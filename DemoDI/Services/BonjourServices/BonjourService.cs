namespace DemoDI.Services.BonjourServices;

public class BonjourService : IBonjourService
{
    //ORM : EF core
    //SDK Fournisseur
    //SDK security

    public string DireBonjour(string nom)
    {
        return $"Bonjour {nom}";
    }
}
