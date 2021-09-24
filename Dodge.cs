namespace AbstractClasses.obj
{
    public class Dodge : Vehicle
    {
        public override void Drive()
        {
            System.Console.WriteLine("The Dodge is in Drive");
        }

        public override void CruiseControl()
        {
            System.Console.WriteLine("The Dodge is in Cruise Control");
        }
    }
}