namespace CsCss.Values.Numeric.Calc
{
    public abstract class CalcValue<T> : NumericValue where T : NumericValue
    {
        protected CalcValue(string v) : base(v)
        {
        }
    }
}
