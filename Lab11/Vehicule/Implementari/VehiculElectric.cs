using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.ClaseAbstracte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Vehicule.Implementari
{
    public class VehiculElectric : Vehicul
    {
        protected int BaterieInProcente { get; set; }

        public VehiculElectric(string model, int id, int baterieInProcenteInitiala = 0) : base(model, id)
        {
            BaterieInProcente = baterieInProcenteInitiala;
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

        public override string ToString()
        {
            return $"Vehicul de tipul {nameof(VehiculElectric)} cu Id {Id} si Model {Model} are {BaterieInProcente}% baterie disponibila.";
        }
    }
}
