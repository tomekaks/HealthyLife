namespace MyCalorieCounter.Application.DomainModels
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaloriesPerHour { get; set; }
        public string CreatedBy { get; set; }
    }
}
