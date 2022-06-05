using RestAPI.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RestAPI.Servies
{
	public class RestManager
	{
		IRestService restService;

		public RestManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<EntryModel>> GetTasksAsync()
		{
			return restService.GetListEntrylist();
		}
	}
}
