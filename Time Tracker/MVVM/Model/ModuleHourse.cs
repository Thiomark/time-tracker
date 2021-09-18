using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Tracker.MVVM.Model
{
    class ModuleHourse
    {
        public int Hours { get; set; }
        public DateTime ModuleDate { get; set; }
        public string ModuleName { get; set; }
        public string ModuleID { get; set; }
        public string ID { get; set; }
        public string ModuleDateStringFormate
        {
            get 
            { 
                return ModuleDate.ToLongDateString();
            }
        }
        public ModuleHourse()
        {
            Guid guid = Guid.NewGuid();
            ID = guid.ToString();
        }
        

    }
}
