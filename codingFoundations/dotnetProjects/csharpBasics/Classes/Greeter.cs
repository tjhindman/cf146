namespace Classes
{
    public class Greeter
    {
        /*
            METHOD STRUCTURE:
                1: access modifier -> where can property be seen?
                2: return type -> specifies the "type" of data expected to be returned 
                    from the method. if there is no "return", keyword "void" is used to 
                    represent nothing will be returned from this method.
                3: method signature -> combination of the method name and parameters
                4: body of code that is executed
        */
        // 1    2           3
        public void SayHello(string name)
        {
            // 4
            System.Console.WriteLine($"Hello {name}!");
        }
        
        public void SayHello()
        {
            // 4
            System.Console.WriteLine($"Good morning!");
        }
    }
}