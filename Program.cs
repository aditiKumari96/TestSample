using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LineCounter;

namespace LineCounter
{

   /* abstract class Count
    {
        /*public static int countComment(string file)
        {
            int count = 0;
            string st[]= File.ReadLines(file); 
            while
            {

            }
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            //fs.Seek(0, SeekOrigin);
            for (int i = 0; i < st.Length; i++)
            {
                
            }
        
        }*/
    public class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Folder's Path: ");
                string path = Console.ReadLine(); //@"C:\Test";
                
                if (Directory.GetDirectories(path) != null)
                {
                    Show d = new Show() { Folderpath = path };
                    //d.displayFile();
                    d.display();
                }
                else
                {
                    throw (new Exception());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception found: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
