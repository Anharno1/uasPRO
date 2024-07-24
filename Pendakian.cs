using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBookingJalurPendakian
{
    public class Pendakian
    {
        private string namaJalur;
        private DateTime tanggalPendakian;
        private int kuotaPendaki;
        private int sisaKuota;
        private List<Pesanan> pemesanan;

        public Pendakian(string namaJalur, DateTime tanggalPendakian, int kuotaPendaki)
        {
            this.namaJalur = namaJalur;
            this.tanggalPendakian = tanggalPendakian;
            this.kuotaPendaki = kuotaPendaki;
            this.sisaKuota = kuotaPendaki;
            this.pemesanan = new List<Pesanan>();
        }

        public string GetNamaJalur()
        {
            return namaJalur;
        }

        public DateTime GetTanggalPendakian()
        {
            return tanggalPendakian;
        }

        public int GetSisaKuota()
        {
            return sisaKuota;
        }

        public void PesanTiket(int jumlahTiket)
        {
            if (jumlahTiket > sisaKuota)
            {
                throw new Exception("Jumlah tiket melebihi kuota yang tersedia");
            }

            sisaKuota -= jumlahTiket;
            pemesanan.Add(new PesananIndividu(jumlahTiket)); 
        }

        public List<Pesanan> GetPemesanan()
        {
            return pemesanan;
        }
    }
}