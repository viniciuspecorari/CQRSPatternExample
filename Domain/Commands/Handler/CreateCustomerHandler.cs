using CQRSPatternEx.Domain.Commands.Requests;
using CQRSPatternEx.Domain.Commands.Responses;
using MediatR;

namespace CQRSPatternEx.Domain.Commands.Handler
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente ja está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia e-mail de boas-vindas

            var result = new CreateCustomerResponse()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                CreatedAt = DateTime.Now,
            };

            return Task.FromResult(result);
        }
    }
}
