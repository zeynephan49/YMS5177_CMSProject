
using System;
using YMS5177_CMS.Entity.Enums;

namespace YMS5177_CMS.Entity.Entities.Interfaces
{
    public interface IBaseEntity
    {
        DateTime CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Status Status { get; set; }
    }
}
