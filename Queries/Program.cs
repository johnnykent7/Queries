
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var querry = context.Courses
                .Where(c => c.FullPrice.ToString().Contains("9"))
                .OrderByDescending (c => c.FullPrice);
                


            foreach(var c in querry)
            {
                System.Console.WriteLine(c.FullPrice);
            }
                
        }
    }
}
