using Azure.AI.TextAnalytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIH_Dashboard
{
    public class SentimentalAnalysis
    {
        public static Dictionary<SentimentType, string> UrlMap { get; } = new Dictionary<SentimentType, string>
        {
            {
                SentimentType.Toxic,
                "https://toxiccommentfunc.azurewebsites.net/api/ToxicServe?code=a3QYM13fo2dzVeWjY0rtvDSpQtE0jXCWO0zloa5D6gRivUS7VTlDDQ=="
            },
            {
                SentimentType.Insult,
                "https://toxiccommentfunc.azurewebsites.net/api/InsultServe?code=G1QY5wKPeLkcPrLSJR1jdEHr5gHobYwkMuHKR0YPBJFHI7w9N9SgKA=="
            }
            ,{
                SentimentType.Identity_Hate,
                "https://toxiccommentfunc.azurewebsites.net/api/HateIdentityServe?code=2K8VehKjaxH9HlZCjucUOZvl80rKhOw6EewHCzum1wCzygDXM3n8DA=="
            },
            {
                SentimentType.Obscene,
                "https://toxiccommentfunc.azurewebsites.net/api/ObsceneServe?code=W/OcZVo29ZlokVVYMqpwA2rEeRdfEDdmPtg8VN76zKy4eNDVW/785Q=="
            }
            ,{
                SentimentType.Severe_Toxic,
                "https://toxiccommentfunc.azurewebsites.net/api/SevereToxicServe?code=VHCigVIGZaoGwiWniRVm6lvS9XtB1cvqsTeEmyCYUWXNaK6QmLO0mA=="
            }
            ,{
                SentimentType.Overall_Toxicity,
                "https://toxiccommentfunc.azurewebsites.net/api/ToxicityServe?code=1Lh8wJ8CE9KFVlKCTRjuj5WnrvsSFcLx0T2UamtKEhLDjVWXOrEJag=="
            }
        };
        readonly string azureURL = "https://toxiccommentfunc.azurewebsites.net/api/SentimentAnalysis?code=1x7UkwYmWhAuGcHZFFWUg48wDqd0Rnn3cLUCyytmPqOL/eZS2OVcBw==";

        public async Task<DocumentSentiment> GetAzureSentiment(string comment)
        {
            SentimentInput input = new SentimentInput() { commentText = comment };
            var res = await Client.PostAsync(azureURL, JsonContent.Create(input));

            var response = await res.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<DocumentSentiment>(response);
            return model;
        }
        public async static Task<ModelOutput> GetSentiment(string comment,SentimentType type)
        {
            SentimentInput input = new SentimentInput() { commentText = comment };
            var res = await Client.PostAsync(UrlMap[type], JsonContent.Create(input));

            var response = await res.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<ModelOutput>(response);
            return model;
        }
        public static HttpClient Client { get; set; } = new HttpClient();
        public enum SentimentType
        {
            Toxic,
            Insult,
            Identity_Hate,
            Obscene,
            Severe_Toxic,
            Overall_Toxicity
        }
        public class SentimentInput
        {
            public string commentText { get; set; }
        }
        public class ModelOutput
        {
            // ColumnName attribute is used to change the column name from
            // its default value, which is the name of the field.
            public Single Prediction { get; set; }
            public float[] Score { get; set; }
        }
    }
}
