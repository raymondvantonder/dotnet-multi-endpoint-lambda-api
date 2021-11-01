﻿using System;
using System.Collections.Generic;
using System.Text;
using TripleT.Domain.Entities.Common;

namespace TripleT.Domain.Entities
{
    public class LanguageEntity : AuditableEntity
    {
        public string Value { get; set; }

        public IList<ModuleEntity> Modules { get; set; } = new List<ModuleEntity>();
    }
}