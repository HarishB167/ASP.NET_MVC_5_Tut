using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto rentalDto)
        {
            if (!ModelState.IsValid)
            {
                var msg = String.Format("rentalDto : {0}", rentalDto);
                return BadRequest(msg);
            }

            var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);

            foreach (var movieId in rentalDto.MovieIds)
            {
                var movie = _context.Movies.SingleOrDefault(m => m.Id == movieId);

                Rental rental = new Rental();
                rental.Customer = customer;
                rental.CustomerId = customer.Id;
                rental.Movie = movie;
                rental.MovieId = movie.Id;
                rental.DateRented = DateTime.Now;

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok("Successfully added rental");
        }
    }
}
