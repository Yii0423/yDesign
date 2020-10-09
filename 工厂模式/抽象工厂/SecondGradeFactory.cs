using yDesign.工厂模式.简单工厂;

namespace yDesign.工厂模式.抽象工厂
{
    public class SecondGradeFactory : IBookFactory
    {
        public IBook CreateChineseBook()
        {
            return new ChineseBook();
        }

        public IBook CreateMathBook()
        {
            return new MathBook();
        }
    }
}
