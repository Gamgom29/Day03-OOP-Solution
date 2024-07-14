using Demo.Interface_Example_01;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface Exmaple 01
            //IMyType myType;
            /// Decalre for reference of type "IMyType" Refering to null
            ///this reference can refer to object from class of struct implement the interface 
            /// CLR will allocate 4bytes in stack for the reference

            //myType = new IMyType(); Invalid U Can't Create Object From Interface

            //MyType myType = new MyType();
            //myType.Salary = 10_000;
            //myType.MyFun(); // Hello World
            //                //myType.Print(); 

            //IMyType referenceFromInterface = new MyType();
            //referenceFromInterface.Salary = 10_000;
            //referenceFromInterface.MyFun(); // Hello World
            //referenceFromInterface.Print(); 
            #endregion
        }
    }
}
