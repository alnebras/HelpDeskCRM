using System;

namespace HelpDeskCRM.DTOs.TicketsDto
{
    public class TicketsDto
    {
        public int TypeID { get; set; }        
        public int StatusID { get; set; }
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
