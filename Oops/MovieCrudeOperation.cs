using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
     public class MovieCrudeOperation
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }

        public MovieCrudeOperation(int id ,string name ,double ticketCost ,string producerName)
        {
            MovieId = id;
            MovieName = name;
            TicketCost = ticketCost;
            ProducerName = producerName;
        }
    }
}
