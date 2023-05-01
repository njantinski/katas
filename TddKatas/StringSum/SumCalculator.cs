using System.Text.RegularExpressions;

namespace TddKatas
{
    public class SumCalculator
    {
        public string Sum(string v1, string v2)
        {
            var number1 = int.Parse(Regex.Replace(v1, "[^0-9]", ""));
            var number2 = int.Parse(Regex.Replace(v2, "[^0-9]", ""));
            return (number1 + number2).ToString();
        }


    }
}
