using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities
{
    public class Comment
    {
        public Post Post
        {
            get => default;
            set
            {
            }
        }

        public User User
        {
            get => default;
            set
            {
            }
        }

        public DateOnly SendDate
        {
            get => default;
            set
            {
            }
        }

        public string Content
        {
            get => default;
            set
            {
            }
        }
    }
}