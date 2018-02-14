﻿using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AweCsomeO365.Attributes.FieldAttributes
{
    public class UserAttribute : Attribute
    {
        bool AllowMultipleValues { get; set; }
        FieldUserSelectionMode FieldUserSelectionMode { get; set; } = FieldUserSelectionMode.PeopleOnly;
        public int? UserSelectionScope { get; set; }
        public const FieldType AssociatedFieldType = FieldType.User;

    }
}