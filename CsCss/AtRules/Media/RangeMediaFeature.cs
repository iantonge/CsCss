using CsCss.Values;

namespace CsCss.AtRules.Media;

public sealed class RangeMediaFeature<TValue> : MediaFeature
    where TValue : Value
{
    internal RangeMediaFeature(string name) : base(name) { }

    public MediaQuery Between(TValue min, TValue max) => new($"({min} <= {Name} <= {max})");

    public static MediaQuery operator >=(RangeMediaFeature<TValue> feature, TValue value) => new($"({feature.Name} >= {value})");

    public static MediaQuery operator <=(RangeMediaFeature<TValue> feature, TValue value) => new($"({feature.Name} <= {value})");

    public static MediaQuery operator >(RangeMediaFeature<TValue> feature, TValue value) => new($"({feature.Name} > {value})");

    public static MediaQuery operator <(RangeMediaFeature<TValue> feature, TValue value) => new($"({feature.Name} < {value})");

    public static MediaQuery operator ==(RangeMediaFeature<TValue> feature, TValue value) => new($"({feature.Name} = {value})");

    public static MediaQuery operator !=(RangeMediaFeature<TValue> feature, TValue value) => new($"not ({feature.Name} = {value})");

    public override bool Equals(object? obj) => ReferenceEquals(this, obj);

    public override int GetHashCode() => HashCode.Combine(Name);
}

public sealed class IntegerRangeMediaFeature : MediaFeature
{
    internal IntegerRangeMediaFeature(string name) : base(name) { }

    public MediaQuery Between(int min, int max) => new($"({min} <= {Name} <= {max})");

    public static MediaQuery operator >=(IntegerRangeMediaFeature feature, int value) => new($"({feature.Name} >= {value})");

    public static MediaQuery operator <=(IntegerRangeMediaFeature feature, int value) => new($"({feature.Name} <= {value})");

    public static MediaQuery operator >(IntegerRangeMediaFeature feature, int value) => new($"({feature.Name} > {value})");

    public static MediaQuery operator <(IntegerRangeMediaFeature feature, int value) => new($"({feature.Name} < {value})");

    public static MediaQuery operator ==(IntegerRangeMediaFeature feature, int value) => new($"({feature.Name} = {value})");

    public static MediaQuery operator !=(IntegerRangeMediaFeature feature, int value) => new($"not ({feature.Name} = {value})");

    public override bool Equals(object? obj) => ReferenceEquals(this, obj);

    public override int GetHashCode() => HashCode.Combine(Name);
}
