using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Class2 : Personal
    {
        public override void Run()
        {
            Console.WriteLine("正在慢慢走路");
        }

        public override void Sleep()
        {

            Console.WriteLine("十点准备睡觉");
        }

        public override void Eat()
        {

            Console.WriteLine("十二点吃午饭");
        }

        public override void Play()
        {

            Console.WriteLine("晚上出门跑步");
        }
        public void Write()
        {

            Console.WriteLine("学会了写作");
        }
    }
}
