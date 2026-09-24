//2.feladat
List<int> bevetel = new List<int>();
Console.WriteLine("=== Kávézó Heti Bevételek Rögzítése ===");
for(int i=0; i<5;i++)
{
    Console.Write($"{i+1}. nap bevétele (Ft): ");
    int napi = int.Parse(Console.ReadLine());
    bevetel.Add(napi);
}
Console.WriteLine("Adatok feldolgozása...");
Console.WriteLine("========================================");
Console.WriteLine("Rögzített napi bevételek:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\t {i + 1}.nap {bevetel[i]} Ft");
}
//3.feladat
int osszeg = 0;
for (int i = 0; i < 5; i++)
{
   osszeg += bevetel[i];
}
double atlag = osszeg / 5.0;
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összesített bevétel: {osszeg} Ft");
Console.WriteLine($"Napi átlagbevétel: {atlag:F2} Ft");
//4.feladat
string status;
if (atlag >= 80000)
{
    status="kiemelkedő hét";
}
else if (atlag >= 50000)
{
    status = "Átlagos hét";
}
else
{
    status = "Gyenge hét,felülviszgálat szükséges";
}
Console.WriteLine($"Heti státusz: {status}");
Console.WriteLine("========================================");