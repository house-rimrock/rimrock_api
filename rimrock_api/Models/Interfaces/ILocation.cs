using System.Collections.Generic;
using System.Threading.Tasks;

namespace rimrock_api.Models.Interfaces
{
    /// <summary>
    ///     CRUD access abstracted to service. Interface methods here to controllers.
    /// </summary>
	public interface ILocation
	{
		Task<List<Location>> GetLocations();

		Task<Location> GetLocation(int id);
	}
}
