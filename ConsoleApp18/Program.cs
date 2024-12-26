using System;

public class Soldier
{
    private string lastName; // Фамилия
    private double height; // Рост
    private double weight; // Вес
    public Soldier(string lastName, double height, double weight)
    {
        this.lastName = lastName;
        this.height = height;
        this.weight = weight;
    }
    public double CalculateQuality()
    {
        return height * weight;
    }
    public string GetInfo()
    {
        return $"Солдат: {lastName}, Рост: {height} см, Вес: {weight} кг, Качество Q: {CalculateQuality()}";
    }
}

public class GraduateSoldier : Soldier
{
    private string education; // Образование
    public GraduateSoldier(string lastName, double height, double weight, string education)
        : base(lastName, height, weight)
    {
        this.education = education;
    }
    public new double CalculateQuality()
    {
        double Q = base.CalculateQuality();
        if (education.ToLower() == "высшее")
        {
            return 2;
        }
        else
        {
            return 0.5 * Q;
        }
    }
    public new string GetInfo()
    {
        return base.GetInfo() + $", Образование: {education}, Качество Qp: {CalculateQuality()}";
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите данные для солдата:");
        Console.Write("Фамилия: ");
        string lastName = Console.ReadLine();
        Console.Write("Рост (в см): ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Вес (в кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Soldier soldier = new Soldier(lastName, height, weight);
        Console.WriteLine(soldier.GetInfo());
        Console.WriteLine("\nВведите данные для выпускника солдата:");
        Console.Write("Фамилия: ");
        string gradLastName = Console.ReadLine();
        Console.Write("Рост (в см): ");
        double gradHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Вес (в кг): ");
        double gradWeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Образование (начальное/среднее/высшее): ");
        string education = Console.ReadLine();
        GraduateSoldier graduateSoldier = new GraduateSoldier(gradLastName, gradHeight, gradWeight, education);
        Console.WriteLine(graduateSoldier.GetInfo());
    }
}
