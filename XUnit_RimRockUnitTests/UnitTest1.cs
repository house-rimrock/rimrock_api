using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;
using rimrock_api.Data;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using rimrock_api.Models.Services;

namespace XUnit_RimRockUnitTests
{
	public class ApiTests
	{

		/////////////////////////////////
		// Test getters and setters
		/////////////////////////////////
		
		[Fact]
		public void CanGetRegionID()
		{
			// Arrange
			Region region = new Region();

			// Assert
			Assert.Equal(0, region.ID);
		}

		[Fact]
		public void CanSetRegionID()
		{
			// Arrange
			Region region = new Region();

			// Act
			region.ID = 3;

			// Assert
			Assert.Equal(3, region.ID);
		}

		[Fact]
		public void CanGetRegionName()
		{
			// Arrange
			Region region = new Region();

			// Assert
			Assert.Null(region.Name);
		}

		[Fact]
		public void CanSetRegionName()
		{
			// Arrange
			Region region = new Region();

			// Act
			region.Name = "The Okanogan, WA";

			// Assert
			Assert.Equal("The Okanogan, WA", region.Name);
		}

		[Fact]
		public void CanGetLocationID()
		{
			// Arrange
			Location location = new Location();

			// Assert
			Assert.Equal(0, location.ID);
		}

		[Fact]
		public void CanSetLocationName()
		{
			// Arrange
			Location location = new Location();

			// Act
			location.Name = "Dry Falls";

			// Assert
			Assert.Equal("Dry Falls", location.Name);
		}

		[Fact]
		public void CanGetLocationCost()
		{
			// Arrange
			Location location = new Location();

			// Assert
			Assert.Null(location.Cost);
		}

		[Fact]
		public void CanSetLocationCost()
		{
			// Arrange
			Location location = new Location();

			// Act
			location.Cost = "$$";

			// Assert
			Assert.Equal("$$", location.Cost);
		}

		[Fact]
		public void CanGetLocationForeignKey()
		{
			// Arrange
			Location location = new Location();

			// Assert
			Assert.Equal(0, location.RegionID);
		}

		[Fact]
		public void CanSetLocationForeignKey()
		{
			// Arrange
			Location location = new Location();

			// Act
			location.RegionID = 2;

			// Assert
			Assert.Equal(2, location.RegionID);
		}

		[Fact]
		public void CanGetRetailerID()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Assert
			Assert.Equal(0, retailer.ID);
		}

		[Fact]
		public void CanSetRetailerID()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Act
			retailer.Name = "Second Ascents";

