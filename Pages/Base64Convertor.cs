using System;
using System.Text;

namespace DevWorkBench.Pages
{
    public partial class Base64Convertor
    {
        public string NonBase64Body{ get; set; }
        public string Base64Body { get; set; }

        private void ConvertToBase64()
        {
            Base64Body = "Attempt to encode";

            var plainTextBytes = Encoding.UTF8.GetBytes(NonBase64Body);
            Base64Body = Convert.ToBase64String(plainTextBytes);
            
        }

        private void ConvertFromBase64()
        {
            NonBase64Body = "Attempt to decode";

            var base64EncodedBytes = Convert.FromBase64String(Base64Body);
            NonBase64Body = Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}