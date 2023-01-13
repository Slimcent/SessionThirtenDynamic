namespace DynamicKeyword.Methods
{
    public static class NormalMethods
    {
        public static void UseObjectVariable()
        {
            // Create a new instance of the Person class
            // and assign it to a variable of type System.Object
            object o = new Person() { FirstName = "Mike", LastName = "Larson" };

            // Must cast object as Person to gain access
            // to the Person properties.
            Console.WriteLine("Person's first name is {0}", ((Person)o).FirstName);
            Console.ReadLine();
        }

        public static void ImplicitlyTypedVariable()
        {
            // a is of type List<int>.
            var a = new List<int> { 90 };

            // This would be a compile-time error!
            //a = "Hello";
        }
    }
}
