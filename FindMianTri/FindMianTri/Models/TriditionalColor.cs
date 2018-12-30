﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMianTri.Models
{
    class TriditionalColor
    {
        public TridColor[] InitTriditionalColors()
        {
            TridColor[] tridColors = new TridColor[630];

            tridColors[0] = new TridColor("#000000", "出错啦");

            string colorContent = GetColorInTxt();
            string[] temp = colorContent.Split(';');

            int i = 0;
            foreach (string str in temp)
            {
                if (str.Contains("="))
                {
                    int index = str.IndexOf("=");
                    i++;
                    tridColors[i] = new TridColor(str.Substring(index + 1, str.Length - index - 1), str.Substring(3, index - 3));
                }
            }

            return tridColors;
        }

        public string GetColorInTxt()
        {
            string content = @"
>蔚蓝=#70f3ff;
>蓝=#44cef6;
>碧蓝=#3eede7;
>石青=#1685a9;
>靛青=#177cb0;
>靛蓝=#065279;
>花青=#003472;
>宝蓝=#4b5cc4;
>蓝灰色=#a1afc9;
>藏青=#2e4e7e;
>藏蓝=#3b2e7e;
>黛=#4a4266;
>黛绿=#426666;
>黛蓝=#425066;
>黛紫=#574266;
>紫色=#8d4bbb;
>紫酱=#815463;
>酱紫=#815476;
>紫檀=#4c221b;
>绀青=#003371;
>紫棠=#56004f;
>青莲=#801dae;
>群青=#4c8dae;
>雪青=#b0a4e3;
>丁香色=#cca4e3;
>藕色=#edd1d8;
>藕荷色=#e4c6d0;
>朱砂=#ff461f;
>火红=#ff2d51;
>朱膘=#f36838;
>妃色=#ed5736;
>洋红=#ff4777;
>品红=#f00056;
>粉红=#ffb3a7;
>桃红=#f47983;
>海棠红=#db5a6b;
>樱桃色=#c93756;
>酡颜=#f9906f;
>银红=#f05654;
>大红=#ff2121;
>石榴红=#f20c00;
>绛紫=#8c4356;
>绯红=#c83c23;
>胭脂=#9d2933;
>朱红=#ff4c00;
>丹=#ff4e20;
>彤=#f35336;
>酡红=#dc3023;
>炎=#ff3300;
>茜色=#cb3a56;
>绾=#a98175;
>檀=#b36d61;
>嫣红=#ef7a82;
>洋红=#ff0097;
>枣红=#c32136;
>殷红=#be002f;
>赫赤=#c91f37;
>银朱=#bf242a;
>赤=#c3272b;
>胭脂=#9d2933;
>栗色=#60281e;
>玄色=#622a1d;
>松花色=#bce672;
>柳黄=#c9dd22;
>嫩绿=#bddd22;
>柳绿=#afdd22;
>葱黄=#a3d900;
>葱绿=#9ed900;
>豆绿=#9ed048;
>豆青=#96ce54;
>油绿=#00bc12;
>葱倩=#0eb83a;
>葱青=#0eb83a;
>青葱=#0aa344;
>石绿=#16a951;
>松柏绿=#21a675;
>松花绿=#057748;
>绿沈=#0c8918;
>绿色=#00e500;
>草绿=#40de5a;
>青翠=#00e079;
>青色=#00e09e;
>翡翠色=#3de1ad;
>碧绿=#2add9c;
>玉色=#2edfa3;
>缥=#7fecad;
>艾绿=#a4e2c6;
>石青=#7bcfa6;
>碧色=#1bd1a5;
>青碧=#48c0a3;
>铜绿=#549688;
>竹青=#789262;
>墨灰=#758a99;
>墨色=#50616d;
>鸦青=#424c50;
>黯=#41555d;
>樱草色=#eaff56;
>鹅黄=#fff143;
>鸭黄=#faff72;
>杏黄=#ffa631;
>橙黄=#ffa400;
>橙色=#fa8c35;
>杏红=#ff8c31;
>橘黄=#ff8936;
>橘红=#ff7500;
>藤黄=#ffb61e;
>姜黄=#ffc773;
>雌黄=#ffc64b;
>赤金=#f2be45;
>缃色=#f0c239;
>雄黄=#e9bb1d;
>秋香色=#d9b611;
>金色=#eacd76;
>牙色=#eedeb0;
>枯黄=#d3b17d;
>黄栌=#e29c45;
>乌金=#a78e44;
>昏黄=#c89b40;
>棕黄=#ae7000;
>琥珀=#ca6924;
>棕色=#b25d25;
>茶色=#b35c44;
>棕红=#9b4400;
>赭=#9c5333;
>驼色=#a88462;
>秋色=#896c39;
>棕绿=#827100;
>褐色=#6e511e;
>棕黑=#7c4b00;
>赭色=#955539;
>赭石=#845a33;
>精白=#ffffff;
>银白=#e9e7ef;
>铅白=#f0f0f4;
>霜色=#e9f1f6;
>雪白=#f0fcff;
>莹白=#e3f9fd;
>月白=#d6ecf0;
>象牙白=#fffbf0;
>缟=#f2ecde;
>鱼肚白=#fcefe8;
>白粉=#fff2df;
>荼白=#f3f9f1;
>鸭卵青=#e0eee8;
>素=#e0f0e9;
>青白=#c0ebd7;
>蟹壳青=#bbcdc5;
>花白=#c2ccd0;
>老银=#bacac6;
>灰色=#808080;
>苍色=#75878a;
>水色=#88ada6;
>黝=#6b6882;
>乌色=#725e82;
>玄青=#3d3b4f;
>乌黑=#392f41;
>黎=#75664d;
>黧=#5d513c;
>黝黑=#665757;
>缁色=#493131;
>煤黑=#312520;
>漆黑=#161823;
>黑色=#000000;

>古代紫=#895b8a;
>茄子紺=#824880;
>二藍=#915c8b;
>京紫=#9d5b8b;
>蒲葡=#7a4171;
>若紫=#bc64a4;
>紅紫=#b44c97;
>梅紫=#aa4c8f;
>菖蒲色=#cc7eb1;
>紅藤色=#cca6bf;
>浅紫=#c4a3bf;
>紫水晶=#e7e7eb;
>薄梅鼠=#dcd6d9;
>暁鼠=#d3cfd9;
>牡丹鼠=#d3ccd6;
>霞色=#c8c2c6;
>藤鼠=#a6a5c4;
>半色=#a69abd;
>薄色=#a89dac;
>薄鼠=#9790a4;
>鳩羽鼠=#9e8b8e;
>鳩羽色=#95859c;
>桔梗鼠=#95949a;
>紫鼠=#71686c;
>葡萄鼠=#705b67;
>濃色=#634950;
>紫鳶=#5f414b;
>濃鼠=#4f455c;
>藤煤竹=#5a5359;
>滅紫=#594255;
>紅消鼠=#524748;
>似せ紫=#513743;
>灰黄緑=#e6eae3;
>蕎麦切色=#d4dcd6;
>薄雲鼠=#d4dcda;
>枯野色=#d3cbc6;
>潤色=#c8c2be;
>利休白茶=#b3ada0;
>茶鼠=#a99e93;
>胡桃染=#a58f86;
>江戸鼠=#928178;
>煤色=#887f7a;
>丁子茶=#b4866b;
>柴染=#b28c6e;
>宗伝唐茶=#a16d5d;
>砺茶=#9f6f55;
>煎茶色=#8c6450;
>銀煤竹=#856859;
>黄枯茶=#765c47;
>煤竹色=#6f514c;
>焦茶=#6f4b3e;
>黒橡=#544a47;
>憲法色=#543f32;
>涅色=#554738;
>檳榔子染=#433d3c;
>黒鳶=#432f2f;
>赤墨=#3f312b;
>黒紅=#302833;
>白=#ffffff;
>胡粉色=#fffffc;
>卯の花色=#f7fcfe;
>白磁=#f8fbf8;
>生成り色=#fbfaf5;
>乳白色=#f3f3f3;
>白練=#f3f3f2;
>素色=#eae5e3;
>白梅鼠=#e5e4e6;
>白鼠=#dcdddd;
>絹鼠=#dddcd6;
>灰青=#c0c6c9;
>銀鼠=#afafb0;
>薄鈍=#adadad;
>薄墨色=#a3a3a2;
>錫色=#9ea1a3;
>素鼠=#9fa0a0;
>鼠色=#949495;
>源氏鼠=#888084;
>灰色=#7d7d7d;
>鉛色=#7b7c7d;
>鈍色=#727171;
>墨=#595857;
>丼鼠=#595455;
>消炭色=#524e4d;
>藍墨茶=#474a4d;
>羊羹色=#383c3c;
>蝋色=#2b2b2b;
>黒=#2b2b2b;
>烏羽色=#180614;
>鉄黒=#281a14;
>濡羽色=#000b00;
>黒壇=#250d00;
>憲法黒茶=#241a08;
>暗黒色=#16160e;
>萌葱色=#006e54;
>花緑青=#00a381;
>翡翠色=#38b48b;
>青緑=#00a497;
>水浅葱=#80aba9;
>錆浅葱=#5c9291;
>青碧=#478384;
>御召茶=#43676b;
>湊鼠=#80989b;
>高麗納戸=#2c4f54;
>百入茶=#1f3134;
>錆鼠=#47585c;
>錆鉄御納戸=#485859;
>藍鼠=#6c848d;
>錆御納戸=#53727d;
>舛花色=#5b7e91;
>熨斗目花色=#426579;
>御召御納戸=#4c6473;
>鉄御納戸=#455765;
>紺鼠=#44617b;
>藍鉄=#393f4c;
>青褐=#393e4f;
>褐返=#203744;
>褐色=#4d4c61;
>月白=#eaf4fc;
>白菫色=#eaedf7;
>白花色=#e8ecef;
>藍白=#ebf6f7;
>白藍=#c1e4e9;
>水色=#bce2e8;
>瓶覗=#a2d7dd;
>秘色色=#abced8;
>空色=#a0d8ef;
>勿忘草色=#89c3eb;
>青藤色=#84a2d4;
>白群=#83ccd2;
>浅縹=#84b9cb;
>薄花色=#698aab;
>納戸色=#008899;
>浅葱色=#00a3af;
>花浅葱=#2a83a2;
>新橋色=#59b9c6;
>天色=#2ca9e1;
>露草色=#38a1db;
>青=#0095d9;
>薄藍=#0094c8;
>縹色=#2792c3;
>紺碧=#007bbb;
>薄群青=#5383c3;
>薄花桜=#5a79ba;
>群青色=#4c6cb3;
>杜若色=#3e62ad;
>瑠璃色=#1e50a2;
>薄縹=#507ea4;
>瑠璃紺=#19448e;
>紺瑠璃=#164a84;
>藍色=#165e83;
>青藍=#274a78;
>深縹=#2a4073;
>紺色=#223a70;
>紺青=#192f60;
>留紺=#1c305c;
>濃藍=#0f2350;
>鉄紺=#17184b;
>漆黒=#0d0015;
>淡藤色=#bbc8e6;
>藤色=#bbbcde;
>紅掛空色=#8491c3;
>紅碧=#8491c3;
>紺桔梗=#4d5aaf;
>花色=#4d5aaf;
>紺藍=#4a488e;
>紅桔梗=#4d4398;
>桔梗色=#5654a2;
>藤納戸=#706caa;
>紅掛花色=#68699b;
>紫苑色=#867ba9;
>白藤色=#dbd0e6;
>藤紫=#a59aca;
>菫色=#7058a3;
>青紫=#674598;
>菖蒲色=#674196;
>竜胆色=#9079ad;
>江戸紫=#745399;
>本紫=#65318e;
>葡萄色=#522f60;
>深紫=#493759;
>紫黒=#2e2930;
>紫=#884898;
>薄葡萄=#c0a2c7;
>紫紺=#460e44;
>暗紅色=#74325c;
>桑の実色=#55295b;
>黄金=#e6b422;
>櫨染=#d9a62e;
>黄朽葉色=#d3a243;
>山吹茶=#c89932;
>芥子色=#d0af4c;
>豆がら茶=#8b968d;
>麹塵=#6e7955;
>山鳩色=#767c6b;
>利休鼠=#888e7e;
>海松茶=#5a544b;
>藍海松茶=#56564b;
>藍媚茶=#56564b;
>千歳茶=#494a41;
>岩井茶=#6b6f59;
>仙斎茶=#474b42;
>黒緑=#333631;
>柳煤竹=#5b6356;
>樺茶色=#726250;
>空五倍子色=#9d896c;
>生壁色=#94846a;
>肥後煤竹=#897858;
>媚茶=#716246;
>白橡=#cbb994;
>亜麻色=#d6c6af;
>榛色=#bfa46f;
>灰汁色=#9e9478;
>利休茶=#a59564;
>鶯茶=#715c1f;
>木蘭色=#c7b370;
>砂色=#dcd3b2;
>油色=#a19361;
>利休色=#8f8667;
>梅幸茶=#887938;
>璃寛茶=#6a5d21;
>黄海松茶=#918754;
>菜種油色=#a69425;
>青朽葉=#ada250;
>根岸色=#938b4b;
>鶸茶=#8c8861;
>柳茶=#a1a46d;
>海松色=#726d40;
>鶯色=#928c36;
>緑黄色=#dccb18;
>鶸色=#d7cf3a;
>抹茶色=#c5c56a;
>若草色=#c3d825;
>黄緑=#b8d200;
>若芽色=#e0ebaf;
>若菜色=#d8e698;
>若苗色=#c7dc68;
>青丹=#99ab4e;
>草色=#7b8d42;
>苔色=#69821b;
>萌黄=#aacf53;
>苗色=#b0ca71;
>若葉色=#b9d08b;
>松葉色=#839b5c;
>夏虫色=#cee4ae;
>鶸萌黄=#82ae46;
>柳色=#a8c97f;
>青白橡=#9ba88d;
>柳鼠=#c8d5bb;
>裏葉柳=#c1d8ac;
>山葵色=#a8bf93;
>老竹色=#769164;
>白緑=#d6e9ca;
>淡萌黄=#93ca76;
>柳染=#93b881;
>薄萌葱=#badcad;
>深川鼠=#97a791;
>若緑=#98d98e;
>浅緑=#88cb7f;
>薄緑=#69b076;
>青鈍=#6b7b6e;
>青磁鼠=#bed2c3;
>薄青=#93b69c;
>錆青磁=#a6c8b2;
>緑青色=#47885e;
>千歳緑=#316745;
>若竹色=#68be8d;
>緑=#3eb370;
>常磐色=#007b43;
>千草鼠=#bed3ca;
>千草色=#92b5a9;
>青磁色=#7ebea5;
>青竹色=#7ebeab;
>常磐緑=#028760;
>木賊色=#3b7960;
>天鵞絨=#2f5d50;
>虫襖=#3a5b52;
>革色=#475950;
>深緑=#00552e;
>鉄色=#005243;
>小豆色=#96514d;
>枯茶=#8d6449;
>饴色=#deb068;
>骆驼色=#bf794e;
>土色=#bc763c;
>黄唐色=#b98c46;
>桑染=#b79b5b;
>栌色=#b77b57;
>黄橡=#b68d4c;
>丁字染=#ad7d4c;
>香染=#ad7d4c;
>枇杷茶=#ae7c4f;
>芝翫茶=#ad7e4e;
>焦香=#ae7c58;
>胡桃色=#a86f4c;
>渋纸色=#946243;
>朽葉色=#917347;
>桑茶=#956f29;
>路考茶=#8c7042;
>国防色=#7b6c3e;
>伽羅色=#d8a373;
>江戸茶=#cd8c5c;
>樺色=#cd5e3c;
>紅鬱金=#cb8347;
>土器色=#c37854;
>狐色=#c38743;
>黄土色=#c39143;
>琥珀色=#bf783a;
>赤茶=#bb5535;
>代赭=#bb5520;
>煉瓦色=#b55233;
>雀茶=#aa4f37;
>団十郎茶=#9f563a;
>柿渋色=#9f563a;
>紅鳶=#9a493f;
>灰茶=#98623c;
>茶色=#965042;
>檜皮色=#965036;
>鳶色=#95483f;
>柿茶=#954e2a;
>弁柄色=#8f2e14;
>赤錆色=#8a3319;
>褐色=#8a3b00;
>栗梅=#852e19;
>紅檜皮=#7b4741;
>海老茶=#773c30;
>唐茶=#783c1d;
>栗色=#762f07;
>赤銅色=#752100;
>錆色=#6c3524;
>赤褐色=#683f36;
>茶褐色=#664032;
>栗皮茶=#6d3c32;
>黒茶=#583822;
>葡萄茶=#6c2c2f;
>葡萄色=#640125;
>萱草色=#f8b862;
>柑子色=#f6ad49;
>金茶=#f39800;
>蜜柑色=#f08300;
>鉛丹色=#ec6d51;
>黄丹=#ee7948;
>柿色=#ed6d3d;
>黄赤=#ec6800;
>人参色=#ec6800;
>橙色=#ee7800;
>照柿=#eb6238;
>赤橙=#ea5506;
>金赤=#ea5506;
>朱色=#eb6101;
>小麦色=#e49e61;
>丹色=#e45e32;
>黄茶=#e17b34;
>肉桂色=#dd7a56;
>赤朽葉色=#db8449;
>黄櫨染=#d66a35;
>蒲公英色=#ffd900;
>黄色=#ffd900;
>中黄=#ffea00;
>菜の花色=#ffec47;
>黄檗色=#fef263;
>卵色=#fcd575;
>花葉色=#fbd26b;
>刈安色=#f5e56b;
>玉蜀黍色=#eec362;
>金糸雀色=#ebd842;
>黄支子色=#ffdb4f;
>支子色=#fbca4d;
>向日葵色=#fcc800;
>山吹色=#f8b500;
>鬱金色=#fabf14;
>藤黄=#f7c114;
>金色=#e6b422;
>桜色=#bf242a;
>薄桜=#fdeff2;
>桜鼠=#e9dfe5;
>鸨鼠=#e4d2d8;
>虹色=#f6bfbc;
>珊瑚色=#f5b1aa;
>一斤染=#f5b199;
>宍色=#efab93;
>红梅色=#f2a0a1;
>薄红=#f0908d;
>甚三红=#ee827c;
>桃色=#f09199;
>鸨色=#f4b3c2;
>撫子色=#eebbcb;
>灰梅=#e8d3c7;
>灰桜=#e8d3d1;
>淡红藤=#e6cde3;
>石竹色=#e5abbe;
>薄红梅=#e597b2;
>桃花色=#e198b4;
>水柿=#e4ab9b;
>ときがら茶=#e09e87;
>退红=#d69090;
>薄柿=#d4acad;
>长春色=#c97586;
>梅鼠=#c099a0;
>鸨浅葱=#b88884;
>梅染=#b48a76;
>苏芳香=#a86965;
>浅苏芳=#a25768;
>真朱=#ec6d71;
>赤紫=#eb6ea5;
>躑躅色=#e95295;
>牡丹色=#e7609e;
>今样色=#d0576b;
>中红=#c85179;
>蔷薇色=#e9546b;
>韩红=#e95464;
>银朱=#c85554;
>赤红=#c53d43;
>红緋=#e83929;
>赤=#e60033;
>猩緋=#e2041b;
>红=#d7003a;
>深緋=#c9171e;
>绯色=#d3381c;
>赤丹=#ce5242;
>红赤=#d9333f;
>胭脂=#b94047;
>朱緋=#ba2636;
>茜色=#b7282e;
>深海老茶=#a73836;
>苏芳=#9e3d3f;
>真红=#a22041;
>浓红=#a22041;
>象牙色=#f8f4e6;
>练色=#ede4cd;
>灰白色=#e9e4d4;
>蒸栗色=#ede1a9;
>女郎花=#f2f2b0;
>枯草色=#e4dc8a;
>淡黄=#f8e58c;
>白茶=#ddbb99;
>赤白橡=#d7a98c;
>洗柿=#f2c9ac;
>鸟の子色=#fff1cf;
>蜂蜜色=#fddea5;
>肌色=#fce2c4;
>薄卵色=#fde8d0;
>雄黄=#f9c89b;
>洒落柿=#f7bd8f;
>赤香=#f6b894;
>砥粉色=#f4dda5;
>肉色=#f1bf99;
>人色=#f1bf99;
>丁子色=#efcd9a;
>香色=#efcd9a;
>薄香=#f0cfa0;
>浅黄=#edd3a1;
>枯色=#e0c38c;
>淡香=#f3bf88;
>杏色=#f7b977;
>东云色=#f19072;
>曙色=#f19072;
>珊瑚朱色=#ee836f;
>深支子=#eb9b6f;
>纁=#e0815e;
>浅绯=#df7163;
>真赭=#d57c6b;
>洗朱=#d0826c;
>遠州茶=#ca8269;
>红桦色=#bb5548;
>赭=#ab6953;";

            return content;

        }
    }
}