using System;
using System.Collections.Generic;
Console.Clear();
Console.WriteLine("AAA");
Console.ReadLine();
while (true)
{

    List<string> _list = new List<string>()
{
    "AAA", "BBB"
};


    foreach (string letter in _list)
    {
        Random rand = new Random();
        int randp = rand.Next(_list.Count);
        string sel = _list[randp];
        //Console.WriteLine(sel);
        string section = letter.Replace("AAA", "---");
        //Console.Clear();

        Console.Write(section);

    }
}
