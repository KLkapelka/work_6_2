// Дан файл numsTask2.txt со словами расположенными в столбик.
// Из заданных слов составьте одну длинную строку(разделить каждое слово пробелом);

using System;
using System.IO;

class work_6_2
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask2.txt"); 
        string wordsLine = string.Join(" ", lines); 

        Console.WriteLine(wordsLine); 
    }
}

