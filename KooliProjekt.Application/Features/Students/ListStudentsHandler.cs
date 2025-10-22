using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Students
{
    public class ListStudentsHandler : IRequestHandler<ListStudentsQuery, IEnumerable<Student>>
    {
        private readonly ApplicationDbContext _context;

        public ListStudentsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> Handle(ListStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.ToListAsync(cancellationToken);
        }
    }
}
