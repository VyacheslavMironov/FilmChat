using FilmChat.Domain.DTO.Users;

namespace FilmChat.Services.Users
{
	interface IUserCreate
	{
		public void CreateRquest();
	}

	public class UserCreate : IUserCreate
	{
		public void CreateRquest() { return; }
	}
}