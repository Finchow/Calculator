using Calculator.Classes;
using System.Xml.Serialization;

namespace Calculator.Pages
{
    public partial class CalculatorPage
    {
        private string Equation { get; set; } = string.Empty;
        private string Answer { get; set; } = string.Empty;

        private readonly string[] operators = { "^", "/", "*", "+", "-", "(", ")", "." };
        private readonly string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};

        private void Calculate()
        {
            Classes.Calculator calculator = new();

            Answer = calculator.Calculate(Equation);
        }

        private void Delete()
        {
            if (string.IsNullOrEmpty(Answer))
            {
                var length = Equation.Length;
                Equation.Remove(length - 1);
            }
            else { Answer = string.Empty; }
            StateHasChanged();
        }

        private void Clear()
        {
            Equation = string.Empty;
            Answer = string.Empty;
        }

        private void Reset()
        {
            Equation = Answer;
            Answer = string.Empty;
        }

        private void AddToString(string item)
        {
            Equation += item;
        }

    }
}