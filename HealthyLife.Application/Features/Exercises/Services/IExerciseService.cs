using HealthyLife.Application.Features.Exercises.Dtos;

namespace HealthyLife.Application.Features.Exercises.Services
{
    public interface IExerciseService
    {
        Task AddAsync(CreateExerciseDto exerciseDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateExerciseDto exerciseDto);
        Task<ExerciseDto> GetByIdAsync(int id);
        Task<List<ExerciseDto>> GetAllAsync();
    }
}
