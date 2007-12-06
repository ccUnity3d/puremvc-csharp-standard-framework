﻿using System;

using org.puremvc.csharp.interfaces;
using org.puremvc.csharp.patterns.command;

namespace org.puremvc.csharp.patterns.command
{
    /**
	 * A MacroCommand subclass used by MacroCommandTest.
	 *
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTest MacroCommandTest
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestSub1Command MacroCommandTestSub1Command
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestSub2Command MacroCommandTestSub2Command
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestVO MacroCommandTestVO
	 */
    public class MacroCommandTestCommand : MacroCommand
    {
        /**
		 * Constructor.
		 */
		public MacroCommandTestCommand()
            : base()
		{ }
		
		/**
		 * Initialize the MacroCommandTestCommand by adding
		 * its 2 SubCommands.
		 */
		protected override void initializeMacroCommand()
		{
			addSubCommand(typeof(MacroCommandTestSub1Command));
			addSubCommand(typeof(MacroCommandTestSub2Command));
		}
    }
}
