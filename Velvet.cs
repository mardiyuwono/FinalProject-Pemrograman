using System;

namespace FinalProject
{
    class Velvet : Bioskop
    {
        public void spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : Minuman Red Velvet");
            Console.WriteLine("                          Snack");
            Console.WriteLine("                          Popcorn");
            Console.WriteLine("                          Penonton yang tidak memiliki tiket tidak boleh masuk ke dalam bioskop");
        }
        public double JumlahTiket { get; set; }
        public double HargaTiket { get; set; }
        public double UangBayar { get; set; }
        public override double Bayar()
        {
            return JumlahTiket * HargaTiket;
        }
        public override double Kembalian()
        {
            return UangBayar - Bayar();
        }
    }
}
