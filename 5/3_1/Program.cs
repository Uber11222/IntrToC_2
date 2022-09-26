Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
char firstChar = number[0];
char secondChar = number[1];
char fourdChar = number[3];
char fifthChar = number[4];
if (firstChar == fifthChar) {
    if (secondChar == fourdChar) {
    Console.WriteLine("Палиндром");
    }
    else {
       Console.WriteLine("Не палиндром"); 
    }
}
else {
    Console.WriteLine("Не палиндром");
}