using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Courses
{
    public class ListCoursesHandler : IRequestHandler<ListCoursesQuery, IEnumerable<Course>>
    {
        private readonly ApplicationDbContext _context;

        public ListCoursesHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> Handle(ListCoursesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Courses.ToListAsync(cancellationToken);
        }
    }
}
