using System.Net.Http.Headers;
using System.Xml.Linq;

namespace XML_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument pd = XDocument.Load("C:\\Users\\SXC_Student\\source\\repos\\XML Demo\\XML Demo\\Product Data.xml");
            var products = pd.Elements();

            //Print all products in the XML file to the console
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ToString());
            //    Console.WriteLine();
            //}

            var result = products.Elements("Product").Where(p => (int)p.Element("price") > 55000)
                .Select(p => new
                {
                    PID = p.Element("pid").Value,
                    Name = p.Element("name").Value,
                    Price = p.Element("price").Value,
                    Dom = p.Element("dom").Value,
                });
            foreach (var prod in result)
            {
                Console.WriteLine(prod.ToString());
            }

            var result2 = products.Elements("Product").GroupBy(p => p.Element("dom").Value)
                .Select(g => new
                {
                    Dom = g.Key,
                    Count = g.Count()
                });
            foreach (var group in result2)
            {
                Console.WriteLine($"DOM: {group.Dom}, Count: {group.Count}");
            }
        }
    }
}
