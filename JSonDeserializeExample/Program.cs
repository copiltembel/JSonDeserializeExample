using DeserializeDb.DataAccess.DataSet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            var profiles = GetProfiles();
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All
            };
            var serializedProfiles = JsonConvert.SerializeObject(profiles, Formatting.None,
                        settings);
            var deserializedProfiles = JsonConvert.DeserializeObject<List<Profile>>(serializedProfiles, settings);
        }

        public static List<Profile> GetProfiles()
        {
            var profile = new Profile()
            {
                Birthday = DateTime.Now,
                CanBeRecommended = true,
                ProfileId = Guid.NewGuid()
            };
            var locations = new List<Location>();
            locations.Add(new Location()
            {
                Address = "Here",
                City = "There",
                LocationId = Guid.NewGuid(),
                Profile = profile
            });

            return new List<Profile>() { profile };
        }
    }
}
