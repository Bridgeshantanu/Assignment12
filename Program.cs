namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ram", PhoneNumber = 2010304120, Address = "123 Main St", Age = 15 },
            new Student { Id = 2, Name = "Raj", PhoneNumber = 9458125245, Address = "456 Elm St", Age = 18 },
            new Student { Id = 3, Name = "Manoj", PhoneNumber = 7040103526, Address = "789 Oak St", Age = 12 },
            
        };
            
            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Phone: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }
           
            var ageFilteredStudents = students.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
            Console.WriteLine("\nStudents with Age between 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            
            var sortedStudents = students.OrderByDescending(s => s.Age).ToList();
            Console.WriteLine("\nStudents Sorted by Age in Descending Order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
           
            var studentsByAddress = students.GroupBy(s => s.Address);
            Console.WriteLine("\nStudents by Address:");
            foreach (var group in studentsByAddress)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }

            var firstThreeStudents = students.Take(3).ToList();
            Console.WriteLine("\nFirst Three Students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            
            string searchName = "Raj";
            var foundStudent = students.FirstOrDefault(s => s.Name == searchName);
            if (foundStudent != null)
            {
                Console.WriteLine($"\nStudent with Name '{searchName}' Found: ID: {foundStudent.Id}, Age: {foundStudent.Age}");
            }
            else
            {
                Console.WriteLine($"\nStudent with Name '{searchName}' Not Found.");
            }
        }
    }
}