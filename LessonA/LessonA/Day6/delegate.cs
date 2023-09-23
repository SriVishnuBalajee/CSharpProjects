public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);
class MathCalculator
        {
            public void DoTask()
            {
                Console.WriteLine("Calculator DoTask");
            }
            public int Add(int x, int y)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                return x + y;
            }
            public int multiply(int x, int y)
            {
                return x * y;
            }
            public double Divide(double x, double y)
            {
                return x / y;
            }
            public class DelegateDemo
            {
                public void Test1()
                {
                    MathCalculator mc = new MathCalculator();
                    MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
                    MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);
                    MethodHandlerB methodHandlerB1 = new MethodHandlerB(mc.multiply);
                    // MethodHandlerA methodHandlerA = new MethodHandlerA(mc.Divide);
                }
            }
}
    

