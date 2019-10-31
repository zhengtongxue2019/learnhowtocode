using System;
using NUnit.Framework;
using Ch01;

namespace TestCh01
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string result = Program.GetStatement();
            string exceptedResult = @"Rental Record For 张三
攀登者:6
哪吒之魔童降世:1.5
昆虫总动员:3
战狼:2
让子弹飞:5
Amount owed is 17.5
You earned 6 frequent renter points。
";
            Assert.AreEqual(exceptedResult,result);
        }
    }
}