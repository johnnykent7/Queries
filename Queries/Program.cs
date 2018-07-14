
using System.Linq;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var contex = new PlutoContext();
            var querry =
                    contex.Courses
                    .GroupBy(c => c.Level);

            foreach(var c in querry)
            {
                System.Console.WriteLine(c.Key);
                foreach(var  b in c)
                {
                    System.Console.WriteLine(b.Name);
                }
            }




        }
    }
}
