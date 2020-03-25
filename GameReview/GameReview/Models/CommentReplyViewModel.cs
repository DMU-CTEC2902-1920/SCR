using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class CommentReplyViewModel
    {
        //combined view model of comment and reply
        //reply part
        public string AnCommentReply { get; set; }
        //comment part
        public int ACommentId { get; set; }
    }
}