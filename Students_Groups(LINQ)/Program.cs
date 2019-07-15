using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // Multiply array's elements, that are greater than 0
            int[] a = { 1, -2, 6, 0, -7, 8 };
            double mult = MultiplyPositiveElements(a);
            Console.WriteLine(mult);
            #endregion

            #region Task 2 
            // You have two sets - Students(string Name, double Rating, Group group) 
            //and Groups(string Name, string Direction).
            //Print all groups with their average rating and list of students in this group

            List< Student> students = new List<Student>()
            {
                new Student(){ Name = "Bob", Rating = 67, Group = "Lv-101"},
                new Student(){ Name = "Adam", Rating = 73, Group = "Lv-102"},
                new Student(){ Name = "Bill", Rating = 86, Group = "Lv-101"},
                new Student(){ Name = "Nick", Rating = 95, Group = "Lv-103"},
                new Student(){ Name = "Ben", Rating = 69, Group = "Lv-103"},
                new Student(){ Name = "Alice", Rating = 83, Group = "Lv-101"},
                new Student(){ Name = "Marry", Rating = 77, Group = "Lv-103"},
                new Student(){ Name = "John", Rating = 62, Group = "Lv-101"},
                new Student(){ Name = "Dilan", Rating = 90, Group = "Lv-103"},
                new Student(){ Name = "Mike", Rating = 66, Group = "Lv-102"},
                new Student(){ Name = "joe", Rating = 79, Group = "Lv-102"},
                new Student(){ Name = "Suzy", Rating = 82, Group = "Lv-102"}
            };
            
            List<Group> groups = new List<Group>()
            {
                new Group(){ Name = "Lv-101", Direction = "TAQC" },
                new Group(){ Name = "Lv-102", Direction = "MQC" },
                new Group(){ Name = "Lv-103", Direction = "SET" },
            };

            List<GroupWithStudents> grouped = GetGroupsWithStudents(students, groups);

            foreach (var item in grouped)
            {
                Console.WriteLine(@"Group {0} has average rating {1}", item.Name, item.AvgRating);
                foreach (var s in item.Students)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("-----------------------------------------");
            }
            #endregion

            #region Task 3
            //
            string myString = "Я несу гусеня";

            bool b = myString.IsPalindrome();
            Console.WriteLine(b);
             #endregion  

            Console.ReadLine();
        }
        
        public static double MultiplyPositiveElements(int[] a)
        {
            double mult = a.Where(n => n > 0).DefaultIfEmpty().Aggregate((x, y) => x * y);
            return mult;
        }

        public static List<GroupWithStudents> GetGroupsWithStudents(IEnumerable<Student> students, IEnumerable<Group> groups)
        {
            var GroupsWithStudents = groups.GroupJoin(students, g => g.Name, s => s.Group,
                   (gs, sts) => new GroupWithStudents
                   {
                       Name = gs.Name,
                       AvgRating = sts.Average(n => n.Rating),
                       Students = sts.Select(n => n.Name)
                   }
                   ).ToList();
            return GroupsWithStudents;
        }
            
    }
}
      