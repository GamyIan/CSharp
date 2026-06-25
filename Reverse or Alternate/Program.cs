namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> numbers = new List<string>() 
            { 
                "One","Two","Three","Four","Five"
            };

            foreach(var num in numbers)
            {
                int index = numbers.IndexOf(num);

                if (index % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
