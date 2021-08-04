using SQLiteDe.Models;
using System;
using System.Linq;

namespace SQLiteDe
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "https://blog.csdn.net/lms99251",Remark="123", Remark1="232" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                //db.Blogs.Where(x => x.Url == "");
                foreach (var blogin in db.Blogs)
                {
                    Console.WriteLine(" - {0}-", blogin.Url);
                }

                Console.ReadKey();
            }
        }
    }
}
