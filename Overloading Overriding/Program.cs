// See https://aka.ms/new-console-template for more information

Console.WriteLine("Over Loading");
NumberHelper.GetANumber();
NumberHelper.GetANumber(5,50);

Console.WriteLine("Over Riding");

CargoService pTT = new PTTService();
CargoService sTT = new SuratService();
CargoService ssTT = new StandartService();

pTT.Send();
sTT.Send();
ssTT.Send();

Console.ReadKey();

//Overloading
internal class NumberHelper
{
    public static void GetANumber()
    {
        Random random = new Random();
        Console.WriteLine(random.Next(0, 100).ToString()); 
    }
    public static void GetANumber(int startValue , int endValue)
    {
        if (startValue>= endValue)
        {
            var ex = new Exception("Başlangıç Değeri bitiş değerinden küçük olmalı");
            Console.Write(ex);
        }    
        Random random = new Random();
        Console.WriteLine(random.Next(startValue, endValue).ToString());
    }
}

//Overriding

internal class CargoService
{
    public virtual void Send()
    {
        Console.WriteLine("Gönderi gönderildi.");
    }
}

internal class StandartService : CargoService
{

}

internal class PTTService : CargoService
{
    public override void Send()
    {
        Console.Write($"Ptt kargo number - PK");
        NumberHelper.GetANumber();
        base.Send();
    }
}

internal class SuratService : CargoService
{
    public override void Send()
    {
        Console.Write("Sürat kargo number - SK");
        NumberHelper.GetANumber(100,1000);
        base.Send();
    }
}