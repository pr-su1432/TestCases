namespace TestingMaxValue
{
    public class Tests
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
    }
}