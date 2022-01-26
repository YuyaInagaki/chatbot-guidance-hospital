using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice2.Bots
{
    public class keyword
    {
        public static int number(string a)　
            //aには入力内容が代入されている
        {
            //キーワードリストの作成
            string[] keyword = new string[100];
            //該当なし
            keyword[0] = "該当なし";
            //診療科
            keyword[1] = "内科";
            keyword[2] = "外科";
            keyword[3] = "整形外科";
            keyword[4] = "眼科";
            keyword[5] = "耳鼻咽喉科";
            keyword[6] = "呼吸器科";
            keyword[7] = "循環器科";
            keyword[8] = "消化器科";
            keyword[9] = "泌尿器科";
            keyword[10] = "皮膚科";
            keyword[11] = "小児科";
            keyword[12] = "精神科";
            keyword[13] = "歯科";
            keyword[14] = "神経内科";
            keyword[15] = "血液内科";
            keyword[16] = "内分泌内科";
            keyword[17] = "脳外科";
            keyword[18] = "形成外科";
            keyword[19] = "脳神経外科";
            keyword[20] = "胸部外科";
            keyword[21] = "心臓血管外科";
            keyword[22] = "肛門科";
            keyword[23] = "腎臓内科";
            keyword[24] = "膠原病内科";
            //場所
            keyword[25] = "受付";
            keyword[26] = "薬局";
            keyword[27] = "院外薬局";
            keyword[28] = "会計";
            keyword[29] = "トイレ";
            keyword[30] = "公衆電話";
            keyword[31] = "喫煙所";
            keyword[32] = "売店";
            keyword[33] = "食堂";
            keyword[34] = "喫茶室";
            keyword[35] = "休憩室";
            keyword[36] = "花屋";
            keyword[37] = "理容室";
            keyword[38] = "銀行";
            keyword[39] = "郵便局";
            keyword[40] = "コンビニ";
            keyword[41] = "〇〇号室";
            //アクセス
            keyword[42] = "アクセス";
            keyword[43] = "タクシー";
            keyword[44] = "バス";
            keyword[45] = "電車";
            keyword[46] = "車";
            keyword[47] = "駐車場";
            //マップ
            keyword[48] = "院内マップ";
            keyword[49] = "マップ";
            keyword[50] = "案内図";
            keyword[51] = "地図";
            //外来
            keyword[52] = "診療";
            keyword[53] = "予約";
            keyword[54] = "初診";
            keyword[55] = "発熱";
            keyword[56] = "外来";
            //検査
            keyword[57] = "検査";
            keyword[58] = "MRI";
            keyword[59] = "MRI検査";
            keyword[60] = "PET";
            keyword[61] = "PET検査";
            keyword[62] = "CT";
            keyword[63] = "CT検査";
            //検診
            keyword[64] = "健康診断";
            keyword[65] = "人間ドッグ";
            keyword[66] = "検診";
            //受付
            keyword[67] = "受付時間";
            keyword[68] = "休診日";
            keyword[69] = "月曜日";
            keyword[70] = "火曜日";
            keyword[71] = "水曜日";
            keyword[72] = "木曜日";
            keyword[73] = "金曜日";
            keyword[74] = "土曜日";
            keyword[75] = "日曜日";
            //面会
            keyword[76] = "面会";
            keyword[77] = "お見舞い";
            keyword[78] = "入院";
            //電話
            keyword[79] = "電話";
            keyword[80] = "住所";
            //コロナ
            keyword[81] = "コロナ";
            keyword[82] = "コロナウイルス";
            keyword[83] = "新型コロナウイルス";
            //ホームページ
            keyword[84] = "ホームページ";
            //産婦人科
            keyword[85] = "産婦人科";
            keyword[86] = "中絶";
            keyword[87] = "避妊";
            //医療保険
            keyword[88] = "医療保険";
            keyword[89] = "給付手続き";
            //予防接種
            keyword[90] = "予防接種";
            //インフルエンザ
            keyword[91] = "インフルエンザ";
            keyword[92] = "インフル";
            //コロナワクチン
            keyword[93] = "コロナワクチン";
            keyword[94] = "ワクチン";
            //おたふく
            keyword[95] = "おたふく風邪";
            keyword[96] = "おたふく";
            keyword[97] = "おたふくかぜ";


            //該当キーワードの番号をkeynumberに格納する
            int keynumber = 0;
            for (int i = 1; i < keyword.Length; i++)
            {
                if (a == keyword[i])
                {
                    keynumber = keynumber + i;
                }
                else
                {
                    keynumber = keynumber + 0;
                }
            }

            //該当キーワードの番号をEchoBotクラスに返す
            return keynumber;


        }
    }
}
