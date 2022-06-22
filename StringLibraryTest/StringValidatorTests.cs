using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class StringValidatorTests
    {
        private StringLibrary? library;

        [TestMethod]
        public void CheckIfValidateMethodExists_MethodExists()
        {
            library = new StringLibrary();
            library.Validate();
        }
    }
}