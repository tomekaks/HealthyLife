using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Workouts.Dtos;
using HealthyLife.Application.Features.Workouts.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<WorkoutDto>> GetAllAsync(int dailySumId)
        {
            var workouts = await _context.Workouts
                            .Include(workout => workout.Exercise)
                            .Where(workout => workout.DailySumId == dailySumId)
                            .ToListAsync();

            if (workouts.Count < 1)
            {
                return new List<WorkoutDto>();
            }

            var workoutsDto = workouts.Select(workout => workout.ToDto()).ToList();
            return workoutsDto;
        }

        public async Task<WorkoutDto> GetByIdAsync(int id)
        {
            var workout = await GetWorkoutAsync(id);

            var workoutDto = workout.ToDto();
            return workoutDto;
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
