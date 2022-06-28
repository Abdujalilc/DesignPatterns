namespace DependencyInversionPrinciple
{
    public class EmployeeBusinessLogic
    {
        //wrong - EmployeeDataAccess _EmployeeDataAccess;
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            // DataAccessFactory.GetEmployeeDataAccessObj() returns new instance of Employee
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
