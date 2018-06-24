using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryServices.ActionResult
{
    /// <summary>
    /// right now not in use
    /// </summary>
    public interface IHttpActionResult
    {
        Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken);
    }
}
