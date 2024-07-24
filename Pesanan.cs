using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBookingJalurPendakian
{
    public class Pesanan
    {
        protected int jumlahTiket;

        public Pesanan(int jumlahTiket)
        {
            this.jumlahTiket = jumlahTiket;
        }

        public int GetJumlahTiket()
        {
            return jumlahTiket;
        }
    }

    public class PesananIndividu : Pesanan
    {
        public PesananIndividu(int jumlahTiket) : base(jumlahTiket)
        {
        }

        public override string ToString()
        {
            return $"Pesanan individu untuk {jumlahTiket} tiket";
        }
    }

    public class PesananKelompok : Pesanan
    {
        public PesananKelompok(int jumlahTiket) : base(jumlahTiket)
        {
        }

        public override string ToString()
        {
            return $"Pesanan kelompok untuk {jumlahTiket} tiket";
        }
    }
}
