using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Test
{
    [TestFixture]
    class TestSms
    {

        private string exampleSMS = "FNB R1234.83 paid to Cheq a/c.. 264056 @ EFT Ref. BKH Instuno. 1 Notti 2 Dec 00:00";

        [TestCase("Word", "Word", new int [] {0})]
        [TestCase("Word, Word",new int [] {0,1})]
        public void WordLocator(string message, string compareValue, int [] expectedLocations)
        {
            Assert.AreEqual(expectedLocations, SMSFunctions.GetWordLocation(message,compareValue));
        }


    }
}
