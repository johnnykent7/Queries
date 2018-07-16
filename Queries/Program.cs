
using System.Linq;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var querru =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { authorName = a.Name, Courses = g.Count() };

            foreach(var c in querru)
            {
                System.Console.WriteLine(c.authorName + ": " + c.Courses);
            }
        }
    }
}
