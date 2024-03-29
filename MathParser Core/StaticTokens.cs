﻿using System;
using System.Collections.Generic;

namespace MathParsing
{
    public partial class MathParser
    {
        static readonly Operator LeftParenthesis = new Operator("("),
            RightParenthesis = new Operator(")"),
            Comma = new Operator(",");

        static readonly UnaryOperator UnaryPlus = new UnaryOperator("un+", 6, (x) => x),
            UnaryMinus = new UnaryOperator("un-", 6, (x) => -x);

        static readonly BinaryOperator Plus = new BinaryOperator("+", 2, (x, y) => x + y),
                Minus = new BinaryOperator("-", 2, (x, y) => x - y);

        static readonly List<Operator> DefaultOperators =
            new List<Operator>
            {
                LeftParenthesis,
                RightParenthesis,
                Comma,
                UnaryPlus,
                UnaryMinus,
                Plus,
                Minus,
                new BinaryOperator("*", 4, (x, y) => x * y),
                new BinaryOperator("/", 4, (x, y) => x / y),
                new BinaryOperator("^", 8, Math.Pow),
                new BinaryOperator("%", 8, (x, y) => x % y)
            };

        static readonly List<Function> DefaultFunctions =
            new List<Function>
            {
                new UnaryFunction("sqrt", Math.Sqrt),
                new TrigonometricFunction("sin", Math.Sin),
                new TrigonometricFunction("cos", Math.Cos),
                new TrigonometricFunction("tan", Math.Tan),
                new TrigonometricFunction("sec", (x) => 1 / Math.Cos(x)),
                new TrigonometricFunction("cosec", (x) => 1 / Math.Sin(x)),
                new TrigonometricFunction("cot", (x) => 1 / Math.Tan(x)),
                new UnaryFunction("asin", Math.Asin),
                new UnaryFunction("acos", Math.Acos),
                new UnaryFunction("atan", Math.Atan),
                new UnaryFunction("sinh", Math.Sinh),
                new UnaryFunction("cosh", Math.Cosh),
                new UnaryFunction("tanh", Math.Tanh),
                new UnaryFunction("ln", Math.Log),
                new UnaryFunction("exp", Math.Exp),
                new UnaryFunction("abs", Math.Abs),
                new UnaryFunction("floor", Math.Floor),
                new UnaryFunction("ceiling", Math.Ceiling),
                new UnaryFunction("round", Math.Round),
                new UnaryFunction("sign", (x) => Math.Sign(x)),
                new UnaryFunction("truncate", Math.Truncate),
                new UnaryFunction("factorial", (x) => Combinatorics.Factorial((int)x)),
                new BinaryFunction("log", Math.Log),
                new BinaryFunction("max", Math.Max),
                new BinaryFunction("min", Math.Min),
                new BinaryFunction("c", (x, y) => Combinatorics.C((int)x, (int)y)),
                new BinaryFunction("p", (x, y) => Combinatorics.P((int)x, (int)y)),
                new TernaryFunction("clip", (val, min, max) =>
                    {
                        if (val < min) return min;
                        else if (val > max) return max;
                        else return val;
                    }),
                new PostfixFunction("!", (x) => Combinatorics.Factorial((int)x))
            };

        static readonly Dictionary<string, Constant> Constants =
            new Dictionary<string, Constant>
            {
                {"pi", Math.PI },
                {"e", Math.E }
            };
    }
}