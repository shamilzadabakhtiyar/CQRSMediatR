using MediatR;

namespace MediatRExample.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewmodel>
    {
        public Guid Id { get; set; }
    }
}
