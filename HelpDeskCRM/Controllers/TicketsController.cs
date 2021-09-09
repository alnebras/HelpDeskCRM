using AutoMapper;
using HelpDeskCRM.DTOs;
using HelpDeskCRM.DTOs.TicketsDto;
using HelpDeskCRM.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HelpDeskCRM.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : Controller
    {

        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketsController(IMapper mapper, ITicketRepository ticketRepository)
        {
            _mapper = mapper;
            _ticketRepository = ticketRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
            
        [HttpGet]
        [Route("TicketList")]
        public ActionResult<List<TicketsDto>> TicketList([FromBody] QueryParamsModel queryParams)
        {
            var ticketList = _ticketRepository.TicketList(queryParams).ToList();
            if (ticketList == null)
                return NotFound();
            else
            return ticketList;
        }

        [HttpGet]
        [Route("TicketsSummary")]
        public ActionResult<TicketsCountsDto> TicketsSummary([FromBody] QueryParamsModel queryParams)
        {
            var ticketCounts = _ticketRepository.TicketsSummary(queryParams);
            if (ticketCounts == null)
                return NotFound();
            else
            return ticketCounts;
        }


    }
}
