using Microsoft.AspNetCore.Identity;
using System;
using YMS5177_CMS.Entity.Entities.Interfaces;
using YMS5177_CMS.Entity.Enums;

namespace YMS5177_CMS.Entity.Entities.Concrete
{
    //IdentityUser => Microsoft'un bize hazrıladığı bir sınıf, user ile ilgli işlmelerde hızlı kullanabilmemiz için bize bir çok yapı sağlayan bir sınıf. User Role, login registrition işlemlerinde hazır yapılar sunmaktadır. Bu sınıfın kendi hazır tabloların "Id" sütunu barındırdığından, alışık olduğunuz gibi IBaseEntity.cs arayüzünden varlıklarımıza Id basmadık. 
    public class AppUser:IdentityUser,IBaseEntity
    {
        //IdentityUSer sınıfının içermediği ama projede ihityaç duyulan özellikler burada eklenebilinir.
        public string Occupation { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
