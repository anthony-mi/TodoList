using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models.Entities
{
    class TodoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? CompletedTime { get; set; }
    }
}
