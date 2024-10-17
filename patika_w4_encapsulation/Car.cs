using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_encapsulation
{
    public class Car
    {
        //Fields 
        private string brand;
        private string model;
        private string color;
        private int numberOfDoors;

        // Yapıcı method içine parametre alacak
        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand;  //gelen marka değeri özellik olan marka değerine atadık
            Model = model;  //gelen model değerini özellik olan model değerine atadık
            Color = color; //gelen renk değerini properties olan renk değerine atadık
            NumberOfDoors = numberOfDoors; //gelen kapı sayısı değerini properties olan renk değerine atadık
        }

        // Encapsulation
        public string Brand
        {
            get { return brand; } // Marka değerini almak için (okuma)
            set { brand = value; } // Dışarıdan yeni bir marka değeri atamak için (yazma)
        }
        public string Model
        {
            get { return model; } // Model değerini almak için
            set { model = value; } // Dışarıdan yeni bir marka değeri atamak için 
        }
        public string Color
        {
            get { return color; }  
            set { color = value; }
        }

        public int NumberOfDoors
        {

            get { return numberOfDoors; } // Kapı sayısı değerini aldık okuma

            set //kapı sayısı değerini atamak için 
            {
                if (value == 2 || value == 4) //eğer girilen değer 2 veya 4 ise kapı sayısı olrak atanacak
                {
                    numberOfDoors = value;
                }
                else //değilse hata yazısı ekranda gösterilecek ve kapı sayısı -1 olarak atanacak
                {
                    Console.WriteLine("Hata: Kapı sayısı yalnızca 2 veya 4 olabilir. Kapı sayısı -1 olarak ayarlandı");
                    numberOfDoors = -1;
                }
            }
        }

        public void Display() //bilgileri gösterme methodu
        {
            Console.WriteLine($"Arabanın Markası : {brand}");
            Console.WriteLine($"Arabanın Modeli  : {model}");
            Console.WriteLine($"Arabanın Rengi   : {color}");
            Console.WriteLine($"Arabanın Markası : {numberOfDoors}");
        }


    }
}
