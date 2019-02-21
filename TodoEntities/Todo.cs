using System;

namespace TodoEntities
{
    public class Todo : IEquatable<Todo>
    {
        public string Name { get; set; }

        public bool Equals(Todo other)
        {
            return other == this;
        }
    }
}
