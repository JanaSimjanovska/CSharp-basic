using System;
using System.Collections.Generic;
using System.Text;
using InheritanceExerciseClassLibrary.Entities.Enums;

namespace InheritanceExerciseClassLibrary.Entities.Models
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        protected bool IsOnBattery { get; set; } // protected e za da moze da se menuva samo preku SwitchToBatteryOrEngine metodot
        
        
        
        public ElectricCar(TypeOfEngine engineType) : base() // Ne go napraviv bonusot so setiranje na EngineType ovde, ama samo zasto mi e malku druga logikata na zadacata. Imeno ne sakam da setiram electrtic Engine zatoa sto elektricnite koli moze da se i hibridi, ne samo elektricni. Osven toa, samata zadaca e malku cudno postavena i me zbuni i zatoa otidov vo ovaa nasoka, zasto vo bonusot za electric car klasava ima staeno da se limitira maxSpeed "when on battery", sto vsusnost i sugerirase deka treba da postoi i opcija hibrid, bidejkji elektricnite koli se samo na akumulator, pa ako ne staev i hibrid, kje nemase smisla i poenta toa bonus baranje.

            // Isto, bidejkji nasleduva od Car, izlisno bi bilo da imase samo opcija za elektricna kola, bidejkji togas kje nemase smisla nasledenoto FuelConsumption Property.
        {
            EngineType = engineType;
            if(engineType != TypeOfEngine.Electric && engineType != TypeOfEngine.Hybrid) // Ne znam kako da ogranicam da moze da se vnese samo hibrid ili samo electric od enumite, pa zatoa samo so predupreduvanjevo vo konzola nastapiv hahaha. Mozebi mora da se napravat posebni klasi hibrid i elektricna kola, dokolku ne moze preku samata klasa da se ogranici, kje mi kazete.
            {
                Console.WriteLine("An electric car can have either an electric motor only, or be a hybrid.");
            }

            if (engineType == TypeOfEngine.Electric)
            {
                IsOnBattery = true;
            }
        }

        public void Recharge()
        {
            Console.WriteLine("Charging...");
            BatteryPercentage = 100;
            Console.WriteLine("Your car is now fully charged.");
        }

        public void SwitchToBatteryOrCombustionEngine() // Metodov ima smisla samo ako kolata e hibrid, poso ako e elektricna, sekogas e na akumulator i zatoa nema zosto da ja ogranicuvame max speed vo toj slucaj. Taka sto so metodov ja ogranicuvam brzinata ako e na akumulator i pravam switch pomegju akumulator i motor na kolata samo ako istata e hibrid. Ako si e elektricna, nikomu nisto. Zatoa i vaka nekako e logikata i na IsOnBattery booleanot, namesten e sekogas da e true ako EngineType e electric;
        {
            if (EngineType == TypeOfEngine.Electric)
            {
                Console.WriteLine("This is an electric car. It always runs on battery."); 
                return;
            }

            if (!IsOnBattery)
            {
                IsOnBattery = true;
                Console.WriteLine("The car now runs on battery.");
            }

            else
            {
                IsOnBattery = false;
                Console.WriteLine("The car now runs on fuel.");
            }

            if (EngineType == TypeOfEngine.Hybrid && IsOnBattery) MaxSpeed = 120;
        }

        public override void Drive()
        {
            Console.WriteLine($"Maximum speed is {MaxSpeed} km/h.");
        }
    }
}
