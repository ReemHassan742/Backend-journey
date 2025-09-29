namespace Common
{
    //Public access modifier accessible in porject and in the whole solution

    //What we can write in struct or class?
    // 1 - Attributes[fields] ==> Member variables [must be private]
    // 2 - Properties [Full property , Automatic Property , Indexer]
    // 3 - Functions [Constructor , Getter Setter , Method]
    // 4 - Events

    // Allowed access modifier inside the class
    // Private [default in the class] 
    // Private protected 
    // protected 
    // internal 
    // internal protected 
    // public 

    // Allowed access modifier inside the struct
    // Private [default in the struct] 
    // internal 
    // public 

    public class TypeA
    {
        private int X; //Accessible through its scope
        internal int Y; //Accessible through its project 
        public int Z;//Accessible through any project reference to me
        public TypeA()
        {
            TypeB typeB = new TypeB();
        }
        void Print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
        }
    }
}
