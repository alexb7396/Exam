using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManagement;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Citizen positiveCitizen = new Citizen();
            positiveCitizen.State = true;
            Citizen citizen1 = new Citizen();
            citizen1.State = false;
            Citizen citizen2 = new Citizen();
            citizen2.State = false;
            Citizen citizen3 = new Citizen();
            citizen3.State = false;
            HealthCompany asl = new HealthCompany();
            asl.AddTrakedCitizen(citizen1);
            asl.AddTrakedCitizen(citizen2);

            citizen1.ManageContact(positiveCitizen, new TimeSpan(1, 16, 0));
            positiveCitizen.ManageContact(citizen1, new TimeSpan(1, 16, 0));

            citizen1.ManageContact(citizen2, new TimeSpan(0, 15, 0));
            citizen2.ManageContact(citizen1, new TimeSpan(0, 15, 0));

            citizen1.ManageContact(citizen3, new TimeSpan(0, 12, 30));
            citizen3.ManageContact(citizen1, new TimeSpan(0, 12, 30));

            citizen2.ManageContact(citizen3, new TimeSpan(0, 30, 0));
            citizen3.ManageContact(citizen2, new TimeSpan(0, 30, 0));

            citizen1.UpdateContact(asl);
            citizen2.UpdateContact(asl);
            citizen3.UpdateContact(asl);
            positiveCitizen.UpdateContact(asl);

            Assert.AreEqual()

            
        }
    }
}
