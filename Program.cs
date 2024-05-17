namespace KataTutoCorrection
{
    //Appelle des bundle necessaire dans le code
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public class program
    {

        public static void Main(String[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Ajout des bundle et de service
            builder.Services.AddDbContext<KataDbContext>(opt => opt.UseInMemoryDatabase("KataTuto"));
            builder.Services.AddAuthorization();
            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
                .AddEntityFrameworkStores<KataDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();//Ajout des autorisations

            app.MapControllers(); 
            
            app.MapIdentityApi<IdentityUser>();



            app.Run();
        }

    }

}