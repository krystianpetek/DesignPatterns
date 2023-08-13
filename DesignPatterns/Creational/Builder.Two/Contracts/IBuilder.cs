namespace Builder.Two.Contracts;

public interface IBuilder
{
    void BuildA();
    void BuildB();
    void BuildC();
    void Reset();
    void GetProduct();
}
