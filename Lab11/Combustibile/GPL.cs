using Lab11.Combustibile.Interfete;
using Lab11.Combustibile.Tipuri;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Combustibile
{
    public class GPL : ICombustibil
    {
        private TipGPL TipGPL { get; set; }

        public int Cantitate { get; set; }

        public ICombustibil ICombustibil
        {
            get => default;
            set
            {
            }
        }

        public GPL(TipGPL tipGpl, int cantitate)
        {
            TipGPL = tipGpl;
            Cantitate = cantitate;
        }
    }
}
