using HelpDeskCRM.DTOs;
using HelpDeskCRM.DTOs.TicketsDto;
using System.Collections.Generic;

namespace HelpDeskCRM.Repositories
{
    public interface ITicketRepository
    {
        List<TicketsDto> TicketList(QueryParamsModel queryParams);
        TicketsCountsDto TicketsSummary(QueryParamsModel queryParams);
    }
}
