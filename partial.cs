using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    partial class Train
    {
        public void PrintTrainInfo()
        {
            Console.WriteLine($"Model: {model}, Max Speed: {maxSpeed}, Destination: {destination}, Price: {ticketPrice}, Carriages count: {carriagesCount}");
        }
    }
}
