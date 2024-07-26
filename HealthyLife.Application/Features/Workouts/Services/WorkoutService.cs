using HealthyLife.Application.Features.Workouts.Dtos;
using HealthyLife.Application.Interfaces;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Workouts.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IApplicationDbContext _context;

        public WorkoutService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateWorkoutDto workoutDto)
        {
            var workout = new Workout()
            {
                DailySumId = workoutDto.DailySumId,
                CaloriesBurned = workoutDto.CaloriesBurned,
                Minutes = workoutDto.Minutes,
                ExerciseId = workoutDto.ExerciseId
            };

            await _context.Workouts.AddAsync(workout);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var workout = await GetWorkoutAsync(id);
            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();
        }

        public Task<List<WorkoutDto>> GetAllAsync(int dailySumId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkoutDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(UpdateWorkoutDto workoutDto)
        {
            var workout = await GetWorkoutAsync(workoutDto.Id);

            workout.CaloriesBurned = workoutDto.CaloriesBurned;
            workout.Minutes = workoutDto.Minutes;

            _context.Workouts.Update(workout);
            await _context.SaveChangesAsync();
        }

        private async Task<Workout> GetWorkoutAsync(int id)
        {
            var workout = await _context.Workouts.FindAsync(id) ?? throw new Exception("Workout not found");
            return workout;
        }
    }
}
