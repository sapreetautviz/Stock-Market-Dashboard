using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Stock_Market_Dashboard.Database;
using Stock_Market_Dashboard.DTOs;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Stock_Market_Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;


        // Using rapidapi platform
        private const string RapidApiKey = "5aace0f731msh262aa05bd1d8952p1a1f56jsn53e9371ad9c0";
        private const string ApiHost = "indian-stock-exchange-api1.p.rapidapi.com";
        private const string BaseUrl = "https://indian-stock-exchange-api1.p.rapidapi.com/stock_price/";

        public StockController(ApplicationDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        [HttpGet("Stocks-info")]

        public async Task<IActionResult> GetStockPrice(string stocks)
        {
            var requestUrl = $"{BaseUrl}?symbol={stocks}";

            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Add("x-rapidapi-host", ApiHost);
            request.Headers.Add("x-rapidapi-key", RapidApiKey);

            try
            {
                var response = await _httpClient.SendAsync(request);

                if(!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
                }

                var result = await response.Content.ReadAsStringAsync();
                var stoksData = JsonConvert.DeserializeObject<StockPriceDto>(result);
                return Ok(stoksData);

            }
            catch(Exception er)
            {
                return StatusCode(500, $"Error: {er.Message}");
            }

        }

    }
}
