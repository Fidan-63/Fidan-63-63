string Sistem_kullanıcısı = "admin";
string Sistem_şifresi = "6363.";


Console.WriteLine("Kullanıcı adınızı giriniz: ");
string girilen_kullanıcı_adı = Console.ReadLine();

Console.WriteLine("Kullancı şifrenizi girniz: ");
string girilen_şifre = Console.ReadLine();

if(girilen_kullanıcı_adı== Sistem_kullanıcısı && girilen_şifre == Sistem_şifresi)
{
    Console.WriteLine("Giriş Başarılı, Hoş geldiniz !");
}
else if ( girilen_kullanıcı_adı == Sistem_şifresi || girilen_şifre== Sistem_şifresi)
{
    Console.WriteLine("Kullanıcı adı veya Şifre Hatalı, Tekrar Deneyiniz !");
}
else
{
    Console.WriteLine("Giriş Başarısız !");
}