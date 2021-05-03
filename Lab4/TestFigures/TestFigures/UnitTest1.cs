using NUnit.Framework;
using System;

namespace TestFigures
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public bool Test_Triangle(int a, int b, int c)
        {
            bool check = true;
            if ((a + b) < c)
            {
                check = false;
            }
            if ((a + c) < b)
            {
                check = false;
            }
            if ((c + b) < a)
            {
                check = false;
            }
            return check;
        }



        [Test]
        public void Test_Triangle_Area()
        {
            for(int i = 1; i<20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    for (int k = 1; k < 20; k++)
                    {
                        if (Test_Triangle(i,j,k))
                        {
                            double p = (i + j + k) / 2;
                            double s = Math.Sqrt(p * (p - i) * (p - j) * (p - k));
                            Assert.AreEqual(GeometricFigures.Triangle.GetArea(i, j, k), s);
                        }
                    }
                }
            }
            Assert.Pass();
        }
        
        [Test]
        public void Test_Triangle_Perimeter()
        {
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    for (int k = 1; k < 20; k++)
                    {
                        if (Test_Triangle(i, j, k))
                        {
                            Assert.AreEqual(GeometricFigures.Triangle.GetLength(i, j, k), (i+j+k));
                        }
                    }
                }
            }
            Assert.Pass();
        }
        
        [Test]
        public void Test_Rectangle_Area()
        {
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                  Assert.AreEqual(GeometricFigures.Rectangle.GetArea(i, j), (i * j));

                }
            }
            Assert.Pass();
        }
        
        [Test]
        public void Test_Rectangle_Perimeter()
        {
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    Assert.AreEqual(GeometricFigures.Rectangle.GetLength(i, j), ((i + j)*2));
                }
            }
            Assert.Pass();
        }
        
        [Test]
        public void Test_Square_Area()
        {
            for (int i = 1; i < 20; i++)
            {
                Assert.AreEqual(GeometricFigures.Square.GetArea(i), (i * i));
            }
            Assert.Pass();
        }
        
        [Test]
        public void Test_Square_Perimeter()
        {
            for (int i = 1; i < 20; i++)
            {
                Assert.AreEqual(GeometricFigures.Square.GetArea(i), (i * 4));
            }
            Assert.Pass();
        }
    }
}