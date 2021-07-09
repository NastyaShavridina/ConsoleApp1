using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Player : IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание.");
        }
        
        public void Record()
        {
            Console.WriteLine("Запись.");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза.");
        }

        public void Stop()
        {
            Console.WriteLine("Остановить.");
        }

        // void IPlayable.Pause()
        //{
        //    Console.WriteLine("Проигрывание на паузу.");
        //}

        // void IPlayable.Stop()
        //{
        //    Console.WriteLine("Проигрывание остановлено.");
        //}



        // void IRecodable.Pause()
        //{
        //    Console.WriteLine("Запись на паузу.");
        //}

        // void IRecodable.Stop()
        //{
        //    Console.WriteLine("Запись остановлена.");
        //}
    }
}
