using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
     

// Using the default naming policy (camelcase)
builder.Services.Configure<MvcOptions>(options => options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider()));

// Using an specific naming policy
builder.Services.Configure<MvcOptions>(options => options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider(new UpperCaseJsonNamingPolicy())));

//  NEWTONSOFT JSON
builder.Services.Configure<MvcOptions>(options => options.ModelMetadataDetailsProviders.Add(new NewtonsoftJsonValidationMetadataProvider()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
