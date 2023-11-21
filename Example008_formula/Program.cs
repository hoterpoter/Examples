//Вычислить значение формулы (𝑎×𝑏)/(𝑐+𝑑)где a,b,c,d – некоторые целые числа.
// Результат вывести на экран.

int a = new Random().Next(1, 50);
Console.WriteLine(a);
int b = new Random().Next(1, 50);
Console.WriteLine(b);
int c = new Random().Next(1, 50);
Console.WriteLine(c);
int d = new Random().Next(1, 50);
Console.WriteLine(d);

int formula = ((a * b) / (c + d));

Console.WriteLine(formula);