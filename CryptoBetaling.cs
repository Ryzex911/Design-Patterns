using System;

public class CryptoBetaling : IBetaalMethode
{

	private string walletAdres;

	public CryptoBetaling(string walletAdres)
	{
		this.walletAdres = walletAdres;
	}

	public void VoerBetalingUit(decimal bedrag)
	{
        if (walletAdres.Length < 10)
            throw new ArgumentException(
                "Ongeldig wallet-adres. Moet minstens 10 tekens lang zijn.");

        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd met cryptocurrency-wallet: {walletAdres}");
    }
}
