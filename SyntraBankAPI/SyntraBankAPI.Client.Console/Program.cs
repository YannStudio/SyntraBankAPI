using Newtonsoft.Json;
using SyntraBankAPI.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SyntraBankAPI.Client.Console
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static string AccountEndpoint = "https://localhost:44364/api/v1/Account";

        static async Task Main(string[] args)
        {
            Account NewAccount = new Account();

            System.Console.WriteLine("Geef uw balans in?");
            NewAccount.Balance = float.Parse(System.Console.ReadLine());

            NewAccount.AccountNumber = RandomBankAccountNumber();
            NewAccount.ClientId = Guid.NewGuid();

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;

            await CreateNewAccount(NewAccount);
                       

        }

        // Create random bank account number

        static string RandomBankAccountNumber()
        {
            string result = "BE";
            Random r = new Random();
            int number;

            for (int i = 0; i < 14; i++)
            {
                number = r.Next(10);
                result = result + number.ToString();
            }

            return result;
        }

        // Create new bank account
        static async Task CreateNewAccount(Account account)
        {
            var ClientMessage = ConvertJsonToStringContent(account);

            var result = await client.PostAsync(AccountEndpoint, ClientMessage);
        }

        //Method to convert any object string content
        static StringContent ConvertJsonToStringContent(Object item)
        {

            var testObject = JsonConvert.SerializeObject(item);

            var stringContent = new StringContent(testObject, System.Text.Encoding.UTF8, "application/json");

            return stringContent;

        }


    }
}
