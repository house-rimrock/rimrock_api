using System.Collections.Generic;
using System.Threading.Tasks;

namespace rimrock_api.Models.Interfaces
{
    /// <summary>
    ///     CRUD access abstracted to service. Interface methods here to controllers.
    /// </summary>
	public interface IRetailer
	{
		Task<List<Retailer>> GetRetailers();

		Task<Retailer> GetRetailer(int id);
	}
}
