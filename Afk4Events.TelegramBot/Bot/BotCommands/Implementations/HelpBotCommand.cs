using Telegram.Bot;
using Telegram.Bot.Types;

namespace Afk4Events.TelegramBot.Bot.BotCommands.Implementations
{
	/// <summary>
	/// The Help command handlers the /event-help command.
	/// This command should provide users with a list of bot capabilities, commands and their usage.
	/// </summary>
	public class HelpBotCommand : AbstractBotCommand
	{
		public HelpBotCommand(ITelegramBotClient client, Chat chat) : base(client, chat)
		{
		}

		protected override void Implementation()
		{
			_client.SendTextMessageAsync(
				_chat.Id,
				$"--- Afk4Events Help ---"
			);
		}
	}
}