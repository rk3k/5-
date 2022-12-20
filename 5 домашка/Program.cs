//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Console.WriteLine("Введите размер массива");
//int.TryParse(Console.ReadLine(), out int size);

//int[] numbers = new int[size];
//FillArrayRandomNumber(numbers);

//Console.WriteLine("Вот наш массив :");
//int count = 0;

//for (int z = 0;z < numbers.Length; z++)
//{
//    if (numbers[z] % 2 == 0)
//       count++;
//}
//Console.WriteLine($"Всего{numbers.Length} чисел,{count} из них четные");

//void FillArrayRandomNumber(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i]= int.Parse(Console.ReadLine());
//    }
//}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//int length = 4;
//int[] array = new int[length];
//Random rnd = new Random();

//int sum = 0;
//for (int i = 0; i < length; i++)
//{
//    sum += array[i];
//}
//Console.WriteLine(sum);


//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[,] a = new int[1, 5];

Random random= new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(100);
        Console.WriteLine("{0,3}", a[i,j]);
    }
    Console.WriteLine();
}

for (int i = 0; i < a.GetLength(0); i++)
{
    int min = a[i, 0];
    int max = a[i, 0];
    for (int j = 1; j < a.GetLength(1); j++)
    {
        if (a[i, j] < min)
            min = a[i, j];
        if (a[i, j] < min)
            min = a[i, j];
    }
    Console.WriteLine(max-min);
}




