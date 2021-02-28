using Core.DataAccess.EntityFramework;
using DAL.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.EntityFramework
{
    public class EfMessageDal: EfEntityRepositoryBase<Message, WebChatContext>, IMessageDal
    {
    }
}
