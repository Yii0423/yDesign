using System;
using yDesign.单例模式;
using yDesign.工厂模式.工厂方法;
using yDesign.工厂模式.抽象工厂;
using yDesign.工厂模式.简单工厂;
using yDesign.观察者模式;

namespace yDesign
{
    internal class Program
    {
        private static void Main()
        {
            const DesignPatterns designPatterns = DesignPatterns.单例模式;
            switch (designPatterns)
            {
                case DesignPatterns.单例模式:
                    Singleton singleton = Singleton.GetInstance();
                    Console.WriteLine(singleton.Say());
                    break;
                case DesignPatterns.工厂模式:
                    //简单工厂
                    BookFactory bookFactory = new BookFactory();
                    IBook chineseBook1 = bookFactory.CreateBook("语文");
                    IBook mathBook1 = bookFactory.CreateBook("数学");
                    chineseBook1.Info();
                    mathBook1.Info();
                    //工厂方法
                    ChineseBookFactory chineseBookFactory = new ChineseBookFactory();
                    MathBookFactory mathBookFactory = new MathBookFactory();
                    IBook chineseBook2 = chineseBookFactory.CreateBook();
                    IBook mathBook2 = mathBookFactory.CreateBook();
                    chineseBook2.Info();
                    mathBook2.Info();
                    //抽象工厂
                    FirstGradeBookFactory firstGradeBookFactory = new FirstGradeBookFactory();
                    SecondGradeFactory secondGradeFactory = new SecondGradeFactory();
                    IBook chineseBook3 = firstGradeBookFactory.CreateChineseBook();
                    IBook mathBook3 = firstGradeBookFactory.CreateMathBook();
                    chineseBook3.Info();
                    mathBook3.Info();
                    IBook chineseBook4 = secondGradeFactory.CreateChineseBook();
                    IBook mathBook4 = secondGradeFactory.CreateMathBook();
                    chineseBook4.Info();
                    mathBook4.Info();
                    break;
                case DesignPatterns.观察者模式:
                    //被观察者
                    Hero hero = new Hero();
                    //添加观察者
                    hero.AttachObserver(new Monster());
                    hero.AttachObserver(new Trap());
                    hero.AttachObserver(new Treasure());
                    //通知观察者
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
        单例模式,
        工厂模式,
        建造者模式,
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
