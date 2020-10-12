namespace yDesign.装饰模式
{
    public abstract class Decorator : Person
    {
        private Person _person;

        public void SetPerson(Person person)
        {
            _person = person;
        }

        public override void Say()
        {
            _person?.Say();
        }
    }
}
