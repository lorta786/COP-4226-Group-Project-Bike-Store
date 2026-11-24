
using System;

namespace BikeStore
{
    public class ErrorLog
    {
        public int ErrorLogID { get; set; }

        public DateTime ErrorDate { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorDetails { get; set; }

        public int UserID { get; set; }

        public string ModuleName { get; set; }
    }
}
