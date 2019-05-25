using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DojoActivities.Models;
using System.Linq;

namespace DojoActivities.Models 
{
    public class DojoActivityContext : DbContext 
    {
        public DojoActivityContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Ninjas {get;set;}
        public DbSet<DojoActivity> Activities {get;set;}
        public DbSet<Participant> Participants {get;set;}

        public int Create(User u)
        {
            Ninjas.Add(u);
            SaveChanges();
            return u.UserId;
        }

        public User GetUserByEmail(string Email)
        {
            return Ninjas.FirstOrDefault(u => u.Email == Email);
        }

        public User GetUserById(int UserId)
        {
            return Ninjas.FirstOrDefault(u => u.UserId == UserId);
        }
        public DojoActivity GetActivityById(int ActId)
        {
            return Activities.Where(a => a.ActivityId == ActId).FirstOrDefault();
        }

        public void Create(DojoActivity a)
        {
            Add(a);
            SaveChanges();
        }

        public void Create(Participant p)
        {
            Add(p);
            SaveChanges();
        }

        public void Remove(int ActId)
        {
            Remove(GetActivityById(ActId));
            SaveChanges();
        }


        public void Remove(int ActId, int PartId)
        {
            Participant Attendee = Participants
                .Where(a => a.ActivityId == ActId)
                .Where(p => p.UserId == PartId)
                .FirstOrDefault();

            Remove(Attendee);
            SaveChanges();
        }

    }
}