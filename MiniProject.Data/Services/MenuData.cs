using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.Data.Services
{
    public interface MenuData
    {
        Menu GetMenu(string restaurant);
    }
}
