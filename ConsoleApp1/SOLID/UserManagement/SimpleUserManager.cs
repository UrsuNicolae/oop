namespace ConsoleApp1.SOLID.UserManagement
{
    public class SimpleUserManager
    {
        private readonly IUserRepository userRepository;
        private readonly IUserNotification userNotification;
        private readonly IReportGenerator reportGenerator;

        public SimpleUserManager(IUserRepository userRepository,
            IUserNotification userNotification,
            IReportGenerator reportGenerator)
        {
            this.userRepository = userRepository;
            this.userNotification = userNotification;
            this.reportGenerator = reportGenerator;
        }

        public void AddUser(User user)
        {
            userRepository.AddUser(user);
            userNotification.SendEmail(user);
            reportGenerator.GenerateReport(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUser(user);
            userNotification.SendEmail(user);
        }

        public void DeleteUser(User user)
        {
            userNotification.SendEmail(user);
            userRepository.DeleteUser(user);
        }
    }
}
