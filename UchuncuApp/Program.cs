using System;

namespace UchuncuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User tərəfindən daxil edilmiş ədədin 2 mislini(2-yə vurmaq) console-da çap edin;
            Console.WriteLine("Eded daxil edin");
            int userinEdedi = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Ededin 2 ile hasili = " + (userinEdedi*2));
        }
    }
}
