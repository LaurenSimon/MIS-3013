using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy ()
        {
            Random rand = new Random();
            int index = rand.Next(0, Toys.Count);

            Toy rToy = Toys[index];
        }
    }
}
