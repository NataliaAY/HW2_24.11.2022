Console.WriteLine ("Введите день недели...");
int dayofweek = int.Parse (Console.ReadLine());
if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Выходной");
else if (dayofweek <= 5) Console.WriteLine ("Будний");
else if (dayofweek > 7) Console.WriteLine ("Это не день недели");