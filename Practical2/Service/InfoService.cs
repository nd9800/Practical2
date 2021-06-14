using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practical2.Models;

namespace Practical2.Service
{
    interface InfoService
    {
        List<InfoItem> GetInfo();
        bool AddInfo(InfoItem item);

    }
}
