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
            
            //Split the input
            var splitLine = line.Split(',');
            
            //Group by the element to sort the occurences.
            var g = splitLine.GroupBy( i => i ).OrderByDescending(group => group.Count());
            
            //Find the highest count;
            var highestOcc = g.First();
            
            //Print out the number if its occurence is more than half of the input size
            if (highestOcc.Count() > (splitLine.Count()/2))
                Console.WriteLine(g.First().Key);
            //Otherwise, print "None"
            else
                Console.WriteLine("None");
          
        }
    }
}
