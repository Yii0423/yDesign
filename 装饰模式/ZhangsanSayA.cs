using System;

namespace yDesign.装饰模式
{
    public class ZhangsanSayA : Decorator
    {
        public override void Say()
        {
            base.Say();
            Console.WriteLine("张三又说了一句话A。");
        }
    }
}
