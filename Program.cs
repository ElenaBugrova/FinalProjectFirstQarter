//Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше, либо равна 3
//символам. Первоначальный массив можно ввести с клавиатуры, либо
//задать на старте выполнения алгоритма. При решении не рекомендуется
//пользоваться коллекциями, лучше обойтись исключительно массивами
//пример: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

using System;
using static System.Console;

string [] Array=new string[4]{"Hello", "2", "world", ":-)"};

Write($"{Array[0]}, {Array[1]}, {Array[2]}, {Array[3]}");
WriteLine();
string [] NewArray;
NewArray= new string [2];
int j=0;
for (int i = 0; i < 4; i++)
{
    if (Array[i].Length<=3)
    {
        NewArray[j]=Array[i];
        j++;
    }
}
Write($"{NewArray[0]}, {NewArray[1]}");