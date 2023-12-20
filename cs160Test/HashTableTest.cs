namespace cs160Test;

[TestClass]
public class HashTableTest
{

    private static cs160.HashTable<string, int> testHashTable1 = new cs160.HashTable<string, int>(17);

    [ClassInitialize]
    public static void InitializeTestSets(TestContext context)
    {

        testHashTable1.Add("aaa", 111);
        testHashTable1.Add("bbb", 222);
        testHashTable1.Add("ccc", 222);
        testHashTable1.Add("ddd", 111);
        testHashTable1.Add("eee", 333);
    }

    [TestCleanup]
    public void CleanupTestTable()
    {
        testHashTable1.RemoveAll();

        testHashTable1.Add("aaa", 111);
        testHashTable1.Add("bbb", 222);
        testHashTable1.Add("ccc", 222);
        testHashTable1.Add("ddd", 111);
        testHashTable1.Add("eee", 333);

    }

    [TestMethod]
    public void TestGetAllKeyValues()
    {
        Assert.AreEqual(5, testHashTable1.GetAllKeyValues().Count);
    }

    [TestMethod]
    public void TestUpdateAndGetHashTable()
    {
        Assert.IsTrue(testHashTable1.Update("aaa", 555));
        Assert.AreEqual(5, testHashTable1.Size);
        Assert.AreEqual(testHashTable1.GetValue("aaa"), 555);
    }

    [TestMethod]
    public void TestCreateEmptyHashTable()
    {
        cs160.HashTable<string, int> myHashTable = new cs160.HashTable<string, int>(17);

        Assert.IsTrue(myHashTable.Size == 0);
    }

    [TestMethod]
    public void TestContainHashTable(){
        Assert.IsTrue(testHashTable1.Contains("aaa"));
        Assert.IsTrue(testHashTable1.Contains("bbb"));
        Assert.IsTrue(testHashTable1.Contains("ccc"));
        Assert.IsFalse(testHashTable1.Contains("zzz"));
    }

    [TestMethod]
    public void TestAddToHashTable()
    {
        cs160.HashTable<string, int> myHashTable = new cs160.HashTable<string, int>(17);

        Assert.IsTrue(myHashTable.Add("aaa", 1));
        Assert.IsTrue(myHashTable.Add("bbb", 2));
        Assert.IsTrue(myHashTable.Add("ccc", 2));
        Assert.IsTrue(myHashTable.Add("ddd", 3));
        Assert.IsTrue(myHashTable.Add("eee", 3));

        Assert.IsFalse(myHashTable.Add("eee", 4));
        Assert.AreEqual(5, myHashTable.Size);
    }

    [TestMethod]
    public void TestRemoveFromHashTable()
    {
        cs160.HashTable<string, int> myHashTable = new cs160.HashTable<string, int>(17);

        myHashTable.Add("aaa", 1);
        myHashTable.Add("bbb", 2);
        myHashTable.Add("ccc", 2);
        myHashTable.Add("ddd", 3);
        myHashTable.Add("eee", 3);

        Assert.IsTrue(myHashTable.Delete("aaa"));
        Assert.IsFalse(myHashTable.Delete("aaa"));

        Assert.IsTrue(myHashTable.Delete("bbb"));
        Assert.IsFalse(myHashTable.Delete("bbb"));

        Assert.IsFalse(myHashTable.Delete("yyy"));

        Assert.AreEqual(3, myHashTable.Size);
    }

    [TestMethod]
    public void TestRemoveAllFromTable()
    {
        cs160.HashTable<string, int> myHashTable = new cs160.HashTable<string, int>(17);

        myHashTable.Add("aaa", 1);
        myHashTable.Add("bbb", 2);
        myHashTable.Add("ccc", 2);
        myHashTable.Add("ddd", 3);
        myHashTable.Add("eee", 3);

        myHashTable.RemoveAll();

        Assert.IsFalse(myHashTable.Delete("aaa"));

        Assert.IsFalse(myHashTable.Delete("bbb"));

        Assert.IsFalse(myHashTable.Delete("yyy"));

        Assert.AreEqual(0, myHashTable.Size);
    }
}