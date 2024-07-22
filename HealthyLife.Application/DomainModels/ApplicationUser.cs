
using Microsoft.AspNetCore.Identity;

namespace MyCalorieCounter.Application.DomainModels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateJoined { get; set; }
        public List<DailySum> DailySums { get; set; }
        public DailyGoal DailyGoal { get; set; }
    }
}
