using yDesign.观察者模式;

namespace yDesign
{
    internal class Program
    {
        private static void Main()
        {
            const DesignPatterns designPatterns = DesignPatterns.观察者模式;
            switch (designPatterns)
            {
                case DesignPatterns.观察者模式:
                    //声明被观察者
                    Hero hero = new Hero();
                    //添加观察者
                    hero.AttachObserver(new Monster());
                    hero.AttachObserver(new Trap());
                    hero.AttachObserver(new Treasure());
                    //触发观察者回调方法
                    hero.Move();
                    break;
            }
        }
    }

    /// <summary>
    /// 枚举-设计模式
    /// </summary>
    public enum DesignPatterns
    {
        单件模式,
        抽象工厂,
        建造者模式,
        工厂方法模式,
        原型模式,
        适配器模式,
        桥接模式,
        装饰模式,
        组合模式,
        外观模式,
        享元模式,
        代理模式,
        模板方法,
        命令模式,
        迭代器模式,
        观察者模式,
        解释器模式,
        中介者模式,
        职责链模式,
        备忘录模式,
        策略模式,
        访问者模式,
        状态模式
    }
}
