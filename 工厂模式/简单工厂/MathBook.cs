using System;

namespace yDesign.工厂模式.简单工厂
{
    public class MathBook : IBook
    {
        public void Info()
        {
            Console.WriteLine("这是一本一年级的数学书");
        }
    }
}
