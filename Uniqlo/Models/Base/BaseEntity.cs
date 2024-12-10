﻿using System;

namespace Uniqlo.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
