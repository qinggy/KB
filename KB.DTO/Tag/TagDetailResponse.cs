﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Dto.Tag
{
    public class TagDetailResponse
    {
        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedTime { get; set; }

        public string Name { get; set; }

        public int KBId { get; set; }

        public int SiteId { get; set; }
    }
}
