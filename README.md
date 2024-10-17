# Patika+ Week4 Constructor Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta Encapsulation için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Constructor Method yapısını öğrenmek

## İstenilen Görev
Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.

Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.


## Kod
```csharp
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
```
Araba sınıfı oluşturuldu. 1 adet constructor method oluşturuldu ve parametreler alındı. Set ve Get ile alınan ve okunan değerler kapsülleme yapıldı. kontrol edildi ve bizden istene işlemler yapıldı
Bilgileri ekranda göstermek için method yazıldı.

```csharp
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
```
Main method içinde sınıftan nesneler oluşturuldu. ilk iki nesne kurallara uygun olarak tanımlandı 2 ve 4 kapı numarası belirtildi ama en son nesne koşulumuza uygun olmayan bir numara girildi.




