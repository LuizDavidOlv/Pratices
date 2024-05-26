﻿using src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Interfaces;

namespace src.DesignPatterns.CreationalPatterns.FactoryMethod.CreatorExample.Products
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
