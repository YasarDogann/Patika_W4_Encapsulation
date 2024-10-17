namespace patika_w4_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Araba Nesnesi 
            Car bmw = new Car("BMW", "M5", "Siyah", 2);
            bmw.Display();

            Console.WriteLine("\r\n----------------------------------------------\r\n");
            // 2. Araba nesnesi
            Car honda = new Car("Honda", "Civic", "Gırmızı", 4);
            honda.Display();

            Console.WriteLine("\r\n----------------------------------------------\r\n");

            //3. Araba nesnesinde kapı sayısı 5 girildiği için hata yazısı çıkacak ve kapı sayısı -1 olacak
            Car volkswagen = new Car("Volkswagen", "Golf5 - R32", "Sarı", 5);
            volkswagen.Display();
        }
    }
}
