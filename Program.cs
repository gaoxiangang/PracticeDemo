using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /*****
           * 抽象类和普通类初看起来其实实现的功能都是差不多的，都说是每个类实现自己定义的方法和动作
           * 就类似于，抽象类就是父母（Personal）， 子类就是子女（Class1 / Class2）。孩子长大后也会具备父母的基本行为（吃饭 睡觉 跑步和玩耍）
           * 但是随着两个孩子慢慢长大，他们分别学会了不同的技能 （ReadBook 和 Write）等等技能
           * 
           * 对应到我们的程序中就是 所有模块都会有“增删改查” 操作，这就是基本的操作。但是偶尔某些模块需要批量新增 批量删除 或者一些其他特殊的业务操作，这时候就可以从自己本身去扩展出新技能点
           * ***/

            Class1 class1 = new Class1();
            class1.Eat();
            class1.Run();
            class1.Sleep();
            class1.Play();
            class1.ReadBook();
            Console.WriteLine("----------------------");
            Class2 class2 = new Class2();
            class2.Eat();
            class2.Run();
            class2.Sleep();
            class2.Play();
            class2.Write();




            #region 注释代码
            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= 9; j++)
            //    {
            //        for (int h = 0; h <= 9; h++)
            //        {
            //            //12?56?  * 123 =154?4987
            //            //第一个循环补充第一个问号位置，然后第二个循环补充第二个 以此类推。最终得到合适的值
            //            if (Convert.ToInt32(12 * 10000 + i * 1000 + 56 * 10 + j) * 123 == 154 * 100000 + h * 10000 + 4987)
            //            {
            //                Console.WriteLine(i.ToString() + "\n" + j.ToString() + "\n" + h.ToString());
            //            }
            //        }
            //    }
            //} 
            #endregion
            Console.ReadKey();
        }
    }
}
