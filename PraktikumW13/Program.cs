using System;

namespace PraktikumW13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa data yang ingin Anda input : ");
            int jumlahdata = Convert.ToInt32(Console.ReadLine());
            
            int[] inputdata = new int[jumlahdata];
            for (int input = 0; input < jumlahdata; input++)
            {
                Console.WriteLine($"Data ke {input + 1} : ");
                Console.Write("NIM : ");
                int NIM = Convert.ToInt32(Console.ReadLine());
                Console.Write("NAMA: ");
                string NAMA = Console.ReadLine();
                Console.Write("JENIS KELAMIN : ");
                string JENIS = Console.ReadLine();
                Console.Write("TAHUN MASUK: ");
                int TAHUNMASUK = Convert.ToInt32(Console.ReadLine());
                Console.Write("PROGRAM STUDI : ");
                string PRODI = Console.ReadLine();
                Console.Write("KELAS : ");
                string KELAS = Console.ReadLine();
            }
            Console.Write("\nPRINT HASIL ? (y/n)");
            string pilih = Console.ReadLine();
            if (pilih == "y")
            {
                Console.WriteLine("NO   NIM     NAMA            JENIS KELAMIN     TAHUN MASUK   PROGRAM STUDI   KELAS");
                
                Console.WriteLine();
                Console.Write("Tambah data ? (y/n)");
                string tambah = Console.ReadLine();
                if (tambah=="y")
                {
                    Console.Write("Berapa data yang ingin Anda input : ");
                    int jumlahdatalagi = Convert.ToInt32(Console.ReadLine());
                    for (int input = 0; input < jumlahdatalagi; input++)
                    {
                        Console.WriteLine($"\nData ke {jumlahdata + (input+1)} : ");
                        Console.Write("NIM : ");
                        int NIM = Convert.ToInt32(Console.ReadLine());
                        Console.Write("NAMA: ");
                        string NAMA = Console.ReadLine();
                        Console.Write("JENIS KELAMIN : ");
                        string JENIS = Console.ReadLine();
                        Console.Write("TAHUN MASUK: ");
                        int TAHUNMASUK = Convert.ToInt32(Console.ReadLine());
                        Console.Write("PROGRAM STUDI : ");
                        string PRODI = Console.ReadLine();
                        Console.Write("KELAS : ");
                        string KELAS = Console.ReadLine();
                    }
                }
                else
                    Console.Clear();
            }
            else
                Console.Clear();
        }
    }
}
