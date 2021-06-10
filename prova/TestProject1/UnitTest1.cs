using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
    
        [TestMethod]
        public void TestRentBoats()
        {

            Customer user1 = new Customer();
            user1.licence = Licenses.A;
            Customer user2 = new Customer();
            Customer user3 = new Customer();
            user3.licence = Licenses.B;
           

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
            BoatRental myboatRental = new BoatRental("BalestraMoretto & CO", "Genova, Corso Italia 2");

            myboatRental.AddBoats(sailBoat1);
            myboatRental.AddBoats(sailBoat2);
            myboatRental.AddBoats(sailBoat3);
            myboatRental.AddBoats(sailBoat4);
            myboatRental.AddBoats(motorBoat1);
            myboatRental.AddBoats(motorBoat2);
            myboatRental.AddBoats(motorBoat3);
            myboatRental.AddBoats(motorBoat4);
            myboatRental.AddEmployees(new Skipper(1,1));

            Assert.IsTrue(myboatRental.RentBoat(user1, sailBoat1));
            Assert.IsTrue(myboatRental.RentBoat(user2, sailBoat2));
            Assert.IsTrue(!myboatRental.RentBoat(user2, motorBoat3));
            Assert.IsTrue(myboatRental.RentBoat(user3, motorBoat3));
            
        }
    }
}
