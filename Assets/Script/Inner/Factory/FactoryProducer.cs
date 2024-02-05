namespace Script.Inner.Factory
{
    public static class FactoryProducer
    {
        public static AbstractFactory GetFactory(string which)
        {
            return which switch
            {
                _ => new MonsterFactory()
            };
        }
    }
}