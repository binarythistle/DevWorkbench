using System;

namespace DevWorkBench.Pages
{
    public partial class GenGUID
    {
        public string Body {get; set;}
        
        private void GenerateGUID()
        {
            Body = Guid.NewGuid().ToString();
        }
    }
}