using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.ClaseAbstracte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Vehicule.Implementari
{
    public class VehiculBenzina : Vehicul
    {
        protected int CombustibilRezervor { get; set; }

        public VehiculBenzina(string model, int id, int combustibilRezervorInitial = 0) : base(model,id)
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
            return $"Vehicul de tipul {nameof(VehiculBenzina)} cu Id {Id} si Model {Model} are {CombustibilRezervor}L benzina in rezervor.";
        }
    }
}
