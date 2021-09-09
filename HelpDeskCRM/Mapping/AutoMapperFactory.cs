using AutoMapper;
using HelpDeskCRM.Mapping.Tickets;

namespace HelpDeskCRM.Mapping
{
    public class AutoMapperFactory
    {
     
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cgf =>
            {
                cgf.AddProfile<TicketProfile>();

            }).CreateMapper();

        }
    }
}
