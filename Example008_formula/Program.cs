//Вычислить значение формулы (𝑎×𝑏)/(𝑐+𝑑)где a,b,c,d – некоторые целые числа.
// Результат вывести на экран.

int a = new Random().Next(1, 50);
Console.Write("Число a: ");
Console.WriteLine(a);
int b = new Random().Next(1, 50);
Console.Write("Число b: ");
Console.WriteLine(b);
int c = new Random().Next(1, 50);
Console.Write("Число c: ");
Console.WriteLine(c);
int d = new Random().Next(1, 50);
Console.Write("Число d: ");
Console.WriteLine(d);

double formula = (a * b) / (c + d);

Console.Write("Ваш ответ: ");
Console.WriteLine(formula);