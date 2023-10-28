using MediatR;

namespace MediatRExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewmodel>
    {
        public Task<GetProductViewmodel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewmodel = new GetProductViewmodel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return Task.FromResult(viewmodel);
        }
    }
}
