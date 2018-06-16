using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryServices.ActionResult
{
    public interface IHttpActionResult
    {
        Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken);
    }
}
