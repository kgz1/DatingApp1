using APII.Entities;
namespace APII.Interfaces

{

public interface ITokenService{

Task<string> CreateToken(AppUser user);

}




}