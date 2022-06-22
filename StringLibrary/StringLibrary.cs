namespace UtilityLibraries;

public class StringLibrary
{
    public Boolean Validate(string stringToValidate, string characterPairs)
    {
        string openingCharacters = new(characterPairs.Where((x, i) => i % 2 == 0).ToArray());
        string closingCharacters = new(characterPairs.Where((x, i) => i % 2 != 0).ToArray());

        Stack<char> openingCharactersInString = new Stack<char>();

        foreach (char c in stringToValidate)
        {
            if (openingCharacters.Contains(c))
                openingCharactersInString.Push(c);
            else if (closingCharacters.Contains(c))
                openingCharactersInString.Pop();
        }

        if(openingCharactersInString.Count == 0)
            return true;
        else
            return false;
    }
}