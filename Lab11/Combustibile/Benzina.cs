using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Combustibile.Tipuri;

namespace Lab11.Combustibile
{
    public class Benzina : ICombustibil
    {
        private TipBenzina TipBenzina { get; set; }

        public int Cantitate { get; set; }

        public ICombustibil ICombustibil
        {
            get => default;
            set
            {
            }
        }

        public Benzina(TipBenzina tipBenzina, int cantitate)
        {
            TipBenzina = tipBenzina;
            Cantitate = cantitate;
        }
    }
}