using System;
using System.Threading.Tasks;
using DevWorkBench.DataServices;
using DevWorkBench.Models;
using Microsoft.AspNetCore.Components;

namespace DevWorkBench.Pages
{
    public partial class CommandData
    {

        public string SearchCriteria { get; set; }

        [Inject]
        public ICommandDataService CommandDataService {get; set;}

        public Command[] Result {get; set;}

        // protected override async Task OnInitializedAsync()
        // {
        //     Result = await CommandDataService.GetAllCommandsGraphQL();
        // }

        private async Task QueryAPI()
        {
            Console.WriteLine($"-> Search Criteria: {SearchCriteria}");

            Result = await CommandDataService.GetSelectedCommandsGraphQL(SearchCriteria);
        }
    }
}