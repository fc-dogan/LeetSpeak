using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChecker;

namespace TriangleChecker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_HasInputsGreaterThanZero_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(1, 2, 3));
    }

    [TestMethod]
    public void IsTriangle_IsOneSideGreaterThanSumOfTwoSides_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(1, 2, 6));
    }

    [TestMethod]
    public void TriangleType_AreAllSidesEqual_EquilateralTriangle()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral Triangle", testTriangle.TriangleType(3, 3, 3));
    }

    [TestMethod]
    public void TriangleType_AreTwoSidesEqual_IsoscelesTriangle()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles Triangle", testTriangle.TriangleType(3, 3, 5));
    }

    [TestMethod]
    public void TriangleType_AreNoSidesEqual_ScaleneTriangle()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene Triangle", testTriangle.TriangleType(3, 4, 5));
    }



  }
}