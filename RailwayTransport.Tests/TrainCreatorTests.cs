using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Tests
{
    [TestClass]
    public class TrainCreatorTests
    {
        [TestMethod]
        public void CreateWagons_30_ListWith30WagonsReturn()
        {
            //arrange
            int input = 30;
            int expected = 30;
            //act
            var wagonsList = TrainCreator.CreateWagons(input);
            //assert
            Assert.AreEqual(expected, wagonsList.Count);
        }

        [TestMethod]
        public void CreateTrain_30_TrainWith30WagonsReturn()
        {
            //arrange
            int input = 30;
            int expected = 30;
            //act
            int actual = TrainCreator.CreateTrain(input).Wagons.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateTrain_CreateLocomotiveAndCreate30Wagons_TrainWith30WagonsReturn()
        {
            //arrange
            int input = 30;
            int expected = 30;
            //act
            int actual = TrainCreator.CreateTrain(TrainCreator.CreateDieselLocomotive(), TrainCreator.CreateWagons(input)).Wagons.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void CreateWagons_LessThanOne_ArgumentOutOfRangeException()
        {
            int[] input = { 0, -1, -214 };

            for (int i = 0; i < 3; i++)
            {
                TrainCreator.CreateWagons(input[i]);
            }
        }

        [TestMethod]
        public void CreateEmptyTrain_Null()
        {
            IWagon expected = null;

            var train = TrainCreator.CreateEmptyTrain();

            var actual = train.FindLongestWagon();
            Assert.AreEqual(expected, actual);

            actual = train.FindShortestWagon();
            Assert.AreEqual(expected, actual);
        }
    }
}
