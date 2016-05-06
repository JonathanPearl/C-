using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SMS;

namespace TestSMS
{
    [TestFixture]
    class TestSMSSearch
    {
        private const string ExampleSMS = "FNB R1234.83 paid to Cheq a/c.. 264056 @ EFT Ref. BKH Instuno 1 Notti 2 Dec 00:00";

        [TestCase (ExampleSMS,"FNB", new int [] {0})]
        [TestCase("FNB FNB", "FNB", new int [] {0,5})]
        public void GivenWordInMessageExpectedWordLocationInString (string message , string searchValue , int [] wordLocations)
        {
            var foundWordLocations = SMSSearch.SearchForWords(searchValue,message);
            Assert.AreEqual(wordLocations,foundWordLocations.To );
        }
        
     
    }
}
