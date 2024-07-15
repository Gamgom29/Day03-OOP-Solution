﻿using Assignment.Question_02;
using Assignment.Question03;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q01 : What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion

            #region Q02 : Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            #endregion

            #region Q03 : Can an interface contain fields in C#?
            //  b) No
            #endregion

            #region Q04 :In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q05: Which keyword is used to implement an interface in a class in C#?
            // d) implements
            #endregion

            #region Q06 :Can an interface contain static methods in C#?
            //  a) Yes
            #endregion

            #region َQ7: In C#, can an interface have explicit access modifiers for its members?
            // b) No, all members are implicitly public
            #endregion

            #region Q08: What is the purpose of an explicit interface implementation in C#?
            // a) To hide the interface members from outside access
            #endregion

            #region Q09:  In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors
            #endregion

            #region Q10: How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion
            #endregion

            #region Part 02

            #region Q01

            //Rectangle Rectangle = new Rectangle() { Width = 10 , Height = 20};
            //Rectangle.DisplayShapeInfo();

            //Circle Circle = new Circle() { Radius = 5};
            //Circle.DisplayShapeInfo();
            #endregion

            #region Q02
            //IAuthenticationService authService  = new BasicAuthenticationService();
            //Console.WriteLine( authService.AuthenticateUser("Abdelrahman", "Aa12345"));
            //Console.WriteLine(authService.AuthorizeUser("Abdelrahman"));

            #endregion

            #region Q03
            SmsNotificationService SMS = new SmsNotificationService();
            SMS.SendNotification("01143101501", "Hello From Sms Service");
            Console.WriteLine();

            EmailNotificationService Email = new EmailNotificationService();
            Email.SendNotification("Amena.route@gmail.com", "Hello Amena");
            Console.WriteLine();

            PushNotificationService Push = new PushNotificationService();
            Push.SendNotification("Anounumus@gmail.com", "Hello From the Other Side");
            Console.WriteLine();
            #endregion
            #endregion
        }
    }
}
