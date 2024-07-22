namespace HealthyLife.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
