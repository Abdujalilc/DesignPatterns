namespace DependencyInversionPrinciple
{
    public class DataAccessFactory
    {
        //not public static EmployeeDataAccess GetEmployeeDataAccessObj()
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            //this returns a new instance of EmployeeDataAccess object.
            return new EmployeeDataAccess();
        }
    }
}
