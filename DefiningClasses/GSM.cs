namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;

    public class GSM
    {
        private static GSM iPhone4S;
        private string manufacturer;
        private string model;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }

        static GSM()
        {
            IPhone4S = new GSM("IPhone", "4S", 1999.99, "New Owner", new Battery("Bad", 5, 50, BatteryTypes.LiIon), new Display(), new List<Call>());
        }


        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer name should be longer than 0 and shorter than 20 symbols");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than 0 and shorter than 20 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (value == 0 || value > 2000)
                {
                    throw new ArgumentOutOfRangeException("Price should be > 0 and <= 2000");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value.Length == 0 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be longer than 0 and shorter than 30 symbols");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }

            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }

            private set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; }
        }


        public GSM(string manufacturer, string model)
            : this(manufacturer, model, 100.0, "Pesho", new Battery(), new Display(), new List<Call>())
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }


        public GSM(string manufacturer, string model, double price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }


        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\n" +
                                 "Model: {1}\n" +
                                 "Price: {2}\n" +
                                 "Owner: {3}\n" +
                                 "Battery: {4}\n" +
                                 "Display: {5}",
                                 this.Manufacturer, this.Model, this.Price, this.Owner,
                                 this.Battery.ToString(), this.Display.ToString());
        }


        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }


        public decimal CalculateTotalCallsPrice(decimal price)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            decimal totalPrice = totalDuration * price;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }
    }
}
