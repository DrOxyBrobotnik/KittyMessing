using System.Drawing;

namespace kittymessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*katt kitty = new katt("Pure white", "Katt", "Very");



            Console.WriteLine("Type of Katt:\n");


            Console.WriteLine(kitty.color);
            Console.WriteLine(kitty.name);
            Console.WriteLine(kitty.fluffiness);

            Console.WriteLine(
            $"Fluffiness: {kitty.fluffiness}\n" +
            $"Color: {kitty.color}\n" +
            $"Name: {kitty.name}"
);


            Bunny newBun = new Bunny("\nBunna");
            

            newBun.height = "Height: Tall\n";
            newBun.skintone = "Skintone: Yummy choclate\n";
            newBun.AssSize = "Ass size: Massive, plump, firm, and extremely grabbable";

            Console.WriteLine("Type of bunny\n\n" + newBun.height + newBun.skintone + newBun.AssSize);
           

            Console.ReadLine();
            

            var test = new TestClass2();
            test.Name = "This name";

            Console.WriteLine(test.Name);

            var KittyTests = new TestClass3();

            KittyTests.Rating = "Pogchamp";
            Console.Write(KittyTests.Rating);

            TestClass4 mystuff = new TestClass4();
            Console.WriteLine();*/

            TestClass4 moods = new TestClass4("Meh");
            Console.WriteLine(moods.mood);
        }
    }
}