using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Time_Tracker.MVVM.Model
{
    class ModuleModel
    {
        // Properties
        public string Code { get; set; }
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }
        public int ClassHoursPerWeek { get; set; }
        public int HoursOfSelfStudyPerWeek { get; set; }
        public int HoursOfSelfStudyRemaing { get; set; }
        public string ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public ObservableCollection<object> HoursSpentOnModule { get; set; }
        public ModuleModel(string code, string name, int numberOfCredits, int classHoursPerWeek, int numberOfWeeksInTheSemester)
        {
            Code = code;
            Name = name;
            NumberOfCredits = numberOfCredits;
            ClassHoursPerWeek = classHoursPerWeek;
            CreatedAt = DateTime.Now;
            HoursOfSelfStudyPerWeek = hoursOfSelfStudyPerWeek(numberOfWeeksInTheSemester);
            HoursOfSelfStudyRemaing = 0;

            Guid guid = Guid.NewGuid();
            ID = guid.ToString();
        }

        public int hoursOfSelfStudyPerWeek(int numberOfWeeks)
        {
            return (this.NumberOfCredits * 10 / numberOfWeeks) - ClassHoursPerWeek;
        }
        public int remaingHoursOfSelfStudyPerWeek(string moduleName,  ObservableCollection<ModuleHourse> moduleHourse)
        {
            int hoursOfSelfStudyAlreadyRecored = moduleHourse.Where(item => item.ModuleName == moduleName).Sum(item => item.Hours);
            int numberOfDaysInAWeek = 7 * 24;
            return numberOfDaysInAWeek - hoursOfSelfStudyAlreadyRecored;
        }
    }
}
