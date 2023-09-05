using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Especialidad { get; set; }
        public Doctor(string name, string id, string especialidad)
            
        {
            this.Name = name;
            this.Id = id;
            this.Especialidad = especialidad;

            ValidateDoctor(this);
        }
        public static string ValidateDoctor (Doctor doctor)
        {  
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(doctor.Name))
            {
                stringBuilder.Append("Unable to create doctor, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Id))
            {
                stringBuilder.Append("Unable to create doctor, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Especialidad))
            {
                stringBuilder.Append("Unable to create doctor, 'especialidad' is required\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Doctor created");
            }

            return stringBuilder.ToString();
        }
    }
}