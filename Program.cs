// 1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

// 1->
Console.WriteLine("Sayi Adedini giriniz :");
int sayiAdet;
sayiAdet = int.Parse(Console.ReadLine());
int[] sayiDizi=new int[sayiAdet];
for (int i = 1; i <= sayiAdet; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz", i);
    sayiDizi[i - 1] = int.Parse(Console.ReadLine());
}
foreach (var sayi in sayiDizi)
{
    if (sayi % 2 == 0)
        Console.WriteLine("{0} sayısı çifttir", sayi);
}

// 2)Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
// 2->
Console.WriteLine("n saysını giriniz:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("m sayısını girimiz:");
int m = int.Parse(Console.ReadLine());
int[] sayiDizisi2 = new int[n];

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz:", i);
    sayiDizisi2[i - 1] = int.Parse(Console.ReadLine());
}
Console.WriteLine("{0} adet sayı girilmiştir. {1} sayısına eşit olan veya ona tam bölünenler aşağıda listelenecektir:", n, m);
foreach (var sayi in sayiDizisi2)
{
    if (sayi == m || sayi % m == 0)
        Console.WriteLine(sayi);
}

// 3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
// 3->
Console.WriteLine("Kelime Adedini Giriniz:");
int kelimeAdet = int.Parse(Console.ReadLine());
string[] kelimeDizisi = new string[kelimeAdet];
for (int i = 1; i <= kelimeAdet; i++)
{
    Console.WriteLine("{0}. kelimeyi giriniz:", i);
    kelimeDizisi[i - 1] = Console.ReadLine();
}
Console.WriteLine("Girilen Kelimelerin Sondan Başa Sıralaması");
for (int i = kelimeAdet - 1; i >= 0; i--)
{
    Console.WriteLine("{0}. kelime: {1}", i + 1, kelimeDizisi[i]);
}

// 4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
// 4->

Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();

//cümleyi boşluklara göre ayırıp diziye atayalım
string[] kelimeler = cumle.Split(' '); 

int kelimeSayisi = 0;
foreach (var kelime in kelimeler)
{
    if (kelime != "")  // boş olmayan kelimeleri sayar
        kelimeSayisi++;
}

int harfSayisi = 0;
foreach (char c in cumle)
{
    // Isletter A-Z arasını döner
    if (char.IsLetter(c))
        harfSayisi++;
}

Console.WriteLine("Toplam kelime sayısı: " + kelimeSayisi);
Console.WriteLine("Toplam harf sayısı: " + harfSayisi);