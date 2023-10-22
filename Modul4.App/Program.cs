using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul4;
namespace Modul4.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train_014C = new Train();
            Train train_015C = new Train("015C", 270);
            train_015C.GetMaxSpeed();
            train_015C.GetModel();
            train_015C.GetCarriagesCount();
            train_015C.GetDestination();
            train_015C.GetTicketPrice();
            train_015C.PrintTrainInfo();
            train_015C.SetModel("015Ca");
            train_015C.SetCarriagesCount(21);
            train_015C.SetDestination("Almaty");
            train_015C.SetTicketPrice(3000);
            double price = 3000;
            train_015C.UpdateTicketPrice(ref price);
            train_015C.SetMaxSpeed(300);
            train_015C.PrintTrainInfo();
            Train train_016T = new Train("016T", 350, 20, "Stepnogorsk", 13000);
            train_016T.PrintTrainInfo();
            Console.WriteLine("Total trains:{0}",Train.GetTotalTrains());
            Train.CreateTrainsArray();
            Console.WriteLine("Total trains:{0}", Train.GetTotalTrains());
            string model;
            Console.WriteLine("Write model:");
            model= Console.ReadLine();
            int maxSpeed;
            do {
                try
                {
                    Console.WriteLine("Write maxSpeed:");
                    maxSpeed = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch { }
            } while (true);
            int carriagesCount;
            do
            {
                try
                {
                    Console.WriteLine("Write carriagesCount:");
                    carriagesCount = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch { }
            } while (true);
            string destination;
            Console.WriteLine("Write destination:");
            destination =Console.ReadLine();
            double ticketPrice;
            do{
                try{
                    Console.WriteLine("Write ticketPrice:");
                    ticketPrice = Convert.ToDouble(Console.ReadLine());
                    break;
                }catch { }
            } while (true);
            Train train= new Train(model, maxSpeed, carriagesCount, destination, ticketPrice);
            train.PrintTrainInfo();
            
            Console.WriteLine("where are you going:");
            destination=Console.ReadLine();
            List<Train> trains=Train.GetTrainDestination(destination);
            try
            {
                if (trains != null)
                {
                    trains.ForEach(trainn =>
                    {

                        trainn.PrintTrainInfo();
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
