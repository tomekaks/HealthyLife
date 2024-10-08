﻿using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Exercises.Mappings;
using HealthyLife.Application.Features.Workouts.Dtos;

namespace HealthyLife.Application.Features.Workouts.Mappings
{
    public static class WorkoutMappings
    {
        public static WorkoutDto ToDto(this Workout workout)
        {
            return new WorkoutDto()
            {
                Id = workout.Id,
                DailySumId = workout.DailySumId,
                CaloriesBurned = workout.CaloriesBurned,
                Minutes = workout.Minutes,
                Exercise = workout.Exercise.ToDto()
            };
        }
    }
}
