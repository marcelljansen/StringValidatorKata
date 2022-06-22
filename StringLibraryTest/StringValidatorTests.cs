using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class StringValidatorTests
    {
        private StringLibrary? library;

        [TestMethod]
        public void CheckIfValidateMethodExists_MethodExists_TakesTwoStringParameter()
        {
            library = new StringLibrary();
            library.Validate("(This looks great!)", "()");
        }

        [TestMethod]
        public void CheckIfStringIsBalanced_IsBalanced_ReturnsTrue()
        {
            library = new StringLibrary();
            bool result = library.Validate("(This looks great!)", "()");
            Assert.IsTrue(result);
        }
    }
}