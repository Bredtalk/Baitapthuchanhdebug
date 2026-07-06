using Microsoft.Win32.SafeHandles;

Console.WriteLine("=======ATM=======");
Console.WriteLine("Nhap so du tai khoan");
int sodu = int.Parse(Console.ReadLine());
chon:
Console.WriteLine("1. Xem so du, 2. Rut tien, 3. Thoat");
string choice = Console.ReadLine();
switch (choice)
{
    case "1" : Console.WriteLine("So du cua ban la {0}", sodu); break;
    case "2" : goto Ruttien; break;
    case "3" : goto ketthuc; break;
    default: Console.WriteLine("vui long chon lai"); break;
}
Ruttien:
try
{
    Console.WriteLine("Nhap so tien muon rut");
    int sotienrut = int.Parse(Console.ReadLine());
    int sotiendu = sodu - sotienrut;

    if (sotienrut > sodu)
    {
        throw new Exception("Ban khong the rut nhieu hon so du cua minh");
    }

    if (sotienrut <= 0)
    {
        throw new Exception("So tien rut phai lon hon 0");
    }
Console.WriteLine("So tien con du cua ban la {0}", sotiendu);
}
catch (FormatException)
{
    Console.WriteLine("Ban phai nhap so");
}
catch (Exception ex)
{
    Console.WriteLine($"Loi: {ex.Message}");
}
finally
{
    Console.WriteLine("Giao dich thanh cong. Xin cam on");
}
ketthuc:
Console.WriteLine("Hen gap lai lan sau!");