using APII.DTOs;
using APII.Entities;
using APII.Helpers;

namespace APII.Interfaces

{

public interface IUserRepository{

void Update(AppUser user);
Task<bool> SaveAllAsync();

Task<IEnumerable<AppUser>> GetUsersAsync();

Task<AppUser> GetUserByIdAsync(int id);

Task<AppUser> GetUserByUsernameAsync(string username); 

Task<PagedList<MemberDto>> GetMembersAync(UserParams userParams);

Task <MemberDto> GetMemberAsync(string username);

}







}