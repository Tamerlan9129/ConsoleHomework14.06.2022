using ConsoleHomework14._06._2022.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleHomework14._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> myStudents = new List<Student>();
            List<Employe> myEmployes = new List<Employe>();
           Main: 
            Helper.Printer("Salam zehmet olmasa secim edin : ", ConsoleColor.Green);
            Helper.Printer("1) Student elave et :  2) 2-Employe elave et :  3)  Axtaris et :  4) Cixis ", ConsoleColor.Blue);
            string choosMenu = Console.ReadLine();
            bool isMenu = int.TryParse(choosMenu, out int menu);

            if (isMenu&& menu>=1&&menu<=4) 
            {
                switch (menu)
                {
                    case 1:
                        Student:
                        Student stud = new Student();
                        Helper.Printer("Student adini daxil edin : ", ConsoleColor.Yellow);
                        string studName = Console.ReadLine();
                        stud.Name = studName;
                        Helper.Printer("Student soyadini daxil edin : ", ConsoleColor.Yellow);
                        string studSurname = Console.ReadLine();
                        stud.Surname = studSurname;
                        Helper.Printer("Student yashini daxil edin : ", ConsoleColor.Yellow);
                        StudAge:
                        string studAge = Console.ReadLine();
                        bool isAge = int.TryParse(studAge, out int age);
                        if (isAge)
                        {
                            stud.Age = age;
                        }
                        else
                        {
                            Helper.Printer("Duzgun yash daxil edin", ConsoleColor.Red);
                            goto StudAge;
                        }
                        Helper.Printer("Student balini daxil edin : ", ConsoleColor.Yellow);
                        StudBal:
                        string bal = Console.ReadLine();
                        bool isBal = int.TryParse(bal, out int grade);
                        if (isBal)
                        {
                            stud.Grade = grade;
                        }
                        else
                        {
                            Helper.Printer("Duzgun daxil edin", ConsoleColor.Red);
                            goto StudBal;
                        }
                        myStudents.Add(stud);
                        Helper.Printer($"{ studName} adli telebe elave olundu .", ConsoleColor.Green);
                        
                        goto Main;
                    case 2:
                        Employe:
                        Employe empl = new Employe();
                        Helper.Printer("Ishcinin adini daxil edin : ", ConsoleColor.Yellow);
                        string empName = Console.ReadLine();
                        empl.Name = empName;
                        Helper.Printer("Ishcinin  soyadini daxil edin : ", ConsoleColor.Yellow);
                        string empSurname = Console.ReadLine();
                        empl.Surname = empSurname;
                        Helper.Printer("Ishcinin  yashini daxil edin : ", ConsoleColor.Yellow);
                        EmpAge:
                        string empAge = Console.ReadLine();
                        bool isemAge = int.TryParse(empAge, out int ageEmp);
                        if (isemAge)
                        {
                            empl.Age = ageEmp;
                        }
                        else
                        {
                            Helper.Printer("Duzgun yash daxil edin", ConsoleColor.Red);
                            goto EmpAge;
                        }
                        Helper.Printer("Ishcinin vezifesini daxil edin : ", ConsoleColor.Yellow);
                        string position = Console.ReadLine();
                        empl.Position = position;
                       
                        myEmployes.Add(empl);
                        
                        Helper.Printer($"{empName} adli ishci elave olundu. ", ConsoleColor.Green);
                        
                        goto Main;

                    case 3:
                        Helper.Printer("1) Employe uzre axtaris :   2) Student uzre axtaris : ", ConsoleColor.Blue);
                        string answer = Console.ReadLine();
                        bool isAns = int.TryParse(answer, out int newMenu);
                        if (isAns && newMenu >= 1 && newMenu <= 2)
                        {
                            switch (newMenu) 
                            {
                                case 1:

                                    if (myEmployes.Count == 0)
                                    {
                                        Helper.Printer("Ishci elave olunmayib.Zehmet olmasa ishi elave edin. ", ConsoleColor.Red);
                                        goto Employe;
                                    }
                                    Helper.Printer("Vezifelerin siyahisi : ", ConsoleColor.White);
                                        foreach (var item in myEmployes)
                                        {
                                            Helper.Printer($"{item.Position}",ConsoleColor.Green);
                                        }
                                        Helper.Printer("Vezife secin : ", ConsoleColor.Yellow);
                                        string emPos = Console.ReadLine();
                                        foreach (var item in myEmployes)
                                        {
                                            if (item.Position == emPos) 
                                            {
                                                Helper.Printer($"{item.Name}", ConsoleColor.Green);
                                                
                                            }
                                        }
                                            
                                    break;
                                case 2:
                                    if (myStudents.Count == 0)
                                    {
                                        Helper.Printer("Telebe elave olunmayib.Zehmet olmasa ishi elave edin. ", ConsoleColor.Red);
                                        goto Student;
                                    }
                                    else
                                    {
                                        MinGrade:
                                        Helper.Printer("Min Grade daxil edin : ", ConsoleColor.Gray);
                                        string sGrade = Console.ReadLine();
                                        bool isMin = int.TryParse(sGrade, out int minGrade);
                                        if (!isMin) 
                                        {
                                            Helper.Printer("Duzgun daxil edin ! ", ConsoleColor.Red);
                                            goto MinGrade;
                                        }
                                    MaxGrade:
                                        Helper.Printer("Max Grade daxil edin : ", ConsoleColor.Gray);
                                        string maGrad = Console.ReadLine();
                                        bool isMag = int.TryParse(maGrad, out int maxGrade);
                                        if (!isMag) 
                                        {
                                            Helper.Printer("Duzgun daxil edin ! ", ConsoleColor.Red);
                                            goto MaxGrade;
                                        }
                                        foreach (var item in myStudents)
                                        {
                                            if (item.Grade > minGrade && item.Grade <= maxGrade) 
                                            {
                                                Helper.Printer($"Studen {item.Name} -  Grade {item.Grade}", ConsoleColor.Blue);
                                            }
                                        }
                                     
                                    }

                                    break;
                            }
                        }
                        else 
                        { 
                            goto case 3; 
                        
                        }
                        break;
                }
            }
            else
            {
                goto Main;
            }
            

        }
    }
}
