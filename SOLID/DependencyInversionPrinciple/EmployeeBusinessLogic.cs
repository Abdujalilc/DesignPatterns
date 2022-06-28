namespace DependencyInversionPrinciple
{
    public class EmployeeBusinessLogic
    {
        //wrong - EmployeeDataAccess _EmployeeDataAccess;
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
