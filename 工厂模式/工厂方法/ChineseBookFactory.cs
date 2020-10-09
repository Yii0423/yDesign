using yDesign.工厂模式.简单工厂;

namespace yDesign.工厂模式.工厂方法
{
    public class ChineseBookFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new ChineseBook();
        }
    }
}
