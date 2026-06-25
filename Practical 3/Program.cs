using System.Xml.Linq;

namespace XML_Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument pd = XDocument.Load("C:\\Users\\SXC_Student\\Desktop\\Exam\\XML Queries\\XML Queries\\Product Data.xml");
            var products = pd.Elements();

            var pr = from x in products.Elements("Product")
                     where (DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yyyy", null) > DateTime.ParseExact("01-04-2020", "dd-mm-yyyy", null))
                     select new
                     {
                         name = (string)x.Element("name"),
                         date = (string)x.Element("dom")
                     };
            Console.WriteLine("Entries after 1st April 2020");
            foreach(var p in pr)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            //pr = from x in products.Elements("Product")
            //     where ((int)x.Element("price") > 40000 &&
            //        (DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yyyy", null) > DateTime.ParseExact("01-04-2020", "dd-mm-yyyy", null))
            //     select new {
            //         name = (string)x.Element("name"),
            //         date = (string)x.Element("dom"),
            //         price = (int)x.Element("price")
            //     };

            var pr2 = from x in products.Elements("Product") where ((int)x.Element("price") > 40000 && DateTime.ParseExact((string)x.Element("dom"), "dd-MM-yyyy", null) > DateTime.ParseExact("01-04-2020", "dd-MM-yyyy", null)) select new { name = (string)x.Element("name"), date = (string)x.Element("dom"), price = (int)x.Element("price") };




            foreach (var p in pr)
            {
                Console.WriteLine(p);
            }
        }
    }
}
