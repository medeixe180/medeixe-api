using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medeixeApi.Application.Common.Interfaces;
using medeixeApi.Domain.Entities;
using MediatR;

namespace medeixeApi.Application.Victims.Commands.AddVictim
{
    public record AddVictimCommand : IRequest<int>
    {
        public string? Name { get; internal set; }
    }

    public class AddVictimCommandHandler : IRequestHandler<AddVictimCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public AddVictimCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddVictimCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Victim
            {
                Name = request.Name
            };
            //TODO: precisa adicionar evento?
            _context.Victims.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}