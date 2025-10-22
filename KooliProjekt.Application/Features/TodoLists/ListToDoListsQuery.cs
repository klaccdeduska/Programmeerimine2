﻿using System.Collections.Generic;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.TodoLists
{
    public class ListToDoListsQuery : IRequest<OperationResult<IList<ToDoList>>>
    {
    }
}
