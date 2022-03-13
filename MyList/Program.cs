using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list[1] = 3;
            list.Remove(1);

            for (int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
