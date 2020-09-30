using System;

namespace yDesign.观察者模式
{
    /// <summary>
    /// 观察者-宝物
    /// </summary>
    public class Treasure : IObserver
    {
        public void Update()
        {
            if (InRange())
            {
                Console.WriteLine("宝物 为主角加血！");
            }
        }

        private static bool InRange()
        {
            //判断主角是否在自己的影响范围内，这里忽略细节，直接返回true
            return true;
        }
    }
}
