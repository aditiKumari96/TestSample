using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineCounter
{
    public class Count
    {
        internal int com, tot, blank;
        /*public int countTotal(string file)
        {
            int linecount = File.ReadLines(file).Count();
            return linecount;
        }

        public int countBlank(string file)
        {
            int c = File.ReadLines(file).Count(line => string.IsNullOrWhiteSpace(line));
            return c;
        }

        public int countComment(string file)
        {
            
            int com = 0;
                var str = File.ReadAllLines(file);
                for (int i = 0; i < str.Length; i++)
                {
                    string curLine = str[i].Trim();
                    if (curLine.StartsWith("/"))
                    {
                        if (curLine[1]== '/')
                        {
                            com++;
                        }
                        else if (curLine[1] == '*')
                        {
                            com++;
                        }
                    }
                    else if(curLine.StartsWith("<!--"))
                    {
                        
                            com++;
                    }
                }
            return com;
        }*/
        public void CountLines(string file)
        {
            com = 0;tot = 0;blank = 0;
            foreach (string line in File.ReadLines(file))
            {
                string curline = line.Trim();
                if (curline.StartsWith("//"))
                    com++;
                else if (curline.StartsWith("<!--"))
                    com++;
                else if (curline.StartsWith("--"))
                    com++;
                else if (curline.Length == 0)
                    blank++;
                tot++; 
            }
            //Console.WriteLine("\nFile: {0}", file);
            //Console.WriteLine("No. of lines: {0}", tot);
            //Console.WriteLine("No. of blank lines: {0}", blank);
            //Console.WriteLine("No. of comment Lines: {0}", com);
            //Console.WriteLine("=========================================\n=========================================");
        }
    }
}
