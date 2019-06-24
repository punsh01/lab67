namespace lab67.DAL.EntityFramework
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	using lab67.DAL.Entities;

	public class Context : DbContext
	{
		// Your context has been configured to use a 'Context' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'lab67.DAL.EntityFramework.Context' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'Context' 
		// connection string in the application configuration file.

		public DbSet<Car> Cars { get; set; }
		public DbSet<Driver> Drivers { get; set; }

		static Context()
		{
			Database.SetInitializer<Context>(new StoreDbInitializer());
		}
		public Context()
			 : base("name=Context")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<Context>
	{
		protected override void Seed(Context db)
		{
			db.Cars.Add(new Car { CarId = 1, DriverId = 3, Model = "TGX", Company = "MAN", Capacity = 15000, ConditionAssessment = 99.98 });
			db.Cars.Add(new Car { CarId = 2, DriverId = 1, Model = "TGS", Company = "MAN", Capacity = 23000, ConditionAssessment = 96.1 });
			db.Cars.Add(new Car { CarId = 3, DriverId = 2, Model = "TGM", Company = "MAN", Capacity = 7000, ConditionAssessment = 83.2 });

			db.Drivers.Add(new Driver { DriverId = 1, Name = "Vlad Saukhin", Taxpay = "1111111111" });
			db.Drivers.Add(new Driver { DriverId = 2, Name = "Dima Yax", Taxpay = "1111111112" });
			db.Drivers.Add(new Driver { DriverId = 3, Name = "QW ER", Taxpay = "1111111113" });

			db.SaveChanges();
		}
	}
}