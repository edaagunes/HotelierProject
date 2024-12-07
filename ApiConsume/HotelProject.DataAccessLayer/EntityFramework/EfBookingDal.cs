using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(Context context) : base(context)
		{
		}

		public void BookingStatusChangeApproved(Booking booking)
		{
			using var context = new Context();
			var values = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
			values.Status = "Onaylandı";
			context.SaveChanges();
		}
	}
}
