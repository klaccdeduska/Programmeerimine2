using System.Collections.Generic;
using MediatR;
using KooliProjekt.Application.Data;

namespace KooliProjekt.Application.Features.Students
{
    public class ListStudentsQuery : IRequest<IEnumerable<Student>>
    {
    }
}
