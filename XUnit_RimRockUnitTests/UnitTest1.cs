using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;
using rimrock_api.Data;
using System.Linq;
using Xunit;

namespace XUnit_RimRockUnitTests
{
	public class ApiTests
	{
		[Fact]
		public void CanGetRegion()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetRegion").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Region region = new Region();
				region.ID = 1;
				region.Name = "Paris";

				context.Add(region);
				context.SaveChanges();

				// Act
				var result = context.Regions.FirstOrDefault(r => r.Name == region.Name);

				// Assert
				Assert.Equal(result, region);
			};
		}

		[Fact]
		public void CanGetRetailer()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetRetailer").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Retailer retailer = new Retailer();
				retailer.ID = 1;
				retailer.Name = "Second Ascents";
				retailer.Specialty = "Alpine climbing";

				context.Add(retailer);
				context.SaveChanges();

				// Act
				var result = context.Retailers.FirstOrDefault(r => r.Specialty == retailer.Specialty);

				// Assert
				Assert.Equal(result, retailer);
			};
		}

		[Fact]
		public void CanGetLocation()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetLocation").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Location location = new Location();
				location.ID = 1;
				location.Name = "Second Ascents";
				location.Cost = "$$";

				context.Add(location);
				context.SaveChanges();

				// Act
				var result = context.Locations.FirstOrDefault(loc => loc.Cost == location.Cost);

				// Assert
				Assert.Equal(result, location);
			};
		}

		//[Fact]

		/*
		public async void GetCompetitor_CanGetOnlyCompetitor()
		{
			//Create the options to feed into the context for dependency injection...
			DbContextOptions<API_DanceFellowsDbContext> options = new DbContextOptionsBuilder<API_DanceFellowsDbContext>().UseInMemoryDatabase("CanGetOnlyCompetitor").Options;

			using (API_DanceFellowsDbContext _context = new API_DanceFellowsDbContext(options))
			{
				//arrange
				Competitor competitor = new Competitor();
				competitor.WSDC_ID = 1000;
				competitor.FirstName = "Joe";
				competitor.LastName = "Schmoe";

				//act
				CompetitorManagementService resultServ = new CompetitorManagementService(_context);
				await _context.Competitors.AddAsync(competitor);
				await _context.SaveChangesAsync();

				Competitor query = await resultServ.GetCompetitor(competitor.WSDC_ID);
				//assert
				Assert.Equal(competitor, query);
			}
		}
		*/
	}
}
