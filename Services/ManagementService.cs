using Bank.Models.Management;

namespace Bank.Services
{
    public class ManagementService : Manager
    {
        protected Manager _component;
        public ManagementService(Manager person) : base(person.name)
        {
            this._component = person;
        }
    }

    public class ManagePersonal : ManagementService
    {
        protected Manager manager;
        public ManagePersonal(Manager person) : base(person)
        {
            this.manager = person;
        }

        public void AddPerson(Person data)
        {
            manager.employersList.Add(data);
        }
    }
}
