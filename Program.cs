using System.Text;

public class BàiTập8
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();
        Console.WriteLine("Chào bạn, " + ten + "!");
    }
}