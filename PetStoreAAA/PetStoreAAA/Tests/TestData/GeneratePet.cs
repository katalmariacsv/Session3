using System;
using System.Collections.Generic;
using System.Text;
using PetStoreAAA.DataModels;

namespace PetStoreAAA.Tests.TestData
{
    public class GeneratePet
    {
        public static PetModel petModel()
        {
            return new PetModel
            {
                Id = 987,
                Name = "Jappy",
                Status = "Available",
                PhotoUrls = new string[] { "wow" },
                Category = new CategoryModel()
                {
                    Id = 1,
                    Name = "Dog Category"
                },
                Tags = new List<TagsModel> { 
                    new TagsModel()
                    {
                        Id=1,
                        Name="Dog Tag"
                    }
                }
            };
        }
    }
}
