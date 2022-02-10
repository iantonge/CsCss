namespace CsCss.Values.Calc
{
    public abstract class CalcValue<T> : Value where T : Value
    {
        protected CalcValue(string v) : base(v)
        {
        }
    }
}
