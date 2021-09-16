using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProgrammingIIITest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void validLengthTest()
        {
            object[,] positiveTestData = new object[,] {
                { "Programming", 1, 11 },
                { "A", 1, 1 },
                { "North West Regional College, Strand Rd, Londonderry, Londonderry, BT48 7AL, United Kingdom", 89, 90 },
                { "01234567890", 10, 11 }
            };
            for (int i = 0; i < positiveTestData.Length / 3; i++)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validLength((string)positiveTestData[i, 0], (int)positiveTestData[i, 1], (int)positiveTestData[i, 2]));
            }
            object[,] negativeTestData = new object[,] {
                { "Programming", 1, 10 },
                { "A", 2, 5 },
                { "North West Regional College, Strand Rd, Londonderry, Londonderry, BT48 7AL, United Kingdom", 91, 100 },
                { "01234567890", 1, 10 }
            };
            for (int i = 0; i < negativeTestData.Length / 3; i++)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validLength((string)negativeTestData[i, 0], (int)negativeTestData[i, 1], (int)negativeTestData[i, 2]));
            }
        }
        [TestMethod]
        public void validNumberTest()
        {
            string[] positiveTestData = new string[] { "1", "0", "-1", "1.1", "920823094734987923764320470631", "999", "-1243872364983274632" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validNumber(s));
            }
            string[] negativeTestData = new string[] { "-", ".", " ", "    ", "one", "a", "\n" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validNumber(s));
            }
        }
        [TestMethod]
        public void validLettersTest()
        {
            string[] positiveTestData = new string[] { "Programming", "A", "Ten", "a", "NorthWestRegionalCollegeStrandRdLondonderryLondonderryUnitedKingdom" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validLetter(s));
            }
            string[] negativeTestData = new string[] { "-", ".", " ", "    ", "1", "9999999", "\n", "Programming III", "Programming3" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validLetter(s));
            }
        }
        [TestMethod]
        public void validLettersWhitepaceTest()
        {
            string[] positiveTestData = new string[] { "Programming III", "A", "Ten", "a", "North West Regional College Strand Rd Londonderry Londonderry United Kingdom", "One Hundred and Ninety Nine" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validLetterWhiteSpace(s));
            }
            string[] negativeTestData = new string[] { "-", ".", " ", "    ", "1", "9999999", "\n", "Programming,III", "Programming3" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validLetterWhiteSpace(s));
            }
        }
        [TestMethod]
        public void validLettersWhitepaceNumberTest()
        {
            string[] positiveTestData = new string[] { "Programming 3", "A", "Ten", "a", "North West Regional College Strand Rd Londonderry Londonderry BT48 7AL  United Kingdom", "One Hundred and Ninety Nine", "199", "10 20 30" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validLetterWhiteSpaceNumber(s));
            }
            string[] negativeTestData = new string[] { "-", ".", " ", "    ", "\n", "Programming,III", "Programming-3", "North West Regional College, Strand Rd, Londonderry, Londonderry, BT48 7AL, United Kingdom" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validLetterWhiteSpaceNumber(s));
            }
        }
        [TestMethod]
        public void validForename()
        {
            string[] positiveTestData = new string[] { "Colm", "Louise", "Lee", "Canice", "Ryan Wojciech", "Peter-Dylan", "Róisín", "花子" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validForename(s));
            }
            string[] negativeTestData = new string[] { ".", " ", "    ", "\n", "Colm,Louise", "L33", "Canice?", "Ryan/Wojciech", "Peter+Dylan" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validForename(s));
            }
        }
        [TestMethod]
        public void validSurname()
        {
            string[] positiveTestData = new string[] { "Canavan", "Gallagher", "Cusack/Kearney", "Campbell Geslak", "Roddy-Robinson", "O'Clery", "山本" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validSurname(s));
            }
            string[] negativeTestData = new string[] { ".", " ", "    ", "\n", "Canavan,Gallagher", "K3arn3y", "Cusack?", "Campbell\\Geslak", "Roddy+Robinson" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validSurname(s));
            }
        }
        [TestMethod]
        public void validDOBDaysTest()
        {
            DateTime date = new DateTime(2021, 9, 14);
            object[,] positiveTestData = new object[,] {
                { "19/07/2021", 57, 58 },
                { "14/09/2020", 364, 366 },
                { "13/09/2021", 1, 2 },
                { "12/12/1966", 19999, 20001 }
            };
            for (int i = 0; i < positiveTestData.Length / 3; i++)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validDOBDays((string)positiveTestData[i, 0], date, (int)positiveTestData[i, 1], (int)positiveTestData[i, 2]));
            }
            object[,] negativeTestData = new object[,] {
                { "19/07/2021", 58, 59 },
                { "14/09/2020", 1, 364 },
                { "13/09/2021", 2, 3 },
                { "12/12/1966", 19990, 19999 }
            };
            for (int i = 0; i < negativeTestData.Length / 3; i++)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validDOBDays((string)negativeTestData[i, 0], date, (int)negativeTestData[i, 1], (int)negativeTestData[i, 2]));
            }
        }
        [TestMethod]
        public void validDOBYearsTest()
        {
            DateTime date = new DateTime(2021, 9, 14);
            object[,] positiveTestData = new object[,] {
                { "19/07/2021", 0,  1},
                { "14/09/2003", 18, 200 },
                { "01/01/1900", 100, 122 },
                { "30/11/1984", 36, 37 }
            };
            for (int i = 0; i < positiveTestData.Length / 3; i++)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validDOBYears((string)positiveTestData[i, 0], date, (int)positiveTestData[i, 1], (int)positiveTestData[i, 2]));
            }
            object[,] negativeTestData = new object[,] {
                { "19/07/2021", 2, 3 },
                { "14/09/2003", 20, 200 },
                { "01/01/1900", 100, 120 },
                { "30/11/1984", 1, 35 }
            };
            for (int i = 0; i < negativeTestData.Length / 3; i++)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validDOBYears((string)negativeTestData[i, 0], date, (int)negativeTestData[i, 1], (int)negativeTestData[i, 2]));
            }
        }
        [TestMethod]
        public void validEmailTest()
        {
            string[] positiveTestData = new string[] { "30004001@live.nwrc.ac.uk", "Colm@derrysmarttour.com", "!#$%&'*+-/=?^_`{|}~.wierdemail@Hotmail.com", "colm.canavan@test.nowhere.co.uk" };
            foreach (string s in positiveTestData)
            {
                Assert.IsTrue(ProgrammingIII.Validation.validEmail(s));
            }
            string[] negativeTestData = new string[] { "30004001.live.nwrc.ac.uk", "colm@derrysmarttour..com", "    ", "\n", "@hotmail.com", "fakeemail@hotmail.com.", "!#$%&'*+-/=?^_`{|}~@.hotmail!.com", "fakeemail@gmail.c0m", "30004001@NWRC" };
            foreach (string s in negativeTestData)
            {
                Assert.IsFalse(ProgrammingIII.Validation.validEmail(s));
            }
        }
    }
}
