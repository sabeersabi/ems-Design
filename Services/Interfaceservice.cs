using ems.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.Services
{
    internal interface Interfaceservice
    {
        Task<List<GetLoginModel>> GetAllLoginList();

    }
}
