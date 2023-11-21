using APII.DTOs;
using APII.Entities;
using APII.Helpers;

namespace APII.Interfaces

{
public interface ILikesRepository
{

Task<UserLike> GetUserLike(int sourceUserId, int targetUserId);

Task<AppUser> GetUserWithLikes(int userId);

Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);



}


}