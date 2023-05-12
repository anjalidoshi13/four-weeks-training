using System.ComponentModel;
namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }
    public class StringToIntProcessor : IProcessor<string, int>
    {
        public int Process(string input)
        {
            return input.Length;
        }
    }
    public class DoubleToStringProcessor : IProcessor<double, string>
    {
        public string Process(double input)
        {
            return input.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Covariance example: StringToIntProcessor can be used as an IProcessor<object, int>
            IProcessor<string, int> intProcessor = new StringToIntProcessor();
            int result = intProcessor.Process("hello");
            Console.WriteLine($"String length: {result}");
            // Contravariance example: IProcessor<string, int> can be used as an IProcessor<object, int>
            IProcessor<string, int> contravariantProcessor = new StringToIntProcessor();
            int length = contravariantProcessor.Process("hello");
            Console.WriteLine($"String length: {length}");
            // Covariance example: DoubleToStringProcessor can be used as an IProcessor<double, object>
            IProcessor<double, string> stringProcessor = new DoubleToStringProcessor();
            object str = stringProcessor.Process(3.14);
            Console.WriteLine($"String representation of 3.14: {str}");
        }
    }
}