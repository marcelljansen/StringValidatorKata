namespace UtilityLibraries;

public class StringLibrary
{
    public Boolean Validate(string stringToValidate, string characterPairs)
    {
        Stack<char> openingCharactersInString = new Stack<char>();
        Dictionary<char, char> matchingCharacterPairs = new Dictionary<char, char>();
        char matchingClosingCharacter;

        for (int i = 0; i < characterPairs.Length - 1; i+=2)
        {
            matchingCharacterPairs.Add(characterPairs[i], characterPairs[i+1]);
        }

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