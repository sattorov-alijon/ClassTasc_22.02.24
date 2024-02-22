using Tasc3;

var dt1=new Doctor("Farrukh","khirurg");
dt1.SetExperience(15);
System.Console.WriteLine("Tajribai kori: "+dt1.GetExperience());
System.Console.WriteLine(dt1.TreatPatient("Shahzod"));
System.Console.WriteLine(dt1.PerformMedicalExamination("Ikrom"));
System.Console.WriteLine(dt1.PrescribeMedication("Muhammad","Antibiotik"));
