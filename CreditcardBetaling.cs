using System;

public class CreditcardBetaling : IBetaalMethode
{

    private string kaartNummer;

    public CreditcardBetaling(string kaartNummer)
	{

        this.kaartNummer = kaartNummer;
    }

    public void VoerBetalingUit(decimal bedrag)
    {

        if (kaartNummer.Length != 16)
            throw new ArgumentException(
                "Ongeldig kaartnummer. Moet 16 cijfers bevatten.");

        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd met creditcard: {kaartNummer}");

    }
}
