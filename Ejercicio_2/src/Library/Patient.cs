using System.Text;

namespace Library
{
    public class Patient
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set;} 
        public string Edad { get; set; }
        public Patient(string name, string id, string phoneNumber, string edad)
            
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Edad = edad;

            ValidatePatient(this);
        }

        public static string ValidatePatient (Patient patient)
        {  
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(patient.Name))
            {
                stringBuilder.Append("Unable to create patient, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                stringBuilder.Append("Unable to create patient, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                stringBuilder.Append("Unable to create patient, 'phone number' is required\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Patient created");
            }

            return stringBuilder.ToString();
        }
    }
}