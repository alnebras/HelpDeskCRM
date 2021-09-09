using System.ComponentModel.DataAnnotations;

namespace HelpDeskTask.Models.TicketTypes
{
    public class TicketType
    {
        [Key]
        public int TypeID { get; set; }
        public string Name { get; set; }
    }
}
