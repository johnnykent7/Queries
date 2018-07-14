
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var querry = from q in context.Courses
                         where q.Level == 1

                         orderby q.FullPrice descending
                         select q;

            foreach(var p in querry)
            {
                System.Console.WriteLine(p.FullPrice);
            }




        }
    }
}
