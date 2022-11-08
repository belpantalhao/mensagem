using System;
using System.Collections.Generic;
using System.Text;


using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Appmensagens.Model;

namespace AppMensagens'.Services
{
    public class DataServices
    {
        public static async Task<Conselho> GetConselho(string conselho)
        {


            string queryString = "https://api.adviceslip.com/advice" + conselho;

            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

        }
    }
}
