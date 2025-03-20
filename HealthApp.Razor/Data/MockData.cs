using HealthApp.Domain;

namespace HealthApp.Razor.Data
{
   
    public static class MockData
    {

        public static List<Patient> Patients()
        {
            return new List<Patient>
            {
                new Patient
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "John",
                    LastName = "Doe",
                  //  DateOfBirth = new DateTime(1980, 1, 1)
                }
            };
        }
    }
}
