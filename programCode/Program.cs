/*
Программа, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами
*/

string[] arrayIn = new string[5] {"Russia","world", ":-)", "1945", "C#"};
string[] arrayOut = new string[arrayIn.Length];
int count = 0;
for (int i = 0; i < arrayIn.Length; i++)
{
if(arrayIn[i].Length <= 3)
    {
        arrayOut[count] = arrayIn[i];
        count++;
    }
}
Console.WriteLine($"[{string.Join(", ", arrayIn)}] -> [{string.Join(", ", arrayOut)}]");