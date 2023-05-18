
    double boy , kilo;
    double kiloBoyİndeksi;
    Console.WriteLine("Boyunuzu Metre Cinsinden Girin Örn; 1,85");
    boy = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Kilonuzu Girin");
    kilo = Convert.ToDouble(Console.ReadLine());

    kiloBoyİndeksi = kilo / (boy * boy);

    Console.WriteLine("Vücüt Kitle Endeksiniz  = " + kiloBoyİndeksi);
    if(kiloBoyİndeksi > 0 && kiloBoyİndeksi <= 18.5)
{
    Console.WriteLine("Zarganasın");
}
  else if (kiloBoyİndeksi > 18.6 && kiloBoyİndeksi <=25) {
    Console.WriteLine("Sağlıklı");
}
    else if (kiloBoyİndeksi >25 && kiloBoyİndeksi <=30)
{
    Console.WriteLine("Kilolu");
}
    else if(kiloBoyİndeksi >30 && kiloBoyİndeksi <= 40)
{
    Console.WriteLine("Şişman");
}
    else
{
    Console.WriteLine("Obezzzz");
}
