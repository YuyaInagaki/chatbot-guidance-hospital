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
            //�ϐ�user�ɓ��͓��e��������
            var user =turnContext.Activity.Text;

            //����user�ŁA���͓��e��keyword�N���X�ɓn��
            //�Y���L�[���[�h�̔ԍ���wordtoanswer�ɑ�������
            int wordtoanswer = keyword.number(user);

            //�Y���L�[���[�h�̔ԍ����Aanswer�N���X�ɓn��
            //�񓚓��e��replyText�ɑ�������
            string replyText = answer.reply(wordtoanswer);

            //answer�N���X����n���ꂽ�񓚓��e��\������
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "��������͂������܂����H\r\n (�u��t�v�A�u���ȁv�̂悤�ɁA�P��ł����͂��������B)";
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
