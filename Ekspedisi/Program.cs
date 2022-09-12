using System;

namespace Ekspedisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int idpengiriman, idbarang, berat,jb, i,diskon;
            string kota1, kota2, nama_sender, val0,val1, val2, val3, val4, val5,val6, nama_barang, pengiriman;
            bool pulau,jenis;
            Console.WriteLine("Berapa banyak jenis barang yang ingin anda kirimkan ?");
            val0 = Console.ReadLine();
            jb = Convert.ToInt32(val0);
            i = 0;
            while (i < jb) {
                Console.WriteLine("Masukkan Id Pengirim");
                val1 = Console.ReadLine();
                idpengiriman = Convert.ToInt32(val1);
                Console.WriteLine("Masukkan Nama Pengirim");
                nama_sender = Console.ReadLine();
                Console.WriteLine("Masukkan Nama Barang");
                nama_barang = Console.ReadLine();
                Console.WriteLine("Masukkan Kota Asal");
                kota1 = Console.ReadLine();
                Console.WriteLine("Masukkan Kota Tujuan");
                kota2 = Console.ReadLine();
                Console.WriteLine("Masukkan Pulau Tujuan (ketik true untuk Sesama pulau dan false untuk beda pulau)");
                val4 = Console.ReadLine();
                pulau = Convert.ToBoolean(val4);
                Console.WriteLine("Masukkan Jenis Barang (ketik true untuk pecah belah dan false untuk non pecah belah)");
                val5 = Console.ReadLine();
                jenis = Convert.ToBoolean(val5);
                Console.WriteLine("Masukkan Jenis Pengiriman (Bondowoso/DPR/Kuli)");
                pengiriman = Console.ReadLine();
                Console.WriteLine("Masukkan Berat (dalam satuan kg)");
                val2 = Console.ReadLine();
                berat = Convert.ToInt32(val2);
                Console.WriteLine("Masukkan Besaran Diskon (dalam persen)");
                val6 = Console.ReadLine();
                diskon = Convert.ToInt32(val6);

                Models.Person person = new Models.Person(idpengiriman, nama_sender, kota1, kota2, pulau);
                Models.Sender sender = new Models.Sender(idpengiriman, nama_sender, kota1, kota2, pulau);
                Models.Barang barang = new Models.Barang(idpengiriman, nama_barang, berat, jenis, pengiriman, diskon);
                sender.pemisah();
                sender.pemisah();
                sender.mengirim(nama_sender);
                barang.namabarang();
                barang.classification();
                sender.kota();
                barang.jumlahbayar(diskon);
                barang.Truk(nama_sender);
                sender.pemisah();
                sender.pemisah();
                i++;

            }
            
        }
    }
}
