using System;
using System.Linq;

namespace DevWorkBench.Pages
{
    public partial class Whitespace
    {
        private int currentCount = 0;
        private string Body { get; set; }

        private void RemoveWhiteSpace()
        {
            Body = String.Concat(Body.Where(c => !Char.IsWhiteSpace(c)));
            currentCount = Body.Length;
        }

        public void OnInput(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            Body = args.Value.ToString();

            currentCount = Body.Length;
        }
    }
}