Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (number.Length > 2) {
    char thirdChar = number[2];
    Console.WriteLine(thirdChar);
}
else {
    Console.WriteLine("В числе третьей цифры нет.");
}