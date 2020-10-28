using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkList list = new LinkList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Assert.IsTrue(list.Search(30));
        }
        [TestMethod]
        public void TestMethod2()
        {
            LinkList list = new LinkList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Insert(3, 40);
            Assert.IsTrue(list.Search(40));
        }
        [TestMethod]
        public void TestMethod3()
        {
            LinkList list = new LinkList();
            list.Append(56);
            list.Append(30);
            list.Append(70);            
            list.Insert(3, 40);
            list.DeleteAnyNode(3);
            Assert.AreEqual(3, list.Size());
        }
    }
}