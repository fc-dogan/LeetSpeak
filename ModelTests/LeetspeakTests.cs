using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeaker;

namespace Leetspeaker.Tests
{
  [TestClass]
  public class LeetspeakTests
  {
    [TestMethod]
    public void Translate_ChangeEtoThree_H3y()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("H3y", testTranslator.Translate("Hey"));
    }

    [TestMethod]
      public void Translate_ChangeOtoZero_0h()
      {
        LeetspeakTranslator testTranslator = new LeetspeakTranslator();
        Assert.AreEqual("0h", testTranslator.Translate("Oh"));
      }

    [TestMethod]
    public void Translate_ChangeLToOne_100k()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("100k", testTranslator.Translate("Look"));
    }
    [TestMethod]
    public void Translate_ChangeTToSeven_1a73r()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("1a73r", testTranslator.Translate("Later"));
    }
    [TestMethod]
    public void Translate_ChangeSToZ_Sazz()
    {
      LeetspeakTranslator testTranslator = new LeetspeakTranslator();
      Assert.AreEqual("H3y Sazz", testTranslator.Translate("Hey Sass"));
    }
  }
}