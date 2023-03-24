using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OvereniJmena_POSITIVE()
        {
            int max = 10;
            string jmeno = "Ales123";
            Assert.IsTrue(jmeno.Length < max);
        }
        [TestMethod]
        public void OvereniJmena_NEGATIVE()
        {
            int max = 10;
            string jmeno = "Ales123456789";
            Assert.IsTrue(jmeno.Length < max);
        }
        [TestMethod]
        public void OvereniLevelu_POSITIVE()
        {
            int level = 1;
            Assert.IsTrue(level ==1);
        }

        [TestMethod]
        public void OvereniLevelu_NEGATIVE()
        {
            int level = 2;
            Assert.AreSame(level, 1);
        }
        [TestMethod]
        public void OvereniPoziceX_POSITIVE()
        {
            int poziceX = 0;

            Assert.IsTrue(poziceX ==0);
        }
        [TestMethod]
        public void OvereniPoziceX_NEGATIVE()
        {
            int poziceX = 1;

            Assert.AreSame(poziceX, 0);
        }
        [TestMethod]
        public void OvereniPoziceY_POSITIVE()
        {
            int poziceY = 0;

            Assert.IsTrue(poziceY==0);
        }
        [TestMethod]
        public void OvereniPoziceY_NEAGTIVE()
        {
            int poziceY = 1;

            Assert.AreSame(poziceY, 0);
        }
        [TestMethod]
        public void OvereniSpecializace_POSITIVE()
        {
            string specializace = "Kouzelnik";

            Assert.IsTrue(specializace == "Kouzelnik"|| specializace == "Berserker"|| specializace == "Inženýr"|| specializace == "Cizák");
        }
        [TestMethod]
        public void OvereniSpecializace_NEGATIVE()
        {
            string specializace = "Kouynik";

            Assert.IsTrue(specializace == "Kouzelnik" || specializace == "Berserker" || specializace == "Inženýr" || specializace == "Cizák");
        }
        [TestMethod]
        public void OvereniOblicej_POSITIVE()
        {
            int oblicej = 0;
            Assert.IsTrue(oblicej == 0);

        }
        [TestMethod]
        public void OvereniOblicej_NEGATIVE()
        {
            int oblicej = 1;
            Assert.IsTrue(oblicej == 0);

        }
        [TestMethod]
        public void OvereniVlasy_POSITIVE()
        {
            int vlasy = 0;
            Assert.IsTrue(vlasy == 0);

        }
        [TestMethod]
        public void OvereniVlasy_NEGATIVE()
        {
            int vlasy = 1;
            Assert.IsTrue(vlasy == 0);

        }
        [TestMethod]
        public void OvereniVlasyBarva_POSITIVE()
        {
            int vlasyBarva = 0;
            Assert.IsTrue(vlasyBarva == 0);

        }
        [TestMethod]
        public void OvereniVlasyBarva_NEGATIVE()
        {
            int vlasyBarva = 1;
            Assert.IsTrue(vlasyBarva == 0);

        }
        [TestMethod]
        public void OvereniXP_POSITIVE()
        {
            int xp = 0;
            Assert.IsTrue(xp== 0);

        }
        [TestMethod]
        public void OvereniXP_NEGATIVE()
        {
            int xp = 1;
            Assert.IsTrue(xp == 0);

        }
        [TestMethod]
        public void OvereniKonstruktoru_POSITIVE()
        {
            string staraSpecializace = "Kouzelnik";
            string novaSpecializace = "Kouzelnik";
            int staryOblicej = 1;
            int novyOblicej = 1;
            int staryVlasy = 1;
            int novyVlasy = 1;
            int staryVlasyBarva = 1;
            int novyVlasyBarva = 1;
            int staryXP = 1;
            int novyXP = 1;

            Assert.IsTrue(staraSpecializace == novaSpecializace && staryOblicej == novyOblicej && staryVlasy == novyVlasy && staryVlasyBarva == novyVlasyBarva && staryXP == novyXP);
        }
        [TestMethod]
        public void OvereniKonstruktoru_NEGATIVE()
        {
            string staraSpecializace = "Kouzelnik";
            string novaSpecializace = "Cizak";
            int staryOblicej = 1;
            int novyOblicej = 2;
            int staryVlasy = 1;
            int novyVlasy = 2;
            int staryVlasyBarva = 1;
            int novyVlasyBarva = 2;
            int staryXP = 1;
            int novyXP = 2;

            Assert.IsTrue(staraSpecializace == novaSpecializace && staryOblicej == novyOblicej && staryVlasy == novyVlasy && staryVlasyBarva == novyVlasyBarva && staryXP == novyXP);
        }


    }
}
