namespace DPInterpreterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetVar("a", 10);
            context.SetVar("b", 20);
            context.SetVar("c", 70);

            IExpression expression = new MinusExpression(
                            new NumberExpression("c"),
                            new PlusExpression(new NumberExpression("a"), new NumberExpression("b"))
                            );
            Console.WriteLine(expression.Interpret(context));
        }
    }
}