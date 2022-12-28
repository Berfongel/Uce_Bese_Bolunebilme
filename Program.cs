// See https://aka.ms/new-console-template for more information
int sayi;
Console.WriteLine("Bir sayı giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 3 == 0 && sayi % 5 == 0)
{
    Console.WriteLine("Girdiğiniz sayı  3'e ve 5'e bölünüyor. ");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 3'e ve 5'e tam bölünmüyor");
}
