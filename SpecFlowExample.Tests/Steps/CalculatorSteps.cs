using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowExample.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.EnterNumber(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            Assert.Equal(expected, _result);
        }
    }

    public class Calculator
    {
        private int _firstNumber;
        private int _secondNumber;

        public void EnterNumber(int number)
        {
            if (_firstNumber == 0)
                _firstNumber = number;
            else
                _secondNumber = number;
        }

        public int Add()
        {
            return _firstNumber + _secondNumber;
        }
    }
}

