using HealthyLife.Application.Features.Workouts.Dtos;

namespace HealthyLife.Application.Features.Workouts.Services
{
    public interface IWorkoutService
    {
        Task CreateAsync(CreateWorkoutDto workoutDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateWorkoutDto workoutDto);
        Task<WorkoutDto> GetByIdAsync(int id);
        Task<List<WorkoutDto>> GetAllAsync(int dailySumId);
    }
}
