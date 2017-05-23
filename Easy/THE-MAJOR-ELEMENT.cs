/* A work in progress, I'm getting partial result here */
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            //Split the output
            var splitLine = line.Split(',');
            var inputList = splitLine.ToList();
            var g = splitLine.GroupBy( i => i ).OrderByDescending(group => group.Count());
            //Print out the result
            Console.WriteLine(g.First().Key);
          
        }
    }
}
