namespace PersonalLibraryApp
{
    internal class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(value))
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!int.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }
    }
}