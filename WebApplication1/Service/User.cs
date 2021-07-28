using IService;
using System;

namespace Service
{
    public class User: IUser
    {
        public string GetName()
        {
            return "zpj";
        }
    }
}
