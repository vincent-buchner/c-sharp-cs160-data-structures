namespace cs160;

using System.Collections.Generic;

public class HashTable<K, V>
{

    private int numOfBuckets;
    private List<KeyValuePair<K, V>>[] buckets;
    public int Size { get; set; }
    public HashTable(int numOfBuckets)
    {

        this.numOfBuckets = numOfBuckets;
        buckets = new List<KeyValuePair<K, V>>[numOfBuckets];
        this.Size = 0;

    }

    /// <summary>
    /// Checks to see if the given key is inside the table.
    /// </summary>
    /// <param name="key">The given key to search for</param>
    /// <returns>A boolean value on whether or not the key was found. If true, the table contains the key.</returns>
    /// <exception cref="Exception">Throws an error if a null key is given</exception>
    public bool Contains(K key) {

        // If the key is null, throw an error
        if (key == null) throw new Exception("Can not hash a null key.");

        // Hash the key to get an index of the bucket
        int hash = HashingFunction(key);

        // Get the bucket with the hash index
        List<KeyValuePair<K, V>> bucket = buckets[hash];

        // If the bucket is null, then there's nothing to get
        if (bucket == null) return false;
        
        // For each item in the bucket, check to see if it's the item we're looking for
        foreach (KeyValuePair<K, V> item in bucket)
        {
            // If it's the item we're looking for return true
           if (item.Key.Equals(key)) return true;
        }

        // Otherwise, if the key was never found return false
        return false;
    }

    /// <summary>
    /// Gets all the key values as a list
    /// </summary>
    /// <returns>A list of key/value pairs</returns>
    public List<KeyValuePair<K, V>> GetAllKeyValues()
    {

        // Create a return list to append to
        List<KeyValuePair<K, V>> returnList = new List<KeyValuePair<K, V>>();

        // For each bucket in the buckets
        foreach (List<KeyValuePair<K, V>> bucket in buckets)
        {

            // If the bucket isn't null
            if (bucket != null)
            {
                // For each kv in the bucket, add it to the return list
                foreach (KeyValuePair<K, V> item in bucket)
                {
                    returnList.Add(item);
                }
            }
        }

        // Return the return list
        return returnList;
    }

    /// <summary>
    /// Get the value given the key
    /// </summary>
    /// <param name="key">The name of the get whose value you wish to get</param>
    /// <returns>Returns the value</returns>
    /// <exception cref="Exception">Throws an error if the key is null</exception>
    public V? GetValue(K key)
    {
        // If the key is null, throw an error
        if (key == null) throw new Exception("Can not hash a key that is null");

        // Get the hash index of the given string
        int hash = HashingFunction(key);

        // Get the bucket of the of the hash
        List<KeyValuePair<K, V>> bucket = buckets[hash];

        // For each value in bucket, return the value if found
        foreach (KeyValuePair<K, V> item in bucket)
        {
            // If the key is equal to the given key, return the value
            if (item.Key.Equals(key)) return item.Value;
        }

        // Return the default V value
        return default;
    }

    /// <summary>
    /// Updates the given key value with the value given
    /// </summary>
    /// <param name="key">The name of the key in which value to update</param>
    /// <param name="newValue">The new value to replace to the key value</param>
    /// <returns>Returns a boolean value on whether the update was successful. If true, the update was successful.</returns>
    public bool Update(K key, V newValue)
    {
        // If the key is null, we can't update it
        if (key == null)
        {
            return false;
        }

        // Otherwise, has the key
        int hash = HashingFunction(key);

        // Get the bucket
        List<KeyValuePair<K, V>> bucket = buckets[hash];

        // If the bucket is null, we can't update anything
        if (bucket == null) return false;

        // For each bucket in the buckets
        for (int i = 0; i < bucket.Count; i++)
        {

            // If the current key is the given key, we set a new pair
            if (bucket[i].Key.Equals(key))
            {

                bucket[i] = new KeyValuePair<K, V>(key, newValue);

                return true;

            }
        }

        // Otherwise, we never found the key, so nothing is updated
        return false;

    }

    /// <summary>
    /// Removes all the pairs inside the table
    /// </summary>
    public void RemoveAll()
    {

        // Go through each bucket and clear it
        foreach (List<KeyValuePair<K, V>> bucket in buckets)
        {
            if (bucket != null) bucket.Clear();
        }

        // Reset the size
        Size = 0;
    }

    /// <summary>
    /// Deletes the the key/value pair with respect to the matching given key in the table
    /// </summary>
    /// <param name="key">The key of the pair to be removed</param>
    /// <returns>A boolean value if on whether the item was removed. If true, removal was successful</returns>
    /// <exception cref="Exception">The given key can not be null</exception>
    public Boolean Delete(K key)
    {
        // If the key is null, we can not hash it
        if (key == null)
        {
            throw new Exception("Cannot hash a null key");
        }

        int hash = Math.Abs(key.GetHashCode() % numOfBuckets);

        List<KeyValuePair<K, V>> bucket = buckets[hash];

        // If the bucket is empty, return false
        if (bucket == null)
        {
            return false;
        }

        // If there is NOT an item that exists, return false
        if (!bucket.Exists(item => item.Key.Equals(key)))
        {
            return false;

            // Otherwise, an item does exists and we need to remove it
        }
        else
        {

            // Remove all elements with that given key, should be only ONE
            bucket.RemoveAll(item => item.Key.Equals(key));

            // Decrease size and return true
            Size -= 1;
            return true;
        }
    }

    /// <summary>
    /// Creates a new key/value pair within the table
    /// <param name="key">The key identify for the value</param>
    /// <param name="value">The value stored in the table that's accessible with the given key</param>
    /// </summary>
    /// <returns>A boolean value on whether the key/value was added or not. If true, item was added. 
    /// Otherwise, item already exists in table.</returns>
    public bool Add(K key, V value)
    {
        // Find the bucket that the item should go into.
        int indexOfTable = HashingFunction(key);

        // Get the bucket and create a pair
        List<KeyValuePair<K, V>> bucket = buckets[indexOfTable];
        KeyValuePair<K, V> kvpToAdd = new KeyValuePair<K, V>(key, value);

        // If the bucket is empty, create a new node at that position and give it the values
        if (bucket == null)
        {
            buckets[indexOfTable] = new List<KeyValuePair<K, V>> { kvpToAdd };
        }

        // Otherwise, check if it exists and if not, add it
        else
        {
            if (bucket.Exists(item => item.Key.Equals(key))) return false;

            bucket.Add(kvpToAdd);
        }

        // Increase the size and return true
        Size += 1;
        return true;

    }

    /// <summary>
    /// Hashes the given generic to an index that's within the scope of the number of buckets.
    /// </summary>
    /// <param name="key">The key to hash to an index</param>
    /// <returns>An integer that's within the range of the number of buckets; acts as an index</returns>
    /// <exception cref="Exception">Throws an error if the given key is null</exception>
    private int HashingFunction(K key)
    {

        // If the key is null, we can not hash it
        if (key == null)
        {
            throw new Exception("Cannot hash a null key");
        }

        // Otherwise, get the hash of the value
        int hash = Math.Abs(key.GetHashCode() % numOfBuckets);

        // Return the hash
        return hash;

    }
}
