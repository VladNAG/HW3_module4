using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                var empljoin = from empl in db.Employees
                               join of in db.Offices on empl.OfficeId equals of.OfficeId
                               join tit in db.Titles on empl.TitleId equals tit.TitleId into gj
                               from x in gj.DefaultIfEmpty()
                               select new
                               {
                                   Office = of.Ttitle,
                                   title = x.Name,
                                   Employee = empl.FirstName,
                                   EmployeeName = empl.LastName
                               };

                await db.SaveChangesAsync();
                foreach (var title in empljoin)
                {
                    Console.WriteLine($"{title.Office} {title.title},{title.Employee}-{title.EmployeeName}");
                }

                Console.WriteLine("Task 1 solved");
            }

            using (CompaniContext db = new CompaniContext())
            {
                var empl = db.Employees.Select(p => p.HiredDate).ToList();
                await db.SaveChangesAsync();
                foreach (var title in empl)
                {
                    var result = DateTime.Now - title;
                    Console.WriteLine(result.Days);
                }

                Console.WriteLine("Task 2 solved");
            }

            using (CompaniContext db = new CompaniContext())
            {
                Office office1 = new Office { Ttitle = "b1", Location = "Flor-0" };
                Title title1 = new Title { Name = "archetector" };
                Employee employee1 = new Employee
                {
                    FirstName = "Artem",
                    LastName = "Illin",
                    HiredDate = new DateTime(2006, 03, 20),
                    DateOfBirth = new DateTime(1996, 03, 20),
                    Office = office1,
                    Title = title1
                };
                Project project1 = new Project { Name = "007", StartDate = new DateTime(2006, 03, 25), Budget = 2000 };
                EmployeeProject employeeProject1 = new EmployeeProject { StartDate = new DateTime(2005, 03, 20), Rate = 154462, Project = project1, Employee = employee1 };
                db.Employees.Add(employee1);

                // добавляем их в бд
                db.Add(employeeProject1);
                await db.SaveChangesAsync();

                Console.WriteLine("Task 4 solved");
            }

            using (CompaniContext db = new CompaniContext())
            {
                Title? title2 = db.Titles.FirstOrDefault(p => p.Name == "developer");
                title2.Name = "admin2";
                Title? title1 = db.Titles.FirstOrDefault(p => p.Name == "HR");
                title1.Name = "HR2";
                db.Titles.UpdateRange(title2, title1);
                var titles = db.Titles.ToList();
                foreach (var title in titles)
                {
                    Console.WriteLine($"{title.TitleId} {title.Name}");
                }

                await db.SaveChangesAsync();
                Console.WriteLine("Task 3 solved");
            }

            using (CompaniContext db = new CompaniContext())
            {
                var titles = db.Employees.ToList();
                foreach (var title in titles)
                {
                    Console.WriteLine($"{title.TitleId} {title.FirstName}");
                }

                Employee? title2 = db.Employees.FirstOrDefault(p => p.FirstName == "Alice");
                if (title2 != null)
                {
                    db.Employees.Remove(title2);
                }

                await db.SaveChangesAsync();
                foreach (var title in titles)
                {
                    Console.WriteLine($"{title.TitleId} {title.FirstName}");
                }

                Console.WriteLine("Task 5 solved");
            }

            using (CompaniContext db = new CompaniContext())
            {
                var grup = db.Employees.GroupBy(p => p.Title.Name).ToList();

                await db.SaveChangesAsync();
                foreach (var title in grup)
                {
                    if (title.Key.Contains("a"))
                    {
                        Console.WriteLine("name contain a");
                    }
                    else
                    {
                        Console.WriteLine(title.Key);
                    }
                }

                Console.WriteLine("Task 6 solved");
            }

            Console.Read();
        }
    }
}