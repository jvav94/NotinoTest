using NotinoAppka.Controllers;
using NotinoAppka.Data;
using Microsoft.EntityFrameworkCore;

namespace Notino.Tests
{
	public class NotinoControllerTests
	{
		public static class DbContextMocker
		{
			public static APIcontext GetApiContext()
			{
				string dbName = "NotinoData";
				var options = new DbContextOptionsBuilder<APIcontext>()
					.UseInMemoryDatabase(databaseName: dbName)
					.Options;

				var dbContext = new APIcontext(options);

				return dbContext;
			}
		}

		[Fact]
		public void Return_Data()
		{
			var _context = DbContextMocker.GetApiContext();
			var controller = new NotinoController(_context);


			var result = _context.NotinoData.ToList();
			Assert.NotNull(result);
		}



	}
}