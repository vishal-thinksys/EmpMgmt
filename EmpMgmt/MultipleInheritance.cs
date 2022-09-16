using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public interface IMovement
    {
        void Move();
    }

    public interface IMakeSound
    {
        public void MakeSound();
    }

    public interface IAnimal2
    {
        string SpeciesName { get; set; }
    }

    public class Cat : IMovement, IMakeSound, IAnimal2
    {
        public string SpeciesName { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Move()
        {
            Console.WriteLine("Walking gracefully");
        }
    }
   
}
