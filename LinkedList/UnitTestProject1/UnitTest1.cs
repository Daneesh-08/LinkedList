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
    }
}
