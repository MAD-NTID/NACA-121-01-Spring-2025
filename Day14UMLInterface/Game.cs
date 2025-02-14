public class Game
{
    private ICharacter[] characters;
    public ICharacter[] Characters
    {
        get { return characters; }
    }
    

    public Game()
    {
        // this means, accept anything that inherits ICharacter
        characters = new ICharacter[10];
    }

    public Game(int capacity)
    {
        // this means, accept anything that inherits ICharacter
        characters = new ICharacter[capacity];
    }

    public void AddCharacter(ICharacter character)
    {
        // Add the character to the array
        for(int i = 0; i < characters.Length; i++)
        {
            if(characters[i] == null)
            {
                characters[i] = character;
                break;
            }
        }
    }

    public void RemoveCharacter(ICharacter character)
    {
        for(int i = 0; i < characters.Length; i++)
        {
            if(characters[i] == character)
            {
                characters[i] = null;
                break;
            }
        }
    }

    // This means, return an array of objects that inherits from ICharacter
    public ICharacter[] GetCharacters()
    {
        return characters;
    }

    public ICharacter GetCharacter(ICharacter character)
    {
        for(int i = 0; i < characters.Length; i++)
        {
            if(characters[i] == character)
            {
                return characters[i];
            }
        }

        return null;
    }
}