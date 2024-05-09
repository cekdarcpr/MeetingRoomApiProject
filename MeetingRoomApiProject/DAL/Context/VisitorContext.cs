using MeetingRoomApiProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KNM9LLL\\SQLEXPRESS;initial catalog=ReservationDbApi;integrated security=true;");

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
