internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        //Expression
        switch (month)
        {
            case 1:
                Console.WriteLine("Ocak");
                break;
            case 2:
                Console.WriteLine("Subat");
                break;
            case 3:
                Console.WriteLine("Mart");
                break;
            case 4:
                Console.WriteLine("Nisan");
                break;
            case 5:
                Console.WriteLine("Mayis");
                break;
            case 6:
                Console.WriteLine("Haziran");
                break;
            case 7:
                Console.WriteLine("Temmuz");
                break;
            case 8:
                Console.WriteLine("Agustos");
                break;
            case 9:
                Console.WriteLine("Eylul");
                break;
            case 10:
                Console.WriteLine("Ekım");
                break;
            case 11:
                Console.WriteLine("Kasim");
                break;
            case 12:
                Console.WriteLine("Aralik");
                break;
            default:
                Console.WriteLine("Yanlis veri girisi");
            break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kis ayindasiniz");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Ilkbahar ayindasiniz");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz ayindasiniz");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar ayindasiniz");
                break;
            default:
                Console.WriteLine("Yanlis veri girisi");
            break;
        }
    }
}