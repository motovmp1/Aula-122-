using System;
using System.Threading.Tasks;

namespace Aula120Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("That is awesome!");

            Post p1 = new Post
                (
                DateTime.Parse("21/06/2018 13:45:44"),
                "Travel to New Zealand",
                "I am going to visit country",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);





        }
    }
}
