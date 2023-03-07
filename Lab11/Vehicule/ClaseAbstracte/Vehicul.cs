using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Vehicule.ClaseAbstracte
{
    public abstract class Vehicul
    {
        protected string Model { get; set; }
        protected int Id { get; set; }

        public Vehicul(string model, int id)
        {
            this.Model = model;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Model => [{Id},{Model}]";
        }

    }
}
