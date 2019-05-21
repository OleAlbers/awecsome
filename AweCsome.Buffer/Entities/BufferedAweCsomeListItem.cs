﻿using System;
using System.Collections.Generic;
using AweCsome.Attributes.FieldAttributes;
using AweCsome.Attributes.IgnoreAttributes;

namespace AweCsome.Buffer.Entities
{
    public abstract class BufferedAweCsomeListItem
    {
        [LiteDB.BsonId]
        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnSelect]
        public virtual int BsonId { get; set; }


        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate]
        public virtual int Id { get; set; }
        [IgnoreOnCreation]
        public virtual string Title { get; set; }

        [User]
        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate]
        public virtual KeyValuePair<int, string> Author { get; set; }

        [User]
        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate]
        public virtual KeyValuePair<int, string> Editor { get; set; }

        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate]
        public virtual DateTime Created { get; set; }

        [IgnoreOnCreation, IgnoreOnInsert, IgnoreOnUpdate]
        public virtual DateTime? Modified { get; set; }
    }

}
