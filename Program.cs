using System.ComponentModel.Design;

Console.WriteLine("Faturanızı Giriniz:");
double tutar = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Öğrenci Misiniz:(true/false)");
Boolean Öğrenci_mi = Convert.ToBoolean(Console.ReadLine());
 
if(tutar >= 650 && Öğrenci_mi == true)
{
    double YeniTutar = tutar * 0.6;
    Console.WriteLine("Yeni tutarınız: " + YeniTutar  );
}
 else if (tutar >= 650 || Öğrenci_mi == true){
    double YeniTutar = tutar * 0.8;
    Console.WriteLine("Yeni tutarınız: " + YeniTutar );
}
else
{
    Console.WriteLine("Tutarınız: " + tutar );

}
