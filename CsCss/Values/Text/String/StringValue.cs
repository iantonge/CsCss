namespace CsCss.Values.Text.String
{
    public class StringValue : TextValue
    {
        public StringValue(string v) : base($"'{v}'") { }

        public static implicit operator StringValue(string value)
        {
            return new StringValue(value);
        }
    }
}
