Console.WriteLine("Введите количество строк в массиве: ");
int size1 = Int32.Parse(Console.ReadLine());
string [] array1 = new string [size1];
for (int i = 0; i < size1; i++) {
    Console.WriteLine($"Введите строку №{i}");
    array1[i] = Console.ReadLine();
}
