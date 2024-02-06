using Business.Concrete;
using Entities.Concrete;
class Program
{
    static void Main(string[] args)
    {

        string[] sehirler = { "Adana", "Ankara", "Mersin" };

        foreach (string sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        List<string> list = new List<string> { "Ankara", "İstanbul", "İzmir" };

        Citizen citizen = new Citizen();

        citizen.FirstName = "Kaan";
        citizen.LastName = "Karakuş";
        citizen.DateOfBirthYear = 2002;
        citizen.NationalIdentity = 42432342;

        CitizenManager citizenManager = new CitizenManager();

        PttManager pttManager = new PttManager(citizenManager);

        pttManager.GiveMask(citizen);
    }
}


