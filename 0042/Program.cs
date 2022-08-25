// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите десятичное число: ");
int Number= Convert.ToInt32(Console.ReadLine());
string binaryNumber =  " ";
do
{
binaryNumber = Convert.ToString(Number%2) + binaryNumber;
Number= Number/2;

}while (Number>0);
Console.WriteLine(binaryNumber);