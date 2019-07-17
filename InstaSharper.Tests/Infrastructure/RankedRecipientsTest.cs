﻿using InstaSharper.Classes.ResponseWrappers;
using InstaSharper.Classes.ResponseWrappers.Direct;
using InstaSharper.Helpers;
using Newtonsoft.Json;
using Xunit;

namespace InstaSharper.Tests.Infrastructure
{
    [Trait("Category", "Infrastructure")]
    public class RankedRecipientsTest
    {
        private const string testJson = @"{
	""ranked_recipients"": [{
		""thread"": {
			""thread_id"": ""340282366841710300949128128698734336052"",
			""users"": [{
				""pk"": 1635609778,
				""username"": ""alr_knight"",
				""full_name"": ""Knight"",
				""is_private"": true,
				""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/18160263_191502241369975_8628660834639282176_a.jpg"",
				""profile_pic_id"": ""1503031289182596054_1635609778"",
				""is_verified"": false,
				""has_anonymous_profile_picture"": false
			}],
			""canonical"": true,
			""named"": false,
			""thread_title"": ""alr_knight"",
			""pending"": false,
			""thread_type"": ""private"",
			""viewer_id"": 1647718432
		}
	},
	{
		""thread"": {
			""thread_id"": ""340282366841710300949128137502093309895"",
			""users"": [{
				""pk"": 1970280312,
				""username"": ""ali.enzo2003"",
				""full_name"": ""Ali akbar jokar"",
				""is_private"": true,
				""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/22221360_117045119049079_2160406946895626240_n.jpg"",
				""profile_pic_id"": ""1619200818765710419_1970280312"",
				""is_verified"": false,
				""has_anonymous_profile_picture"": false
			}],
			""canonical"": true,
			""named"": false,
			""thread_title"": ""ali.enzo2003"",
			""pending"": false,
			""thread_type"": ""private"",
			""viewer_id"": 1647718432
		}
	},
	{
		""thread"": {
			""thread_id"": ""340282366841710300949128176621874302520"",
			""users"": [{
				""pk"": 1083654223,
				""username"": ""hootanht"",
				""full_name"": ""Hootan HT"",
				""is_private"": false,
				""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23421265_159622818107137_4034734531750658048_n.jpg"",
				""profile_pic_id"": ""1645900906660662890_1083654223"",
				""is_verified"": false,
				""has_anonymous_profile_picture"": false
			}],
			""canonical"": true,
			""named"": false,
			""thread_title"": ""hootanht"",
			""pending"": false,
			""thread_type"": ""private"",
			""viewer_id"": 1647718432
		}
	},
	{
		""user"": {
			""pk"": 1693680351,
			""username"": ""farnaz.mzh20"",
			""full_name"": ""Farnaz Mozhgani\u2764\ud83d\udc69\u200d\ud83d\udcbb \u0641\u0631\u0646\u0627\u0632"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23507176_1824437314513972_7352310486865543168_n.jpg"",
			""profile_pic_id"": ""1648949686839436879_1693680351"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1458048765,
			""username"": ""k.salamati"",
			""full_name"": ""kourosh salamati"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/22639548_744397965747635_470940668630401024_n.jpg"",
			""profile_pic_id"": ""1632272046988117813_1458048765"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 6288988520,
			""username"": ""miad.95879593"",
			""full_name"": ""miad.9587"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-mxp1-1.cdninstagram.com/t51.2885-19/11906329_960233084022564_1448528159_a.jpg"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": true,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 4700872585,
			""username"": ""amirali.life1997"",
			""full_name"": ""AMIR\u2764Ali"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/17332903_1356564087699739_7016453540491034624_a.jpg"",
			""profile_pic_id"": ""1472296969970953382_4700872585"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5614099053,
			""username"": ""ese5973"",
			""full_name"": ""ese"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/22159207_785051548363223_2327166594125398016_n.jpg"",
			""profile_pic_id"": ""1618638727914373626_5614099053"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5982940248,
			""username"": ""njd_mhmdmhmd"",
			""full_name"": ""\u0645\u062d\u0645\u062f \u0645\u062d\u0645\u062f \u0646\u0698\u0627\u062f"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-mxp1-1.cdninstagram.com/t51.2885-19/11906329_960233084022564_1448528159_a.jpg"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": true,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5677513936,
			""username"": ""nilooofar.re"",
			""full_name"": ""Nilooofar.re"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/19535013_1592941304080493_2890533623230889984_a.jpg"",
			""profile_pic_id"": ""1550741736980990941_5677513936"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5760970028,
			""username"": ""hsh_1993"",
			""full_name"": ""Hamed"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/20904862_116006422352140_4342957413729566720_a.jpg"",
			""profile_pic_id"": ""1585317022022179386_5760970028"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1044853632,
			""username"": ""atn_1993"",
			""full_name"": ""ATN"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/20184492_1907934619457872_8098029874465210368_a.jpg"",
			""profile_pic_id"": ""1563642139068355862_1044853632"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5717455301,
			""username"": ""8309kazeron"",
			""full_name"": ""Mohammad 8309kazeron"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/20479076_1391591357543894_7587999269659869184_a.jpg"",
			""profile_pic_id"": ""1571721063779623132_5717455301"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5678455485,
			""username"": ""mstfy662"",
			""full_name"": ""\u0645\u0635\u0637\u0641\u06cc"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-mxp1-1.cdninstagram.com/t51.2885-19/11906329_960233084022564_1448528159_a.jpg"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": true,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 4776464077,
			""username"": ""rwin.ak"",
			""full_name"": ""Rwin"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/20482199_713939045481173_4217748736115212288_a.jpg"",
			""profile_pic_id"": ""1572672385144738831_4776464077"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5561289395,
			""username"": ""sl_mayyy"",
			""full_name"": ""May"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23596152_306141666540750_2722580335870083072_n.jpg"",
			""profile_pic_id"": ""1648821021405184938_5561289395"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1665097951,
			""username"": ""madt1375"",
			""full_name"": ""\u0026\u0026matin\u0026\u0026\ud83d\udc49  Hakina Matata"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/19985838_1493714687346911_6311131670384738304_a.jpg"",
			""profile_pic_id"": ""1559723410019089129_1665097951"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 4172003794,
			""username"": ""bahareh_malekpour"",
			""full_name"": ""Bahareh"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/15057170_1247864588617496_449409619618430976_a.jpg"",
			""profile_pic_id"": ""1387121674563167477_4172003794"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1977441402,
			""username"": ""yousafriaz6"",
			""full_name"": ""Raja Yousaf Riaz"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/15625524_180356095772072_4276718035793870848_a.jpg"",
			""profile_pic_id"": ""1412858842651739747_1977441402"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 5360387201,
			""username"": ""ali.d2698"",
			""full_name"": ""Ali.D2698"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/18014047_117319205487829_6246258770654003200_a.jpg"",
			""profile_pic_id"": ""1497713138212502207_5360387201"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1263972398,
			""username"": ""unknow0.o"",
			""full_name"": ""farZin0da"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/18380268_383330582067431_7009299585264779264_a.jpg"",
			""profile_pic_id"": ""1513241329025427304_1263972398"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 3917685878,
			""username"": ""azin_zahabi"",
			""full_name"": ""azinzahabi"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/15534828_351621061879017_1749654446712815616_a.jpg"",
			""profile_pic_id"": ""1411707140427458562_3917685878"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1413636874,
			""username"": ""shahryar.ashtari"",
			""full_name"": ""shary famous"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/13388487_1727117410888429_587178138_a.jpg"",
			""profile_pic_id"": ""1281397482828254031_1413636874"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 890888289,
			""username"": ""ekhtad"",
			""full_name"": ""Mostafa Fakoori"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/1660619_178819552491836_2121922682_a.jpg"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1504001049,
			""username"": ""saber_marandi"",
			""full_name"": ""saber"",
			""is_private"": false,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23498266_143087636334813_3285276048702308352_n.jpg"",
			""profile_pic_id"": ""1646826333928264659_1504001049"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 3183327996,
			""username"": ""arash_doooonnnn"",
			""full_name"": ""arash \ud83d\udc97\ud83c\udd70\ud83d\udc97"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/17494568_1349544698446502_3670486137857638400_a.jpg"",
			""profile_pic_id"": ""1484548657205383055_3183327996"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 1177836418,
			""username"": ""bardiarya"",
			""full_name"": ""bardi.arya11"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/16229152_225821371157909_6646071452262989824_a.jpg"",
			""profile_pic_id"": ""1447028028453472548_1177836418"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 4069861549,
			""username"": ""shayan_behdinian"",
			""full_name"": ""Shayan Behdinian"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23279276_127835277902850_7169559637010677760_n.jpg"",
			""profile_pic_id"": ""1642356985624045981_4069861549"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 4051680176,
			""username"": ""aseman_sard"",
			""full_name"": ""Open Page:18/10/1395"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/23594227_377303179371808_132910790926663680_n.jpg"",
			""profile_pic_id"": ""1649597462907807731_4051680176"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	},
	{
		""user"": {
			""pk"": 315442394,
			""username"": ""arian_yeganegi"",
			""full_name"": ""Arian"",
			""is_private"": true,
			""profile_pic_url"": ""https://scontent-cdg2-1.cdninstagram.com/t51.2885-19/s150x150/21433649_146016685993808_8510183569073635328_a.jpg"",
			""profile_pic_id"": ""1600099344663909473_315442394"",
			""is_verified"": false,
			""has_anonymous_profile_picture"": false,
			""coeff_weight"": 0.0
		}
	}],
	""expires"": 7200,
	""filtered"": true,
	""request_id"": """",
	""rank_token"": ""69b1c5f4-91a3-4a07-b259-ff9b25ea52d1"",
	""status"": ""ok""
}";

        [Fact]
        public void ConvertRankedRecipientsTest()
        {
            var responseRecipients = JsonConvert.DeserializeObject<InstaRankedRecipientsResponse>(testJson);
            var fabric = ConvertersHelper.GetDefaultFabric();
            var result = fabric.GetRecipientsConverter(responseRecipients).Convert();
            Assert.NotNull(result);
        }
    }
}