using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice2.Bots
{
    public class answer

    {
        public static string reply (int b)
            //bには該当キーワードの番号が格納されている
        {

            //URLリストの作成
            string URL_naika, URL_geka, URL_seikeigeka, URL_gannka, URL_zibi, URL_kokyuu, URL_zyunnkann, URL_syouka, URL_hinyou, URL_hihu, URL_syouni, URL_seishinn, URL_sika, URL_sinnkeinaika,
                   URL_ketuekinaika, URL_naibunpitu, URL_nougeka, URL_keiseigeka, URL_nousinnkeigeka, URL_kyoubugeka, URL_sinzoukekkann, URL_koumonn, URL_zinnzou, URL_kougennbyou, URL_map, URL_access, URL_gairai, URL_kennsa,
                   URL_kennsinn, URL_uketuke, URL_mennkai, URL_covid, URL_homepage, URL_sannhuzin, URL_yobousessyu, URL_innfuru, URL_covidwakutin, URL_otahuku;

            //URL　内科
            URL_naika = "https://www.etlab-sophia.net/";
            //URL　外科
            URL_geka = "https://www.etlab-sophia.net/";
            //URL  整形外科
            URL_seikeigeka = "https://www.etlab-sophia.net/";
            //URL　眼科
            URL_gannka = "https://www.etlab-sophia.net/";
            //URL　耳鼻咽喉科
            URL_zibi = "https://www.etlab-sophia.net/";
            //URL　呼吸器科
            URL_kokyuu = "https://www.etlab-sophia.net/";
            //URL　循環器科
            URL_zyunnkann = "https://www.etlab-sophia.net/";
            //URL　消化器科
            URL_syouka = "https://www.etlab-sophia.net/";
            //URL　泌尿器科
            URL_hinyou = "https://www.etlab-sophia.net/";
            //URL　皮膚科
            URL_hihu = "https://www.etlab-sophia.net/";
            //URL　小児科
            URL_syouni = "https://www.etlab-sophia.net/";
            //URL　精神科
            URL_seishinn = "https://www.etlab-sophia.net/";
            //URL　歯科
            URL_sika = "https://www.etlab-sophia.net/";
            //URL　神経内科
            URL_sinnkeinaika = "https://www.etlab-sophia.net/";
            //URL　血液内科
            URL_ketuekinaika = "https://www.etlab-sophia.net/";
            //URL　内分泌内科
            URL_naibunpitu = "https://www.etlab-sophia.net/";
            //URL　脳外科
            URL_nougeka = "https://www.etlab-sophia.net/";
            //URL　形成外科
            URL_keiseigeka = "https://www.etlab-sophia.net/";
            //URL　脳神経外科
            URL_nousinnkeigeka = "https://www.etlab-sophia.net/";
            //URL　胸部外科
            URL_kyoubugeka = "https://www.etlab-sophia.net/";
            //URL　心臓血管外科
            URL_sinzoukekkann = "https://www.etlab-sophia.net/";
            //URL　肛門科
            URL_koumonn = "https://www.etlab-sophia.net/";
            //URL　腎臓内科
            URL_zinnzou = "https://www.etlab-sophia.net/";
            //URL　膠原病内科
            URL_kougennbyou = "https://www.etlab-sophia.net/";
            //URL　マップ
            URL_map = "https://www.etlab-sophia.net/";
            //URL　アクセス
            URL_access = "https://www.etlab-sophia.net/";
            //URL　外来受診
            URL_gairai = "https://www.etlab-sophia.net/";
            //URL　検査
            URL_kennsa = "https://www.etlab-sophia.net/";
            //URL　検診
            URL_kennsinn = "https://www.etlab-sophia.net/";
            //URL　受付時間・休診日
            URL_uketuke = "https://www.etlab-sophia.net/";
            //URL　面会
            URL_mennkai = "https://www.etlab-sophia.net/";
            //URL　コロナウイルス
            URL_covid = "https://www.etlab-sophia.net/";
            //URL　ホームページ
            URL_homepage = "https://www.etlab-sophia.net/";
            //URL　産婦人科
            URL_sannhuzin = "https://www.etlab-sophia.net/";
            //URL　予防接種
            URL_yobousessyu = "https://www.etlab-sophia.net/";
            //URL　インフルエンザ
            URL_innfuru = "https://www.etlab-sophia.net/";
            //URL　コロナワクチン
            URL_covidwakutin = "https://www.etlab-sophia.net/";
            //URL　おたふく風邪
            URL_otahuku = "https://www.etlab-sophia.net/";





            //回答リストの作成
            string[] answer = new string[100];

            //該当なし
            answer[0] = $"問いかけていただいた方。その言葉、勉強不足でした。他の単語をお願いできますか？";
            //診療科
            answer[1] = $"下記URLをタップしていただくと、内科の詳細をご覧になれます。↓↓  {URL_naika}";
            answer[2] = $"下記URLをタップしていただくと、外科の詳細をご覧になれます。↓↓  {URL_geka}";
            answer[3] = $"下記URLをタップしていただくと、整形外科の詳細をご覧になれます。↓↓  {URL_seikeigeka}";
            answer[4] = $"下記URLをタップしていただくと、眼科の詳細をご覧になれます。↓↓  {URL_gannka}";
            answer[5] = $"下記URLをタップしていただくと、耳鼻咽喉科の詳細をご覧になれます。↓↓  {URL_zibi}";
            answer[6] = $"下記URLをタップしていただくと、呼吸器科の詳細をご覧になれます。↓↓  {URL_kokyuu}";
            answer[7] = $"下記URLをタップしていただくと、循環器科の詳細をご覧になれます。↓↓  {URL_zyunnkann}";
            answer[8] = $"下記URLをタップしていただくと、消化器科の詳細をご覧になれます。↓↓  {URL_syouka}";
            answer[9] = $"下記URLをタップしていただくと、泌尿器科の詳細をご覧になれます。↓↓  {URL_hinyou}";
            answer[10] = $"下記URLをタップしていただくと、皮膚科の詳細をご覧になれます。↓↓  {URL_hihu}";
            answer[11] = $"下記URLをタップしていただくと、小児科の詳細をご覧になれます。↓↓  {URL_syouni}";
            answer[12] = $"下記URLをタップしていただくと、精神科の詳細をご覧になれます。↓↓  {URL_seishinn}";
            answer[13] = $"下記URLをタップしていただくと、歯科の詳細をご覧になれます。↓↓  {URL_sika}";
            answer[14] = $"下記URLをタップしていただくと、神経内科の詳細をご覧になれます。↓↓  {URL_sinnkeinaika}";
            answer[15] = $"下記URLをタップしていただくと、血液内科の詳細をご覧になれます。↓↓  {URL_ketuekinaika}";
            answer[16] = $"下記URLをタップしていただくと、内分泌内科の詳細をご覧になれます。↓↓  {URL_naibunpitu}";
            answer[17] = $"下記URLをタップしていただくと、脳外科の詳細をご覧になれます。↓↓  {URL_nougeka}";
            answer[18] = $"下記URLをタップしていただくと、形成外科の詳細をご覧になれます。↓↓  {URL_keiseigeka}";
            answer[19] = $"下記URLをタップしていただくと、脳神経外科の詳細をご覧になれます。↓↓  {URL_nousinnkeigeka}";
            answer[20] = $"下記URLをタップしていただくと、胸部外科の詳細をご覧になれます。↓↓  {URL_kyoubugeka}";
            answer[21] = $"下記URLをタップしていただくと、心臓血管外科の詳細をご覧になれます。↓↓  {URL_sinzoukekkann}";
            answer[22] = $"下記URLをタップしていただくと、肛門科の詳細をご覧になれます。↓↓  {URL_koumonn}";
            answer[23] = $"下記URLをタップしていただくと、腎臓内科の詳細をご覧になれます。↓↓  {URL_zinnzou}";
            answer[24] = $"下記URLをタップしていただくと、膠原病内科の詳細をご覧になれます。↓↓  {URL_kougennbyou}";
            //アクセス
            answer[25] = $"受付は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[26] = $"薬局は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[27] = $"院外薬局は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[28] = $"会計は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[29] = $"トイレは〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[30] = $"公衆電話は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[31] = $"喫煙所は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[32] = $"売店は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[33] = $"食堂は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[34] = $"喫茶室は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[35] = $"休憩室は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[36] = $"花屋は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[37] = $"理容室は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[38] = $"銀行は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[39] = $"郵便局は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[40] = $"コンビニエンスストアは〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[41] = $"〇〇号室は〇棟〇階にございます。下記URLをタップしていただくと 、院内マップをご覧になれます。↓↓  {URL_map}";
            //アクセス
            answer[42] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            answer[43] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            answer[44] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            answer[45] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            answer[46] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            answer[47] = $"下記URLをタップしていただくと、当院へのアクセス方法をご覧になれます。↓↓ {URL_access}";
            //マップ
            answer[48] = $"下記URLをタップしていただくと、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[49] = $"下記URLをタップしていただくと、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[50] = $"下記URLをタップしていただくと、院内マップをご覧になれます。↓↓  {URL_map}";
            answer[51] = $"下記URLをタップしていただくと、院内マップをご覧になれます。↓↓  {URL_map}";

            //外来
            answer[52] = $"下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_gairai}";
            answer[53] = $"下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_gairai}";
            answer[54] = $"下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_gairai}";
            answer[55] = $"下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_gairai}";
            answer[56] = $"下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_gairai}";

            //検査
            answer[57] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[58] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[59] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[60] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[61] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[62] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";
            answer[63] = $"下記URLをタップしていただくと、検査の詳細をご覧になれます。↓↓  {URL_kennsa}";

            //検診
            answer[64] = $"下記URLをタップしていただくと、健康診断・人間ドッグ等の詳細をご覧になれます。↓↓  {URL_kennsinn}";
            answer[65] = $"下記URLをタップしていただくと、健康診断・人間ドッグ等の詳細をご覧になれます。↓↓  {URL_kennsinn}";
            answer[66] = $"下記URLをタップしていただくと、健康診断・人間ドッグ等の詳細をご覧になれます。↓↓  {URL_kennsinn}";

            //受付
            answer[67] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[68] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[69] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[70] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[71] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[72] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[73] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[74] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";
            answer[75] = $"月～金　〇〇時から受付しています。（休診日は〇・〇曜日） 下記URLをタップしていただくと、外来受診の詳細をご覧になれます。↓↓  {URL_uketuke}";

            //面会
            answer[76] = $"下記URLをタップしていただくと、 面会の詳細をご覧になれます。↓↓   {URL_mennkai}";
            answer[77] = $"下記URLをタップしていただくと、 面会の詳細をご覧になれます。↓↓   {URL_mennkai}";
            answer[78] = $"下記URLをタップしていただくと、 面会の詳細をご覧になれます。↓↓   {URL_mennkai}";

            //電話、住所
            answer[79] = $"〒○○○-○○○○ 　 〇〇県〇〇市〇〇1 - 1 - 1 　℡○○○-○○○-○○○○";
            answer[80] = $"〒○○○-○○○○ 　 〇〇県〇〇市〇〇1 - 1 - 1 　℡○○○-○○○-○○○○";

            //コロナウイルス
            answer[81] = $"下記URLをタップしていただくと、 新型コロナウイルスに関するお知らせをご覧になれます。↓↓   {URL_covid}";
            answer[82] = $"下記URLをタップしていただくと、 新型コロナウイルスに関するお知らせをご覧になれます。↓↓   {URL_covid}";
            answer[83] = $"下記URLをタップしていただくと、 新型コロナウイルスに関するお知らせをご覧になれます。↓↓   {URL_covid}";

            //ホームページ
            answer[84] = $"下記URLをタップしていただくと、 当院のホームページをご覧になれます。↓↓   {URL_homepage}";

            //産婦人科
            answer[85] = $"下記URLをタップしていただくと、 産婦人科の詳細をご覧になれます。↓↓   {URL_sannhuzin}";
            answer[86] = $"下記URLをタップしていただくと、 産婦人科の詳細をご覧になれます。↓↓   {URL_sannhuzin}";
            answer[87] = $"下記URLをタップしていただくと、 産婦人科の詳細をご覧になれます。↓↓   {URL_sannhuzin}";

            //医療保険
            answer[88] = $"<医療保険の給付手続きについて> 書類をお持ちの方は、○〇場所〇〇専用窓口にてご提出ください。下記URLをタップしていただくと、 院内マップをご覧になれます。↓↓  {URL_map}";
            answer[89] = $"<医療保険の給付手続きについて> 書類をお持ちの方は、○〇場所〇〇専用窓口にてご提出ください。下記URLをタップしていただくと、 院内マップをご覧になれます。↓↓  {URL_map}";

            //予防接種
            answer[90] = $"下記URLをタップしていただくと、 予防接種の詳細をご覧になれます。↓↓   {URL_yobousessyu}";

            //インフルエンザ
            answer[91] = $"下記URLをタップしていただくと、 予防接種(インフルエンザ)の詳細をご覧になれます。↓↓   {URL_innfuru}";
            answer[92] = $"下記URLをタップしていただくと、 予防接種(インフルエンザ)の詳細をご覧になれます。↓↓   {URL_innfuru}";

            //コロナワクチン
            answer[93] = $"下記URLをタップしていただくと、 予防接種(コロナウイルス)の詳細をご覧になれます。↓↓   {URL_covidwakutin}";
            answer[94] = $"下記URLをタップしていただくと、 予防接種(コロナウイルス)の詳細をご覧になれます。↓↓   {URL_covidwakutin}";

            //おたふく風邪
            answer[95] = $"下記URLをタップしていただくと、 予防接種(おたふく風邪)の詳細をご覧になれます。↓↓   {URL_otahuku}";
            answer[96] = $"下記URLをタップしていただくと、 予防接種(おたふく風邪)の詳細をご覧になれます。↓↓   {URL_otahuku}";
            answer[97] = $"下記URLをタップしていただくと、 予防接種(おたふく風邪)の詳細をご覧になれます。↓↓   {URL_otahuku}";


            //回答内容をanswertobotに代入する
            string answertobot;
            answertobot = answer[b];

            //回答内容をEchoBotクラスに返す
            return answertobot;

            


        }
    }
}
