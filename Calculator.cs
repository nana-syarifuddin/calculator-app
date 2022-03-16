class Calculator
{
	static void Main(String[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.Writeline("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.Writeline("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.Writeline("\nTekan sembarang key untuk keluar");
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
}