using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAAA.Resources
{
    public class Endpoints
    {
        //Base URL
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetPetByPetId(long petId) => $"{baseURL}/pet/{petId}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeletePetByPetId(long petId) => $"{baseURL}/pet/{petId}";
    }
}
