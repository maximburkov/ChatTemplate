using ChatService.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();

// TODO: uncomment code
//builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
//{
//    builder.AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader();
//}));

var app = builder.Build();

// TODO: Remove it
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

// TODO: uncomment it
//app.UseRouting();
//app.UseGrpcWeb();
//app.UseCors();

//app.UseEndpoints(c =>
//{
//    c.MapGrpcService<MessengerService>().EnableGrpcWeb().RequireCors("AllowAll");
//});

app.Run();
