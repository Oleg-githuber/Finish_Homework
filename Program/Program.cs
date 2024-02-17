Console.WriteLine("Введите количество строк в массиве: ");
int size1 = Int32.Parse(Console.ReadLine());    //Количество строк в первом массиве
string [] array1 = new string [size1];  // Создание пустого массива
int size2 = 0;  // Размер второго массива

// Цикл заполнения массива с клавиатуры
for (int i = 0; i < size1; i++) {
    Console.WriteLine($"Введите строку №{i}");
    array1[i] = Console.ReadLine();
    if (array1[i].Length < 4) size2++;
}

