using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class StringValidatorTests
    {
        private StringLibrary? library;

        [TestInitialize]
        public void TestInitialize()
        {
            library = new StringLibrary();
        }

        [TestMethod]
        public void CheckIfValidateMethodExists_MethodExists_TakesTwoStringParameter()
        {
            library.Validate("(This looks great!)", "()");
        }

        [TestMethod]
        public void CheckIfStringIsBalanced_IsBalanced_ReturnsTrue()
        {
            bool result = library.Validate("(This looks great!)", "()");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfStringIsBalanced_IsUnbalanced_ReturnsFalse()
        {
            bool result = library.Validate("(This looks bad!", "()");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfStringIsBalanced2_IsBalanced_ReturnsTrue()
        {
            bool result = library.Validate("(This [looks] great!)", "()[]");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfStringIsBalanced2_IsUnbalanced_ReturnsFalse()
        {
            bool result = library.Validate("(This [looks) bad!]", "()[]");
            Assert.IsFalse(result);
        }

    }
}