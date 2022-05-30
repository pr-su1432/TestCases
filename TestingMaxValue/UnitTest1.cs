namespace TestingMaxValue
{
    public class UnitTest1
    {

        [Test]

        public void GivenIntArray_CheckMaxValue_ReturnMaxValue()
        {

            int[] arr = { 7, 56, 45, 25, 70, 88, 90 };
            MaximumNumber.MaxValue<int> example = new MaximumNumber.MaxValue<int>(arr);
            var ActuvalResult = example.CheckMaximumValue();
            Assert.AreEqual(90, ActuvalResult);


        }
        
        [Test]
        public void GivendoubleArray_CheckMaxValue_ReturnMaxValue()
        {


            double[] arr_ = { 10.5, 16.56, 25.7, 67.45, 45.34, 68.78 };
            MaximumNumber.MaxValue<double> example = new MaximumNumber.MaxValue<double>(arr_);
            var ActuvalResult = example.CheckMaximumValue();
            Assert.AreEqual(68.78, ActuvalResult);


        }
        [Test]
        
        public void GivenStringArray_CheckMaxValue_ReturnMaxValue()
        {

            string[] _arr = { "prasanna", "arjun", "nanna", "malli", "vara" };
            MaximumNumber.MaxValue<string> example = new MaximumNumber.MaxValue<string>(_arr);
            var ActuvalResult = example.CheckMaximumValue();
            Assert.AreEqual("vara", ActuvalResult);


        }
        
        

    }
}
