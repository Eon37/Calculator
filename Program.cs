using System;

namespace lab5
{
    class Client
    {
        static void Main(string[] args)
        {
            Expression ex = new DivOp(new AddOp(new Variable("x"), new Literal(5)), new MultOp(new Literal(10), new Literal(20)));

            Console.WriteLine((ex.acceptVisitor(new CalcExpr())).acceptVisitor(new PrintExpr()));
        }
    }
}
