using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Factory
    {
        public static IPerson CreatePerson() => new Person();

        public static IChore CreateChore() => new Chore(CreateLogger(), CreateMessageSender());

        public static ILogger CreateLogger() => new Logger();

        public static IMessageSender CreateMessageSender() => new Texter();
    }
}
