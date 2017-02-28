
/// <summary>
/// Virtual Pet is a c# interactive game. User input corralates to data entry.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace VirtualPet
{
    class VirtualPet
    {

        private string petName;
        private string petColor;
        private int petTemperment;
        private int petPlayfulness;
        private int petHunger;
        private int petAge; 


        public VirtualPet(string petN, string petC, int petT, int petP, int petH, int petA)
        {
            this.PetName = petN;
            this.PetColor = petC;
            this.PetTemperment = petT;
            this.PetPlayfulness = petP;
            this.PetHunger = petH;
            this.PetAge = petA;
        }

        public VirtualPet()
       {
            this.PetName = "Uni the Unicorn";
            this.PetColor = "I'm white with pink poka dots";
            this.PetAge = 10;
            this.PetTemperment = 10;
            this.PetPlayfulness = 10;
            this.PetHunger = 10;
            this.PetAge = 1;
       }

        public string PetName
        {
            get
            {
                return petName;

            }
            set
            {
                this.petName = value;
            }
        }
        public string PetColor
        {
            get
            {
                return petColor;
            }
            set
            {
                this.petColor = value;
            }
        }

        public int PetTemperment
        {
            get
            {
                return petTemperment;
            }
            set
            {
                this.petTemperment = value;
            }
        }
        public int PetPlayfulness
        {
            get
            {
                 return petPlayfulness;
            }
            set
            {
                this.petPlayfulness = value;
            }
        }
        public int PetHunger
        {
            get
            {
                return petHunger;
            }
            set
            {  
                petHunger = value;
            }
        }

        public int PetAge
        {
            get
            {
                return petAge;
            }
            set
            {
                petAge = value;
            }
        }

        public static object Properties { get; internal set; }

        public void Picture()
        {
        Console.WriteLine("");

        Console.WriteLine(@"           \                       ");
        Console.WriteLine(@"            \ji                    ");
        Console.WriteLine(@"             /.(((                 ");
        Console.WriteLine(@"            (,/(((__,--.           ");  
        Console.WriteLine(@"               \  ) _( /{          ");
        Console.WriteLine(@"                !||    ||\         ");
        Console.WriteLine(@"                !||   :||          ");
        Console.WriteLine(@"                '''   '''          ");

            Console.WindowWidth = 89;
            Console.WriteLine("\n\n");
        }


        public void PetInformation()
        {

            Console.WriteLine("Hello my name is " + petName);
            Console.WriteLine("I'm " + petColor);
            Console.WriteLine("I'm " + petAge + "yr old");

            Console.WriteLine("");

        }
            public void PetInformation2()
        { 

            Console.WriteLine("I'm feeling: " + PetTemperment);
            Console.WriteLine("Pet Play: " + PetPlayfulness);
            Console.WriteLine("My stomach is: " + PetHunger);
            this.PetPlayOptions();
        }

        public void PetPlayOptions()
        {
            Console.WriteLine("");
            Console.WriteLine(" Pick an option!");
            List<string> list = new List<string>() {" 1.Feed Uni"," 2.Play with Uni", " 3.Put Uni to sleep"};
            foreach (string items in list)
            Console.WriteLine(items);
            
            Console.WriteLine("");

            int listOptions = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("");
            
            while (listOptions == 1)
            {
                Console.WriteLine();
                PetHunger +=2;
                PetTemperment +=2;
                PetPlayfulness +=2;
                this.PetInformation2();
                break;
            }

            while (listOptions == 2)
            {
                Console.WriteLine();
                PetTemperment += 2;
                PetPlayfulness -=2;
                PetHunger -=5;
                this.PetInformation2();
                break;
            }
            while (listOptions == 3)
            {
                Console.WriteLine();
                PetTemperment += 5;
                PetPlayfulness += 5;
                PetHunger -= 5;
                this.PetInformation2();
                this.PetPlayOptions();

                break;
            }

            }

        public void Interaction()

        {
            if (petHunger > 1)
                Console.WriteLine("Feed Me?  Play time?");

            while (petPlayfulness < 20)
            {
                Console.WriteLine("Please Play with me! I'm bored!");
               break;
            }
            if (petHunger < 10)
            {
               Console.WriteLine("Hunger can kill you! Hunger level at: " + PetHunger);

               
            }

        }
    }
}

          











