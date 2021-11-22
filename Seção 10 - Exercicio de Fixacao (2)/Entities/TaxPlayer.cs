using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_10___Exercicio_de_Fixacao__2_.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double Anuallncome { get; set; }


        //Construtores
        public TaxPlayer()
        {

        }

        public TaxPlayer(string name, double anuallncome)
        {
            Name = name;
            Anuallncome = anuallncome;
        }


        //Métodos

        public abstract double Tax();
    }
}
