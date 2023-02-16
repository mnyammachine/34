


// Длинна массива вводится из терминала 
Console.Write($"Введите длину массива, указав количество его элементов: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 
// Заполнение массива случайными числами
int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Массив: ");
// Поиск суммы элементов, стоящих на нечётных позициях  
    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, -100, 100);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


