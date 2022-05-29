namespace TestingMaxValue
{
    public class UnitTest1
    {
        [Test]
        public void GivenMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {
            
            double A = 100.5, B = 90.67, C = 54.45;
            MaximumNumber.MaxFloatValue<double> example = new MaximumNumber.MaxFloatValue<double>();
            var ActuvalResult = example.maximumofintegers(A, B, C);
            Assert.AreEqual(A, ActuvalResult);


        }
        [Test]
        public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
        {

            double A = 90.67, B = 100.5, C = 54.45;
            MaximumNumber.MaxFloatValue<double> example = new MaximumNumber.MaxFloatValue<double>();
            var ActuvalResult = example.maximumofSecintegers(A, B, C);
            Assert.AreEqual(B, ActuvalResult);


        }
        [Test]
        public void GivenMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {

            double A = 90.67, B = 54.45, C = 100.5;
            MaximumNumber.MaxFloatValue<double> example = new MaximumNumber.MaxFloatValue<double>();
            var ActuvalResult = example.maximumofThirdintegers(A, B, C);
            Assert.AreEqual(C, ActuvalResult);


        }
    }
}