using System;

class Program
{
    static void Main(string[] args)
    {
        Programmer programmer1 = new Programmer();
        programmer1.nama = "Raden";
    }
}

public class Employee
{
    private int id;
    public string nama;
    protected int divisi;

    protected void getDivisi()
    {
        Console.WriteLine("Employee Perusahaan UNEJ");
    }
}

public class Programmer : Employee
{
    private long ipAddress;

}