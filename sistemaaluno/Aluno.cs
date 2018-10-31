using System;
namespace sistemaaluno
{
    public class Aluno
    {
        public string Nome{
            set;get;
        }

        public double Nota1{
            set; get;
        }

        public double Nota2
        {
            set; get;
        }

        public double Nota3
        {
            set; get;
        }

        public double Media(){
            return Math.Round((Nota1 + Nota2 + Nota3) / 3, 2);
        }

    }
}
