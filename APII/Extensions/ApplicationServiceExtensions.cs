using APII.Data;
using APII.Helpers;
using APII.Interfaces;
using APII.Services;
using APII.SignalR;
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
services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
services.AddScoped<IPhotoService, PhotoService>();
services.AddScoped<LogUserActivity>();
services.AddScoped<ILikesRepository,  LikesRepository>();
services.AddScoped<IMessageRepository, MessageRepository>();
services.AddSignalR();
services.AddSingleton<PresenceTracker>();
return services;

}



}






}