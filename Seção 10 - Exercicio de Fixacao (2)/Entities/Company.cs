using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_10___Exercicio_de_Fixacao__2_.Entities
{
    class Company : TaxPlayer
    {
        public int NumberOfEmployees { get; set; }



        //Construtores
        public Company()
        {

        }

        public Company(string name, double anuallncome, int numberOfEmployees) 
            : base (name, anuallncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }


        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return Anuallncome * 0.14;
            }
            else
            {
                return Anuallncome * 0.16;
            }
        }
    }
}
