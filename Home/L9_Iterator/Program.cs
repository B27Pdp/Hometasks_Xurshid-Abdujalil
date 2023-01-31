// See https://aka.ms/new-console-template for more information
#region 1
List<string> names = new() { "Salima","Nozima","Muslima","Madina","Sitora" };
names.Add("Anvar");
names.Add("Sanjar");
names.Add("Sarvar");
names.Add("Bobur");
names.Add("Salim");

foreach (var item in names)
{
    Console.WriteLine(item);
}Console.WriteLine("\v");

names.Add("Xurshid");
names[9] = "Abdujalilov";
names[8] = "Abdujalilov";

string[] names1 =names.ToArray();

foreach (var item in names1)
{
    Console.WriteLine(item);
}Console.WriteLine("\v");


//IEnumerable<string> result=names1.ToList().SkipWhile(x => x == "Xurshid" & x == "Abdujalilov");
//IEnumerable<string> result = names1.TakeWhile(x => x == "Xurshid" & x == "Abdujalilov");
names = names1.ToList();
if(names.Contains("Xurshid")) names.Remove("Xurshid");

foreach (var item in names)
{   Console.WriteLine(item);    }Console.WriteLine("\v");

while (names.Contains("Abdujalilov")) names.Remove("Abdujalilov");

foreach (var item in names)
{
    Console.WriteLine(item);
}
#endregion

#region 2
List<int> numbers = new(50);
Random random = new Random();

for (int i = 0; i < 50; i++)
{   numbers[i] = random.Next(1, 100);   }
#endregion


