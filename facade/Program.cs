﻿using System;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade("void main() { ... }");

            f.Execute();
        }
    }
}
