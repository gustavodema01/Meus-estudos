using Médias_com_treino_em_poo___C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Médias_Escolares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> list = new List<Aluno>();

            bool validacao = false;
            while (!validacao)
            {
                Console.Clear();
                Console.WriteLine("1. STUDENT REGISTER");
                Console.WriteLine("2. STUDENT SITUATION");
                Console.WriteLine("3. STUDENT SEARCHING");
                Console.WriteLine("4. QUIT");
                Console.Write("\n Wich option?: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("STUDENT NAME: ");
                        string name = Console.ReadLine();  //colocar validação aqui
                        Console.Write("STUDENT ENROLLMENT: ");
                        int enrollment = int.Parse(Console.ReadLine());  //colocar validação aqui
                        Console.Write("STUDENTE GRADE: "); 
                        double grade = int.Parse(Console.ReadLine());
                        Aluno student = new Aluno(name, enrollment, grade); // create a new instance of Aluno
                        list.Add(student); // list with objects of student type
                        validacao  = false;   
                    break;

                    case 2:
                        Console.Clear();
                        Console.Write("STUDENT ENROLLMENT: ");
                        Aluno found = list.Find(x => x.Enrollment == int.Parse(Console.ReadLine())); //colocar validação aqui 
                        Console.WriteLine(found.CalcSituation());
                        Console.ReadKey();
                        validacao = false;
                        break;

                        case 3:
                        Console.Clear();
                        Console.Write("Write the student's ID number: ");
                        Aluno found2 = list.Find(x => x.Enrollment == int.Parse(Console.ReadLine())); //colocar validação aqui
                        Console.WriteLine(found2);
                        Console.ReadKey();
                        break;

                        case 4:
                        validacao = false;
                        break;
                }
            }
        }
    }
}
