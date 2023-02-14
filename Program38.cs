
// Задаю массив вещественных чисел, количество элементов вводится с терминала
Console.Write($"Введите длину массива, указав количество его элементов: ");
int numberElements = Convert.ToInt32(Console.ReadLine());
double[] array = new double[10];


  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
  }
// найти разницу между максимальным и минимальным значением элементов массива
double maxNumber = array[0];
double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");