using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace WebApplication1.Services
{
    /// <summary>
    /// Description résumée de Fibo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Fibo : System.Web.Services.WebService
    {

        [WebMethod (Description = "Get Fibonacci sequence result of the n input")]
        public string Fibonacci(int n)
        {
            Thread.Sleep(2000);
            if (n < 1 || n > 100)
            {
                return "-1";
            }
            else
            {
                if (n == 1 || n == 2) return "1";
                else
                {
                    BigInteger start = 1;
                    BigInteger next = 1;
                    for (int i = 0; i < (n - 2); i++)
                    {
                        BigInteger tempNbr = start;
                        start += next;
                        next = tempNbr;
                    }
                    return start.ToString();
                }
            }
        }
    }
}
