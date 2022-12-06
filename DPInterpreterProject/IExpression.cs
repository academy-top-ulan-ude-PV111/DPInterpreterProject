using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPInterpreterProject
{
    interface IExpression
    {
        int Interpret(Context context);
    }

    class PlusExpression : IExpression
    {
        IExpression expressionLeft;
        IExpression expressionRight;

        public PlusExpression(IExpression expressionLeft, IExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
        }

        public int Interpret(Context context)
        {
            return expressionLeft.Interpret(context) + expressionRight.Interpret(context);
        }
    }

    class MinusExpression : IExpression
    {
        IExpression expressionLeft;
        IExpression expressionRight;

        public MinusExpression(IExpression expressionLeft, IExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
        }

        public int Interpret(Context context)
        {
            return expressionLeft.Interpret(context) - expressionRight.Interpret(context);
        }
    }

    class NumberExpression : IExpression
    {
        string name;
        public NumberExpression(string name)
        {
            this.name = name;
        }
        public int Interpret(Context context)
        {
            return context.GetVar(name);
        }
    }
}
