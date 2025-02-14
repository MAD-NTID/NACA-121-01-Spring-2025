public interface ICharacter
{
    // Interfaces do NOT have body
    /*
        The parameter ICharacter accepts any object that inherits
        from ICharacter.

        In the example of Quadrupeds animals, then this means that 
        this method will accept, for example, 
        cat, dog, cow, bull, tiger, lion - because they inherit from IQuadrupeds
    */
    public void Attack(ICharacter target);

    public void Defend();
}