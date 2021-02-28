using Core.DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
    public interface IMessageDal:IEntityRepository<Message>
    {
    }
}
