using Tasc4;

var act1=new Actor("Alijon",22,"mard");
act1.AddMovie("Iron Man");
act1.AddMovie("Avengers: Endgame");
act1.AddMovie("Iron Man 2");
act1.AddMovie("Sherlock Holmes");
act1.AddMovie("Iron Man 3");
act1.AddMovie("Avengers: Final");


System.Console.WriteLine(act1.GetInfo());

System.Console.WriteLine(act1.GetInfoMovie("Sattorov","Alijon","S"));
int i=1;
foreach (var moviesPlayed in act1.GetMoviePlayed())
{
    System.Console.WriteLine(i + "." + moviesPlayed);
    i ++;
}
