
using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        private string name;

        private string id;
        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;

                } else {
                    Console.WriteLine("ERROR - Debe ingresar un nombre válido");
                    this.name = null;
                    
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine($"ERROR - Para {this.name} La cédula es incorrecta");
                    this.id = null;
                    
                    
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
