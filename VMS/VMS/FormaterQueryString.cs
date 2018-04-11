using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS
{
    public class FormaterQueryString
    {
        Dictionary<String, String> ugyldigeTegn = new Dictionary<string, string>()
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

        public String FormaterString(String streng)
        {
            foreach (var keyValuePar in ugyldigeTegn)
            {
                streng.Replace(keyValuePar.Key, keyValuePar.Value);
            }
            return streng;
        }

    }
}