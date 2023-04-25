namespace RailwayTransport.Tests
{
    [TestClass]
    public class TrainTests
    {
        private static IWagon _expectedShortestWagon;
        private static IWagon _expectedLongestWagon;
        private static List<IWagon> _wagonsList;
        private static double _expectedTotalLength;

        private Train _train;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _expectedShortestWagon = new CargoWagon(12, 18, 40);
            _expectedLongestWagon = new CargoWagon(20, 34, 100);
            CargoWagon wagon = new CargoWagon();

            _expectedTotalLength = TrainCreator.CreateDieselLocomotive().Length + _expectedShortestWagon.Length + _expectedLongestWagon.Length + wagon.Length;
            _wagonsList = new List<IWagon> { _expectedShortestWagon, wagon, _expectedLongestWagon };
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _train = TrainCreator.CreateTrain(TrainCreator.CreateDieselLocomotive(), _wagonsList);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void AddWagon_NullWagon_ArgumentNullExceptionThrow()
        {
            TrainCreator.CreateEmptyTrain().AddWagon(null);
        }

        [TestMethod]
        public void FindShortestWagonTest()
        {
            var actualShortestWagon = _train.FindShortestWagon();
            Assert.AreSame(_expectedShortestWagon, actualShortestWagon);
        }

        [TestMethod]
        public void FindLongestWagonTest()
        {
            var actualLongestWagon = _train.FindLongestWagon();
            Assert.AreSame(_expectedLongestWagon, actualLongestWagon);
        }

        [TestMethod]
        public void LengthTest()
        {
            var actualTotalLength = _train.Length;
            Assert.AreEqual(_expectedTotalLength, actualTotalLength);
        }
    }
}