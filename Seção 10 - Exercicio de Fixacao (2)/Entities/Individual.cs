using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_10___Exercicio_de_Fixacao__2_.Entities
{
    class Individual : TaxPlayer
    {
        public double HealthExpenditures { get; set; }


        //Construtores
        public Individual()
        {

        }

        public Individual(string name, double anuallncome, double healthExpenditures)
            : base(name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        //Métodos
        public override double Tax()
        {
            if (Anuallncome < 20000.00)
            {
                return Anuallncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Anuallncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}

