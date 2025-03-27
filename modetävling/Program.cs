
static void strek()
{
  Console.WriteLine("---------");
}


Console.WriteLine("välkommen till Mode-tävlingen!");
Console.WriteLine("infomation:");
Console.WriteLine("Du kommer få välja olika typer av plagg som sen kommer bli en jätte snygg outfit ");
Console.WriteLine("Som sen kommer det vara en jury som kommer bedömma, du kommer göra mot slumpmässiga personer");

strek();

Console.WriteLine("Steg 1:");
Console.WriteLine("De första man bör göra är att välja en topp");


Console.WriteLine("Du kan välja mellan:");
// String [] toppar = [ "gucci tröja", "Glittrig balenciaga topp", "svättig tröja" , "köttklänning"];

for (int i = 0; i < 1; i++)
{
  Console.WriteLine("1) gucci topp");
  Console.WriteLine("2) balenciaga skjorta");
  Console.WriteLine("3) H&M t-shirt");
  Console.WriteLine("4) svettig tröja");
  Console.WriteLine("5) inget(; ");


}

Console.WriteLine("vilket plagg väljer du");
string whatToChoose = Console.ReadLine();
while (whatToChoose != "1" && whatToChoose != "2" && whatToChoose != "3" && whatToChoose != "4" && whatToChoose != "5") ;
{
  whatToChoose = Console.ReadLine();
}


Random generator = new Random();

int poäng = 0;

if (whatToChoose == "1")
{

  poäng = Random.Shared.Next(10);
}
else if (whatToChoose == "2")
{
  poäng = Random.Shared.Next(10);
}
else if (whatToChoose == "3")
{
  poäng =Random.Shared.Next(10);
}
else if (whatToChoose == "4")
{
  poäng = Random.Shared.Next(10);
}
else if (whatToChoose == "5")
{
  poäng = Random.Shared.Next(10);
}


Console.Clear();


Console.WriteLine("Nästa steg! Nu är de dags att välja underdel");
Console.WriteLine("Du har dessa att välja på:");

strek(); 
















Console.ReadLine();