using System.Collections.Generic;
using System;
using System.Linq;
using System.Runtime.Remoting.Channels;


// Türkiye'deki 81 ilin adında bu dört harften hangisi diğer üçünden daha az bulunur? 


class Program
{
    static void Main(string[] args)
    {
        List<string> str = new List<string>
        {
            "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", 
            "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", 
            "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", 
            "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", 
            "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa",
            "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun",  "Siirt",
            "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat",  "Zonguldak", 
            "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", 
            "Karabük", "Kilis", "Osmaniye", "Düzce"
        };

        string strs = string.Join("", str);
        strs = strs.ToLower();
        char[] chr = new char[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Seçenekleri giriniz :");
            chr[i] = Convert.ToChar(Console.ReadLine());
        }

        int total1 = strs.Count(c => c == chr[0]);
        int total2 = strs.Count(c => c == chr[1]);
        int total3 = strs.Count(c => c == chr[2]);
        int total4 = strs.Count(c => c == chr[3]);

        // En az bulunan karakteri bulmak için:

        int min = Math.Min(Math.Min(total1, total2), Math.Min(total3, total4));

        // En fazla bulunan karateri bulmak için:

        int max = Math.Max(Math.Max(total1, total2), Math.Max(total3, total4));

        Console.WriteLine(chr[0] + ":\t" + total1 + "\n" + chr[1] + ":\t" + total2 + "\n" + chr[2] + ":\t" + total3 + "\n" + chr[3] + ":\t" + total4);

        if (min == total1)
        {
            Console.WriteLine("En az bulunan sayı: " + chr[0]);
        }

        else if (min == total2)
        {
            Console.WriteLine("En az bulunan sayı: " + chr[1]);
        }

        else if (min == total3)
        {
            Console.WriteLine("En az bulunan sayı: " + chr[2]);
        }

        else if (min == total4)
        {
            Console.WriteLine("En az bulunan sayı: " + chr[3]);
        }

        else { Console.WriteLine("Equals."); }



        if (max == total1) 
        {
            Console.WriteLine("En fazla bulunan sayı: " + chr[0]);
        }
        else if (max == total2)
        {
            Console.WriteLine("En fazla bulunan sayı: " + chr[1]);
        }
        else if (max == total3)
        {
            Console.WriteLine("En fazla bulunan sayı: " + chr[2]);
        }
        else if (max == total4)
        {
            Console.WriteLine("En fazla bulunan sayı: " + chr[3]);
        }
        else
        {
            Console.WriteLine("Equals.");
        }
    }
}