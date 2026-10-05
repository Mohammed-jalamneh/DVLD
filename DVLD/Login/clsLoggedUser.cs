using DVLD_Business;

namespace DVLD
{
    public static class clsLoggedUser
    {
        public static clsUsersB CurrentUser { get;  set; }

        public static bool SetCurrentUser(string userName)
        {
            CurrentUser = clsUsersB.Find(userName);

            return CurrentUser != null;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}