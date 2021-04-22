using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CSBeginnerHelpLG
{
    public class FileData
    {
        private string _Path;
        public string Path 
        { 
            get 
            {
                return _Path;
            } set 
            {
                _Path = Path;
            } 
        }

        public void write(string Text)
        {
            FileStream fs = new FileStream(_Path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Text);
            sw.Close();
        }
        public void write(object Text)
        {
            FileStream fs = new FileStream(_Path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Text);
            sw.Close();
        }
        public void start()
        {
            Process.Start(_Path);
        }
        public string read() 
        {
            string Texxt = string.Empty;
            FileStream fs = new FileStream(_Path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;
            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                Texxt += zeile + "\n";
            }
            sr.Close();
            return Texxt;
        }
        public string read(int lines)
        {
            string Texxt = string.Empty;
            FileStream fs = new FileStream(_Path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;
            //sr.Peek() != -1
            for (int i = lines; i <= 0 && sr.Peek() <= -1; i--)
            {
                zeile = sr.ReadLine();
                Texxt += zeile + "\n";
            }
            sr.Close();
            return Texxt;
        }
    }
}
