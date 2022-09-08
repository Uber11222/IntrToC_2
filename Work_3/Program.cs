Console.WriteLine("Введите число обозначающее день недели");
string numberDayOfWeek = Console.ReadLine();
int a = Convert.ToInt32(numberDayOfWeek);
if (a < 6) {
    Console.WriteLine ("Этот день выходной? - нет");
}
else {
    Console.WriteLine ("Этот день выходной? - да");
}