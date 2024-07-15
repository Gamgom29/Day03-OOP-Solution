using Demo.Builtin_Interfaces;
using Demo.Interface_Example_01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null) return;
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

            #region Why The Description of Clone Method Say Its Shallow Copy
            //string[] Names01 = { "Amr", "Mona" };
            //string[] Names02 = { "Ahmed", "Yassmin" };
            //Console.WriteLine($"HashCode Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Names01 = {Names02.GetHashCode()}");

            //Names02 = (string[])Names01.Clone();
            //Console.WriteLine("After Deep Copy ----------->");

            //Console.WriteLine($"HashCode Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine("***************************");
            //Console.WriteLine(Names01[0].GetHashCode());
            //Console.WriteLine(Names02[0].GetHashCode());

            //Names02[0] = "Khaled";

            //Console.WriteLine(Names01[0]); 
            #endregion

            #region ICloneable Interface
            //Employee employee01 = new Employee() { Id = 10, Name = "Abdelrahman", Salary = 6_0000 , Department = new Department() { Code = 101 , Title = "Sales"} };
            //Employee employee02 = new Employee() { Id = 20, Name = "Ahmed", Salary = 4_0000, Department = new Department() { Code = 102, Title = "HR" } };

            //Console.WriteLine($"HashCode Of Employee01 {employee01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Employee02 {employee02.GetHashCode()}");

            ///* employee02 = (Employee) employee01.Clone()*/; // 2.1 Deep Copy Using Clone Method
            ///// Deep Copy
            ///// Clone Method Create new object with new identity 
            ///// this object will have the same state [data] Of caller object 

            //employee02 = new Employee(employee01); // 2.2 Deep Copy using Copy Constructor

            //Console.WriteLine("After Deep Copy----------------->");
            //Console.WriteLine($"HashCode Of Employee01 {employee01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Employee02 {employee02.GetHashCode()}");

            //Console.WriteLine("======================");
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);

            //if(employee02.Department is not null)
            //employee02.Department.Title = "New";

            //Console.WriteLine(employee01.Department.Title); 
            #endregion

            #region Built in Interfaces ICompareable
            //int[] Numbers = { 7, 4, 9, 2, 6, 10, 5, 3, 1, 8 };

            //Array.Sort(Numbers);
            //foreach (int i in Numbers)
            //    Console.Write($"{i} ");

            //Employee[] employees =
            //{
            //    new Employee() { Id = 10 , Name = "Omar" , Salary = 8_000},
            //    new Employee() { Id = 20 , Name = "Mona" , Salary = 2_000},
            //    new Employee() { Id = 30 , Name = "Eyad" , Salary = 10_000},
            //    new Employee() { Id = 40 , Name = "Fady" , Salary = 4_000}
            //};

            //Array.Sort(employees);

            //int Result = employees[0].CompareTo(employees[1]);
            //Console.WriteLine(Result);

            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee); 
            #endregion

            #region Builtin Interface IComparer
            //Employee[] employees =
            //{
            //    new Employee() { Id = 30 , Name = "Eyad" , Salary = 10_000},
            //    new Employee() { Id = 40 , Name = "Fady" , Salary = 4_000},
            //    new Employee() { Id = 10 , Name = "Omar" , Salary = 8_000},
            //    new Employee() { Id = 20 , Name = "Mona" , Salary = 2_000},
            //};

            //Array.Sort(employees , new EmployeeIDComparer());

            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee); 
            #endregion
        }
    }
}
