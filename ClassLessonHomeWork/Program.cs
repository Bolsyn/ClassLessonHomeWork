using System;

namespace ClassLessonHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.Создать массив(не менее 5 элементов) объектов созданного класса.
            Airplane[] planes = { new Airplane(180,10,3000), new Airplane(240,8,6000), new Airplane(180,10,"KC275"), new Airplane(2450.5,4,600), new Airplane(5,2,150) };

        }
    }
}

// 9.Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial.
public partial class Airplane
{
    public void Flight()
    {
        Console.WriteLine("Airplane in flight");
    }

}