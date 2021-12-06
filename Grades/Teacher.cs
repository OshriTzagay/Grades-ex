using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Professor
    {
        public string name;
        public string studentName;
        public int id;
        public List<int> gradesList;


        public Professor() { }

        public Professor(string name, string studentName, int id, List<int> gradesList)
        {
            this.name = name;
            this.studentName = studentName;
            this.id = id;
            this.gradesList = gradesList;
        }


        public static void ProfessorAppEntry()
        {
            //Console.WriteLine("Hello Professor , What is your Name ? :)");
            //string professorName = Console.ReadLine();
            Console.WriteLine("Welcome To Our School App");
            Console.WriteLine($"Hey Professor !\nFor Add Studs , Press 1");
            Console.WriteLine("For Second Stud Grades Press 2");
            Console.WriteLine("");

            int ProfessorPick = int.Parse(Console.ReadLine());

            switch (ProfessorPick)
            {

                case 1:
                    try
                    {
                        AddStudFunction();

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 2:

                    //GetStudNum2();
                    break;

            }


        }


        public static void AddStudFunction()
        {
            List<string> listFromFile = new List<string>();
            Console.WriteLine("Hello Professor , What is your Name ? :)");
            string professorName = Console.ReadLine();

            Console.WriteLine($"{professorName}, How much students u want to save ???");
            int professorNumOfStuds = int.Parse(Console.ReadLine());


            int counter = 0;
            for (int i = 0; i < professorNumOfStuds; i++)
            {
                Professor CurrentStud = new Professor();


                CurrentStud.name = professorName;

                Console.WriteLine("What is your Stud Name ?");
                string studName = Console.ReadLine();
                CurrentStud.studentName = studName;


                Console.WriteLine("What is the Stud ID ? ");
                int studentID = int.Parse((Console.ReadLine()));
                CurrentStud.id = studentID;

                Console.WriteLine("Gimmie his Grades...");


                CurrentStud.gradesList = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    int studGrades = int.Parse((Console.ReadLine()));

                    CurrentStud.gradesList.Add(studGrades);
                }
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine($"Stud number:  {counter}\n Name:{CurrentStud.studentName}\n ID :{CurrentStud.id}\n Grades: \n {CurrentStud.gradesList[0]}\n {CurrentStud.gradesList[1]}\n {CurrentStud.gradesList[2]}\n");
                Console.WriteLine("_______________________________________________________________");
                counter++;





                FileStream studsFile = new FileStream($@"c:\Test\Studs\{professorName}.txt", FileMode.Append);

                using (StreamWriter studsWriter = new StreamWriter(studsFile))
                {
                    //studsWriter.WriteLine("___________________________________");
                    studsWriter.WriteLine($"Stud Num: {counter} Name:{CurrentStud.studentName} ID :{CurrentStud.id} Grades:  {CurrentStud.gradesList[0]} , {CurrentStud.gradesList[1]}, {CurrentStud.gradesList[2]}");
                    //studsWriter.WriteLine("___________________________________");

                }
                FileStream studsFile2 = new FileStream($@"c:\Test\Studs\{professorName}.txt", FileMode.Open);
                using (StreamReader studReader = new StreamReader(studsFile2))
                {
                    listFromFile.Add($"{CurrentStud.studentName} , {CurrentStud.id} , {CurrentStud.gradesList[0]}, {CurrentStud.gradesList[1]}, {CurrentStud.gradesList[2]}");
                }

            }
            for (int i = 0; i < listFromFile.Count; i++)
            {
                Console.WriteLine(listFromFile[i]);
            }

        }
        //public static void studentsInfo(string profName,int numOfstuds) 
        //{
        //    int counter = 0;
        //    for (int i = 0; i < numOfstuds; i++)
        //    {
        //        Professor CurrentStud = new Professor();

        //        CurrentStud.gradesList = new List<int>();
        //        CurrentStud.name = profName;

        //        Console.WriteLine("What is your Stud Name ?");
        //        string studName = Console.ReadLine();
        //        CurrentStud.studentName = studName;


        //        Console.WriteLine("What is the Stud ID ? ");
        //        int studentID = int.Parse((Console.ReadLine()));
        //        CurrentStud.id = studentID;

        //        Console.WriteLine("Gimmie his Grades...");


        //        for (int j = 0; j < 3; j++)
        //        {
        //            int studGrades = int.Parse((Console.ReadLine()));

        //            CurrentStud.gradesList.Add(studGrades);
        //        }
        //        Console.WriteLine("_______________________________________________________________");
        //        Console.WriteLine($"Stud number:  {counter}\n Name:{CurrentStud.studentName}\n ID :{CurrentStud.id}\n Grades: \n {CurrentStud.gradesList[0]}\n {CurrentStud.gradesList[1]}\n {CurrentStud.gradesList[2]}\n");
        //        Console.WriteLine("_______________________________________________________________");
        //        counter++;
        //    }


        static void writingTheFile(string profName, int numOfstuds)
        {



        }

        static void exceptionSht()
        {
             throw new FormatException("Bro, Format Exception , Must be a String . ");
        }
        //public
        //public static void GetStudNum2()
        //{
        //    Console.WriteLine("Alright , for your student grades , please give me your Name .");
        //    string professorName = Console.ReadLine();
        //    Console.WriteLine("O");
        //    FileStream professorFile = new FileStream($@"c:\Test\Studs\{professorName}.txt", FileMode.Open);
        //    using (StreamReader studNameNGrades = new StreamReader(professorFile))
        //    {
        //        string studName = studNameNGrades.ReadLine().Substring(12, 12);

        //    }

        //}

    }

}
