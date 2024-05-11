using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    public class User
    {
        public Dictionary<string, UserData>? UserDataByTime { get; set; }
    }
}
