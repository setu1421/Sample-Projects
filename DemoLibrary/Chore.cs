using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        private IMessageSender _messageSender;
        private ILogger _logger;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(IMessageSender messageSender, ILogger logger)
        {
            _messageSender = messageSender;
            _logger = logger;
        }

        public void PerformWorked(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Perfored work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");
            _messageSender.sendEmail(Owner, $"The chore {ChoreName} is complete.");
        }

    }
}
