namespace KataFizzBuzz.Test
{
    using System.Collections.Generic;
    using System.Globalization;

    public class FizzBuzzer
    {
        public IEnumerable<string> Execute(int lowEndLimit, int topEndLimit)
        {
            for (var index = lowEndLimit; index <= topEndLimit; index++)
            {
                if (IsFizzBuzz(index))
                {
                    yield return "FizzBuzz";
                }
                else if (IsFizz(index))
                {
                    yield return "Fizz";
                }
                else if (IsBuzz(index))
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return index.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private static bool IsFizzBuzz(int index)
        {
            return IsFizz(index) && IsBuzz(index);
        }

        private static bool IsBuzz(int index)
        {
            return index % 5 == 0 || index.ToString(CultureInfo.InvariantCulture).Contains("5");
        }

        private static bool IsFizz(int index)
        {
            return index % 3 == 0 || index.ToString(CultureInfo.InvariantCulture).Contains("3");
        }
    }
}
