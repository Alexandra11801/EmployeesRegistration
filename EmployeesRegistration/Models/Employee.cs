using System;

namespace EmployeesRegistration.Models
{
    public class Employee
    {
        private int id;
        private string name;
        private string personnelNumber;
        private int departmentId;
        private string title;
        private string email;
        private string phoneNumber;
        private DateTime recruitDate;
        private Nullable<DateTime> fireDate;
        private bool active;

        public Employee(int id, string name, string personnelNumber, int departmentId, string title, string email,
            string phoneNumber, DateTime recruitDate, Nullable<DateTime> fireDate, bool active)
        {
            this.id = id;
            this.name = name;
            this.personnelNumber = personnelNumber;
            this.departmentId = departmentId;
            this.title = title;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.recruitDate = recruitDate;
            this.fireDate = fireDate;
            this.active = active;
        }

        public Employee(string name, string personnelNumber, int departmentId, string title, string email,
            string phoneNumber, DateTime recruitDate, Nullable<DateTime> fireDate, bool active) 
            : this(0, name, personnelNumber, departmentId, title, email, phoneNumber, recruitDate, fireDate, active){}

        public int Id => id;
        public string Name => name;
        public string PersonnelNumber => personnelNumber;
        public int DepartmentId => departmentId;
        public string Title => title;
        public string Email => email;
        public string PhoneNumber => phoneNumber;
        public DateTime RecruitDate => recruitDate;
        public Nullable<DateTime> FireDate => fireDate;
        public bool Active => active;
    }
}
