using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlfaERP_CriarExcelPorConsultaApi
{
    public static class MeuProxy
    {
        public static string ChamarApiRD()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpc3MiOiJodHRwczovL2FwaS5yZC5zZXJ2aWNlcyIsInN1YiI6InkzZGNyWTMycE5OM1ZHbm1kM2JwM1BQNXBmT0QxMW1nMzVPYng2V0VHTU1AY2xpZW50cyIsImF1ZCI6Imh0dHBzOi8vYXBwLnJkc3RhdGlvbi5jb20uYnIvYXBpL3YyLyIsImFwcF9uYW1lIjoiQXBwV2VzbGV5QWxmYSIsImV4cCI6MTY2ODE2MzU5MCwiaWF0IjoxNjY4MDc3MTkwLCJzY29wZSI6IiJ9.B55xh_qO8Z_RoZAdmVkXvox8PrEX5J4m1xCrCKxymHruWKHJzBwi_na_SyC0aikxjoIBAVbmeJpgb5lmcHNUa3nR5M4s9BfKBrybvuJjD_3z8kWvbNXdlc1ha7ng_c3oyuJQ5jM_CURe8jXBZ9lEeDazg4NgQsMaFIH5SuKI2ygW7PxlzWH_edvWcVpfLoyy1pFYURd7JE9H-Bo6qlwglF-CkfHtDnTpPpTKtW0hcOfgpofMoxomXFaJO-sovxlVY4yFmDFeyUW4Cx4F2qWi5B85tYxxrKB1qzAKjlzniznOLTalWsER6CbspWd3xPwIJ1KpBLDGY9J7O_WQBS4SJA");

                string url = "https://api.rd.services/platform/contacts/email:contato@alfa.com.br";                
                var task = client.GetAsync(url);
                task.Wait();

                if (!task.Result.IsSuccessStatusCode)
                {
                    throw new Exception(task.Result.StatusCode.ToString());
                }

                var readTask = task.Result.Content.ReadAsStringAsync();
                readTask.Wait();
                return readTask.Result;
            }
        }
    }
}
