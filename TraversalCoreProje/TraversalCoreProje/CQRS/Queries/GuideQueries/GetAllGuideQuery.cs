using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQuery>>
    {


    }
}
