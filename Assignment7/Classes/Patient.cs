using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7.Classes
{
    internal class Patient(int id, string fullName, string PhoneNumber, string MedicalHistory)
    {
        public int Id { get; } = id;
        public string FullName { get; }=fullName;
        public string PhoneNumber { get; }=PhoneNumber;
        public string MedicalHistory { get; }=MedicalHistory;

        public override string ToString()
        {
            return $"Id:{Id} :: FullName:{FullName} :: PhoneNumber:{ PhoneNumber} :: MedicalHistory:{MedicalHistory}";
        }
    }
    record PatientDto(int Id, string FullName, String PhoneNumber);

    
}
