using System.ComponentModel.DataAnnotations;

namespace HelpDeskTask.Models.TicketStatuses
{
    public class TicketStatus
    {
        [Key]
        public int StatusID { get; set; }
        public string Name { get; set; }
    }
}
