using System;

public interface IBetaalMethode  
{
    private string email;

    void VoerBetalingUit(decimal bedrag);
}
