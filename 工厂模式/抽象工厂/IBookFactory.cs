using yDesign.工厂模式.简单工厂;

namespace yDesign.工厂模式.抽象工厂
{
    public interface IBookFactory
    {
        IBook CreateChineseBook();
        IBook CreateMathBook();
    }
}
