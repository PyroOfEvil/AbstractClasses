namespace AbstractClasses.obj
{
    public abstract class Vehicle
    {

        public string Make { get; set; }

        public string Model { get; set; }

        public abstract void Drive();

        public abstract void CruiseControl();
        
        public virtual void CheckEngine()
        {
            System.Console.WriteLine("Check The Engine");
        }

        public void Start()
        {
            System.Console.WriteLine("The vehicle is running");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine("The vehicle is stopped");
        }



        

    }
}