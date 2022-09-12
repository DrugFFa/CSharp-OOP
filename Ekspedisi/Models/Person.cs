using System;
using System.Collections.Generic;
using System.Text;

namespace Ekspedisi.Models
{
    public class Person
    {

        public Person(int id, string nama, string kota_asal, string kota_tujuan, bool pulau)
        {
            this.id = id;
            this.nama = nama;
            this.kota_asal = kota_asal;
            this.kota_tujuan = kota_tujuan;
            this.pulau = pulau;

        }
        public Person()
        { }
        public int id { get; private set; }
        public string nama { get; private set; }
        public string kota_asal { get; private set; }
        public string kota_tujuan { get; private set; }
        public bool pulau { get; private set; }

        public void pemisah()
        {
            Console.WriteLine("-----------------------------");
        }

        public void mengirim(string nama)
        {
            Console.WriteLine(nama + " ingin mengirimkan paket");
        }
        public void menerima(string nama)
        {
            Console.WriteLine(nama +" telah menerima paket")
;        }
     
}

  
}