			// Assert
			Assert.Equal("Second Ascents", retailer.Name);
		}

		[Fact]
		public void CanGetRetailerSpecialty()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Assert
			Assert.Null(retailer.Specialty);
		}

		[Fact]
		public void CanSetRetailerSpecialty()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Act
			retailer.Specialty = "Climbing";

			// Assert
			Assert.Equal("Climbing", retailer.Specialty);
		}

		[Fact]
		public void CanGetRetailerForeignKey()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Assert
			Assert.Equal(0, retailer.RegionID);
		}

		[Fact]
		public void CanSetRetailerForeignKey()
		{
			// Arrange
			Retailer retailer = new Retailer();

			// Act
			retailer.RegionID = 2;

			// Assert
			Assert.Equal(2, retailer.RegionID);
		}


		/////////////////////////////////////////
		// Test logic for GET methods setting objects into in-memory DB context
		/////////////////////////////////////////

		/// <summary>
		/// Tests whether can get a Region object from context
		/// </summary>
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

		/// <summary>
		/// Tests whether can get list of all Region objects from context
		/// </summary>
		[Fact]
		public void CanGetAllRegions()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetAllRegions").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Region region1 = new Region();
				region1.ID = 1;
				region1.Name = "Paris";

				context.Add(region1);
				context.SaveChanges();

				Region region2 = new Region();
				region2.ID = 2;
				region2.Name = "Bretagne";

				context.Add(region2);
				context.SaveChanges();

				// Act
				List<Region> list = context.Regions.ToList();

				// Assert
				Assert.Equal(list[1], region2);
			};
		}

		/// <summary>
		/// Tests whether can get a Retailer object from context
		/// </summary>
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

		/// <summary>
		/// Tests whether can get list of all Retailer objects from context
		/// </summary>
		[Fact]
		public void CanGetAllRetailers()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetAllRetailers").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Retailer retailer1 = new Retailer();
				retailer1.ID = 1;
				retailer1.Name = "Second Ascents";

				context.Add(retailer1);
				context.SaveChanges();

				Retailer retailer2 = new Retailer();
				retailer2.ID = 2;
				retailer2.Name = "Play It Again Sports";

				context.Add(retailer2);
				context.SaveChanges();

				// Act
				List<Retailer> list = context.Retailers.ToList();

				// Assert
				Assert.Equal(list[1], retailer2);
			};
		}

		/// <summary>
		/// Tests whether can get a Location object from context
		/// </summary>
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

		/// <summary>
		/// Tests whether can get list of all Location objects from context
		/// </summary>
		[Fact]
		public void CanGetAllLocations()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetAllLocations").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Location location1 = new Location();
				location1.ID = 1;
				location1.Name = "Mt. Baker";

				context.Add(location1);
				context.SaveChanges();

				Location location2 = new Location();
				location2.ID = 2;
				location2.Name = "Mt. St. Helens";

				context.Add(location2);
				context.SaveChanges();

				// Act
				List<Location> list = context.Locations.ToList();

				// Assert
				Assert.Equal(list[1], location2);
			};
		}


		/////////////////////////////////////////
		// Test GET methods using in-memory DB
		/////////////////////////////////////////

		/// <summary>
		/// Tests whether can get single Region by calling RegionService's GetRegion() method
		/// </summary>
		[Fact]
		public async void GetRegion_CanGetSingleRegion()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetSingleRegion").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Region region = new Region();
				region.ID = 1;
				region.Name = "The Palouse";

				// Act
				RegionService regionService = new RegionService(context);
				await context.Regions.AddAsync(region);
				await context.SaveChangesAsync();

				Region result = await regionService.GetRegion(region.ID);

				// Assert
				Assert.Equal(result, region);
			};
		}

		/// <summary>
		/// Tests whether can get single Retailer by calling RetailerService's GetRetailer() method
		/// </summary>
		[Fact]
		public async void GetRetailer_CanGetSingleRetailer()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetSingleRetailer").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Retailer retailer = new Retailer();
				retailer.ID = 1;
				retailer.Name = "Backcountry Essentials";

				// Act
				RetailerService retailerService = new RetailerService(context);
				await context.Retailers.AddAsync(retailer);
				await context.SaveChangesAsync();

				Retailer result = await retailerService.GetRetailer(retailer.ID);

				// Assert
				Assert.Equal(result, retailer);
			};
		}

		/// <summary>
		/// Tests whether can get single Location by calling LocationService's GetLocation() method
		/// </summary>
		[Fact]
		public async void GetLocation_CanGetSingleLocation()
		{
			DbContextOptions<RimRockApiDbContext> options = new DbContextOptionsBuilder<RimRockApiDbContext>().UseInMemoryDatabase("CanGetSingleLocation").Options;

			using (RimRockApiDbContext context = new RimRockApiDbContext(options))
			{
				// Arrange
				Location location = new Location();
				location.ID = 1;
				location.Name = "Second Ascents";
				location.Cost = "$$";

				// Act
				LocationService locationService = new LocationService(context);
				await context.Locations.AddAsync(location);
				await context.SaveChangesAsync();

				Location result = await locationService.GetLocation(location.ID);

				// Assert
				Assert.Equal(result, location);
			};
		}
	}
}
