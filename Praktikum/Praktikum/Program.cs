using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil();
        Mobil mobil2 = new Mobil();

        mobil1.tampilkanMobil("Toyota","Canny",2021);
        mobil2.merk = "Honda";
    }
}

class Mobil
{
    public string merk, model;
    public int tahun;
    public string kata = "Mobil Baru";

    public void tampilkanMobil(string merk,string model,int tahun) {
        Console.WriteLine("Merk : " + merk);
        Console.WriteLine($"Model : {model}");
        Console.WriteLine($"Tahun : {tahun}");
    }
}