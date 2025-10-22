using System.Collections.Generic;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Courses
{
    public class ListCoursesQuery : IRequest<IEnumerable<Course>>
    {
    }
}
