using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public abstract class Gem
    {
        public abstract decimal GetValuePerCarat();

        public string GetCommonColors()
        {
            return "Clear, Purple, Red, Black, White";
        }
    }
    public class Garnet : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 500M;
        }
    }

    public class Amethyst : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 300M;
        }
    }

    public class Pearl : Gem
    {
        public override decimal GetValuePerCarat()
        {
            return 400M;
        }
    }
    public class AbstractClass
    {
       public void CallAbstractClass()
        {
            Gem gem = new Garnet();
            PrintOutPut("Garnet", gem.GetValuePerCarat());
            PrintOutPut("Garnet", gem.GetCommonColors());
            Garnet garnet = new Garnet();
            PrintOutPut("Garnet",garnet.GetValuePerCarat());
            PrintOutPut("Garnet", garnet.GetCommonColors());           
            Amethyst amethyst = new Amethyst();
            PrintOutPut("Amethyst", amethyst.GetValuePerCarat());
            PrintOutPut("Amethyst", amethyst.GetCommonColors());
            Pearl pearl = new Pearl();
            PrintOutPut("Pearl", pearl.GetValuePerCarat());
            PrintOutPut("Pearl", pearl.GetCommonColors());
        }
        void PrintOutPut(string text, decimal val)
        {
            Console.WriteLine($"{text} Get Value Per Carat is {val.ToString()}");
        }
        void PrintOutPut(string text, string val)
        {
            Console.WriteLine($"Get Common Colors {text} is {val}");
        }
    }
}
