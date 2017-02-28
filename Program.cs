
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Press Enter to begin!");
            Console.ReadLine();
            SoundPlayer Wav = new SoundPlayer("c:/users/wecancodeit/Downloads/chime_up.wav");
            Wav.PlaySync();
            while (true)
            {

                VirtualPet PetPlay = new VirtualPet();
                PetPlay.Picture();
                PetPlay.PetInformation();
                Console.WriteLine("You can exit now by entering in exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")

                    break;

                PetPlay.Interaction();
                PetPlay.PetInformation2();
                Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")
                break;

               
            }
        }
    }
}
