﻿using System;
using System.Collections.Generic;
using System.Text;
using WebZen.Network;

namespace WebZen.Util
{
    public class CommandHandler<TSession>
        where TSession : WZClient
    {
        private List<Command<TSession>> _commands;

        public CommandHandler()
        {
            _commands = new List<Command<TSession>>();
        }

        public CommandHandler<TSession> AddCommand(Command<TSession> command)
        {
            _commands.Add(command);
            return this;
        }

        public bool ProcessCommands(TSession source, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            foreach(var cmd in _commands)
            {
                if(cmd.Process(source, text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
