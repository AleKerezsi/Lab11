using Lab11.Combustibile;
using Lab11.Combustibile.Tipuri;
using Lab11.StatiiDePompare;
using Lab11.Vehicule.Implementari;
using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var statieDePompareClasica = new StatieDePompareClasica();
            var statieDePompareHibrida = new StatieDePompareHibrida();

            var vehiculBenzina = new VehiculBenzina("Dacia",1);
            var vehiculDiesel = new VehiculDiesel("Volkswagen",2);
            var vehiculElectric = new VehiculElectric("Nissan", 3, baterieInProcenteInitiala: 5);
            var vehiculGpl = new VehiculGPL("Hyundai", 4);
            var vehiculHybridPlugin = new VehiculHybridPlugin("Toyota", 5, baterieInProcenteInitiala: 10);

            var benzina = new Benzina(TipBenzina.Benzina95,8);
            var diesel = new Diesel(TipDiesel.Petroleum, 6);
            var electric = new Electric(TipElectricitate.Electricitate7200Watts, 90);
            var gpl = new GPL(TipGPL.GazNaturalLichefiat, 30);

            statieDePompareClasica.Alimenteaza(vehiculBenzina, benzina);
            statieDePompareClasica.Alimenteaza(vehiculDiesel, diesel);
            statieDePompareClasica.Alimenteaza(vehiculGpl, gpl);

            //statia hibrida poate incarca la fel ca si statia clasica
            statieDePompareHibrida.Alimenteaza(vehiculBenzina, benzina);
            statieDePompareHibrida.Alimenteaza(vehiculDiesel, diesel);
            statieDePompareHibrida.Alimenteaza(vehiculGpl, gpl);

            //statia hibrida poate incarca si masinile electrica
            statieDePompareHibrida.Alimenteaza(vehiculElectric, electric);

            //statia hibrida poate incarca si masinile hybrid plugin
            //incarcam amandoua sursele de combustibil pentru masinile hybrid plugin
            statieDePompareHibrida.Alimenteaza(vehiculHybridPlugin, benzina);
            statieDePompareHibrida.Alimenteaza(vehiculHybridPlugin, electric);

            Console.WriteLine();

            Console.WriteLine(vehiculBenzina);
            Console.WriteLine(vehiculDiesel);
            Console.WriteLine(vehiculGpl);
            Console.WriteLine(vehiculElectric);
            Console.WriteLine(vehiculHybridPlugin);
        }
    }
}
