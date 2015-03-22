using System;

namespace VgzMedicijnenApp.Domain
{
    public class Notification
    {
        public DateTime Time { get; set; }
        public Drug Drug { get; set; }
        public PartOfDay PartOfDay { get; set; }

        public Notification(DateTime time, Drug drug)
        {
            Time = time;
            Drug = drug;

            if (time.Hour < 12)
                PartOfDay = PartOfDay.Morning;
            else if (time.Hour < 17)
                PartOfDay = PartOfDay.Afternoon;
            else
                PartOfDay = PartOfDay.Evening;
        }
    }

    public enum PartOfDay
    {
        Morning,
        Afternoon,
        Evening
    }
}
