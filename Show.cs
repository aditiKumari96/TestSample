using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineCounter
{
    public class Show
    {
        Count ct = new Count();
        int totalLines = 0, commentedLines = 0, blankLines = 0, countFiles=0, sloc;

        //Folderpath
        public string Folderpath { get; set; }
        
        void displayFile()
        {
            foreach (var file in Directory.GetFiles(Folderpath, "*.*", SearchOption.AllDirectories).Where(x => (x.EndsWith(".ts") || x.EndsWith(".html") || x.EndsWith(".cs") || x.EndsWith(".sql"))))
            {
                ct.CountLines(file);
                totalLines = totalLines + ct.tot;
                blankLines = blankLines + ct.blank;
                commentedLines = commentedLines + ct.com;
                countFiles++;
            }
        }

        public void display()
        {
            displayFile();
            sloc = totalLines - (commentedLines + blankLines);
            Console.WriteLine("Lines in folder: {0,-10} ", Folderpath);
            Console.WriteLine("Total no. of files: {0}", countFiles);
            Console.WriteLine("TotalLines: {0}", totalLines);
            Console.WriteLine("BlankLines: {0}", blankLines);
            Console.WriteLine("CommentLines: {0}", commentedLines);
            Console.WriteLine("SLOC: {0}", sloc);
        }
    }
}
