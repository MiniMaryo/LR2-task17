using System;
using System.Collections.Generic;

// Базовый класс Точка
class Точка
{
    // свойства
    public int X { get; set; }
    public int Y { get; set; }

    public Точка(int x, int y)
    {
        X = x;
        Y = y;
    }

    // методы
    public virtual void Показать()
    {
        Console.WriteLine($"Точка: X = {X}, Y = {Y}");
    }

    public virtual void Нарисовать()
    {
        Console.WriteLine("рисуем точку");
    }
}

// Производный класс Цветная точка
class ЦветнаяТочка : Точка
{
    // свойство
    public string Цвет { get; set; }

    public ЦветнаяТочка(int x, int y, string цвет) : base(x, y)
    {
        Цвет = цвет;
    }

    public override void Показать()
    {
        Console.WriteLine($"Цветная точка: X = {X}, Y = {Y}, Цвет = {Цвет}");
    }

    public override void Нарисовать()
    {
        Console.WriteLine($"Рисуем точку цвета {Цвет}");
    }
}

// Производный класс Трехмерная точка
class ТрехмернаяТочка : Точка
{
    // свойство
    public int Z { get; set; }

    public ТрехмернаяТочка(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }

    public override void Показать()
    {
        Console.WriteLine($"Трехмерная точка: X = {X}, Y = {Y}, Z = {Z}");
    }

    public override void Нарисовать()
    {
        Console.WriteLine($"Координаты точки {X}, {Y}, {Z}");
    }
}

class Program
{
    static void Main()
    {
        // создание объектов
        Точка t1 = new Точка(1, 2);
        Точка t2 = new ЦветнаяТочка(3, 4, "красный");
        Точка t3 = new ТрехмернаяТочка(5, 6, 7);

        // коллекция
        List<Точка> точки = new List<Точка> { t1, t2, t3 };

        // вызов методов в цикле
        foreach (Точка t in точки)
        {
            t.Показать();
            t.Нарисовать();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
