namespace Tasc3;


public class Doctor
{
    string _fullName;
    string _specialty;
    int _experience;
    public string TreatPatient(string patientName)
    {
       return $"{_fullName},  {_specialty} , бемореро бо номи {patientName} табобат мекунад";
    }

    public string PerformMedicalExamination(string patientName)
    {
       return $"{_fullName} , барои бемор бо номи {patientName} муоинаи тиббиро анҷом медиҳад";
    }

    
    public string PrescribeMedication(string patientName, string medication)
    {
       return $"{_fullName} ,  {medication}-ро ба беморе бо номи {patientName} таъин мекунад";
    }

    public void SetExperience(int years)
    {
        _experience=years;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public Doctor()
    {
    }
     public Doctor(string name,string specialty)
    {
        _fullName=name;
        _specialty=specialty;
        
    }
    public Doctor(string name, string specialty, int experience)
    {
     _fullName=name;
     _specialty=specialty;
     _experience=experience;
    }
}