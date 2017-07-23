﻿using System;
using System.Collections.Generic;
using System.Linq;
using ScriptingMod.Managers;
using ScriptingMod.ScriptEngines;

namespace ScriptingMod.Commands
{
    public class ResetJs : ConsoleCmdAbstract
    {
        public override string[] GetCommands()
        {
            return new string[] { "dj-reset-js" };
        }

        public override string GetDescription()
        {
            return "Clears the JavaScript engine from all variables and loaded modules.";
        }

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            try
            {
                JsEngine.Instance.Reset();
                SdtdConsole.Instance.Output("JavaScript engine was reset.");
            }
            catch (Exception ex)
            {
                CommandManager.HandleCommandException(ex);
            }
        }
    }
}
