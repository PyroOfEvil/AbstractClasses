﻿using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Ford ford= new Ford();
            ford.Start();
            ford.Drive();
            ford.CruiseControl();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            dodge.CruiseControl();
        }
    }
}
