namespace DefiningClasses
{
    using System;

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryTypes type;

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length < 0 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Model should be with less than 15 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value <= 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be less than 500!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be less than 50!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }

        }

        public BatteryTypes Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }

        public Battery() : this("Standard", 100.0, 10.0, BatteryTypes.LiIon)
        {

        }

        public Battery(string model) : this(model, 100.0, 10.0, BatteryTypes.LiIon)
        {

        }

        public Battery(string model, double idle, double talk, BatteryTypes type)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
                this.Model, this.HoursIdle, this.HoursTalk, this.Type);
        }
    }
}
