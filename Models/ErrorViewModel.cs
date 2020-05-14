using System;

namespace CoreWebFirst.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    }

    public class MySampleModel
    {
        public string key { get; set; }
        public string value { get; set; }
    }

}