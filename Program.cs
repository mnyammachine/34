// 34


// задать массив
int[] array = new int[8];
// заполнить массив случайными положительными трехзначными числами 
FillArray (array, 100, 999);
// показать количество четных чисел в массиве
Console.WriteLine ("Количество положительных элементов в массиве");

// заполняю массив 
void FillArray(int[] arr, int minVal, int maxVal)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++ ) {
        arr[i] = rnd.Next(minVal, maxVal + 1);
    }
}


// 
void PrintArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(array, 100, 1000);
PrintArray(array);
Console.WriteLine();

int quantity = QuantityPositive(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
