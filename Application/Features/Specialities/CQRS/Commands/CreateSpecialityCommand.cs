using MediatR;
using Application.Responses;
using Application.Features.Specialities.DTOs;

namespace Application.Features.Specialities.CQRS.Commands
{
    public class CreateSpecialityCommand : IRequest<Result<Guid>>
    {
        public CreateSpecialityDto SpecialityDto { get; set; }
    }
}
