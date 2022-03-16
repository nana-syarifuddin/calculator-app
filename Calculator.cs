class Calculator
{
	static void Main(String[] args)
	{
		Console.Title = "Aplikasi Kalkulator";

        // int a = 10; // declarasi variabel a, dg nilai awal 10;
        // int b = 6; // declarasi variabel b, dg nilai awal 6;

        Console.Write("Pilih menu calculator:");
        Console.WriteLine();
        Console.Write("\n1. Penambahan");
        Console.Write("\n2. Pengurangan");
        Console.Write("\n3. Perkalian");
        Console.Write("\n4. Pembagian");

        Console.Write("\n\nInput nomor menu [1..4]: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (p == 1)
        {
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

        else if (p == 2)
        {
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
        }

        else if (p == 3)
        {
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
        }

        else if (p == 4)
        {
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); // proses casting

            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
        }

        else
        {
            Console.Write("Maaf, menu yang Anda pilih tidak tersedia");
            Console.WriteLine();
        }

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
	}
	
	static void Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static void Pengurangan(int a, int b)
	{
		return a - b;
	}
	
	static int Perkalian(int a, int b)
    {
        return a * b;
    }

    static int Pembagian(int a, int b)
    {
        return a / b;
    }
	
}