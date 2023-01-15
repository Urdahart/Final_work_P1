// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размерность массива");
int razmA=Convert.ToInt32(Console.ReadLine());
string [] A = new string[razmA];
string [] B = new string[razmA];
Console.WriteLine("Введите элементы массива");
for (int i=0; i<razmA;i++)
{
    A[i]=Convert.ToString(Console.ReadLine());
}

int j=0;
for (int i=0; i<A.Length;i++) // делаем проверку условия
{
    if (A[i].Length<=3) 
    {
        B[j]=A[i];
        j++;
    }
}
Console.WriteLine();

for (int k=0; k<j;k++) //выводим итоговый массив с элементами, отвечающим условиям
{
    Console.WriteLine(B[k]);
}