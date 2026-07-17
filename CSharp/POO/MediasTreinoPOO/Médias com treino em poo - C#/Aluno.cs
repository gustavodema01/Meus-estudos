using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Médias_Escolares
{
    internal class Aluno
    {
        public string Name { get; private set; }
        public int Enrollment { get; private set; }
        public double Grade { get; private set; }

        public Aluno(string name, int enrollment, double grade) //colocar validação aqui
        {
            Name = name;
            Enrollment = enrollment;
            Grade = grade;
        }
        public string CalcSituation()
        {
            return Grade>=5 ?  "Approved!" : "Failed"; //ternary condition to check if the student is approved or not      
        }
        public override string ToString()
        {
            return $"Name: {Name}, Enrollment: {Enrollment}, Situation : {CalcSituation()}";
        }

    }
}
