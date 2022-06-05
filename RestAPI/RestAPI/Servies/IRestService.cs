using RestAPI.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RestAPI.Servies
{
    public interface IRestService
    {
        Task <List<EntryModel>> GetListEntrylist();
    }
}
