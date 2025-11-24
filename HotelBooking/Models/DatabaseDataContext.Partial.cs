using System.Configuration;

namespace HotelBooking.Models   // đặt đúng namespace giống designer.cs
{
    public partial class DatabaseDataContext : System.Data.Linq.DataContext
    {
        public DatabaseDataContext()
            : base(ConfigurationManager.ConnectionStrings["HotelBookingConnectionString"].ConnectionString)
        {
        }
    }
}
