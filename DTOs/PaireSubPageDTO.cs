﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectFinal1.Models;

namespace ProjectFinal1.DTOs
{
    public class PaireSubPageDTO
    {
        public int Coursecs { get; set; }
        public int Coursetra { get; set; }
        public List<SelectListItem> TransferCourse { get; set; }
        public List<SelectListItem> CsCourseStruc { get; set; }
        public List<SelectListItem> TraSub { get; set; }
        public TransferSub Data { get; set; }
    }
}