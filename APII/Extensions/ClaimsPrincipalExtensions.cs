using System.Security.Claims;

namespace APII.Extensions

{

public static class ClaimsPrincipalExtensions{

public static string GetUsername(this ClaimsPrincipal user){

return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

}



}





}