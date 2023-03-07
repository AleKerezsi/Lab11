using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.ClaseAbstracte;
using Lab11.Vehicule.Implementari;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.StatiiDePompare
{
    public class StatieDePompareClasica
    {
        public void Alimenteaza(VehiculBenzina vehicul, ICombustibil combustibil)
        {
            if (combustibil is Benzina)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, alimentam rezervorul cu {combustibil.Cantitate}L de benzina. Rezervor  inainte de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                vehicul.AdaugaInRezervor(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat alimentarea rezervorului cu {combustibil.Cantitate}L benzina. Rezervor dupa de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
            }

            Console.WriteLine($"Vehiculul pe benzina poate fi alimentat doar cu benzina");
            Console.WriteLine();
        }

        public void Alimenteaza(VehiculDiesel vehicul, ICombustibil combustibil)
        {
            if (combustibil is Diesel)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, alimentam rezervorul cu {combustibil.Cantitate}L de combustibil diesel. Rezervor  inainte de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                vehicul.AdaugaInRezervor(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat alimentarea rezervorului cu {combustibil.Cantitate}L de combustibil diesel. Rezervor dupa de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                return;
            }

            Console.WriteLine($"Vehiculul pe benzina poate fi alimentat doar cu diesel");
            Console.WriteLine();
        }

        public void Alimenteaza(VehiculGPL vehicul, ICombustibil combustibil)
        {
            if (combustibil is Benzina || combustibil is GPL)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, alimentam rezervorul cu {combustibil.Cantitate}L de combustibil. Rezervor  inainte de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                vehicul.AdaugaInRezervor(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat alimentarea rezervorului cu {combustibil.Cantitate}L de combustibil. Rezervor dupa de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                return;
            }

            Console.WriteLine($"Vehiculul pe benzina poate fi alimentat doar cu benzina sau GPL");
            Console.WriteLine();
        }
    }
}
