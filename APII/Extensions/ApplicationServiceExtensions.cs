using APII.Data;
using APII.Interfaces;
using APII.Services;
using Microsoft.EntityFrameworkCore;

namespace APII.Extensions

{

public static class  ApplicationServiceExtensions{


public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
IConfiguration config){

services.AddDbContext<DataContext> (opt =>
{
opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
});
services.AddCors();
services.AddScoped<ITokenService, TokenService>();
services.AddScoped<IUserRepository, UserRepository>();
services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

return services;

}



}






}