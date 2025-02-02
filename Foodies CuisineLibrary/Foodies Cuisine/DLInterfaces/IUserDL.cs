using Foodies_Cuisine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DLInterfaces
{
    public interface IUserDL
    {
        bool AddUser(User user);
        List<User> RetrieveUsers();
        User SignIn(User user);
    }
}
