using AutoMapper;
using HelpDeskCRM.DTOs.TicketsDto;
using HelpDeskCRM.Models;

namespace HelpDeskCRM.Mapping.Tickets
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketsDto>().ReverseMap();          
        }
    }
}
