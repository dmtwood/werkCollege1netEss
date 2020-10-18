using System;
using System.Text;

namespace WE01.Logica
{
    public static class Helper
    {
        /// <summary>
        /// Wisselt twee integer waarden om. Integers worden als reference doorgegeven i.p.v. als value.
        /// </summary>
        /// <param name="a">Eerste waarde, zal na wissel de waarde van b bevatten..</param>
        /// <param name="b">Tweede waarde, zal na wissel de waarde van a bevatten.</param>
        public static void Wissel(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Zet een in om naar een camelCase woord.
        /// </summary>
        /// <param name="invoer">Om te zetten zin. Methode gaat er van uit dat deze niet leeg is en niet enkel spaties bevat.</param>
        /// <returns>Invoer omgezet naar camelCase woord.</returns>
        public static string ZinNaarCamelCase(string invoer)
        {
            /* invoer opkuisen en opdelen. In volgorde gebeurt hier:
             *   1 - Spaties voor en achteraan de zin worden weggehaalt met Trim()
             *   2 - Zin wordt omgezet naar kleine letters
             *   3 - Zin wordt opgesplits in array van strings (op basis van de spaties in de zin)
             *   
             *   Opmerking: elke van deze methoden maakt een kopie van de string.
             *   In volgende werkcolleges gaan we LINQ zien, dan ken je dit efficiënter oplossen met een query.
             */
            string[] woorden = invoer.Trim().ToLowerInvariant().Split(' ');
           
            // gebruik van stringbuilder voor optimalisatie tijdens for-lus
            var uitvoer = new StringBuilder();
            // eerste woord is sowieso lowercase, dus toevoegen aan uitvoer
            uitvoer.Append(woorden[0]);

            // alle volgende woorden aflopen
            for (int i = 1; i < woorden.Length; i++)
            {
                // huidige woord in de zin ophalen
                var woord = woorden[i];               
                if(!string.IsNullOrWhiteSpace(woord))
                {
                    // eerste letter hoofdletter maken en toevoegen aan uitvoer
                    uitvoer.Append(char.ToUpperInvariant(woord[0]) + woord.Substring(1));
                }
            }

            return uitvoer.ToString();
        }
    }
}
