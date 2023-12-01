using Microsoft.AspNetCore.Identity;

namespace APII.Entities

{
public class AppRole : IdentityRole<int>
{

public ICollection<AppUserRole> UserRoles { get; set; }




}

}