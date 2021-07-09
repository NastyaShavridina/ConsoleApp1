using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class AbstractHandler
    {
        public string [] SplitString { get; set; }

        public List<string> Data { get; set; }

        public string Path { get; set; }

        public string Condition { get; set; }

        public string  Extension { get; set; }


        protected AbstractHandler(string path)
        {
            Path = path;
        }


        public virtual void DefineExtension(string path)
        {
            SplitString = path.Split(new char[] { '.' });

            for (int i = 0; i < SplitString.Length; i++)
            {
                if (SplitString[i] == "xml" || SplitString[i] == "doc" || SplitString[i] == "txt")
                {
                    Extension = SplitString[i].ToUpper();
                }
            }
        }

        public abstract void Open();

        public abstract List<string> Create();

        public abstract List<string> Change();

        public abstract void Save(string data);
    }
}
