using APII.Data;
using APII.Interfaces;
using APII.Services;
using Microsoft.EntityFrameworkCore;

namespace APII.Extensions

{

public static class  ApplicationServiceExtensions{


public static IServiceCollection AddApplicationServices(this IServiceCollection sevices, 
IConfiguration config){

sevices.AddDbContext<DataContext> (opt =>
{
opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
});
sevices.AddCors();
sevices.AddScoped<ITokenService, TokenService>();


return sevices;

}



}






}