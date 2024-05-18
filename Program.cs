using efcorejoin.Infra;
using efcorejoin.Repository;
using efcorejoin.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Efcoredb>();
builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerRepo,CustomerRepo>();
builder.Services.AddScoped<IOrderRepo,OrderRepo>();
builder.Services.AddScoped<IPaymentRepo,PaymentRepo>();
builder.Services.AddScoped<ICustomerServices,CustomerServices>();
builder.Services.AddScoped<IOrderServices,OrderServices>();
builder.Services.AddScoped<IPaymentServices,PaymentServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();

