using KafeinExample.CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KafeinExample.CORE.Services
{
    public interface IUser : IRepository<Users>
    {
        //User tablosundaki tüm verileri getirir.Farklı işlemlere ihtiyaç olduğunda bu sayfada tanımlanacaktır.
    }

}
