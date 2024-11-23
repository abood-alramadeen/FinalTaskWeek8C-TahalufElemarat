// See https://aka.ms/new-console-template for more information

//Exercise 1
//Create generic class to represent generic List and create
//method to add elements to and one another to display
//the first element of. And then make meaningful execution in main.




/*
 
 
 
 using System;
using System.Collections.Generic;

namespace GenericListExample
{
    public class GenericList<T>
    {
        private List<T> items = new List<T>();

        public void AddElement(T element)
        {
            items.Add(element);
        }

        public T GetFirstElement()
        {
            if (items.Count > 0)
                return items[0];
            throw new InvalidOperationException("The list is empty.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            intList.AddElement(20);
            intList.AddElement(40);
            Console.WriteLine("First element in integer list: " + intList.GetFirstElement());

            GenericList<string> stringList = new GenericList<string>();
            stringList.AddElement("Abood");
            stringList.AddElement("talal");
            Console.WriteLine("First element is string list: " + stringList.GetFirstElement());
        }
    }
}


 
 */


/////////////////////////////////////////////////////////////////////////////////////////////
///
//Exercise 2:
//Append what you read from text document 1 to text document 2 and calculate total
//numbers of words in text document 2 using lambda expression or LINQ.

/*
 
 using System;
using System.IO;
using System.Linq;

namespace TextDocumentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string textDoc1Path = "TextDocument1.txt";
            string textDoc2Path = "TextDocument2.txt";

            string text1 = File.ReadAllText(textDoc1Path);

            File.AppendAllText(textDoc2Path, text1);

            string text2 = File.ReadAllText(textDoc2Path);

            int wordCount = text2.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Count();

            Console.WriteLine($"Total number of words in {textDoc2Path}: {wordCount}");
        }
    }
}

 
 
 
 
 */


////////////////////////////////////////////////////////////////////////////////////////////


/*
 Exercise 3
Create a city class to represent the city name and the city region. 
Create a school class to represent the school’s name and the space.
Create a teacher class to represent the teacher’s name and teacher Id.
 Display City’s schools and school’s teachers in organized way by using LINQ and feel free in adding the appropriate properties.
 Display the school information that has the highest number of teachers.




/////the answer ////




using System;
using System.Collections.Generic;
using System.Linq;

namespace CitySchoolTeacherExample
{
    public class City
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public List<School> Schools { get; set; }
    }

    public class School
    {
        public string Name { get; set; }
        public int Space { get; set; }
        public List<Teacher> Teachers { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>
            {
                new City
                {
                    Name = "Amman",
                    Region = "Central",
                    Schools = new List<School>
                    {
                        new School
                        {
                            Name = "jubaiha school",
                            Space = 450,
                            Teachers = new List<Teacher>
                            {
                                new Teacher { Name = " abdalrahman", Id = 1 },
                                new Teacher { Name = " talal", Id = 2 }
                            }
                        },
                        new School
                        {
                            Name = "Modern School",
                            Space = 700,
                            Teachers = new List<Teacher>
                            {
                                new Teacher { Name = " basma", Id = 3 }
                            }
                        }
                    }
                },
                new City
                {
                    Name = "Irbid",
                    Region = "Northern",
                    Schools = new List<School>
                    {
                        new School
                        {
                            Name = "Irbid Primary School",
                            Space = 400,
                            Teachers = new List<Teacher>
                            {
                                new Teacher { Name = "Mr. Omar", Id = 4 },
                                new Teacher { Name = "Ms. Salma", Id = 5 },
                                new Teacher { Name = "Mr. Nasser", Id = 6 }
                            }
                        }
                    }
                }
            };

            foreach (var city in cities)
            {
                Console.WriteLine($"City: {city.Name}, Region: {city.Region}");
                foreach (var school in city.Schools)
                {
                    Console.WriteLine($"\tSchool: {school.Name}, Space: {school.Space}");
                    foreach (var teacher in school.Teachers)
                    {
                        Console.WriteLine($"\t\tTeacher: {teacher.Name}, ID: {teacher.Id}");
                    }
                }
            }

            var schoolWithMostTeachers = cities
                .SelectMany(city => city.Schools)
                .OrderByDescending(school => school.Teachers.Count)
                .FirstOrDefault();

            Console.WriteLine("\nSchool with the highest number of teachers:");
            Console.WriteLine($"School: {schoolWithMostTeachers.Name}, Teachers Count: {schoolWithMostTeachers.Teachers.Count}");
        }
    }
}




 
 */