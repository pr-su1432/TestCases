namespace TestingMaxFloat
{
    public class Tests
    {
      

        [Test]
       
            public void GivenMaxInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
            {

                float A = 10, B = 9, C = 5;
                MaximumNumber.MaxFloatValue<float> example = new MaximumNumber.MaxFloatValue<float>();
                var ActuvalResult = example.maximumofintegers(A, B, C);
                Assert.AreEqual(A, ActuvalResult);


            }
            [Test]
            public void GivenMaxInSecondPosition_CheckMaxNumber_ReturnMaxInsecondPosition()
            {

                float A = 9, B = 10, C = 5;
                MaximumNumber.MaxFloat<float> example = new MaximumNumber.MaxFloat<float>();
                var ActuvalResult = example.maximumofSecintegers(A, B, C);
                Assert.AreEqual(B, ActuvalResult);


            }
            [Test]
            public void GivenMaxInThirsPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
            {

                float A = 9, B = 5, C = 10;
                MaximumNumber.MaxFloat<float> example = new MaximumNumber.MaxFloat<float>();
                var ActuvalResult = example.maximumofThirdintegers(A, B, C);
                Assert.AreEqual(C, ActuvalResult);


            }
        
    }
    
}