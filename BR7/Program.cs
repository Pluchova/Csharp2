using System.Reflection.Emit;

namespace BR7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Zvirata> zvirataVZoo = new List<Zvirata>
            {
                new Slon(),
                new Opice(),
                new Tygr()
            };


            zvirataVZoo.ForEach(x => x.VydejZvuk());

        }
    }
    public abstract class Zvirata
    {
        public abstract void VydejZvuk();

    }
    public class Slon : Zvirata
    {
        public override void VydejZvuk()
        {
            Console.WriteLine("Slon dělá tu");
        }
    }

    public class Opice : Zvirata
    {
        public override void VydejZvuk()
        {
            Console.WriteLine("Opice dělá uuaa");
        }
    }

    public class Tygr : Zvirata
    {
        public override void VydejZvuk()
        {
            Console.WriteLine("Tygr dělá vrr");
        }
    }
    
    
}