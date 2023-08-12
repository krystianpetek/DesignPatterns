namespace AbstractFactory.Contracts;

public interface IAlphabetFactory
{
    public ILetter CreateLetters();
    public INumber CreateNumbers();
}
