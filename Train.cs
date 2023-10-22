using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    public partial class Train
    {
        private string model;
        private int maxSpeed;
        private int carriagesCount;
        private string destination;
        private double ticketPrice;

        public static int totalTrains;
        public static string railwayCompany = "Dimomix";
        private static List<Train> trains = new List<Train>();


        public Train()
        {
            totalTrains++;
            trains.Add(this);
        }

        public Train(string model, int maxSpeed)
        {
            this.model = model;
            this.maxSpeed = maxSpeed;
            totalTrains++;
            trains.Add(this);

        }

        public Train(string model, int maxSpeed, int carriagesCount, string destination, double ticketPrice)
        {
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.carriagesCount = carriagesCount;
            this.destination = destination;
            this.ticketPrice = ticketPrice;
            totalTrains++;
            trains.Add(this);
        }
        static Train()
        {
            totalTrains = 0;
        }
        public static List<Train> GetAllInstances()
        {
            return trains;
        }
        public static List<Train> GetTrainDestination(string destination)
        {
            return trains.Where(train => train.destination == destination).ToList();
        }

        public string GetModel() => model;
        public void SetModel(string value) => model = value;
        public int GetMaxSpeed() => maxSpeed;
        public void SetMaxSpeed(int value) => maxSpeed = value;
        public int GetCarriagesCount() => carriagesCount;
        public void SetCarriagesCount(int value) => carriagesCount = value;
        public string GetDestination() => destination;
        public void SetDestination(string value) => destination = value;
        public double GetTicketPrice() => ticketPrice;
        public void SetTicketPrice(double value) => ticketPrice = value;
        public void UpdateTicketPrice(ref double newPrice)
        {
            ticketPrice = newPrice;
        }
        public static Train[] CreateTrainsArray()
        {
            Train train_015T = new Train();
            train_015T.model = "015T";
            train_015T.maxSpeed = 200;
            train_015T.destination = "Kokshetau";
            return new Train[]
            {
            train_015T,
            new Train("033C", 250, 10, "Astana", 15000),
            new Train("051X", 300, 15, "Karaganda", 10000),
            new Train("105T", 350, 20, "Shimkent", 8000),
            new Train("113C", 270)
            };
        }
        public static int GetTotalTrains()
        {
            return totalTrains;
        }
    }

    
}
