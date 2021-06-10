using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void initialize()
        {
            SailBoat sailBoat1 = new SailBoat();
            sailBoat1.HourlyCost = 15;
            SailBoat sailBoat2 = new SailBoat();
            sailBoat2.HourlyCost = 20;
            SailBoat sailBoat3 = new SailBoat();
            sailBoat3.HourlyCost = 10;
            SailBoat sailBoat4 = new SailBoat();
            sailBoat4.HourlyCost = 15;
            MotorBoat motorBoat1 = new MotorBoat();
            motorBoat1.HourlyCost = 25;
            MotorBoat motorBoat2 = new MotorBoat();
            motorBoat2.HourlyCost = 30;
            MotorBoat motorBoat3 = new MotorBoat();
            motorBoat3.HourlyCost = 50;
            MotorBoat motorBoat4 = new MotorBoat();
            motorBoat4.HourlyCost = 30;
            BoatRental myboatRental = new BoatRental("BalestraMoretto & CO","Genova, Corso Italia 2");
            myboatRental.AddBoat
            
        }
       
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
