
// static void strek()
// {
//   Console.WriteLine("----------------------------------------------------------");
// }

// static void fel()
// {
//   int fel = 0;

//   while (fel == 0)
//   {
//     string num = Console.ReadLine();
//     bool success = int.TryParse(num, out fel);
//     if (success == false)
//     {
//       Console.WriteLine("Du måste skriva en siffra!");
//     }
//   }

// }
// Console.WriteLine("välkommen till Mode-tävlingen!");
// Console.WriteLine("infomation:");
// Console.WriteLine("Du kommer få välja olika typer av plagg som sen kommer bli en jätte snygg outfit ");
// Console.WriteLine("Som sen kommer det vara en jury som kommer bedömma, du kommer göra mot slumpmässiga personer");

// strek();

// Console.WriteLine("Steg 1:");
// Console.WriteLine("De första man bör göra är att välja en topp");


// Console.WriteLine("Du kan välja mellan:");
// // String [] toppar = [ "gucci tröja", "Glittrig balenciaga topp", "svättig tröja" , "köttklänning"];

// for (int i = 0; i < 1; i++)
// {

//   Console.WriteLine("1) gucci topp");
//   Console.WriteLine("2) balenciaga skjorta");
//   Console.WriteLine("3) H&M t-shirt");
//   Console.WriteLine("4) svettig tröja");
//   Console.WriteLine("5) inget(; ");

// }

// Console.WriteLine("vilket plagg väljer du");
// fel();


Random generator = new Random();

int poäng = 0;
string svar = Console.ReadLine();

{

  poäng = Random.Shared.Next(10);

}

// Console.WriteLine("Nästa steg! Nu är de dags att välja underdel");
// Console.WriteLine("Du har dessa att välja på:");

// strek();


// Console.WriteLine("1) baggy jeans");
// Console.WriteLine("2) mjukis byxor");
// Console.WriteLine("3)skinny jeans");
// Console.WriteLine("4) kjol med prickar");
// Console.WriteLine("5) speedos");

// Console.WriteLine("vilket plagg väljer du");

// int poäng2 = 0;

// fel();

// string svar2 = Console.ReadLine();

// {
//   poäng2 = Random.Shared.Next(10);

// }

// int Totpoäng = poäng * poäng2;
// Console.WriteLine($"Din totala poäng är just nu {Totpoäng}");
// Console.ReadLine();

// Console.ReadLine();


// Random spelare

int poängSpelare0= 0;

{

  poängSpelare0 = Random.Shared.Next(10);

}
int poängSpelare1= 0;

{

  poängSpelare1 = Random.Shared.Next(10);

}
int poängSpelare2= 0;

{

  poängSpelare2 = Random.Shared.Next(10);

}
int poängSpelare3= 0;

{

  poängSpelare3 = Random.Shared.Next(10);

}
int poängSpelare4= 0;

{

  poängSpelare4 = Random.Shared.Next(10);

}


// Andra delen av poäng


int poängSpelare02= 0;

{

  poängSpelare02 = Random.Shared.Next(10);

}
int poängSpelare12= 0;

{

  poängSpelare12 = Random.Shared.Next(10);

}
int poängSpelare22= 0;

{

  poängSpelare22 = Random.Shared.Next(10);

}
int poängSpelare32= 0;

{

  poängSpelare32 = Random.Shared.Next(10);

}


int RandomTOTAL02 = poängSpelare0 * poängSpelare0;
int RandomTOTAL12 = poängSpelare1 * poängSpelare12;
int RandomTOTAL22 = poängSpelare2* poängSpelare22;
int RandomTOTAL32= poängSpelare3 * poängSpelare32;

string[] names = ["Benny", "Kalle", "Kenny", "Amanda"];

for (int i = 0; i <1; i++)
{

  Console.WriteLine( names [0] +  $" fick {RandomTOTAL02}" );
  Console.WriteLine( names [1] +  $" fick {RandomTOTAL12}" );
  Console.WriteLine( names [2] +  $" fick {RandomTOTAL22}" );
  Console.WriteLine( names [3] +  $" fick {RandomTOTAL32}" );
 
}

Console.ReadLine();

