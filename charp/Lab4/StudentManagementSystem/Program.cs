namespace StudentManagementSystem
{
    internal class Program
    {
        public static Student TopAvarage(Student[]students )
        {
            Student student = students[0];
            double topavarage=student.CalculateAvarage();
            foreach(var stud in students)
            {
                if (stud.CalculateAvarage() > topavarage)
                {
                    topavarage = stud.CalculateAvarage();
                    student = stud;
                }
            }

            return student;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Student You Have");
            int num = int.Parse(Console.ReadLine());
            Student[] stud = new Student[num];
            for(int i = 0; i < num; i++)
            {
                stud[i] = new Student();
                Console.WriteLine($"enter student Id {i + 1}");
                stud[i].Id = int .Parse(Console.ReadLine());
                Console.WriteLine($"enter student name {i + 1}");
                stud[i].Name = Console.ReadLine();
                Console.WriteLine($"Choose student Gender {i + 1}");
                foreach(var g in Enum.GetValues(typeof(Gender)))
                {
                    Console.WriteLine($"{(int)g} - {g}");
                }
                stud[i].gender = (Gender)int.Parse( Console.ReadLine());
                Console.WriteLine($"Enter how many Subject you have to student num {i+1}");
                int sub = int.Parse(Console.ReadLine());
                stud[i].Results = new SubjectResult[sub];
                for(int j = 0; j < sub; j++)
                {
                    Console.WriteLine($"Enter name of subject {j + 1}:");
                    string subjectName = Console.ReadLine();

                    Console.WriteLine($"Enter grade for {subjectName}:");
                    int grade = int.Parse(Console.ReadLine());

                    stud[i].Results[j] = new SubjectResult(subjectName, grade);

                }
                Console.WriteLine($"---------------------------------");
                Console.WriteLine($"Student info");

            }
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine($"Student num {i+1}");
                Console.WriteLine($"Student name {stud[i].Name} and Id= {stud[i].Id} gender={stud[i].gender}");
                Console.WriteLine("subject and grade ");
                foreach (var s in stud[i].Results)
                {
                    Console.WriteLine($" - {s.SubjectName}: {s.Grade}");
                }

                Console.WriteLine($"Average: {stud[i].CalculateAvarage():F2}");


            }
            Student top = TopAvarage(stud);

            Console.WriteLine($"Top Student is : {top.Name} and avarage  is {top.CalculateAvarage()}");

        }
    }
}
