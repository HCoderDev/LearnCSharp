namespace PasswordGenerator
{
    public class GenerateConfig
    {
        public bool IsLowerCase { get; set; }
        public bool IsUpperCase { get; set; }
        public bool IsDigits { get; set; }
        public bool IsSymbols { get; set; }
        public int Length { get; set; }
    }
}
