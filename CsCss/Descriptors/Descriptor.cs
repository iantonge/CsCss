namespace CsCss.Descriptors;

public abstract class Descriptor
{
    private readonly string name;

    protected Descriptor(string name) => this.name = name;

    public override string ToString() => name;
}
