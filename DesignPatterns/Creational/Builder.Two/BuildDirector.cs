using Builder.Two.Contracts;

namespace Builder.Two;

public class BuildDirector
{
    private IBuilder _builder;

    public void SetBuilder(IBuilder value) => _builder = value;
    public void BuildPoorProduct() => _builder.BuildA();
    public void BuildRichProduct()
    {
        _builder.BuildA();
        _builder.BuildB();
        _builder.BuildC();
    }
}
