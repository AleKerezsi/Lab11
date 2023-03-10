using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.ClaseAbstracte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Vehicule.Implementari
{
    public class VehiculDiesel : Vehicul
    {
        protected int CombustibilRezervor { get; set; }

        public VehiculDiesel(string model, int id, int combustibilRezervorInitial = 0) : base(model, id)
        {
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
            return $"Vehicul de tipul {nameof(VehiculDiesel)} cu Id {Id} si Model {Model} are {CombustibilRezervor}L benzina in rezervor.";
        }
    }
}
