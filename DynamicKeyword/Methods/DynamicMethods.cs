using System.Reflection;

namespace DynamicKeyword.Methods
{
    public static class DynamicMethods
    {
        public static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";

            dynamic s3 = "Minneapolis";
                        
            Console.WriteLine($"s1 is of type: {s1.GetType()}" );
            Console.WriteLine($"s2 is of type: {s2.GetType()}");
            Console.WriteLine($"s3 is of type: {s3.GetType()}");
            Console.ReadLine();
        }

        public static void ChangeDynamicDataType()
        {
            // Declare a single dynamic data point
            // named "t".
            dynamic t = "Hello!";
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = false;
            Console.WriteLine("t is of type: {0}", t.GetType());

            t = new List<int>();
            Console.WriteLine("t is of type: {0}", t.GetType());
            Console.ReadLine();
        }

        public static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";
            try
            {
                Console.WriteLine(textData1.ToUpper());
                Console.WriteLine(textData1.toupper());
                Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InvokeMethodWithDynamicKeyword(Assembly asm)
        {
            try
            {
                // Get metadata for the Minivan type.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                // Create the Minivan on the fly and call method!
                dynamic obj = Activator.CreateInstance(miniVan);
                obj.TurboBoost();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static dynamic DynamicAdd(dynamic num1, dynamic num2)
        {
            dynamic ans = num1 + num2;
            Console.WriteLine(ans.ToString());
            Console.ReadLine();
            return ans;
        }

        public static void Concatstrings(dynamic s1, dynamic s2)
        {
            dynamic result = s1 + s2;
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
