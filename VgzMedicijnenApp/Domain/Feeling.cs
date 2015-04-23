
using System;

namespace VgzMedicijnenApp.Domain
{
    public class Feeling
    {
        public string Title { get; set; }
        public Feelings Emotion { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }

        public string Image
        {
            get
            {
                switch (Emotion)
                {
                    case Feelings.Excited:
                        return "../Resources/Images/Emoji/Excited.png";
                    case Feelings.Happy:
                        return "../Resources/Images/Emoji/Happy.png";
                    case Feelings.Neutral:
                        return "../Resources/Images/Emoji/Neutral.png";
                    case Feelings.Sad:
                        return "../Resources/Images/Emoji/Sad.png";
                    case Feelings.Pain:
                        return "../Resources/Images/Emoji/Pain.png";
                }
                return "../Resources/Images/Emoji/Neutral.png";
            }
        }

        public string SimpleTime
        {
            get
            {
                if (Time.Minute <= 9)
                    return Time.DayOfWeek + " " + Time.Hour + ":0" + Time.Minute;
                else
                    return Time.DayOfWeek + " " + Time.Hour + ":" + Time.Minute;
            }
        }

        public Feeling(string title, Feelings emotion, string body)
        {
            Title = title;
            Emotion = emotion;
            Body = body;
            Time = DateTime.Now;
        }

        public enum Feelings
        {
            Excited,
            Happy,
            Neutral,
            Sad,
            Pain
        }
    }
}
