using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Utilities
{
    public class ErrorMessage
    {
        public ErrorMessage()
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; set; }
        public int Status { get; set; }
    }
}