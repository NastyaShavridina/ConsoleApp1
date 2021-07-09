using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string path) : base(path)
        {
        }

        public override void DefineExtension(string path)
        {
            Console.WriteLine("It`s XML extension : " + path);
        }

        public override List<string> Create()
        {
            Path = Path;

            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

            Console.WriteLine("Документ расширения XML создан. Введите данные");

            Data = new List<string>();

            Data.Add(Console.ReadLine());

            return Data;
        }

        public override void Open()
        {
            Path = Path + ".xml";

            try
            {
                Process.Start(Path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public override List<string> Change()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                Data = new List<string>();

                Data.Add(sr.ReadToEnd());
            }

            return Data;
        }

        public override void Save(string data)
        {
            Path = Path + ".xml";

            if (File.Exists(Path) && !data.Equals(null))
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine(data);
                }

                Console.WriteLine("Документ сохранен");
            }
            else
            {
                Console.WriteLine("Данные не были введены");
            }

        }
    }
}
