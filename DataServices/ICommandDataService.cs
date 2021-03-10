

using System.Threading.Tasks;
using DevWorkBench.Models;

namespace DevWorkBench.DataServices
{
    public interface ICommandDataService
    {
        Task<Command[]> GetAllCommandsGraphQL();
    }
}