
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
String [] toppar = [ "gucci tröja", "Glittrig balenciaga topp", "svättig tröja" , "köttklänning"];

for (int i = 0; i < toppar.Length; i++)
{
    Console.WriteLine(toppar[0]);
    Console.WriteLine(toppar[1]);
    Console.WriteLine(toppar[2]);
    Console.WriteLine(toppar[3]);
}






















Console.ReadLine();