using System.Collections.Generic;
using System.ComponentModel;

namespace KursWork
{
    public class Departament
    {
        [DisplayName("Отдел")]
        public string Name { get; set; }
        [DisplayName("Максимальное кол-во сотрудников на обеде")]
        public int MaxCount { get; set; }
    }

    public class Time
    {
        [DisplayName("Часы обеда")]
        public string Period { get; set; }
        [DisplayName("Баллы комфорта")]
        public int Points { get; set; }
    }

    public class Employee
    {
        [DisplayName("Имя")]
        public string Name { get; set; }
        [Browsable(false)]
        public Departament Departament { get; set; }
        [DisplayName("Отдел")]
        public string DepName { get { return Departament != null ? Departament.Name : string.Empty; } }
        [DisplayName("Пол")]
        public char Sex { get; set; }
    }

    public class Plan
    {
        [Browsable(false)]
        public Employee Employee { get; set; }
        [DisplayName("Сотрудник")]
        public string EmpName { get { return Employee != null ? Employee.Name : string.Empty; } }
        [Browsable(false)]
        public Departament Departament { get; set; }
        [DisplayName("Отдел")]
        public string DepName { get { return Departament != null ? Departament.Name : string.Empty; } }
        [Browsable(false)]
        public Time Time { get; set; }
        [DisplayName("Часы обеда")]
        public string TimePeriod { get { return Time != null ? Time.Period : string.Empty; } }
    }

    public class PlanDep
    {
        public PlanDep() { Counts = new List<int>(); }
        [DisplayName("Отдел")]
        public string DepName { get; set; }
        [Browsable(false)]
        public List<int> Counts { get; set; }
        [DisplayName("Ограничение")]
        public int DepMax { get; set; }
        public int Count1 { get { return Counts[0]; } }
        public int Count2 { get { return Counts[1]; } }
        public int Count3 { get { return Counts[2]; } }
    }

    public class PlanMF
    {
        [Browsable(false)]
        public Time Time { get; set; }
        [DisplayName("Часы обеда")]
        public string TimePeriod { get { return Time != null ? Time.Period : string.Empty; } }
        [DisplayName("Кол-во мужчин")]
        public int CountM { get; set; }
        [DisplayName("Кол-во женщин")]
        public int CountF { get; set; }
    }

}
