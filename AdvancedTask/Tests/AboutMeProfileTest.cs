

namespace ProjectMars.Tests
{
    [TestFixture]
    public class AboutMeProfileTest : BaseClass
    {
        private readonly AboutMeProfilePage aboutMeProfilePage;
        private AboutMeProfile _AboutMeDataToCleanup;

        public AboutMeProfileTest()
        {
            aboutMeProfilePage = new AboutMeProfilePage();
        }

        //[SetUp]
        //public void CleanUpBeforeTestStarts()
        //{
        //    //aboutMeProfilePage.CleaupAllLanguageDataBeforeStartTest();
        //}

        //[TearDown]
        //public void Cleanup()
        //{
        //    // Cleanup only the data that was affected by the current test
        //    if (_LanguageToCleanup != null)
        //    {
        //        languagePage.CleanUpAddedLanguageAfterTest(_LanguageToCleanup);
        //        _LanguageToCleanup = null; // Reset for the next test
        //    }
        //}


        [Test]
        [TestCaseSource(typeof(AboutMeProfileTestData), nameof(AboutMeProfileTestData.EditProfileName))]
        public void SuccessfullyEditProfileName(AboutMeProfile editProfileName)
        {
            aboutMeProfilePage.SuccessfullyEditProfileName(editProfileName);

            aboutMeProfilePage.ViewProfileName(editProfileName);

           
        }

        [Test]
        [TestCaseSource(typeof(AboutMeProfileTestData), nameof(AboutMeProfileTestData.EditProfileName))]
        public void CannotBeAbleToEditProfileNameWithoutFirstName(AboutMeProfile editProfileName)
        {
            aboutMeProfilePage.CannotBeAbleToEditProfileNameWithoutAddingFirstName(editProfileName);

            aboutMeProfilePage.ViewProfileName(editProfileName);

          
        }
    }
}

