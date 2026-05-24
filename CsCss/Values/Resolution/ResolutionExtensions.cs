using CsCss.Values.Resolution;

namespace CsCss;

public static class ResolutionExtensions
{
    public static ResolutionValue Dpi(this double input) => new(input, ResolutionUnit.Dpi);

    public static ResolutionValue Dpi(this int input) => new(input, ResolutionUnit.Dpi);

    public static ResolutionValue Dpcm(this double input) => new(input, ResolutionUnit.Dpcm);

    public static ResolutionValue Dpcm(this int input) => new(input, ResolutionUnit.Dpcm);

    public static ResolutionValue Dppx(this double input) => new(input, ResolutionUnit.Dppx);

    public static ResolutionValue Dppx(this int input) => new(input, ResolutionUnit.Dppx);

    public static ResolutionValue X(this double input) => new(input, ResolutionUnit.X);

    public static ResolutionValue X(this int input) => new(input, ResolutionUnit.X);
}
