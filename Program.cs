using System;

class Praktikum_AP_Week_13
{
	static void Main(string[] args)
	{
		string nomor = "NO";
		string nim = "NIM";
		string nama = "NAMA";
		string jenisKelamin = "JENIS KELAMIN";
		string tahunMasuk = "TAHUN MASUK";
		string programStudi = "PROGRAM STUDI";
		string kelas = "KELAS";
		while (true)
		{
			Console.Write("Berapa data = ");
			int banyakData = Convert.ToInt32(Console.ReadLine());
			string[,] data = new string[banyakData, 6];
			Console.Write("\n");
			for (int pengulanganInputData = 0; pengulanganInputData < banyakData; pengulanganInputData++)
			{
				Console.Write($"Data ke - {pengulanganInputData + 1} \nNIM                 : ");
				data[pengulanganInputData, 0] = Console.ReadLine();
				Console.Write("NAMA                : ");
				data[pengulanganInputData, 1] = Console.ReadLine();
				Console.Write("JENIS KELAMIN       : ");
				data[pengulanganInputData, 2] = Console.ReadLine();
				Console.Write("TAHUN MASUK         : ");
				data[pengulanganInputData, 3] = Console.ReadLine();
				Console.Write("PROGRAM STUDI       : ");
				data[pengulanganInputData, 4] = Console.ReadLine();
				Console.Write("KELAS               : ");
				data[pengulanganInputData, 5] = Console.ReadLine();
				Console.Write("\n");
			}
			Console.Write("PRINT HASIL? (y/n) . . . ");
			string printHasil = Console.ReadLine();
			if (printHasil == "y")
			{
				Console.Clear();
				Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-28}{3,-18}{4,-15}{5,-18}{6,5}", nomor, nim, nama, jenisKelamin, tahunMasuk, programStudi, kelas));
				Console.Write("\n");
				for (int pengulanganCetak = 0; pengulanganCetak < banyakData; pengulanganCetak++)
					Console.WriteLine(String.Format("{0,-5}{1,-8}{2,-28}{3,-18}{4,-15}{5,-18}{6,5}", (pengulanganCetak + 1), data[pengulanganCetak, 0], data[pengulanganCetak, 1], data[pengulanganCetak, 2], data[pengulanganCetak, 3], data[pengulanganCetak, 4], data[pengulanganCetak, 5]));
				Console.Write("\nTambah data? (y/n) . . . ");
				string penambahanData =	Console.ReadLine();
				Console.Write("\n");
				if (penambahanData == "n")
					System.Environment.Exit(0);
			}
			else if (printHasil == "n")
				System.Environment.Exit(0);
		}
	}
}