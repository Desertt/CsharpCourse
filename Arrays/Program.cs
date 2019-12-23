using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //TEK BOYUTLU DİZİLER
            //string[] students = new string[3];
            //students[0] = "Miraç";
            //students[1] = "Dağtekin";
            //students[2] = "Kazım";
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);


            //}
            //Console.ReadLine();

            string[] students2 = {"Kazım,Miraç,Dağtekin" };
            //string[] students2 = new string[3]{ "Kazım,Miraç,Dağtekin" };
            //students2[3] = "Ahmet";  Dizi sınırı aşıldı.
            foreach (var student in students2)
            {
                Console.WriteLine(student);
             

            }
            
            Console.ReadLine();
            */

            //ÇOK BOYUTLU DİZİLER

            //Multi dimensional,Türkiyenin Bölgeleri ve Bu bölgelerde ki en büyük 3 şehri -- Bölge ve Şehir 

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir", "Muğla", "Manisa"}

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadLine();
        }
    }
}
