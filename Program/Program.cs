Console.WriteLine("Введите количество строк в массиве: ");
int size1 = Int32.Parse(Console.ReadLine());    //Количество строк в первом массиве
string [] array1 = new string [size1];  // Создание пустого массива
int size2 = 0;  // Размер второго массива
//string [] array2 = new string [size1];

// Цикл заполнения массива с клавиатуры
for (int i = 0; i < size1; i++) {
    Console.WriteLine($"Введите строку №{i}");
    array1[i] = Console.ReadLine();
    if (array1[i].Length < 4) size2++;
}

if (size2 == 0) Console.WriteLine("Массив не содержит коротких строк");
else {
    
    // Цикл формирования второго массива
    Console.WriteLine("\nПервоначальный массив:");
    Console.Write("[");
    for (int i1 = 0; i1 < size1; i1++) {
        Console.Write($"\"{array1[i1]}\"");
        if (i1 < (size1 - 1)) Console.Write(", ");
    }
    Console.Write("]");
}

string [] array2 = new string [size2];
int i2 = 0; // Индекс второго массива
Console.WriteLine("\nВаш новый массив:");
Console.Write("[");
for (int i1 = 0; i1 < size1; i1++) {
    if (array1[i1].Length < 4) {
        array2[i2] = array1[i1];
        Console.Write($"\"{array2[i2]}\"");
        if (i1 < (size1 - 1)) Console.Write(", ");
        i2++;
    }
}
 Console.Write("]");
