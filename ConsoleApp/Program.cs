//task 1
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

int number = 10;
string str = "cool";
char symbol = 'c';
bool booled = true;

Console.WriteLine(number);
Console.WriteLine(str);
Console.WriteLine(symbol);
Console.WriteLine(booled);

//task 2
int num = 10;
Console.WriteLine(num);
num = 15;
Console.WriteLine(num);
num = 20;
Console.WriteLine(num);

int a = 15;
int b = a;
b = 10;
Console.WriteLine(a);
Console.WriteLine(b);

double i = 10;
double j = 15;
double sum = i + j;
double sub = i - j;
double mul = i * j;
double del = i / j;
Console.WriteLine($"Сумма: {sum}, Разность:{sub}, Произведение: {mul}, Деление: {del}");
