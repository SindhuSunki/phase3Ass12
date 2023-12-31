﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment12.Controllers
{
    public class Comments
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }

        // Foreign key to relate comments to a post
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}