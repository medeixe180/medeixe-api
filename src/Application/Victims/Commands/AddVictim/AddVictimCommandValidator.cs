

using FluentValidation;
using medeixeApi.Application.Common.Interfaces;

namespace medeixeApi.Application.Victims.Commands.AddVictim
{
    public class AddVictimCommandValidator : AbstractValidator<AddVictimCommand>
    {
        private readonly IApplicationDbContext _context;
        public AddVictimCommandValidator(IApplicationDbContext context)
        {
            _context = context;
        }
    }
}