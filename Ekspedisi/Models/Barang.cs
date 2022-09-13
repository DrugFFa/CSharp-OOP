using System;
using System.Collections.Generic;
using System.Text;

namespace Ekspedisi.Models
{
    class Barang : Transportation
    {
        
        public Barang(int id, string nama, int berat, bool jenis, string pengiriman,int diskon)
        {
            this.id = id;
            this.nama = nama;
            this.berat = berat;
            this.jenis = jenis;
            this.pengiriman = pengiriman;
            this.diskon = diskon;
        }
        public int id { get; private set; }
        public string nama { get; private set; }
        public string pengiriman { get; private set; }
        public int berat { get; private set; }
        public bool jenis { get; private set; }
        public int diskon { get; private set; }

        public void namabarang()
        {
            Console.WriteLine("Barang yang dikirim adalah " + nama);
        }

        public void jenis_fragile()
        {
            Console.WriteLine("Barang Yang dikirim oleh " + nama + " merupakan barang pecah belah");
        }

        public void jenis_aman()
        {
            Console.WriteLine("Barang Yang dikirim oleh " + nama + " bukan merupakan barang pecah belah");
        }

        public void classification()
        {
            if (jenis == true)
            {
                jenis_fragile();
            }
            else
            {
                jenis_aman();
            }

        }

        //overloading start
        public int harga()
        {
            int total;
            
            total = 1000 * berat;

            return total;

        }

        
        public Double harga(int diskon)
        {
            Double potharga,hargaawal,awal;
            
            hargaawal = Convert.ToDouble(harga());

            potharga = Convert.ToDouble(diskon);

            awal = (hargaawal/100) * potharga;
            return awal;
          
        }

        public void jumlahbayar()
        {
            Console.WriteLine("Jumlah biaya sebelum yang harus dibayarkan adalah " + harga());
        }

        public void jumlahbayar(int diskon)
        {
            
            Console.WriteLine("Jumlah biaya setelah mendapat diskon adalah " + harga(diskon));
        }

        public override void Truk(string nama)
        {
            if (pengiriman == "Bondowoso")
            {
                base.Truk(nama);
                Console.WriteLine("Pengiriman dilakukan hari ini dengan kecepatan ekstra cepat");
            }
            else if (pengiriman == "DPR")
            {
                base.Truk(nama);
                Console.WriteLine("Pengiriman dilakukan hari ini dengan kecepatan ekstra lambat");
            }
            else if (pengiriman == "Kuli")
            {
                base.Truk(nama);
                Console.WriteLine("Pengiriman dilakukan hari ini dengan kecepatan Normal, Tergantung Persediaan Kopi dan Rokok");
            }
            else
            {
                Console.WriteLine("Tidak memilih paket pengiriman yang sesuai, silahkan kirim paket anda sendiri");
            }
        }
    }
}
