using System.Collections.Generic;

namespace EmployeesRegistration.Models
{
    public class Department
    {
        private int id;
        private string name;
        private int headDepartmentId;
        private int headId;
        private bool active;

        public Department(int id, string name, int headDepartmentId, int headId,  bool active)
        {
            this.id = id;
            this.name = name;
            this.headDepartmentId = headDepartmentId;
            this.headId = headId;
            this.active = active;
        }

        public Department(string name, int headDepartmentId, int headId, bool active) 
            : this(0, name, headDepartmentId, headId, active) { }

        public Department(int id, string name, bool active) : this(id, name, 0, 0, active) { }

        public int Id => id;
        public string Name => name;
        public int HeadDepartmentId
        {
            get
            {
                return headDepartmentId;
            }
            set
            {
                headDepartmentId = value;
            }
        }
        public int HeadId
        {
            get
            {
                return headId;
            }
            set
            {
                headId = value;
            }
        }
        public bool Active => active;
    }
}
