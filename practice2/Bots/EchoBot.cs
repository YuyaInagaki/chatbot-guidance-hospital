// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.15.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace practice2.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            //変数userに入力内容を代入する
            var user =turnContext.Activity.Text;

            //引数userで、入力内容をkeywordクラスに渡す
            //該当キーワードの番号がwordtoanswerに代入される
            int wordtoanswer = keyword.number(user);

            //該当キーワードの番号を、answerクラスに渡す
            //回答内容がreplyTextに代入される
            string replyText = answer.reply(wordtoanswer);

            //answerクラスから渡された回答内容を表示する
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "何か質問はございますか？\r\n (「受付」、「内科」のように、単語でご入力ください。)";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
