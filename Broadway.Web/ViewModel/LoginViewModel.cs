namespace Broadway.Web.ViewModel
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }

        public NewViewModel[] New { get; set; }
    }

    public class NewViewModel
    {
        public string Name { get; set; }
    }
}