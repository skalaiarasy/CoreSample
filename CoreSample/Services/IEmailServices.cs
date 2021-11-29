using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Services
{
    public interface IEmailServices
    {
        void SendEmail(Message message);
        void SetConfiguration();
    }
}
