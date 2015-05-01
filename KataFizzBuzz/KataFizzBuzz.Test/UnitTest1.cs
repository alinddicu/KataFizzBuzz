namespace KataFizzBuzz.Test
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenExecuteUntil10ThenReturnCorrect()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Execute(15);

            Check.That(result).ContainsExactly("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz");
        }
    }
}
