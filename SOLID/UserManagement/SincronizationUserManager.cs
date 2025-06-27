namespace ConsoleApp1.SOLID.UserManagement
{
    public class SincronizationUserManager : SimpleUserManager
    {
        private readonly ICRMSincronizationService crmSincronization;

        public SincronizationUserManager(IUserRepository userRepository,
            IUserNotification userNotification, 
            IReportGenerator reportGenerator,
            ICRMSincronizationService crmSincronization)
            : base(userRepository, userNotification, reportGenerator)
        {
            this.crmSincronization = crmSincronization;
        }

        public new void AddUser(User user)
        {
            base.AddUser(user);
            crmSincronization.SyncToCRM(user);
        }

        public new void UpdateUser(User user)
        {
            base.UpdateUser(user);
            crmSincronization.SyncToCRM(user);
        }

        public new void DeleteUser(User user)
        {
            base.DeleteUser(user);
            crmSincronization.SyncToCRM(user);
        }
    }
}
