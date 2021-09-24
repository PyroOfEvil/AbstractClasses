namespace AbstractClasses.obj
{
    public class Ford : Vehicle
    {
        public string Color { get; set;}

        public override void Drive()
        {
            System.Console.WriteLine("The Ford is driving");
        }

       public void Start()
       {
           System.Console.WriteLine("The Ford has started");
       }

       public override CruiseControl()
       {
           System.Console.WriteLine("The Ford is in Cruise Control");
       }
        
            
        
    }
}