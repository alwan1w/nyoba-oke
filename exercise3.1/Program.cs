using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class IPKKLSC
    {
        public double NIM;
        public string Nama, Kelas;
        public void InputIPK()
        {
            Console.WriteLine("=================IPK=================");
            Console.WriteLine("-------------------------------------");
            Console.Write("Masukkan NIM: ");
            NIM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nama: ");
            Nama = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Kelas: ");
            Kelas = Convert.ToString(Console.ReadLine());

        }
        public void ipkarray()

        {
            string[] array1 = new string[6];
            int[] array2 = new int[6];
            string[] array3 = new string[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("\nMasukkan Nama Matakuliah:");
                array1[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Masukkan Nilai Angka:");
                array2[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan Nilai Huruf:");
                array3[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Transkip Kuliah");
            Console.WriteLine("---------------");
            Console.WriteLine("NIM :" + NIM);
            Console.WriteLine("Nama:" + Nama);
            Console.WriteLine("Kelas:" + Kelas);
            Console.WriteLine("----------------\n");

            Console.WriteLine("Transkip Mahasiswa dengan NIM:" + NIM);
            Console.WriteLine("------------------------------");
            Console.Write("Mata Kuliah\t");
            Console.Write("Nilai Angka\t");
            Console.Write("Nilai Huruf\t");


            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n");
                Console.Write("{0}\t", array1[i]);
                Console.Write("{0}\t", array2[i]);
                Console.Write("{0}\t", array3[i]);

            }


        }
        public class KARTUKELUARGA
        {

            public void arrayKK()
            {
                Console.WriteLine("================Kartu Keluarga================");
                Console.WriteLine("----------------------------------------------");

                string[] array4;
                string[] array5;
                string[] array6;
                int ukuran;
                Console.Write("\nMasukkan Jumlah Anggota Keluarga : ");
                ukuran = Convert.ToInt32(Console.ReadLine());

                array4 = new string[ukuran];
                array5 = new string[ukuran];
                array6 = new string[ukuran];

                for (int i = 0; i < ukuran; i++)
                {
                    Console.Write("Masukkan Nama Lengkap : ");
                    array4[i] = Convert.ToString(Console.ReadLine());

                    Console.Write("Masukkan Pendidikan Terakhir : ");
                    array5[i] = Convert.ToString(Console.ReadLine());

                    Console.Write("Masukkan Status : ");
                    array6[i] = Convert.ToString(Console.ReadLine());


                }
                Console.WriteLine("");
                Console.WriteLine("Data Kartu Keluarga");
                Console.WriteLine("-------------------");
                Console.Write("Nama Lengkap\t");
                Console.Write("Pendidikan Terakhir\t");
                Console.Write("Status\t");

                for (int i = 0; i < ukuran; i++)
                {
                    Console.Write("\n");
                    Console.Write("{0}\t", array4[i]);
                    Console.Write("{0}\t", array5[i]);
                    Console.Write("{0}\t", array6[i]);
                }

            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                IPKKLSC ipk = new IPKKLSC();
                KARTUKELUARGA kk = new KARTUKELUARGA();

                int pilih;
                string ulang;
                ulang = "Y";
                while (ulang == "Y" || ulang == "y")

                {
                    Console.WriteLine("================Menu Utama===============");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("1. IPK");
                    Console.WriteLine("2. Kartu Keluarga ");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Silahkan Pilih Menu = ");
                a:
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");


                    switch (pilih)
                    {
                        case 1:
                            ipk.InputIPK();
                            ipk.ipkarray();
                            break;
                        case 2:
                            kk.arrayKK();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Maksukkan Menu Utama yang benar! ");
                            Console.ReadKey();
                            goto a;


                    }
                    Console.WriteLine(" ");
                    Console.Write(" Apakah Akan Kembali ke Menu Utama (Y/N) ");
                    ulang = Console.ReadLine();
                    Console.Clear();


                }
            }
        }
    }
}