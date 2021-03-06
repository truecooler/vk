using VkNet.Abstractions;
using VkNet.Model.Attachments;
using VkNet.Utils.AntiCaptcha;

namespace VkNet.Utils
{
	/// <summary>
	/// Тексты для атрибута Obsolete
	/// </summary>
	public static class ObsoleteText
	{
		/// <summary>
		/// Параметры для капчи устаревшие.
		/// Необходимо реализовать интефейс ICaptchaSolver и внедрить через констуктор.
		/// </summary>
		public const string CaptchaNeeded = "Использование параметров капчи устаревший метод взаимодействия с Captcha."
											+ " Необходимо реализовать интерфейс "
											+ nameof(ICaptchaSolver)
											+ " и внедрить через конструктор."
											+ " Данный параметр будет удален в версии 2.0.0";

		/// <summary>
		/// Stats.Get
		/// </summary>
		public const string StatsGet = "Устаревший параметр, доступен только для версий меньше 5.86";

		/// <summary>
		/// Attachment
		/// </summary>
		public const string Attachment = "Данный тип данных устарел, используйте вместо него " + nameof(MediaAttachment);

		/// <summary>
		/// Validate
		/// </summary>
		public const string Validate = "Данный метод устарел, используйте перегрузку void Validate(string validateUrl);";

		/// <summary>
		/// Messages.GetConversations
		/// </summary>
		public const string MessageGet = Deprecated + nameof(IMessagesCategory.GetConversations);

		/// <summary>
		/// Messages.SearchConversations
		/// </summary>
		public const string MessageSearchDialogs = Deprecated + nameof(IMessagesCategory.SearchConversations);

		/// <summary>
		/// Messages.MessageMarkAsImportantDialog
		/// </summary>
		public const string MessageMarkAsImportantDialog = Deprecated + nameof(IMessagesCategory.MarkAsImportantConversation);

		/// <summary>
		/// Messages.MarkAsAnsweredDialog
		/// </summary>
		public const string MessageMarkAsAnsweredDialog = Deprecated + nameof(IMessagesCategory.MarkAsAnsweredConversation);

		/// <summary>
		/// Messages.DeleteConversation
		/// </summary>
		public const string MessageDeleteDialog = Deprecated + nameof(IMessagesCategory.DeleteConversation);

		/// <summary>
		/// Messages.DeleteConversation
		/// </summary>
		public const string MessageGetChatUsers = Deprecated + nameof(IMessagesCategory.GetConversationMembers);

		/// <summary>
		/// Messages.DeleteConversation
		/// </summary>
		public const string MessageGetById = Deprecated
											+ "GetById(IEnumerable<ulong> messageIds, IEnumerable<string> fields, ulong? previewLength = null, bool? extended = null, ulong? groupId = null)";

		private const string Deprecated =
			"Данный метод устарел и может быть отключён через некоторое время, пожалуйста, избегайте его использования. Используйте вместо него ";
	}
}