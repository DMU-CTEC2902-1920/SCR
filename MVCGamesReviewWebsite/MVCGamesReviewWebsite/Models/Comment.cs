﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class Comment
    {
        public virtual int CommentId { get; set; }
        public virtual string CommentText { get; set; }

    }
}