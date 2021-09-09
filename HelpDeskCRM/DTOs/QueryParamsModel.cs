using System;

namespace HelpDeskCRM.DTOs
{
    public class QueryParamsModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime Date { get; set; }
        public string TicketType { get; set; }
        public string TicketStatus { get; set; }
    }
}
