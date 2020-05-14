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
        public string Key { get; set; }
        
        public string Value { get; set; }
        
        public bool FlActive {get;set; }
        
    }

}
