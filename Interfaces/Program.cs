using System;

namespace Interfaces
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: 
    //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 
    //метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop()
    //соответственно.
    //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
    //Написать программу, которая выполняет проигрывание и запись

    class Program
    { 
        static void Main(string[] args)
        {
           IPlayable playable = new Player();

            playable.Play();

            playable.Pause();

            playable.Stop();

           IRecodable recodable = new Player();

            recodable.Record();

            recodable.Pause();

            recodable.Stop();

        }
    }
}
