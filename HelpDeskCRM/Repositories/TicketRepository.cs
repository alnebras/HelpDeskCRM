using AutoMapper;
using HelpDeskCRM.Authentication;
using HelpDeskCRM.DTOs;
using HelpDeskCRM.DTOs.TicketsDto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HelpDeskCRM.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public TicketRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public List<TicketsDto> TicketList(QueryParamsModel queryParams)
        {
           

            var ticketList = _applicationDbContext.Tickets.Include(t => t.TicketStatus)
                     .Where(u => u.TicketDate >= queryParams.DateFrom && u.TicketDate <= queryParams.DateTo && u.TicketStatus.Name == queryParams.TicketStatus).ToList();
            var TicketListDto = _mapper.Map<List<TicketsDto>>(ticketList);

            return TicketListDto;
        }

        public TicketsCountsDto TicketsSummary(QueryParamsModel queryParams)
        {
            var result = new TicketsCountsDto
            {
                TicketTypeCountDay = _applicationDbContext.Tickets.Include(ts => ts.TicketType)
                        .Where(t => t.TicketDate.Value.Day == queryParams.Date.Day && t.TicketType.Name == queryParams.TicketType).Count(),

                TicketTypeCountMonth = _applicationDbContext.Tickets.Include(ts => ts.TicketType)
                        .Where(t => t.TicketDate.Value.Month == queryParams.Date.Day && t.TicketType.Name == queryParams.TicketType).Count(),

                TicketTypeCountYear = _applicationDbContext.Tickets.Include(ts => ts.TicketType)
                        .Where(t => t.TicketDate.Value.Year == queryParams.Date.Year && t.TicketType.Name == queryParams.TicketType).Count()
            };
            return result;
        }
    }
}
