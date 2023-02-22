string X = string.Empty;
int counter = 0;

Console.Write("Задайте размерность массива: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("А теперь давайте заполним массив строками");

for(int i = 0; i < n; i++)
{
  X += $"{Console.ReadLine()} ";
}

Console.WriteLine("Отлично! Теперь давайте посмотрим на наш массивчик!");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
string[] array = X.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string s in array)
{
  if (s.Length <= 3) counter+=1;
  Console.Write($"{s} ");
}
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("А теперь покажем новый массив, созданный из текущего, где длина каждого элемента не превышает 3 символа!");

string [] newarray = new string [counter];
counter = 0;

foreach (string s in array)
{
  if (s.Length <= 3)
  {
    
    newarray[counter] = s;
    counter++;
  }
}

Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.Write("Результат: ");
foreach (string s in newarray)
{
  Console.Write($"{s} ");
}
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");