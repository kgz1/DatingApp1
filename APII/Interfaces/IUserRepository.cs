using APII.DTOs;
using APII.Entities;

namespace APII.Interfaces

{

public interface IUserRepository{

void Update(AppUser user);
Task<bool> SaveAllAsync();

Task<IEnumerable<AppUser>> GetUsersAsync();

Task<AppUser> GetUserByIdAsync(int id);

Task<AppUser> GetUserByUsernameAsync(string username); 

Task<IEnumerable<MemberDto>> GetMembersAync();

Task <MemberDto> GetMemberAsync(string username);

}







}