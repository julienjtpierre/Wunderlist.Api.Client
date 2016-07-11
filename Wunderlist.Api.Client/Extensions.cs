using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wunderlist.Api.Client.Extensions
{
    public static class Extensions
    {
        public static UpdateTaskRequest ToUpdateTaskRequest(this Task value)
        {
            UpdateTaskRequest r = new UpdateTaskRequest
            {
                AssigneeId = value.AssigneeId,
                Completed = value.Completed,
                DueDate = value.DueDate,
                Starred = value.Starred,
                Title = value.Title,
                Revision = value.Revision
            };

            return r;
        }
    }
}
