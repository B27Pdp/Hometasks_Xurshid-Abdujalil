using System;
using static Home.L10_Delegates.ClassWork.AnonymousDelegates;

namespace Home.L10_Delegates.ClassWork
{
	public class LambdaExpression
	{
        public static bool Rub()
        {
            AnonymousDelegates.SmsServicePointer smsServicePointer = (phone) =>
            { Console.WriteLine("This is anonymous delegate with labda expression!"); return true; };
            // comfy anonymous delegate with Lambda Expression !

            AnonymousDelegates.SmsServicePointer smsServicePointer2 = num =>
            { Console.WriteLine("This is what you wrote : {0}", num); return true; };
            return true;
        }  





	}
}

