//using System;
//using System.Diagnostics.Contracts;
//using System.Runtime.CompilerServices;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Mobil mobil1 = new Mobil("Toyota", "Canny", 2021);
//        Mobil mobil2 = new Mobil("Honda", "Jazz", 1998);

//        Mobil.roda = 4;
//        //Console.WriteLine(Mobil.penjumlahan(5,3));

//        //mobil1.tampilkanMobil("Toyota", "Canny", 2021);
//        //mobil2.merk = "Honda";
//        //Console.WriteLine(mobil1.merk);

//        mobil1.tampilkanMobil();
//        Console.WriteLine("========");
//        mobil2.tampilkanMobil();
//    }
//}

//class Mobil
//{
//    public string merk, model;
//    public int tahun;
//    public static int roda;

//    public Mobil(string merk, string model, int tahun)
//    {
//        this.merk = merk;
//        this.model = model;
//        this.tahun = tahun;
//    }



//    //    public void tampilkanMobil(string merk,string model,int tahun) {
//    //        Console.WriteLine("Merk : " + merk);
//    //        Console.WriteLine($"Model : {model}");
//    //        Console.WriteLine($"Tahun : {tahun}");
//    //    }
//    //}
//    public static int penjumlahan(int a, int b)
//    {
//        return a + b;
//    }
//    public void  tampilkanMobil()
//    {
//        Console.WriteLine("Merk : " + this.merk);
//        Console.WriteLine("Model : " + this.model);
//        Console.WriteLine($"Tahun : " +this.tahun);
//    }
//}