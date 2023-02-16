using project.Model;

var builder = WebApplication.CreateBuilder(args);

const string corsPolicy="ApiCORS";

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors((options)=>{
    options.AddPolicy(corsPolicy, policy=>{
        policy.WithOrigins("http://localhost:5220");
        policy.WithOrigins("http://localhost:3000");
    });
});

builder.Services.AddDbContext<DeltaContext>((options)=>{});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
