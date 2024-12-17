using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordConverter.service.core.Tests
{
    [TestClass()]
    public class NumberConverterServiceTests
    {
        NumberConverterService convertToWordImpl = new NumberConverterService();

        [TestMethod()]
        public void testOnlyCent_1()
        {
            String actual = convertToWordImpl.ToWord(0.23);

            Assert.AreEqual("TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testBelowTwenty_1()
        {
            String actual = convertToWordImpl.ToWord(3.23);

            Assert.AreEqual("THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testBelowTwenty_2()
        {
            String actual = convertToWordImpl.ToWord(13.23);

            Assert.AreEqual("THIRTEEN DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testBelowTwenty_3()
        {
            String actual = convertToWordImpl.ToWord(3.2399);

            Assert.AreEqual("THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testaboveTwenty_1()
        {
            String actual = convertToWordImpl.ToWord(23.2399);

            Assert.AreEqual("TWENTY-THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testHundredValue_1()
        {
            String actual = convertToWordImpl.ToWord(103.23);

            Assert.AreEqual("ONE HUNDRED THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testHundredValue_2()
        {
            String actual = convertToWordImpl.ToWord(173.23);

            Assert.AreEqual("ONE HUNDRED SEVENTY-THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testThousandValue_1()
        {
            String actual = convertToWordImpl.ToWord(1003.23);

            Assert.AreEqual("ONE THOUSAND THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testThousandValue_2()
        {
            String actual = convertToWordImpl.ToWord(1043.23);

            Assert.AreEqual("ONE THOUSAND FORTY-THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testThousandValue_3()
        {
            String actual = convertToWordImpl.ToWord(1543.26);

            Assert.AreEqual("ONE THOUSAND FIVE HUNDRED FORTY-THREE DOLLARS AND TWENTY-SIX CENTS", actual);
        }

        [TestMethod()]
        public void testTensThousandValue()
        {
            String actual = convertToWordImpl.ToWord(10031.23);

            Assert.AreEqual("TEN THOUSAND THIRTY-ONE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testHundredsThousandValue_2()
        {
            String actual = convertToWordImpl.ToWord(112043.23);

            Assert.AreEqual("ONE HUNDRED TWELVE THOUSAND FORTY-THREE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testMillionValue_1()
        {
            String actual = convertToWordImpl.ToWord(1128439.23);

            Assert.AreEqual("ONE MILLION ONE HUNDRED TWENTY-EIGHT THOUSAND FOUR HUNDRED THIRTY-NINE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testTensMillionValue_1()
        {
            String actual = convertToWordImpl.ToWord(15168439.23);

            Assert.AreEqual("FIFTEEN MILLION ONE HUNDRED SIXTY-EIGHT THOUSAND FOUR HUNDRED THIRTY-NINE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testHundredsMillionValue_1()
        {
            String actual = convertToWordImpl.ToWord(175168439.23);

            Assert.AreEqual("ONE HUNDRED SEVENTY-FIVE MILLION ONE HUNDRED SIXTY-EIGHT THOUSAND FOUR HUNDRED THIRTY-NINE DOLLARS AND TWENTY-THREE CENTS", actual);
        }

        [TestMethod()]
        public void testBillionValue_1()
        {
            String actual = convertToWordImpl.ToWord(1075168439.23);

            Assert.AreEqual("ONE BILLION SEVENTY-FIVE MILLION ONE HUNDRED SIXTY-EIGHT THOUSAND FOUR HUNDRED THIRTY-NINE DOLLARS AND TWENTY-THREE CENTS", actual);
        }
    }
}