using Time_Tracker.Core;
using Time_Tracker.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Threading.Tasks;
using System.Threading;

namespace Time_Tracker.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<ModuleModel> Modules { get; set; }
        public ObservableCollection<ModuleHourse> HourseSpentOnModules { get; set; }
        public SemesterModel CurentSemester { get; set; }
        public UserModel CurrentUser { get; set; }

        public string color = "#409aff";

        public RelayCommand SendCommand { get; set; }
        public RelayCommand SendNumOfWeeksCommand { get; set; }
        public RelayCommand DeleteModuleCommand { get; set; }
        public RelayCommand HourseSpentOnModulesCommand { get; set; }

        private ModuleModel _selectedContact;

        public ModuleModel SelectedContact
        {
            get { return _selectedContact; }
            set {
                _selectedContact = value;
                ShowSelectedModule = "Visible";
                if(_selectedContact != null)
                {
                    HoursOfSelfStudyRemaing = SelectedContact.remaingHoursOfSelfStudyPerWeek(SelectedContact.Name, HourseSpentOnModules);
                }
                onPropertyChanged();
            }
        }

        // Hours Of Self Study Per Week
        private int _hoursOfSelfStudyPerWeek;

        public int HoursOfSelfStudyPerWeek
        {
            get { return _hoursOfSelfStudyPerWeek; }
            set { 
                _hoursOfSelfStudyPerWeek = value;
                onPropertyChanged();

            }
        }


        // Todays date for the user to know the current date
        private DateTime _dateOfToday = DateTime.Now;

        public DateTime DateOfToday
        {
            get { return _dateOfToday; }
            set { _dateOfToday = value; }
        }

        // Property for Semester Start Date that the UI will use
        private DateTime _semesterStartDate;

        public DateTime SemesterStartDate
        {
            get { return _semesterStartDate; }
            set {
                _semesterStartDate = value;
                onPropertyChanged();
            }
        }


        // Property for NumOfWeeks that the UI will use
        private int _numOfWeeks;
 
        private int _numOfWeeksUILabel;

        public int NumOfWeeksUILabel
        {
            get { return _numOfWeeksUILabel; }
            set {
                _numOfWeeksUILabel = value;
                onPropertyChanged();
            }
        }

        public int NumOfWeeks
        {
            get { return _numOfWeeks; }
            set { 
                _numOfWeeks = value;
                onPropertyChanged();
            }
        }


        // Property for Start Date For The First Week that the UI will use
        private string _startDateForTheFirstWeek;

        public string StartDateForTheFirstWeek
        {
            get { return _startDateForTheFirstWeek; }
            set {
                _startDateForTheFirstWeek = value;
                onPropertyChanged();
            }
        }

        // Property for Remaing Number Of Weeks In The Semester that the UI will display
        private string _remaingNumberOfWeeksInTheSemester;

        public string RemaingNumberOfWeeksInTheSemester
        {
            get { return _remaingNumberOfWeeksInTheSemester; }
            set {
                _remaingNumberOfWeeksInTheSemester = value;
                onPropertyChanged();
            }
        }


        // Property for User Name and surname that the UI will use
        public string UserNameAndSurname { get; set; }

        // Module code input
        private string _moduleCode;
        public string ModuleCode
        {
            get { return _moduleCode; }
            set {
                _moduleCode = value;
                onPropertyChanged();
            }
        }

        // Module name input
        private string _moduleName;
        public string ModuleName
        {
            get { return _moduleName; }
            set
            {
                _moduleName = value;
                onPropertyChanged();
            }
        }

        // Module Number Of Credits input
        private int _moduleNumberOfCredits;
        public int ModuleNumberOfCredits
        {
            get { return _moduleNumberOfCredits; }
            set
            {
                _moduleNumberOfCredits = value;
                onPropertyChanged();
            }
        }

        // Module Class Hours Per Week input
        private int _moduleClassHoursPerWeek;
        public int ModuleClassHoursPerWeek
        {
            get { return _moduleClassHoursPerWeek; }
            set
            {
                _moduleClassHoursPerWeek = value;
                onPropertyChanged();
            }
        }

        // Property to tell UI to show the selected Module Information
        private string _showSelectedModule;

        public string ShowSelectedModule
        {

            get { return _showSelectedModule; }
            set {
                _showSelectedModule = value;
                onPropertyChanged();
            }
        }

        // Hours property to Update the UI
        private int _hourseSpentOnModules_Hours;

        public int HourseSpentOnModules_Hours
        {
            get { return _hourseSpentOnModules_Hours; }
            set { 
                _hourseSpentOnModules_Hours = value; 
                onPropertyChanged(); 
            }
        }

        // Date property to Update the UI
        private DateTime _hourseSpentOnModules_Date;

        public DateTime HourseSpentOnModules_Date
        {
            get { return _hourseSpentOnModules_Date; }
            set { 
                _hourseSpentOnModules_Date = value;
                onPropertyChanged();
            }
        }

        // This property is to show the user sum Of hours for all modules
        private int _sumOfHourseSpentOnModules;

        public int SumOfHourseSpentOnModules
        {
            get { 
                return _sumOfHourseSpentOnModules = HourseSpentOnModules.Sum(item => item.Hours);
            }
            set { 
                _sumOfHourseSpentOnModules = value;
                onPropertyChanged();
            }
        }

        // Combo box select value 
        private string _hourseSpentOnModules_Selected;

        public string HourseSpentOnModules_Selected
        {
            get { return _hourseSpentOnModules_Selected; }
            set { 
                _hourseSpentOnModules_Selected = value;
                onPropertyChanged();
            }
        }

        // Property HoursOfSelfStudyRemaing for the UI
        private int _hoursOfSelfStudyRemaing;

        public int HoursOfSelfStudyRemaing
        {
            get {
                return _hoursOfSelfStudyRemaing = SelectedContact.remaingHoursOfSelfStudyPerWeek(SelectedContact.Name, HourseSpentOnModules);
            }
            set { 
                _hoursOfSelfStudyRemaing = value;
                onPropertyChanged();
            }
        }

        // Seach module property for the UI
        private string _searchModule;

        public string SearchModule
        {
            get { return _searchModule; }
            set { 
                _searchModule = value;
                MessageBox.Show("ss");
                onPropertyChanged();
            }
        }


        public MainViewModel()
        {
            // Creating the current user object of the Application
            // -- Ater will be changed to registering the user when we Add SQL
            CurrentUser = new UserModel { Name = "Itumeleng", Surname = "Tsoela" };
            ShowSelectedModule = "Visible";

            // Creating the current semester object of the Application
            // This will work once the user is able to register to avoid setting every date to Date.Now
            DateTime randomDate = new DateTime(2021,02,01);
            HourseSpentOnModules_Date = DateTime.Now;
            CurentSemester = new SemesterModel { NumberOfWeeksInTheSemester = 15, StartDateForTheFirstWeek = randomDate };
            NumOfWeeks = CurentSemester.NumberOfWeeksInTheSemester;
            NumOfWeeksUILabel = CurentSemester.NumberOfWeeksInTheSemester;
            SemesterStartDate = CurentSemester.StartDateForTheFirstWeek;

            StartDateForTheFirstWeek = CurentSemester.StartDateForTheFirstWeek.ToLongDateString();

            UserNameAndSurname = $"{CurrentUser.Surname} {CurrentUser.Name}";

            Modules = new ObservableCollection<ModuleModel>();
            HourseSpentOnModules = new ObservableCollection<ModuleHourse>();

            SendCommand = new RelayCommand(o =>
            {
                if (ModuleCode.Length < 1 || ModuleName.Length < 1 || ModuleNumberOfCredits == 0 || ModuleClassHoursPerWeek == 0)
                {
                    if(ModuleNumberOfCredits == 0 || ModuleClassHoursPerWeek == 0)
                        MessageBox.Show("Module credits or the module class hours per week cannot be 0");
                    else
                        MessageBox.Show("Please enter all Fields!!");
                }
                else
                {
                    Modules.Add(new ModuleModel(ModuleCode, ModuleName, ModuleNumberOfCredits, ModuleClassHoursPerWeek, 15));

                    ModuleCode = "";
                    ModuleName = "";
                    ModuleNumberOfCredits = 0;
                    ModuleClassHoursPerWeek = 0;
                }
            });

            DeleteModuleCommand = new RelayCommand(o =>
            {
                
                if (SelectedContact != null)
                {
                    Modules.Remove(Modules.Where(i => i.Code == SelectedContact.Code).Single());
                    SelectedContact = null;

                    Task.Factory.StartNew(() => Thread.Sleep(1))
                    .ContinueWith((t) =>
                    {
                        ShowSelectedModule = "Collapsed";
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    
                }
            });

            HourseSpentOnModulesCommand = new RelayCommand(o =>
            {
                // Checking if there are modules so that the combobox can work since its field is based on list of modules
                if (Modules.Count() == 0)
                {
                    MessageBox.Show("You do not have any modules, Add modules First");
                }
                else
                {
                    // Check if fileds are there or not
                    if (HourseSpentOnModules_Selected == null)
                        MessageBox.Show("Please select a module form the drop down combo box");
                    else if (HourseSpentOnModules_Hours == 0)
                        MessageBox.Show("Hourse spent on the module has to be a number and greator than 0");
                    else
                    {
                        HourseSpentOnModules.Add(new ModuleHourse { Hours = HourseSpentOnModules_Hours, ModuleDate = HourseSpentOnModules_Date, ModuleName = HourseSpentOnModules_Selected });
                        SumOfHourseSpentOnModules = HourseSpentOnModules.Sum(item => item.Hours);
                        HourseSpentOnModules_Date = DateTime.Now;
                        HourseSpentOnModules_Hours = 0;
                        if(SelectedContact != null)
                        {
                            HoursOfSelfStudyRemaing = SelectedContact.remaingHoursOfSelfStudyPerWeek(SelectedContact.Name, HourseSpentOnModules);
                        }
                        onPropertyChanged();
                    }
                }
                
            });

            SendNumOfWeeksCommand = new RelayCommand(o =>
            {
                CurentSemester = new SemesterModel { NumberOfWeeksInTheSemester = NumOfWeeks, StartDateForTheFirstWeek = SemesterStartDate };
                NumOfWeeksUILabel = CurentSemester.NumberOfWeeksInTheSemester;
                StartDateForTheFirstWeek = CurentSemester.StartDateForTheFirstWeek.ToLongDateString();
                onPropertyChanged();
            });

            // This is dummy data
            Random rand = new Random();
            // HourseSpentOnModules.Add(new ModuleHourse { Hours = rand.Next(5, 10), ModuleDate = DateTime.Now, ModuleName = "IT Project Management"});
            Modules.Add(new ModuleModel("WEDE5010", "Web Development(Introduction)", rand.Next(5, 10), rand.Next(5, 10), 17));
            Modules.Add(new ModuleModel("IPMA6212", "IT Project Management", rand.Next(5, 10), rand.Next(5, 10), 17));

            SelectedContact = Modules.FirstOrDefault();
        }
        public double selfStudyHoursPerWeek(double numberOfWeeksInTheSemester, DateTime startDateForTheFirstWeek)
        {
            // This varible will store number of days in semester weeks since that is what the user provides and not days
            double numberOfDaysInSemesterWeeks = numberOfWeeksInTheSemester * 7;
            double selfStudyHoursPerWeek = numberOfDaysInSemesterWeeks - (DateTime.Now - startDateForTheFirstWeek).TotalDays;

            selfStudyHoursPerWeek = selfStudyHoursPerWeek / 7;
            // Converting those days back to weeks
            return selfStudyHoursPerWeek;
        }
    }
}
