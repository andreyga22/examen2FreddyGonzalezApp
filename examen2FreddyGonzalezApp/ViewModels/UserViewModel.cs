using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen2FreddyGonzalezApp.Models;

namespace examen2FreddyGonzalezApp.ViewModels {
    public class UserViewModel : BaseViewModel {

        public User MyUser { get; set; }

        public UserViewModel() {
            MyUser = new User();
        }

        public async Task<User> GetAllUserAsync(string userName, string password) {
            try {
                List<User>? roles = new List<User>();
                roles = await MyUser.GetAllUserAsync();
                if (roles == null) {
                    return null;
                } else {
                   foreach (var item in roles)
                    {
                        if (item.UserName == userName && item.UserPassword == password) {       
                            return item;
                        }
                    }
                    return null;
                }

            } catch (Exception) {

                throw;
            }
        }
    }
}
