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
            //Put them to list
            var inputList = splitLine.ToList();
            //Group them up and sort by count descending
            var g = splitLine.GroupBy( i => i ).OrderByDescending(group => group.Count());
            //Print it out
            Console.WriteLine( "{0} {1}", grp.Key, grp.Count() );
        }
    }
}
