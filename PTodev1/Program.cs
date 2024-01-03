using System.Reflection.Metadata;

namespace PTodev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Sayı tahmin oyunu / Number guessing game ");
            Console.WriteLine("e=EASY(-20p) = sayı tahmin aralığı/number prediction range(0-50) & 8 hak/due");
            Console.WriteLine("m=MEDİUM(-10p) = sayı tahmin aralığı/number prediction range(0-100) & 16 hak/due");
            Console.WriteLine("h=HARD(-5p) = sayı tahmin aralığı/number prediction range(0-150) & 24 hak/due");

            Console.WriteLine("zorluk seçin/select difficulty(e/m/h)");
            string difficult =Console.ReadLine();

            if (difficult=="e")
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 50);
                int due = 8;
                int score = 100;

                while (true)
                {
                    Console.WriteLine("\n\n"+ due-- + "hakkınız var/you have rights");
                    if (due<0 || score == 0)
                    {
                        Console.WriteLine("kaybettiniz/you lost");
                        break;
                    }


                    Console.WriteLine("sayıyı tahmit edin/guess the number:");
                    int unumber = int.Parse(Console.ReadLine());




                    if (unumber > number)
                    {
                        Console.WriteLine("daha küçük bir sayı girin/enter a smaller number");
                        score = score - 20;
                        
                    }
                    else if (unumber<number)
                    {
                        Console.WriteLine("daha büyük bir sayı girin/enter a bigger number");
                        score = score - 20;
                    }
                    else
                    {
                        Console.WriteLine("kazandınız/you won!!!");
                    }
                }
            }
            else if (difficult=="m")
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 100);
                int due = 16;
                int score = 100;

                while (true)
                {
                    Console.WriteLine("\n\n" + due-- + "hakkınız var/you have rights");
                    if (due < 0 || score == 0)
                    {
                        Console.WriteLine("kaybettiniz/you lost");
                        break;
                    }

                    Console.WriteLine("sayıyı tahmit edin/guess the number:");
                    int unumber = int.Parse(Console.ReadLine());




                    if (unumber > number)
                    {
                        Console.WriteLine("daha küçük bir sayı girin/enter a smaller number");
                        score = score - 10;

                    }
                    else if (unumber < number)
                    {
                        Console.WriteLine("daha büyük bir sayı girin/enter a bigger number");
                        score = score - 10;
                    }
                    else
                    {
                        Console.WriteLine("kazandınız/you won!!!");
                    }
                }
            }
            else if(difficult=="h")
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 150);
                int due = 24;
                int score = 100;

                while (true)
                {

                    Console.WriteLine("\n\n" + due-- + "hakkınız var/you have rights");
                    if (due < 0 || score==0)
                    {
                        Console.WriteLine("kaybettiniz/you lost");
                        break;
                    }

                    Console.WriteLine("sayıyı tahmit edin/guess the number:");
                    int unumber = int.Parse(Console.ReadLine());




                    if (unumber == number)
                    {
                        Console.WriteLine("kazandınız/you won!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        score = score - 5;

                    }
                }
            }
            else 
            {
                Console.WriteLine("yanlış değer girdiniz/wrong input");
                    
            }



            //sayı tahmin oyununa seviye ve puan sistemi ekle github a yükle

        }
    }
}