using APII.DTOs;
using APII.Entities;
using APII.Helpers;

namespace APII.Interfaces

{
public interface IMessageRepository
{
void AddMessage(Message message);
void DeleteMessage(Message message);
Task<Message> GetMessage(int id);
Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientUsername);
Task<bool> SaveAllAsync();

}

}