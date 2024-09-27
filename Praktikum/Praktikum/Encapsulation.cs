//using System;
//using System.Security.Cryptography;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Programmer programmer1 = new Programmer();
//        programmer1.nama = "Raden";
//        programmer1.tampilkanData();

//        //Employee employee1 = new Employee();
//        //employee1.setID(1);
//        //Console.WriteLine(employee1.getID());

//        programmer1.aksesDb();
//        programmer1._serverKey = 123;
//        Console.WriteLine((programmer1._serverKey));

//    }
//}

//public class Employee
//{
//    private int id;
//    public string nama;

//    protected void getDivisi()
//    {
//        id = 5;
//        Console.WriteLine("Employee Perusahaan UNEJ");
//    }
//    public int getID()
//    {
//        return id;
//    }

//    public void setID(int id)
//    {
//        id = id;
//    }
//}

//public class Programmer : Employee
//{
//    private double gaji = 10000;
//    private long serverKey;

//    public long _serverKey
//    {
//        get { return serverKey; }
//        set { serverKey = value; }
//    }

//    public void tampilkanData()
//    {
//        getDivisi();
//        Console.WriteLine($"Gaji : {gaji}");
//        //Console.WriteLine((employee1.getID());
//    }

//    public void aksesDb()
//    {
//        Console.WriteLine("A");
//    }
//}

//// Kriteria Kelas Student:
//// Atribut:

//// Nama(name): hanya bisa diakses dan dimodifikasi dari luar kelas.
//// NIM (Nomor Induk Mahasiswa) (nim): tidak boleh diakses langsung dari luar kelas,
//// tetapi bisa dimodifikasi dan dilihat melalui properti.
//// IPK (Indeks Prestasi Kumulatif) (gpa): tidak boleh diakses
//// atau diubah langsung dari luar kelas.
//// Hanya bisa diubah jika nilainya valid (nilai antara 0.0 dan 4.0).
//// Fungsi:

//// Sebuah method DisplayInfo() untuk menampilkan
//// informasi lengkap tentang mahasiswa (Nama, NIM, IPK).
//// Properti untuk mengakses dan memodifikasi
//// NIM dan IPK sesuai aturan yang sudah disebutkan di atas.

public class Student
{
    private string name;
    private string nim;
    private double gpa;

    public Student(string name, string nim, double gpa)
    {
        this.name = name;
        this.nim = nim;
        this.Gpa = gpa; // Menggunakan property setter untuk validasi
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Nim
    {
        get { return nim; }
        set { nim = value; }
    }

    public double Gpa
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0 && value <= 4.0)
            {
                gpa = value;
            }
            else
            {
                throw new ArgumentException("IPK harus antara 0.0 dan 4.0");
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Nama: {name}");
        Console.WriteLine($"NIM: {nim}");
        Console.WriteLine($"IPK: {gpa}");
    }
}

//class Program
//{
//    Student mahasiswa1 = new Student("John Doe", "12345678", 3.5);

//    // Mengakses dan memodifikasi atribut
//    Console.WriteLine(mahasiswa1.Name); // Output: John Doe
//mahasiswa1.Name = "Jane Smith";
//Console.WriteLine(mahasiswa1.Name); // Output: Jane Smith

//// Mencoba mengubah IPK
//mahasiswa1.Gpa = 3.8;

//// Menampilkan informasi mahasiswa
//mahasiswa1.DisplayInfo();
//}
