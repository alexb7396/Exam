using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManagement;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingBaseFunctionalities()
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
            asl.AddTrakedCitizen(citizen3);
            asl.AddTrakedCitizen(positiveCitizen);

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

            Assert.AreEqual(1, asl.PositiveCitizens.Count);
            Assert.AreEqual(4, asl.TrakedCitizens.Count);
            Assert.IsTrue(citizen1.ContactWithPositive);
            Assert.IsTrue(!citizen2.ContactWithPositive);
            Assert.IsTrue(!citizen3.ContactWithPositive);

            asl.SwitchCitizenState(citizen3,true);

            Assert.AreEqual(2, asl.PositiveCitizens.Count);
            Assert.AreEqual(4, asl.TrakedCitizens.Count);
            Assert.IsTrue(citizen1.ContactWithPositive);
            Assert.IsTrue(citizen2.ContactWithPositive);
            Assert.IsTrue(!citizen3.ContactWithPositive);

        }

        [TestMethod]
        public void TestingExceptions()
        {
            Citizen positiveCitizen = new Citizen();
            positiveCitizen.State = true;
            Citizen citizen1 = new Citizen();
            citizen1.State = false;
            Citizen citizen2 = new Citizen();
            citizen2.State = false;
            HealthCompany asl = new HealthCompany();

            asl.AddTrakedCitizen(positiveCitizen);
            asl.AddTrakedCitizen(citizen1);

            try
            {
                asl.SwitchCitizenState(positiveCitizen, true);
            }
            catch (ApplicationException)
            {
                try
                {
                    asl.SwitchCitizenState(citizen1, false);
                }
                catch (ApplicationException)
                {
                    try
                    {
                        asl.SwitchCitizenState(citizen2, true);
                    }
                    catch (ApplicationException)
                    {
                        return;
                    }
                }
            }
            throw new Exception("Expected exceptions");
        }
    }
}
