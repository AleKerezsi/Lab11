using Lab11.Combustibile.Interfete;
using Lab11.Combustibile.Tipuri;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Combustibile
{
    public class Electric : ICombustibil
    {
        private TipElectricitate TipElectricitate { get; set; }

        public int Cantitate { get; set; }

        public ICombustibil ICombustibil
        {
            get => default;
            set
            {
            }
        }

        public Electric(TipElectricitate tipElectricitate, int cantitate)
        {
            TipElectricitate = tipElectricitate;
            Cantitate = cantitate;
        }
    }
}
