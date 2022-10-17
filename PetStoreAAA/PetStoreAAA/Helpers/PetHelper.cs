using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using PetStoreAAA.DataModels;
using PetStoreAAA.Tests.TestData;
using PetStoreAAA.Resources;
using System.Threading.Tasks;

namespace PetStoreAAA.Helpers
{
    /// <summary>
    /// Demo class containing all methods for pet
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new pet
        /// </summary>
        ///
    
        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newpetData = GeneratePet.petModel();
            var postRequest = new RestRequest(Endpoints.PostPet());
    
            //Send Post Request to add new pet
            postRequest.AddJsonBody(newpetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);
    
            var createdPetData = newpetData;
            return createdPetData;
        }
    }
}
