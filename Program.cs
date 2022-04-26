using System;

namespace RW // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Human one = new Human();
            Manager two = new Manager();
            Dir three = new Dir();    
            one.Print();
            two.Print();
            three.Print();

            //List<Human> list = new List<Human>();
            ////Добавление совсем новых элементов как базы так и наследника
            //list.Add(new Human());
            //list.Add(new Dir());
            //list.Add(new Manager());


            ////Добавление сущестувющих элементов
            //Human human = new Human();
            //Dir dir = new Dir();
            //list.Add(human);
            //list.Add(dir);

            //Manager temp = (Manager)list[2];
            //temp.PrintX();
            //((Manager)list[2]).PrintX();


            ////использование рефлексии
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].GetType() == typeof(Dir))
            //    {
            //        Console.WriteLine("УРА");
            //    }
            //}
            //Console.WriteLine("-----");
            //foreach (Human human1 in list)
            //{

            //    if (human1.GetType() == typeof(Dir))
            //    {
            //        Console.WriteLine("УРА");
            //    }
            //}

            //Console.ReadLine();

      



        }
    }
}