using HelpDeskTask.Models.TicketStatuses;
using HelpDeskTask.Models.TicketTypes;
using System;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskCRM.Models
{
    public class Ticket
    {

        [Key]
        public int TicketID { get; set; }
        public DateTime? TicketDate { get; set; }
        public int TypeID { get; set; }
        public TicketType TicketType { get; set; }
        public int StatusID { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public int PriorityID { get; set; }
        public int ContactID { get; set; }
        public int CompanyID { get; set; }
        public int SystemID { get; set; }
        public int ScreenID { get; set; }
        public string Subject { get; set; }
        public int AssignTo { get; set; }
        public DateTime Created { get; set; }
        public int InsertById { get; set; }
        public string Notes { get; set; }
        public string ImagePath { get; set; }
        public string TesterNotes { get; set; }
        public string TestCase { get; set; }
    }
    }
