using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NoDesignPatternsBetaalmethode
{

    internal class BetaalProcessor
    {
       IBetaalMethode betaalMethode;
        
         public BetaalProcessor(IBetaalMethode betaalMethode )
        { 
         this.betaalMethode = betaalMethode; 
        }

        public void VerwerkBetaling(decimal bedrag)
        {
            betaalMethode.VoerBetalingUit(bedrag);
        }

}
}
