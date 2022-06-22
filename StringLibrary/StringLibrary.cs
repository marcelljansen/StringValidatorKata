namespace UtilityLibraries;

public class StringLibrary
{
    public Boolean Validate(string stringToValidate, string characterPairs)
    {
        Dictionary<char, char> matchingCharacterPairs = new Dictionary<char, char>();
        for (int i = 0; i < characterPairs.Length - 1; i+=2)
        {
            matchingCharacterPairs.Add(characterPairs[i], characterPairs[i+1]);
        }

        char matchingClosingCharacter;
        Stack<char> openingCharactersInString = new Stack<char>();
        foreach (char c in stringToValidate)
        {
            if (matchingCharacterPairs.ContainsKey(c))
            {
                openingCharactersInString.Push(c);
            } 
            else if (matchingCharacterPairs.ContainsValue(c))
            {
                matchingCharacterPairs.TryGetValue(openingCharactersInString.Peek(), out matchingClosingCharacter);

                if (matchingClosingCharacter == c)
                    openingCharactersInString.Pop();
            }
        }

        return openingCharactersInString.Count == 0 ? true: false;
    }
}