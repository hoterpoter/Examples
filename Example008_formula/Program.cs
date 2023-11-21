//Вычислить значение формулы (𝑎×𝑏)/(𝑐+𝑑)где a,b,c,d – некоторые целые числа.
// Результат вывести на экран.

double a = new Random().Next(1, 50);
Console.WriteLine(a);
double b = new Random().Next(1, 50);
Console.WriteLine(b);
double c = new Random().Next(1, 50);
Console.WriteLine(c);
double d = new Random().Next(1, 50);
Console.WriteLine(d);

double formula = ((a * b) / (c + d));

Console.WriteLine(formula);