using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
        //    Создайте класс AbstractHandler.
        //   В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
        //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
        //AbstractHandler.
        //Написать программу, которая будет выполнять определение документа и для каждого формата
        //должны быть методы открытия, создания, редактирования, сохранения определенного
        //формата документа.
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler dOCHandler = new DOCHandler(@"C:\document2\mydoc");

            List<string> list;
            
            list = dOCHandler.Create();

            dOCHandler.Save(list[0]);

            dOCHandler.Open();

        }
    }
}
