using System;

public class PaypalBetaling : IBetaalMethode
{
    private string email;

    public PaypalBetaling(string email)
	{
		this.email = email;
	}

	public void VoerBetalingUit(decimal bedrag)
    {
        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Ongeldig e-mailadres.");
        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd met PayPal: {email}");
    }
}
