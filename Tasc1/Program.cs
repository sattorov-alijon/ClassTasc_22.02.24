var teach1=new Teacher("Alijon","  Programming",10);
System.Console.WriteLine(teach1.Teach());
System.Console.WriteLine(teach1.GetExperience());


var teach2=new Teacher("Mansur","  Math");
teach2.SetExperience(5);
System.Console.WriteLine(teach2.Teach());
System.Console.WriteLine(teach2.GetExperience());

var teach3=new Teacher();
teach3.SetExperience(20);
System.Console.WriteLine(teach3.Teach());
System.Console.WriteLine(teach3.GetExperience());