
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var querry =
                from c in context.Courses
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = a.Name };

            foreach(var p in querry)
            {
                System.Console.WriteLine(p.CourseName+" "+p.AuthorName);
            }




        }
    }
}
