using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Server
{
    public class NewNUnit
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           Console.WriteLine("hello");
            Assert.Pass();
        }
    }
}