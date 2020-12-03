using KafeinExample.CORE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KafeinExample.CORE.Services
{
    public interface IProduct : IRepository<Products>
    {

        //Product tablosundaki tüm verileri getirir.
        //List<Products> GetAll();

    }
}
