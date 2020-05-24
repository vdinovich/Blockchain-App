namespace Blockchain_Admin_App.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public System.DateTime Date_Register { get; set; }
        public string Phone { get; set; }
    }
}
