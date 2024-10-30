namespace API.Model
{
    public interface IEmployeeRepository
    {
        void add(Employee employee);
        List <Employee> get();
        
    }
}
