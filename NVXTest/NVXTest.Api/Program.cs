using NVXTest.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var wizardService = new WizardService();

app.MapPost("/Encrypt", async (string text) => await wizardService.Encrypt(text));
app.MapPost("/Decrypt", async (string text) => await wizardService.Decrypt(text));

app.UseSwagger();
app.UseSwaggerUI();

app.Run();