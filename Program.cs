//Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше, либо равна 3
//символам. Первоначальный массив можно ввести с клавиатуры, либо
//задать на старте выполнения алгоритма. При решении не рекомендуется
//пользоваться коллекциями, лучше обойтись исключительно массивами
//пример: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

using System;
using static System.Console;

string [] Array={"Hel", "2", "wor", ":-))"};
PrintString(Array);
WriteLine();


void PrintString (string [] Array)
{
for (int i = 0; i < Array.Length; i++)
{
    Write(Array[i]);
    if(i<Array.Length-1)Write(", ");
}
}



string [] NewArray;
int j=0;


for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<=3)j++;
   
}
NewArray= new string [j];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<=3)
    {
        
    }
   
}


PrintString(NewArray);

