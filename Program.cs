
string Path = "../../../addresses.csv";
List<Address> addresses = new List<Address>();
StreamReader? file = null;


try
{
    file = File.OpenText(Path);
    file.ReadLine();

    while (!file.EndOfStream)
    {
        string? Line = file.ReadLine();
        string[] singlePartLine = Line.Split(",");

        if( singlePartLine.Length != 6 && singlePartLine.Length <= 6 )
        {
            continue;
        }
        string name = singlePartLine[0];
        string surname = singlePartLine[1];
        string street = singlePartLine[2];
        string city = singlePartLine[3];
        string? province = singlePartLine[4];
        string zipCode = singlePartLine[5];

        addresses.Add(new Address(name, surname, street, city, province, zipCode));
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("File non trovato");
}
finally
{
    if (file != null)
    {
        foreach (Address address in addresses)
        {
            Console.WriteLine(address.ToString());
        }

    }
}