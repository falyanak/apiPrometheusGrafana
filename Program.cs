using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:5000");

var app = builder.Build();

// Middleware Prometheus
app.UseHttpMetrics();

// Expose /metrics
app.MapMetrics();

app.MapGet("/", () => "Hello Prometheus!");

app.Run();

