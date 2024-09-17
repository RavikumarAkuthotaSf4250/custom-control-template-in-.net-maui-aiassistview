using Syncfusion.Maui.AIAssistView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate
{
    public class CustomAssistViewChat : AssistViewChat
    {
        public CustomAssistViewChat(Syncfusion.Maui.AIAssistView.SfAIAssistView aIAssistView) : base(aIAssistView)
        {

        }
    }

    public class CustomAssistView : Syncfusion.Maui.AIAssistView.SfAIAssistView
    {
        public static readonly BindableProperty AssistChatViewProperty =
       BindableProperty.Create(nameof(AssistChatView), typeof(CustomAssistViewChat), typeof(CustomAssistView));

        public CustomAssistViewChat AssistChatView
        {
            get { return (CustomAssistViewChat)this.GetValue(AssistChatViewProperty); }
            set { this.SetValue(AssistChatViewProperty, value); }
        }
        protected override AssistViewChat CreateAssistChat()
        {
            AssistChatView = new CustomAssistViewChat(this);
            return AssistChatView;
        }
    }
}
