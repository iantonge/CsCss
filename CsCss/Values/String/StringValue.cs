namespace CsCss.Values.String
{
    public class StringValue : Value
    {
        public StringValue(string v) : base($"'{v}'") { }

        public static implicit operator StringValue(string value)
        {
            return new StringValue(value);
        }
    }
}
