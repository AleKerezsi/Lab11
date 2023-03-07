using Lab11.Combustibile.Interfete;
using Lab11.Combustibile.Tipuri;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Combustibile
{
    public class Diesel : ICombustibil
    {
        private TipDiesel TipDiesel { get; set; }

        public int Cantitate { get; set; }

        public ICombustibil ICombustibil
        {
            get => default;
            set
            {
            }
        }

        public Diesel(TipDiesel tipDiesel, int cantitate)
        {
            TipDiesel = tipDiesel;
            Cantitate = cantitate;
        }
    }
}
