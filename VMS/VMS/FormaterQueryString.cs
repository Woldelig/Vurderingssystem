﻿using System;
using System.Collections.Generic;

namespace VMS
{
    public static class FormaterQueryString
    {
        /*
         * Denne klassen har som formål og formatere query strings.
         * Man må formatere de fordi for eksempel mellomrom i url blir tegnsatt
         * til %20 eller +. Derfor har denne klassen en Dictionary
         * som for eksempel bytter om tegnene %C3%A6 til æ. 
         * Dette er noe vi må gjøre for at  vi skal kunne sende korrekte database spørringer.
         */

        private static Dictionary<String, String> ugyldigeTegn = new Dictionary<string, string>()
        {
            {"?", String.Empty },
            {"%20", " " },
            {"+", " " },
            {"%C3%A5", "å" },
            {"%C3%85", "Å" },
            {"%C3%A6", "æ" },
            {"%C3%86", "Æ" },
            {"%C3%B8", "ø" },
            {"%C3%98", "Ø" }
        };

        public static String FormaterString(String streng)
        {
            /*
             * Her sjekkes hvert par opp mot tekststrengen.
             * Hvis en nøkkel matcher blir verdien byttet om mot verdien
             */

            foreach (KeyValuePair<String, String> byttOm in ugyldigeTegn)
            {
                streng = streng.Replace(byttOm.Key, byttOm.Value);
            }
            return streng;
        }

    }
}
