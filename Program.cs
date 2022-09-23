
string Path = "../../../addresses.csv";
List<Address> addresses = new List<Address>();
StreamReader? file = null;

file = File.OpenText(Path);

file.ReadLine();

while (!file.EndOfStream)
{
    string? Line = file.ReadLine();
    string[] singlePartLine = Line.Split(",");

    try
    {


        //if (singlePartLine.Length != 6 )
        //{
        //    Console.WriteLine("il formato non è correto");
        //    continue;
        //}
        string name = singlePartLine[0];
        string surname = singlePartLine[1];
        string street = singlePartLine[2];
        string city = singlePartLine[3];
        string province = singlePartLine[4];
        string zipCode = singlePartLine[5];


        Address address = new Address(name, surname, street, city, province, zipCode);
        addresses.Add(address);
        //addresses.Add(new Address(name, surname, street, city, province, zipCode));
        Console.WriteLine(address);
    }


    catch (Exception e)
    {
        Console.WriteLine("---ERROR---- ");
        Console.WriteLine(Line);
        Console.WriteLine("-------");
    }

    //addresses.ForEach(Console.WriteLine);
}
file.Close();