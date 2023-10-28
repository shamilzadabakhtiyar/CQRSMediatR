using MediatR;

namespace MediatRExample.Med.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductViewmodel>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewmodel>>
        {
            public Task<List<GetProductViewmodel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var viewmodel = new GetProductViewmodel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };
                var viewmodel2 = new GetProductViewmodel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor"
                };
                return Task.FromResult(new List<GetProductViewmodel>() { viewmodel, viewmodel2 });
            }
        }
    }
}
