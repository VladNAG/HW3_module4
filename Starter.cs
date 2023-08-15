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
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // создаем два объекта User
                Office office1 = new Office { Ttitle = "b2", Location = "Flor-1" };
                Title title1 = new Title { Name = "ReeR" };
                Project project1 = new Project { Name = "Test", StartDate = new DateTime(1996, 03, 20), Budget = 1491 };
                Employee employee1 = new Employee
                {
                    FirstName = "Alice",
                    LastName = "Burda",
                    HiredDate = new DateTime(1996, 03, 20),
                    DateOfBirth = new DateTime(1996, 03, 20),
                    Office = office1,
                    Title = title1
                };
                EmployeeProject employeeProject1 = new EmployeeProject { StartDate = new DateTime(2005, 03, 20), Rate = 154462, Project = project1, Employee = employee1 };
                db.Employees.Add(employee1);

                // добавляем их в бд
                db.Add(employeeProject1);
                await db.SaveChangesAsync();
                Console.WriteLine("Created");

                // получаем объекты из бд и выводим на консоль
                var users = db.Offices.ToList();
                Console.WriteLine("LIst Obects:");
                foreach (Office u in users)
                {
                    Console.WriteLine($"{u.OfficeId}.{u.Ttitle} - {u.Location}");
                }
            }

            Console.Read();
        }
    }
}