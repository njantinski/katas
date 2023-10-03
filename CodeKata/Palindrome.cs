namespace CodeKata
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int digits = NumDigits(x);
            if (digits < 2 && x < 0)
                return false;
            if (digits < 2 && x > 0)
                return true;

            while (digits > 1)
            {
                int firstDigit = (int)(x / Math.Pow(10, digits - 1));
                if (x < 0)
                    firstDigit *= -1;

                var lastDigit = x % 10;

                if (firstDigit != lastDigit)
                    return false;

                x /= 10;
                x = x % (int)Math.Pow(10, digits - 2);
                digits -= 2;

                if (x == 0)
                    return true;
                if (x < 10 && digits == 1)
                    return true;
                if (x < 10 && digits > 1)
                    return false;
            }
            return true;
        }

        public int NumDigits(int n)
        {
            int result = 0;
            if (n < 0)
                n *= -1;
            while (n > 0)
            {
                n = n / 10;
                result++;
            }
            return result;
        }
    }
}
