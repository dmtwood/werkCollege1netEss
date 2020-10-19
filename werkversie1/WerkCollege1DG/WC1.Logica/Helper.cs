using System;
using System.Collections.Generic;
using System.Text;

namespace WerkCollege1DG.WC1.Logica
{
    class Helper
    {
        /// <summary>
        /// Wisselt twee integers die als reference ingelezen worden.
        /// </summary>
        /// <param name="a">Bevat initieel de eerste waarde, na wissel de initiële tweede waarde. </param>
        /// <param name="b">Bevat initieel de tweede waarde, na wissel de initiële eerste waarde. </param>
        public static void Wissel(ref int a, ref int b)
        {
            int ezelsbrug = a;
            a = b;
            b = ezelsbrug;
        }



    }
}
