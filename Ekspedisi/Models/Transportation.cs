using System;
using System.Collections.Generic;
using System.Text;

namespace Ekspedisi.Models
{
    class Transportation
    {
        public Transportation (int Id, string Name, int Age, bool Gender)
        {
            this.Id = Id;
            this.Name = Name;
            ;
        }

        public Transportation()
        {

        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }


        public virtual void Truk(string Name)
        {
            Console.WriteLine("Pengiriman Paket Milik " + Name + " Dilakukan Menggunakan Truk Scania Mesin 2 Tak");
        }
    }

    
}
