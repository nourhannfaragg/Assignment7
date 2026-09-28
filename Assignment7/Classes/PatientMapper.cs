using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7.Classes
{
    static class PatientMapper
    {
        public static PatientDto PatientModelToDto(Patient patient)
        {
            return new PatientDto(
                patient.Id,
                patient.FullName,
                patient.PhoneNumber);
        }
    }
}
