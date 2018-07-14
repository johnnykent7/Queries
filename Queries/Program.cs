
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var querry = from c in context.Courses
                         group c by c.AuthorId
                         into g
                         select g;

            foreach(var ai in querry)
            {
                System.Console.WriteLine(ai.Key);
                foreach(var gi in ai)
                {
                    System.Console.WriteLine("curs name:"+gi.Name+"description name:"+gi.Description);
                }
            }
        }
    }
}
