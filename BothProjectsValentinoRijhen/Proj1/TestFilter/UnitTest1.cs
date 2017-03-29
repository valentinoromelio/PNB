using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/** Valentino Rijhen
 * 0615310513
 */
namespace TestFilter
{
    [TestClass]
    public class UnitTest1
    {
        Proj1.Program program = new Proj1.Program();

        [TestMethod]
        public void TestNoItemsIsTrueWithoutPartA()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "cdef", "def"});
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestItemsIsTrueWithPartA()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "abc", "def" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestNoItemsIsTrueWithoutPartB()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "abc", "dedf" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestItemsIsTrueWithPartB()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "abc", "def" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestItemsIsTrueBButReturnValueBiggerThanAllowedSize()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef7", "abc", "def" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestItemsIsTrueButSubpartsLessThanAllowedSize()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "ab", "ef" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestItemsIsTrueButSubpartsBiggerThanAllowedSize()
        {
            HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "abcd", "cdef" });
            var result = program.Filter(ListToBeFiltered);
            Assert.IsTrue(result.Count == 0);
        }
    }
}
