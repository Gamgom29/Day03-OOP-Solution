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
        }
    }
}
