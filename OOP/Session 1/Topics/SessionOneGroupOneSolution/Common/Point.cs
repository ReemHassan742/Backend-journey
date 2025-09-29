namespace Common
{
    public struct Point
    {
        //What can I write inside class or struct?
        //Attributes [must be priavte]
        //Functions  [Constructor , getter setter , Methods]
        //Properties
        //Event

        //Allowed access modifiers indise struct ? 
        //Private [default access modifier]
        //Internal
        //Public


        //Attributes [must be priavte]
        public int X;
        public int Y;

        //Constructor
        //Default constructor || Parmeterless constructor
        //Default constructor --> Intialize the attributes inside the struct
        public Point() //Before .NET 6 wasn't allowed to access
        {
            X = default;
            Y = default;
            //Special function :-
            // Constructor name must be same name with class or struct
            // Has no return
        }
        //User defined construcor , Paratmerized constructor
        //Constructor overloading
        public Point(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public Point(int Num1) 
        {
            X = Y = Num1;
        }
        public override string ToString()
        {
            return $"X = {this.X} , Y = {this.Y}";
        }
    }
}
