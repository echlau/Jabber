﻿using System.Collections.Generic;
using JabberBCIT.Models;

namespace JabberBCIT
{
    public class ForumPostsViewmodel
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //IEnumerable<UserTags> Tags;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IEnumerable<ForumPost> Posts { get; set; }
    }
}
