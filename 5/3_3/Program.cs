
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 1;
int c = 0;
for (int i = 0; i < a ; i++) {
    c = b * b * b;
    b++;
    Console.WriteLine($"{b-1} в кубе равно {c}");
}
