using Lab11.Combustibile;
using Lab11.Combustibile.Interfete;
using Lab11.Vehicule.Implementari;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.StatiiDePompare
{
    public class StatieDePompareHibrida : StatieDePompareClasica
    {
        public void Alimenteaza(VehiculElectric vehicul, ICombustibil combustibil)
        {
            if (combustibil is Electric)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, incarcam bateria autovehiculului. Procentaj baterie inainte de incarcare: {vehicul.ObtineBaterieInProcente()}% \n");
                vehicul.IncarcaBateria(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat incarcarea bateriei autovehiculului. Procentaj baterie dupa incarcare: {vehicul.ObtineBaterieInProcente()}% \n");
                return;
            }

            Console.WriteLine($"Vehiculul pe benzina poate fi alimentat doar cu curent.");
            Console.WriteLine();
        }

        public void Alimenteaza(VehiculHybridPlugin vehicul, ICombustibil combustibil)
        {
            if (combustibil is Electric)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, incarcam bateria autovehiculului. Procentaj baterie inainte de incarcare: {vehicul.ObtineBaterieInProcente()}% \n");
                vehicul.IncarcaBateria(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat incarcarea bateriei autovehiculului. Procentaj baterie dupa incarcare: {vehicul.ObtineBaterieInProcente()}% \n");
                return;
            }

            if (combustibil is Benzina)
            {
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()}, alimentam rezervorul cu {combustibil.Cantitate}L de benzina. Rezervor  inainte de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                vehicul.AdaugaInRezervor(combustibil.Cantitate);
                Console.Write($"Pentru vehiculul cu Id {vehicul.ObtineId()} si model {vehicul.ObtineModel()} s-a terminat alimentarea rezervorului cu {combustibil.Cantitate}L benzina. Rezervor dupa de alimentare: {vehicul.ObtineCombustibilRezervor()}L \n");
                return;
            }

            Console.WriteLine($"Vehiculul pe benzina poate fi alimentat doar cu benzina sau curent.");
            Console.WriteLine();
        }
    }
}
