   M S B A M L   `   `   `  ���� G  CTime Tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Time_TrackerTime_Tracker  I)clr-namespace:Time_Tracker.MVVM.ViewModelTime_Tracker.MVVM.ViewModel      Time_Tracker.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Time_Tracker     ?	viewmodel)clr-namespace:Time_Tracker.MVVM.ViewModel       � Title$  Time Tracker��$
��1000��$
��1400�����#36393f � DataContext /  )Time_Tracker.MVVM.ViewModel.MainViewModel  .���  � RowDefinitions ��  � ColumnDefinitions �� $	��350 ��� �� .+�� ���#2F3136 �� $
��auto ��� .+��� ���#36393f$��50��$	��0,2q�._�� $��15, 0q� �� �� $
��auto �.+��� $��ALL MY ADDED MODULES��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(��� $��
0,30, 0, 0q�$��1��
������ $��0q�   ModuleCardTheme#��[  ���� *	Modules+ �� SelectedItem �� *SelectedContact+�� $��1��$��1��.+��� ���#2F3136$��50��$��0,0,0,2 q�._�� $��15, 0q� �� �� $
��auto �.+��� $��SEMESTER��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(��� $��1�� �� Orientation$ 
Horizontal=�.+��� $��Today :��
�������$��0q�$��SemiBold"�$��Center=�$��12(��� 
�������$��0q�$��SemiBold"�$��Center=�$��12(����� *DateOfToday+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ Explicit=�� $��20, 10, 20, 20q�$
��auto��
������  �� �� ��  �� $
��auto ��� .+��� $��0��$��0��$"��First Week Of The Semester: ��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��0��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *StartDateForTheFirstWeek+$ OneWay=��� $��1��$��0��$��Number Of Weeks: ��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��1��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *NumOfWeeksUILabel+$ OneWay=��� $y�	Collapsed=�$��2��$��0��$��Remaing Number Of Weeks: ��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $y�	Collapsed=�$��1��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=�$��2��$��27��$��
164,26,0,0q�$��2��$	��Top=����� *#!RemaingNumberOfWeeksInTheSemester+$ OneWay=��� ���#2F3136$��50��$��0,2,0,2 q�._�� $��15, 0q� �� �� $
��auto �.+��� $��MODULE��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(��� ���#DEDEDE$��1��$��0q� �� CornerRadius$ 7�����#D55454$��30��$	��130��y��� *ShowSelectedModule+._��� 
������ $��0q�$��12(�$
��Bold"�
�������$��Delete Module������ *DeleteModuleCommand+�� ���#2F3136$��0,0,0,2 q�y��� *ShowSelectedModule+._�� $��20, 0, 20, 20q�$
��auto��
������  �� �� �� �� �� �� ��  �� $
��auto ��� .+��� $��0��$��0��$��Name:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��0��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *SelectedContact.Name+�� $��1��$��0��$��Code:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��1��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *SelectedContact.Code+�� $��2��$��0��$��Number Of Credits:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��2��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *!SelectedContact.NumberOfCredits+�� $��3��$��0��$��Class Hours Per Week:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��3��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *#!SelectedContact.ClassHoursPerWeek+�� $��4��$��0��$��Created:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��4��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *SelectedContact.CreatedAt+�� $��5��$��0��$��Self Study Per Week:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��5��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *)'SelectedContact.HoursOfSelfStudyPerWeek+�� $��6��$��0��$"��Hours Of Self-Study Remaing:��$��0q�$��SemiBold"�$
��12.5(�
�������$��Center=��� $��6��$��2��$��20, 5q�$��SemiBold"�$
��12.5(�
�������$��Center=����� *HoursOfSelfStudyRemaing+$ OneWay=�$ PropertyChanged=��� $��50�����#2F3136$��0,0,0,2 q�._�� $��15, 0q� �� �� $
��auto �.+��� $��HOURS SPENT ON MODULES ��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(�� $��13,30, 13, 10q� �� $
��auto ��� $��15 ��� .+��� $	��200��.+��� $
��Date��$
��Bold"�$��15(�$
��6, 0q�
�������&   System.Windows.Controls.Calendar  $
��Left=�$	��200��$��8q�
�������
�������	   SelectedDate	 �� *HourseSpentOnModules_Date+
   DisplayDate
 �� *HourseSpentOnModules_Date+� $	��200��$��2��$	��Top=� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��Module Name��$��0,0,0,8q�$
��Bold"�$��15(�$��0q�
��������� $��1��$��30�� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$
 Name�� �� SelectedIndex$ 0��$��0q�$��0, 10q� �� SelectedValue �� *HourseSpentOnModules_Selected+���� *	Modules+�� $��2��$��0,0,0,8q�$��Hours Spent On The Module��$
��Bold"�$��15(�$��0q�
��������� $��3�����#DEDEDE$��0q�$ 3�����#2F3136$��35��._��� $��0q�$��14, 0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *HourseSpentOnModules_Hours+$ TwoWay=�$ PropertyChanged=��� $��4��$��Bottom=����#DEDEDE$��0q�$ 13�����#6CA468$��35��._��� 
������ $��0q�$��12(�$
��Bold"�
�������$	��Add������ *HourseSpentOnModulesCommand+�� $��50�����#2F3136$��0,2,0,2 q�._�� $��15, 0q� �� �� $
��auto �.+��� $��MODULES AND HOURS��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(��� $��1��$ 
Horizontal=�.+��� $��Hours :��
�������$��0q�$��SemiBold"�$��Center=�$��12(��� 
�������$��0q�$��SemiBold"�$��Center=�$��12(����� *SumOfHourseSpentOnModules+$ OneWay=�$ Explicit=��� $	��200��
������ $��0q�  HourseSpentOnModuleTheme#��[ ���� *HourseSpentOnModules+�� $��2�����#2F3136.+��� $��80��$��1��$ 
Horizontal=����#292B2F.+��� $ 25��$��30��$��30�����#3bff6f$��30,0,0,0q��� $��Center=�.+��� $
��5, 0q�$��14(�$
��Bold"�
����������� *UserNameAndSurname+�� ���#36393f$��50��$	��0,2q�._�� $��15, 0q� �� �� $
��auto �.+��� $ ��UPDATE SEMESTER INFOMATION��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(�� $��24,30, 30, 30q� �� $
��auto ��� $��15 ��� .+��� $	��200��.+��� $��Semester Start Date��$
��Bold"�$��15(�$
��6, 0q�
�������  $
��Left=�$	��200��$��8q�
�������
�������	 �� *SemesterStartDate+
 �� *SemesterStartDate+� $	��200��$��2��$	��Top=� �� $
��auto ��� $
��auto ��� .+��� $��Number Of Semeter Weeks��$
��Bold"�$��15(�$��0q�
��������� $��1�����#DEDEDE$��0q�$ 3�����#393B40$��45��$��0, 11, 0, 14q�._��� $��10, 0, 0, 0q�$��0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *
NumOfWeeks+$ TwoWay=�$ PropertyChanged=��� $��2��$��Bottom=����#DEDEDE$��0q�$ 13�����#6CA468$��35��._��� 
������ $��0q�$��12(�$
��Bold"�
�������$��Update Semester Info������ *SendNumOfWeeksCommand+�� ���#36393f$��50��$	��0,2q�._�� $��15, 0q� �� �� $
��auto �.+��� $��ADD A MODULE��
�������$��0q�$
��Bold"�$��Center=�$
��Left=�$��14(�� $��2��.+�� $��30, 20, 30, 10q� �� �� $��60 �.+��� $��Stretch=�.+��� $��Module Code��$
��Bold"�$��15(�$��0, 0, 10, 0q�
��������� ���#DEDEDE$��0q�$ 3�����#393B40$��50��$��0, 10, 0, 20q�._��� $��10, 0, 0, 0q�$��0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *
ModuleCode+$ TwoWay=�$ 	LostFocus=��� $��Module Name��$
��Bold"�$��15(�$��0, 0, 10, 0q�
��������� ���#DEDEDE$��0q�$ 3�����#393B40$��50��$��0, 10, 0, 20q�._��� $��10, 0, 0, 0q�$��0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *
ModuleName+$ TwoWay=�$ 	LostFocus=��  �� �� $	��15  ��� .+��� $ Vertical=�.+��� $��Number Of Credits��$
��Bold"�$��15(�$��0, 0, 10, 0q�
��������� ���#DEDEDE$��0q�$ 3�����#393B40$��50��$��0, 10, 0, 20q�._��� $��10, 0, 0, 0q�$��0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *ModuleNumberOfCredits+$ TwoWay=�$ 	LostFocus=��� $��2��.+��� $��Class Hours Per Week��$
��Bold"�$��15(�$��0, 0, 10, 0q�
��������� ���#DEDEDE$��0q�$ 3�����#393B40$��50��$��0, 10, 0, 20q�._��� $��10, 0, 0, 0q�$��0q�
������ $��Center=�$��14(�$��Stretch=�
����������� *ModuleClassHoursPerWeek+$ TwoWay=�$ 	LostFocus=��� $��1��$��2��$��Right=�$ 
Horizontal=�$��Center=�.+��� ���#DEDEDE$��0q�$ 3�����#6CA468$��35��$	��120��._��� 
������ $��0q�$��12(�$
��Bold"�
�������$��
Add Module������ *SendCommand+