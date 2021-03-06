﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YMS5177_CMS.Entity.Entities.Interfaces;
using YMS5177_CMS.Entity.Enums;

namespace YMS5177_CMS.Entity.Entities.Concrete
{
    public class Page : IBaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Must type a title")]
        [MinLength(2, ErrorMessage ="Minimum lenght is 2")]
        public string Title  { get; set; }

        public string Slug { get; set; }

        [Required(ErrorMessage = "Must type a title")]
        [MinLength(2, ErrorMessage = "Minimum lenght is 2")]
        public string Content { get; set; }

        public int Sorting { get; set; }

        //IBaseEntity'den gelen özellekler
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get ; set ; }
        public DateTime? DeleteDate { get ; set ; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
