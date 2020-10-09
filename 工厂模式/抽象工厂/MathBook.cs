using System;
using yDesign.工厂模式.简单工厂;

namespace yDesign.工厂模式.抽象工厂
{
    public class MathBook : IBook
    {
        public void Info()
        {
            Console.WriteLine("这是一本二年级的数学书");
        }
    }
}
