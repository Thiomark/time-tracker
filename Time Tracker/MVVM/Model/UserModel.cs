using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Tracker.MVVM.Model
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
        public UserModel()
        {
            Guid guid = Guid.NewGuid();
            ID = guid.ToString();
        }
    }
}