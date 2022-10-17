using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using PetStoreAAA.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PetStoreAAA.Tests
{
    public class ApiBaseTests
    {
        public RestClient RestClient { get; set; }

        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
