using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZooAssignment
{
    public class Ticket
    {
        [JsonProperty("Статус билета")]
        public string Status { get; set; }
        [JsonProperty("Дата покупки билета ")]
        public DateTime DateTime { get; set; }
        public Ticket()
        {

        }
        public Ticket(string status, DateTime dateTime)
        {
            Status = status;
            DateTime = dateTime;
        }
    }
}
