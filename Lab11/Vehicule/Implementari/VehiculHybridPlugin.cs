using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.ClaseAbstracte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Vehicule.Implementari
{
    public class VehiculHybridPlugin : Vehicul
    {
        protected int BaterieInProcente { get; set; }

        protected int CombustibilRezervor { get; set; }

        public VehiculHybridPlugin(string model, int id, int combustibilRezervorInitial = 0, int baterieInProcenteInitiala = 0) : base(model, id)
        {
            BaterieInProcente = baterieInProcenteInitiala;
            CombustibilRezervor = combustibilRezervorInitial;
        }

        public string ObtineModel()
        {
            return Model;
        }

        public int ObtineId()
        {
            return Id;
        }

        public int ObtineBaterieInProcente()
        {
            return BaterieInProcente;
        }

        public void IncarcaBateria(int procente)
        {
            BaterieInProcente = BaterieInProcente + procente;
        }
        public int ObtineCombustibilRezervor()
        {
            return CombustibilRezervor;
        }
        public void AdaugaInRezervor(int cantitate)
        {
            CombustibilRezervor = CombustibilRezervor + cantitate;
        }

        public override string ToString()
        {
            return $"Vehicul de tipul {nameof(VehiculHybridPlugin)} cu Id {Id} si Model {Model} are {BaterieInProcente}% baterie disponibila, precum si {CombustibilRezervor}L benzina in rezervor.";

        }
    }
}
