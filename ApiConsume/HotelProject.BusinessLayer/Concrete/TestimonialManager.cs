using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TDelete(Testimonial entity)
		{
			_testimonialDal.Delete(entity);
		}

		public List<Testimonial> TGetAll()
		{
			return _testimonialDal.GetAll();
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public void TInsert(Testimonial entity)
		{
			_testimonialDal.Insert(entity);
		}

		public void TUpdate(Testimonial entity)
		{
			_testimonialDal.Update(entity);
		}
	}
}
