Console.Clear();

Console.Write("Введите пятизначное число:  ");
int num = Int32.Parse(Console.ReadLine());

int dig1 = num / 10000;
int dig2 = (num / 1000) % 10;
int dig4 = (num / 10) % 10;
int dig5 = num % 10;

Console.Write((dig1 == dig5 && dig2 == dig4) ? "Да" : "Нет");


