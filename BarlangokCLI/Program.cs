using BarlangokCLI;
using System.Text;

const string PATH = "C:\\PROJECTS\\CSHARP25011302\\BarlangokCLI\\RESOURCES\\barlangok.txt";

List<Barlang> barlangok = [];
StreamReader sr = new(PATH, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"F4: barlangok szama: {barlangok.Count}");

var f5 = barlangok
    .Where(b => b.Telepules.StartsWith("Miskolc"))
    .Average(b => b.Melyseg);
Console.WriteLine($"F5: atlagos melyseg: {f5:0.000} m");

Console.Write("F6: kerem a vedettsegi szintet: ");
string f6vsz = Console.ReadLine();
var f6 = barlangok
    .Where(b => b.Vedettseg == f6vsz)
    .MaxBy(b => b.Hossz);
Console.WriteLine(f6 is null
    ? "\tnincs ilyen vedettsegi szinttel barlang az adatok kozt"
    : f6);

var f7grps = barlangok.GroupBy(b => b.Vedettseg);
foreach (var grp in f7grps)
    Console.WriteLine($"\t{(grp.Key + ':').PadRight(
        barlangok.Max(b => b.Vedettseg.Length) + 4, '-')}>{grp.Count(), 4} db");

