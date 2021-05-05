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

        public bool Test_Triangle(int i, int j, int k)
        {
            bool check = false;
            if ( ((i + j) > k) && ((i + k) > j) && ((j + k) > i) )
            {
               check = true;
            }
            return check;
        }

        [Test]
        public void Test_Triangle_Area([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int i,
                                       [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int j,
                                       [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int k)
        {
         if (Test_Triangle(i, j, k))
         {
          double p = (i + j + k) / 2;
          double s = Math.Sqrt(p * (p - i) * (p - j) * (p - k));
          Assert.AreEqual(GeometricFigures.Triangle.GetArea(i, j, k), s, "Ожидаемая площадь треугольника не совпадает с полученной");
         }
         else
         {
          Assert.Fail("Не может существовать такого треугольника");
         }
        }

        [Test]
        public void Test_Triangle_Perimeter([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int i,
                                            [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int j,
                                            [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int k)
        {
        if (Test_Triangle(i, j, k))
          {
           Assert.AreEqual(GeometricFigures.Triangle.GetLength(i, j, k), (i + j + k), "Ожидаемый периметр треугольника не совпадает с полученным");
          }
        else
          {
           Assert.Fail("Не может существовать такого треугольника");
          }
        }

        [Test]
        public void Test_Rectangle_Area([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int i,
                                        [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int j)
        {  
        Assert.AreEqual(GeometricFigures.Rectangle.GetArea(i, j), (i * j), "Ожидаемая площадь прямоугольника не совпадает с полученной");
        }

        [Test]
        public void Test_Rectangle_Perimeter([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int i,
                                             [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int j)
        {
         Assert.AreEqual(GeometricFigures.Rectangle.GetLength(i, j), ((i + j) * 2), "Ожидаемый периметр прямоугольника не совпадает с полученным");
        }

        [Test]
        public void Test_Square_Area([Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int i)
        {
         Assert.AreEqual(GeometricFigures.Square.GetArea(i), (i * i), "Ожидаемая площадь квадрата не совпадает с полученной");
        }

        [Test]
        public void Test_Square_Perimeter([Values(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20)] int i)
        {
         Assert.AreEqual(GeometricFigures.Square.GetLength(i), (i * 4), "Ожидаемый периметр квадрата не совпадает с полученным");
        }
    }
}
