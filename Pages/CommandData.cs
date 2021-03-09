using System.Threading.Tasks;
using DevWorkBench.DataServices;
using DevWorkBench.Models;
using Microsoft.AspNetCore.Components;

namespace DevWorkBench.Pages
{
    public partial class CommandData
    {
        [Inject]
        public ICommandDataService CommandDataService {get; set;}

        public Command[] Result {get; set;}

        protected override async Task OnInitializedAsync()
        {
            Result = await CommandDataService.GetAllCommandsGraphQL();
        }

        
    }
}