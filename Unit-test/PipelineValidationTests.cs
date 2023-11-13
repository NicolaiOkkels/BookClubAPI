namespace Unit_test
{
    public class FailureTest
    {
        //Test if pipeline react as expected
        [Fact]
        public void FailingTest()
        {
            Assert.False(true); // This test will fail
        }
    }
}