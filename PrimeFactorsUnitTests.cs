using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void PrimeFactorsOf30()
        {
            //arrange
            int number = 30;
            string expected = "2 * 3 * 5";

            //act
            string actual = PrimeFactors.PrimeFactorsGenerate(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf656()
        {
            //arrange
            int number = 656;
            string expected = "2 * 2 * 2 * 2 * 41";

            //act
            string actual = PrimeFactors.PrimeFactorsGenerate(number);

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void PrimeFactorsOf723()
        {
            //arrange
            int number = 723;
            string expected = "3 * 241";

            //act
            string actual = PrimeFactors.PrimeFactorsGenerate(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf2()
        {
            //arrange
            int number = 2;
            string expected = "2";

            //act
            string actual = PrimeFactors.PrimeFactorsGenerate(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf0()
        {
            //arrange
            int number = 0;
            string expected = "number must be between 1 and 1000.";

            //act
            string actual = PrimeFactors.PrimeFactorsGenerate(number);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}