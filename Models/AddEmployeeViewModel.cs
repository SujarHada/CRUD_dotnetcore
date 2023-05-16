namespace ASPNETMVCCRUD.Models
{
    public class AddEmployeeViewModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public long Salary { get; set; }

        public DateTime DateOfbirth { get; set; }

        public string? Deparment { get; set; }
    }
}
