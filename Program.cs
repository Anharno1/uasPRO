using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBookingJalurPendakian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pendakian> pendakianList = new List<Pendakian>();
         

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Sistem Booking Online Jalur Pendakian");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Lihat Daftar Jalur Pendakian");
                Console.WriteLine("2. Pesan Tiket");
                Console.WriteLine("3. Lihat Riwayat Pemesanan");
                Console.WriteLine("4. Keluar");

                Console.Write("Pilih menu: ");
                int pilihanMenu = int.Parse(Console.ReadLine());

                switch (pilihanMenu)
                {
                    case 1:
                        TampilkanDaftarJalurPendakian(pendakianList);
                        break;
                    case 2:
                        PesanTiket(pendakianList);
                        break;
                    case 3:
                        LihatRiwayatPemesanan();
                        break;
                    case 4:
                        Console.WriteLine("Terima kasih telah menggunakan Sistem Booking Online Jalur Pendakian!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan menu tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void TampilkanDaftarJalurPendakian(List<Pendakian> pendakianList)
        {
            if (pendakianList.Count == 0)
            {
                Console.WriteLine("Belum ada data jalur pendakian.");
                return;
            }

            Console.WriteLine("\nDaftar Jalur Pendakian:");
            for (int i = 0; i < pendakianList.Count; i++)
            {
                Pendakian pendakian = pendakianList[i];
                Console.WriteLine($"{i + 1}. {pendakian.GetNamaJalur()} ({pendakian.GetTanggalPendakian().ToString("yyyy-MM-dd")}) - Sisa Kuota: {pendakian.GetSisaKuota()}");
            }
        }

        static void PesanTiket(List<Pendakian> pendakianList)
        {
            if (pendakianList.Count == 0)
            {
                Console.WriteLine("Belum ada data jalur pendakian. Silakan tambahkan data terlebih dahulu.");
                return;
            }

            Console.Write("Pilih nomor jalur pendakian: ");
            int pilihanJalur = int.Parse(Console.ReadLine());

            if (pilihanJalur < 1 || pilihanJalur > pendakianList.Count)
            {
                Console.WriteLine("Nomor jalur pendakian tidak valid.");
                return;
            }

            Pendakian pendakian = pendakianList[pilihanJalur - 1];
            Console.Write($"Masukkan jumlah tiket yang ingin dipesan ({pendakian.GetSisaKuota()} tiket tersedia): ");
            int jumlahTiket = int.Parse(Console.ReadLine());

            try
            {
                pendakian.PesanTiket(jumlahTiket);
                Console.WriteLine($"Pemesanan berhasil! Anda memesan {jumlahTiket} tiket untuk Jalur Pendakian {pendakian.GetNamaJalur()} pada tanggal {pendakian.GetTanggalPendakian().ToString("yyyy-MM-dd")}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void LihatRiwayatPemesanan()
        {
            if (riwayatPemesanan.Count == 0)
            {
                Console.WriteLine("Belum ada riwayat pemesanan.");
                return;
            }

            Console.WriteLine("\nRiwayat Pemesanan:");
            foreach (var pemesanan in riwayatPemesanan)
            {
                Console.WriteLine(pemesanan); 
            }

        }
    }
}
    

