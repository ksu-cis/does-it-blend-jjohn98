using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Blendables> items = new List<Blendables>();
            Strawberry strawberry = new Strawberry();
            items.Add(strawberry);
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());

            string result = "";

            foreach (Blendables f in items)
            {
                result = result + f.Blend();
                result = result + ' ';
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
