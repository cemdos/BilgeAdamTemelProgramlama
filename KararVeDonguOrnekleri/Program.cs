using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KararVeDonguOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Örnek
            //int sayac = 1;
            //do
            //{
            //    //Console.WriteLine("{0}.Bilge Adam", sayac < 10 ? $"0{sayac}" : $"{sayac}");
            //    Console.WriteLine("{0} Bilge Adam", sayac.ToString().PadLeft(5, '0'));
            //    sayac++;
            //} while (sayac <= 10000);
            #endregion

            #region 2. Örnek
            //int sayi, toplam = 0;
            //Console.Write("Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Sonuc=" + toplam);
            #endregion

            #region 3. Örnek
            /*
             Sayı Giriniz = 5
             *
             **
             ***
             ****
             *****
             */
            //int sayi;
            //Console.Write("Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++) // Satırlar icin dönecek
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 4. Örnek
            //int sayi;
            //bool asalMi = true;
            //Console.Write("Sayı Giriniz=");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= sayi / 2 && asalMi; i++) //Bolen Degerler icin donecek
            //{
            //    if (sayi % i == 0)
            //        asalMi = false;
            //}

            //if (asalMi)
            //    Console.WriteLine("Asaldir");
            //else
            //    Console.WriteLine("Asal Degildir");
            #endregion

            #region 5. Örnek
            //int min, max;
            //Console.Write("Min = ");
            //min = int.Parse(Console.ReadLine());
            //Console.Write("Max = ");
            //max = int.Parse(Console.ReadLine());
            //Stopwatch stopwatch = new Stopwatch();

            //stopwatch.Start();
            //for (int i = min; i <= max; i++) // min max arasındaki sayılar icin dönecek
            //{
            //    bool asalMi = true;
            //    for (int j = 2; j <= i / 2 && asalMi; j++) //Bolen Degerler icin donecek
            //    {
            //        if (i % j == 0)
            //            asalMi = false;
            //    }
            //    if (asalMi)
            //        Console.WriteLine(i);
            //}
            //stopwatch.Stop();
            //Console.WriteLine("Çalışma Süresi:" + stopwatch.ElapsedMilliseconds);
            #endregion

            #region 6. Örnek
            //int min, max;
            //Console.Write("1. sayı = ");
            //while (!int.TryParse(Console.ReadLine(), out min))
            //    Console.Write("Geçersiz Veri\n1. Sayı = ");
            //Console.Write("2. sayı = ");
            //while (!int.TryParse(Console.ReadLine(), out max))
            //    Console.Write("Geçersiz Veri\n2. sayı = ");
            //if (max < min)
            //{
            //    int tempData = max;
            //    max = min;
            //    min = tempData;
            //}

            //for (int i = min; i <= max; i++)
            //    Console.WriteLine(i);
            #endregion

            #region 7. Örnek
            //int sayi;
            //Console.Write("Sayı Giriniz = ");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = sayi; i > 1; i--) //Satırlar icin
            //{
            //    for (int j = 0; j < i - 1; j++) // bosluk karakterlerini basar
            //        Console.Write(" ");
            //    Console.Write("*");
            //    for (int k = 0; k < 2 * (sayi - i) - 1; k++) // bosluk karakterlerini basar
            //        Console.Write(" ");
            //    if (sayi != i)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < sayi; i++)
            //    Console.Write("* ");
            #endregion

            #region 8. Örnek - Sayısal Loto Rastgele Kupon
            do
            {
                Console.Clear();
                Random random = new Random();
                for (char letter = 'A'; letter <= 'G'; letter++)
                {
                    string metin = $"{letter} :";
                    for (int i = 0; i < 6; i++)
                    {
                        int rand = random.Next(1, 50);
                        string value = rand.ToString().PadLeft(2, '0');
                        if (!metin.Contains(value))
                            metin += $" {value}";
                        else
                            i--;
                    }
                    Console.WriteLine(metin);
                }
                Console.WriteLine("Devam etmek için herahangi bir tuşa basın..");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            #endregion

            #region 9. Örnek
            //string text, screenText;
            //Console.Write("Metin Giriniz = ");
            //text = Console.ReadLine();
            //screenText = text;
            //while (true)
            //{
            //    for (int i = 0; i < Console.WindowWidth - screenText.Length; i++)
            //    {
            //        text = text.Insert(0, " ");
            //        Console.Clear();
            //        Console.Write(text);
            //        Thread.Sleep(10);
            //        if (i == Console.WindowWidth - screenText.Length - 1)
            //            ;

            //    }
            //    for (int i = 0; i < Console.WindowWidth - screenText.Length; i++)
            //    {
            //        text = text.Remove(0, 1);
            //        Console.Clear();
            //        Console.Write(text);
            //        Thread.Sleep(10);
            //    }
            //}
            #endregion

            #region 10. Örnek
            //int number, remainder;
            //string result = "";
            //bool isNegative;
            //Console.Write("Sayı Giriniz = ");
            //number = int.Parse(Console.ReadLine());
            //isNegative = number < 0;
            //number = isNegative ? (number * (-1)) : number;
            //while (number >= 2)
            //{
            //    remainder = number % 2;
            //    result = result.Insert(0, remainder.ToString());
            //    number /= 2;
            //}
            //result = result.Insert(0, number.ToString());
            //result = result.PadLeft(7, '0');
            //result = result.Insert(0, (isNegative ? "1" : "0"));
            //Console.WriteLine("Sonuc = " + result);
            #endregion

            #region 11. Örnek
            //int number, sum = 0;
            //Console.Write("Sayı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number / 2; i++) //Tam Bolenleri bulmak icin döndügümüz döngü
            //{
            //    if (number % i == 0)
            //        sum += i;
            //}
            //if (number == sum)
            //    Console.WriteLine("Mükemmel Sayıdır");
            //else
            //    Console.WriteLine("Mükemmel Sayı Degildir");
            #endregion

            #region 12. Örnek
            //Random rnd = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    int sum = 0;
            //    int number = rnd.Next(1, 101);
            //    for (int j = 1; j <= number / 2; j++) //Tam Bolenleri bulmak icin döndügümüz döngü
            //    {
            //        if (number % j == 0)
            //            sum += j;
            //    }
            //    if (number == sum)
            //        Console.WriteLine($"{number}: Mükemmel Sayıdır");
            //    else
            //        Console.WriteLine($"{number}: Mükemmel Sayı Degildir");
            //}
            #endregion

            #region 13. Örnek
            //int number, stepDigit, sum = 0;
            //Console.Write("Sayı Giriniz = ");
            //number = int.Parse(Console.ReadLine());
            //stepDigit = number.ToString().Length;
            //for (int i = 0; i < stepDigit; i++)
            //{
            //    //int digitNumber = int.Parse(number.ToString()[i].ToString());
            //    int digitNumber = int.Parse(number.ToString().Substring(i, 1));
            //    sum += (int)Math.Pow(digitNumber, stepDigit);
            //}

            //if (sum == number)
            //    Console.WriteLine("Amstrong Sayıdır.");
            //else
            //    Console.WriteLine("Amstrong Sayı Degildir");
            #endregion

            #region 14.Örnek
            //string username, password;
            //bool isLogin;
            //do
            //{
            //    Console.Write("Kullanıcı Adı = ");
            //    username = Console.ReadLine();
            //    username = username.ToLower().Replace(" ", string.Empty);
            //    Console.Write("Şifre = ");
            //    password = Console.ReadLine();
            //    password = password.ToLower().Replace(" ", String.Empty);
            //    isLogin = username == "bilgeadam" && password == "1234";
            //    if (!isLogin)
            //        Console.WriteLine("Kullanıcı Adı ya da şifre yanlış");
            //} while (!isLogin);
            //Console.WriteLine("Hoşgeldiniz");
            #endregion

            #region 15.Örnek
            //do
            //{
            //    Console.Clear();
            //    int number1, number2;
            //    float result = 0;
            //    char action;
            //    Console.Write("1. Sayı =");
            //    number1 = int.Parse(Console.ReadLine());
            //    Console.Write("İşlem (+-*/) = ");
            //    action = Console.ReadKey().KeyChar;
            //    Console.Write("\n2. Sayı =");
            //    number2 = int.Parse(Console.ReadLine());
            //    switch (action)
            //    {
            //        case '+': result = number1 + number2; break;
            //        case '-': result = number1 - number2; break;
            //        case '*': result = number1 * number2; break;
            //        case '/': result = (float)number1 / number2; break;
            //        default: Console.WriteLine("Geçersiz işlem seçildi."); break;
            //    }
            //    if (action == '+' || action == '-' || action == '*' || action == '/')
            //        Console.WriteLine("Sonuc = " + Math.Round(result,2));
            //    Console.WriteLine("Devam etmek için bir tuşa basın..\nÇıkmak için esc tuşuna basın..");
            //} while (Console.ReadKey().Key != ConsoleKey.Escape);
            #endregion

            #region 16.Örnek
            //do
            //{
            //    Console.Clear();
            //    Random rnd = new Random();
            //    int counter = 0;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int number1 = rnd.Next(1, 7);
            //        int number2 = rnd.Next(1, 7);
            //        Console.WriteLine($"Atılan Zar : {number1} - {number2}");
            //        if (number1 == number2)
            //            counter++;
            //    }
            //    Console.WriteLine($"Atılan Zarlardan {counter} tanesi aynı geldi.");
            //    Console.WriteLine("Devam etmek için bir tuşa basın..\nÇıkmak için esc tuşuna basın..");
            //} while (Console.ReadKey().Key != ConsoleKey.Escape);
            #endregion

            #region 17. Örnek
            //string ages = "";
            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.Write("{0}. Öğrencinin yaşı = ",i);
            //    byte age = byte.Parse(Console.ReadLine());
            //    if (age > 31)
            //    {
            //        Console.WriteLine("Geçersiz yaş");
            //        i--;
            //    }
            //    int remainder;
            //    string ageResult = "";
            //    while (age >= 2)
            //    {
            //        remainder = age % 2;
            //        ageResult = ageResult.Insert(0, remainder.ToString());
            //        age /= 2;
            //    }
            //    ageResult = ageResult.Insert(0, age.ToString());
            //    ageResult = ageResult.PadLeft(5, '0');
            //    ages = ages.Insert(0, ageResult);
            //}
            //ages = ages.PadLeft(32, '0');
            //Console.WriteLine(ages);
            #endregion

            #region 18. Örnek - Mod Sayacı

            //for (int i = 1; i < 4; i++) //Yüzler basamagı icin dönecek
            //    for (int j = 0; j < 4; j++) // Onlar Basamagı icin dönecek
            //        for (int k = 0; k < 4; k++) //Birler Basamagı
            //            Console.WriteLine("{0}{1}{2}",i,j,k);

            #endregion

            #region 19. Örnek - İşaretli ve Ondalıklı olan sayıların binary sisteme mapping işlemi
            //while (true)
            //{
            //    float sayi;
            //    Console.Write("Sayı Giriniz = ");
            //    sayi = float.Parse(Console.ReadLine());

            //    int tamsayi, ondalikSayi = 0;
            //    string sonuc = "";
            //    bool NegatifMi = sayi < 0;

            //    sayi = NegatifMi ? sayi * (-1) : sayi;
            //    tamsayi = (int)sayi;
            //    if (sayi.ToString().Contains(","))
            //    {
            //        string ondalikSayiString = sayi.ToString().Split(',')[1];
            //        ondalikSayiString = ondalikSayiString.PadRight(3, '0');
            //        ondalikSayi = int.Parse(ondalikSayiString);
            //    }                

            //    while (tamsayi >= 2)
            //    {
            //        int kalan;
            //        kalan = tamsayi % 2;
            //        sonuc = sonuc.Insert(0, kalan.ToString());
            //        tamsayi /= 2;
            //    }
            //    sonuc = sonuc.Insert(0, tamsayi.ToString());
            //    sonuc = " " + sonuc.PadLeft(8, '0');

            //    while (ondalikSayi >= 2)
            //    {
            //        int kalan;
            //        kalan = ondalikSayi % 2;
            //        sonuc = sonuc.Insert(0, kalan.ToString());
            //        ondalikSayi /= 2;
            //    }
            //    sonuc = sonuc.Insert(0, ondalikSayi.ToString());
            //    sonuc = " " + sonuc.PadLeft(17, '0');
            //    sonuc = sonuc.Insert(0, (NegatifMi ? "1" : "0"));

            //    Console.WriteLine("Sonuc=" + sonuc);
            //}

            #endregion

        }
    }
}