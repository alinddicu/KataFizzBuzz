namespace KataFizzBuzz.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Execute(10);

            Check.That(result).ContainsExactly("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", " Buzz");
        }
    }
}
