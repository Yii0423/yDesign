namespace yDesign.工厂模式.简单工厂
{
    public class BookFactory
    {
        public IBook CreateBook(string type)
        {
            switch (type)
            {
                case "语文":
                    return new ChineseBook();
                case "数学":
                    return new MathBook();
            }
            return null;
        }
    }
}
