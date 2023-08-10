using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_module4
{
    public static class Starter
    {
        public static async Task Start()
        {
            using (CompaniContext db = new CompaniContext())
            {
                /*db.Database.EnsureDeleted();
                db.Database.EnsureCreated();*/

                // создаем два объекта User
                Console.WriteLine("Created");

                /*var users = db.Clients.ToList();
                Console.WriteLine("LIst Obects:");
                foreach (Client u in users)
                {
                    Console.WriteLine($"{u.FirstName}.{u.LastName} --{u.Country}-{u.ClientId}");
                }*/
            }

            Console.Read();
        }
    }
}