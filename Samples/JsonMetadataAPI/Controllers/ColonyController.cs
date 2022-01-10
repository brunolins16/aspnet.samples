namespace JsonMetadataAPI.Controllers;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


[ApiController]
[Route("[controller]")]
public class ColonyController : Controller
{

    [HttpPost]
    public Task<int> Create([FromBody] ColonyToAddDto colonyToAddDto)
    {
        return Task.FromResult(0);
    }
}

public class ColonyToAddDto
{
    [Required]
    [StringLength(300, MinimumLength = 3)]
    [JsonPropertyName("bar")]
    [JsonProperty("barsoft")]
    public string Name { get; set; }

    [Range(1, 99999)]
    public int PostalCode { get; set; }

    [Range(1, double.PositiveInfinity)]
    public int MunicipalityId { get; set; }

    [Required]
    public InnerClass SubClass { get; set; }

    public class InnerClass
    {
        [Range(1, 10)]
        [JsonPropertyName("number")]
        [JsonProperty("numbersof")]
        public int Test1 { get; set; }

    }
}
