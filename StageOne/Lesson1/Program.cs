// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Ներմուծել քառանիշ թիվ և հաշվել նրա թվանշանների գումարը:

//int x = 11;
//float y = 2;
//float result = x / y;
//int rem = x % 2; 
//Console.WriteLine(result);
//Console.WriteLine(rem);

Console.WriteLine("Please input number");//4329/10
string text = Console.ReadLine();
int input = int.Parse(text);
int n1 = input % 10;//9
input = input / 10;//432
int n2 = input % 10;//2
input = input / 10;//43
int n3 = input % 10;//3
input = input / 10;//4
int n4 = input % 10;//4

int result = n1 + n2 + n3 + n4;
Console.WriteLine(result);