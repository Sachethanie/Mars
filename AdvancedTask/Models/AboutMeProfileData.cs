using Newtonsoft.Json;

namespace ProjectMars.Models
{
    public class AboutMeProfileTestData
    {
        public static IEnumerable<TestCaseData> EditProfileName
        {
            get
            {
                var json = File.ReadAllText("Data\\EditProfileName.json");
                var data = JsonConvert.DeserializeObject<List<AboutMeProfile>>(json);

                foreach (var item in data)
                {
                    yield return new TestCaseData(item);
                }
            }
        }

        public static IEnumerable<TestCaseData> MandetoryFieldValidationOfAddProfileNameToAboutMeProfile
        {
            get
            {
                var json = File.ReadAllText("Data\\MandetoryFieldValidationOfAddProfileNameToAboutMeProfile.json");
                var data = JsonConvert.DeserializeObject<List<AboutMeProfile>>(json);

                foreach (var item in data)
                {
                    yield return new TestCaseData(item);
                }
            }
        }
    }
}
