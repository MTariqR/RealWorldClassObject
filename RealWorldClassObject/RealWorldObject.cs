using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldClassObject
{
    internal class Person
    {
        public string name;
        public int age;
        public string eyeColour;
        public string hairColour;
        public double heightInMetres;
        public bool clothes;
        public bool eyesOpen;

        public Person(string Name, int Age, string EyeColour, string HairColour, double HeightInMetres, bool Clothes, bool EyesOpen) 
        {
            name = Name;
            age = Age;
            eyeColour = EyeColour;
            hairColour = HairColour;
            heightInMetres = HeightInMetres;
            clothes = Clothes;
            eyesOpen = EyesOpen;
        }

        public bool Blink()
        {
            return eyesOpen = !eyesOpen;
        }


    }
}
