using System;
using Newtonsoft.Json;

namespace CallingExternalApi
{
    public class Users
    {
        public string GetUsers()
        {
            UsersRepository user = new UsersRepository();
            string usersList = user.GetUsers();

            Users [] users = JsonConvert.DeserializeObject<Users[]>(usersList);
            return users[0].Name;
        }
    }
}