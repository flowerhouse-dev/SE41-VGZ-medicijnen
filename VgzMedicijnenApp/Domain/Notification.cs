using System;

namespace VgzMedicijnenApp.Domain
{
    public class Notification
    {
        public DateTime Time { get; set; }

        public string SimpleTime
        {
            get
            {
                if (Time.Minute <= 9)
                    return Time.Hour + ":0" + Time.Minute;
                else
                    return Time.Hour + ":" + Time.Minute;
            }
        }

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
