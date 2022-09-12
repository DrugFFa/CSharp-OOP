using System;
using System.Collections.Generic;
using System.Text;

namespace Ekspedisi.Models
{
    //inheritance
    public class Sender : Person
    {
      
        public Sender(int id, string nama, string kota_asal, string kota_tujuan, bool pulau) { 
            this.id =id;
            this.nama = nama;
            this.kota_asal = kota_asal;
            this.kota_tujuan = kota_tujuan;
            this.pulau = pulau;
            

        }


        public int id { get; private set; }
        public string nama { get; private set; }
        public string kota_asal { get; private set; }
        public string kota_tujuan { get; private set; }
        public bool pulau { get; private set; }
        

        public void kota()
        {
            Console.WriteLine("Barang dikrimkan dari Kota " + kota_asal + " menuju ke Kota "+kota_tujuan);
        }

       

    }


}
