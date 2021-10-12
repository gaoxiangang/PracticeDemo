using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Class1 : Personal
    {
        public override void Run()
        {
            Console.WriteLine("正在跑步");
        }

        public override void Sleep()
        {

            Console.WriteLine("十二点准备睡觉");
        }

        public override void Eat()
        {

            Console.WriteLine("晚上六点吃晚饭");
        }

        public override void Play()
        {

            Console.WriteLine("正在打游戏");
        }

        public void ReadBook()
        {
            Console.WriteLine("正在读书");
        }
    }

}
