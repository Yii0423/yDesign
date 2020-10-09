using yDesign.工厂模式.简单工厂;

namespace yDesign.工厂模式.抽象工厂
{
    public class FirstGradeBookFactory : IBookFactory
    {
        public IBook CreateChineseBook()
        {
            return new 简单工厂.ChineseBook();
        }

        public IBook CreateMathBook()
        {
            return new 简单工厂.MathBook();
        }
    }
}
