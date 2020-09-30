using System;

namespace yDesign.观察者模式
{
    /// <summary>
    /// 被观察者-英雄
    /// </summary>
    public class Hero : Subject
    {
        public void Move()
        {
            Console.WriteLine("主角向前移动");
            NotifyObservers();
        }
    }
}
