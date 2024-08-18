internal class Program
{
    public static void Main(string[] args)
    {
		try
		{
            Console.WriteLine("Bir sayı giriniz : ");
			int number = Convert.ToInt32(Console.ReadLine());                   //Girilen sayı kullanıcıdan alındı
            int numberSquare = number * number;                                 //Karesi hesaplanıp bir değişkene atandı

            Console.WriteLine("Girdiğiniz sayının karesi : " + numberSquare);

        }
		catch (Exception)
		{

            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");      //Eğer kullanıcı sayısal değer girmezse hata mesajı alır
        }   
    }
}