namespace HospitalManagement.Models
{
    public class RegistrationNumberGenerator
    {
        private int _registrationNumberCounter = 0;

        public string GenerateRegistrationNumber()
        {
            var currentYear = DateTime.Now.ToString("yy");
            var registrationNumber = $"HMS-{currentYear}-{++_registrationNumberCounter:0000}";
            return registrationNumber;
        }
    }
}
