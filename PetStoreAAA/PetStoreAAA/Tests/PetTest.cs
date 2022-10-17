using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using PetStoreAAA.Helpers;
using PetStoreAAA.Resources;
using PetStoreAAA.DataModels;

namespace PetStoreAAA.Tests
{
    [TestClass]
    public class PetTest : ApiBaseTests
    {
        private static List<PetModel> userCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task DemoGetPet()
        {
            //Arrange
            var demoGetRequest = new RestRequest(Endpoints.GetPetByPetId(PetDetails.Id));
            userCleanUpList.Add(PetDetails);

            //Act
            var demoResponse = await RestClient.ExecuteGetAsync<PetModel>(demoGetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, demoResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(PetDetails.Id, demoResponse.Data.Id, "Pet ID did not match.");
            Assert.AreEqual(PetDetails.Name, demoResponse.Data.Name, "Pet name did not match.");
            Assert.AreEqual(PetDetails.Status, demoResponse.Data.Status, "Pet status did not match.");
            Assert.AreEqual(PetDetails.PhotoUrls[0], demoResponse.Data.PhotoUrls[0], "Pet photo URL did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Id, demoResponse.Data.Tags[0].Id, "Pet tag ID did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Name, demoResponse.Data.Tags[0].Name, "Pet tag name did not match.");
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in userCleanUpList)
            {
                var deleteUserRequest = new RestRequest(Endpoints.GetPetByPetId(data.Id));
                var deleteUserResponse = await RestClient.DeleteAsync(deleteUserRequest);
            }
        }
    }
}
