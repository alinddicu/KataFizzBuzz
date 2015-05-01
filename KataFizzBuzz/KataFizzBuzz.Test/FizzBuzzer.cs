namespace KataFizzBuzz.Test
{
    using System.Collections.Generic;
    using System.Globalization;

    public class FizzBuzzer
    {
        public IEnumerable<string> Execute(int limit)
        {
            for (var index = 1; index <= limit; index++)
            {
                if (index % 3 == 0 && index % 5 == 0)
                {
                    yield return "FizzBuzz";
                }
                else if (index % 3 == 0)
                {
                    yield return "Fizz";
                }
                else if (index % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return index.ToString(CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
