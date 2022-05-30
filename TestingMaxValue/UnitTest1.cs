namespace TestingMaxValue
{
    public class UnitTest1
    {

        [Test]

        public void GivenMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {

            int A = 10, B = 9, C = 5;
            MaximumNumber.MaxValue<int> example = new MaximumNumber.MaxValue<int>();
            var ActuvalResult = example.maximumofintegers(A, B, C);
            Assert.AreEqual(A, ActuvalResult);


        }
        [Test]
        public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            int A = 9, B = 10, C = 5;
            MaximumNumber.MaxValue<int> example = new MaximumNumber.MaxValue<int>();
            var ActuvalResult = example.maximumofSecintegers(A, B, C);
            Assert.AreEqual(B, ActuvalResult);


        }
        [Test]
        public void GivenMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            int A = 9, B = 5, C = 10;
            MaximumNumber.MaxValue<int> example = new MaximumNumber.MaxValue<int>();
            var ActuvalResult = example.maximumofThirdintegers(A, B, C);
            Assert.AreEqual(C, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueInFirstPosition_CheckMaxNumber_ReturnMaxValueInFirstPosition()
        {

            double A = 100.5, B = 90.67, C = 54.45;
            MaximumNumber.MaxValue<double> example = new MaximumNumber.MaxValue<double>();
            var ActuvalResult = example.MaximumofFloatValue(A, B, C);
            Assert.AreEqual(A, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueInSecondPosition_CheckMaxNumber_ReturnMaxValueInsecondPosition()
        {

            double A = 90.67, B = 100.5, C = 54.45;
            MaximumNumber.MaxValue<double> example = new MaximumNumber.MaxValue<double>();
            var ActuvalResult = example.maximumofSecFloatvalue(A, B, C);
            Assert.AreEqual(B, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueInThirdPosition_CheckMaxNumber_ReturnMaxValueInThirdPosition()
        {

            double A = 90.67, B = 54.45, C = 100.5;
            MaximumNumber.MaxValue<double> example = new MaximumNumber.MaxValue<double>();
            var ActuvalResult = example.maximumofThirdFloatValue(A, B, C);
            Assert.AreEqual(C, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueOfInThirdPosition_CheckMaxNumber_ReturnMaxValueofInThirdPosition()
        {

            string A = "Apple", B = "Banana", C = "Peach";
            MaximumNumber.MaxValue<string> example = new MaximumNumber.MaxValue<string>();
            var ActuvalResult = example.MaximumofStringValue(A,B,C);
            Assert.AreEqual(C, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueOfInFirstPosition_CheckMaxNumber_ReturnMaxValueofInFirstPosition()
        {

            string A = "Peach", B = "Banana", C = "Apple";
            MaximumNumber.MaxValue<string> example = new MaximumNumber.MaxValue<string>();
            var ActuvalResult = example.MaximumofFirstStringValue(A, B, C);
            Assert.AreEqual(A, ActuvalResult);


        }
        [Test]
        public void GivenMaxValueOfInSecondPosition_CheckMaxNumber_ReturnMaxValueofInSecondPosition()
        {

            string A = "Apple", B = "Peach", C = "Banana";
            MaximumNumber.MaxValue<string> example = new MaximumNumber.MaxValue<string>();
            var ActuvalResult = example.MaximumofSecStringValue(A, B, C);
            Assert.AreEqual(B, ActuvalResult);


        }
    }
}
