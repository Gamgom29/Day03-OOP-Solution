using Demo.Interface_Example_01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if(series == null) return;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GetNext();

            }
            series.Reset();
            Console.WriteLine();
        }
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

            #region Interface Example 02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree); 
            #endregion

            #region Interface Example 03
            //Airplane airplane = new Airplane();
            //airplane.Backward();
            //airplane.Forward();

            //IMovable movable = new Airplane();
            //movable.Backward();
            //movable.Forward(); 
            #endregion

            #region Shallow Copy , Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;
            ///// Shallow Copy [سطحي]
            ///// this Object {1,2,3} Has 2 References [Arr01 , Arr02] [اسمين دلع]
            ///// thid object {4,5,6} Became unReachable Object

            //Console.WriteLine("After Shallow Copy ----------->");

            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); 
            #endregion

            #region Deep Copy
            //Arr02 = (int[]) Arr01.Clone();
            /// Deep Copy
            /// Clone Method will Generate new object with new different identity
            /// this object will have the same object state [data] of caller object "Arr01"

            //Console.WriteLine("After Deep Copy ------------->");

            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}");

            //Console.WriteLine("*******************************");
            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); 
            #endregion 
            #endregion
        }
    }
}
