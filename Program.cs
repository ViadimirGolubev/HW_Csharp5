// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 - сначала создаем массив->потом заполняем его рандомным операторм->
// потом вводим переменную и проверяем его на каждый элемент делением на 2 с очтаткомесли остаток равен 0 то четное число и сразу счетчик увеличиввется на 1
// ________________________________________________________
//  int [] array = new int [4];
// Console.Write("[");

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i]+",");
// }
// Console.Write("]");

// int even = 0;
// for(int i = 0; i < array.Length; i++)
// if (array[i] % 2 == 0)
// {
//     even++;
// }
// Console.Write("Количество чётных чисел в массиве =" + even);
// ________________________________________________









// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 - сначала создаем массив->потом заполняем его рандомным операторм->
// потом вводим переменную для суммы и складываем вам только теэлемены массива индексы которого нечетные
// ________________________________________________________

// int [] array = new int [4];
// Console.Write("[");

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,1000);
//     Console.Write(array[i]+",");
// }
// Console.Write("]");

// int sumnoteven = 0;
// for(int i = 1; i < array.Length; i+=2)

//     sumnoteven=sumnoteven+array[i];

// Console.Write("Сумаа  чисел на не четных позициях в массиве =" + sumnoteven);








// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76  задать массив с помощью рандома=>
// создать преременную максимум =>найти максимум перебором=>
// создать преременную минимму =>найти минимим перебором
// найти разницу и выести ее=>

Console.WriteLine("Введите желаемое количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] randomArray = new double[a];

 Console.WriteLine("массив: ");
// задаем массив методом
void Massiv(int a)
{

for (int i = 0; i < a; i++)
{
randomArray[i] =(Math.Round(new Random().NextDouble(),2)+new Random().Next(1,10));
Console.WriteLine(randomArray[i] ); 
}
// мат рандом позволяет обрезать числа после запятой в ашем случае 2 плюс рандомный масив что бы числа были в диапазоне больше 1
}

double  Difference(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

Massiv(a);
Console.WriteLine($"\nРазница между максимальным и минимальным элементов массива = {Difference(randomArray):F2}");