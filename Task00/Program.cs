// Console.WriteLine("Input username");
// string username = Console.ReadLine();
// Console.WriteLine("Hello, World!");
// Console.Write(username);


//------------------------------

// Console.WriteLine("Input username");
// string username = Console.ReadLine();
// if (username.ToLower() == "artem")
// {
// 	Console.WriteLine($"Hello, my dear friends, {username}");
// }
// if (username.ToLower() == "kate")
// {
// 	Console.WriteLine("Privet, vonychaya popa");
// }
// else
// {
// 	Console.WriteLine($"Hello, {username}");
// }

// ------------------------------

// int numberOne = new Random().Next(1, 100);
// Console.WriteLine(numberOne);
// int numberTwo = new Random().Next(0, 2);
// Console.WriteLine(numberTwo);
// int sum = numberOne * numberTwo;
// Console.WriteLine($"Summ = {sum}");

// ------------------------------

// int a = new Random().Next(1, 100);
// Console.WriteLine(a);
// int b = new Random().Next(1, 100);
// Console.WriteLine(b);
// int c = new Random().Next(1, 100);
// Console.WriteLine(c);
// int d = new Random().Next(1, 100);
// Console.WriteLine(d);
// int e = new Random().Next(1, 100);
// Console.WriteLine(e);
// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// Console.WriteLine($"max = {max}");

// ------------------------------

// Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

// Console.Clear();
// int xa = 40, ya = 1;
// int xb = 1, yb = 30;
// int xc = 80, yc = 30;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
// int x = xa, y = ya;
// int count = 0;
// while (count < 10000)
// {
// 	int what = new Random().Next(0, 3);
// 	if (what == 0)
// 	{
// 		x = (x + xa) / 2;
// 		y = (y + ya) / 2;
// 	}
// 	if (what == 1)
// 	{
// 		x = (x + xb) / 2;
// 		y = (y + yb) / 2;
// 	}
// 	if (what == 2)
// 	{
// 		x = (x + xc) / 2;
// 		y = (y + yc) / 2;
// 	}
// 	Console.SetCursorPosition(x, y);
// 	Console.WriteLine("*");
// 	count = count + 1;
// }