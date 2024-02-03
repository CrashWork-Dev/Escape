namespace Script.Inner.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            return choice switch
            {
                "Monster" => new MonsterAbstractFactory(),
                _ => new MonsterAbstractFactory()
            };
        }
    }
}