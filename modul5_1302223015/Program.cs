namespace modul5_1302223015
{
    internal class Program
    {

        public class Penjumlahan
        {
        
            public static T JumlahTigaAngka<T> (T angka1, T angka2, T angka3)
            {
                dynamic Angka1 = angka1;
                dynamic Angka2 = angka2;
                dynamic Angka3 = angka3;
                return angka1 + Angka2 + Angka3;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 22));
        }
    }
}
