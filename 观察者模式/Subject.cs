using System.Collections.Generic;

namespace yDesign.观察者模式
{
    /// <summary>
    /// 抽象类-被观察者
    /// </summary>
    public abstract class Subject
    {
        private readonly List<IObserver> _observerList = new List<IObserver>();

        public void AttachObserver(IObserver observer)
        {
            _observerList.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            _observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observerList.ForEach(o => o.Update());
        }
    }
}
