namespace Common
{
    //What can I write inside the namespace ?
    //Class
    //interface
    //Enum
    //Struct

    //What can I use as access modifier inside namesapce?
    //Internal [default in namespace]
    //Public

    //Internal is accessbile in the project
    internal class TypeB
    {
        public TypeB()
        {
            TypeA obj = new TypeA();
            //obj.X = 10; //Invalid
            obj.Y = 20; //Valid because internal access modifier is accessible in the project
            obj.Z = 30; //Valide because public access modifier is accessible in the project and in the external project which refernce to me

        }
    }
}
