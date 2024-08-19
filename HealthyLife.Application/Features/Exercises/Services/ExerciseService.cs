using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Exercises.Dtos;
using HealthyLife.Application.Features.Exercises.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.Exercises.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IApplicationDbContext _context;

        public ExerciseService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateExerciseDto exerciseDto)
        {
            var exercise = new Exercise()
            {
                Name = exerciseDto.Name,
                CaloriesPerHour = exerciseDto.CaloriesPerHour,
                CreatedBy = exerciseDto.CreatedBy
            };

            await _context.Exercises.AddAsync(exercise);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var exercise = await GetExerciseAsync(id);
            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ExerciseDto>> GetAllAsync()
        {
            var exercises = await _context.Exercises.ToListAsync();
            
            if (exercises.Count == 0)
            {
                return new List<ExerciseDto>();
            }

            var exercisesDto = exercises.Select(e => e.ToDto()).ToList();
            return exercisesDto;
        }

        public async Task<ExerciseDto> GetByIdAsync(int id)
        {
            var exercise = await GetExerciseAsync(id);

            var exerciseDto = exercise.ToDto();
            return exerciseDto;
        }

        public async Task UpdateAsync(UpdateExerciseDto exerciseDto)
        {
            var exercise = await GetExerciseAsync(exerciseDto.Id);

            exercise.CaloriesPerHour = exerciseDto.CaloriesPerHour;

            _context.Exercises.Update(exercise);
            await _context.SaveChangesAsync();
        }

        private async Task<Exercise> GetExerciseAsync(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id) ?? throw new Exception("Exercise not found");
            return exercise;
        }
    }
}
