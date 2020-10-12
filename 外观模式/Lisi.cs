namespace yDesign.外观模式
{
    public class Lisi
    {
        private readonly Hospital _hospital;
        private readonly SuperMarket _superMarket;
        private readonly GasStation _gasStation;

        public Lisi()
        {
            _hospital = new Hospital();
            _superMarket = new SuperMarket();
            _gasStation = new GasStation();
        }

        public void OneDay()
        {
            _hospital.SeeTheDoctor();
            _superMarket.BuySomething();
            _gasStation.AddSomeOil();
        }
    }
}
