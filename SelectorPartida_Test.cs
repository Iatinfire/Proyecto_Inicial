using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poyecto_UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        public void QuienJuega_Test()
        {
            string expectedResult = "Player1";
            int actualValue = "Player1";
            ApplicationCodeClass appObject = new ApplicationCodeClass();

            string actualResult = appObject.combineArrayStringWithSpace(AnalistaPartidas.QuienJuega());
            Assert.AreEqual<string>(expectedResult, actualResult);
        }

        public void PrimerTiroPlayer1_Test()
        {
            bool expectedResult = true;
            bool actualValue = false;
            ApplicationCodeClass appObject = new ApplicationCodeClass();

            string actualResult = appObject.combineArrayStringWithSpace(AnalistaPartidas.PrimerTiroPlayer1()());
            Assert.AreEqual<string>(expectedResult, actualResult);
        }
        
    }
}
