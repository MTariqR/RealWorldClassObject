namespace RealWorldClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person noah = new Person("Noah",26,"Brown","Brown",176,true,true);

            string nameInput;
            int ageInput;
            string eyeColourInput;
            string hairInput;
            double heightInput;
            bool clothesInput;
            bool eyesOpenInput;

            Console.WriteLine("Let's make a person\n\n");
            
            Console.WriteLine("What is their name?\n");
            nameInput = Console.ReadLine();
            Console.WriteLine("How old are they?\n");
            ageInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What colour are their eyes?\n");
            eyeColourInput = Console.ReadLine();
            Console.WriteLine("What colour is their hair?\n");
            hairInput = Console.ReadLine();
            Console.WriteLine("How tall are they in metres?\n");
            heightInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are they wearing clothes?\nEnter 1 for yes and 2 for no.\n");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                clothesInput = true;
            }
            else { clothesInput = false; }
            Console.WriteLine("Are their eyes open?\nEnter 1 for yes and 2 for no.\n");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                eyesOpenInput = true;
            }
            else { eyesOpenInput = false; }


            Person userPerson = new Person(nameInput,ageInput,eyeColourInput,hairInput,heightInput,clothesInput,eyesOpenInput);

            Console.WriteLine($"Congraulations! You person is {userPerson.name}. They are {userPerson.age}. They have {userPerson.eyeColour} eyes and {userPerson.hairColour} hair. They are {userPerson.heightInMetres} metres tall.");
        }

    }
}
