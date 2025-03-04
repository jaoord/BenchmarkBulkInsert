using BenchmarkBulkInsert.Db;

namespace BenchmarkBulkInsert
{
    static class DataProvider
    {

        public static IEnumerable<MetarWithUniqueConstraint> GetTestMetarWithUniqueConstraint()
        {
            return GetTestData().Select(x => new MetarWithUniqueConstraint(x));
        }

        public static List<Metar> GetTestData()
        {
            return new()
            {
                    new Metar {
       Station = "UUBW",
       RawData = "UUBW 041641Z 24004MPS 9999 OVC011 02/02 Q0997 R30/290250 NOSIG RMK QFE737",
       LastChange = "2025-03-04T16:41:00Z"
    },
    new Metar {
       Station = "PKWA",
       RawData = "PKWA 041640Z AUTO 08010KT 10SM SCT027 27/22 A2988 RMK AO2 T02680221",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KY51",
       RawData = "KY51 041640Z AUTO 15008KT 10SM OVC015 07/04 A2956 RMK AO1 T00680040",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KSGT",
       RawData = "KSGT 041640Z AUTO 14020G27KT 9SM VCTS -RA 14/13 A2952 RMK AO2 PK WND 15031/1625 LTG DSNT ALQDS TSB34RAB02 P0002",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQFX",
       RawData = "KQFX 041640Z AUTO 11001KT 9999 FEW001 OVC070 M00/M01 A3016 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQFV",
       RawData = "KQFV 041640Z AUTO 08001KT 9999 OVC060 M02/M03 A3020 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQFU",
       RawData = "KQFU 041640Z AUTO 34002KT 9999 OVC065 01/M04 A3021 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQFB",
       RawData = "KQFB 041640Z AUTO 34001KT 9999 OVC019 04/02 A3019 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQEX",
       RawData = "KQEX 041640Z AUTO 27002KT 9999 BKN033 03/01 A3009 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQEW",
       RawData = "KQEW 041640Z AUTO 24001KT 9999 // OVC075 01/M00 A3016 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQEQ",
       RawData = "KQEQ 041640Z AUTO 03003KT 9999 OVC065 01/M04 A3023 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQEP",
       RawData = "KQEP 041640Z AUTO 36003KT 9999 OVC065 03/M02 A3018 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KQEI",
       RawData = "KQEI 041640Z AUTO 11001KT 9999 OVC065 M01/M01 A3017 RMK A02 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KFHM",
       RawData = "KFHM 041640Z 16003G05KT 13/07",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KDTA",
       RawData = "KDTA 041640Z AUTO 16009KT 10SM BKN075 05/00 A3013 RMK AO1",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KDSF",
       RawData = "KDSF 041640Z AUTO 13022KT 5SM HZ CLR 23/18 A2991 RMK A01",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KBOK",
       RawData = "KBOK 041640Z AUTO 15007KT 1/4SM -RA OVC003 A3021 RMK AO2 PNO $",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KAPY",
       RawData = "KAPY 041640Z AUTO 35015G22KT 5SM HZ CLR 26/M04 A2976 RMK AO2 T02621045 TSNO",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "CYFR",
       RawData = "CYFR 041640Z VRB02KT 8SM OVC005 M11/M12 A3000 RMK ST8 SLP179",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "CYBQ",
       RawData = "CYBQ 041640Z AUTO 20005KT 9SM -SN OVC024 M13/M16 A2993 RMK ICE SLP165",
       LastChange = "2025-03-04T16:40:00Z"
    },
    new Metar {
       Station = "KSHR",
       RawData = "KSHR 041639Z AUTO 33015KT 3SM -SN FEW010 OVC031 00/M03 A3009 RMK AO2 P0000 T00001033",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KRIW",
       RawData = "KRIW 041639Z AUTO 02018G23KT 3SM -SN BKN022 OVC034 M02/M06 A3001 RMK AO2 P0000 T10221056",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KOFK",
       RawData = "KOFK 041639Z AUTO 35017G30KT 1 3/4SM -RA OVC006 08/05 A2944 RMK AO2 PK WND 34030/1634 RAB35 P0000 T00780050",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KMOT",
       RawData = "KMOT 041639Z 36010KT 10SM FEW011 OVC018 M02/M06 A3002 RMK AO2 T10221056",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KHYS",
       RawData = "KHYS 041639Z AUTO 34033G41KT 10SM OVC016 07/03 A2931 RMK AO2 PK WND 34041/1637",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KHEI",
       RawData = "KHEI 041639Z AUTO 34017KT 7SM -SN BKN013 OVC018 M01/M04 A2999 RMK AO2 SNB07E16B37 P0000 T10061039",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KFYV",
       RawData = "KFYV 041639Z 24009KT 2 1/2SM RA BR SCT012 BKN049 OVC070 13/11 A2945 RMK AO2 P0014 T01280106",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KFLL",
       RawData = "KFLL 041639Z 10019G26KT 10SM BKN025CB BKN037 OVC055 23/18 A3008 RMK AO2 PK WND 09030/1615 CB W MOV NW T02330183",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KCNM",
       RawData = "KCNM 041639Z AUTO 27027G42KT 5SM HZ FEW005 14/M07 A2976 RMK AO2 PK WND 27060/1611 T01441072",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KBPK",
       RawData = "KBPK 041639Z AUTO 16011G20KT 4SM +RA BR FEW010 BKN015 OVC019 12/10 A2943 RMK AO2 LTG DSNT ALQDS P0011 T01170100",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "KADF",
       RawData = "KADF 041639Z AUTO 29009KT 4SM RA BR FEW046 BKN060 OVC085 14/14 A2949 RMK AO2 WSHFT 1554 LTG DSNT NE-SE TSE26 P0042",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "K2V6",
       RawData = "K2V6 041639Z AUTO 34023G37KT 10SM BKN019 OVC026 02/M01 A2970 RMK AO2",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "CYYL",
       RawData = "CYYL 041639Z AUTO 22007KT 9SM -SN BKN009 OVC014 M11/M14 A2996 RMK SLP181",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "CYRV",
       RawData = "CYRV 041639Z AUTO VRB02KT 3SM BR BKN001 OVC060 M01/M01 A3010 RMK SLP215",
       LastChange = "2025-03-04T16:39:00Z"
    },
    new Metar {
       Station = "UWGG",
       RawData = "UWGG 041638Z 18002MPS 7000 -SN OVC005 00/00 Q0997 R18L/290050 NOSIG",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "PFKW",
       RawData = "PFKW 041638Z AUTO 35004KT 4SM -SN BR BKN016 BKN030 OVC046 M10/M12 A2967 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "NZCM",
       RawData = "NZCM 041638Z AUTO 14012G22KT 090V170 9000 -SN OVC019 M12/M15 A2916 RMK AO2 SNE1621B1638 CIG 015V023 SLP881 T11161155",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KSGF",
       RawData = "KSGF 041638Z 14019G27KT 2 1/2SM RA BR OVC010 12/10 A2935 RMK AO2 PK WND 15030/1628 P0006 T01170100",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KRFD",
       RawData = "KRFD 041638Z 16014G25KT 10SM OVC029 08/04 A2966 RMK AO2 PK WND 15027/1615 T00780039",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KRCA",
       RawData = "KRCA 041638Z 33019KT 2 1/4SM -SN BR FEW002 BKN007 BKN015 BKN021 OVC044 M01/M02 A2990 RMK AO2A VIS 1 3/4V2 1/4 CIG 007V040 SLP148 $",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KMIC",
       RawData = "KMIC 041638Z 36006KT 2SM -RA BR OVC006 05/03 A2958 RMK AO2 RAB08 P0001 T00500033",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KLNR",
       RawData = "KLNR 041638Z AUTO 10005KT 10SM OVC032 09/06 A2957 RMK AO2 T00940056",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KLFT",
       RawData = "KLFT 041638Z 15016G34KT 10SM BKN027 OVC034 23/17 A2966 RMK AO2 PK WND 14042/1606 T02280172",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KJLN",
       RawData = "KJLN 041638Z 28025G37KT 1 3/4SM +RA BR BKN006 BKN013 OVC023 12/10 A2933 RMK AO2 PK WND 27037/1638 WSHFT 1613 CIG 003V010 P0019 T01170100",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KICR",
       RawData = "KICR 041638Z AUTO 34025G36KT 1 1/2SM BR FEW007 BKN011 OVC016 00/M02 A2977 RMK AO2 PK WND 33036/1633 T00001022 PWINO FZRANO $",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KGCC",
       RawData = "KGCC 041638Z AUTO 33018G27KT 8SM BKN015 BKN021 OVC025 M02/M05 A3002 RMK AO2 PK WND 32027/1635 SNE16 P0000 T10221050",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KEUF",
       RawData = "KEUF 041638Z AUTO 16012G19KT 10SM BKN030 OVC037 21/13 A3004 RMK AO2 I1000 T02060128 PWINO PNO $",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KCAG",
       RawData = "KCAG 041638Z AUTO 25008KT 9SM -RA BKN013 BKN023 OVC042 02/M01 A2994 RMK AO2 RAB27SNE27 P0000 T00171006",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "KBBW",
       RawData = "KBBW 041638Z AUTO 34033G49KT 2 1/2SM -SN BR OVC011 01/M01 A2952 RMK AO2 PK WND 35049/1634 UPB05E19SNE05B19 P0000 T00061011",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "CYXQ",
       RawData = "CYXQ 041638Z 00000KT 25SM FEW003 SCT120 OVC250 M21/M23 A2991 RMK ST1AC2CI5 SLP189",
       LastChange = "2025-03-04T16:38:00Z"
    },
    new Metar {
       Station = "YCFS",
       RawData = "YCFS 041637Z AUTO 22015KT 9999 // SCT013 BKN019 BKN026 21/20 Q1013",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "UWLW",
       RawData = "UWLW 041637Z 16008MPS 2800 -SN OVC008 M03/M04 Q1003 R20/550542 NOSIG RMK QFE747/0997",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "KSLK",
       RawData = "KSLK 041637Z AUTO 22015G21KT 10SM BKN028 OVC034 00/M08 A2993 RMK AO2 T00001083",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "KIXD",
       RawData = "KIXD 041637Z 15004KT 4SM -RA BR BKN050 OVC065 12/11 A2938 RMK AO2 PRESFR P0007 T01170106",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "KBIL",
       RawData = "KBIL 041637Z 26005KT 7SM -SN FEW018 OVC031 M01/M03 A3013 RMK AO2 SNB1558E12B37 P0000 T10111028 $",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "CYVV",
       RawData = "CYVV 041637Z 20010KT 15SM OVC020 02/01 A2982 RMK SC8 SLP108",
       LastChange = "2025-03-04T16:37:00Z"
    },
    new Metar {
       Station = "PATQ",
       RawData = "PATQ 041636Z AUTO 10022KT 3SM -SN BR CLR M16/M17 A2981 RMK AO2 PK WND 09026/1600 P0000 FZRANO TSNO",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KXWA",
       RawData = "KXWA 041636Z AUTO 35018KT 10SM FEW011 BKN026 OVC033 M03/M06 A3006 RMK AO2 SNE1559 P0000 T10331061",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KUIN",
       RawData = "KUIN 041636Z AUTO 15013G19KT 2SM -RA BR BKN033 BKN044 OVC055 09/08 A2953 RMK AO2 TSB10E25 P0036 T00890083",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KTQE",
       RawData = "KTQE 041636Z AUTO 08008KT 9SM BKN011 OVC031 13/11 A2934 RMK AO2 T01330111",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KSTC",
       RawData = "KSTC 041636Z 02007KT 2 1/2SM -RA BR FEW010 BKN033 OVC049 03/02 A2962 RMK AO2 P0014 T00330022",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KSLH",
       RawData = "KSLH 041636Z AUTO 00000KT 10SM BKN016 BKN022 OVC080 04/00 A2969 RMK AO2",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KPIR",
       RawData = "KPIR 041636Z AUTO 35019G26KT 1SM -SN BR SCT009 BKN016 OVC024 00/M02 A2985 RMK AO2 PK WND 36035/1606 SNB06 P0000 T00001017",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KOVS",
       RawData = "KOVS 041636Z AUTO 02003KT 10SM OVC031 08/06 A2956 RMK AO2 T00830056",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KMSP",
       RawData = "KMSP 041636Z 01008KT 3SM -RA BR FEW005 BKN020 OVC034 06/04 A2958 RMK AO2 P0000 T00560044",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KMCD",
       RawData = "KMCD 041636Z AUTO VRB01KT 10SM OVC017 04/M01 A2969 RMK AO2 PRESFR",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KMAF",
       RawData = "KMAF 041636Z 30033G49KT 1 1/4SM BLDU CLR 13/M07 A2970 RMK AO2 PK WND 31049/1636 T01331067",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KLIC",
       RawData = "KLIC 041636Z AUTO 35033G52KT 10SM BKN016 BKN021 OVC026 01/M02 A2969 RMK AO2 PK WND 35059/1625 T00111017",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KI69",
       RawData = "KI69 041636Z AUTO 18009G15KT 150V210 10SM CLR 14/M04 A2990 RMK AO1 T01431040",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KHOU",
       RawData = "KHOU 041636Z 29008G18KT 9SM -RA BKN030 OVC045 14/12 A2964 RMK AO2 PK WND 31039/1607 WSHFT 1557 RAB10 BINOVC FROPA P0006 T01440117",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KCTB",
       RawData = "KCTB 041636Z AUTO 15003KT 1/4SM FZFG VV001 M05/M06 A3009 RMK AO2 T10501061",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KAVL",
       RawData = "KAVL 041636Z 18009KT 10SM BKN025 OVC038 10/02 A3018 RMK AO2 T01000017",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "KABR",
       RawData = "KABR 041636Z AUTO 01022G31KT 10SM OVC014 01/M03 A2983 RMK AO2 PK WND 02035/1625 T00061033",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "K79J",
       RawData = "K79J 041636Z AUTO BKN027 OVC034 21/13 A2998 RMK AO2 T02060133 TSNO $",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "CZSJ",
       RawData = "CZSJ 041636Z AUTO 36006KT 320V040 9SM OVC043 M09/M13 A2997 RMK SLP176",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "CYZP",
       RawData = "CYZP 041636Z AUTO 14024G30KT 9SM -RA FEW019 07/06 A2978 RMK SLP087",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "CYQA",
       RawData = "CYQA 041636Z AUTO 14004KT 1 3/4SM -SN BKN019 OVC025 M00/M01 A2985 RMK VIS VRB 1-2 1/2 ICE PAST HR SLP121",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "CYMT",
       RawData = "CYMT 041636Z AUTO 22009KT 3SM -SN OVC015 M03/M05 A2970 RMK SLP080",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "CYMH",
       RawData = "CYMH 041636Z AUTO 26012G18KT 9SM -SN CLR M10/M19 A2972 RMK SLP067",
       LastChange = "2025-03-04T16:36:00Z"
    },
    new Metar {
       Station = "PFEL",
       RawData = "PFEL 041635Z AUTO 00000KT 1 1/2SM -SN BR OVC020 M10/M12 A2971 RMK AO2 P0000 FZRANO TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "PASL",
       RawData = "PASL 041635Z AUTO 00000KT 1 3/4SM BR FEW001 M01/M02 A2976 RMK AO2 FZRANO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "PAKX",
       RawData = "PAKX 041635Z AUTO 00000KT 7SM SCT065 BKN070 OVC095 02/M03 A2972 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "PAAD",
       RawData = "PAAD 041635Z AUTO 08014KT 10SM CLR M19/M21 A2993 RMK AO2 T11951215",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KZPH",
       RawData = "KZPH 041635Z AUTO 11010G21KT 10SM BKN042 BKN049 25/14 A3011 RMK A02 T02470138",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KZER",
       RawData = "KZER 041635Z AUTO 15006KT 10SM OVC055 02/M05 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KY63",
       RawData = "KY63 041635Z AUTO 35015KT 10SM SCT018 BKN060 OVC070 01/M03 A2974 RMK AO2 T00101026",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KY49",
       RawData = "KY49 041635Z AUTO 34010KT 10SM OVC090 M01/M04 A2974 RMK AO2 T10061042",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KY31",
       RawData = "KY31 041635Z AUTO 21006KT 10SM BKN038 OVC048 03/01 A2975 RMK AO2 T00320010",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KY23",
       RawData = "KY23 041635Z AUTO 00000KT 4SM BR BKN005 BKN022 OVC035 05/05 A2959 RMK AO2 T00500045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KY19",
       RawData = "KY19 041635Z AUTO 35015G22KT 9SM -DZ SCT019 OVC034 M01/M03 A2998 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KXSA",
       RawData = "KXSA 041635Z AUTO 10SM CLR 14/M02 A3025 RMK AO2 T01441016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KXLL",
       RawData = "KXLL 041635Z AUTO 22007KT 10SM SCT070 08/M01 A3018 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KX60",
       RawData = "KX60 041635Z AUTO 14009G19KT 10SM BKN041 OVC050 24/14 A3010 RMK AO2 T02390141",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KX26",
       RawData = "KX26 041635Z AUTO 11015G23KT 10SM SCT033 SCT046 SCT065 25/15 A3014 RMK AO2 T02490151",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KWWR",
       RawData = "KWWR 041635Z AUTO 33019G26KT 10SM SCT032 11/02 A2934 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KWDR",
       RawData = "KWDR 041635Z AUTO 00000KT 10SM BKN028 BKN033 OVC049 12/05 A3016 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW99",
       RawData = "KW99 041635Z AUTO 19009KT 10SM FEW140 16/M07 A3008 RMK AO2 T01571075",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW96",
       RawData = "KW96 041635Z AUTO 23008KT 10SM CLR 13/M03 A3025 RMK AO1 T01331028",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW81",
       RawData = "KW81 041635Z AUTO 21005KT 10SM CLR 13/M07 A3023 RMK AO1 T01331069",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW78",
       RawData = "KW78 041635Z AUTO 19005KT 10SM CLR 14/M02 A3023 RMK AO1 T01401023",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW63",
       RawData = "KW63 041635Z AUTO 21005KT 10SM CLR 13/M02 A3024 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW31",
       RawData = "KW31 041635Z AUTO 22007KT 180V240 10SM CLR 14/M01 A3024 RMK AO1 T01361010",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW22",
       RawData = "KW22 041635Z AUTO 19005KT 10SM CLR 17/M08 A3004 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KW13",
       RawData = "KW13 041635Z AUTO 18005KT 10SM CLR 14/M07 A3015 RMK AO1 T01431068",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVYS",
       RawData = "KVYS 041635Z AUTO 13011G17KT 3SM RA SCT013 BKN017 OVC065 07/06 A2965 RMK AO2 LTG DSNT SE AND S P0013 T00670057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVWU",
       RawData = "KVWU 041635Z AUTO 01012KT 10SM OVC017 01/M03 A2981 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVVV",
       RawData = "KVVV 041635Z AUTO 34020G28KT 3/4SM -SN BKN008 OVC013 M01/M02 A2972 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVVS",
       RawData = "KVVS 041635Z AUTO 23008KT 10SM CLR 16/M10 A3003 RMK AO2 T01581104",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVTI",
       RawData = "KVTI 041635Z AUTO 14010KT 10SM OVC021 12/08 A2948 RMK AO2 T01150079",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVPC",
       RawData = "KVPC 041635Z AUTO 13008G19KT 090V150 BKN028 BKN037 BKN065 16/08 A3008 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVOA",
       RawData = "KVOA 041635Z AUTO 17010G22KT 120V280 7SM SCT021 BKN025 23/18 A2991 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVNW",
       RawData = "KVNW 041635Z AUTO 01004KT 10SM OVC060 07/00 A2987 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVNC",
       RawData = "KVNC 041635Z AUTO 10SM FEW035 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVLL",
       RawData = "KVLL 041635Z AUTO 19006KT 10SM OVC033 04/01 A2984 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVJI",
       RawData = "KVJI 041635Z AUTO 21007KT 190V250 10SM CLR 16/M09 A3009 RMK AO2 T01631088",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVHN",
       RawData = "KVHN 041635Z AUTO 29032G38KT 3/4SM HZ OVC021 09/M07 A2996 RMK AO2 T00941074",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVGC",
       RawData = "KVGC 041635Z AUTO 15008KT 10SM 03/M07 A3003 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVER",
       RawData = "KVER 041635Z AUTO 10003KT 10SM -VCTSRA OVC032 11/11 A2946 RMK AO2 LTG DSNT N THRU SE P0008 T01130110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVDI",
       RawData = "KVDI 041635Z AUTO 15010G16KT 10SM SCT042 OVC050 22/11 A3014 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVDF",
       RawData = "KVDF 041635Z AUTO 13011G16KT 10SM SCT041 SCT060 25/16 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVBW",
       RawData = "KVBW 041635Z AUTO 22011G15KT 200V260 10SM CLR 14/M05 A3013 RMK AO1 T01431048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KVAF",
       RawData = "KVAF 041635Z 16029G39KT 1SM HZ OVC017 25/22 A2964 RMK A01 WINDS UN-RELIABLE 350 TO 45 DEGREES",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUYF",
       RawData = "KUYF 041635Z AUTO 20014G19KT 10SM CLR 11/M06 A2992 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUXL",
       RawData = "KUXL 041635Z AUTO 15025G34KT 5SM RA SCT015 BKN022 OVC032 22/19 A2962 RMK AO2 T02160190",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUVA",
       RawData = "KUVA 041635Z AUTO 28022G40KT 5SM HZ CLR 20/M11 A2979 RMK AO2 T02031110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUUV",
       RawData = "KUUV 041635Z AUTO 17014G27KT 10SM SCT110 15/03 A2952 RMK AO2 LTG DSNT SW THRU NW",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUTA",
       RawData = "KUTA 041635Z AUTO 14020G28KT 9SM OVC075 16/06 A2962 RMK AO2 PK WND 13030/1608 LTG DSNT W AND NW T01600059 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUOX",
       RawData = "KUOX 041635Z AUTO 14015G32KT 10SM CLR 16/03 A2971 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUNI",
       RawData = "KUNI 041635Z AUTO 18007KT 10SM CLR 14/M08 A2999 RMK AO2 T01371082 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUMP",
       RawData = "KUMP 041635Z AUTO 19012G22KT 10SM SCT120 16/M01 A2977 RMK AO2 T01571014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KULM",
       RawData = "KULM 041635Z AUTO 03007KT 3SM BR SCT006 SCT011 04/02 A2954 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUKT",
       RawData = "KUKT 041635Z AUTO 19005G10KT 9SM CLR 07/M01 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUKL",
       RawData = "KUKL 041635Z AUTO 00000KT 4SM RA SCT009 BKN026 OVC035 10/10 A2935 RMK AO2 P0011 T01000095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUKF",
       RawData = "KUKF 041635Z AUTO 23005KT 10SM CLR 12/00 A3025 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KUBE",
       RawData = "KUBE 041635Z AUTO 01007KT 4SM BR SCT005 OVC017 05/04 A2958 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KU68",
       RawData = "KU68 041635Z AUTO 00000KT 10SM CLR 01/M05 A3008 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KU64",
       RawData = "KU64 041635Z AUTO 30015G23KT 10SM FEW029 SCT043 03/M05 A3004 RMK AO2 T00291050 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KU14",
       RawData = "KU14 041635Z AUTO 36001KT 10SM SCT038 BKN047 BKN065 04/M01 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTYQ",
       RawData = "KTYQ 041635Z AUTO 18016G28KT 10SM CLR 16/00 A2975 RMK AO2 T01551002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTYL",
       RawData = "KTYL 041635Z AUTO 32011KT 10SM CLR 07/M07 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTXW",
       RawData = "KTXW 041635Z AUTO 34011KT 10SM CLR 29/19 A2970 RMK AO2 T02860189",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTWT",
       RawData = "KTWT 041635Z AUTO 16017G22KT 10SM SCT100 19/00 A2975 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTWM",
       RawData = "KTWM 041635Z AUTO 06012G17KT 10SM BKN100 05/M02 A2967 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTVK",
       RawData = "KTVK 041635Z AUTO 15010KT 10SM SCT095 13/09 A2945 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTVI",
       RawData = "KTVI 041635Z AUTO 16012G21KT 130V200 10SM SCT033 SCT046 OVC050 22/13 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTTF",
       RawData = "KTTF 041635Z AUTO 18004KT 10SM -RA BKN070 OVC080 05/01 A2987 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTSP",
       RawData = "KTSP 041635Z AUTO 31008KT 10SM CLR 05/02 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTQK",
       RawData = "KTQK 041635Z AUTO 35039G47KT 10SM OVC012 03/01 A2945 RMK AO2 T00320014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTQH",
       RawData = "KTQH 041635Z AUTO 07012G16KT 3SM BR 11/11 A2932 RMK AO2 P0009",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTOC",
       RawData = "KTOC 041635Z AUTO 04007KT 10SM BKN025 OVC035 12/01 A3018 RMK AO2 T01230015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTOB",
       RawData = "KTOB 041635Z AUTO 00000KT 10SM OVC009 06/04 A2952 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTNU",
       RawData = "KTNU 041635Z AUTO 14015KT 10SM CLR 14/10 A2940 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTNB",
       RawData = "KTNB 041635Z AUTO 23004G15KT 10SM SCT027 10/M04 A2999 RMK AO2 T01041036",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTMK",
       RawData = "KTMK 041635Z AUTO 06005KT 7SM -RA BKN037 08/07 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTME",
       RawData = "KTME 041635Z AUTO 00000KT 9SM OVC050 14/11 A2967 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTMA",
       RawData = "KTMA 041635Z AUTO 14011KT 10SM SCT034 22/14 A3010 RMK AO2 T02210138",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTKX",
       RawData = "KTKX 041635Z AUTO 16025G34KT 4SM HZ FEW090 16/02 A2961 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTKV",
       RawData = "KTKV 041635Z 2SM OVC002 05/03 A2956 RMK AO2 T00450026 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTKC",
       RawData = "KTKC 041635Z AUTO 34015G22KT 2 1/2SM BR OVC003 02/02 A2960 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTIP",
       RawData = "KTIP 041635Z AUTO 18007KT 10SM -VCTSRA OVC046 09/04 A2971 RMK AO2 LTG DSNT W THRU N T00860035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTIF",
       RawData = "KTIF 041635Z AUTO 35029G40KT 3/4SM -SN OVC010 M01/M02 A2965 RMK AO2 T10081022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTGI",
       RawData = "KTGI 041635Z AUTO 10SM CLR 09/04 A3028 RMK AO1 T00910036",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTEX",
       RawData = "KTEX 041635Z AUTO 29015G20KT 1 1/2SM -SN SCT007 BKN015 OVC020 M03/M06 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTEW",
       RawData = "KTEW 041635Z AUTO 19004KT 10SM OVC014 06/05 A2979 RMK AO2 T00590052",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTBX",
       RawData = "KTBX 041635Z AUTO 31031KT OVC001 M07/M08 A3000 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTBR",
       RawData = "KTBR 041635Z AUTO 16012G19KT 10SM SCT035 SCT060 21/11 A3016 RMK AO2 T02080108",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTAZ",
       RawData = "KTAZ 041635Z 10SM SCT070 OVC080 12/05 A2961 RMK AO2 LTG DSNT N AND NW P0001 T01200045 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KTAH",
       RawData = "KTAH 041635Z AUTO34008G16KT 230V040 8SM FEW024 FEW030 25/20 A2977 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT82",
       RawData = "KT82 041635Z AUTO 28022G32KT 10SM CLR 17/M06 A2971 RMK AO2 T01731063",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT78",
       RawData = "KT78 041635Z AUTO 29012G31KT 4SM -RA HZ FEW007 SCT013 BKN020 15/10 A2964 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT74",
       RawData = "KT74 041635Z AUTO 28014G22KT 10SM CLR 19/00 A2963 RMK AO2 P0001 T01941003",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT69",
       RawData = "KT69 041635Z AUTO 6SM HZ CLR 25/M02 A2972 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT41",
       RawData = "KT41 041635Z AUTO 30016KT 5SM RA BR BKN012 BKN019 OVC025 15/13 A2967 RMK AO2 LTG DSNT S P0001 T01470127",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT35",
       RawData = "KT35 041635Z AUTO 28012G20KT 10SM CLR 19/07 A2961 RMK AO2 T01880068",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KT20",
       RawData = "KT20 041635Z AUTO 28012G18KT 10SM CLR 21/01 A2967 RMK AO2 T02130005",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSYN",
       RawData = "KSYN 041635Z AUTO 36007KT 10SM OVC024 06/04 A2955 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSYM",
       RawData = "KSYM 041635Z AUTO 17007G12KT 150V210 10SM CLR 17/M10 A2996 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSYF",
       RawData = "KSYF 041635Z AUTO 34027G39KT 4SM BR FEW009 BKN017 OVC022 01/M00 A2962 RMK AO2 PK WND 34042/16",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSXU",
       RawData = "KSXU 041635Z AUTO 28022G29KT 10SM CLR 10/M06 A2968 RMK AO2 PK WND 29029/19",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSXS",
       RawData = "KSXS 041635Z AUTO 17011G22KT 8SM BKN029 21/14 A2999 RMK AO2 SLP156 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSXK",
       RawData = "KSXK 041635Z AUTO 02022G28KT 4SM UP BKN007 BKN011 OVC030 03/03 A2944 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSWW",
       RawData = "KSWW 041635Z AUTO 27033G48KT 2 1/2SM 14/M06 A2958 RMK AO2 T01431056",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSVC",
       RawData = "KSVC 041635Z AUTO 31026G30KT 10SM CLR 06/M06 A3002 RMK AO2 T00641065",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSUZ",
       RawData = "KSUZ 041635Z AUTO 13014G25KT 1 1/2SM BR OVC012 15/15 A2941 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSUW",
       RawData = "KSUW 041635Z AUTO 02005KT 10SM SCT044 SCT050 OVC080 02/M01 A2967 RMK AO2 T00181014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSTK",
       RawData = "KSTK 041635Z AUTO 31027G35KT 10SM OVC022 03/M01 A2976 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSTF",
       RawData = "KSTF 041635Z AUTO 15020G27KT 9SM CLR 17/07 A2980 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSTE",
       RawData = "KSTE 041635Z AUTO 13007KT 10SM SCT008 SCT060 07/05 A2959 RMK AO2 T00710046",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSSI",
       RawData = "KSSI 041635Z AUTO 11014G20KT 10SM CLR 20/16 A3016 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSRR",
       RawData = "KSRR 041635Z AUTO 30026G41KT 10SM CLR 03/M08 A2984 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSPF",
       RawData = "KSPF 041635Z AUTO 31015G20KT 3/4SM -SN BKN007 BKN016 M02/M02 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSPA",
       RawData = "KSPA 041635Z AUTO 11004KT 10SM BKN034 BKN039 BKN060 12/01 A3020 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSOW",
       RawData = "KSOW 041635Z AUTO 32010G16KT 10SM CLR 05/M05 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSOA",
       RawData = "KSOA 041635Z AUTO 25019G28KT 10SM 16/M08 A2977 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSNL",
       RawData = "KSNL 041635Z AUTO 20008KT 10SM CLR 14/09 A2933 RMK AO2 P0002 T01360086",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSNK",
       RawData = "KSNK 041635Z AUTO 28040G49KT 1 3/4SM HZ SCT020 OVC027 13/M06 A2956 RMK AO2 T01331062",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSNC",
       RawData = "KSNC 041635Z AUTO 21011G18KT 10SM CLR 07/M02 A3019 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSME",
       RawData = "KSME 041635Z AUTO 18013G22KT 140V210 10SM CLR 18/M02 A2994 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSMD",
       RawData = "KSMD 041635Z AUTO 00000KT 8SM SCT060 SCT075 06/05 A2987 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSLO",
       RawData = "KSLO 041635Z AUTO 17017G29KT 10SM CLR 17/01 A2963 RMK AO2 T01660012",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSLB",
       RawData = "KSLB 041635Z AUTO 02014KT M1/4SM FG OVC002 06/06 A2943 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSJX",
       RawData = "KSJX 041635Z AUTO 16004KT 10SM BKN011 OVC018 04/02 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSJS",
       RawData = "KSJS 041635Z AUTO 17006KT 10SM CLR 15/M06 A3001 RMK AO2 T01511060",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSIK",
       RawData = "KSIK 041635Z AUTO 15017G32KT 9SM OVC100 16/M00 A2964 RMK AO2 PK WND 15032/1628 T01611002 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSHL",
       RawData = "KSHL 041635Z AUTO 03019G28KT 3SM UP BKN020 BKN028 04/04 A2944 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSHD",
       RawData = "KSHD 041635Z AUTO 22010KT 10SM CLR 14/M05 A3017 RMK AO2 T01391053",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSGS",
       RawData = "KSGS 041635Z AUTO 35007KT 4SM BR SCT006 BKN019 OVC034 06/04 A2958 RMK AO2 T00560044",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSFQ",
       RawData = "KSFQ 041635Z AUTO 18014KT 10SM CLR 16/M03 A3029 RMK AO2 T01591029",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSEZ",
       RawData = "KSEZ 041635Z AUTO VRB04KT 10SM CLR 05/M00 A3014 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSEP",
       RawData = "KSEP 041635Z AUTO 25021G30KT 10SM CLR 16/M02 A2954 RMK AO2 T01641017",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSEF",
       RawData = "KSEF 041635Z AUTO 12011KT 10SM 26/15 A3012 RMK AO2 T02580151",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSDC",
       RawData = "KSDC 041635Z AUTO 18004KT 10SM BKN060 OVC100 06/M05 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSDA",
       RawData = "KSDA 041635Z AUTO 02003KT 10SM SCT031 15/11 A2932 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSCD",
       RawData = "KSCD 041635Z AUTO 16014G21KT 10SM SCT030 BKN110 19/11 A2999 RMK AO2 T01850108",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSBS",
       RawData = "KSBS 041635Z AUTO 23003KT 10SM SCT010 BKN038 OVC043 00/M01 A2990 RMK AO1 T10021006",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSBO",
       RawData = "KSBO 041635Z AUTO 16012G20KT 10SM SCT044 SCT065 21/10 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSAZ",
       RawData = "KSAZ 041635Z AUTO 36008G15KT 10SM BKN060 02/M03 A2971 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSAR",
       RawData = "KSAR 041635Z AUTO 16017G26KT 10SM BKN120 16/01 A2962 RMK AO2 LTG DSNT W T01570009",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KSAA",
       RawData = "KSAA 041635Z AUTO 33010G14KT 10SM SCT016 BKN032 OVC046 M01/M03 A2994 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KS52",
       RawData = "KS52 041635Z AUTO 00000KT 10SM CLR M02/M03 A3006 RMK AO2 T10201033",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KS33",
       RawData = "KS33 041635Z AUTO 10SM SCT070 OVC090 02/00 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KS32",
       RawData = "KS32 041635Z AUTO 01021G27KT 10SM BKN011 OVC017 M03/M04 A2991 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KS25",
       RawData = "KS25 041635Z AUTO 33013G18KT 4SM -SN M02/M02 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KS24",
       RawData = "KS24 041635Z AUTO 21007KT 10SM BKN065 OVC075 10/M02 A2987 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRZT",
       RawData = "KRZT 041635Z AUTO 15009KT 10SM CLR 12/M08 A2995 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRZN",
       RawData = "KRZN 041635Z AUTO 03004KT 5SM -RA SCT007 BKN017 BKN028 03/02 A2962 RMK AO2 T00300024",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRZL",
       RawData = "KRZL 041635Z AUTO 13006KT 7SM RA BKN050 BKN070 OVC085 05/04 A2977 RMK AO2 P0012",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRYW",
       RawData = "KRYW 041635Z AUTO 28019G28KT 10SM CLR 18/M03 A2967 RMK AO2 T01761031",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRYV",
       RawData = "KRYV 041635Z AUTO 17007G16KT 10SM OVC032 08/04 A2961 RMK AO2 T00820043",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRXE",
       RawData = "KRXE 041635Z AUTO 23006KT 10SM OVC006 00/00 A3008 RMK AO2 CIG 004V007 T00000000",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRVL",
       RawData = "KRVL 041635Z AUTO 00000KT 10SM CLR 07/M08 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRVJ",
       RawData = "KRVJ 041635Z AUTO 14013G23KT 10SM SCT044 BKN050 22/11 A3015 RMK AO2 T02160114",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRUG",
       RawData = "KRUG 041635Z AUTO 01012KT 10SM OVC017 M04/M07 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRSN",
       RawData = "KRSN 041635Z AUTO 16019G29KT 10SM OVC014 19/17 A2946 RMK AO2 PK WND 17029/1634 LTG DSNT W - NE T01870168 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRRT",
       RawData = "KRRT 041635Z AUTO 35010KT 10SM BKN018 OVC025 M03/M06 A2988 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRRL",
       RawData = "KRRL 041635Z AUTO 09003KT 2 1/2SM BR OVC003 04/04 A2955 RMK AO2 T00440044 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRQB",
       RawData = "KRQB 041635Z AUTO 16006KT 10SM BKN013 OVC019 05/03 A2972 RMK AO2 T00500032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRPJ",
       RawData = "KRPJ 041635Z AUTO 16021G24KT 10SM OVC031 07/05 A2964 RMK AO2 T00710051",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRPH",
       RawData = "KRPH 041635Z AUTO 26019G41KT 10SM CLR 16/M02 A2942 RMK AO2 PK WND 26041/1628 P0001 T01591021",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRPD",
       RawData = "KRPD 041635Z AUTO 02005KT 5SM BR SCT006 OVC022 04/03 A2959 RMK AO2 T00410031",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KROX",
       RawData = "KROX 041635Z AUTO 35013G16KT 10SM OVC015 M02/M06 A2989 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KROS",
       RawData = "KROS 041635Z AUTO 36006KT 4SM RA BKN008 BKN016 OVC030 02/02 A2963 RMK AO2 P0002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRNV",
       RawData = "KRNV 041635Z AUTO 14018G31KT 10SM BKN085 17/12 A2959 RMK AO2 PK WND 15031/1625 LTG DSNT W AND NW T01720121 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRNP",
       RawData = "KRNP 041635Z AUTO 16004KT 10SM OVC018 05/02 A2981 RMK AO2 T00450015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRNH",
       RawData = "KRNH 041635Z AUTO 35004KT 2SM DZ OVC006 04/04 A2960 RMK AO2 T00410035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRMY",
       RawData = "KRMY 041635Z AUTO 20010G17KT 10SM -RA OVC080 06/04 A2979 RMK AO2 P0001 T00550041",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRMN",
       RawData = "KRMN 041635Z AUTO 21012G18KT 10SM CLR 17/M04 A3020 RMK AO2 T01651044",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRLD",
       RawData = "KRLD 041635Z AUTO 18009KT 10SM CLR 10/05 A3007 RMK AO2 T00970047",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRKR",
       RawData = "KRKR 041635Z AUTO 09005KT 7SM -RA BKN075 OVC085 12/11 A2941 RMK AO2 P0009",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRID",
       RawData = "KRID 041635Z AUTO 18020KT 10SM CLR 13/00 A2984 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRGK",
       RawData = "KRGK 041635Z AUTO 01004KT 10SM OVC033 07/04 A2954 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRGA",
       RawData = "KRGA 041635Z AUTO 19016G22KT 10SM CLR 16/M05 A2996 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRFI",
       RawData = "KRFI 041635Z AUTO 00000KT 10SM OVC070 15/13 A2955 RMK AO2 T01500132",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KREG",
       RawData = "KREG 041635Z AUTO 13020G27KT 7SM OVC024 23/18 A2973 RMK AO2 T02320180",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRDK",
       RawData = "KRDK 041635Z AUTO 32004KT 10SM CLR 14/14 A2934 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRCX",
       RawData = "KRCX 041635Z AUTO 01006KT 5SM BR SCT005 SCT020 OVC050 05/04 A2958 RMK AO2 T00490044",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRCV",
       RawData = "KRCV 041635Z AUTO 32020G28KT 10SM SCT070 BKN080 BKN090 04/M12 A2982 RMK AO2 T00441125",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRCR",
       RawData = "KRCR 041635Z AUTO 11007KT 10SM BKN055 OVC065 05/05 A2982 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRCM",
       RawData = "KRCM 041635Z AUTO 07009KT 4SM VCTSRA SCT026 BKN034 OVC050 10/10 A2940 RMK AO2 P0015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRCE",
       RawData = "KRCE 041635Z AUTO 24014G20KT 10SM CLR 14/00 A2929 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRBW",
       RawData = "KRBW 041635Z AUTO 16016G19KT 10SM BKN042 21/10 A3021 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRAW",
       RawData = "KRAW 041635Z AUTO 12005KT 10SM -RA OVC019 10/10 A2938 RMK AO2 LTG DSNT NE THRU S P0002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KRAS",
       RawData = "KRAS 041635Z AUTO 34018G25KT 10SM SCT030 SCT036 SCT090 22/08 A2973 RMK AO2 T02220079",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPZQ",
       RawData = "KPZQ 041635Z AUTO 16003KT 10SM SCT060 OVC080 03/00 A2973 RMK AO2 T00250002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPXE",
       RawData = "KPXE 041635Z AUTO 16014G17KT 10SM SCT033 SCT044 BKN055 20/11 A3011 RMK AO2 T02010114",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPWC",
       RawData = "KPWC 041635Z AUTO 34012G15KT 10SM SCT090 01/M03 A2974 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPVJ",
       RawData = "KPVJ 041635Z AUTO 26014G21KT 10SM CLR 14/04 A2938 RMK AO2 T01440037",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPVF",
       RawData = "KPVF 041635Z AUTO 00000KT 10SM OVC070 07/03 A3024 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPVB",
       RawData = "KPVB 041635Z AUTO 15009KT 10SM SCT022 OVC028 10/05 A2956 RMK AO1 T00950049",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPUJ",
       RawData = "KPUJ 041635Z AUTO 14004G15KT 10SM OVC021 13/07 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPTT",
       RawData = "KPTT 041635Z AUTO 33015G20KT 10SM CLR 11/M03 A2930 RMK AO2 T01121029",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPTS",
       RawData = "KPTS 041635Z AUTO 31010G18KT 270V330 3/4SM +RA BR BKN007 OVC012 10/10 A2936 RMK AO2 LTG DSNT E PRESRR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPTD",
       RawData = "KPTD 041635Z AUTO 20008KT 10SM FEW029 OVC044 03/M05 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPTB",
       RawData = "KPTB 041635Z AUTO 19003KT 10SM CLR 14/M04 A3026 RMK AO2 T01401044",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPSO",
       RawData = "KPSO 041635Z AUTO 29003KT 10SM SCT013 SCT080 M03/M07 A2991 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPSN",
       RawData = "KPSN 041635Z AUTO 19004KT 10SM FEW060 BKN090 BKN110 13/13 A2953 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPSK",
       RawData = "KPSK 041635Z AUTO 17013G24KT 10SM CLR 12/M06 A3013 RMK AO2 T01181057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPRS",
       RawData = "KPRS 041635Z AUTO 27027G35KT 10SM 14/M09 A3004 RMK AO2 T01421091",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPRO",
       RawData = "KPRO 041635Z AUTO 10016G20KT 10SM BKN016 11/10 A2934 RMK AO2 PK WND 10030/1611 CIG 014V021 T01100095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPRG",
       RawData = "KPRG 041635Z AUTO 17018G29KT 10SM SCT055 BKN100 OVC110 14/00 A2972 RMK AO2 LTG DSNT NW T01361002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPPQ",
       RawData = "KPPQ 041635Z AUTO 07007KT 10SM SCT005 SCT023 OVC060 09/09 A2958 RMK AO2 LTG DSNT NE AND W T00870085",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPPO",
       RawData = "KPPO 041635Z AUTO 18009KT 5SM -RA BR SCT038 SCT045 06/06 A2975 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPPA",
       RawData = "KPPA 041635Z AUTO 34030G40KT 7SM -RA OVC011 05/04 A2941 RMK AO2 P0003 T00500040",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPOY",
       RawData = "KPOY 041635Z AUTO 31014G19KT 10SM SCT009 M03/M06 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPOV",
       RawData = "KPOV 041635Z AUTO 20005KT 10SM BKN090 11/M10 A2995 RMK AO2 T01071103 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPNT",
       RawData = "KPNT 041635Z AUTO 15010KT 5SM VCTSRA OVC027 06/06 A2971 RMK AO2 LTG DSNT S AND SW T00620055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPNM",
       RawData = "KPNM 041635Z AUTO 01008KT 4SM RA SCT010 OVC031 03/03 A2963 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPNA",
       RawData = "KPNA 041635Z AUTO 30023G28KT 10SM CLR M01/M07 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPMV",
       RawData = "KPMV 041635Z AUTO 05003KT 10SM OVC025 13/11 A2933 RMK AO2 T01310110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPMU",
       RawData = "KPMU 041635Z AUTO 12012G22KT 10SM SCT080 SCT095 17/03 A2967 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPLU",
       RawData = "KPLU 041635Z AUTO 00000KT 10SM -DZ BKN043 BKN048 BKN120 05/05 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPLR",
       RawData = "KPLR 041635Z AUTO 18008G16KT 10SM CLR 19/11 A2998 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPKV",
       RawData = "KPKV 041635Z AUTO 33012G16KT 10SM SCT036 SCT049 21/12 A2971 RMK AO2 T02060115",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPJC",
       RawData = "KPJC 041635Z AUTO 21007KT 162V232 10SM SCT120 15/M10 A2999 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPIM",
       RawData = "KPIM 041635Z AUTO 15008KT 110V180 10SM OVC023 17/12 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPHN",
       RawData = "KPHN 041635Z AUTO 18006KT 3SM +RA OVC028 02/01 A2986 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPHG",
       RawData = "KPHG 041635Z AUTO 34027G38KT 10SM OVC015 05/02 A2939 RMK AO2 PK WND 35038/29 PRESRR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPEZ",
       RawData = "KPEZ 041635Z AUTO 30022G36KT 7SM CLR 23/M10 A2974 RMK AO2 T02301098",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPEX",
       RawData = "KPEX 041635Z AUTO 02010G15KT 4SM -RA BKN007 OVC015 01/01 A2962 RMK AO2 P0006",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPEQ",
       RawData = "KPEQ 041635Z AUTO 27034G48KT 1SM HZ 14/M07 A2981 RMK AO2 T01361070",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPEA",
       RawData = "KPEA 041635Z AUTO 13016G22KT 10SM CLR 14/08 A2940 RMK AO2 T01360076",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPDC",
       RawData = "KPDC 041635Z AUTO 09007KT 10SM OVC030 10/05 A2954 RMK AO2 T00960053",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPCZ",
       RawData = "KPCZ 041635Z AUTO 14007KT 10SM OVC050 08/04 A2960 RMK AO2 T00800040",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPCM",
       RawData = "KPCM 041635Z AUTO 13013G17KT 10SM SCT041 SCT047 26/14 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPBX",
       RawData = "KPBX 041635Z AUTO 15007G15KT 10SM CLR 16/M07 A3002 RMK AO2 T01581069",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPBH",
       RawData = "KPBH 041635Z AUTO 01004KT 7SM BKN005 OVC024 05/05 A2957 RMK AO2 T00460045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KPAN",
       RawData = "KPAN 041635Z AUTO 24007KT 10SM CLR 05/M03 A3015 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOZW",
       RawData = "KOZW 041635Z AUTO 18008KT 10SM OVC017 04/02 A2981 RMK AO2 T00440015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOZS",
       RawData = "KOZS 041635Z AUTO 15015G22KT 10SM -RA OVC029 12/08 A2940 RMK AO2 LTG DSNT N S AND W",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOZA",
       RawData = "KOZA 041635Z AUTO 28027G36KT 10SM CLR 15/M07 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOYM",
       RawData = "KOYM 041635Z AUTO 19004KT 10SM SCT110 11/M10 A3004 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOXV",
       RawData = "KOXV 041635Z AUTO 150KT 10SM CLR 13/07 A2940 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOXD",
       RawData = "KOXD 041635Z AUTO 19019G24KT 10SM CLR 17/M08 A2985 RMK AO2 T01681081",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOWX",
       RawData = "KOWX 041635Z AUTO 21009KT 10SM FEW060 BKN085 BKN095 11/00 A2987 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOWP",
       RawData = "KOWP 041635Z AUTO 24003KT 10SM BKN011 13/11 A2933 RMK AO2 T01300108",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOWA",
       RawData = "KOWA 041635Z AUTO 04003KT 8SM OVC027 06/05 A2952 RMK AO2 T00630049",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOVL",
       RawData = "KOVL 041635Z AUTO 01003G14KT 7SM OVC006 03/02 A2959 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOSC",
       RawData = "KOSC 041635Z AUTO 23007KT 10SM BKN029 OVC050 03/01 A2976 RMK AO2 PRESFR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KORS",
       RawData = "KORS 041635Z AUTO 14007KT 110V170 10SM FEW039 SCT120 09/06 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KORK",
       RawData = "KORK 041635Z AUTO 14015G27KT 1 3/4SM VCTS BR OVC007 13/13 A2943 RMK AO2 LTG DSNT ALQDS",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KORG",
       RawData = "KORG 041635Z AUTO 18018G24KT 4SM OVC008 21/19 A2961 RMK AO2 P0001 T02080192 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOQN",
       RawData = "KOQN 041635Z AUTO 20005KT 10SM CLR 09/00 A3018 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOPN",
       RawData = "KOPN 041635Z AUTO 15013KT 10SM BKN026 OVC035 17/09 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOPL",
       RawData = "KOPL 041635Z AUTO 17021G40KT 10SM RA OVC027 22/17 A2964 RMK AO2 T02200173",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOOA",
       RawData = "KOOA 041635Z AUTO 13012KT 10SM CLR 14/08 A2943 RMK AO2 T01390080",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KONP",
       RawData = "KONP 041635Z AUTO 18015G21KT 2SM -RA BKN011 OVC017 07/07 A3005 RMK AO2 P0003",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KONM",
       RawData = "KONM 041635Z AUTO 33020G34KT 10SM CLR 10/M08 A2993 RMK AO2 T01001077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KONL",
       RawData = "KONL 041635Z AUTO 35025G33KT 7SM UP OVC006 00/00 A2959 RMK AO2 P0001 T10011005",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KONA",
       RawData = "KONA 041635Z AUTO 13005KT 10SM OVC019 07/03 A2955 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOMH",
       RawData = "KOMH 041635Z AUTO 19013G17KT 10SM CLR 11/M05 A3021 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOLZ",
       RawData = "KOLZ 041635Z AUTO 13014KT 10SM OVC018 09/09 A2949 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOLY",
       RawData = "KOLY 041635Z AUTO 16016G23KT 10SM SCT085 16/M01 A2970 RMK AO2 T01601007",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOLG",
       RawData = "KOLG 041635Z AUTO 02005KT 5SM OVC004 02/01 A2962 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOLE",
       RawData = "KOLE 041635Z AUTO 24003KT 10SM BKN060 BKN080 OVC095 06/M09 A2999 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOKV",
       RawData = "KOKV 041635Z AUTO 20004KT 10SM OVC070 10/M06 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOKM",
       RawData = "KOKM 041635Z AUTO 13006KT 10SM BKN009 13/12 A2932 RMK AO2 T01290124",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOJA",
       RawData = "KOJA 041635Z AUTO 27008KT 10SM CLR 13/M01 A2929 RMK AO2 T01281008",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOIN",
       RawData = "KOIN 041635Z AUTO 35032G41KT 2 1/2SM -RA BR SCT012 02/01 A2948 RMK AO2 PK WND 33043/20 VIS 1 3/4V5",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOIC",
       RawData = "KOIC 041635Z AUTO 17010KT 10SM OVC050 05/M08 A3005 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOGS",
       RawData = "KOGS 041635Z AUTO 20010KT 10SM OVC048 02/M04 A2996 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOGA",
       RawData = "KOGA 041635Z AUTO 35034G44KT 10SM BKN017 OVC023 02/00 A2965 RMK AO2 T00220001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOEO",
       RawData = "KOEO 041635Z AUTO 36003KT 5SM BKN008 OVC028 05/04 A2963 RMK AO2 T00500042 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOEL",
       RawData = "KOEL 041635Z AUTO 36032G44KT 7SM OVC012 02/00 A2947 RMK AO1 T00210000",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOEB",
       RawData = "KOEB 041635Z AUTO 17010KT 6SM -RA BR OVC075 05/03 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOCQ",
       RawData = "KOCQ 041635Z AUTO 09004KT 5SM SCT004 OVC025 03/03 A2964 RMK AO1 T00340032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KOBE",
       RawData = "KOBE 041635Z AUTO 13008G18KT 090V150 10SM SCT041 26/16 A3009 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KO32",
       RawData = "KO32 041635Z AUTO 00000KT 10SM CLR 09/09 A3026 RMK AO2 T00910087 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KO22",
       RawData = "KO22 041635Z AUTO 00000KT 10SM OVC080 08/05 A3024 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KNY0",
       RawData = "KNY0 041635Z AUTO 00000KT 10SM SCT034 BKN042 OVC050 M01/M10 A3006 RMK AO2 T10131097",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KNRN",
       RawData = "KNRN 041635Z AUTO 34031G42KT 10SM OVC013 02/01 A2942 RMK AO2 PK WND 34045/01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KNEW",
       RawData = "KNEW 041635Z 14023G36KT 10SM SCT027 BKN034 23/16 A2981 RMK AO2 PK WND 15036/1631 T02280161",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KN79",
       RawData = "KN79 041635Z AUTO 22007KT 200V280 10SM SCT070 SCT085 07/M08 A3011 RMK AO2 T00671079",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KN38",
       RawData = "KN38 041635Z AUTO 20010KT 10SM 05/M07 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KN24",
       RawData = "KN24 041635Z AUTO 21003KT 10SM CLR M01/M05 A2985 RMK AO2 T10061047",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KN03",
       RawData = "KN03 041635Z AUTO 20010KT 10SM OVC065 03/M07 A3005 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMZZ",
       RawData = "KMZZ 041635Z AUTO 21009KT 10SM SCT060 OVC085 13/M03 A2982 RMK AO2 T01251034",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMZH",
       RawData = "KMZH 041635Z AUTO 36004KT 7SM SCT034 BKN043 OVC075 02/00 A2966 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMYZ",
       RawData = "KMYZ 041635Z AUTO 00000KT 10SM SCT038 BKN044 OVC050 13/09 A2929 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMYJ",
       RawData = "KMYJ 041635Z AUTO 12011KT 10SM TS SCT050 BKN070 BKN120 11/08 A2948 RMK AO2 LTG DSNT W AND NW",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMXO",
       RawData = "KMXO 041635Z AUTO 12012KT 10SM BKN023 OVC048 09/08 A2949 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMWO",
       RawData = "KMWO 041635Z AUTO 17011KT 10SM CLR 16/M03 A2988 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMWM",
       RawData = "KMWM 041635Z AUTO 34018G23KT 4SM BR BKN006 OVC012 02/02 A2952 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMVE",
       RawData = "KMVE 041635Z AUTO 35017G21KT 5SM RA OVC012 01/01 A2964 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMUT",
       RawData = "KMUT 041635Z AUTO 15009G15KT 10SM CLR 12/12 A2950 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMTV",
       RawData = "KMTV 041635Z AUTO 21007G14KT 180V240 10SM CLR 13/M05 A3024 RMK AO2 T01301053",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMRT",
       RawData = "KMRT 041635Z AUTO 21015G21KT 10SM CLR 12/M01 A2991 RMK AO2 T01161013",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMRJ",
       RawData = "KMRJ 041635Z AUTO 15010KT 10SM CLR 08/05 A2959 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMQS",
       RawData = "KMQS 041635Z AUTO 19003G10KT 10SM SCT075 08/M01 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMQJ",
       RawData = "KMQJ 041635Z AUTO 18018G25KT 10SM FEW120 15/M01 A2978 RMK AO2 T01471005 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMQB",
       RawData = "KMQB 041635Z AUTO 15013G18KT 7SM -RA BKN008 BKN026 OVC034 09/08 A2959 RMK AO2 P0001 T00860081",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMPZ",
       RawData = "KMPZ 041635Z AUTO 15018G23KT 10SM SCT012 12/08 A2948 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMPR",
       RawData = "KMPR 041635Z AUTO 19008KT 10SM CLR 11/04 A2931 RMK AO2 T01110043",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMPE",
       RawData = "KMPE 041635Z AUTO 17014G29KT 10SM CLR A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMOX",
       RawData = "KMOX 041635Z AUTO 35015KT 3/4SM -SN BR BKN003 BKN022 00/00 A2970 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMOP",
       RawData = "KMOP 041635Z AUTO 18007KT 10SM BKN012 OVC018 05/02 A2977 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMNZ",
       RawData = "KMNZ 041635Z AUTO 26027G36KT 10SM CLR 16/M01 A2956 RMK AO2 PK WND 27037/49",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMNI",
       RawData = "KMNI 041635Z AUTO 18014G19KT 10SM 19/07 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMNH",
       RawData = "KMNH 041635Z AUTO 34017G26KT SCT014 BKN019 OVC060 00/M03 A2977 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMNE",
       RawData = "KMNE 041635Z AUTO 28005KT 4SM +TSRA SCT006 BKN029 OVC041 12/11 A2959 RMK AO2 LTG DSNT ALQDS P0084",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMMH",
       RawData = "KMMH 041635Z AUTO 16003KT 10SM CLR M00/M06 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMLJ",
       RawData = "KMLJ 041635Z AUTO 15007G14KT 100V230 10SM FEW038 BKN070 19/11 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMLE",
       RawData = "KMLE 041635Z AUTO 08003KT 10SM OVC028 13/11 A2934 RMK AO2 T01330108",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMKS",
       RawData = "KMKS 041635Z AUTO 16007G14KT 120V180 10SM BKN047 BKN055 20/08 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMKQ",
       RawData = "KMKQ 041635Z AUTO 18026G33KT 9SM SCT028 BKN038 OVC045 25/19 A2982 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMKN",
       RawData = "KMKN 041635Z AUTO 26020G36KT 10SM CLR 16/M02 A2956 RMK AO2 T01581016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMKJ",
       RawData = "KMKJ 041635Z AUTO 22008KT 200V270 10SM CLR 12/M09 A3014 RMK AO2 T01231092",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMJQ",
       RawData = "KMJQ 041635Z AUTO 35010G14KT 2SM -RA OVC003 02/02 A2950 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMJD",
       RawData = "KMJD 041635Z AUTO 15020G30KT 10SM BKN020 BKN025 21/17 A2980 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMHP",
       RawData = "KMHP 041635Z AUTO 00000KT 10SM SCT036 SCT048 SCT070 22/12 A3015 RMK AO2 T02220122",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMHL",
       RawData = "KMHL 041635Z AUTO 09007KT 5SM RA SCT030 BKN035 OVC044 10/09 A2944 RMK AO2 P0020 LTG DSNT N THRU E",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMGR",
       RawData = "KMGR 041635Z AUTO 14016KT 10SM BKN034 BKN055 22/15 A3009 RMK AO2 T02210148",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMGN",
       RawData = "KMGN 041635Z AUTO 00000KT 10SM OVC019 04/01 A2969 RMK AO2 T00460016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMGG",
       RawData = "KMGG 041635Z AUTO 01007KT 4SM DZ OVC005 04/02 A2961 RMK AO2 P0002 T00350021",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMGC",
       RawData = "KMGC 041635Z AUTO 19010KT 10SM OVC038 06/04 A2975 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMEZ",
       RawData = "KMEZ 041635Z AUTO 12003KT 2 1/2SM -RA BR 11/11 A2943 RMK AO2 P0001 T01130113 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMDZ",
       RawData = "KMDZ 041635Z AUTO 12003KT 2 1/2SM OVC002 04/04 A2956 RMK AO2 T00400035 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMDS",
       RawData = "KMDS 041635Z AUTO 01026G32KT 10SM UP OVC008 M01/M01 A2959 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMDQ",
       RawData = "KMDQ 041635Z AUTO 17016G28KT 10SM CLR 17/08 A2993 RMK A02 T01720082",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMDD",
       RawData = "KMDD 041635Z AUTO 28029G39KT 1 1/4SM HZ VV007 14/M09 A2971 RMK AO2 T01361086",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMCJ",
       RawData = "KMCJ 041635Z AUTO VRB06G13KT 9SM FEW028 BKN033 OVC041 14/09 A2962 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMBY",
       RawData = "KMBY 041635Z AUTO 10009KT 10SM -VCTSRA BKN034 OVC039 10/08 A2946 RMK AO2 P0010 LTG DSNT ALQDS",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMBO",
       RawData = "KMBO 041635Z AUTO 15011G20KT 100V250 10SM FEW070 18/12 A2971 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMAO",
       RawData = "KMAO 041635Z AUTO 16011G17KT 10SM SCT047 18/07 A3023 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KMAN",
       RawData = "KMAN 041635Z AUTO 00000KT 10SM CLR 05/05 A3012 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KM40",
       RawData = "KM40 041635Z AUTO 14012G22KT 110V170 10SM CLR 17/06 A2986 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KM30",
       RawData = "KM30 041635Z AUTO 16011G21KT 120V190 10SM SCT100 17/M02 A2971 RMK AO2 T01721019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KM25",
       RawData = "KM25 041635Z AUTO 18016G32KT 10SM FEW170 BKN190 17/M02 A2972 RMK AO2 PK WND 17032/1625 T01661022 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KM21",
       RawData = "KM21 041635Z AUTO 16014G18KT 10SM SCT100 18/M04 A2981 RMK AO2 T01841039",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KM01",
       RawData = "KM01 041635Z AUTO 15017G27KT 9SM FEW180 17/01 A2962 RMK AO2 PK WND 16030/1621 T01680012 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLYV",
       RawData = "KLYV 041635Z AUTO 02016G26KT 7SM OVC005 01/00 A2953 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLYO",
       RawData = "KLYO 041635Z AUTO 28005KT 10SM CLR 09/01 A2930 RMK AO2 T00910009",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLXY",
       RawData = "KLXY 041635Z AUTO 22012KT 10SM SCT100 16/11 A2956 RMK AO2 T01550114 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLXN",
       RawData = "KLXN 041635Z AUTO 36028G40KT 10SM OVC015 03/00 A2948 RMK AO2 T00250001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLWA",
       RawData = "KLWA 041635Z AUTO 17010G15KT 10SM OVC036 10/05 A2973 RMK AO2 T00950052",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLVN",
       RawData = "KLVN 041635Z AUTO 35006KT 7SM OVC027 06/03 A2957 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLVL",
       RawData = "KLVL 041635Z AUTO 18008KT 10SM CLR 16/M03 A3026 RMK AO1 T01591029",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLVJ",
       RawData = "KLVJ 041635Z AUTO 31013G30KT 4SM RA FEW012 BKN022 OVC049 14/11 A2967 RMK AO2 PK WND 29032/1620 WSHFT 1615 RAE00B27 P0002 T01390111",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUX",
       RawData = "KLUX 041635Z AUTO 14007KT 10SM SCT035 BKN044 16/06 A3020 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUV",
       RawData = "KLUV 041635Z AUTO 30038G56KT 3/4SM HZ BKN019 OVC026 10/00 A2966 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUM",
       RawData = "KLUM 041635Z AUTO 36005KT 4SM OVC028 06/06 A2956 RMK AO2 T00570057 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUL",
       RawData = "KLUL 041635Z AUTO 15017G25KT 10SM SCT027 BKN035 19/12 A2986 RMK A02 T01920121",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUD",
       RawData = "KLUD 041635Z AUTO 25012G22KT 220V280 7SM CLR 15/02 A2942 RMK AO2 T01530022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLUA",
       RawData = "KLUA 041635Z AUTO 19010KT 10SM 15/M03 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLSB",
       RawData = "KLSB 041635Z AUTO 30023G28KT 10SM CLR 09/M05 A3009 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLRY",
       RawData = "KLRY 041635Z AUTO 00000KT 2SM RA OVC006 12/11 A2940 RMK AO2 P0009 LTG DSNT E",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLRU",
       RawData = "KLRU 041635Z AUTO 30013G20KT 10SM CLR 09/M08 A3000 RMK AO2 T00931077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLRO",
       RawData = "KLRO 041635Z AUTO 09007G15KT 060V120 10SM CLR 20/10 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLRJ",
       RawData = "KLRJ 041635Z AUTO 02017KT 5SM BR OVC007 04/04 A2943 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLQK",
       RawData = "KLQK 041635Z AUTO 00000KT 10SM OVC031 11/01 A3018 RMK AO2 T01130010",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLOM",
       RawData = "KLOM 041635Z AUTO 19006KT 10SM 09/M01 A3018 RMK AO2 T00881007",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLNP",
       RawData = "KLNP 041635Z AUTO 18012G19KT 10SM CLR 11/M08 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLNN",
       RawData = "KLNN 041635Z AUTO 22007KT 190V020 10SM OVC085 10/M11 A2992 RMK AO1 T01011115",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLNL",
       RawData = "KLNL 041635Z AUTO 01003KT 1 1/2SM BR OVC003 02/02 A2962 RMK AO2 T00220022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLNC",
       RawData = "KLNC 041635Z AUTO 21009KT 10SM CLR 14/10 A2950 RMK AO2 T01420095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLNA",
       RawData = "KLNA 041635Z AUTO 10018G24KT 10SM SCT023 BKN029 OVC037 24/18 A3012 RMK AO2 T02430176",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLMO",
       RawData = "KLMO 041635Z AUTO 01020G27KT 10SM CLR 09/M05 A2980 RMK AO2 T00911055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLLN",
       RawData = "KLLN 041635Z AUTO 30028G37KT 10SM FEW036 SCT044 BKN050 08/02 A2963 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLKU",
       RawData = "KLKU 041635Z AUTO 20008KT 150V250 10SM CLR 12/M02 A3020 RMK AO2 T01241024",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLKR",
       RawData = "KLKR 041635Z AUTO 16008KT 10SM BKN034 BKN044 17/07 A3021 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLJF",
       RawData = "KLJF 041635Z AUTO 01010G14KT 10SM OVC005 03/02 A2959 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLHB",
       RawData = "KLHB 041635Z AUTO 23010KT 10SM FEW085 16/13 A2960 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLGC",
       RawData = "KLGC 041635Z AUTO 17015G21KT 10SM OVC025 18/11 A3007 RMK AO2 T01840110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLDM",
       RawData = "KLDM 041635Z AUTO 17007KT 10SM OVC045 07/02 A2968 RMK AO2 T00690019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLDJ",
       RawData = "KLDJ 041635Z AUTO 20007KT 10SM SCT075 SCT090 09/M01 A3020 RMK AO2 T00911014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLCQ",
       RawData = "KLCQ 041635Z AUTO 16012G22KT 10SM SCT039 BKN050 23/13 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLCG",
       RawData = "KLCG 041635Z AUTO 01018G27KT 2SM -RA OVC004 06/05 A2943 RMK AO2 T00550050",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLBO",
       RawData = "KLBO 041635Z AUTO 15018G24KT 10SM TS OVC023 12/08 A2941 RMK AO2 LTG DSNT N NE AND SW",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KLAM",
       RawData = "KLAM 041635Z AUTO 14008KT 120V200 8SM CLR 03/M06 A2984 RMK AO2 WSHFT 1615 T00321060 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KL35",
       RawData = "KL35 041635Z AUTO 28003KT 10SM CLR 01/M03 A3020 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KL18",
       RawData = "KL18 041635Z AUTO 07004KT 10SM BKN027 12/05 A3024 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KL08",
       RawData = "KL08 041635Z AUTO 21004KT 10SM CLR 15/M01 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KKY8",
       RawData = "KKY8 041635Z AUTO 16012G23KT 120V190 10SM SCT100 18/ A2980 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KK88",
       RawData = "KK88 041635Z AUTO 27003KT 2 1/2SM RA BR SCT055 11/11 A2938 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KK83",
       RawData = "KK83 041635Z AUTO 35004KT 5SM HZ OVC033 15/06 A2931 RMK AO2 T01500057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KK82",
       RawData = "KK82 041635Z AUTO 35020G34KT 10SM OVC010 06/05 A2933 RMK AO2 T00640045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KK62",
       RawData = "KK62 041635Z AUTO 17011G20KT 10SM CLR 15/M05 A2991 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJZI",
       RawData = "KJZI 041635Z AUTO 12013KT 10SM CLR 21/12 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJYR",
       RawData = "KJYR 041635Z AUTO 35015KT 1 3/4SM BR OVC003 10/10 A2932 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJYO",
       RawData = "KJYO 041635Z AUTO 17008KT 10SM OVC085 09/M02 A3019 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJYM",
       RawData = "KJYM 041635Z AUTO 18009G14KT 8SM -RA SCT060 OVC070 04/02 A2982 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJYL",
       RawData = "KJYL 041635Z AUTO 16009KT 10SM SCT060 21/11 A3018 RMK AO2 T02120108",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJYG",
       RawData = "KJYG 041635Z AUTO 34012KT 6SM BR BKN006 BKN012 OVC035 04/04 A2952 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJWY",
       RawData = "KJWY 041635Z AUTO 24014G18KT 10SM CLR 16/08 A2949 RMK AO2 T01580076",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJWG",
       RawData = "KJWG 041635Z AUTO 30008KT 10SM CLR 13/M01 A2930 RMK AO2 T01351014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJSY",
       RawData = "KJSY 041635Z AUTO 00000KT 10SM CLR 02/M04 A3005 RMK AO2 T00151040",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJSV",
       RawData = "KJSV 041635Z AUTO 07011G21KT 10SM FEW048 FEW065 BKN090 12/12 A2934 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJSO",
       RawData = "KJSO 041635Z AUTO 25007KT 10SM OVC070 13/11 A2951 RMK AO2 UPB1609E1618 PRESFR P0000 T01290115 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJRO",
       RawData = "KJRO 041635Z AUTO 18013KT 10SM CLR 16/M07 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJPX",
       RawData = "KJPX 041635Z AUTO 20014G21KT 10SM SCT080 07/M01 A3023 RMK AO2 T00661014 FZRANO TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJOT",
       RawData = "KJOT 041635Z AUTO 16008KT 4SM RA SCT007 BKN037 OVC046 07/06 A2972 RMK AO2 P0005 T00680063",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJMR",
       RawData = "KJMR 041635Z AUTO 01003KT 5SM UP CLR 02/02 A2967 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJKJ",
       RawData = "KJKJ 041635Z AUTO 36020G25KT 10SM OVC013 M01/M04 A2984 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJHN",
       RawData = "KJHN 041635Z AUTO 34032G55KT 1 1/2SM HZ FEW003 OVC030 07/M00 A2952 RMK AO2 PK WND 34059/45 PRESRR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJGG",
       RawData = "KJGG 041635Z AUTO 23007KT 10SM CLR 16/M03 A3026 RMK AO2 T01581027 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJFZ",
       RawData = "KJFZ 041635Z AUTO 19009G16KT 160V230 10SM CLR 13/M10 A3008 RMK AO2 T01301098",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJFX",
       RawData = "KJFX 041635Z AUTO 13010G18KT 110V180 10SM CLR 18/09 A2993 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJDD",
       RawData = "KJDD 041635Z AUTO 17005KT 10SM BKN095 BKN110 12/11 A2952 RMK AO2 RAB1556E1628 P0001 T01160110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJCA",
       RawData = "KJCA 041635Z AUTO 08007KT 10SM BKN032 BKN040 OVC065 13/05 A3015 RMK AO2 T01280048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJAS",
       RawData = "KJAS 041635Z AUTO 28017G43KT 250V320 M1/4SM +TSRA FG BKN002 OVC012 12/12 A2962 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJAQ",
       RawData = "KJAQ 041635Z AUTO 00000KT 10SM OVC080 07/07 A3024 RMK AO1 T00700070",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIZA",
       RawData = "KIZA 041635Z AUTO 00000KT 10SM SCT008 08/07 A3027 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIYA",
       RawData = "KIYA 041635Z AUTO 16016G22KT 9SM OVC026 21/18 A2967 RMK AO2 CIG 025V030 T02100184",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIUA",
       RawData = "KIUA 041635Z AUTO 26007KT 10SM SCT075 BKN110 09/M05 A2999 RMK AO2 T00871049",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KISQ",
       RawData = "KISQ 041635Z AUTO 16003KT 1 1/2SM BR OVC002 03/03 A2966 RMK AO2 T00270025",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIRS",
       RawData = "KIRS 041635Z AUTO 20012KT 2 1/2SM UP BR OVC075 05/04 A2978 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIOB",
       RawData = "KIOB 041635Z AUTO 20009G16KT 10SM CLR 16/M04 A2996 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KINJ",
       RawData = "KINJ 041635Z AUTO 24014G20KT 10SM CLR 17/06 A2951 RMK AO2 T01650060",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KINF",
       RawData = "KINF 041635Z AUTO 12014KT 7SM 25/15 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIMS",
       RawData = "KIMS 041635Z AUTO 17012G20KT 10SM CLR 15/M02 A2987 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIKW",
       RawData = "KIKW 041635Z AUTO 21007KT 10SM SCT019 OVC025 06/02 A2978 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIKV",
       RawData = "KIKV 041635Z AUTO 14012G20KT 10SM CLR 13/09 A2939 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIKK",
       RawData = "KIKK 041635Z AUTO 14006KT 5SM -RA SCT049 BKN060 OVC075 05/05 A2974 RMK AO2 LTG DSNT SW P0016 T00520045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIKG",
       RawData = "KIKG 041635Z AUTO 32015G24KT 7SM OVC032 25/M02 A2975 RMK AO2 T02521020",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIJX",
       RawData = "KIJX 041635Z AUTO 07009KT 5SM SCT042 OVC060 08/08 A2958 RMK AO2 LTG DSNT N AND NE T00770075 PNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIIY",
       RawData = "KIIY 041635Z AUTO 12007KT 10SM SCT041 BKN060 OVC070 16/09 A3017 RMK AO2 T01580088",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIIB",
       RawData = "KIIB 041635Z AUTO 13016KT 10SM OVC019 10/07 A2950 RMK AO2 T00980069",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIGQ",
       RawData = "KIGQ 041635Z AUTO 18011KT 10SM RA SCT029 BKN037 OVC100 06/M21 A2973 RMK AO2 LTG DSNT S P0001 T00611215",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIFA",
       RawData = "KIFA 041635Z AUTO 13007KT 10SM OVC039 10/08 A2945 RMK AO2 T01000075",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIER",
       RawData = "KIER 041635Z AUTO 17014G23KT 10SM OVC020 21/19 A2951 RMK AO2 LTG DSNT NW T02090190",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIDP",
       RawData = "KIDP 041635Z AUTO 05026G31KT 10SM SCT070 OVC090 10/08 A2922 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIDI",
       RawData = "KIDI 041635Z AUTO 21010G16KT 10SM CLR 15/M08 A3002 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KICL",
       RawData = "KICL 041635Z AUTO 14011KT 10SM CLR 15/11 A2935 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KIBM",
       RawData = "KIBM 041635Z AUTO 34025G37KT 7SM -SN OVC011 00/M01 A2980 RMK AO2 T00031015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI95",
       RawData = "KI95 041635Z AUTO 19012G17KT 10SM SCT110 13/M02 A2982 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI75",
       RawData = "KI75 041635Z AUTO 13013KT 10SM -RA SCT022 SCT043 BKN080 13/10 A2940 RMK AO2 T01250096",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI74",
       RawData = "KI74 041635Z AUTO 19012G18KT 10SM SCT110 13/M01 A2988 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI68",
       RawData = "KI68 041635Z AUTO 18018KT 10SM CLR 14/02 A2986 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI67",
       RawData = "KI67 041635Z AUTO 19011G19KT 10SM CLR 15/M02 A2986 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI63",
       RawData = "KI63 041635Z AUTO 15011KT 2 1/2SM RA SCT034 BKN049 OVC065 08/08 A2956 RMK AO2 LTG DSNT NE E AND SW T00840077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI35",
       RawData = "KI35 041635Z AUTO 15003KT 10SM CLR 16/M07 A3004 RMK AO2 T01601069",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI23",
       RawData = "KI23 041635Z AUTO 17014G17KT 10SM CLR 12/M04 A2991 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KI16",
       RawData = "KI16 041635Z AUTO 10SM CLR 15/M06 A3011 RMK AO2 T01471062",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHZX",
       RawData = "KHZX 041635Z AUTO 35004KT 10SM OVC090 02/M01 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHZR",
       RawData = "KHZR 041635Z AUTO 21012G23KT 10SM OVC021 21/17 A2968 RMK AO2 T02100166",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHZL",
       RawData = "KHZL 041635Z AUTO 15004KT 10SM SCT075 OVC090 08/M08 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHZE",
       RawData = "KHZE 041635Z AUTO 01008KT 7SM UP BKN014 OVC020 M01/M03 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHYX",
       RawData = "KHYX 041635Z AUTO 20014KT 3SM BR FEW009 OVC025 04/02 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHYW",
       RawData = "KHYW 041635Z AUTO 15005G15KT 10SM SCT046 19/07 A3025 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHWY",
       RawData = "KHWY 041635Z AUTO 20008G15KT 10SM CLR 14/M09 A3019 RMK AO2 T01411089",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHVS",
       RawData = "KHVS 041635Z AUTO 15007KT 090V200 10SM FEW060 18/06 A3023 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHSP",
       RawData = "KHSP 041635Z AUTO 15006G15KT 10SM CLR 08/M08 A3013 RMK AO2 T00771084",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHSG",
       RawData = "KHSG 041635Z AUTO 29013G21KT 10SM OVC050 M01/M07 A3006 RMK AO2 T10091066",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHSB",
       RawData = "KHSB 041635Z AUTO 18021G31KT 10SM BKN060 OVC100 16/01 A2971 RMK AO2 T01630006",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHRX",
       RawData = "KHRX 041635Z AUTO 32026G32KT 5SM RA OVC009 06/04 A2956 RMK AO2 T00590043 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHRL",
       RawData = "KHRL 041635Z 30013G18KT 5SM HZ CLR 30/20 A2968 RMK AO2 T03000200",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHQG",
       RawData = "KHQG 041635Z AUTO 36039G49KT 4SM HZ OVC024 06/01 A2948 RMK AO2 PK WND 35049/30",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHPT",
       RawData = "KHPT 041635Z AUTO 09007KT 10SM SCT010 OVC017 08/08 A2945 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHOT",
       RawData = "KHOT 041635Z AUTO 27009G26KT RA FEW009 BKN029 OVC065 15/13 A2947 RMK AO2 PK WND 26026/1628 WSHFT 1550 LTG DSNT NE-SE TSB1555E18 P0045 T01500128 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHOE",
       RawData = "KHOE 041635Z AUTO 12017G21KT 10SM SCT037 SCT050 SCT060 23/13 A3013 RMK AO2 T02330133",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHNR",
       RawData = "KHNR 041635Z AUTO 08007KT 10SM CLR 13/11 A2935 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHMZ",
       RawData = "KHMZ 041635Z AUTO 00000KT 10SM BKN095 11/M09 A3007 RMK AO2 T01141093",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHMT",
       RawData = "KHMT 041635Z AUTO 04003KT 10SM SCT023 09/04 A3024 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHMP",
       RawData = "KHMP 041635Z AUTO 13012G17KT 10SM BKN025 BKN033 BKN060 17/09 A3013 RMK AO2 T01700085",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHJH",
       RawData = "KHJH 041635Z AUTO 35008KT 5SM BR SCT006 SCT013 SCT018 12/11 A2929 RMK AO2 T01200112",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHII",
       RawData = "KHII 041635Z AUTO VRB04KT 10SM CLR 13/01 A3016 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHHV",
       RawData = "KHHV 041635Z 2 1/2SM HZ CLR 24/22 A2962 RMK A01 WIND SENSOR OFFLINE",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHHG",
       RawData = "KHHG 041635Z AUTO 04004KT 10SM -RA BKN065 OVC075 05/05 A2983 RMK AO2 P0001 T00500050",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHFY",
       RawData = "KHFY 041635Z AUTO 20012G23KT 10SM CLR 15/M01 A2980 RMK AO2 T01531013",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHFJ",
       RawData = "KHFJ 041635Z AUTO 14014G20KT 7SM -RA SCT008 BKN021 OVC075 11/11 A2934 RMK AO2 P0013",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHEG",
       RawData = "KHEG 041635Z AUTO 11012KT 9SM BKN039 BKN049 BKN065 24/14 A3015 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHDE",
       RawData = "KHDE 041635Z AUTO 36034G43KT 10SM OVC010 03/01 A2942 RMK AO2 T00250007",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHDC",
       RawData = "KHDC 041635Z AUTO 15016G26KT 10SM SCT022 SCT036 BKN065 21/16 A2977 RMK AO2 T02110163",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHCR",
       RawData = "KHCR 041635Z AUTO 00000KT 10SM FEW004 SCT014 BKN034 OVC080 01/01 A3005 RMK AO2 SNE1556 FEW V SCT P0000 T00120012",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHCO",
       RawData = "KHCO 041635Z AUTO 34015G20KT 10SM SCT013 OVC018 M03/M06 A2995 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHCD",
       RawData = "KHCD 041635Z AUTO 03012KT 5SM BR OVC005 04/03 A2958 RMK AO2 T00410028",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHAI",
       RawData = "KHAI 041635Z AUTO 19007KT 10SM -DZ SCT039 SCT050 OVC095 05/04 A2979 RMK AO2 T00520041",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHAF",
       RawData = "KHAF 041635Z AUTO 16004KT 9SM OVC060 11/09 A3027 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KHAE",
       RawData = "KHAE 041635Z AUTO 10009G14KT 10SM VCTS BKN030 OVC050 10/08 A2952 RMK AO2 LTG DSNT SW AND W",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGZL",
       RawData = "KGZL 041635Z AUTO 11011G20KT 10SM FEW100 12/12 A2933 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGYL",
       RawData = "KGYL 041635Z AUTO 01003KT 3SM BR OVC004 04/04 A2956 RMK AO2 T00400035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGYF",
       RawData = "KGYF 041635Z AUTO 19023KT 7SM SCT015 26/23 A2968 RMK AO2 PWINO T02610226",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGYB",
       RawData = "KGYB 041635Z AUTO 29011G17KT 10SM SCT095 18/06 A2967 RMK AO2 T01800063",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGWR",
       RawData = "KGWR 041635Z AUTO 01025KT 10SM OVC013 M02/M02 A2984 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGWB",
       RawData = "KGWB 041635Z AUTO 00000KT 7SM -RA BKN070 05/03 A2987 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGVW",
       RawData = "KGVW 041635Z AUTO 18026KT 4SM HZ CLR A2962 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGVE",
       RawData = "KGVE 041635Z AUTO 21009G14KT 10SM CLR 12/M04 A3019 RMK AO1 T01161040",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGRN",
       RawData = "KGRN 041635Z AUTO 36026G32KT 10SM OVC011 M02/M04 A2984 RMK AO2 T10201041",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGPM",
       RawData = "KGPM 041635Z AUTO 24012G20KT 10SM CLR 17/02 A2948 RMK AO2 T01660022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGPC",
       RawData = "KGPC 041635Z AUTO 19019G28KT 10SM BKN110 16/M01 A2975 RMK AO2 T01611012",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGOP",
       RawData = "KGOP 041635Z AUTO 26020G28KT 10SM CLR 18/M01 A2958 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGNT",
       RawData = "KGNT 041635Z AUTO 30015G18KT 10SM CLR 03/M05 A3002 RMK AO2 T00331053",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGNC",
       RawData = "KGNC 041635Z AUTO 29033G43KT 5SM HZ SCT041 SCT055 BKN065 13/M05 A2972 RMK AO2 T01281054",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGNB",
       RawData = "KGNB 041635Z AUTO 28003KT 10SM SCT022 BKN041 OVC048 M02/M05 A2990 RMK AO2 T10201052",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGMJ",
       RawData = "KGMJ 041635Z AUTO 29007G14KT 260V320 2 1/2SM RA BR SCT047 SCT055 11/11 A2941 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGLY",
       RawData = "KGLY 041635Z AUTO 05006KT 2 1/2SM VCTS RA BR OVC018 11/11 A2937 RMK AO2 LTG DSNT E AND SE",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGLW",
       RawData = "KGLW 041635Z AUTO 17015G21KT 10SM CLR 17/02 A2990 RMK AO2 T01720018",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGIC",
       RawData = "KGIC 041635Z AUTO 00000KT 10SM CLR 03/01 A3006 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGHW",
       RawData = "KGHW 041635Z AUTO 35014G19KT 1 1/4SM -SN BKN006 OVC019 00/M01 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGHG",
       RawData = "KGHG 041635Z AUTO 22011G23KT 10SM OVC080 06/M05 A3018 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGHB",
       RawData = "KGHB 041635Z AUTO 14016G29KT 120V180 7SM SCT030 SCT035 25/22 A2972 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGGI",
       RawData = "KGGI 041635Z AUTO 14016KT 10SM CLR 15/10 A2942 RMK AO2 T01480095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGGF",
       RawData = "KGGF 041635Z AUTO 35035G46KT 9SM BKN019 BKN026 01/01 A2963 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGGE",
       RawData = "KGGE 041635Z AUTO 11013G17KT 10SM SCT041 20/09 A3024 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGDK",
       RawData = "KGDK 041635Z AUTO 19013G18KT 10SM CLR 15/M03 A2986 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGDJ",
       RawData = "KGDJ 041635Z AUTO 26028G35KT 10SM CLR 17/01 A2950 RMK AO2 T01690009",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGDB",
       RawData = "KGDB 041635Z AUTO 33013G19KT 7SM -RA BKN006 OVC010 03/02 A2964 RMK AO2 T00250017 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGDA",
       RawData = "KGDA 041635Z AUTO 17016G27KT 150V210 10SM CLR 18/M02 A2973 RMK AO2 T01801023 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGCM",
       RawData = "KGCM 041635Z AUTO 07016G22KT 10SM CLR 12/12 A2922 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGBG",
       RawData = "KGBG 041635Z AUTO 15009G16KT 110V170 7SM -RA SCT013 OVC020 09/09 A2958 RMK AO2 P0002 T00850085",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KGAO",
       RawData = "KGAO 041635Z AUTO 14013G21KT 10SM OVC019 22/17 A2982 RMK AO2 T02210173",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFZG",
       RawData = "KFZG 041635Z AUTO 16010G16KT 10SM SCT033 22/13 A3010 RMK AO2 T02240129",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFYJ",
       RawData = "KFYJ 041635Z AUTO 22010G15KT 190V250 10SM CLR 15/M03 A3027 RMK AO1 T01471035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFXY",
       RawData = "KFXY 041635Z AUTO 04006KT 10SM OVC007 07/05 A2947 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFWC",
       RawData = "KFWC 041635Z AUTO 17020G27KT 10SM SCT090 17/01 A2970 RMK AO2 T01680008",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFWB",
       RawData = "KFWB 041635Z AUTO 12012G19KT 080V140 1 1/4SM RA BR OVC004 11/11 A2934 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFSW",
       RawData = "KFSW 041635Z AUTO 12012G16KT 10SM -DZ OVC005 10/09 A2951 RMK AO2 LTG DSNT SE AND SW",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFSO",
       RawData = "KFSO 041635Z AUTO 19008G14KT 150V210 10SM 03/M09 A3000 RMK AO2 T00311087",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFSK",
       RawData = "KFSK 041635Z AUTO 32005KT 5SM RA BR SCT007 BKN023 OVC041 11/11 A2938 RMK AO2 P0015 T01140110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFSE",
       RawData = "KFSE 041635Z AUTO 01016G20KT 10SM OVC014 M02/M04 A2983 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFRH",
       RawData = "KFRH 041635Z AUTO 18012G21KT 141V201 10SM SCT060 17/M03 A2979 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFPY",
       RawData = "KFPY 041635Z AUTO 13012G16KT 10SM BKN037 BKN050 24/14 A3008 RMK AO2 T02420140",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFPK",
       RawData = "KFPK 041635Z AUTO 20012KT 10SM OVC010 06/04 A2978 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFOA",
       RawData = "KFOA 041635Z AUTO 17020G29KT 10SM CLR 16/02 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFMM",
       RawData = "KFMM 041635Z AUTO 34033G42KT 10SM SCT024 BKN030 04/01 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFLY",
       RawData = "KFLY 041635Z AUTO 35029G45KT 10SM SCT020 01/M04 A2969 RMK AO2 T00121042",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFKS",
       RawData = "KFKS 041635Z AUTO 13004KT 10SM BKN034 OVC048 06/02 A2968 RMK AO2 T00570020",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFKR",
       RawData = "KFKR 041635Z AUTO 20005KT 10SM BKN055 BKN070 OVC090 15/M00 A2976 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFKN",
       RawData = "KFKN 041635Z AUTO 19009KT 10SM CLR 15/M04 A3027 RMK AO2 T01541039",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFKA",
       RawData = "KFKA 041635Z AUTO 12004KT 10SM OVC011 08/06 A2953 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFHB",
       RawData = "KFHB 041635Z AUTO 16011G18KT 10SM CLR 22/15 A3016 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFGX",
       RawData = "KFGX 041635Z AUTO 22016G21KT 10SM CLR 15/M05 A2995 RMK AO2 T01531054",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFGN",
       RawData = "KFGN 041635Z AUTO 35010KT 10SM OVC019 M03/M06 A2989 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFFX",
       RawData = "KFFX 041635Z AUTO 17006KT 7SM OVC010 04/04 A2972 RMK AO2 T00410036",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFFM",
       RawData = "KFFM 041635Z AUTO 35020G26KT 10SM FEW014 BKN050 BKN060 00/M01 A2975 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFFL",
       RawData = "KFFL 041635Z AUTO 16013G20KT 10SM CLR 13/09 A2943 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFET",
       RawData = "KFET 041635Z AUTO 05004KT 5SM BR SCT005 BKN019 OVC070 12/11 A2934 RMK AO2 T01200106",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFEP",
       RawData = "KFEP 041635Z AUTO 17020G24KT 10SM OVC031 09/06 A2962 RMK AO2 T00860055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFDW",
       RawData = "KFDW 041635Z AUTO 13009KT 10SM SCT034 SCT050 OVC055 16/07 A3020 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFBR",
       RawData = "KFBR 041635Z AUTO 29015KT 10SM BKN018 OVC070 02/M02 A3006 RMK AO2 T00201024",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KFBL",
       RawData = "KFBL 041635Z AUTO 36006KT 10SM OVC024 07/04 A2954 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KF46",
       RawData = "KF46 041635Z AUTO 19010KT 10SM CLR 12/12 A2947 RMK AO2 T01160116",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KF44",
       RawData = "KF44 041635Z AUTO 00000KT 10SM BKN008 OVC100 12/11 A2952 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KF17",
       RawData = "KF17 041635Z AUTO 31006KT 7SM -RA SCT027 SCT035 OVC048 11/10 A2958 RMK AO2 P0019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KF05",
       RawData = "KF05 041635Z AUTO 28021G30KT 10SM SCT080 SCT110 15/M01 A2935 RMK AO2 T01461007",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KF00",
       RawData = "KF00 041635Z AUTO 10SM CLR 12/10 A2946 RMK AO2 T01230103",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEZZ",
       RawData = "KEZZ 041635Z AUTO 18009KT 3SM BR OVC006 11/ A2941 RMK AO2 P0007 T0115////",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEZS",
       RawData = "KEZS 041635Z AUTO 07004KT 7SM SCT009 OVC032 06/05 A2961 RMK AO2 T00580045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEZP",
       RawData = "KEZP 041635Z AUTO 6SM HZ FEW021 BKN028 BKN037 26/21 A2967 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEZM",
       RawData = "KEZM 041635Z AUTO 16018G22KT 10SM SCT038 SCT046 21/11 A3014 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEZF",
       RawData = "KEZF 041635Z AUTO 20012G21KT 10SM CLR 14/M03 A3019 RMK AO2 T01431029",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEVW",
       RawData = "KEVW 041635Z AUTO 26008KT 3SM -SN OVC026 M01/M03 A3005 RMK AO2 SNB08 P0000 T10061033",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEVU",
       RawData = "KEVU 041635Z AUTO 17013G20KT 7SM SCT014 SCT023 SCT030 14/12 A2933 RMK AO2 T01420123",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEVM",
       RawData = "KEVM 041635Z AUTO 03006G16KT 10SM CLR 02/M02 A2971 RMK AO2 T00171022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KETB",
       RawData = "KETB 041635Z AUTO 20008KT 10SM OVC041 08/06 A2964 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KERY",
       RawData = "KERY 041635Z AUTO 13003KT 5SM BR OVC006 02/02 A2966 RMK AO2 T00220015",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KERV",
       RawData = "KERV 041635Z AUTO 28020G31KT 10SM CLR 18/M06 A2973 RMK AO2 T01761064",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEQA",
       RawData = "KEQA 041635Z AUTO 11011KT 10SM CLR 11/09 A2926 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEOK",
       RawData = "KEOK 041635Z AUTO 14012KT 8SM BKN009 BKN013 OVC034 10/10 A2952 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEOE",
       RawData = "KEOE 041635Z AUTO 08005KT 10SM 17/05 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KENL",
       RawData = "KENL 041635Z AUTO 16016G23KT 10SM CLR 16/02 A2964 RMK AO2 LTG DSNT W T01600019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEMV",
       RawData = "KEMV 041635Z AUTO 00000KT 10SM CLR 14/M01 A3028 RMK AO2 T01441013",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEMM",
       RawData = "KEMM 041635Z AUTO 30011G14KT 10SM SCT013 BKN033 BKN065 01/M03 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KELO",
       RawData = "KELO 041635Z AUTO 03008G17KT 340V060 10SM SCT018 M01/M04 A2971 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KELK",
       RawData = "KELK 041635Z AUTO 26011KT 9SM 12/M02 A2928 RMK AO2 T01201023 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KELA",
       RawData = "KELA 041635Z AUTO 27008KT 10SM OVC055 15/12 A2966 RMK AO2 T01520116",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEKX",
       RawData = "KEKX 041635Z AUTO 20017G27KT 10SM BKN065 16/M03 A2987 RMK AO2 T01611033",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEKM",
       RawData = "KEKM 041635Z 18007KT 6SM -RA BR OVC065 05/05 A2978 RMK AO2 P0011 T00540053 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEKE",
       RawData = "KEKE 041635Z AUTO 13031KT 4SM HZ FEW026 A2965 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEIK",
       RawData = "KEIK 041635Z AUTO 02021G27KT 10SM CLR 07/M05 A2978 RMK AO2 PK WND 02027/1631 T00671051",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEHY",
       RawData = "KEHY 041635Z AUTO 36011KT 5SM BKN010 OVC018 M02/M06 A2990 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEHA",
       RawData = "KEHA 041635Z AUTO 35039G47KT 2 1/2SM -RA OVC024 05/02 A2955 RMK AO2 VIS 2 1/2V3 T00450016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEGV",
       RawData = "KEGV 041635Z AUTO 00000KT 2SM BR OVC004 03/03 A2959 RMK AO2 T00330033",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEGT",
       RawData = "KEGT 041635Z AUTO 18011KT 10SM BKN018 12/08 A2931 RMK AO2 T01230078",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEFT",
       RawData = "KEFT 041635Z AUTO 17013G18KT 10SM OVC032 08/05 A2959 RMK AO2 T00820052",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEFK",
       RawData = "KEFK 041635Z AUTO 17008KT 10SM SCT055 SCT070 BKN090 03/M10 A3000 RMK AO2 T00291102",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEDC",
       RawData = "KEDC 041635Z AUTO 28023G31KT 7SM CLR 19/01 A2960 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KECU",
       RawData = "KECU 041635Z AUTO 26017G30KT 10SM CLR 16/M08 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KECS",
       RawData = "KECS 041635Z AUTO 34019G27KT 10SM BKN027 BKN032 00/M06 A2995 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEBS",
       RawData = "KEBS 041635Z AUTO 14007KT 10SM SCT018 BKN028 BKN032 11/11 A2941 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEBG",
       RawData = "KEBG 041635Z AUTO 35012G16KT 8SM CLR 27/19 A2969 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEBA",
       RawData = "KEBA 041635Z AUTO 10006KT 10SM SCT042 OVC048 14/07 A3017 RMK AO2 T01430074",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KEAN",
       RawData = "KEAN 041635Z AUTO 33021G30KT 5SM -SN SCT014 SCT020 00/M03 A2993 RMK AO2 T00011030",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE57",
       RawData = "KE57 041635Z AUTO 30031G44KT 2SM HZ BKN055 11/M08 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE42",
       RawData = "KE42 041635Z AUTO 34033G45KT 5SM -RA BR OVC013 04/03 A2945 RMK AO2 P0002 T00430029",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE41",
       RawData = "KE41 041635Z AUTO 27025G42KT 2 1/2SM HZ SCT033 OVC041 13/M07 A2974 RMK AO2 T01261065",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE38",
       RawData = "KE38 041635Z AUTO 27036G44KT 1SM OVC010 09/M09 A2990 RMK AO2 T00901095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE16",
       RawData = "KE16 041635Z AUTO 16003KT 10SM OVC070 08/06 A3030 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KE11",
       RawData = "KE11 041635Z AUTO 29030G42KT 4SM HZ SCT021 BKN029 OVC036 13/M05 A2970 RMK AO2 T01261055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDZJ",
       RawData = "KDZJ 041635Z AUTO 09016G23KT 10SM OVC027 11/05 A3011 RMK AO2 T01150055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDZB",
       RawData = "KDZB 041635Z AUTO 28014G25KT 250V320 10SM CLR 19/M05 A2967 RMK AO2 T01861052",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDYT",
       RawData = "KDYT 041635Z AUTO 03012KT 10SM BKN043 BKN049 OVC080 01/01 A2966 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDYB",
       RawData = "KDYB 041635Z AUTO VRB05G11KT 10SM BKN044 BKN055 OVC065 20/12 A3020 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDYA",
       RawData = "KDYA 041635Z AUTO 14009G15KT 10SM SCT033 19/10 A2992 RMK AO2 T01850102",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDXX",
       RawData = "KDXX 041635Z AUTO 34023G30KT 4SM -SN SCT008 BKN021 01/M01 A2969 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDWX",
       RawData = "KDWX 041635Z AUTO 28008KT 01/M01 A2996 RMK AO2 T00071010 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDVO",
       RawData = "KDVO 041635Z AUTO 00000KT 10SM SCT025 BKN055 11/11 A3027 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDVK",
       RawData = "KDVK 041635Z AUTO 18014G19KT 10SM SCT110 16/M04 A2993 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDUX",
       RawData = "KDUX 041635Z AUTO 34037G44KT 3SM -SN SCT006 OVC018 03/03 A2949 RMK AO2 P0005 T00330032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDUH",
       RawData = "KDUH 041635Z AUTO 23006KT 10SM OVC050 08/M02 A2987 RMK AO2 T00801025",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDUC",
       RawData = "KDUC 041635Z AUTO 25018G28KT 10SM CLR 15/00 A2934 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDUA",
       RawData = "KDUA 041635Z AUTO 18015KT 10SM FEW014 FEW020 13/12 A2944 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDTL",
       RawData = "KDTL 041635Z AUTO 35015KT 10SM OVC016 M00/M03 A2976 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDRM",
       RawData = "KDRM 041635Z AUTO 11003KT 10SM OVC045 02/00 A2972 RMK AO2 T00210001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDRI",
       RawData = "KDRI 041635Z AUTO 17023G37KT 8SM -RA OVC014 21/20 A2953 RMK AO2 PK WND 15037/1624 LTG DSNT W AND NW OVC V BKN P0004 T02060196 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDQH",
       RawData = "KDQH 041635Z AUTO 16013G18KT 10SM BKN040 BKN046 OVC060 22/12 A3014 RMK AO2 T02220119",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDNV",
       RawData = "KDNV 041635Z AUTO 04005KT 10SM OVC050 09/05 A2974 RMK AO2 T00870048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDNS",
       RawData = "KDNS 041635Z AUTO 05010KT 7SM BKN013 12/12 A2938 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDNN",
       RawData = "KDNN 041635Z AUTO 14016G19KT 10SM OVC030 16/08 A3004 RMK AO2 PK WND 14026/1603 PRESFR T01640077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDNA",
       RawData = "KDNA 041635Z AUTO 29017G24KT 9SM CLR 10/M06 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDLZ",
       RawData = "KDLZ 041635Z AUTO 20012G20KT 10SM SCT120 12/M03 A2991 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDLO",
       RawData = "KDLO 041635Z AUTO 00000KT 10SM CLR 08/04 A3028 RMK AO2 T00770035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDLL",
       RawData = "KDLL 041635Z AUTO 15007KT 10SM OVC026 08/05 A2957 RMK AO2 T00810048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDKR",
       RawData = "KDKR 041635Z AUTO 25008KT 9SM CLR 15/13 A2957 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDKB",
       RawData = "KDKB 041635Z AUTO 16019G26KT 10SM OVC030 07/06 A2967 RMK AO2 T00660057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDEH",
       RawData = "KDEH 041635Z AUTO 14006G13KT 10SM OVC022 09/07 A2950 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDED",
       RawData = "KDED 041635Z AUTO 12017KT 10SM SCT039 BKN050 OVC065 24/13 A3015 RMK AO2 TSNO T02350133",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDCY",
       RawData = "KDCY 041635Z AUTO 17021G29KT 10SM SCT060 OVC070 15/00 A2976 RMK AO2 T01470002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDCM",
       RawData = "KDCM 041635Z AUTO 15006KT 10SM SCT033 SCT044 SCT060 15/05 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KDBN",
       RawData = "KDBN 041635Z AUTO 13011G18KT 10SM BKN045 BKN055 22/12 A3013 RMK AO2 T02200118 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD95",
       RawData = "KD95 041635Z AUTO 18005KT 1 1/2SM -RA BKN021 OVC028 04/04 A2984 RMK AO2 T00350035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD60",
       RawData = "KD60 041635Z AUTO 35015KT 10SM OVC011 M03/M03 A3005 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD57",
       RawData = "KD57 041635Z AUTO 34015KT 8SM -UP BKN013 BKN018 OVC024 M00/M03 A2998 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD55",
       RawData = "KD55 041635Z AUTO 36018KT 9SM -SN OVC011 M05/M05 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD50",
       RawData = "KD50 041635Z AUTO 33014KT 10SM FEW011 OVC025 M04/M06 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD39",
       RawData = "KD39 041635Z AUTO 34011G15KT 2 1/2SM -SN SCT015 SCT028 SCT049 00/00 A2967 RMK AO2 VIS 2 1/2V3 P0001 T00000000",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD25",
       RawData = "KD25 041635Z AUTO 03005KT 2SM BR OVC002 02/02 A2959 RMK AO2 T00200020",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KD09",
       RawData = "KD09 041635Z AUTO 34012G23KT 10SM OVC017 M04/M07 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCZT",
       RawData = "KCZT 041635Z AUTO 32020G30KT 5SM HZ CLR 23/M11 A2976 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCZL",
       RawData = "KCZL 041635Z AUTO 13009G16KT 090V160 10SM OVC028 16/08 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCYD",
       RawData = "KCYD 041635Z AUTO 14022KT 5SM HZ BKN028 OVC033 22/19 A2990 RMK A02 T02220191",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCXU",
       RawData = "KCXU 041635Z AUTO 15014G21KT 10SM SCT033 OVC050 22/14 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCXE",
       RawData = "KCXE 041635Z AUTO 16005KT 10SM CLR 13/M04 A3024 RMK AO1 T01311037",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCWV",
       RawData = "KCWV 041635Z AUTO 16013G20KT 130V190 10SM FEW036 BKN050 22/13 A3016 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCWC",
       RawData = "KCWC 041635Z AUTO 26018G31KT 10SM CLR 16/M03 A2937 RMK AO2 T01561028",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCVX",
       RawData = "KCVX 041635Z AUTO 17004KT 10SM OVC019 05/02 A2970 RMK AO2 PRESRR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCVH",
       RawData = "KCVH 041635Z AUTO 00000KT 10SM BKN070 09/06 A3030 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCVC",
       RawData = "KCVC 041635Z AUTO VRB04KT 10SM OVC027 15/08 A3011 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCVB",
       RawData = "KCVB 041635Z AUTO 29030G37KT 10SM CLR 22/M07 A2970 RMK AO2 PK WND 30037/56",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCUT",
       RawData = "KCUT 041635Z AUTO 36009G17KT 320V030 10SM SCT025 SCT080 OVC090 M02/M09 A2984 RMK AO2 PK WND 01028/1608 T10221089",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCUH",
       RawData = "KCUH 041635Z AUTO 15007KT 10SM OVC012 12/09 A2931 RMK AO2 T01190086",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCTY",
       RawData = "KCTY 041635Z AUTO 13010KT 110V170 10SM BKN040 BKN055 24/14 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCTJ",
       RawData = "KCTJ 041635Z AUTO 13009KT 10SM OVC020 13/07 A3011 RMK AO2 T01320074",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCSQ",
       RawData = "KCSQ 041635Z AUTO 12010KT 10SM BKN012 11/11 A2937 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCSB",
       RawData = "KCSB 041635Z AUTO 35028G40KT 1 1/4SM -SN BR SCT010 BKN016 BKN030 01/01 A2946 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCQW",
       RawData = "KCQW 041635Z AUTO 21006KT 10SM BKN043 BKN050 OVC060 17/06 A3023 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCQM",
       RawData = "KCQM 041635Z AUTO 02010KT 10SM OVC015 00/M03 A2971 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCQF",
       RawData = "KCQF 041635Z AUTO 13015G23KT 100V170 10SM BKN024 21/15 A2993 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPW",
       RawData = "KCPW 041635Z AUTO 01004G17KT 10SM BKN027 OVC036 M08/M14 A2989 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPU",
       RawData = "KCPU 041635Z AUTO 00000KT 10SM SCT090 06/03 A3026 RMK AO2 T00580033",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPT",
       RawData = "KCPT 041635Z AUTO 24021G27KT 9SM CLR 17/02 A2945 RMK AO2 PK WND 24027/1633 T01680019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPP",
       RawData = "KCPP 041635Z AUTO 13006G12KT 10SM SCT034 BKN041 OVC070 17/10 A3012 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPK",
       RawData = "KCPK 041635Z AUTO 19010G16KT 10SM CLR 16/M04 A3028 RMK AO2 T01561038",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCPF",
       RawData = "KCPF 041635Z AUTO 21013G21KT 10SM CLR 16/M10 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCOQ",
       RawData = "KCOQ 041635Z AUTO 35004KT 10SM OVC075 01/00 A2964 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCOM",
       RawData = "KCOM 041635Z AUTO 26024G33KT 10SM CLR 15/M02 A2959 RMK AO2 T01521025 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCNC",
       RawData = "KCNC 041635Z AUTO 14010G17KT 10SM BKN036 13/10 A2940 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCNB",
       RawData = "KCNB 041635Z AUTO 33017G25KT 3/4SM -SN OVC008 00/M01 A2968 RMK AO2 P0001 T00001006",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCMR",
       RawData = "KCMR 041635Z AUTO 36003KT 10SM CLR 01/M03 A3013 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCMD",
       RawData = "KCMD 041635Z AUTO 15014G26KT 10SM SCT025 16/10 A2994 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCLW",
       RawData = "KCLW 041635Z AUTO 12012G21KT 10SM CLR 24/13 A3008 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCLS",
       RawData = "KCLS 041635Z AUTO 19004KT 9SM OVC031 07/07 A3003 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCLK",
       RawData = "KCLK 041635Z AUTO 29009KT 10SM CLR 13/M02 A2930 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCLI",
       RawData = "KCLI 041635Z AUTO 13005KT 10SM SCT034 BKN060 OVC095 07/04 A2962 RMK AO2 T00710044",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKZ",
       RawData = "KCKZ 041635Z AUTO VRB06KT 10SM FEW075 SCT100 BKN120 07/M01 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKP",
       RawData = "KCKP 041635Z AUTO 03014G20KT 2SM -DZ BR OVC004 05/05 A2944 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKN",
       RawData = "KCKN 041635Z 35017KT 10SM M01/M04 A2989 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKM",
       RawData = "KCKM 041635Z AUTO 13021G26KT 10SM 17/ A2962 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKI",
       RawData = "KCKI 041635Z AUTO 14012G17KT 10SM SCT049 19/06 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKF",
       RawData = "KCKF 041635Z AUTO 16009G17KT 10SM BKN033 BKN043 22/12 A3010 RMK AO2 T02230124",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCKC",
       RawData = "KCKC 041635Z AUTO 03009G14KT 10SM CLR 01/M05 A2965 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCJR",
       RawData = "KCJR 041635Z AUTO 22010G15KT 10SM CLR 14/M07 A3019 RMK AO2 T01431075",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCIR",
       RawData = "KCIR 041635Z AUTO 16018G27KT 10SM BKN100 17/00 A2968 RMK AO2 T01651001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCIN",
       RawData = "KCIN 041635Z AUTO 08012KT 10SM OVC015 11/11 A2938 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCHK",
       RawData = "KCHK 041635Z AUTO 25012KT 10SM CLR 14/00 A2927 RMK AO2 T01430001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCGC",
       RawData = "KCGC 041635Z AUTO 13009G14KT 10SM BKN041 BKN050 24/14 A3010 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCFS",
       RawData = "KCFS 041635Z AUTO 19011KT 10SM BKN013 OVC024 05/05 A2980 RMK AO2 T00480046",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCFJ",
       RawData = "KCFJ 041635Z AUTO 20018G27KT 10SM SCT050 SCT065 14/M03 A2974 RMK AO2 T01391028",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCFE",
       RawData = "KCFE 041635Z AUTO 02010KT 2 1/2SM -RA BR OVC004 03/03 A2959 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCFD",
       RawData = "KCFD 041635Z AUTO 25008KT 10SM OVC080 15/10 A2963 RMK AO2 T01460103",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCDN",
       RawData = "KCDN 041635Z AUTO VRB06G12KT 10SM FEW055 18/07 A3022 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCDI",
       RawData = "KCDI 041635Z AUTO 20014G17KT 10SM CLR 14/M05 A2999 RMK AO2 T01391048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCDH",
       RawData = "KCDH 041635Z AUTO 27008G20KT 240V300 1SM +RA SCT002 BKN026 OVC032 15/14 A2948 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCDA",
       RawData = "KCDA 041635Z AUTO 12007KT 10SM OVC100 00/M10 A3002 RMK AO2 T00001100",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCCY",
       RawData = "KCCY 041635Z AUTO 11008KT 10SM OVC018 09/09 A2949 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCCU",
       RawData = "KCCU 041635Z AUTO 29020G28KT BKN001 OVC007 M07/M10 A2982 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCCO",
       RawData = "KCCO 041635Z AUTO 14013G16KT 10SM SCT022 BKN030 BKN035 17/09 A3010 RMK AO2 T01650085",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCCA",
       RawData = "KCCA 041635Z AUTO VRB05G10KT 2SM VCTS RA FEW003 SCT008 OVC013 13/13 A2945 RMK AO2 LTG DSNT ALQDS VIS 1 1/2V3",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCBK",
       RawData = "KCBK 041635Z AUTO 34031G45KT 4SM -RA BR OVC011 02/00 A2953 RMK AO2 P0001 T00151001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCBG",
       RawData = "KCBG 041635Z AUTO 01005KT 2 1/2SM RA BKN014 OVC027 03/M01 A2962 RMK AO2 P0006",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCBF",
       RawData = "KCBF 041635Z AUTO 08006KT 9SM OVC029 13/13 A2932 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCAV",
       RawData = "KCAV 041635Z AUTO 05008KT 9SM OVC011 09/09 A2944 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KCAD",
       RawData = "KCAD 041635Z AUTO 20004KT 10SM OVC041 04/01 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC75",
       RawData = "KC75 041635Z AUTO 16011KT 10SM -RA BKN013 OVC026 07/06 A2964 RMK AO2 LTG DSNT SE P0004 T00710057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC65",
       RawData = "KC65 041635Z AUTO 16008G15KT 5SM BR FEW034 BKN048 OVC075 06/06 A2978 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC35",
       RawData = "KC35 041635Z AUTO 15005KT 10SM OVC025 08/04 A2958 RMK AO2 T00810044 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC29",
       RawData = "KC29 041635Z AUTO 17007KT 10SM OVC029 09/06 A2960 RMK AO1 T00920057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC09",
       RawData = "KC09 041635Z AUTO 15010KT 2SM +RA BKN006 BKN010 OVC015 06/06 A2970 RMK AO2 LTG DSNT E THRU SW P0009 T00610060",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KC07",
       RawData = "KC07 041635Z AUTO 25003KT 3/4SM -SN OVC002 A2986 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBYY",
       RawData = "KBYY 041635Z AUTO 31010KT 7SM -RA FEW014 SCT023 BKN028 OVC036 15/12 A2965 RMK AO2 PK WND 20032/1607 WSHFT 1609 RAB1616 FEW V SCT P0000 T01520116",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBYL",
       RawData = "KBYL 041635Z AUTO 15013G17KT 10SM 17/M05 A2998 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBXM",
       RawData = "KBXM 041635Z AUTO 21009KT 10SM SCT060 OVC120 01/M10 A3014 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBXK",
       RawData = "KBXK 041635Z AUTO 00000KT 10SM CLR 13/M00 A3018 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBXA",
       RawData = "KBXA 041635Z AUTO 16015G25KT 10SM OVC020 22/16 A2981 RMK AO2 T02180158",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBWW",
       RawData = "KBWW 041635Z AUTO 34020G25KT 10SM OVC014 M02/M02 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBWD",
       RawData = "KBWD 041635Z AUTO 26017G29KT 9SM CLR 16/M02 A2958 RMK AO2 PK WND 26033/1618 T01601021 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBVU",
       RawData = "KBVU 041635Z AUTO 21004KT 10SM CLR 13/M03 A3014 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBVS",
       RawData = "KBVS 041635Z AUTO 13005KT 10SM BKN043 09/05 A3002 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBVN",
       RawData = "KBVN 041635Z AUTO 34022G32KT 5SM BR OVC007 04/02 A2945 RMK AO2 T00360023",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBVI",
       RawData = "KBVI 041635Z AUTO 25010KT 10SM CLR 16/M11 A2999 RMK AO2 T01551110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBUU",
       RawData = "KBUU 041635Z AUTO 18010KT 10SM OVC035 09/05 A2964 RMK AO2 T00870052 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBTA",
       RawData = "KBTA 041635Z AUTO 07009KT 7SM BKN005 OVC027 12/11 A2933 RMK AO2 T01210111",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBRY",
       RawData = "KBRY 041635Z AUTO 17014G20KT 9SM CLR 18/M04 A2987 RMK AO2 T01751042",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBRG",
       RawData = "KBRG 041635Z AUTO 29019G25KT 10SM CLR 09/M07 A2997 RMK AO2 T00941072",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBQP",
       RawData = "KBQP 041635Z AUTO 13007G23KT 060V190 10SM OVC020 18/14 A2953 RMK AO2 T01800136 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBQK",
       RawData = "KBQK 041635Z AUTO 12015KT 10SM CLR 22/15 A3018 RMK AO2 T02230148",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBPG",
       RawData = "KBPG 041635Z AUTO 27042G50KT 1/4SM HZ BKN008 BKN017 OVC027 13/M08 A2966 RMK AO2 T01331084",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBNW",
       RawData = "KBNW 041635Z AUTO 11011KT 10SM FEW018 11/11 A2937 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBNL",
       RawData = "KBNL 041635Z AUTO 16010KT 10SM FEW040 SCT050 BKN060 19/10 A3019 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBMT",
       RawData = "KBMT 041635Z AUTO 17018G30KT 4SM -RA OVC009 20/19 A2957 RMK AO2 LTG DSNT ALQS T02010185",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBKS",
       RawData = "KBKS 041635Z AUTO 35017G25KT 10SM CLR 26/M01 A2972 RMK AO2 PK WND 32027/1617 SLP024 T02561005 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBKN",
       RawData = "KBKN 041635Z AUTO 14007G13KT 10SM FEW018 13/10 A2930 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBKD",
       RawData = "KBKD 041635Z AUTO 27023G33KT 5SM HZ CLR 17/M02 A2949 RMK AO2 T01701016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBJI",
       RawData = "KBJI 041635Z AUTO 01015G19KT 10SM OVC011 M01/M04 A2979 RMK AO2 T10151042",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBIJ",
       RawData = "KBIJ 041635Z AUTO 15009G15KT 10SM OVC028 21/13 A3005 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBIE",
       RawData = "KBIE 041635Z AUTO 26004KT 10SM CLR 14/10 A2927 RMK AO2 T01350101",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBHC",
       RawData = "KBHC 041635Z AUTO 17010G17KT 140V200 10SM SCT041 SCT050 A3013 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBGE",
       RawData = "KBGE 041635Z AUTO 16012G23KT 10SM OVC029 22/15 A3005 RMK AO2 T02180149",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBEC",
       RawData = "KBEC 041635Z AUTO 16007KT 10SM BKN019 11/07 A2928 RMK AO2 T01060065",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBEA",
       RawData = "KBEA 041635Z AUTO 31020G26KT 10SM CLR 23/M08 A2973 RMK AO2 T02311081 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBDU",
       RawData = "KBDU 041635Z AUTO 01018G26KT 10SM CLR 07/M05 A2977 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBDH",
       RawData = "KBDH 041635Z AUTO 01014G20KT 6SM UP BR OVC008 03/03 A2961 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBDG",
       RawData = "KBDG 041635Z AUTO 30015G21KT 10SM CLR 07/M03 A2999 RMK AO2 T00661033 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBCK",
       RawData = "KBCK 041635Z AUTO 10003KT 10SM OVC041 08/06 A2956 RMK AO2 T00810055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBCB",
       RawData = "KBCB 041635Z AUTO 18012G19KT 10SM CLR 13/M06 A3018 RMK AO2 T01331057",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBBP",
       RawData = "KBBP 041635Z AUTO 14009KT 114V174 10SM CLR 18/07 A3023 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBBD",
       RawData = "KBBD 041635Z AUTO 27026G35KT 10SM CLR 15/M05 A2962 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBBB",
       RawData = "KBBB 041635Z AUTO 34016KT 3/4SM -SN BR BKN004 OVC016 01/01 A2966 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBAX",
       RawData = "KBAX 041635Z AUTO 20009KT 10SM SCT043 SCT060 OVC080 04/02 A2979 RMK AO2 T00400024",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBAM",
       RawData = "KBAM 041635Z AUTO 24003KT 10SM CLR 02/00 A3016 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KBAC",
       RawData = "KBAC 041635Z AUTO 36019G24KT 10SM UP OVC012 M03/M03 A2990 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAYS",
       RawData = "KAYS 041635Z AUTO 16011G19KT 10SM SCT041 SCT050 BKN065 24/12 A3013 RMK AO2 T02350124 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAXX",
       RawData = "KAXX 041635Z AUTO 27020G23KT 10SM BKN055 M02/M08 A2979 RMK AO2 T10221077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAXV",
       RawData = "KAXV 041635Z AUTO 19019G23KT 10SM SCT100 SCT120 13/10 A2982 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAXH",
       RawData = "KAXH 041635Z AUTO 29004KT 10SM -RA SCT018 BKN034 OVC040 14/12 A2967 RMK AO2 LTG DSNT SE P0005 T01390120",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAXA",
       RawData = "KAXA 041635Z AUTO 02012KT 9SM BKN009 08/08 A2945 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAWG",
       RawData = "KAWG 041635Z AUTO 17014G20KT 10SM CLR 13/09 A2944 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAVC",
       RawData = "KAVC 041635Z AUTO 21011KT 10SM CLR 15/M02 A3030 RMK AO2 T01461016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAUN",
       RawData = "KAUN 041635Z AUTO 15004KT 10SM BKN080 07/06 A3025 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAUM",
       RawData = "KAUM 041635Z AUTO 00000KT 10SM OVC008 08/06 A2951 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAUH",
       RawData = "KAUH 041635Z AUTO 01024G30KT 2 1/2SM BR OVC003 08/07 A2936 RMK AO2 P0001 T00760070",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KATS",
       RawData = "KATS 041635Z AUTO 30027G37KT 3SM HZ BKN002 BKN010 BKN016 15/M07 A2976 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KATP",
       RawData = "KATP 041635Z AUTO 16021G33KT 8SM FEW029 SCT035 OVC042 25/19 A2983 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KASW",
       RawData = "KASW 041635Z AUTO 14009KT 7SM RA OVC065 03/03 A2981 RMK AO2 P0007 T00410032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KASN",
       RawData = "KASN 041635Z AUTO 15014G25KT 10SM FEW028 20/12 A2997 RMK AO2 PK WND 14028/09 PRESFR",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KARW",
       RawData = "KARW 041635Z AUTO 14007G17KT 10SM SCT040 BKN047 BKN060 20/12 A3020 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KARV",
       RawData = "KARV 041635Z AUTO 03004KT 3SM BR BKN003 BKN065 03/03 A2958 RMK AO2 T00340028",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KARM",
       RawData = "KARM 041635Z AUTO 30008KT 10SM OVC043 16/11 A2968 RMK AO2 P0002 T01630111 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAQX",
       RawData = "KAQX 041635Z AUTO 14012KT 10SM FEW046 FEW050 20/11 A3017 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAQO",
       RawData = "KAQO 041635Z AUTO 27021G30KT 10SM CLR 18/M06 A2965 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAPS",
       RawData = "KAPS 041635Z AUTO 18022G29KT 10SM BKN022 OVC028 22/18 A2977 RMK AO2 T02170175",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KANW",
       RawData = "KANW 041635Z AUTO 35028G38KT 1 3/4SM -SN OVC007 M01/M02 A2970 RMK AO2 T10101023",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KANQ",
       RawData = "KANQ 041635Z AUTO 19009G14KT 3SM RA BR FEW039 04/04 A2983 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KANK",
       RawData = "KANK 041635Z AUTO 01013KT 10SM BKN055 04/M10 A2976 RMK AO2 T00381098",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAMN",
       RawData = "KAMN 041635Z AUTO 20008KT 3SM -DZ BR BKN016 OVC024 04/03 A2978 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KALX",
       RawData = "KALX 041635Z AUTO 16007G14KT 110V200 10SM BKN022 20/14 A3001 RMK AO2 T01950135",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KALM",
       RawData = "KALM 041635Z AUTO 34010KT 10SM CLR 10/M07 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAJZ",
       RawData = "KAJZ 041635Z AUTO 23006KT 10SM SCT025 SCT043 BKN060 05/02 A2998 RMK AO2 T00480016",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAJR",
       RawData = "KAJR 041635Z AUTO 08004G14KT 10SM OVC034 12/02 A3015 RMK AO2 T01150022",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAJG",
       RawData = "KAJG 041635Z AUTO 19023G27KT 10SM BKN080 17/00 A2974 RMK AO2 T01701002",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAIT",
       RawData = "KAIT 041635Z AUTO 00000KT 10SM BKN095 02/M02 A2970 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAIO",
       RawData = "KAIO 041635Z AUTO 03007KT 10SM FEW010 12/12 A2934 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAIK",
       RawData = "KAIK 041635Z AUTO 14010G16KT 110V170 10SM CLR 18/10 A3019 RMK AO2 T01850095",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAIG",
       RawData = "KAIG 041635Z AUTO 10003KT 2SM BR SCT002 OVC014 03/03 A2958 RMK AO2 T00310031",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAIB",
       RawData = "KAIB 041635Z AUTO 00000KT 10SM BKN013 OVC070 03/M01 A3004 RMK AO2 T00311011",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAHQ",
       RawData = "KAHQ 041635Z AUTO 03006KT 5SM BR BKN018 OVC022 12/12 A2933 RMK AO2 T01220116",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAGO",
       RawData = "KAGO 041635Z AUTO 29007G13KT 2 1/2SM BR SCT011 SCT031 BKN037 13/12 A2950 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAGI",
       RawData = "KAGI 041635Z AUTO 17032KT 7SM CLR 25/21 A2971 RMK AO2 T02480212",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAFO",
       RawData = "KAFO 041635Z AUTO 29003KT 10SM BKN035 OVC040 M02/M04 A3005 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAFK",
       RawData = "KAFK 041635Z AUTO 09003KT 7SM SCT039 OVC047 14/09 A2932 RMK AO2 T01430091",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAEL",
       RawData = "KAEL 041635Z AUTO 03003KT 10SM BKN008 OVC022 08/06 A2950 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KADU",
       RawData = "KADU 041635Z AUTO 03006KT 10SM 12/11 A2936 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KADT",
       RawData = "KADT 041635Z AUTO 34025G39KT 10SM DZ OVC018 03/00 A2959 RMK AO2 T00250000",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KADH",
       RawData = "KADH 041635Z AUTO 22011KT 10SM CLR 14/11 A2936 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KADC",
       RawData = "KADC 041635Z AUTO 01011G17KT 10SM CLR 00/M03 A2972 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KACQ",
       RawData = "KACQ 041635Z AUTO 36005KT 10SM OVC028 06/03 A2954 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KACP",
       RawData = "KACP 041635Z AUTO 15010G24KT 110V180 10SM -RA OVC020 22/17 A2960 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KACJ",
       RawData = "KACJ 041635Z AUTO 14009G20KT 9SM BKN030 BKN035 OVC049 20/14 A3005 RMK AO2 T01980143",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KACB",
       RawData = "KACB 041635Z AUTO 19004KT 10SM BKN013 OVC022 05/02 A2971 RMK AO2 T00480023",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAAS",
       RawData = "KAAS 041635Z AUTO 21019G24KT 10SM CLR 16/00 A2991 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAAO",
       RawData = "KAAO 041635Z AUTO 16009KT 10SM BKN019 11/07 A2928 RMK AO2 T01110067",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KAAA",
       RawData = "KAAA 041635Z AUTO 00000KT 10SM -TSRA OVC039 08/08 A2966 RMK AO2 LTG DSNT ALQS P0015 T00820082",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KA39",
       RawData = "KA39 041635Z AUTO 00000KT 10SM CLR 13/00 A3021 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K9Y1",
       RawData = "K9Y1 041635Z AUTO 32011KT 5SM -SN BR BKN017 BKN023 OVC044 M00/M02 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K9V9",
       RawData = "K9V9 041635Z AUTO 35019G27KT 10SM SCT016 BKN024 OVC035 00/M01 A2977 RMK AO2 T10021014",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K9A5",
       RawData = "K9A5 041635Z AUTO 18008G17KT 160V220 10SM SCT001 SCT026 15/08 A3004 RMK AO2 T01520078",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K9A4",
       RawData = "K9A4 041635Z AUTO 17018G26KT 10SM CLR 17/06 A2991 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K96D",
       RawData = "K96D 041635Z AUTO 35014G22KT 10SM OVC015 M04/M06 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K8W2",
       RawData = "K8W2 041635Z AUTO 22012G16KT 10SM CLR 14/M07 A3012 RMK AO1 T01431073",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K8T6",
       RawData = "K8T6 041635Z AUTO 32020G26KT 7SM CLR 23/M06 A2973 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K8D4",
       RawData = "K8D4 041635Z AUTO 12004KT 5SM -DZ BR SCT012 BKN025 OVC032 05/03 A2974 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K8B0",
       RawData = "K8B0 041635Z AUTO 24009G15KT 210V270 10SM CLR M00/M11 A2996 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K8A0",
       RawData = "K8A0 041635Z AUTO 14010G21KT 090V180 10SM OVC022 16/10 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K82V",
       RawData = "K82V 041635Z AUTO 33027G37KT 5SM -SN 00/M02 A2982 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K82C",
       RawData = "K82C 041635Z AUTO 14003KT 10SM SCT029 OVC041 08/05 A2958 RMK AO2 T00820054",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K81R",
       RawData = "K81R 041635Z AUTO 26024G30KT 10SM CLR 17/M01 A2963 RMK AO2 T01681013",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K7W4",
       RawData = "K7W4 041635Z AUTO 21009KT 10SM CLR 13/M02 A3020 RMK AO1 T01261018",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K7L2",
       RawData = "K7L2 041635Z AUTO 36016G22KT 10SM OVC013 M01/M03 A2995 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K79S",
       RawData = "K79S 041635Z AUTO 00000KT 10SM OVC090 M01/M03 A3016 RMK AO2 T10101027 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K77S",
       RawData = "K77S 041635Z AUTO 07003KT 6SM BR FEW034 SCT049 OVC060 07/07 A3010 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K74V",
       RawData = "K74V 041635Z AUTO 00000KT 10SM CLR 05/M05 A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6S2",
       RawData = "K6S2 041635Z AUTO 20011KT 1 1/4SM -RA BR BKN009 BKN013 08/08 A3009 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6R3",
       RawData = "K6R3 041635Z AUTO 00000KT 10SM SCT012 SCT017 OVC041 12/10 A2964 RMK AO2 P0018 T01180099",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6P9",
       RawData = "K6P9 041635Z AUTO 25020G35KT 10SM CLR 16/M02 A2951 RMK AO2 T01561020",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6L4",
       RawData = "K6L4 041635Z AUTO 15007G17KT 100V200 10SM CLR 14/M09 A3004 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6I2",
       RawData = "K6I2 041635Z AUTO 16019G25KT 10SM CLR 18/M04 A2990 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6B9",
       RawData = "K6B9 041635Z AUTO 22009G16KT 10SM FEW065 FEW080 06/M08 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6B0",
       RawData = "K6B0 041635Z AUTO 19009KT 10SM OVC070 01/M13 A3006 RMK AO2 T00141128",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6A2",
       RawData = "K6A2 041635Z AUTO 15005KT 10SM SCT025 SCT032 17/07 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K6A1",
       RawData = "K6A1 041635Z AUTO 01013G19KT 10SM SCT028 SCT047 BKN060 19/11 A3010 RMK AO2 T01900110",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K66R",
       RawData = "K66R 041635Z AUTO 29007G16KT 10SM SCT060 BKN110 18/10 A2967 RMK AO2 T01750098",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K60R",
       RawData = "K60R 041635Z AUTO 8SM OVC065 15/13 A2961 RMK AO2 SLP945 P0002 T01520135 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K5SM",
       RawData = "K5SM 041635Z AUTO M1/4SM -SN OVC001 M07/M08 A2994 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K5R8",
       RawData = "K5R8 041635Z AUTO 16023G31KT 10SM OVC013 21/19 A2957 RMK AO2 T02130191",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K5H4",
       RawData = "K5H4 041635Z AUTO 01014KT 10SM OVC013 M03/M06 A3001 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K5C1",
       RawData = "K5C1 041635Z AUTO 29016G27KT 10SM CLR 17/M07 A2972 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K5A9",
       RawData = "K5A9 041635Z AUTO 14010KT 10SM OVC024 17/10 A3009 RMK AO2 T01680102",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K57C",
       RawData = "K57C 041635Z AUTO 18009G17KT 10SM OVC032 08/05 A2962 RMK AO2 T00830045",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K54J",
       RawData = "K54J 041635Z AUTO 16015G21KT 10SM OVC030 21/14 A3000 RMK AO2 T02120143",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4V9",
       RawData = "K4V9 041635Z AUTO 34024G30KT 6SM -DZ BR OVC006 03/03 A2950 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4V1",
       RawData = "K4V1 041635Z AUTO 02010KT 10SM OVC070 04/M01 A2975 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4V0",
       RawData = "K4V0 041635Z AUTO 19007KT 10SM A2997 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4S2",
       RawData = "K4S2 041635Z AUTO 00000KT 10SM OVC050 05/02 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4S1",
       RawData = "K4S1 041635Z AUTO 18011KT 3SM -RA SCT009 OVC014 09/08 A3018 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4R5",
       RawData = "K4R5 041635Z AUTO 02010G14KT 5SM BR SCT002 OVC010 01/01 A2965 RMK AO2 P0001 T00100005",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4O4",
       RawData = "K4O4 041635Z AUTO VRB05G11KT 9SM -RA FEW080 SCT095 12/12 A2941 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4M9",
       RawData = "K4M9 041635Z AUTO 15025G30KT 10SM FEW075 16/07 A2959 RMK A01 LTG DSNT SW AND W",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4M3",
       RawData = "K4M3 041635Z AUTO 14017G25KT 3SM BR OVC022 14/12 A2948 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4F2",
       RawData = "K4F2 041635Z AUTO 17003KT 10SM OVC055 13/11 A2956 RMK AO2 LTG DSNT E P0001 T01320115",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4BM",
       RawData = "K4BM 041635Z AUTO 30022G29KT 10SM SCT025 SCT032 M05/M12 A2979 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4B8",
       RawData = "K4B8 041635Z AUTO 19008G16KT 10SM CLR 06/M04 A3016 RMK AO2 T00621042 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4A9",
       RawData = "K4A9 041635Z AUTO 13008G18KT 090V170 10SM BKN025 BKN031 15/08 A3000 RMK AO2 T01520077",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K4A6",
       RawData = "K4A6 041635Z AUTO 18014G20KT 10SM SCT028 17/09 A2998 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K49A",
       RawData = "K49A 041635Z AUTO 12008G16KT 070V180 10SM BKN024 OVC050 15/09 A3010 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K48I",
       RawData = "K48I 041635Z AUTO 00000KT 10SM BKN160 OVC190 16/M07 A3002 RMK AO2 T01631069",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K48A",
       RawData = "K48A 041635Z AUTO 15014G23KT 10SM SCT037 SCT042 BKN049 21/12 A3011 RMK AO2 T02110122",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K42J",
       RawData = "K42J 041635Z AUTO 13013G18KT 9SM BKN038 BKN046 BKN055 23/13 A3011 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K41U",
       RawData = "K41U 041635Z AUTO 28004KT 10SM SCT034 BKN065 04/M02 A3011 RMK AO1 T00391024",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K40U",
       RawData = "K40U 041635Z AUTO 30016G24KT 10SM OVC090 03/M05 A3002 RMK AO2 T00311048",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3U3",
       RawData = "K3U3 041635Z AUTO 21005KT 10SM FEW043 OVC065 M02/M04 A3006 RMK AO2 T10231040 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3T5",
       RawData = "K3T5 041635Z AUTO 28008KT 10SM CLR 19/07 A2963 RMK AO2 T01940074 $",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3R7",
       RawData = "K3R7 041635Z AUTO 15020G24KT 7SM SCT023 BKN028 OVC035 21/19 A2963 RMK AO2 T02080192",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3N8",
       RawData = "K3N8 041635Z AUTO 01015G20KT 10SM OVC013 M01/M03 A2981 RMK AO2 T10111035",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3LF",
       RawData = "K3LF 041635Z AUTO 16015KT 10SM SCT120 14/05 A2960 RMK AO2 LTG DSNT N AND W T01360046",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3K7",
       RawData = "K3K7 041635Z AUTO 36039G49KT 9SM -RA OVC012 02/01 A2949 RMK AO2 PK WND 35057/04",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3K3",
       RawData = "K3K3 041635Z AUTO 35039G54KT 2 1/2SM HZ SCT025 BKN044 OVC055 06/02 A2950 RMK AO2 PK WND 34056/06 PRESRR VIS 2V3",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3F3",
       RawData = "K3F3 041635Z AUTO 25004KT 4SM VCTSRA SCT007 BKN012 OVC050 13/13 A2961 RMK AO2 LTG DSNT ALQS P0044 T01280125",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3D2",
       RawData = "K3D2 041635Z AUTO 15006KT 5SM BR SCT003 OVC020 04/03 A2965 RMK AO2 T00370032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K3AU",
       RawData = "K3AU 041635Z AUTO 15006KT 10SM SCT014 SCT060 10/05 A2928 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K36K",
       RawData = "K36K 041635Z AUTO 35038G55KT 5SM HZ OVC019 04/01 A2949 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K35A",
       RawData = "K35A 041635Z AUTO 16005KT 10SM CLR 14/05 A3024 RMK A02 T01430049",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K33V",
       RawData = "K33V 041635Z AUTO 32010KT 10SM SCT035 BKN041 BKN065 M03/M06 A2990 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2V5",
       RawData = "K2V5 041635Z AUTO 34028G41KT 10SM BKN022 BKN030 03/00 A2968 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2R9",
       RawData = "K2R9 041635Z AUTO 28020G29KT 10SM CLR 23/M03 A2973 RMK AO2 T02291032",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2R2",
       RawData = "K2R2 041635Z AUTO 18016G24KT 9SM CLR 16/M00 A2976 RMK AO2 T01601005",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2P2",
       RawData = "K2P2 041635Z AUTO 17003KT 10SM OVC017 04/04 A2965 RMK AO2 T00360036",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2M8",
       RawData = "K2M8 041635Z AUTO 14012G26KT 10SM FEW160 SCT200 17/00 A2963 RMK AO2 PK WND 17026/1625 LTG DSNT W AND NW T01690001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2J9",
       RawData = "K2J9 041635Z AUTO 16012G21KT 110V200 23/15 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2IS",
       RawData = "K2IS 041635Z AUTO 10017G25KT 10SM BKN036 OVC043 25/16 A3010 RMK AO2 T02490165",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2I0",
       RawData = "K2I0 041635Z AUTO 17016G21KT 10SM SCT100 18/M04 A2979 RMK AO2 T01801040",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2G9",
       RawData = "K2G9 041635Z AUTO 25006KT 10SM CLR 12/M09 A3004 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2D5",
       RawData = "K2D5 041635Z AUTO 36022G30KT OVC009 M01/ A2985 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K2C8",
       RawData = "K2C8 041635Z AUTO 35018G23KT 9SM OVC013 M04/M04 A2999 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K28J",
       RawData = "K28J 041635Z AUTO 13011G22KT 9SM SCT040 SCT060 24/14 A3013 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K24J",
       RawData = "K24J 041635Z AUTO 15008G19KT 110V230 10SM SCT039 SCT046 BKN055 24/14 A3010 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K22N",
       RawData = "K22N 041635Z AUTO 00000KT 10SM OVC100 05/M05 A3017 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K21D",
       RawData = "K21D 041635Z AUTO 35004KT 1 3/4SM -DZ SCT004 OVC021 05/04 A2960 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K20U",
       RawData = "K20U 041635Z AUTO 33015G21KT 10SM -RA M03/M04 A3006 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1V6",
       RawData = "K1V6 041635Z AUTO 30018G26KT 10SM CLR 10/M05 A2971 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1S5",
       RawData = "K1S5 041635Z AUTO 00000KT 10SM CLR 06/03 A3006 RMK AO2 T00630031",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1R8",
       RawData = "K1R8 041635Z AUTO 15013G26KT 120V190 10SM BKN029 22/14 A2991 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1R7",
       RawData = "K1R7 041635Z AUTO 14013G21KT 9SM BKN020 OVC075 18/15 A2974 RMK A01 TSNO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1P1",
       RawData = "K1P1 041635Z AUTO 00000KT BKN075 OVC090 00/M12 A3009 RMK AO2 T00031119 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1H2",
       RawData = "K1H2 041635Z AUTO 14013G25KT 10SM SCT110 15/01 A2968 RMK AO2 T01540010",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1F0",
       RawData = "K1F0 041635Z AUTO 25013G23KT 10SM CLR 16/02 A2937 RMK AO2 T01570019",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1B9",
       RawData = "K1B9 041635Z AUTO 21014G22KT 10SM OVC080 06/M07 A3018 RMK AO2 T00611075",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1A9",
       RawData = "K1A9 041635Z AUTO 15006G16KT 10SM OVC024 19/12 A2998 RMK AO2 T01860115",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K1A6",
       RawData = "K1A6 041635Z AUTO 16006G16KT 10SM CLR 14/M06 A3005 RMK AO2 T01391062",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K19S",
       RawData = "K19S 041635Z AUTO 35041G48KT 1 3/4SM HZ OVC018 05/01 A2944 RMK AO2 T00530010",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K18H",
       RawData = "K18H 041635Z AUTO 15025G41KT 2SM HZ BKN026 BKN030 26/21 A2971 RMK A01",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K18A",
       RawData = "K18A 041635Z AUTO 08005KT 10SM BKN022 OVC038 13/04 A3017 RMK AO2 T01310043",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K17J",
       RawData = "K17J 041635Z AUTO 19020G24KT 10SM BKN030 OVC036 22/13 A3006 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K15M",
       RawData = "K15M 041635Z AUTO 16017G25KT 10SM SCT200 17/06 A2985 RMK AO2 T01700055",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K14Y",
       RawData = "K14Y 041635Z AUTO 36009G16KT 1 3/4SM -SN OVC031 A2968 RMK AO2 P0001",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K13K",
       RawData = "K13K 041635Z AUTO 08020G28KT 10SM OVC095 10/09 A2927 RMK AO2 T00980086",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K11R",
       RawData = "K11R 041635Z AUTO 26003KT 10SM OVC070 16/11 A2964 RMK AO2 T01560106",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K10G",
       RawData = "K10G 041635Z AUTO 20008KT 10SM BKN090 11/M05 A2996 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0VG",
       RawData = "K0VG 041635Z AUTO 16007KT 10SM CLR 14/M08 A3007 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0V4",
       RawData = "K0V4 041635Z AUTO 18011G20KT 10SM CLR 13/00 A3022 RMK AO1",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0S9",
       RawData = "K0S9 041635Z AUTO 00000KT 10SM FEW020 BKN095 07/05 A2999 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0R4",
       RawData = "K0R4 041635Z AUTO 14019G27KT BKN025 BKN030 OVC048 21/16 A2964 RMK AO2 T02100155 PWINO",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0F2",
       RawData = "K0F2 041635Z AUTO 25017G31KT 10SM 15/00 A2940 RMK AO2 T01541004",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K0E0",
       RawData = "K0E0 041635Z AUTO 29034G40KT 10SM CLR 07/M07 A2984 RMK AO2 T00671073",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K08D",
       RawData = "K08D 041635Z AUTO 35013G20KT 10SM BKN013 OVC018 M02/M03 A3002 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K06D",
       RawData = "K06D 041635Z AUTO 02012KT 10SM OVC013 M06/M08 A3000 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K06C",
       RawData = "K06C 041635Z AUTO 19017G23KT 10SM OVC031 09/05 A2968 RMK AO2 T00850053",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "K04W",
       RawData = "K04W 041635Z AUTO 02007KT 4SM RA SCT032 OVC043 03/03 A2963 RMK AO2",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "CYTL",
       RawData = "CYTL 041635Z AUTO 03004KT 340V060 8SM -SN BKN014 OVC046 M10/M13 A2997 RMK SLP170",
       LastChange = "2025-03-04T16:35:00Z"
    },
    new Metar {
       Station = "KJXI",
       RawData = "KJXI 041855Z AUTO 00000KT 10SM -RA SCT002 SCT080 12/11 A2952 RMK AO2 T01200107",
       LastChange = "2025-03-04T16:34:21Z"
    },
    new Metar {
       Station = "PAVC",
       RawData = "PAVC 041634Z AUTO 00000KT 10SM BKN014 OVC022 M02/M03 A2961 RMK AO2 UPB18E32 FZRANO PNO $",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "PAPN",
       RawData = "PAPN 041634Z AUTO 00000KT 3/4SM BR FEW019 BKN027 OVC090 01/01 A2963 RMK AO2 RAE02 P0000 FZRANO $",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "PAMC",
       RawData = "PAMC 041634Z AUTO 00000KT 1 3/4SM BR CLR M07/M08 A2975 RMK AO2 I1000 T10671083 TSNO $",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KSTJ",
       RawData = "KSTJ 041634Z 16013G22KT 4SM -RA BR SCT011 OVC060 13/11 A2937 RMK AO2 P0004 T01330111",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KMHE",
       RawData = "KMHE 041634Z AUTO 35025G35KT 3/4SM -SN BR OVC007 M01/M02 A2967 RMK AO2 PK WND 34035/1634 P0000 T10111022 $",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KGLD",
       RawData = "KGLD 041634Z AUTO 34035G50KT 3/4SM -SN BR BKN008 BKN011 OVC019 02/00 A2956 RMK AO2 PK WND 34056/1609 P0000 T00170000",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KFLP",
       RawData = "KFLP 041634Z AUTO 13009G15KT 4SM +RA BR OVC014 12/12 A2944 RMK AO2 LTG DSNT N AND S AND NW TSB01E16 P0009",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KDVN",
       RawData = "KDVN 041634Z AUTO 13014KT 10SM OVC030 11/07 A2955 RMK AO2 T01110072",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KCOU",
       RawData = "KCOU 041634Z 13012KT 5SM -TSRA SCT050 BKN070 OVC090 12/09 A2944 RMK AO2 LTG DSNT ALQDS RAB1557E16B24 TSB00E15B28 P0008 T01170089",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "KAZO",
       RawData = "KAZO 041634Z 19011KT 10SM SCT009 OVC040 06/04 A2978 RMK AO2 T00560044",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "CYND",
       RawData = "CYND 041634Z 21006KT 3/4SM -SN OVC007 00/M02 A2997 RMK SN6NS2 SLP153",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "CYBU",
       RawData = "CYBU 041634Z AUTO 16006KT 9SM -SN OVC033 M08/M10 A3011 RMK SLP227",
       LastChange = "2025-03-04T16:34:00Z"
    },
    new Metar {
       Station = "YPJT",
       RawData = "YPJT 041633Z AUTO 11017G27KT 9999 // NCD 20/07 Q1022",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "SKIB",
       RawData = "SKIB 041633Z 05005KT 5000 -DZ BKN005 23/22 Q1018",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KXVG",
       RawData = "KXVG 041633Z AUTO 36006G14KT 10SM CLR 01/M04 A2970 RMK AO2",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KRUE",
       RawData = "KRUE 041633Z AUTO VRB06G15KT 1 1/2SM +RA BR SCT007 BKN012 OVC024 15/13 A2942 RMK AO2 LTG DSNT E-S TSE1558B07E22 T01500128 PNO",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KRSL",
       RawData = "KRSL 041633Z AUTO 35021G30KT 10SM BKN012 08/06 A2928 RMK AO2 PK WND 36030/1632 T00830056",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KMKG",
       RawData = "KMKG 041633Z 14007KT 9SM SCT011 OVC027 06/04 A2972 RMK AO2 PRESFR T00610039",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KLBF",
       RawData = "KLBF 041633Z AUTO 35030G48KT 2SM -SN BR BKN014 OVC020 02/00 A2955 RMK AO2 PK WND 36048/1633 P0000 T00170000",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KFOZ",
       RawData = "KFOZ 041633Z AUTO 01007G15KT 343V053 10SM 01/M03 A2979 RMK AO2",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KETH",
       RawData = "KETH 041633Z AUTO 36019G27KT 10SM OVC013 00/M03 A2980 RMK AO2",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KDVP",
       RawData = "KDVP 041633Z AUTO 35020G27KT 3/4SM BR OVC001 01/01 A2957 RMK AO2 T00130010",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KCVO",
       RawData = "KCVO 041633Z AUTO 16006KT 7SM -RA SCT008 BKN017 OVC046 07/07 A3008 RMK AO2 CIG 012V022 P0003",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KAQP",
       RawData = "KAQP 041633Z 34019G26KT 1SM -SN 01/M01 A2969 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "CYZF",
       RawData = "CYZF 041633Z 09003KT 15SM -SN SCT024 OVC078 M14/M16 A3000 RMK SC4AC4 SLP184",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "CYPW",
       RawData = "CYPW 041633Z 11012G20KT 060V130 20SM SCT011 BKN063 OVC110 07/05 A2998 RMK SF4SC1AS3 VIS N 4 LO CLD BR SLP155",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "CYPQ",
       RawData = "CYPQ 041633Z AUTO 19009KT 9SM -RA FEW034 SCT042 BKN060 BKN072 04/M03 A2991 RMK SLP138",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "CYNM",
       RawData = "CYNM 041633Z AUTO 26006KT 230V290 9SM -SN OVC011 M01/M03 A2972 RMK SLP081",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "CYEN",
       RawData = "CYEN 041633Z AUTO 33013KT 9SM SCT011 OVC023 M04/M07 A3006 RMK SLP216",
       LastChange = "2025-03-04T16:33:00Z"
    },
    new Metar {
       Station = "KGAF",
       RawData = "KGAF 041835Z AUTO 36021G26KT 9SM OVC011 M03/M05 A2997 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:32:33Z"
    },
    new Metar {
       Station = "YPPH",
       RawData = "YPPH 041632Z 09019G29KT CAVOK 20/07 Q1022",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "SAZM",
       RawData = "SAZM 041632Z 32014KT 9000 -TSRA FEW050CB OVC080 22/20 Q1013",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "PAWN",
       RawData = "PAWN 041632Z AUTO 00000KT 2SM -SN BR M12/M14 A2981 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "PAGN",
       RawData = "PAGN 041632Z AUTO 00000KT 1/2SM FG OVC003 01/01 A2994 RMK AO2 FZRANO RVRNO",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KSBN",
       RawData = "KSBN 041632Z 18009KT 6SM -RA BR BKN036 BKN070 OVC095 07/06 A2978 RMK AO2 P0002 T00720061",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KRKS",
       RawData = "KRKS 041632Z AUTO 17003KT 1/2SM SN FZFG BKN010 OVC019 M03/M03 A3000 RMK AO2 P0001 T10281033",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KRAP",
       RawData = "KRAP 041632Z 34022G33KT 4SM -SN SCT009 BKN040 OVC048 01/M03 A2993 RMK AO2 PK WND 35036/1622 P0001 T00061028",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KOLU",
       RawData = "KOLU 041632Z AUTO 34017KT 2SM -RA BR OVC004 07/07 A2938 RMK AO2 RAB09 P0000",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KMSY",
       RawData = "KMSY 041632Z 15024G35KT 9SM BKN027 BKN032 OVC065 23/18 A2979 RMK AO2 PK WND 14035/1632 T02280178",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KCNK",
       RawData = "KCNK 041632Z AUTO 09004KT 9SM BKN008 BKN015 12/12 A2928 RMK AO2 CIG 006V011 T01220117",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KCMX",
       RawData = "KCMX 041632Z AUTO 04005KT 2SM HZ OVC040 04/01 A2964 RMK AO2 RAB05E14 P0000 T00390006",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KBAD",
       RawData = "KBAD 041632Z AUTO 25003KT 1 7/8SM VCTSRA OVC048 14/12 A2957 RMK AO2 VIS 1 7/8V3 RAE09RAB13 TSE09TSB15E32 SLP017",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "KACV",
       RawData = "KACV 041632Z AUTO 14004KT 9SM OVC028 09/09 A3021 RMK AO2 RAE31 P0001 T00890089",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "CYRA",
       RawData = "CYRA 041632Z 33007KT 15SM OVC021 M15/M17 A3001 RMK SC8 SNW CVR/MUCH LOOSE SLP190",
       LastChange = "2025-03-04T16:32:00Z"
    },
    new Metar {
       Station = "SUCA",
       RawData = "SUCA 041631Z 17011KT 130V200 9999 TS BKN010 FEW040CB 26/24 Q1012",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "SBFN",
       RawData = "SBFN 041631Z AUTO 13004KT 090V200 9999 BKN014 28/25 Q1009",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "PAEH",
       RawData = "PAEH 041631Z AUTO 00000KT 2 1/2SM -SHSN BR OVC004 M06/M07 A2961 RMK AO2 SLP040 $",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "MMSM",
       RawData = "MMSM 041631Z 26009KT 8SM SKC 23/05 A3031 RMK HZY ISOL CI",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KPIA",
       RawData = "KPIA 041631Z 16011KT 4SM -RA BR OVC004 08/07 A2964 RMK AO2 LTG DSNT E-SW P0008 T00780072",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KLIT",
       RawData = "KLIT 041631Z 16019G30KT 4SM RA BR OVC013 14/13 A2945 RMK AO2 PK WND 19031/1603 TSE04 P0014 T01440128 $",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KHYR",
       RawData = "KHYR 041631Z AUTO 36004KT 3SM BR OVC004 03/02 A2960 RMK AO2 CIG 003V008 T00330022",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KELD",
       RawData = "KELD 041631Z AUTO 26013G26KT 1SM +TSRA BR SCT011 OVC016 13/13 A2955 RMK AO2 PK WND 27040/1617 WSHFT 1608 LTG DSNT N AND S AND SW TSB31 PRESRR P0062 T01330133",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KDIK",
       RawData = "KDIK 041631Z AUTO 34014G22KT 3SM -SN SCT013 BKN019 OVC036 M01/M04 A2999 RMK AO2 P0000 T10111044",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "KCEU",
       RawData = "KCEU 041631Z AUTO 04005KT 10SM BKN029 OVC037 12/03 A3018 RMK AO2 T01220028",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "K1IN",
       RawData = "K1IN 041631Z AUTO 35015KT 10SM FEW015 SCT023 BKN029 BKN036 M01/M04 A2998 RMK AO2 SNE21 CIG 029V036 BKN029 V SCT SLP183 $",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "CYRL",
       RawData = "CYRL 041631Z 01007KT 350V060 15SM -SN SCT014 OVC018 M05/M08 A2989 RMK CF4SC4 CIG RAG SLP146",
       LastChange = "2025-03-04T16:31:00Z"
    },
    new Metar {
       Station = "ZYTX",
       RawData = "ZYTX 041630Z 18001MPS CAVOK M03/M06 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZYTL",
       RawData = "ZYTL 041630Z VRB01MPS 9999 -SN FEW011 BKN026 01/M00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZWWW",
       RawData = "ZWWW 041630Z 33001MPS 1600 -SN BR BKN007 M02/M03 Q1035 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZSSS",
       RawData = "ZSSS 041630Z 35005MPS 9999 BKN015 07/04 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZSPD",
       RawData = "ZSPD 041630Z 32005MPS 9999 BKN016 07/06 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZSHC",
       RawData = "ZSHC 041630Z 33004MPS 300V360 7000 -RA SCT012 BKN020 06/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZMCK",
       RawData = "ZMCK 041630Z VRB02MPS CAVOK M14/M18 Q1026 NOSIG RMK QFE652.8 75",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZGGG",
       RawData = "ZGGG 041630Z 33005MPS 9999 -SHRA SCT015 OVC020 15/12 Q1013 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZBYN",
       RawData = "ZBYN 041630Z 04001MPS 4000 HZ NSC 01/M04 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZBTJ",
       RawData = "ZBTJ 041630Z 16001MPS 6000 NSC M01/M03 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZBAD",
       RawData = "ZBAD 041630Z 18002MPS CAVOK M01/M09 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ZBAA",
       RawData = "ZBAA 041630Z 16005MPS CAVOK 03/M11 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YWLM",
       RawData = "YWLM 041630Z AUTO 11007KT 9999 // BKN025 BKN036 OVC046 21/20 Q1018 RESHRA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSTW",
       RawData = "YSTW 041630Z AUTO 17011KT 9999 // NCD 20/15 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSSY",
       RawData = "YSSY 041630Z AUTO 20015KT 9999 // BKN032 BKN044 OVC053 21/18 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSRI",
       RawData = "YSRI 041630Z AUTO 25001KT 9999 // BKN023 OVC028 OVC043 18/18 Q1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSNF",
       RawData = "YSNF 041630Z AUTO 07011KT 9999 // OVC014 22/20 Q1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSDU",
       RawData = "YSDU 041630Z AUTO 13007KT 9999 // NCD 17/13 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YSCB",
       RawData = "YSCB 041630Z AUTO 11005KT 9999 -RA NCD 10/10 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPXM",
       RawData = "YPXM 041630Z AUTO 15008KT 9999 // ////// 26/25 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPWR",
       RawData = "YPWR 041630Z AUTO 17008KT 9999 // NCD 24/M02 Q1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPTN",
       RawData = "YPTN 041630Z AUTO 00000KT 9999 // NCD 25/21 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPPD",
       RawData = "YPPD 041630Z AUTO 27007KT 9999 // NCD 30/28 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPLM",
       RawData = "YPLM 041630Z AUTO 21005KT 9999 // NCD 30/23 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPKU",
       RawData = "YPKU 041630Z AUTO 03004KT 9999 // NCD 29/25 Q1007",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPKG",
       RawData = "YPKG 041630Z AUTO 13018KT 9999 // OVC025 19/13 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPGV",
       RawData = "YPGV 041630Z AUTO 00000KT 9999 // BKN026 BKN031 27/25 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPEA",
       RawData = "YPEA 041630Z AUTO 09019G31KT 9999 // NCD 21/08 Q1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPDN",
       RawData = "YPDN 041630Z AUTO 33005KT 9999 // NCD 27/26 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPCC",
       RawData = "YPCC 041630Z AUTO 12010KT 9999 // FEW020 29/26 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YPAD",
       RawData = "YPAD 041630Z 00000KT CAVOK 21/04 Q1016",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YMML",
       RawData = "YMML 041630Z AUTO 01009KT 9999 // NCD 17/09 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YMLT",
       RawData = "YMLT 041630Z AUTO 31008KT 9999 // SCT029 16/12 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YMHB",
       RawData = "YMHB 041630Z AUTO 35008KT 9999 // NCD 17/11 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YMAV",
       RawData = "YMAV 041630Z AUTO 30004KT 9999 // NCD 15/12 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YLHI",
       RawData = "YLHI 041630Z AUTO 09035G48KT 1800 -SHRA FEW008 BKN012 OVC022 22/21 Q1009 RESHRA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YHID",
       RawData = "YHID 041630Z AUTO 11006KT 9999 // FEW020 28/25 Q1007",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YGLA",
       RawData = "YGLA 041630Z AUTO 21005KT 9999 // SCT020 24/21 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YGEL",
       RawData = "YGEL 041630Z AUTO 15008KT 9999 // NCD 20/15 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YFRT",
       RawData = "YFRT 041630Z AUTO 15022KT 9999 // OVC021 21/16 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YCIN",
       RawData = "YCIN 041630Z AUTO 36015KT 9999 -RA SCT025 BKN075 BKN120 28/24 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBWW",
       RawData = "YBWW 041630Z AUTO 17009KT 9999 // NCD 21/15 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBTL",
       RawData = "YBTL 041630Z AUTO 36006KT 9999 // FEW023 27/23 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBSU",
       RawData = "YBSU 041630Z AUTO 23009KT 9999 // NCD 23/16 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBRM",
       RawData = "YBRM 041630Z AUTO 01007KT 9999 // NCD 29/27 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBRK",
       RawData = "YBRK 041630Z AUTO 00000KT 9999 // NCD 23/22 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBMA",
       RawData = "YBMA 041630Z AUTO 29001KT 9999 // NCD 25/11 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBLN",
       RawData = "YBLN 041630Z AUTO 12013KT 9999 // NCD 15/06 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBHM",
       RawData = "YBHM 041630Z AUTO 33004KT 9999 // NCD 26/24 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBCS",
       RawData = "YBCS 041630Z AUTO 15006KT 9999 // NCD 25/23 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBCG",
       RawData = "YBCG 041630Z AUTO 21013KT 9999 // FEW038 SCT125 24/18 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBBN",
       RawData = "YBBN 041630Z 23011KT 9999 -RA FEW048 SCT110 BKN120 22/19 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YBAS",
       RawData = "YBAS 041630Z AUTO 06005KT 9999 // NCD 25/03 Q1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "YAMB",
       RawData = "YAMB 041630Z AUTO 19011KT 9999 -RA OVC125 24/18 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WSSS",
       RawData = "WSSS 041630Z 04006KT 010V070 9999 FEW016 BKN300 27/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WMKP",
       RawData = "WMKP 041630Z 35004KT 290V050 8000 FEW025 30/23 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WMKK",
       RawData = "WMKK 041630Z 00000KT 9999 SCT030 28/26 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIPP",
       RawData = "WIPP 041630Z 03001KT 5000 BR SCT013 25/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIOO",
       RawData = "WIOO 041630Z 05002KT 6000 BKN010 24/24 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIMM",
       RawData = "WIMM 041630Z 20005KT 5000 HZ FEW018 27/27 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WILL",
       RawData = "WILL 041630Z 00000KT 3000 BR SCT012 25/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIII",
       RawData = "WIII 041630Z 10004KT 2000 +RA OVC020 25/24 Q1009 TEMPO FM1710 5000 -RA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIHH",
       RawData = "WIHH 041630Z 13005KT 6000 SCT017 26/25 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIEE",
       RawData = "WIEE 041630Z 32004KT 9999 -RA SCT020 BKN160 25/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WIBB",
       RawData = "WIBB 041630Z 00000KT 8000 FEW014 24/23 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WBSB",
       RawData = "WBSB 041630Z 33002KT 9999 -SHRA SCT014 BKN140 26/24 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WBKK",
       RawData = "WBKK 041630Z VRB02KT 9999 FEW014 27/26 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WBGG",
       RawData = "WBGG 041630Z 00000KT 9999 SCT020 24/24 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WATT",
       RawData = "WATT 041630Z AUTO 13002KT 9999 NCD 25/25 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WARR",
       RawData = "WARR 041630Z 01002KT 8000 FEW020 28/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAPP",
       RawData = "WAPP 041630Z 01004KT 9999 SCT017 26/25 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAOO",
       RawData = "WAOO 041630Z AUTO 03005KT 310V070 9999 SCT020 SCT055 27/26 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAMM",
       RawData = "WAMM 041630Z VRB03KT 9999 FEW020 24/24 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WALL",
       RawData = "WALL 041630Z 32005KT 9000 TS FEW015CB SCT18 27/27 Q1009 RMK CB TO S",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAJJ",
       RawData = "WAJJ 041630Z 00000KT 9999 FEW012CB FEW013 26/26 Q1008 RMK CB AT NW",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAHS",
       RawData = "WAHS 041630Z AUTO VRB02KT 4700 BR NCD 27/25 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WADL",
       RawData = "WADL 041630Z AUTO 00000KT 6000 NCD 26/25 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WADD",
       RawData = "WADD 041630Z 12004KT 9999 FEW017 28/27 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WABB",
       RawData = "WABB 041630Z 06011KT 210V060 6000 RA FEW014CB SCT015 25/24 Q1009 NOSIG RMK CB AT E AND SW",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "WAAA",
       RawData = "WAAA 041630Z 09002KT 6000 -RA FEW017CB SCT018 25/25 Q1009 TEMPO TL1700 4000 RA RMK CB IN APCH",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VYYY",
       RawData = "VYYY 041630Z 18002KT 6000 FEW020 28/25 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVVD",
       RawData = "VVVD 041630Z AUTO VRB01KT 4600 SCT000/// 23/23 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVTS",
       RawData = "VVTS 041630Z 15009KT 9999 FEW014 27/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVPQ",
       RawData = "VVPQ 041630Z VRB01KT 9999 FEW017 25/23 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVPB",
       RawData = "VVPB 041630Z 31002KT 6000 SCT013 26/25 Q1007 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVNB",
       RawData = "VVNB 041630Z 11008KT 7000 SCT010 BKN014 BKN023 24/23 Q1007 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVDN",
       RawData = "VVDN 041630Z 14003KT 060V180 CAVOK 26/24 Q1007 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVCT",
       RawData = "VVCT 041630Z 14003KT 9999 FEW017 26/24 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVCR",
       RawData = "VVCR 041630Z 18004KT CAVOK 26/23 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VVCI",
       RawData = "VVCI 041630Z 11007KT 5000 -DZ BR OVC004 23/23 Q1007 TEMPO 2500 BR BKN003",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTSS",
       RawData = "VTSS 041630Z VRB01KT 9999 SCT020 27/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTSP",
       RawData = "VTSP 041630Z 30004KT 270V330 9999 FEW020 28/25 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTCC",
       RawData = "VTCC 041630Z VRB02KT CAVOK 24/14 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTBU",
       RawData = "VTBU 041630Z 20008KT 9999 FEW020 28/26 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTBS",
       RawData = "VTBS 041630Z 19011KT 9999 FEW020 29/23 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VTBD",
       RawData = "VTBD 041630Z 18010KT CAVOK 29/23 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOTV",
       RawData = "VOTV 041630Z 33003KT 5000 BR SCT012 BKN080 29/26 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOTR",
       RawData = "VOTR 041630Z 11005KT 6000 SCT016 28/24 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOTP",
       RawData = "VOTP 041630Z VRB03KT 6000 FEW020 26/22 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VORY",
       RawData = "VORY 041630Z 15006KT 6000 FEW020 27/22 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOMM",
       RawData = "VOMM 041630Z 20003KT 6000 FEW020 28/24 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOML",
       RawData = "VOML 041630Z 00000KT 4000 BR FEW015 SCT080 28/25 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOKN",
       RawData = "VOKN 041630Z VRB02KT 5000 BR FEW012 28/25 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOHY",
       RawData = "VOHY 041630Z 00000KT 6000 NSC 24/12 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOHS",
       RawData = "VOHS 041630Z 08004KT 6000 SCT015 SCT100 24/09 Q1016 TEMPO COR 5000 HZ",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOGO",
       RawData = "VOGO 041630Z 19004KT 4000 BR NSC 29/25 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOGA",
       RawData = "VOGA 041630Z 14003KT 3000 FU NSC 28/18 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOCL",
       RawData = "VOCL 041630Z 23002KT 6000 SCT012 28/26 Q1011 TEMPO 5000 BR",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOCI",
       RawData = "VOCI 041630Z 08002KT 4000 BR SCT012 BKN080 28/25 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOCB",
       RawData = "VOCB 041630Z VRB02KT 5000 HZ FEW015 SCT080 29/14 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOBL",
       RawData = "VOBL 041630Z 08006KT 6000 NSC 24/10 Q1017 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VOBG",
       RawData = "VOBG 041630Z 10006KT 6000 NSC 24/13 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VNKT",
       RawData = "VNKT 041630Z 19003KT 8000 FEW015 16/07 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VMMC",
       RawData = "VMMC 041630Z 05003KT 7000 FEW006 SCT020 21/20 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VLVT",
       RawData = "VLVT 041630Z 24002KT 5000 BR NSC 26/22 Q1006 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VILK",
       RawData = "VILK 041630Z 27009KT 5000 HZ NSC 19/04 Q1013 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VIJP",
       RawData = "VIJP 041630Z 34004KT 4000 HZ NSC 20/01 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VIDP",
       RawData = "VIDP 041630Z 27005G15KT 4500 HZ NSC 17/11 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VIAR",
       RawData = "VIAR 041630Z 30005KT 6000 NSC 12/07 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VHHH",
       RawData = "VHHH 041630Z 29004KT 240V310 9999 FEW005 SCT015 21/20 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VGHS",
       RawData = "VGHS 041630Z 00000KT 3500 HZ NSC 25/10 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VERP",
       RawData = "VERP 041630Z 30004KT 4000 HZ NSC 27/10 Q1013 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VERC",
       RawData = "VERC 041630Z 34008KT 4000 HZ NSC 22/09 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VEPT",
       RawData = "VEPT 041630Z 27007KT 3000 HZ NSC 25/14 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VEGT",
       RawData = "VEGT 041630Z 22003KT 2500 HZ FEW020 19/13 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VEDO",
       RawData = "VEDO 041630Z 29002KT 4500 HZ NSC 23/11 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VECC",
       RawData = "VECC 041630Z 15003KT 3200 HZ NSC 26/14 Q1009 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VEBS",
       RawData = "VEBS 041630Z 20005KT 4000 BR NSC 26/22 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VEBN",
       RawData = "VEBN 041630Z 27008KT 3000 HZ NSC 20/11 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VDSV",
       RawData = "VDSV 041630Z 08003KT 9000 FEW017 25/24 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VDSA",
       RawData = "VDSA 041630Z 20002KT 9000 FEW020 27/22 Q1008",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VDPP",
       RawData = "VDPP 041630Z 20004KT 9999 FEW017 28/25 Q1007",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VASU",
       RawData = "VASU 041630Z 01008KT 6000 NSC 25/11 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VANP",
       RawData = "VANP 041630Z 34010KT 4000 HZ FEW100 29/09 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VAID",
       RawData = "VAID 041630Z 02006KT 5000 HZ NSC 22/08 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VABB",
       RawData = "VABB 041630Z 36004KT 3000 FU NSC 29/15 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "VAAH",
       RawData = "VAAH 041630Z 32003KT 4000 FU NSC 22/M01 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWWW",
       RawData = "UWWW 041630Z 17006MPS 9999 OVC010 M05/M06 Q1006 R15/450145 NOSIG RMK QFE743/0991",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWUU",
       RawData = "UWUU 041630Z 17009MPS 3000 -SN OVC020 M08/M10 Q1013 R14R/490542 TEMPO 0600 +SHSN BKN007CB",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWSG",
       RawData = "UWSG 041630Z 25005MPS 9999 OVC033 02/01 Q1004 R26/290155 NOSIG RMK QFE750/1000",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWPS",
       RawData = "UWPS 041630Z 19005MPS 4900 -SN BR OVC005 00/M00 Q0999 R20/290253 NOSIG RMK QFE732",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWOO",
       RawData = "UWOO 041630Z 15006MPS 9999 -SN BLSN OVC028 M08/M10 Q1016 R26/490245 NOSIG RMK QFE752/1002",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWLL",
       RawData = "UWLL 041630Z 13003MPS 2500 -SN BKN013 M03/M04 Q1003 R20/810250 NOSIG RMK QFE742/0989",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWKS",
       RawData = "UWKS 041630Z 16005MPS 9999 BKN008 M02/M03 Q1001 R06/520150 NOSIG RMK QFE735",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWKE",
       RawData = "UWKE 041630Z 17004MPS 5000 -SN BKN043 M05/M06 Q1006 R21/410250 NOSIG RMK QFE738/0984",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UWKD",
       RawData = "UWKD 041630Z 15006MPS 6000 -SN OVC009 M03/M04 Q1003 R11/420342 NOSIG RMK QFE742/0990",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUYY",
       RawData = "UUYY 041630Z 15004MPS 9999 FEW016CB BKN030 M03/M05 Q1002 R18/29//51 NOSIG RMK QFE743/0991",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUWW",
       RawData = "UUWW 041630Z 25005MPS 9999 BKN008 OVC020 02/01 Q0996 R24/510345 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUOO",
       RawData = "UUOO 041630Z 26006MPS 9999 OVC021 02/M00 Q1005 R12/290150 NOSIG RMK QFE740",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUOL",
       RawData = "UUOL 041630Z AUTO 26007MPS 9000 ///010 01/01 Q1003",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUOK",
       RawData = "UUOK 041630Z 26005MPS 9999 OVC022 03/00 Q1007 R30/190050 NOSIG RMK QFE737/0983",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUOB",
       RawData = "UUOB 041630Z 23006MPS 9999 OVC010 02/00 Q1010 R11/120065 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUEE",
       RawData = "UUEE 041630Z 24005MPS 9999 OVC008 02/01 Q0995 R24L/290136 R24C/290136 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUDL",
       RawData = "UUDL 041630Z 18002MPS 3000 -RASN BKN005 OVC017 01/M00 Q0993 R23/290350 NOSIG RMK QBB150 QFE736",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUDD",
       RawData = "UUDD 041630Z 23004MPS 9999 BKN006 02/02 Q0997 R32L/290042 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UUBC",
       RawData = "UUBC 041630Z 25005MPS 9999 -RA BKN009 02/01 Q1000 R31/290150 NOSIG RMK QFE733/0977",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTTT",
       RawData = "UTTT 041630Z 06004KT 320V090 CAVOK 02/M07 Q1029 R08R/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTST",
       RawData = "UTST 041630Z 06004KT CAVOK 04/M02 Q1029 R25/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTSS",
       RawData = "UTSS 041630Z 13012KT 9999 NSC 00/M07 Q1026 R09/70D NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTSK",
       RawData = "UTSK 041630Z 06006KT CAVOK 03/M06 Q1026 R16/CLRD70",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTSB",
       RawData = "UTSB 041630Z 12006KT CAVOK 05/M07 Q1026 R01/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTSA",
       RawData = "UTSA 041630Z 10008KT 9999 NSC 02/M05 Q1027 R07/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTNU",
       RawData = "UTNU 041630Z 11010KT CAVOK 05/M04 Q1023 R13/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTNN",
       RawData = "UTNN 041630Z 07006KT CAVOK 02/M02 Q1023 R33/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTFN",
       RawData = "UTFN 041630Z 34008KT 9999 NSC 02/M09 Q1031 R28/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTFF",
       RawData = "UTFF 041630Z 13004KT 9999 NSC 01/M11 Q1031 R18/CLRD70",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTDT",
       RawData = "UTDT 041630Z VRB01MPS 8000 NSC 03/01 Q1028 R35/CLRD70 RMK QFE731/0975",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTDL",
       RawData = "UTDL 041630Z 07006MPS 9999 NSC 02/M06 Q1030 R08/CLRD70 NOSIG RMK QFE732/0977",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTDK",
       RawData = "UTDK 041630Z 02002MPS 9999 NSC 01/M02 Q1029 R01/09//70 RMK QFE714/0952",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UTDD",
       RawData = "UTDD 041630Z VRB02MPS 6000 NSC 02/M05 Q1030 R09/D NOSIG RMK QFE703/0937",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USTR",
       RawData = "USTR 041630Z 17005MPS CAVOK M10/M14 Q1016 R21/090065 R30/090065 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USSS",
       RawData = "USSS 041630Z 17002MPS CAVOK M05/M12 Q1012 R26L/11//60 NOSIG RMK QFE738/0985",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USRR",
       RawData = "USRR 041630Z 15002MPS 110V180 CAVOK M06/M12 Q1021 R25/CLRD60 RMK QFE760",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USPP",
       RawData = "USPP 041630Z 13003MPS 9999 -SN BKN030 M07/M10 Q1010 R21/490160 TEMPO 2200 -SN RMK QFE747",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USNN",
       RawData = "USNN 041630Z 16002MPS CAVOK M08/M13 Q1023 R21/31//65 NOSIG RMK QFE762",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USHH",
       RawData = "USHH 041630Z 12002MPS CAVOK M10/M15 Q1018 R06/410260 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USDA",
       RawData = "USDA 041630Z AUTO 09004MPS 9999 NCD M33/M36 Q1019 RMK QFE763/1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USCM",
       RawData = "USCM 041630Z 20005MPS 9999 SCT040 M10/M13 Q1014 R36/090060 NOSIG RMK QFE722",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "USCC",
       RawData = "USCC 041630Z 16003MPS CAVOK M09/M12 Q1013 R27/000060 NOSIG RMK QFE740",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URWW",
       RawData = "URWW 041630Z 25010MPS 7000 OVC011 01/M01 Q1012 R23/510150 TEMPO 1000 BR OVC002",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URWI",
       RawData = "URWI 041630Z AUTO 26013MPS 9999 // ///046/// 01/M02 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URWA",
       RawData = "URWA 041630Z 23006MPS CAVOK 01/M01 Q1020 R27/010070 NOSIG RMK QFE767/1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URSS",
       RawData = "URSS 041630Z 08003MPS 9999 FEW033 04/01 Q1027 R06/010070 R02/////// NOSIG RMK R02/05002MPS MT OBSC QFE769",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URRP",
       RawData = "URRP 041630Z 26010MPS 9999 OVC037 02/M00 Q1017 R23/CLRD70 NOSIG RMK QFE755/1007",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URMT",
       RawData = "URMT 041630Z 29006MPS 9999 SCT034 00/M02 Q1021 R25/120060 NOSIG RMK QFE727",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URMO",
       RawData = "URMO 041630Z 06005MPS 9999 NSC M02/M04 Q1023 R09/190054 NOSIG RMK QFE723/0964",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URMN",
       RawData = "URMN 041630Z 17001MPS 9999 SCT025 00/M04 Q1023 R24/110060 NOSIG RMK QFE730",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URMM",
       RawData = "URMM 041630Z 22005MPS 9999 OVC032 03/M02 Q1024 R29/850148 NOSIG RMK QFE739/0986",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URML",
       RawData = "URML 041630Z 27003MPS 9999 NSC 00/M03 Q1026 R32/01//70 NOSIG RMK QFE769/1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URMG",
       RawData = "URMG 041630Z 00000MPS CAVOK 00/M03 Q1025 R08/090070 TEMPO 0300 FZFG BKN002 RMK QFE754/1006",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URKK",
       RawData = "URKK 041630Z 22006MPS 9999 BKN044 03/M02 Q1024 R23L/290060 NOSIG RMK QFE765",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "URKA",
       RawData = "URKA 041630Z 32004MPS 9999 BKN021CB 04/01 Q1024 R21/150060 NOSIG RMK QFE763/1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNWW",
       RawData = "UNWW 041630Z 14001MPS 7000 SCT035 M06/M11 Q1032 R19/820245 NOSIG RMK QFE746",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNTT",
       RawData = "UNTT 041630Z 17003MPS CAVOK M08/M11 Q1028 NOSIG RMK QFE756",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNOO",
       RawData = "UNOO 041630Z 21002MPS 9000 NSC M11/M13 Q1024 R25/490545 NOSIG RMK QFE760",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNNT",
       RawData = "UNNT 041630Z 20005MPS 9000 -SHSN OVC019CB M05/M08 Q1029 R25/490143 R34/////// NOSIG RMK QFE761/1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNKL",
       RawData = "UNKL 041630Z 28002MPS 9999 SCT032 M07/M10 Q1030 R29/810260 NOSIG RMK QFE746",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNEE",
       RawData = "UNEE 041630Z 14003MPS 9999 SCT035 M09/M11 Q1029 R23/////// NOSIG RMK QFE749",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNBB",
       RawData = "UNBB 041630Z 18003MPS 9999 BKN040CB M07/M10 Q1031 R24/410250 NOSIG RMK QFE751",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UNAA",
       RawData = "UNAA 041630Z 00000MPS 1700 1200N R02/P2000U FU BR NSC M16/M18 Q1031 R02/CLRD65 NOSIG RMK QFE750",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UMMS",
       RawData = "UMMS 041630Z 27009G13MPS 9999 BKN026 05/01 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UMKK",
       RawData = "UMKK 041630Z 28011G16MPS 9999 OVC018 06/03 Q1015 R24/95D NOSIG RMK QFE760/1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UMIO",
       RawData = "UMIO 041630Z 29007G11MPS 9999 -RA SCT014 OVC021 04/02 Q1006 NOSIG RMK QFE737/0983",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UMGG",
       RawData = "UMGG 041630Z 27010G13MPS 9999 OVC043 06/M00 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ULWC",
       RawData = "ULWC 041630Z 17003MPS 3200 -SHSNRA BKN002 OVC016CB 00/M00 Q0989 R21/290260 TEMPO 1000 SHSNRA BKN013CB RMK QBB080 QFE732/0976",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ULOO",
       RawData = "ULOO 041630Z 28004MPS 240V330 CAVOK 02/M03 Q1000 R01/290050 NOSIG RMK QFE746",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ULMM",
       RawData = "ULMM 041630Z 12001MPS 8000 -SHSN BKN028CB M01/M02 Q0985 R13/650245 NOSIG RMK QFE733",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ULLI",
       RawData = "ULLI 041630Z 29008MPS 9999 FEW009 SCT024CB BKN043 01/M00 Q0995 RESHRA RESHSN R88/290050 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ULAA",
       RawData = "ULAA 041630Z 15003MPS 120V200 9999 BKN012 M00/M00 Q0989 R08/390150 NOSIG RMK QFE741/0988",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UIUU",
       RawData = "UIUU 041630Z 02001MPS 3700 FU NSC M15/M17 Q1029 R26/810860 NOSIG RMK QFE727/0969",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UIII",
       RawData = "UIII 041630Z 00000MPS CAVOK M08/M14 Q1028 R30/60D NOSIG RMK QFE726/0968",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UIBB",
       RawData = "UIBB 041630Z AUTO 28002MPS 4700 // ///009/// M08/M09 Q1027 RMK QBB280 QFE727/0969",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UIAA",
       RawData = "UIAA 041630Z VRB01MPS 9999 NSC M09/M16 Q1025 R29/410164 NOSIG RMK QFE710/0947",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UHWW",
       RawData = "UHWW 041630Z 28002MPS 9999 NSC M06/M16 Q1028 R25L/0///70 NOSIG RMK QFE770",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UHMA",
       RawData = "UHMA 041630Z 02006MPS CAVOK M28/M31 Q1019 R02/////// NOSIG RMK MID 02005MPS END R02/02004MPS QFE761/1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UHHH",
       RawData = "UHHH 041630Z 18003MPS CAVOK M17/M25 Q1029 R23R/090060 NOSIG RMK QFE765/1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UGTB",
       RawData = "UGTB 041630Z 33014KT CAVOK 05/M05 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UGSB",
       RawData = "UGSB 041630Z 11004KT CAVOK 03/01 Q1027 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UGMS",
       RawData = "UGMS 041630Z AUTO 03003KT 350V070 //// ////// M05/M10 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UGKO",
       RawData = "UGKO 041630Z 13002KT CAVOK 02/M01 Q1027 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UGAM",
       RawData = "UGAM 041630Z AUTO VRB02KT //// ////// 00/00 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UERR",
       RawData = "UERR 041630Z 00000MPS CAVOK M31/M34 Q1032 R07/810250 NOSIG RMK QFE743/0991",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UEEE",
       RawData = "UEEE 041630Z 27003MPS CAVOK M30/M34 Q1029 R23/450155 NOSIG RMK QFE763",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UDYZ",
       RawData = "UDYZ 041630Z 33002KT 9999 NSC 04/M03 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UDSG",
       RawData = "UDSG 041630Z 08005KT 9999 NSC M03/M07 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UCFO",
       RawData = "UCFO 041630Z 17001MPS 1500 1300N R12/P1500N FU NSC M02/M08 Q1030 TEMPO 0600 FZFG FU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UCFM",
       RawData = "UCFM 041630Z 18002MPS 5000 BR FU NSC M04/M08 Q1032 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UBBZ",
       RawData = "UBBZ 041630Z AUTO 36006KT 9999 // ///////// 07/M02 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UBBN",
       RawData = "UBBN 041630Z 11004KT 9999 FEW046 SCT100 06/M03 Q1021 NOSIG RMK QFE690",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UBBG",
       RawData = "UBBG 041630Z 24006KT 9999 BKN100 07/M07 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UBBF",
       RawData = "UBBF 041630Z AUTO 22002KT 110V270 9999 // ///////// 04/M03 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UBBB",
       RawData = "UBBB 041630Z 32008KT 9999 SCT016 04/02 Q1027 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAUU",
       RawData = "UAUU 041630Z 22007MPS 9000 -SN OVC040 M10/M12 Q1017 TEMPO 1500 SN BLSN RMK QFE746/0995",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UATT",
       RawData = "UATT 041630Z 17005MPS 9999 BKN020 M11/M14 Q1020 TEMPO 17013MPS RMK QFE745/0994",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UATG",
       RawData = "UATG 041630Z 20008MPS 5000 BR OVC002 M01/M02 Q1020 NOSIG RMK QBB080 QFE767/1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UATE",
       RawData = "UATE 041630Z VRB01MPS 9000 OVC014 01/M00 Q1024 NOSIG RMK QFE767/1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UASP",
       RawData = "UASP 041630Z 19003MPS 3300 -SN BKN036 M09/M11 Q1028 TEMPO 1000 SN OVC003 RMK QFE760/1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UARR",
       RawData = "UARR 041630Z 17012MPS 4400 -SN BLSN BKN010 OVC023 M03/M05 Q1011 NOSIG RMK QFE755/1007",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAOO",
       RawData = "UAOO 041630Z 14004MPS CAVOK M03/M07 Q1030 NOSIG RMK QFE761/1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAKK",
       RawData = "UAKK 041630Z 22007MPS 9999 -SN DRSN SCT025 M12/M14 Q1027 NOSIG RMK QFE723/0964",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAIT",
       RawData = "UAIT 041630Z 09004MPS CAVOK M03/M06 Q1031 NOSIG RMK QFE748/0998",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAII",
       RawData = "UAII 041630Z 07002MPS CAVOK M00/M07 Q1030 NOSIG RMK QFE737/0983",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UADD",
       RawData = "UADD 041630Z 12002MPS 9999 NSC M04/M08 Q1030 NOSIG RMK QFE715/0953",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UACC",
       RawData = "UACC 041630Z 23005MPS 2100 SN SCT014 OVC029 M12/M14 Q1027 TEMPO 1500 SN BKN010 RMK QFE738/0985",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "UAAA",
       RawData = "UAAA 041630Z 13003MPS 9999 FEW050 M04/M10 Q1034 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "TFFR",
       RawData = "TFFR 041630Z AUTO 11014KT 9999 FEW041 29/20 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "TFFJ",
       RawData = "TFFJ 041630Z AUTO 13009KT 080V170 9999 SCT025 29/22 Q1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "TFFF",
       RawData = "TFFF 041630Z AUTO 12014KT 9999 SCT039 30/20 Q1013 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "SPZO",
       RawData = "SPZO 041630Z 10007KT 070V140 9999 VCSH SCT040 BKN100 12/08 Q1031 NOSIG RMK BIRD HAZARD RWY 10/28",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "SPJR",
       RawData = "SPJR 041630Z 14005KT 100V170 9999 SCT025 BKN060 19/11 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "SOCA",
       RawData = "SOCA 041630Z AUTO 04015KT 9999 BKN028 BKN041 BKN068 30/23 Q1011 TEMPO 2500 SHRA SCT012 BKN015TCU BKN025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "SBMQ",
       RawData = "SBMQ 041630Z 09010KT 2000 RA BR BKN009 BKN033 OVC070 26/25 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "ROAH",
       RawData = "ROAH 041630Z AUTO 36017KT 9999 BKN007 OVC140 20/18 Q1014 RMK A2997",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RKSI",
       RawData = "RKSI 041630Z 04010KT CAVOK 02/M03 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJTT",
       RawData = "RJTT 041630Z 34022KT 5000 -RA BR FEW006 BKN008 BKN018 03/02 Q1022 TEMPO 4000 -RA BR RMK 1ST006 5CU008 7SC018 A3021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJGG",
       RawData = "RJGG 041630Z AUTO 32005KT 4600 -RA BR BKN004 OVC014 08/07 Q1016 TEMPO 3000 -SHRA BR",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJFF",
       RawData = "RJFF 041630Z AUTO 29003KT 9999 NSC 09/08 Q1015 TEMPO BKN008 RMK A3000",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJCC",
       RawData = "RJCC 041630Z 36005KT 9999 FEW015 BKN150 BKN/// M08/M11 Q1029 RMK 1ST015 5AS150 A3040",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJBB",
       RawData = "RJBB 041630Z AUTO 04009KT 9999 FEW042 BKN044 OVC060 09/08 Q1013 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RJAA",
       RawData = "RJAA 041630Z AUTO 33011KT 3800 -RASN FEW002 BKN003 OVC005 //////TCU 02/02 Q1021 TEMPO 3000 -RA BR RMK A3017 TCU 20KM NE MOV UNKNOWN",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "RCTP",
       RawData = "RCTP 041630Z 04018KT 8000 -RA SCT003 BKN004 BKN015 15/15 Q1015 NOSIG RMK A3000",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "PFZK",
       RawData = "PFZK 041630Z AUTO 34003KT 4SM -SN BR FEW047 SCT060 OVC090 M10/M12 A2967 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OTBD",
       RawData = "OTBD 041630Z 10006KT 9999 FEW040 20/16 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OPPS",
       RawData = "OPPS 041630Z 00000KT 8000 HZ NSC 13/05 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OPMT",
       RawData = "OPMT 041630Z 00000KT 4000 HZ NSC 18/05 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OPKC",
       RawData = "OPKC 041630Z 08009KT 6000 NSC 21/M09 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OPIS",
       RawData = "OPIS 041630Z 23004KT 7000 NSC 10/06 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OMSJ",
       RawData = "OMSJ 041630Z 08009KT CAVOK 23/11 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OMDW",
       RawData = "OMDW 041630Z 06018KT 6000 1200W R12/P2000N BLDU NSC 24/07 Q1017 BECMG 8000 NSW",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OMDB",
       RawData = "OMDB 041630Z 07013KT CAVOK 24/12 Q1017 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIYY",
       RawData = "OIYY 041630Z 27006KT 9999 FEW090 BKN190 12/M14 Q1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OITT",
       RawData = "OITT 041630Z 03006KT 9999 FEW032 06/M07 Q1021 A3017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OITR",
       RawData = "OITR 041630Z 32004KT 9999 FEW040 BKN170 02/M04 Q1020 A3013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OISS",
       RawData = "OISS 041630Z 24004KT 5000 RA BR FEW030CB SCT035 OVC080 05/03 Q1025 A3027",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIMM",
       RawData = "OIMM 041630Z 21006KT CAVOK 06/M01 Q1023 A3021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIKB",
       RawData = "OIKB 041630Z 10006KT 7000 SCT100 22/09 Q1017 A3006",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIII",
       RawData = "OIII 041630Z 22005KT 9000 FEW110 BKN190 09/M14 Q1022 A3018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIGG",
       RawData = "OIGG 041630Z 05006KT 8000 FEW030 BKN160 08/03 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIFM",
       RawData = "OIFM 041630Z 29004KT 9999 FEW040 SCT100 BKN200 09/M18 Q1020 A3014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OICC",
       RawData = "OICC 041630Z 19012KT CAVOK 08/M26 Q1019 A3010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIBB",
       RawData = "OIBB 041630Z 04010KT 5000 HZ SCT040 OVC090 18/07 Q1016 A3002",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "OIAW",
       RawData = "OIAW 041630Z 17010G21KT 5000 -SHRA SA FEW035CB SCT040 OVC090 19/02 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NZWN",
       RawData = "NZWN 041630Z AUTO 18021G31KT 9999 -RA FEW017/// BKN060/// 14/11 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NZQN",
       RawData = "NZQN 041630Z AUTO 36004KT 9999 NCD 06/00 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NZCH",
       RawData = "NZCH 041630Z AUTO 24009KT 9999 -RA SCT034/// BKN048/// OVC070/// 10/08 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NZAA",
       RawData = "NZAA 041630Z AUTO 24011KT 9999 SCT040/// 18/13 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NWWW",
       RawData = "NWWW 041630Z AUTO 16002KT 9999 BKN027 OVC034 25/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NTTO",
       RawData = "NTTO 041630Z AUTO 08010KT //// // FEW021/// SCT030/// 29/24 Q1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NTTB",
       RawData = "NTTB 041630Z AUTO 13007KT 9999 FEW019/// 28/25 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NTAT",
       RawData = "NTAT 041630Z AUTO 30008KT 9999 SCT015/// SCT020/// OVC200/// 27/24 Q1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NTAA",
       RawData = "NTAA 041630Z AUTO VRB02KT CAVOK 27/23 Q1014 BECMG 05012KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NLWW",
       RawData = "NLWW 041630Z AUTO VRB03KT 9999 FEW025/// BKN180/// 27/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "NIUE",
       RawData = "NIUE 041630Z AUTO 22003KT 9999 NCD 25/24 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LZZI",
       RawData = "LZZI 041630Z VRB01KT CAVOK 09/M04 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LZTT",
       RawData = "LZTT 041630Z 27009KT CAVOK 07/M11 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LZPP",
       RawData = "LZPP 041630Z 23003KT CAVOK 10/02 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LZKZ",
       RawData = "LZKZ 041630Z 18005KT CAVOK 06/01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LZIB",
       RawData = "LZIB 041630Z 16004KT CAVOK 10/M00 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYVR",
       RawData = "LYVR 041630Z AUTO 02003KT CAVOK 10/01 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYTV",
       RawData = "LYTV 041630Z VRB02KT CAVOK 14/04 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYPG",
       RawData = "LYPG 041630Z 11002KT CAVOK 14/M02 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYNI",
       RawData = "LYNI 041630Z 32006KT CAVOK 11/M01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYKV",
       RawData = "LYKV 041630Z 05004KT 020V080 CAVOK 12/M01 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYBT",
       RawData = "LYBT 041630Z 14002KT CAVOK 11/01 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LYBE",
       RawData = "LYBE 041630Z 09002KT CAVOK 11/M00 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LUKK",
       RawData = "LUKK 041630Z 27010KT CAVOK 06/M00 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRTR",
       RawData = "LRTR 041630Z 34003KT CAVOK 10/M01 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRTM",
       RawData = "LRTM 041630Z VRB01KT CAVOK 06/M02 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRTC",
       RawData = "LRTC 041630Z 26007KT CAVOK 05/M00 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRSV",
       RawData = "LRSV 041630Z 28004KT CAVOK 06/M00 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRSM",
       RawData = "LRSM 041630Z 14002KT CAVOK 08/01 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRSB",
       RawData = "LRSB 041630Z 36004KT CAVOK 09/M03 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LROP",
       RawData = "LROP 041630Z 23005KT CAVOK 07/M00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LROD",
       RawData = "LROD 041630Z 00000KT CAVOK 10/M02 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRIA",
       RawData = "LRIA 041630Z 23004KT CAVOK 09/M00 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRCV",
       RawData = "LRCV 041630Z 22003KT 180V260 CAVOK 10/M01 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRCL",
       RawData = "LRCL 041630Z 02004KT CAVOK 08/M02 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRCK",
       RawData = "LRCK 041630Z 27002KT CAVOK 06/00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRBV",
       RawData = "LRBV 041630Z 28003KT CAVOK 07/M00 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRBS",
       RawData = "LRBS 041630Z 25004KT CAVOK 09/02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRBM",
       RawData = "LRBM 041630Z 28004KT CAVOK 06/M00 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRBC",
       RawData = "LRBC 041630Z 17007KT CAVOK 06/02 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LRAR",
       RawData = "LRAR 041630Z 29005KT CAVOK 09/M00 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LQTZ",
       RawData = "LQTZ 041630Z 06007KT 040V100 CAVOK 12/M01 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LQSA",
       RawData = "LQSA 041630Z VRB02KT CAVOK 09/00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LQMO",
       RawData = "LQMO 041630Z 16008KT CAVOK 14/M02 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LQBK",
       RawData = "LQBK 041630Z 32005KT CAVOK 12/01 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPPT",
       RawData = "LPPT 041630Z 05007KT 9999 VCSH FEW012 13/13 Q1011 RERA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPPS",
       RawData = "LPPS 041630Z 36014KT 9999 SCT014 17/11 Q1012",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPPR",
       RawData = "LPPR 041630Z 12007KT 090V170 CAVOK 21/10 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPPD",
       RawData = "LPPD 041630Z 01005KT 310V070 9999 FEW018 BKN035 16/12 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPMA",
       RawData = "LPMA 041630Z 35011G22KT 290V020 9999 FEW016 FEW018TCU 18/08 Q1012",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPHR",
       RawData = "LPHR 041630Z 29013KT 9999 FEW011 17/14 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPFR",
       RawData = "LPFR 041630Z 08012KT 9999 FEW020 FEW025 18/13 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPFL",
       RawData = "LPFL 041630Z 17010KT 140V200 9999 SCT016 BKN025 17/14 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPCS",
       RawData = "LPCS 041630Z 07010KT 040V100 9999 FEW012 FEW022TCU SCT035 15/11 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LPAZ",
       RawData = "LPAZ 041630Z 01011KT 340V050 9999 BKN020 16/11 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKTB",
       RawData = "LKTB 041630Z 17001KT CAVOK 08/M05 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKPR",
       RawData = "LKPR 041630Z 07006KT CAVOK 07/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKPD",
       RawData = "LKPD 041630Z VRB01KT CAVOK 10/M07 Q1026 RMK BLACK",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKNA",
       RawData = "LKNA 041630Z 36003KT CAVOK 09/M09 Q1025 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKMT",
       RawData = "LKMT 041630Z 22009KT CAVOK 07/M06 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKKV",
       RawData = "LKKV 041630Z 00000KT CAVOK 08/M15 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LKCV",
       RawData = "LKCV 041630Z 03004KT CAVOK 10/M07 Q1026 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LJPZ",
       RawData = "LJPZ 041630Z AUTO 26002KT 9999 NCD 13/M02 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LJMB",
       RawData = "LJMB 041630Z AUTO 14006KT 9999 NCD 13/M01 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LJLJ",
       RawData = "LJLJ 041630Z 14001KT CAVOK 08/03 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LJCE",
       RawData = "LJCE 041630Z 09005KT CAVOK 12/M01 Q1025 RMK BLU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LHBP",
       RawData = "LHBP 041630Z 19003KT CAVOK 12/00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFVP",
       RawData = "LFVP 041630Z AUTO 32015KT 9999 FEW024 OVC043 M04/M10 Q1015 TEMPO 1500 -SHSN SCT015TCU BECMG 32020G30KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFTW",
       RawData = "LFTW 041630Z AUTO 18006KT 160V220 CAVOK 16/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFTH",
       RawData = "LFTH 041630Z AUTO 09006KT CAVOK 13/06 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSX",
       RawData = "LFSX 041630Z AUTO 25001KT CAVOK 16/03 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFST",
       RawData = "LFST 041630Z AUTO 35003KT CAVOK 13/01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSO",
       RawData = "LFSO 041630Z AUTO VRB03KT CAVOK 13/M01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSN",
       RawData = "LFSN 041630Z AUTO VRB03KT CAVOK 14/01 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSM",
       RawData = "LFSM 041630Z AUTO 04007KT CAVOK 13/02 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSL",
       RawData = "LFSL 041630Z AUTO 15004KT 100V200 CAVOK 18/01 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSI",
       RawData = "LFSI 041630Z AUTO 09004KT CAVOK 13/01 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSG",
       RawData = "LFSG 041630Z AUTO 35004KT CAVOK 12/02 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSD",
       RawData = "LFSD 041630Z AUTO 32003KT CAVOK 13/03 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFSB",
       RawData = "LFSB 041630Z AUTO 35005KT CAVOK 11/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRZ",
       RawData = "LFRZ 041630Z AUTO 07010KT 9999 FEW010 14/05 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRV",
       RawData = "LFRV 041630Z AUTO 04009KT CAVOK 13/03 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRU",
       RawData = "LFRU 041630Z AUTO 09009KT CAVOK 12/02 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRT",
       RawData = "LFRT 041630Z AUTO 06005KT CAVOK 09/01 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRS",
       RawData = "LFRS 041630Z AUTO 05008KT 020V080 CAVOK 14/04 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRQ",
       RawData = "LFRQ 041630Z AUTO 12005KT 080V180 CAVOK 14/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRO",
       RawData = "LFRO 041630Z AUTO 08007KT 040V130 CAVOK 11/02 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRN",
       RawData = "LFRN 041630Z AUTO 07008KT CAVOK 14/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRM",
       RawData = "LFRM 041630Z AUTO 04009KT CAVOK 14/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRL",
       RawData = "LFRL 041630Z AUTO 05004KT 010V090 CAVOK 14/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRK",
       RawData = "LFRK 041630Z AUTO 06004KT 030V090 7000 NSC 10/04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRJ",
       RawData = "LFRJ 041630Z AUTO 07009KT CAVOK 12/04 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRI",
       RawData = "LFRI 041630Z AUTO 08008KT CAVOK 14/06 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRH",
       RawData = "LFRH 041630Z AUTO 07012KT CAVOK 13/03 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRG",
       RawData = "LFRG 041630Z AUTO 11007KT CAVOK 12/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRD",
       RawData = "LFRD 041630Z AUTO 05003KT 360V080 CAVOK 11/04 Q1024 TEMPO 3000 BR",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRC",
       RawData = "LFRC 041630Z AUTO 12008KT CAVOK 09/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFRB",
       RawData = "LFRB 041630Z AUTO 06008KT CAVOK 13/06 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFQQ",
       RawData = "LFQQ 041630Z AUTO 09003KT CAVOK 13/00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFQG",
       RawData = "LFQG 041630Z AUTO 16004KT CAVOK 15/06 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFQB",
       RawData = "LFQB 041630Z AUTO 02004KT 350V070 CAVOK 14/03 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFQA",
       RawData = "LFQA 041630Z AUTO 36005KT CAVOK 11/04 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPV",
       RawData = "LFPV 041630Z AUTO 06004KT 030V090 CAVOK 12/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPT",
       RawData = "LFPT 041630Z AUTO VRB03KT CAVOK 13/02 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPO",
       RawData = "LFPO 041630Z 07005KT CAVOK 14/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPN",
       RawData = "LFPN 041630Z AUTO 06005KT 030V090 9999 NCD 12/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPG",
       RawData = "LFPG 041630Z 07003KT 020V110 CAVOK 13/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFPB",
       RawData = "LFPB 041630Z AUTO 06004KT CAVOK 14/01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOV",
       RawData = "LFOV 041630Z AUTO 06006KT CAVOK 14/04 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOT",
       RawData = "LFOT 041630Z AUTO 06007KT CAVOK 13/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOP",
       RawData = "LFOP 041630Z AUTO 12006KT CAVOK 12/01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOK",
       RawData = "LFOK 041630Z AUTO 03003KT CAVOK 12/04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOJ",
       RawData = "LFOJ 041630Z AUTO 05010KT CAVOK 12/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOH",
       RawData = "LFOH 041630Z AUTO 06006KT 9000 NSC 11/05 Q1024 TEMPO 33010KT 4500 HZ",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOE",
       RawData = "LFOE 041630Z AUTO 10003KT CAVOK 12/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOB",
       RawData = "LFOB 041630Z AUTO 06006KT CAVOK 12/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFOA",
       RawData = "LFOA 041630Z AUTO 07003KT 050V150 CAVOK 16/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMY",
       RawData = "LFMY 041630Z AUTO 20005KT CAVOK 15/02 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMV",
       RawData = "LFMV 041630Z AUTO 24004KT CAVOK 16/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMU",
       RawData = "LFMU 041630Z AUTO 08008KT CAVOK 14/08 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMT",
       RawData = "LFMT 041630Z AUTO 00000KT CAVOK 14/08 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMP",
       RawData = "LFMP 041630Z AUTO 06007KT 9999 BKN020 13/09 Q1022 TEMPO BKN011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMO",
       RawData = "LFMO 041630Z AUTO 27004KT 240V300 CAVOK 16/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMN",
       RawData = "LFMN 041630Z VRB03KT CAVOK 14/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFML",
       RawData = "LFML 041630Z AUTO 18007KT CAVOK 15/04 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMK",
       RawData = "LFMK 041630Z AUTO 09016KT CAVOK 14/06 Q1021 TEMPO 09016G26KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMI",
       RawData = "LFMI 041630Z AUTO 21006KT CAVOK 15/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMH",
       RawData = "LFMH 041630Z AUTO 08005KT CAVOK 14/02 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMD",
       RawData = "LFMD 041630Z AUTO 07003KT 360V120 CAVOK 15/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFMC",
       RawData = "LFMC 041630Z AUTO 10006KT 070V130 9999 ////// 14/01 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLY",
       RawData = "LFLY 041630Z AUTO 34005KT CAVOK 15/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLX",
       RawData = "LFLX 041630Z AUTO 03007KT CAVOK 12/06 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLW",
       RawData = "LFLW 041630Z AUTO 17006KT 120V220 CAVOK 14/M03 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLV",
       RawData = "LFLV 041630Z AUTO 04008KT CAVOK 16/01 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLU",
       RawData = "LFLU 041630Z AUTO 09004KT 050V110 CAVOK 17/01 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLS",
       RawData = "LFLS 041630Z AUTO 21003KT 180V250 CAVOK 15/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLP",
       RawData = "LFLP 041630Z AUTO 30006KT CAVOK 14/00 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLN",
       RawData = "LFLN 041630Z AUTO 05008KT CAVOK 15/05 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLL",
       RawData = "LFLL 041630Z 36004KT CAVOK 16/00 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLH",
       RawData = "LFLH 041630Z AUTO 05003KT 020V080 CAVOK 15/04 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLC",
       RawData = "LFLC 041630Z AUTO 14005KT 110V180 CAVOK 17/M02 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFLB",
       RawData = "LFLB 041630Z AUTO VRB03KT CAVOK 12/02 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFKS",
       RawData = "LFKS 041630Z AUTO 18004KT CAVOK 14/08 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFKJ",
       RawData = "LFKJ 041630Z AUTO 21004KT 9999 SCT066 16/08 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFKF",
       RawData = "LFKF 041630Z AUTO 07010KT 040V110 9999 FEW028 14/09 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFKC",
       RawData = "LFKC 041630Z AUTO VRB02KT CAVOK 16/05 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFKB",
       RawData = "LFKB 041630Z AUTO 12003KT CAVOK 14/09 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFJR",
       RawData = "LFJR 041630Z AUTO 04006KT CAVOK 14/03 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFJL",
       RawData = "LFJL 041630Z AUTO 12006KT CAVOK 13/M00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFHP",
       RawData = "LFHP 041630Z AUTO 17004KT 140V210 CAVOK 12/M04 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFGJ",
       RawData = "LFGJ 041630Z AUTO VRB02KT CAVOK 15/01 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFGA",
       RawData = "LFGA 041630Z AUTO VRB02KT CAVOK 13/01 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFCR",
       RawData = "LFCR 041630Z AUTO 12008KT CAVOK 14/00 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFCK",
       RawData = "LFCK 041630Z AUTO 11012KT CAVOK 14/03 Q1022 BECMG 12016G26KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBZ",
       RawData = "LFBZ 041630Z AUTO 06010KT CAVOK 17/09 Q1019 TEMPO BKN050TCU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBY",
       RawData = "LFBY 041630Z AUTO 06006KT 020V090 9999 // ////// 17/09 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBX",
       RawData = "LFBX 041630Z AUTO 08004KT 030V160 CAVOK 18/03 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBU",
       RawData = "LFBU 041630Z AUTO 35007KT CAVOK 15/06 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBT",
       RawData = "LFBT 041630Z AUTO 03007KT CAVOK 15/07 Q1019 TEMPO FEW035 SCT070TCU",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBP",
       RawData = "LFBP 041630Z AUTO 04006KT 360V080 CAVOK 17/08 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBO",
       RawData = "LFBO 041630Z AUTO 12011KT 9999 FEW011 15/03 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBM",
       RawData = "LFBM 041630Z AUTO 07008KT 040V100 CAVOK 18/09 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBL",
       RawData = "LFBL 041630Z AUTO VRB02KT CAVOK 17/M00 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBI",
       RawData = "LFBI 041630Z AUTO 04006KT 010V080 CAVOK 15/05 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBH",
       RawData = "LFBH 041630Z AUTO 08007KT CAVOK 14/05 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBG",
       RawData = "LFBG 041630Z AUTO 04004KT 9999 FEW003 SCT160 16/04 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBF",
       RawData = "LFBF 041630Z AUTO 13010KT 100V160 CAVOK 15/02 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBE",
       RawData = "LFBE 041630Z AUTO VRB03KT CAVOK 18/05 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBD",
       RawData = "LFBD 041630Z AUTO 07009KT CAVOK 16/04 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBC",
       RawData = "LFBC 041630Z AUTO 09008KT CAVOK 16/07 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFBA",
       RawData = "LFBA 041630Z AUTO 10008KT CAVOK 17/04 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFAT",
       RawData = "LFAT 041630Z AUTO 34004KT 5000 BR NSC 09/04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFAQ",
       RawData = "LFAQ 041630Z AUTO 06006KT CAVOK 12/04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LFAC",
       RawData = "LFAC 041630Z AUTO VRB02KT 5000 HZ NSC 10/05 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEZL",
       RawData = "LEZL 041630Z 04007KT 9999 VCTS FEW030CB SCT045 17/14 Q1011 BECMG NSW",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEZG",
       RawData = "LEZG 041630Z 12011KT 100V160 9999 FEW030 OVC065 15/09 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEXJ",
       RawData = "LEXJ 041630Z 06005KT 010V110 9999 BKN085 15/10 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEVX",
       RawData = "LEVX 041630Z 09005KT 030V160 9999 SCT050 18/07 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEVT",
       RawData = "LEVT 041630Z 13013KT 110V170 9999 FEW036 BKN044 13/07 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEVS",
       RawData = "LEVS 041630Z 09005KT 020V140 9999 FEW026 SCT033CB BKN042 13/08 Q1016",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEVD",
       RawData = "LEVD 041630Z 08005KT 030V110 9999 FEW032 13/07 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEVC",
       RawData = "LEVC 041630Z 05015KT 020V080 8000 OVC010 14/12 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LETU",
       RawData = "LETU 041630Z AUTO 12009KT 9999 FEW036/// OVC062/// 14/09 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LETO",
       RawData = "LETO 041630Z 36004KT 330V030 9999 SCT038 BKN050 11/09 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LETL",
       RawData = "LETL 041630Z AUTO 15011KT 9999 FEW035 OVC046 09/06 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEST",
       RawData = "LEST 041630Z 07006KT 010V110 CAVOK 17/08 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LESO",
       RawData = "LESO 041630Z 02005KT 310V070 9999 FEW065 14/13 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LESB",
       RawData = "LESB 041630Z AUTO 07013KT 9999 FEW034 OVC038 15/12 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LESA",
       RawData = "LESA 041630Z 11012KT 9999 FEW040 14/08 Q1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LERT",
       RawData = "LERT 041630Z 12013KT 8000 -DZ FEW020 17/13 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LERS",
       RawData = "LERS 041630Z 09009KT 060V120 9999 FEW040 14/08 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LERI",
       RawData = "LERI 041630Z 07017G27KT 9999 FEW018 SCT030 16/12 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEPP",
       RawData = "LEPP 041630Z 14007KT 9999 BKN058 14/06 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEPA",
       RawData = "LEPA 041630Z 07012KT 9999 FEW010 SCT020 BKN035 16/13 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEMO",
       RawData = "LEMO 041630Z 25005KT 220V280 9999 OVC058 18/13 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEMI",
       RawData = "LEMI 041630Z 06018KT 020V080 9999 BKN013 15/13 Q1015",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEMH",
       RawData = "LEMH 041630Z 10015KT 9999 FEW018 BKN025 15/10 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEMG",
       RawData = "LEMG 041630Z 27004KT 230V300 9999 FEW030 19/12 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEMD",
       RawData = "LEMD 041630Z 36006KT 9999 -SHRA SCT040CB BKN050 11/08 Q1016 TEMPO SHRA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LELO",
       RawData = "LELO 041630Z 11009KT 080V150 9999 FEW030 BKN045 13/08 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LELN",
       RawData = "LELN 041630Z 04004KT 010V080 9999 FEW010 09/08 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LELL",
       RawData = "LELL 041630Z 12008KT 080V150 9999 FEW040 16/08 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LELC",
       RawData = "LELC 041630Z 06013KT 020V090 7000 FEW010 SCT030 17/14 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEJR",
       RawData = "LEJR 041630Z 16004KT 100V210 9000 FEW025 BKN060 16/13 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEIB",
       RawData = "LEIB 041630Z 06012KT 9999 SCT015 16/13 Q1017 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEHC",
       RawData = "LEHC 041630Z AUTO 12008KT 080V160 CAVOK 15/06 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEGT",
       RawData = "LEGT 041630Z 09007KT 9999 FEW023 SCT032 BKN046 14/10 Q1016",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEGR",
       RawData = "LEGR 041630Z 03008KT 350V060 9999 BKN065 15/10 Q1011 RERA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEGE",
       RawData = "LEGE 041630Z 03008KT CAVOK 14/06 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEDA",
       RawData = "LEDA 041630Z 12006KT 9999 SCT040 17/06 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LECV",
       RawData = "LECV 041630Z 07007KT 2000 TS SHRA SCT010CB SCT022 BKN030 07/07 Q1016",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LECO",
       RawData = "LECO 041630Z 04005KT 340V090 CAVOK 17/09 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LECH",
       RawData = "LECH 041630Z AUTO 03010KT 9000 SCT010 BKN024 BKN033 11/10 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBZ",
       RawData = "LEBZ 041630Z 10005KT 070V140 9999 SHRA SCT025CB 16/13 Q1012",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBT",
       RawData = "LEBT 041630Z AUTO 06008KT 340V120 9999 OVC012 13/11 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBR",
       RawData = "LEBR 041630Z AUTO 14008KT 9999 OVC054/// 14/09 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBL",
       RawData = "LEBL 041630Z 07014KT 9999 FEW030 14/06 Q1021 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBG",
       RawData = "LEBG 041630Z 07010KT 9999 FEW018 BKN033 BKN055 10/07 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBB",
       RawData = "LEBB 041630Z VRB08G18KT 9999 FEW054 SCT063 18/10 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEBA",
       RawData = "LEBA 041630Z 08006KT 050V110 CAVOK 19/09 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAS",
       RawData = "LEAS 041630Z 05005KT 010V110 9999 SCT012 BKN020 13/11 Q1018 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAO",
       RawData = "LEAO 041630Z 10012KT 9999 SCT040 15/09 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAM",
       RawData = "LEAM 041630Z 06019KT 9999 FEW035 20/12 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAL",
       RawData = "LEAL 041630Z 07020KT 030V090 9999 FEW039 SCT068 16/13 Q1015 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAG",
       RawData = "LEAG 041630Z AUTO 10010KT 9999 FEW020/// SCT037/// OVC045/// 17/13 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LEAB",
       RawData = "LEAB 041630Z 10015KT 9999 FEW018 BKN024 12/08 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDZD",
       RawData = "LDZD 041630Z 31007KT CAVOK 13/01 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDZA",
       RawData = "LDZA 041630Z 10004KT CAVOK 12/M01 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDSP",
       RawData = "LDSP 041630Z 24006KT CAVOK 12/01 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDRI",
       RawData = "LDRI 041630Z 00000KT CAVOK 16/M04 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDPL",
       RawData = "LDPL 041630Z 27007KT CAVOK 10/01 Q1024 BECMG TL1700 30004KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDOS",
       RawData = "LDOS 041630Z 15003KT CAVOK 11/00 Q1026",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LDDU",
       RawData = "LDDU 041630Z 29008KT CAVOK 12/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LCPH",
       RawData = "LCPH 041630Z 08005KT 020V100 9999 FEW050 17/04 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LCLK",
       RawData = "LCLK 041630Z 34013KT CAVOK 17/06 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LBWN",
       RawData = "LBWN 041630Z 09007KT CAVOK 04/M00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LBSF",
       RawData = "LBSF 041630Z AUTO 06006KT 9999 NCD 09/M03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LBPD",
       RawData = "LBPD 041630Z AUTO 16005KT 9999 NCD 09/M00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LBGO",
       RawData = "LBGO 041630Z AUTO 28003KT 9999 NCD 09/01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "LBBG",
       RawData = "LBBG 041630Z 10006KT CAVOK 05/02 Q1026 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KVUJ",
       RawData = "KVUJ 041630Z AUTO 17009KT 10SM SCT050 15/04 A3028 RMK AO2 T01490042",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KTTA",
       RawData = "KTTA 041630Z AUTO 19009KT 10SM BKN050 15/03 A3024 RMK AO2 T01540025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KTDF",
       RawData = "KTDF 041630Z AUTO 18009G14KT 160V220 10SM CLR 13/M02 A3026 RMK AO2",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQFW",
       RawData = "KQFW 041630Z AUTO 05003KT 9999 OVC065 01/M02 A3000 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQFT",
       RawData = "KQFT 041630Z AUTO 02001KT 9999 OVC070 02/M02 A3017 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQEY",
       RawData = "KQEY 041630Z AUTO 23001KT 9999 FEW070 BKN190 02/M01 A2983 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQEV",
       RawData = "KQEV 041630Z AUTO 04002KT 9999 OVC065 03/M00 A3012 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQER",
       RawData = "KQER 041630Z AUTO 36002KT 9999 OVC065 M00/M05 A3014 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQEJ",
       RawData = "KQEJ 041630Z AUTO 15002KT 9999 OVC070 M01/M02 A3016 RMK A02 TSNO",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KQBL",
       RawData = "KQBL 041630Z AUTO VRB05KT 7SM BKN009 OVC013 19/17 A2998 RMK AO2 CIG 009V012 BKN V FEW SLP165 WND DATA ESTMD",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KPRN",
       RawData = "KPRN 041630Z AUTO 17013G22KT 10SM SCT021 20/13 A2996 RMK AO2 T02000128",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KPPF",
       RawData = "KPPF 041630Z AUTO 06007KT 4SM RA BR OVC060 11/09 A2936 RMK AO2 PRESFR P0010 T01060089",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KPGV",
       RawData = "KPGV 041630Z AUTO 19009KT 10SM CLR 17/00 A3028 RMK AO2",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KOYE",
       RawData = "KOYE 041630Z AUTO 10028G35KT 3SM HZ CLR 23/19 A2977 RMK A01",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KOPF",
       RawData = "KOPF 041630Z 11020G27KT 10SM SCT026 BKN039 26/18 A3009 RMK AO2 PK WND 11027/1624 T02560178",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KONX",
       RawData = "KONX 041630Z AUTO 20008KT 10SM CLR 15/00 A3029 RMK AO2 T01481001",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KMWT",
       RawData = "KMWT 041630Z AUTO VRB04KT 4SM -RA FEW020 BKN060 OVC075 14/11 A2946 RMK AO2 RAB1536B08 PRESRR P0013 T01390111 $",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KMQI",
       RawData = "KMQI 041630Z AUTO 19010KT 10SM CLR 15/04 A3031 RMK AO2 T01480037",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KLHZ",
       RawData = "KLHZ 041630Z AUTO 19008KT 150V220 10SM CLR 15/00 A3027 RMK AO2",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KJNX",
       RawData = "KJNX 041630Z AUTO 19005KT 10SM CLR 17/04 A3025 RMK AO2",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KINK",
       RawData = "KINK 041630Z AUTO 28026G41KT 2SM HZ OVC023 14/M07 A2974 RMK AO2 PK WND 28046/1603 T01441072",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KHRJ",
       RawData = "KHRJ 041630Z AUTO 18007KT 130V200 10SM BKN050 17/05 A3026 RMK AO2 T01670047",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KHBI",
       RawData = "KHBI 041630Z AUTO 19010KT 150V230 10SM SCT050 13/01 A3025 RMK AO2 T01320009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KGWW",
       RawData = "KGWW 041630Z AUTO 17011G17KT 10SM SCT047 SCT055 17/04 A3026 RMK AO2 T01650040",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KGRY",
       RawData = "KGRY 041630Z AUTO 19024G33KT 10SM CLR 24/18 A2977 RMK A01",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KGLX",
       RawData = "KGLX 041630Z AUTO VRB05G14KT 9SM CLR A2987 RMK A01",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KGEV",
       RawData = "KGEV 041630Z AUTO 18012G21KT 110V210 10SM CLR 12/M07 A3015 RMK AO2 T01211069",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KGCK",
       RawData = "KGCK 041630Z 34036G57KT 10SM OVC014 06/02 A2939 RMK AO2 PK WND 34057/1624 T00560017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KFOE",
       RawData = "KFOE 041630Z 17009KT 2SM R31/5500VP6000FT +RA BR BKN050 OVC065 11/09 A2936 RMK AO2 P0011 T01060094",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KFFA",
       RawData = "KFFA 041630Z AUTO 12006KT 10SM CLR 14/04 A3030 RMK AO2 T01400038",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KEHO",
       RawData = "KEHO 041630Z AUTO 00000KT 10SM OVC037 12/02 A3022 RMK AO2 T01180023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KEDE",
       RawData = "KEDE 041630Z AUTO 19008KT 10SM CLR 17/04 A3031 RMK AO2 T01650035",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KDPL",
       RawData = "KDPL 041630Z AUTO 14008KT 100V160 10SM SCT050 18/06 A3027 RMK AO2",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KCPC",
       RawData = "KCPC 041630Z AUTO 17014G17KT 10SM BKN046 BKN055 19/07 A3026 RMK AO2 T01910068",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KCMY",
       RawData = "KCMY 041630Z AUTO 00000KT 9SM OVC020 10/06 A2954 RMK AO2 SLP009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KCGS",
       RawData = "KCGS 041630Z AUTO 20009KT 170V230 10SM BKN080 12/M04 A3021 RMK AO2 T01221037",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KAXN",
       RawData = "KAXN 041630Z AUTO 01011G18KT 1 3/4SM -SN BR BKN031 OVC045 00/M02 A2971 RMK AO2 P0002 T00001022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "KAKO",
       RawData = "KAKO 041630Z AUTO 34030G42KT 10SM OVC014 01/M01 A2973 RMK AO2 PK WND 35046/1606 T00111011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "K2W6",
       RawData = "K2W6 041630Z AUTO 22016G20KT 10SM BKN110 13/M01 A3023 RMK AO1",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "K24A",
       RawData = "K24A 041630Z AUTO 14009KT 10SM OVC028 07/01 A3016 RMK AO2 T00740009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "K1NN",
       RawData = "K1NN 041630Z AUTO 35006KT 10SM SCT011 BKN022 OVC028 M02/M04 A3002 RMK AO2 CIG 011V028 SLP194 $",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "K1GN",
       RawData = "K1GN 041630Z AUTO 03010KT 8SM -SN OVC005 M02/M04 A2997 RMK AO2 CIG 005V007 OVC V BKN SLP179 $",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "K1A5",
       RawData = "K1A5 041630Z AUTO 00000KT 10SM BKN026 OVC033 11/04 A3019 RMK AO2 T01090043",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "HRYR",
       RawData = "HRYR 041630Z 18010KT 9999 FEW023CB BKN025 27/15 Q1014 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GOBD",
       RawData = "GOBD 041630Z 36018KT CAVOK 23/13 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMMX",
       RawData = "GMMX 041630Z 28008KT 250V310 9999 SCT020 FEW030TCU 19/10 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMMN",
       RawData = "GMMN 041630Z 03014KT 9999 BKN030 18/12 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMME",
       RawData = "GMME 041630Z 33007KT 290V350 6000 SCT015 19/12 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMFO",
       RawData = "GMFO 041630Z 33008KT 8000 SCT013 BKN030 14/10 Q1009 TEMPO 5000 RA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMFF",
       RawData = "GMFF 041630Z 29003KT 9999 BKN030 SCT100 19/09 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GMAD",
       RawData = "GMAD 041630Z 28018KT 9999 FEW030 20/11 Q1008 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GEML",
       RawData = "GEML 041630Z 05004KT 350V100 9000 SCT004 BKN015 17/15 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GECE",
       RawData = "GECE 041630Z AUTO 09007KT 030V150 9999 VCTS BKN033 OVC038 //////CB 17/14 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCXO",
       RawData = "GCXO 041630Z 31014KT 7000 2600NW -RA BCFG FEW000 SCT004 BKN020 12/11 Q1012 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCTS",
       RawData = "GCTS 041630Z 15006KT 110V210 9999 FEW025 BKN035 19/12 Q1011 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCRR",
       RawData = "GCRR 041630Z 02011KT 340V050 9999 FEW020 FEW030TCU SCT049 18/11 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCLP",
       RawData = "GCLP 041630Z 01011KT 9999 FEW025 BKN035TCU 17/14 Q1011 RERA NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCLA",
       RawData = "GCLA 041630Z 02012G25KT 340V070 9999 FEW040 SCT080 19/09 Q1012",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCHI",
       RawData = "GCHI 041630Z 34017KT 9999 FEW025 SCT035 19/13 Q1012",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCGM",
       RawData = "GCGM 041630Z VRB04KT 9999 FEW025 SCT045 19/10 Q1011 RMK R09/14006KT 080V190 ARP/VRB04KT",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GCFV",
       RawData = "GCFV 041630Z 05013KT 9999 -RA FEW025 SCT030 BKN040 17/14 Q1011",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "GABS",
       RawData = "GABS 041630Z 35007KT 310V030 CAVOK 38/04 Q1007 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "FMMI",
       RawData = "FMMI 041630Z VRB03KT 9000 VCTS SCT017CB SCT020 23/18 Q1018 WS R29 TEMPO 4500 TSRA",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "FMEP",
       RawData = "FMEP 041630Z AUTO 09005KT 020V130 CAVOK 27/23 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "FMEE",
       RawData = "FMEE 041630Z AUTO 10009KT 9999 SCT068/// ///CB 27/23 Q1013 TEMPO 4000 SHRA BKN012TCU FEW015CB",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "FMCZ",
       RawData = "FMCZ 041630Z AUTO 15006KT 9999 SCT024 BKN034 29/25 Q1010 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "FAOR",
       RawData = "FAOR 041630Z 31008KT CAVOK 21/17 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPZG",
       RawData = "EPZG 041630Z 23008KT CAVOK 09/M03 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPWR",
       RawData = "EPWR 041630Z 28008KT CAVOK 08/M04 Q1025",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPWA",
       RawData = "EPWA 041630Z 26014KT CAVOK 09/03 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPSY",
       RawData = "EPSY 041630Z 25011KT 220V290 CAVOK 08/02 Q1017",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPSC",
       RawData = "EPSC 041630Z 24007KT 200V270 CAVOK 10/03 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPRZ",
       RawData = "EPRZ 041630Z 28009KT CAVOK 07/M01 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPRA",
       RawData = "EPRA 041630Z 27014KT CAVOK 08/M00 Q1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPPO",
       RawData = "EPPO 041630Z 25007KT CAVOK 09/M02 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPMO",
       RawData = "EPMO 041630Z 24015KT CAVOK 08/03 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPLL",
       RawData = "EPLL 041630Z 25011KT CAVOK 08/M01 Q1022",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPLB",
       RawData = "EPLB 041630Z 26013KT CAVOK 08/02 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPKT",
       RawData = "EPKT 041630Z 25007KT CAVOK 06/M07 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPKK",
       RawData = "EPKK 041630Z 24009KT CAVOK 07/M04 Q1024",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPGD",
       RawData = "EPGD 041630Z 28026G39KT 9999 FEW024 07/02 Q1017 WS ALL RWY",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EPBY",
       RawData = "EPBY 041630Z 26013KT CAVOK 09/02 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIWF",
       RawData = "EIWF 041630Z 23015KT 200V260 9999 FEW024 09/05 Q1023",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EISG",
       RawData = "EISG 041630Z 19009G20KT 150V240 9000 SCT016 BKN018 10/06 Q1016",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EINN",
       RawData = "EINN 041630Z 21013KT 9999 FEW030 BKN240 12/05 Q1020 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIME",
       RawData = "EIME 041630Z 23014KT CAVOK 09/03 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIKY",
       RawData = "EIKY 041630Z 22010KT 190V250 9999 FEW035 11/06 Q1021",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIKN",
       RawData = "EIKN 041630Z 21018G31KT 180V250 9999 OVC018 09/05 Q1016 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIDW",
       RawData = "EIDW 041630Z 23010G20KT 200V280 9999 FEW016 BKN250 10/03 Q1019 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EIDL",
       RawData = "EIDL 041630Z 21021KT 9999 OVC021 11/06 Q1013",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "EICK",
       RawData = "EICK 041630Z 22013KT 9999 BKN020 08/04 Q1022 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DTTJ",
       RawData = "DTTJ 041630Z 10014KT 8000 FEW020 18/11 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DTTA",
       RawData = "DTTA 041630Z 12009KT 080V160 9999 FEW023 17/11 Q1019",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DTNH",
       RawData = "DTNH 041630Z 09014KT 090V160 CAVOK 16/13 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DTMB",
       RawData = "DTMB 041630Z 10013KT 090V160 8000 SCT026 17/12 Q1020",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DIAP",
       RawData = "DIAP 041630Z 22012KT 9999 FEW012 FEW020CB 29/26 Q1006 TEMPO TS",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DAOO",
       RawData = "DAOO 041630Z 04011KT 9999 SCT030 BKN100 16/13 Q1009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DAON",
       RawData = "DAON 041630Z 18004KT 9000 SCT020 SCT026 16/12 Q1010",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DAAT",
       RawData = "DAAT 041630Z 18005KT 160V220 CAVOK 27/M09 Q1018",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "DAAG",
       RawData = "DAAG 041630Z 34003KT 260V020 9999 FEW023 SCT090 BKN200 22/07 Q1014",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "CYWJ",
       RawData = "CYWJ 041630Z 35003KT 15SM BKN015 M18/M20 A3008 RMK SC7 SLP214",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "CWPF",
       RawData = "CWPF 041630Z AUTO 09001KT 07/07 RMK AO1 SLP159 T00710066 55009",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "BKPR",
       RawData = "BKPR 041630Z 35009KT CAVOK 09/M01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "BIKF",
       RawData = "BIKF 041630Z 22026KT 9999 VCSH FEW004 BKN024CB 00/M04 Q0973",
       LastChange = "2025-03-04T16:30:00Z"
    },
    new Metar {
       Station = "SAWG",
       RawData = "SAWG 041629Z 28020KT CAVOK 20/04 Q0976",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "RJTR",
       RawData = "RJTR 041629Z AUTO 33010G18KT 1 3/4SM RA BR OVC004 02/01 A3020 RMK AO2 VIS 1 3/4V3 SNE09RAB09E11SNB11E29RAB29 SLP231 $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "RJFY",
       RawData = "RJFY 041629Z 22005KT 9999 FEW007 SCT015 BKN025 16/14 Q1012 RMK 1ST007 4CU015 7CU025 A2989",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "PATO",
       RawData = "PATO 041629Z AUTO 00000KT 10SM SCT001 M01/M01 A2982 RMK AO2 I1000 T10061006 TSNO $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KSUT",
       RawData = "KSUT 041629Z AUTO 14007G14KT 10SM CLR 19/08 A3027 RMK AO2",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KOTH",
       RawData = "KOTH 041629Z 20013G19KT 1/2SM -RA FG BKN014 BKN019 OVC029 09/08 A3014 RMK AO2 P0002 RVRNO",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KNPA",
       RawData = "KNPA 041629Z 15014KT 10SM BKN027 BKN250 21/17 A2995 RMK AO2 T02110167 $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KMCK",
       RawData = "KMCK 041629Z AUTO 35031G49KT 7SM -SN BKN017 BKN024 OVC041 02/01 A2951 RMK AO2 PK WND 35051/1619 P0000 T00220006",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KFTK",
       RawData = "KFTK 041629Z AUTO 16023G30KT 10SM -RA FEW065 FEW090 17/M06 A2984 RMK AO2 RAE1555RAB03E14RAB26 SLP107 $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KFME",
       RawData = "KFME 041629Z AUTO 25007KT 10SM CLR 12/M03 A3021 RMK AO1",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KFCM",
       RawData = "KFCM 041629Z 36008KT 1 3/4SM BR BKN006 BKN023 OVC047 06/04 A2956 RMK AO2 RAE21 P0001 T00610044",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KFBG",
       RawData = "KFBG 041629Z AUTO 16008KT 10SM SCT043 SCT055 17/05 A3023 RMK AO2 SLP240 RVRNO $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KBVX",
       RawData = "KBVX 041629Z AUTO 13012G22KT 7SM VCTS +RA OVC023 A2951 RMK AO2 LTG DSNT SW AND W TSB23RAB05 FZRANO PNO $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KAMA",
       RawData = "KAMA 041629Z 34023G44KT 10SM -RA BKN014 OVC021 04/02 A2949 RMK AO2 PK WND 35046/1617 PRESRR P0006 T00440022",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "KAFP",
       RawData = "KAFP 041629Z AUTO 14007KT 10SM SCT045 17/05 A3023 RMK AO2 T01650048",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "K1HN",
       RawData = "K1HN 041629Z AUTO 34011KT 10SM -SN BKN018 OVC036 M00/M03 A3000 RMK AO2 SNE18PLB18E27UPB27E29SNB29 BKN V OVC SLP184 $",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "CYPO",
       RawData = "CYPO 041629Z AUTO 35005KT 300V020 9SM -SN BKN018 OVC039 M13/M18 A2998 RMK SLP162",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "CYHI",
       RawData = "CYHI 041629Z 27020KT 1 1/2SM BR DRSN FEW005 BKN110 M21/M24 A3002 RMK FG1SF1AC4 CIG RAG SLP172",
       LastChange = "2025-03-04T16:29:00Z"
    },
    new Metar {
       Station = "PANU",
       RawData = "PANU 041628Z AUTO 04004KT 8SM UP SCT019 BKN024 OVC033 01/M02 A2978 RMK AO2 RAE21UPB21 P0000 FZRANO",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "PABE",
       RawData = "PABE 041628Z 36009KT 2SM -SN BR OVC050 M12/M13 A2966 RMK AO2 P0001 T11171128 $",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KVBT",
       RawData = "KVBT 041628Z AUTO 26012G22KT 7SM RA BKN007 BKN011 OVC020 12/11 A2943 RMK AO2 PK WND 26028/1605 WSHFT 1556 RAB06 CIG 006V009 P0009 $",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KRBL",
       RawData = "KRBL 041628Z AUTO 16006KT 10SM BKN012 OVC050 10/07 A3026 RMK AO2 T01000067",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KPRB",
       RawData = "KPRB 041628Z AUTO 00000KT 2SM BR OVC003 04/04 A3029 RMK AO2 T00440039 $",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KPBF",
       RawData = "KPBF 041628Z AUTO 13019G24KT 4SM TSRA BR OVC018 16/13 A2949 RMK AO2 PK WND 14028/1610 LTG DSNT ALQDS TSB1555E10B22 PRESFR P0011 T01560133",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KOTG",
       RawData = "KOTG 041628Z AUTO 36020G25KT 2SM UP BR OVC003 02/02 A2951 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KLND",
       RawData = "KLND 041628Z AUTO 13008KT 2SM -SN BR SCT007 BKN011 OVC016 M03/M04 A3003 RMK AO2 P0001 T10281044",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "KCDR",
       RawData = "KCDR 041628Z AUTO 02023G49KT 1SM -SN FEW014 BKN022 OVC047 M01/M03 A2992 RMK AO2 PK WND 36049/1619 UPE13SNB13 P0000 T10061033",
       LastChange = "2025-03-04T16:28:00Z"
    },
    new Metar {
       Station = "RCMQ",
       RawData = "RCMQ 041627Z 36008KT 3200 RA BR SCT004 FEW010CB BKN012 BKN030 20/20 Q1014 RMK A2996 CB SW APCH CLD SCT004",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "PAWM",
       RawData = "PAWM 041627Z AUTO 36008KT 3SM -SN BR OVC029 M12/M13 A2972 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "PAOT",
       RawData = "PAOT 041627Z 28006KT 2 1/2SM -SN BR OVC033 M14/M16 A2981 RMK AO2 P0001 T11391161",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "KHTL",
       RawData = "KHTL 041627Z AUTO 16005KT SCT024 OVC036 03/00 A2973 RMK AO2 T00280000",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "KEST",
       RawData = "KEST 041627Z AUTO 01017G24KT 4SM BR OVC005 04/03 A2948 RMK AO2 T00440028",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "KEFD",
       RawData = "KEFD 041627Z 29021G35KT 7SM BR OVC013 16/13 A2965 RMK WSFT 1614",
       LastChange = "2025-03-04T16:27:00Z"
    },
    new Metar {
       Station = "SPQT",
       RawData = "SPQT 041626Z 31005KT 270V340 9999 TS BKN020 FEW025CB 30/25 Q1010 NOSIG",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "KPLN",
       RawData = "KPLN 041626Z AUTO 14003KT 10SM BKN015 OVC020 04/02 A2970 RMK AO2 T00440017",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "KODX",
       RawData = "KODX 041626Z AUTO 35026G38KT 10SM OVC011 02/M01 A2949 RMK AO2 PK WND 35039/1603 T00221006",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "KLOT",
       RawData = "KLOT 041626Z 17015G22KT 2 1/2SM -DZ BR FEW007 OVC034 06/06 A2972 RMK LTG DSNT SE-SW",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "KIEN",
       RawData = "KIEN 041626Z AUTO 01020G31KT 5SM -SN OVC017 M01/M04 A2988 RMK AO2 PK WND 36035/1605 P0000 T10111039",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "KCNU",
       RawData = "KCNU 041626Z AUTO 01004KT 4SM RA BR OVC060 12/09 A2939 RMK AO2 P0009 T01170094",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "K1JN",
       RawData = "K1JN 041626Z AUTO 01008KT 9SM M M03/M03 A2999 RMK AO2 SNE26 SLP188 $",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "CYNE",
       RawData = "CYNE 041626Z AUTO 02004KT 340V060 9SM -SN FEW017 OVC041 M09/M12 A3007 RMK SLP204",
       LastChange = "2025-03-04T16:26:00Z"
    },
    new Metar {
       Station = "SKBG",
       RawData = "SKBG 041625Z 32004KT 8000 BKN015 23/22 Q1016",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "OPLA",
       RawData = "OPLA 041625Z 30007KT 4000 FU NSC 17/09 Q1018 NOSIG RMK QFE992 A30.08",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KW29",
       RawData = "KW29 041625Z AUTO 17010KT 10SM CLR 12/00 A3021 RMK AO2 T01160000",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KSZL",
       RawData = "KSZL 041625Z 08008KT 5SM -RA FEW005 OVC025 11/10 A2938 RMK AO2A PRESFR SLP950 $",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KSVH",
       RawData = "KSVH 041625Z AUTO 18008KT 10SM CLR 14/02 A3022 RMK AO2 T01360017",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KSPI",
       RawData = "KSPI 041625Z 08007KT 9SM BKN044 BKN055 OVC095 09/07 A2962 RMK AO2 LTG DSNT W-NE RAE02 PRESFR P0001 T00890072",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KSIF",
       RawData = "KSIF 041625Z AUTO 27003KT 10SM CLR 13/00 A3022 RMK AO2 T01270003",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KRUQ",
       RawData = "KRUQ 041625Z AUTO 18009KT 10SM SCT048 14/02 A3023 RMK AO2 T01350015",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KRCZ",
       RawData = "KRCZ 041625Z AUTO 15008KT 10SM BKN041 17/06 A3024 RMK AO2 T01650056",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KOCW",
       RawData = "KOCW 041625Z AUTO 14007KT 10SM CLR 17/M01 A3030 RMK AO2 T01701007",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KMWK",
       RawData = "KMWK 041625Z AUTO 20005KT 10SM CLR 12/M01 A3024 RMK AO2 T01151011",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KMRN",
       RawData = "KMRN 041625Z AUTO 26003KT 10SM SCT036 BKN043 12/00 A3021 RMK AO2 T01150000",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KMCZ",
       RawData = "KMCZ 041625Z AUTO 22012G15KT 10SM CLR 17/00 A3029 RMK AO2 T01711002",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KLWT",
       RawData = "KLWT 041625Z AUTO 27007KT 10SM OVC003 M04/M04 A3011 RMK AO2 T10391044",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KIXA",
       RawData = "KIXA 041625Z AUTO 18008KT 10SM CLR 14/02 A3026 RMK AO2",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KIPJ",
       RawData = "KIPJ 041625Z AUTO 20006KT 10SM SCT040 SCT048 13/03 A3022 RMK AO2 T01300026",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KHIO",
       RawData = "KHIO 041625Z 00000KT 8SM -RA BKN017 OVC048 06/05 A3007 RMK AO2 P0002 T00610050",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KFQD",
       RawData = "KFQD 041625Z AUTO 00000KT 10SM OVC034 10/00 A3023 RMK AO2",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KEYF",
       RawData = "KEYF 041625Z AUTO 17013G19KT 10SM SCT046 BKN060 19/07 A3025 RMK AO2 T01890071",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KEXX",
       RawData = "KEXX 041625Z AUTO 16007KT 10SM CLR 15/02 A3023 RMK AO2 T01460024",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KETC",
       RawData = "KETC 041625Z AUTO 19007KT 170V230 10SM CLR 16/M01 A3027 RMK AO2 T01621012",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KCTZ",
       RawData = "KCTZ 041625Z AUTO 15009KT 110V170 10SM CLR 17/07 A3026 RMK AO2 T01700070",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KCGE",
       RawData = "KCGE 041625Z AUTO 19014G20KT 160V220 10SM CLR 12/00 A3023 RMK A01",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KCBE",
       RawData = "KCBE 041625Z AUTO 00000KT 10SM BKN080 09/M08 A3014 RMK AO2 T00871084",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KBBG",
       RawData = "KBBG 041625Z 13015G28GKT 1 1/4SM +RA OVC004 11/10 A2939",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "KASJ",
       RawData = "KASJ 041625Z AUTO 21009G14KT CLR 16/M03 A3027 RMK AO2 T01551034 PWINO",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "K2G4",
       RawData = "K2G4 041625Z AUTO 19010G15KT 10SM CLR 11/M12 A3004 RMK AO2",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "K0W3",
       RawData = "K0W3 041625Z AUTO 16009KT 10SM OVC080 08/M01 A3018 RMK AO2 T00801006",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHWO",
       RawData = "EHWO 041625Z AUTO 25003KT 9999 NCD 10/03 Q1025 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHVL",
       RawData = "EHVL 041625Z AUTO 22016KT 9999 NCD 09/03 Q1023 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHVK",
       RawData = "EHVK 041625Z AUTO 09004KT 080V150 9999 NCD 11/03 Q1025 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHSC",
       RawData = "EHSC 041625Z AUTO 14003KT 6000 ///////// 06/04 Q1025 W06/H3",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHSA",
       RawData = "EHSA 041625Z AUTO 16007KT 7000 ///////// 06/03 Q1025 W07/H3",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHRD",
       RawData = "EHRD 041625Z AUTO 30004KT 7000 NCD 10/04 Q1025 NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHPG",
       RawData = "EHPG 041625Z AUTO 19014KT 150V250 5000 BR NCD 07/05 Q1024",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHMG",
       RawData = "EHMG 041625Z AUTO 21023KT 9999 NCD 07/05 Q1023",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHMA",
       RawData = "EHMA 041625Z AUTO 22014KT 9999 NCD 08/05 Q1023",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHLW",
       RawData = "EHLW 041625Z AUTO 22010KT 9999 NCD 09/05 Q1023 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHLE",
       RawData = "EHLE 041625Z AUTO 21004KT 9999 NCD 11/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHKV",
       RawData = "EHKV 041625Z AUTO 21021KT 9999 NCD 08/05 Q1024",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHKD",
       RawData = "EHKD 041625Z AUTO 21011KT 9999 NCD 08/03 Q1024 BLU NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHJR",
       RawData = "EHJR 041625Z AUTO 20021KT //// // ///////// 08/05 Q1023 RE// W07/H6",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHJA",
       RawData = "EHJA 041625Z AUTO 22023KT 9000 NSC 07/05 Q1021",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHHW",
       RawData = "EHHW 041625Z AUTO 23009KT 200V280 7000 NSC 07/05 Q1022",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHGR",
       RawData = "EHGR 041625Z AUTO 00000KT 9999 NCD 12/02 Q1025 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHGG",
       RawData = "EHGG 041625Z AUTO 22007KT 190V250 9999 NCD 10/05 Q1024 NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHFS",
       RawData = "EHFS 041625Z AUTO 13002KT 9999 NCD 10/01 Q1025",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHFD",
       RawData = "EHFD 041625Z AUTO 23025KT 9999 NSC 07/05 Q1020",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHEH",
       RawData = "EHEH 041625Z AUTO 03002KT 9999 NCD 12/01 Q1025 BLU NOSIG RMK TREND REMOTE BY EHWX",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHDV",
       RawData = "EHDV 041625Z AUTO 23017KT 9999 ///////// 07/05 Q1020",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHDL",
       RawData = "EHDL 041625Z AUTO 17003KT 150V250 9999 NCD 12/03 Q1025 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHBK",
       RawData = "EHBK 041625Z AUTO 08004KT 9999 NCD 12/M00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHAM",
       RawData = "EHAM 041625Z 20005KT CAVOK 10/02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EHAK",
       RawData = "EHAK 041625Z AUTO 21022KT 9999 NSC 07/04 Q1018",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBLB",
       RawData = "EBLB 041625Z AUTO 05004KT 9999 NCD 11/M03 Q1024 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBFN",
       RawData = "EBFN 041625Z AUTO VRB02KT 9999 NCD 11/04 Q1024 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBDT",
       RawData = "EBDT 041625Z AUTO VRB02KT 9999 NCD 13/M04 Q1025 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBCV",
       RawData = "EBCV 041625Z AUTO 07003KT 9999 SCT085/// OVC100/// 13/01 Q1024 BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBBL",
       RawData = "EBBL 041625Z VRB02KT 9999 SKC 12/M01 Q1025 BLU BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "EBBE",
       RawData = "EBBE 041625Z VRB02KT 9999 FEW250 12/00 Q1025 BLU BLU",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "CYVC",
       RawData = "CYVC 041625Z 24008KT 15SM BKN068 M03/M05 A3004 RMK AC7 SLP201",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "CYBK",
       RawData = "CYBK 041625Z 32019KT 2 1/2SM -SN BLSN OVC030 M19/M23 A2993 RMK SC8 WIND EST SLP140",
       LastChange = "2025-03-04T16:25:00Z"
    },
    new Metar {
       Station = "PANV",
       RawData = "PANV 041624Z AUTO 08004KT 3/4SM UP BR FEW002 OVC024 M01/M01 A2964 RMK AO2 P0000 FZRANO TSNO",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "KHON",
       RawData = "KHON 041624Z AUTO 36025G34KT 1SM -SN BR FEW011 OVC016 M01/M03 A2973 RMK AO2 PK WND 36034/1620 P0000 T10111028 $",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "KCMI",
       RawData = "KCMI 041624Z AUTO 14007KT 10SM VCTS OVC041 10/04 A2971 RMK AO2 LTG DSNT N AND NW RAE08 P0001 T01000039 $",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "KBIS",
       RawData = "KBIS 041624Z 35014G21KT 10SM FEW017 SCT022 OVC039 M01/M04 A2998 RMK AO2 SNE17 P0000 T10061044",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "CYYB",
       RawData = "CYYB 041624Z 18008KT 3/4SM R08/4000VP6000FT/D -SN OVC004 M02/M02 A2980 RMK SC8 SLP113",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "CYPR",
       RawData = "CYPR 041624Z AUTO 01003KT 310V040 9SM FEW043 BKN055 BKN110 04/03 A2987 RMK SLP119",
       LastChange = "2025-03-04T16:24:00Z"
    },
    new Metar {
       Station = "PFSH",
       RawData = "PFSH 041623Z AUTO 02014KT 1 1/4SM -SN BR OVC014 M10/M11 A2972 RMK AO2 P0000 FZRANO TSNO",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "KJCT",
       RawData = "KJCT 041623Z AUTO 26020G33KT 7SM BKN031 17/M05 A2971 RMK AO2 T01671050",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "KGFA",
       RawData = "KGFA 041623Z 09004KT 10SM OVC013 M02/M04 A3012 RMK AO2A SNE23 SLP234 $",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "KFST",
       RawData = "KFST 041623Z AUTO 28037G51KT 3/4SM HZ BKN021 BKN027 OVC037 13/M08 A2981 RMK AO2 PK WND 29053/1554 T01281083 $",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "KASX",
       RawData = "KASX 041623Z AUTO 05006KT 1 1/4SM BR OVC002 03/02 A2963 RMK AO2 T00280017",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "KAAT",
       RawData = "KAAT 041623Z AUTO 00000KT 10SM -SN BKN025 OVC065 01/M01 A3015 RMK AO2 P0000 T00061011",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "CYPH",
       RawData = "CYPH 041623Z AUTO 34007KT 8SM CLR M19/M23 A2980 RMK SLP096",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "CYHK",
       RawData = "CYHK 041623Z 30012KT 3SM -SN OVC018 M20/M22 A2979 RMK SC8 SLP096",
       LastChange = "2025-03-04T16:23:00Z"
    },
    new Metar {
       Station = "PGUA",
       RawData = "PGUA 041622Z AUTO 10016G25KT 7SM -RA SCT003 BKN011 OVC019 25/24 A2990 RMK AO2 RAB22 SLPNO $",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "PAJN",
       RawData = "PAJN 041622Z 00000KT 1/4SM R08/1400V2600FT FZFG VV002 M01/M01 A2994 RMK AO2 T10111011",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "PADE",
       RawData = "PADE 041622Z AUTO 26009KT 2SM BR OVC019 M16/M18 A2981 RMK AO2 T11561178 PWINO FZRANO TSNO $",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KROG",
       RawData = "KROG 041622Z 26017G26KT 6SM RA BR BKN010 OVC015 12/11 A2941 RMK AO2 PK WND 22028/1610 WSHFT 1605 CIG 007V012 P0008",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KIML",
       RawData = "KIML 041622Z AUTO 34028G45KT 2SM -SN BR FEW016 BKN021 OVC027 01/00 A2961 RMK AO2 PK WND 33051/1607 P0000 T00110000",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KGVL",
       RawData = "KGVL 041622Z AUTO 09009KT 10SM SCT028 BKN038 BKN065 12/04 A3016 RMK AO2 T01170039",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KEEO",
       RawData = "KEEO 041622Z AUTO 25006KT 3SM -SN BR BKN015 OVC021 00/M01 A2995 RMK AO2 P0000 T00001011",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KDHT",
       RawData = "KDHT 041622Z AUTO 35037G57KT 10SM BKN030 07/00 A2954 RMK AO2 PK WND 36064/1602 T00720000",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "CYQB",
       RawData = "CYQB 041622Z 27005KT 15SM SCT026 SCT048 OVC076 M04/M06 A2997 RMK SC3SC4AC1 SLP157",
       LastChange = "2025-03-04T16:22:00Z"
    },
    new Metar {
       Station = "KHBG",
       RawData = "KHBG 041621Z AUTO 15014G25KT 10SM SCT023 BKN035 19/13 A2987 RMK AO2 PK WND 14026/1610 T01940133",
       LastChange = "2025-03-04T16:21:00Z"
    },
    new Metar {
       Station = "KDUB",
       RawData = "KDUB 041621Z AUTO 30007KT 10SM SCT085 M02/M09 A2995 RMK AO2",
       LastChange = "2025-03-04T16:21:00Z"
    },
    new Metar {
       Station = "CZPC",
       RawData = "CZPC 041621Z AUTO 30005KT 6SM BR OVC002 M08/M10 A3005 RMK ICE PAST HR SLP248",
       LastChange = "2025-03-04T16:21:00Z"
    },
    new Metar {
       Station = "CYXJ",
       RawData = "CYXJ 041621Z 26003KT 60SM FEW007 SCT170 BKN230 M04/M05 A2994 RMK SF1AC4CI2 SF TR SLP176",
       LastChange = "2025-03-04T16:21:00Z"
    },
    new Metar {
       Station = "CYLK",
       RawData = "CYLK 041621Z 05003KT 10SM -SN BKN032 BKN051 OVC080 M16/M19 A3003 RMK SC5SC2AC1 SLP191",
       LastChange = "2025-03-04T16:21:00Z"
    },
    new Metar {
       Station = "SADP",
       RawData = "SADP 041620Z 17013G30KT 9999 BKN020 BKN100 25/22 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LXGB",
       RawData = "LXGB 041620Z 08010KT 7000 HZ FEW020 SCT038 17/14 Q1011 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LWSK",
       RawData = "LWSK 041620Z 25002KT CAVOK 12/00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTFM",
       RawData = "LTFM 041620Z 06012KT 9999 SCT035 06/01 Q1025 NOSIG RMK RWY17L 06010KT RWY34L 04010KT RWY16R 05011KT RWY36 05012KT RWY18 06011KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTFJ",
       RawData = "LTFJ 041620Z 05014KT 9999 SCT035 05/M01 Q1024 NOSIG RMK RWY24R 05008KT RWY06R 04012KT RWY24L 04011KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTFE",
       RawData = "LTFE 041620Z 11009KT 9999 FEW035 BKN100 14/08 Q1014 NOSIG RMK RWY10 09006KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTFC",
       RawData = "LTFC 041620Z 08012KT 9999 FEW035 07/M01 Q1016 RMK RWY23 07010KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTDB",
       RawData = "LTDB 041620Z 03009KT CAVOK 15/00 Q1013 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTCS",
       RawData = "LTCS 041620Z 09009KT 9999 FEW040 SCT100 11/M04 Q1018 RMK RWY22 11008KT 1CU040 4AC100",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTCJ",
       RawData = "LTCJ 041620Z 02006KT CAVOK 09/M03 Q1018 NOSIG RMK RWY20 01007KT 2AC100 4CI180",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTCG",
       RawData = "LTCG 041620Z 10005KT 9999 FEW018 BKN035 07/03 Q1027 NOSIG RMK RWY29 08007KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTCE",
       RawData = "LTCE 041620Z 14003KT 9999 FEW040 M07/M08 Q1021 NOSIG RMK RWY08R 14004KT RWY26R 15003KT RWY08L 16001KT 1SC040",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTCC",
       RawData = "LTCC 041620Z 29005KT 280V360 9999 FEW040 SCT100 11/M02 Q1019 NOSIG RMK RWY16 34005KT 2SC040 4AC100",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTBU",
       RawData = "LTBU 041620Z 05011KT 9999 FEW030 05/M01 Q1025 RMK RWY22 06009KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTBS",
       RawData = "LTBS 041620Z VRB02KT 9999 SCT030 BKN100 15/09 Q1014 NOSIG RMK RWY19 24003KT 4CU030 5AC100",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTBR",
       RawData = "LTBR 041620Z 02007KT 350V050 CAVOK 06/M00 Q1022 NOSIG RMK RWY07 02007KT 350V050",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTBJ",
       RawData = "LTBJ 041620Z 36014KT CAVOK 12/01 Q1015 NOSIG RMK RWY16 36012KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTBA",
       RawData = "LTBA 041620Z 05012KT CAVOK 06/M00 Q1025 RMK RWY23 05012KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAZ",
       RawData = "LTAZ 041620Z 33011KT 9999 SCT040 06/M00 Q1019 RMK RWY29 04009KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAU",
       RawData = "LTAU 041620Z 10009KT 9999 SCT035 04/M01 Q1019 NOSIG RMK RWY07 10009KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAT",
       RawData = "LTAT 041620Z 25005KT 9999 FEW040 SCT100 03/00 Q1020 NOSIG RMK RWY03 26004KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAJ",
       RawData = "LTAJ 041620Z 09009KT 9999 FEW040 SCT120 13/M06 Q1017 NOSIG RMK RWY10 09008KT 2CU040 4AC120",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAI",
       RawData = "LTAI 041620Z VRB01KT 9999 FEW030 16/04 Q1013 NOSIG RMK RWY18C VRB03KT RWY36R 09003KT RWY18L 30003KT 270V350",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAG",
       RawData = "LTAG 041620Z 02009KT CAVOK 17/M03 Q1012 NOSIG RMK 2CI200",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAF",
       RawData = "LTAF 041620Z 03010KT CAVOK 19/M02 Q1012 NOSIG RMK RWY23 05009KT SKC",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LTAC",
       RawData = "LTAC 041620Z 11007KT CAVOK 05/M09 Q1020 NOSIG RMK RWY21L 09009KT RWY03L 10006KT RWY21R 08007KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZS",
       RawData = "LSZS 041620Z 20006KT CAVOK 03/M09 Q1023 RMK T TL170",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZR",
       RawData = "LSZR 041620Z 28005KT CAVOK 10/01 Q1024 RMK L",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZH",
       RawData = "LSZH 041620Z 04004KT 010V080 CAVOK 12/M02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZG",
       RawData = "LSZG 041620Z 06004KT CAVOK 12/04 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZC",
       RawData = "LSZC 041620Z AUTO 07002KT CAVOK 10/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZB",
       RawData = "LSZB 041620Z 35004KT 320V040 CAVOK 13/00 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSZA",
       RawData = "LSZA 041620Z 19007KT CAVOK 16/00 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSMP",
       RawData = "LSMP 041620Z AUTO VRB02KT 9999NDV NCD 12/01 Q1024 RMK",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSMM",
       RawData = "LSMM 041620Z AUTO 00000KT 9999NDV NCD 10/M03 Q1023 RMK",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSME",
       RawData = "LSME 041620Z AUTO 34002KT 9999NDV NCD 13/01 Q1024 RMK",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSMD",
       RawData = "LSMD 041620Z AUTO 07004KT 020V150 9999NDV NCD 13/00 Q1024 RMK",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSGS",
       RawData = "LSGS 041620Z 25009KT CAVOK 13/M03 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSGG",
       RawData = "LSGG 041620Z AUTO 11004KT 070V200 CAVOK 12/00 Q1023 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LSGC",
       RawData = "LSGC 041620Z 02006KT 340V040 CAVOK 10/M00 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWW",
       RawData = "LOWW 041620Z 14004KT CAVOK 10/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWS",
       RawData = "LOWS 041620Z AUTO 29004KT 9999 NCD 12/M01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWL",
       RawData = "LOWL 041620Z AUTO 34004KT 9999 NCD 12/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWK",
       RawData = "LOWK 041620Z AUTO 09004KT 9999 NCD 12/M04 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWI",
       RawData = "LOWI 041620Z AUTO 08008KT 050V110 9999 NCD 14/M03 Q1022 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LOWG",
       RawData = "LOWG 041620Z AUTO 15004KT 9999 NCD 11/01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LLBG",
       RawData = "LLBG 041620Z 36006KT 9999 SCT027 18/10 Q1009 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIRZ",
       RawData = "LIRZ 041620Z AUTO 03011KT 9999 NCD 14/02 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIRQ",
       RawData = "LIRQ 041620Z 03005KT 360V070 CAVOK 17/M01 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIRN",
       RawData = "LIRN 041620Z 20004KT 160V230 CAVOK 15/02 Q1022 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIRF",
       RawData = "LIRF 041620Z 26009KT CAVOK 14/08 Q1022 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIRA",
       RawData = "LIRA 041620Z 27008KT CAVOK 14/08 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPZ",
       RawData = "LIPZ 041620Z 22004KT CAVOK 13/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPY",
       RawData = "LIPY 041620Z AUTO 33004KT 9999 NCD 10/06 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPX",
       RawData = "LIPX 041620Z 18003KT 140V210 CAVOK 15/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPR",
       RawData = "LIPR 041620Z 09003KT CAVOK 13/05 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPQ",
       RawData = "LIPQ 041620Z AUTO 15007KT 9999 NCD 12/04 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPO",
       RawData = "LIPO 041620Z AUTO 23002KT 9999 NCD 16/02 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPH",
       RawData = "LIPH 041620Z VRB01KT CAVOK 17/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIPE",
       RawData = "LIPE 041620Z VRB02KT CAVOK 14/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIMZ",
       RawData = "LIMZ 041620Z AUTO 03003KT 9999 NCD 13/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIML",
       RawData = "LIML 041620Z VRB02KT CAVOK 15/01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIMJ",
       RawData = "LIMJ 041620Z 13006KT CAVOK 14/08 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIMF",
       RawData = "LIMF 041620Z VRB02KT CAVOK 15/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIME",
       RawData = "LIME 041620Z 22004KT 180V240 CAVOK 14/M00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIMC",
       RawData = "LIMC 041620Z 17004KT CAVOK 15/M01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIEO",
       RawData = "LIEO 041620Z 11006KT CAVOK 15/09 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIEE",
       RawData = "LIEE 041620Z 12014KT 9999 FEW030 16/06 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIEA",
       RawData = "LIEA 041620Z 02008KT 9999 FEW035 17/10 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICR",
       RawData = "LICR 041620Z AUTO 20003KT 9999 OVC053/// 14/08 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICJ",
       RawData = "LICJ 041620Z 06015KT CAVOK 14/05 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICD",
       RawData = "LICD 041620Z AUTO 12007KT 9999 FEW020/// 16/12 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICC",
       RawData = "LICC 041620Z 09010KT 9999 SCT025 14/08 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICB",
       RawData = "LICB 041620Z AUTO 15004KT 090V200 9999 -RA SCT032/// BKN038/// BKN049/// 12/09 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LICA",
       RawData = "LICA 041620Z AUTO VRB02KT 9999 OVC051/// 15/06 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIBR",
       RawData = "LIBR 041620Z 02009KT CAVOK 13/03 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIBP",
       RawData = "LIBP 041620Z AUTO 08004KT 9999 NCD 12/05 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LIBD",
       RawData = "LIBD 041620Z 36003KT 300V040 9999 FEW030 13/08 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGTS",
       RawData = "LGTS 041620Z 24004KT CAVOK 12/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGSR",
       RawData = "LGSR 041620Z 35015KT 9999 SCT025 13/04 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGSO",
       RawData = "LGSO 041620Z AUTO 36022G32KT //// // ////// 11/05 Q1018 RE//",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGSM",
       RawData = "LGSM 041620Z 35012KT 310V040 9999 FEW030 14/03 Q1015",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGSA",
       RawData = "LGSA 041620Z 35010KT 9999 FEW016 BKN025 BKN070 10/06 Q1018",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGRX",
       RawData = "LGRX 041620Z 04014KT 9999 FEW025 12/01 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGRP",
       RawData = "LGRP 041620Z VRB03KT 9999 FEW020 13/08 Q1014 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGPZ",
       RawData = "LGPZ 041620Z 09004KT 9999 FEW035 12/01 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGPA",
       RawData = "LGPA 041620Z AUTO 36023KT //// // ////// 11/05 Q1017 RE//",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGMT",
       RawData = "LGMT 041620Z 36010G20KT 330V040 CAVOK 11/03 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGMK",
       RawData = "LGMK 041620Z 01022KT 9999 FEW015 11/03 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGLM",
       RawData = "LGLM 041620Z 03016G26KT 9999 FEW025 09/02 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKZ",
       RawData = "LGKZ 041620Z AUTO VRB03KT //// // ////// 07/M08 Q1023 RE//",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKV",
       RawData = "LGKV 041620Z 00000KT 9999 FEW030 10/02 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKR",
       RawData = "LGKR 041620Z 26006KT 9999 FEW025 14/05 Q1021 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKP",
       RawData = "LGKP 041620Z 31011KT 9999 FEW018 SCT025 13/06 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKO",
       RawData = "LGKO 041620Z 36009KT 9999 FEW018 13/05 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGKL",
       RawData = "LGKL 041620Z 14004KT 9999 FEW030 13/07 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGIR",
       RawData = "LGIR 041620Z 33018KT 9999 -RA SCT010 FEW018TCU BKN020 12/08 Q1017 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGIO",
       RawData = "LGIO 041620Z VRB03KT CAVOK 10/M03 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGEL",
       RawData = "LGEL 041620Z 35010G24KT 9999 SCT030 10/M00 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGBL",
       RawData = "LGBL 041620Z 26004KT 9999 FEW030 08/03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGAV",
       RawData = "LGAV 041620Z 02014KT 9999 SCT035 09/M01 Q1022 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGAL",
       RawData = "LGAL 041620Z 06009KT 9999 FEW030 10/M02 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LGAD",
       RawData = "LGAD 041620Z 01014KT 9999 FEW025 12/02 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LCRA",
       RawData = "LCRA 041620Z 26003KT CAVOK 16/10 Q1011 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LCEN",
       RawData = "LCEN 041620Z 34009KT 9999 FEW025 BKN200 15/06 Q1012 NOSIG RMK RWY11R 36007KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "LATI",
       RawData = "LATI 041620Z 35006KT CAVOK 13/04 Q1022 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KW40",
       RawData = "KW40 041620Z AUTO 16015G19KT 10SM SCT044 SCT050 16/07 A3026 RMK AO2 T01600065",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KVCV",
       RawData = "KVCV 041620Z AUTO 14005KT 10SM CLR 07/01 A3022 RMK AO2",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KSHV",
       RawData = "KSHV 041620Z 30008KT 3SM -TSRA BR FEW015 BKN047CB OVC070 14/12 A2954 RMK OCNL LTGICCC NE-SE-S TS NE-SE-S MOV E",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KPO1",
       RawData = "KPO1 041620Z AUTO 34008KT 4SM UP BR SCT016 OVC024 M02/M03 A3012 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KMWS",
       RawData = "KMWS 041620Z 01002KT 04/M04",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KMSN",
       RawData = "KMSN 041620Z 18010KT 10SM OVC031 08/05 A2960 RMK AO2 T00830050",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KMLP",
       RawData = "KMLP 041620Z AUTO 00000KT 10SM BKN013 OVC050 M02/M04 A3000 RMK AO2 T10171044",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KMCC",
       RawData = "KMCC 041620Z AUTO 15007KT 10SM BKN095 10/08 A3027 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KLSF",
       RawData = "KLSF 041620Z AUTO 14009G16KT 10SM BKN029 20/13 A3003 RMK AO2 BKN V SCT CIG 028 RWY15 SLP174",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KLRF",
       RawData = "KLRF 041620Z AUTO 15017G28KT 5SM TS RA BR FEW003 OVC010 15/13 A2944 RMK AO2 TSB1555E17TSB20 CIG 010V012 SLP971 $",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KJSL",
       RawData = "KJSL 041620Z AUTO 16031G40KT 7SM BKN025 BKN031 26/21 A2978 RMK A01",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KIWD",
       RawData = "KIWD 041620Z AUTO 01003KT 2 1/2SM -RA BR OVC002 02/02 A2965 RMK AO2 P0001 FZRANO",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KHNZ",
       RawData = "KHNZ 041620Z AUTO 19007KT 10SM CLR 12/M04 A3024 RMK AO2 T01231039",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KFTN",
       RawData = "KFTN 041620Z AUTO 32016G30KT 5SM HZ CLR 24/M12 A2979 RMK A01",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KDTN",
       RawData = "KDTN 041620Z 30006KT 3SM RA BR BKN048 OVC070 13/12 A2955 RMK AO2 LTG DSNT NE-S TSB1557E12 P0013 T01330117",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KDMW",
       RawData = "KDMW 041620Z AUTO 17009KT 10SM BKN075 11/M04 A3015 RMK AO2",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KAFF",
       RawData = "KAFF 041620Z 34029G34KT 7SM -SN BLSN SCT004 BKN040 034 01/M04 A2972 RMK AO2A CIG LWR W-NW SLP074",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KACZ",
       RawData = "KACZ 041620Z AUTO 15012KT 10SM SCT046 18/07 A3027 RMK AO2 T01820068",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "K1LN",
       RawData = "K1LN 041620Z AUTO 35013KT 10SM OVC015 M02/M05 A3002 RMK AO2 SLP195 $",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "K1D1",
       RawData = "K1D1 041620Z AUTO 35024G30KT 3/4SM -SN BR OVC003 M01/M01 A2973 RMK AO2",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "K10U",
       RawData = "K10U 041620Z AUTO 14004KT 10SM OVC050 01/M01 A3011 RMK AO2",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "K0A9",
       RawData = "K0A9 041620Z AUTO 00000KT 8SM CLR 15/M08 A3010 RMK AO2",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EYVI",
       RawData = "EYVI 041620Z 28014KT 9999 OVC014 05/02 Q1011 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EYSA",
       RawData = "EYSA 041620Z 27014KT 9999 BKN017 OVC021 05/02 Q1009 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EYPA",
       RawData = "EYPA 041620Z 27009G19KT 240V330 CAVOK 05/03 Q1011",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EYKA",
       RawData = "EYKA 041620Z 27015KT 250V310 4900 -DZ BR OVC010 04/03 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EVVA",
       RawData = "EVVA 041620Z AUTO 24012KT CAVOK 06/03 Q1007",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EVRA",
       RawData = "EVRA 041620Z 27006KT 220V310 9999 OVC033 07/02 Q1006 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EVLA",
       RawData = "EVLA 041620Z AUTO 26017KT 9999 NSC 05/03 Q1009",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EVGA",
       RawData = "EVGA 041620Z 28011KT 250V320 9999 OVC032 07/02 Q1005 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETWM",
       RawData = "ETWM 041620Z AUTO VRB03KT //// // ////// 10/03 Q1024 ///",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETSN",
       RawData = "ETSN 041620Z 11002KT 9999 SCT320 12/M04 Q1024 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETSL",
       RawData = "ETSL 041620Z AUTO 03005KT 9999 // ////// 09/M02 Q1024 ///",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETSI",
       RawData = "ETSI 041620Z 10003KT 9999 FEW240 BKN320 12/M06 Q1024 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETSH",
       RawData = "ETSH 041620Z 23005KT 9999 FEW320 11/M04 Q1025 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETSB",
       RawData = "ETSB 041620Z 09005KT 9999 SCT290 12/M05 Q1024 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNW",
       RawData = "ETNW 041620Z 26004KT 9999 FEW300 10/M02 Q1025 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNT",
       RawData = "ETNT 041620Z 23008KT 9999 FEW020 SCT320 10/05 Q1023 BLACKBLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNS",
       RawData = "ETNS 041620Z 24014KT 8000 FEW012 SCT230 07/05 Q1021 BLU+BLU+ TEMPO GRN",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNN",
       RawData = "ETNN 041620Z 30003KT 9999 FEW300 12/M02 Q1025 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNL",
       RawData = "ETNL 041620Z 27011KT 9999 FEW020 BKN370 10/05 Q1022 BLU+BLU+ TEMPO WHT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETNH",
       RawData = "ETNH 041620Z 22009KT 7000 FEW013 BKN340 07/05 Q1021 WHT BLU+ TEMPO GRN",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETMN",
       RawData = "ETMN 041620Z 25005KT 9999 BKN270 08/05 Q1023 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHS",
       RawData = "ETHS 041620Z 24008KT 9999 SCT380 10/M01 Q1024 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHN",
       RawData = "ETHN 041620Z 07003KT 9999 SCT240 11/M01 Q1025 BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHL",
       RawData = "ETHL 041620Z 06004KT 9999 FEW250 10/M02 Q1024 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHF",
       RawData = "ETHF 041620Z 18004KT 9999 SCT330 12/M03 Q1025 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHC",
       RawData = "ETHC 041620Z 22006KT 9999 FEW340 11/M01 Q1024 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHB",
       RawData = "ETHB 041620Z 32002KT 9999 FEW350 11/M01 Q1025 BLU+FCST CNL",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETHA",
       RawData = "ETHA 041620Z 08006KT 9999 FEW300 09/M02 Q1024 BLU+BLU+",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ETGG",
       RawData = "ETGG 041620Z AUTO 26019KT 9999 // ////// 07/05 Q1020 ///",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESUT",
       RawData = "ESUT 041620Z AUTO 09004KT 9999 OVC028/// M02/M04 Q0991",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESUP",
       RawData = "ESUP 041620Z 27006KT CAVOK M00/M06 Q0988",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESTL",
       RawData = "ESTL 041620Z AUTO 26014KT 9999 OVC035/// 10/05 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESTA",
       RawData = "ESTA 041620Z 26013KT 9999 BKN028 BKN037 07/05 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSV",
       RawData = "ESSV 041620Z 25010KT CAVOK 05/02 Q1008",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESST",
       RawData = "ESST 041620Z 24010G21KT 200V260 CAVOK 09/00 Q1003",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSP",
       RawData = "ESSP 041620Z AUTO 26013KT 9999 NCD 07/01 Q1007",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSL",
       RawData = "ESSL 041620Z 26017KT CAVOK 07/02 Q1007",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSD",
       RawData = "ESSD 041620Z AUTO 15005KT 9999 BKN076/// OVC130/// 03/M00 Q1002",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSB",
       RawData = "ESSB 041620Z VRB02KT CAVOK 06/02 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESSA",
       RawData = "ESSA 041620Z 00000KT CAVOK 04/M01 Q1004 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESPE",
       RawData = "ESPE 041620Z AUTO 28006KT 9999 NCD 01/M06 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESPA",
       RawData = "ESPA 041620Z 27007KT CAVOK 03/M05 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESOW",
       RawData = "ESOW 041620Z AUTO 24007KT 190V270 9999 NCD 07/00 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESOK",
       RawData = "ESOK 041620Z AUTO 24013KT 9999 NCD 07/01 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESOH",
       RawData = "ESOH 041620Z AUTO 20007KT 170V240 9999 FEW120/// SCT180/// 08/M00 Q1003",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESOE",
       RawData = "ESOE 041620Z 24014G24KT 210V280 CAVOK 06/02 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNZ",
       RawData = "ESNZ 041620Z 18007KT CAVOK 00/M05 Q0996",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNX",
       RawData = "ESNX 041620Z 28013KT CAVOK M01/M07 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNV",
       RawData = "ESNV 041620Z AUTO 23004KT 9999 NCD M01/M06 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNU",
       RawData = "ESNU 041620Z 26006KT CAVOK 03/M05 Q0996",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNS",
       RawData = "ESNS 041620Z 27009KT CAVOK 02/M06 Q0994",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNQ",
       RawData = "ESNQ 041620Z 28012KT CAVOK M02/M09 Q0987",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNO",
       RawData = "ESNO 041620Z 26007KT CAVOK 02/M05 Q0997",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNN",
       RawData = "ESNN 041620Z AUTO 30004KT 270V340 9999 R16/P2000N R34///// OVC100/// 03/M05 Q1000",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNL",
       RawData = "ESNL 041620Z AUTO 29006KT 9999 NCD M01/M06 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNK",
       RawData = "ESNK 041620Z 28009KT CAVOK 03/M04 Q0999",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESNG",
       RawData = "ESNG 041620Z 28010KT CAVOK M01/M06 Q0988",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESND",
       RawData = "ESND 041620Z VRB02KT 9999 BKN035 OVC045 01/M03 Q0999",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMX",
       RawData = "ESMX 041620Z 25014KT 220V280 9999 BKN019 07/04 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMV",
       RawData = "ESMV 041620Z AUTO 24014KT 9999 NCD 06/02 Q1011",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMT",
       RawData = "ESMT 041620Z 24013KT 9999 OVC029 06/04 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMS",
       RawData = "ESMS 041620Z 25014KT 9999 BKN032 08/06 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMQ",
       RawData = "ESMQ 041620Z 27014KT CAVOK 08/03 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESMK",
       RawData = "ESMK 041620Z 27013KT 9999 BKN034 10/04 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESKS",
       RawData = "ESKS 041620Z AUTO 19010KT 9999 SCT049/// OVC110/// 05/M01 Q0999",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESKN",
       RawData = "ESKN 041620Z 26010KT CAVOK 07/02 Q1006",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESKM",
       RawData = "ESKM 041620Z AUTO 13004KT 9999 SCT120/// 01/00 Q1001",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESIB",
       RawData = "ESIB 041620Z AUTO 25017KT 9999 NCD 07/04 Q1009",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESIA",
       RawData = "ESIA 041620Z AUTO 26011KT 9999 NCD 06/03 Q1007",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESGT",
       RawData = "ESGT 041620Z 24014KT 220V280 9999 BKN017 07/04 Q1010",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESGP",
       RawData = "ESGP 041620Z AUTO 24009KT 9999 OVC009/// 07/04 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESGJ",
       RawData = "ESGJ 041620Z 25014KT 9999 FEW022 06/03 Q1010",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESGG",
       RawData = "ESGG 041620Z 24013KT 9999 BKN007 OVC009 06/04 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESDF",
       RawData = "ESDF 041620Z 27012KT 9999 BKN030 08/03 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESCM",
       RawData = "ESCM 041620Z AUTO 20002KT 9999 FEW170/// 04/01 Q1004",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ESCF",
       RawData = "ESCF 041620Z 24013KT 9999 FEW025 BKN200 06/03 Q1008",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENZV",
       RawData = "ENZV 041620Z 20012KT 9999 FEW010 BKN055 07/05 Q1009 TEMPO 22018G28KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENWV",
       RawData = "ENWV 041620Z AUTO 23034KT 9999NDV NCD 07/05 Q1016 W///S4",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENVD",
       RawData = "ENVD 041620Z 03006KT 9999 SCT013 BKN017 M01/M03 Q0985",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENVA",
       RawData = "ENVA 041620Z 05005KT 350V090 9999 -RASN FEW012 BKN040 02/01 Q0993 TEMPO 4000 RADZ BKN008 RMK WIND 670FT 14011KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENUN",
       RawData = "ENUN 041620Z AUTO 15020G31KT 9999 -SHRA OVC024/// 03/M01 Q0983 W06/S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENUG",
       RawData = "ENUG 041620Z AUTO 05005KT 320V100 9999NDV FEW018/// OVC069/// 03/M01 Q0985 W///S5",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENTO",
       RawData = "ENTO 041620Z 21018KT CAVOK 08/03 Q1006 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENTC",
       RawData = "ENTC 041620Z 14003KT 100V200 9999 VCSH BKN013 01/M00 Q0988 TEMPO BKN018 RMK WIND 2600FT 31020KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENST",
       RawData = "ENST 041620Z 17013KT 140V200 9999 VCSH FEW026 SCT033 BKN110 03/M03 Q0991 RMK WIND 300FT 16017KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSS",
       RawData = "ENSS 041620Z 15004KT 9000 -SHSNRA BKN010 01/01 Q0986 RMK WIND 0500FT 15007KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSR",
       RawData = "ENSR 041620Z 28008KT 250V310 9999 VCSH FEW016 SCT019 BKN033 02/M01 Q0986 RMK WIND RWY 32 31008KT WIND 1119FT 27018KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSO",
       RawData = "ENSO 041620Z 22012KT 9999 SCT011 07/07 Q1006",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSL",
       RawData = "ENSL 041620Z AUTO 22042KT 9999 BKN038/// 08/05 Q1007 W06/S5",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSK",
       RawData = "ENSK 041620Z 17005KT 150V210 9999 VCSH FEW012 SCT024 BKN036 02/00 Q0990",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSH",
       RawData = "ENSH 041620Z VRB02KT 9999 FEW017 01/00 Q0990 RMK WIND 0150FT VRB02KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSG",
       RawData = "ENSG 041620Z 26019KT 9999 -RA FEW010 BKN022 BKN035 06/02 Q0998 RMK WIND 3806FT 23032G44KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSF",
       RawData = "ENSF 041620Z AUTO 25051KT 4800 -RA BR BKN010/// 10/08 Q0993 W/////",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSE",
       RawData = "ENSE 041620Z AUTO 23041KT 3000 -RA OVC010/// 09/08 Q0993 W/////",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSD",
       RawData = "ENSD 041620Z 22018G33KT 180V260 3800 SHRA BR FEW006 SCT017 BKN032 09/05 Q0996 RMK WIND RWY 26 26018G30KT WIND 1140FT VRB11G22KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENSB",
       RawData = "ENSB 041620Z 12014KT 9999 VCSH FEW020 SCT050 M09/M14 Q1006 RMK WIND 1400FT 11020KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENRY",
       RawData = "ENRY 041620Z 23012KT CAVOK 07/02 Q1006",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENRS",
       RawData = "ENRS 041620Z 17012KT 9999 FEW024 04/00 Q0989",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENRO",
       RawData = "ENRO 041620Z VRB02KT 9999 -SNRA SCT030 BKN058 M00/M01 Q0994",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENRM",
       RawData = "ENRM 041620Z 15012KT 120V190 4000 SNRA VV008 02/M00 Q0991",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENRA",
       RawData = "ENRA 041620Z VRB02KT 9999 FEW026 SCT032 BKN042 00/M00 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENQR",
       RawData = "ENQR 041620Z AUTO 23044KT 2000 -RA /// 09/08 Q0990 W12///",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENQC",
       RawData = "ENQC 041620Z AUTO 21040KT 0900 OVC018/// 09/07 Q0997 W///S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENQA",
       RawData = "ENQA 041620Z AUTO 20042KT 8000 -SHRA OVC024/// 09/06 Q0999 W07/S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENOV",
       RawData = "ENOV 041620Z 23022G40KT 8000 RA FEW020 SCT030 BKN038 09/05 Q0994 RMK WIND RWY 24 23022G35KT WIND 2090FT 23033G53KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENOL",
       RawData = "ENOL 041620Z 14021KT 9999 -RADZ SCT012 BKN035 02/01 Q0990 TEMPO 4000 RADZ BKN012 BECMG 26025KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENOA",
       RawData = "ENOA 041620Z 23040KT 8000 -SHRA OVC018 08/07 Q0998 W///S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENNM",
       RawData = "ENNM 041620Z 08004KT 4000 SNRA VV012 01/M01 Q0993",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENNE",
       RawData = "ENNE 041620Z 13024KT 8000 OVC012 02/00 Q0984 W///S5",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENNA",
       RawData = "ENNA 041620Z 15004KT 060V180 9999 FEW017 BKN023 M02/M04 Q0986 RMK WIND 1800FT 24006KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENMS",
       RawData = "ENMS 041620Z 15004KT 120V190 9999 FEW022 BKN040 01/M01 Q0992 RMK WIND 412FT 16005KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENML",
       RawData = "ENML 041620Z 07007KT 6000 RA FEW000 SCT019 BKN041 03/03 Q0991",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENMH",
       RawData = "ENMH 041620Z 18004KT CAVOK M02/M04 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENLK",
       RawData = "ENLK 041620Z 15005KT 9999 FEW020 SCT050 03/01 Q0989",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENLE",
       RawData = "ENLE 041620Z 22035KT CAVOK 07/04 Q1014 W07/S4",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENLA",
       RawData = "ENLA 041620Z AUTO 21036KT 9999NDV NCD 07/06 Q1011 W///S5",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENKR",
       RawData = "ENKR 041620Z 00000KT 9999 -SHSN BKN006 M03/M03 Q0985 RMK WIND 731FT 12002KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENKB",
       RawData = "ENKB 041620Z 21010G20KT 170V250 9000 -RA FEW023 SCT028 BKN036 07/04 Q0989 RMK WIND 745FT 21025KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENJS",
       RawData = "ENJS 041620Z 22038KT 9000 BKN030 08/05 Q1006 W08/S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENHV",
       RawData = "ENHV 041620Z VRB01KT 9999 FEW021 BKN094 M02/M03 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENHK",
       RawData = "ENHK 041620Z AUTO 33004KT 9999 -SN NCD 00/M01 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENHF",
       RawData = "ENHF 041620Z 03003KT 9999 FEW006 SCT021 BKN042 M02/M03 Q0985 RMK WIND 1253FT 01003KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENHE",
       RawData = "ENHE 041620Z 14043KT 2500 -RA OVC008 04/03 Q0980 W///S5",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENHD",
       RawData = "ENHD 041620Z 20015KT 7000 SCT010 BKN049 06/05 Q1007",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENGM",
       RawData = "ENGM 041620Z 19017KT CAVOK 06/M01 Q1002 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENGC",
       RawData = "ENGC 041620Z 23045KT 4000 -RA BR OVC011 09/09 Q0996 W08/S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENFL",
       RawData = "ENFL 041620Z 20032G45KT 2600 +SHRA FEW007 SCT011 BKN016 08/07 Q0997",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENFB",
       RawData = "ENFB 041620Z AUTO 23052KT 1500 -RA BR BKN011/// ///// //// W/////",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENEV",
       RawData = "ENEV 041620Z 24004KT 180V330 9999 FEW010 SCT034 BKN076 02/M00 Q0991 NOSIG RMK WIND 1400FT 26014KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENDU",
       RawData = "ENDU 041620Z VRB03KT 9999 VCSH FEW007 BKN030 01/M00 Q0988 TEMPO 4500 -SHSNRA VV014 RMK WIND 1100FT 25013KT WIND 2200FT 27015KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENDR",
       RawData = "ENDR 041620Z AUTO 20041KT 4000NDV RA OVC010/// 07/07 Q0983 W///S6",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENCN",
       RawData = "ENCN 041620Z 25015KT 9999 BKN016 08/04 Q1010",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBV",
       RawData = "ENBV 041620Z 24003KT 9999 FEW025 BKN095 M02/M05 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBS",
       RawData = "ENBS 041620Z AUTO 12001KT 9999 BKN025/// BKN029/// OVC090/// M02/M02 Q0985",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBR",
       RawData = "ENBR 041620Z 20018KT 5000 -RA SCT004 BKN006 07/06 Q1005 TEMPO 2000 SHRA BR BKN004 SCT015TCU RMK WIND 1200FT 22027G46KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBO",
       RawData = "ENBO 041620Z 21007KT 170V230 9999 FEW020 SCT050 03/M02 Q0991 BECMG 10009KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBN",
       RawData = "ENBN 041620Z 14012KT 120V180 9999 FEW027 BKN066 03/M02 Q0991",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENBL",
       RawData = "ENBL 041620Z 22013KT 170V250 4500 RA BR FEW003 SCT008 BKN012 06/05 Q0998",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENAT",
       RawData = "ENAT 041620Z 13003KT 9999 -SN SCT017 BKN037 M01/M02 Q0986 RMK WIND 700FT VRB03KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENAN",
       RawData = "ENAN 041620Z 24007KT 9999 VCSH BKN039 03/M01 Q0989",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ENAL",
       RawData = "ENAL 041620Z 23036G47KT 6000 -RA SCT010 BKN014 08/06 Q0991",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "ELLX",
       RawData = "ELLX 041620Z 07004KT CAVOK 13/M04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKYT",
       RawData = "EKYT 041620Z AUTO 24019KT 9999 BKN030/// 07/05 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKVJ",
       RawData = "EKVJ 041620Z AUTO 23010KT 190V270 8000 NCD 06/05 Q1018 UNMONITORED",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKVG",
       RawData = "EKVG 041620Z AUTO 27019G36KT 9999 SCT030/// SCT042/// BKN073/// BKN140/// 06/01 Q0989 RERA RMK BKN031/// BKN067/// BKN140/// WIND SKEID 27030G44KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKVD",
       RawData = "EKVD 041620Z AUTO 26013KT //// ///////// 07/// Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKSP",
       RawData = "EKSP 041620Z 25014KT 9999 FEW015 BKN210 07/05 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKSB",
       RawData = "EKSB 041620Z 23010KT 9999 SCT015 08/05 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKRN",
       RawData = "EKRN 041620Z AUTO 26022KT 5000 BKN031/// 06/04 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKRK",
       RawData = "EKRK 041620Z AUTO 26014KT 9999 NCD 09/05 Q1018",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKOD",
       RawData = "EKOD 041620Z AUTO 25016KT 9999 NCD 09/05 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKKA",
       RawData = "EKKA 041620Z AUTO 23013KT 9999 FEW013/// BKN029/// 07/05 Q1017 TEMPO 27015G25KT BKN015",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKEB",
       RawData = "EKEB 041620Z AUTO 23014KT 8000 BKN005/// 06/05 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKCH",
       RawData = "EKCH 041620Z AUTO 26014KT 9999 SCT029/// 10/05 Q1018 TEMPO 27018G30KT",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKBI",
       RawData = "EKBI 041620Z AUTO 25012KT 9999 FEW034/// 07/05 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EKAH",
       RawData = "EKAH 041620Z AUTO 25011KT 9999 OVC031/// 09/05 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGYP",
       RawData = "EGYP 041620Z 33031KT 9999 FEW031 BKN130 16/08 Q0992 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGYM",
       RawData = "EGYM 041620Z 21011KT CAVOK 12/00 Q1022 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGYH",
       RawData = "EGYH 041620Z 23014KT 9999 SKC 12/01 Q1022 RMK BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGYD",
       RawData = "EGYD 041620Z 24013KT CAVOK 11/01 Q1022 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXZ",
       RawData = "EGXZ 041620Z AUTO 22014KT 9999 NCD 08/03 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXW",
       RawData = "EGXW 041620Z 23012KT CAVOK 11/00 Q1021 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXV",
       RawData = "EGXV 041620Z AUTO 26009KT 9999 NCD 11/02 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXT",
       RawData = "EGXT 041620Z AUTO 23011KT 9999 NCD 12/M01 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXS",
       RawData = "EGXS 041620Z AUTO 22017KT 9999 NCD 12/00 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGXE",
       RawData = "EGXE 041620Z 24013KT 9999 FEW030 BKN250 08/03 Q1020 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGWU",
       RawData = "EGWU 041620Z 22005KT CAVOK 13/M02 Q1023 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGWC",
       RawData = "EGWC 041620Z AUTO 21009KT //// ///////// ///// Q////",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGVP",
       RawData = "EGVP 041620Z 16006KT CAVOK 12/M02 Q1024 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGVO",
       RawData = "EGVO 041620Z 21007KT CAVOK 12/M02 Q1023 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGVN",
       RawData = "EGVN 041620Z 23005KT CAVOK 13/M03 Q1023 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGUW",
       RawData = "EGUW 041620Z 18009KT CAVOK 11/02 Q1023 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGUB",
       RawData = "EGUB 041620Z 19006KT CAVOK 13/M01 Q1023 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGTE",
       RawData = "EGTE 041620Z 18007KT CAVOK 11/03 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGTC",
       RawData = "EGTC 041620Z 23009KT CAVOK 11/M01 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGSY",
       RawData = "EGSY 041620Z 28009KT CAVOK 09/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGSS",
       RawData = "EGSS 041620Z AUTO 19007KT 9999 NCD 12/M01 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGSH",
       RawData = "EGSH 041620Z 21008KT 170V250 CAVOK 12/01 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGSC",
       RawData = "EGSC 041620Z 21007KT CAVOK 13/M01 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGQM",
       RawData = "EGQM 041620Z AUTO 23014G26KT 9999 NCD 09/03 Q1015",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGQK",
       RawData = "EGQK 041620Z AUTO 23027G40KT 9999 BKN054/// 11/06 Q1006",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGQA",
       RawData = "EGQA 041620Z AUTO 21016KT 9999 -RA OVC026/// 11/06 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPU",
       RawData = "EGPU 041620Z 20030KT 4500 -RA BKN005 09/08 Q1010",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPO",
       RawData = "EGPO 041620Z 22023G33KT 9999 -RA FEW015 BKN020 11/09 Q1003 RERA",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPN",
       RawData = "EGPN 041620Z 25019KT 9999 SCT020 BKN025 08/05 Q1012",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPL",
       RawData = "EGPL 041620Z 23030KT 4000 RA SCT008 BKN012 10/09 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPK",
       RawData = "EGPK 041620Z 21013KT 9999 FEW030 10/04 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPI",
       RawData = "EGPI 041620Z 22015G25KT 9999 SCT024 BKN045 10/07 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPH",
       RawData = "EGPH 041620Z 24016KT CAVOK 10/03 Q1013",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPF",
       RawData = "EGPF 041620Z AUTO 22021G32KT 9999 FEW021 09/05 Q1015",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPE",
       RawData = "EGPE 041620Z 21021G33KT 9999 FEW010 BKN046 10/06 Q1006",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPD",
       RawData = "EGPD 041620Z AUTO 24013KT 9999 NCD 11/06 Q1008",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPC",
       RawData = "EGPC 041620Z 21016G28KT 160V240 9999 -RA BKN033 11/05 Q1003",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPB",
       RawData = "EGPB 041620Z 24032KT 5000 RA SCT009 BKN016 09/08 Q0999 TEMPO BKN008",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGPA",
       RawData = "EGPA 041620Z 23017KT 9000 -RA BKN024 BKN028 OVC032 10/07 Q1002",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGOW",
       RawData = "EGOW 041620Z 20013KT CAVOK 09/02 Q1021 RMK BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGOV",
       RawData = "EGOV 041620Z AUTO 20023KT 9999 BKN018/// 08/04 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGOS",
       RawData = "EGOS 041620Z 26012KT CAVOK 09/01 Q1023 NOSIG RMK BLACKBLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGOP",
       RawData = "EGOP 041620Z AUTO 23008KT 9999 NCD 08/03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGOM",
       RawData = "EGOM 041620Z AUTO 25020KT 9999 NCD 06/02 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNX",
       RawData = "EGNX 041620Z 23011KT CAVOK 11/M00 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNV",
       RawData = "EGNV 041620Z 22018KT 9999 FEW031 08/03 Q1019",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNT",
       RawData = "EGNT 041620Z 23010KT 190V260 9999 FEW025 09/02 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNS",
       RawData = "EGNS 041620Z 22018KT 9999 FEW018 08/04 Q1019 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNR",
       RawData = "EGNR 041620Z 23014KT CAVOK 09/01 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNO",
       RawData = "EGNO 041620Z 21011KT 9999 FEW028 08/03 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNM",
       RawData = "EGNM 041620Z 23011KT 9999 FEW024 08/02 Q1020",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNJ",
       RawData = "EGNJ 041620Z 21012KT CAVOK 12/02 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGNH",
       RawData = "EGNH 041620Z 23008KT CAVOK 08/04 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGMD",
       RawData = "EGMD 041620Z 21004KT CAVOK 10/04 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGMC",
       RawData = "EGMC 041620Z 11005KT 080V160 CAVOK 10/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGLL",
       RawData = "EGLL 041620Z AUTO 20006KT 170V240 9999 NCD 13/M03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGLF",
       RawData = "EGLF 041620Z AUTO 22005KT 170V260 9999 NCD 13/00 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGLC",
       RawData = "EGLC 041620Z AUTO 21006KT 150V240 9999 NCD 14/M04 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGKK",
       RawData = "EGKK 041620Z 20006KT 160V230 CAVOK 12/M03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGKB",
       RawData = "EGKB 041620Z 20007KT CAVOK 11/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGKA",
       RawData = "EGKA 041620Z 18003KT 150V230 6000 NSC 09/05 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGJJ",
       RawData = "EGJJ 041620Z 11008KT CAVOK 11/04 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGJB",
       RawData = "EGJB 041620Z 07005KT 040V110 CAVOK 09/03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGJA",
       RawData = "EGJA 041620Z 11007KT CAVOK 09/05 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGHQ",
       RawData = "EGHQ 041620Z 30003KT 250V010 9999 FEW015 09/05 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGHI",
       RawData = "EGHI 041620Z 21005KT CAVOK 12/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGHH",
       RawData = "EGHH 041620Z 17007KT 120V190 7000 NSC 09/04 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGHE",
       RawData = "EGHE 041620Z 12004KT CAVOK 09/04 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGHC",
       RawData = "EGHC 041620Z VRB03KT 9999 FEW024 09/05 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGGW",
       RawData = "EGGW 041620Z AUTO 20007KT 160V250 9999 NCD 12/M03 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGGP",
       RawData = "EGGP 041620Z 22008KT 190V250 CAVOK 09/01 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGGD",
       RawData = "EGGD 041620Z AUTO 23009KT 9999 NCD 11/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGFF",
       RawData = "EGFF 041620Z AUTO 29008KT 9999 NCD 09/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGEC",
       RawData = "EGEC 041620Z 21012KT 9999 FEW028 11/06 Q1015",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGDY",
       RawData = "EGDY 041620Z 28002KT CAVOK 13/01 Q1024 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGDR",
       RawData = "EGDR 041620Z 23005KT 9999 HZ FEW020 10/05 Q1024 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGDM",
       RawData = "EGDM 041620Z 23006KT CAVOK 12/M02 Q1024 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGCK",
       RawData = "EGCK 041620Z 20017KT 9999 FEW036 08/03 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGCC",
       RawData = "EGCC 041620Z AUTO 24008KT 9999 NCD 10/02 Q1022",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGBJ",
       RawData = "EGBJ 041620Z 22006KT CAVOK 11/02 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGBB",
       RawData = "EGBB 041620Z 21006KT 180V250 CAVOK 11/00 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGAE",
       RawData = "EGAE 041620Z 22017KT 9999 BKN024 11/07 Q1014",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGAC",
       RawData = "EGAC 041620Z AUTO 22016KT 9999 NCD 11/04 Q1017",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EGAA",
       RawData = "EGAA 041620Z AUTO 22014KT 9999 NCD 10/05 Q1016",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFVA",
       RawData = "EFVA 041620Z AUTO 24007KT CAVOK 01/M03 Q0997",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFUT",
       RawData = "EFUT 041620Z 29008KT CAVOK 02/M04 Q0996",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFTU",
       RawData = "EFTU 041620Z AUTO 29007KT CAVOK 02/M03 Q1001",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFTP",
       RawData = "EFTP 041620Z AUTO 27010KT CAVOK 02/M02 Q0998",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFSI",
       RawData = "EFSI 041620Z AUTO 24004KT 210V270 CAVOK 01/M04 Q0996",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFSA",
       RawData = "EFSA 041620Z AUTO 30009KT 9999 SCT020 00/M02 Q0993",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFRO",
       RawData = "EFRO 041620Z AUTO 26005KT CAVOK M02/M03 Q0988",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFPO",
       RawData = "EFPO 041620Z AUTO 28008KT CAVOK 02/M02 Q1000",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFOU",
       RawData = "EFOU 041620Z AUTO 29008KT CAVOK M02/M04 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFMI",
       RawData = "EFMI 041620Z AUTO 28005KT CAVOK 01/M04 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFMA",
       RawData = "EFMA 041620Z AUTO 27003KT 200V340 CAVOK 05/M02 Q1003",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFLP",
       RawData = "EFLP 041620Z AUTO 29004KT CAVOK 01/M01 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKU",
       RawData = "EFKU 041620Z AUTO 27006KT CAVOK M00/M03 Q0993",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKT",
       RawData = "EFKT 041620Z AUTO 28005KT CAVOK M01/M05 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKS",
       RawData = "EFKS 041620Z AUTO 29009KT 5000 -SN OVC011 M02/M03 Q0986",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKK",
       RawData = "EFKK 041620Z AUTO 23004KT CAVOK 00/M04 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKI",
       RawData = "EFKI 041620Z AUTO 26010KT CAVOK M03/M04 Q0990",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFKE",
       RawData = "EFKE 041620Z AUTO 24004KT CAVOK M01/M04 Q0990",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFJY",
       RawData = "EFJY 041620Z AUTO 28006KT CAVOK 01/M06 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFJO",
       RawData = "EFJO 041620Z AUTO 30010KT 9999 SCT018 M00/M03 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFIV",
       RawData = "EFIV 041620Z AUTO 24003KT 9999 BKN022 M01/M03 Q0985",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFHK",
       RawData = "EFHK 041620Z 28012KT CAVOK 03/M03 Q0999 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFHA",
       RawData = "EFHA 041620Z AUTO 27007KT CAVOK 00/M05 Q0996",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EFET",
       RawData = "EFET 041620Z AUTO 28007KT CAVOK M02/M05 Q0985",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EETU",
       RawData = "EETU 041620Z AUTO 27014KT 9999 FEW097/// BKN110/// 01/M01 Q1001",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EETN",
       RawData = "EETN 041620Z 28012KT CAVOK 02/M03 Q1001 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EEPU",
       RawData = "EEPU 041620Z AUTO 28007KT 9999 OVC063/// 03/M01 Q1004",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EEKE",
       RawData = "EEKE 041620Z AUTO 30004KT 260V340 9999 FEW026/// BKN180/// 04/M00 Q1005",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EEKA",
       RawData = "EEKA 041620Z AUTO 28008KT 250V320 9999 SCT065/// BKN080/// OVC120/// 04/M00 Q1004",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDXW",
       RawData = "EDXW 041620Z AUTO 25014KT 6000 // BKN004/// 06/05 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDWE",
       RawData = "EDWE 041620Z AUTO 22007KT 190V250 9999 FEW027 11/05 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDVK",
       RawData = "EDVK 041620Z VRB02KT CAVOK 11/M01 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDVE",
       RawData = "EDVE 041620Z AUTO 24006KT CAVOK 10/M00 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDTY",
       RawData = "EDTY 041620Z 09005KT CAVOK 11/00 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDTL",
       RawData = "EDTL 041620Z 01004KT CAVOK 12/03 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDSB",
       RawData = "EDSB 041620Z 34003KT CAVOK 13/M01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDQM",
       RawData = "EDQM 041620Z 20004KT CAVOK 09/M07 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDNY",
       RawData = "EDNY 041620Z 22004KT CAVOK 10/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDMO",
       RawData = "EDMO 041620Z AUTO 02007KT CAVOK 10/M02 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDMA",
       RawData = "EDMA 041620Z 11003KT 070V130 CAVOK 11/M02 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDLW",
       RawData = "EDLW 041620Z 32006KT CAVOK 12/M00 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDLV",
       RawData = "EDLV 041620Z VRB01KT CAVOK 12/M02 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDLP",
       RawData = "EDLP 041620Z 33003KT 290V360 CAVOK 11/M03 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDLN",
       RawData = "EDLN 041620Z VRB01KT CAVOK 12/M03 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDJA",
       RawData = "EDJA 041620Z 05006KT CAVOK 10/01 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDHL",
       RawData = "EDHL 041620Z 27008KT 240V300 9999 BKN017 08/05 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDHK",
       RawData = "EDHK 041620Z 24014KT 210V270 9999 BKN014 08/05 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDHI",
       RawData = "EDHI 041620Z 26010KT CAVOK 10/05 Q1023",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDGS",
       RawData = "EDGS 041620Z 19004KT 160V220 CAVOK 11/M11 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDFM",
       RawData = "EDFM 041620Z VRB01KT CAVOK 14/M03 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDFH",
       RawData = "EDFH 041620Z 14005KT CAVOK 11/M07 Q1024",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDW",
       RawData = "EDDW 041620Z AUTO 24006KT CAVOK 10/05 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDV",
       RawData = "EDDV 041620Z AUTO 26004KT 230V290 CAVOK 10/M01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDS",
       RawData = "EDDS 041620Z AUTO 05003KT 020V080 CAVOK 13/M03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDR",
       RawData = "EDDR 041620Z AUTO 10004KT 070V130 CAVOK 13/M04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDP",
       RawData = "EDDP 041620Z AUTO 24005KT CAVOK 11/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDN",
       RawData = "EDDN 041620Z AUTO 28003KT CAVOK 12/M01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDM",
       RawData = "EDDM 041620Z AUTO 11003KT CAVOK 12/M01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDL",
       RawData = "EDDL 041620Z AUTO 33004KT CAVOK 13/M04 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDK",
       RawData = "EDDK 041620Z AUTO 08004KT CAVOK 14/M04 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDH",
       RawData = "EDDH 041620Z AUTO 26006KT 230V300 9999 FEW023 10/05 Q1023 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDG",
       RawData = "EDDG 041620Z AUTO 24003KT 200V260 CAVOK 11/M00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDF",
       RawData = "EDDF 041620Z AUTO 27003KT 240V020 CAVOK 13/M03 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDE",
       RawData = "EDDE 041620Z AUTO 02002KT CAVOK 11/00 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDC",
       RawData = "EDDC 041620Z AUTO 27004KT 240V300 CAVOK 11/M06 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDDB",
       RawData = "EDDB 041620Z AUTO 25005KT CAVOK 10/M04 Q1024 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDBC",
       RawData = "EDBC 041620Z AUTO 31004KT CAVOK 10/M01 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDAH",
       RawData = "EDAH 041620Z AUTO 26009KT 9999 // NCD 09/04 Q1021",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EDAC",
       RawData = "EDAC 041620Z 32003KT CAVOK 10/M02 Q1025",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EBOS",
       RawData = "EBOS 041620Z 06002KT 6000 NSC 10/03 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EBLG",
       RawData = "EBLG 041620Z 04004KT CAVOK 12/01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EBCI",
       RawData = "EBCI 041620Z 06007KT CAVOK 11/01 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EBBR",
       RawData = "EBBR 041620Z 03003KT CAVOK 12/02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "EBAW",
       RawData = "EBAW 041620Z 13002KT CAVOK 13/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "BGSF",
       RawData = "BGSF 041620Z AUTO 05006KT 9999NDV BKN060/// M22/M26 Q0995",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "BGKK",
       RawData = "BGKK 041620Z AUTO 06020G32KT 030V100 9999NDV -SHRA BKN055/// 01/M09 Q0973",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "BGGH",
       RawData = "BGGH 041620Z VRB02KT 1100 R04/1600U SHSN SCT007 BKN009 BKN017 M12/M14 Q0992",
       LastChange = "2025-03-04T16:20:00Z"
    },
    new Metar {
       Station = "KY70",
       RawData = "KY70 041619Z AUTO 16007KT 10SM OVC013 05/03 A2977 RMK AO2",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "KSGR",
       RawData = "KSGR 041619Z 31006KT 10SM FEW024 SCT029 OVC042 14/10 A2965 RMK AO2 WSHFT 1540 RAE18 P0003 T01390100",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "KRVS",
       RawData = "KRVS 041619Z 11006KT 10SM SCT011 13/11 A2927 RMK AO2 T01330106",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "KIMT",
       RawData = "KIMT 041619Z AUTO 00000KT 2 1/2SM BR FEW003 OVC055 03/01 A2962 RMK AO2 T00280006",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "EQYG",
       RawData = "EQYG 041619Z AUTO 36010G17KT FEW024 BKN036 OVC048 11/ A3011 RMK AO2 T0106 PWINO $",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "CYBC",
       RawData = "CYBC 041619Z AUTO 18003KT 9SM BKN014 BKN019 M06/M08 A2988 RMK SLP122",
       LastChange = "2025-03-04T16:19:00Z"
    },
    new Metar {
       Station = "KXNA",
       RawData = "KXNA 041618Z 26015G27KT 6SM RA BR FEW012 BKN048 OVC070 12/11 A2942 RMK AO2 PK WND 24034/1554 WSHFT 1540 P0007 T01170106",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KUKI",
       RawData = "KUKI 041618Z AUTO 29003KT 10SM -RA BKN009 OVC048 09/06 A3025 RMK AO2 P0000 T00890056",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KSSF",
       RawData = "KSSF 041618Z 28018G33KT 10SM CLR 22/M06 A2967 RMK AO2 PK WND 29033/1613 T02171056",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KRWF",
       RawData = "KRWF 041618Z AUTO 34010KT 7SM OVC009 04/01 A2958 RMK AO2 T00390011",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KGUR",
       RawData = "KGUR 041618Z AUTO 35025G33KT 9SM -UP OVC022 00/M06 A2991 RMK AO2 UPB18 SLP159",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KESC",
       RawData = "KESC 041618Z AUTO 00000KT 4SM BR OVC005 04/04 A2965 RMK AO2",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KDTS",
       RawData = "KDTS 041618Z 14015G25KT 8SM OVC010 20/17 A2998 RMK AO2 T02000172",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KDEW",
       RawData = "KDEW 041618Z AUTO 07004KT 10SM OVC015 02/02 A3008 RMK AO2 T00220017",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KCEC",
       RawData = "KCEC 041618Z AUTO 17012KT 4SM -RA BR BKN007 BKN013 OVC025 09/08 A3022 RMK AO2 P0001 T00890083",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KBRL",
       RawData = "KBRL 041618Z AUTO 17010KT 9SM BKN007 BKN017 OVC080 10/09 A2953 RMK AO2 RAE16 CIG 005V012 P0000 T01000089",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "CYWA",
       RawData = "CYWA 041618Z 10002KT 1 1/4SM -SN VV012 M03/M04 A2993 RMK SN8 DENSITY ALT -1621FT SLP142",
       LastChange = "2025-03-04T16:18:00Z"
    },
    new Metar {
       Station = "KPVU",
       RawData = "KPVU 041617Z 08003KT 10SM OVC028 04/02 A3010 RMK AO2",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "KPHP",
       RawData = "KPHP 041617Z AUTO 35022G33KT 7SM -SN SCT015 BKN019 BKN060 01/M03 A2991 RMK AO2 PK WND 34033/1613 P0000 T00061028",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "KHRO",
       RawData = "KHRO 041617Z AUTO 13012KT 1 1/4SM +RA BR OVC007 12/11 A2940 RMK AO2 CIG 005V009 PRESFR P0014 T01220111",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "KCDD",
       RawData = "KCDD 041617Z AUTO 01005KT 10SM OVC013 00/M04 A2980 RMK AO2",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "K0J4",
       RawData = "K0J4 041617Z AUTO 17009G22KT 10SM BKN029 21/13 A3000 RMK AO2 T02110133",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "CYFB",
       RawData = "CYFB 041617Z CCA 32018KT 15SM DRSN BKN061 M22/M27 A2955 RMK SC7 VIS SW LWR SLP015",
       LastChange = "2025-03-04T16:17:00Z"
    },
    new Metar {
       Station = "RODN",
       RawData = "RODN 041616Z 35011KT 10SM BKN010 OVC015 20/18 A2996 RMK AO2A RAB1559E00DZB00E01RAB01E12DZB12E16 BKN V OVC SLP136 FZRANO $",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "PAOU",
       RawData = "PAOU 041616Z AUTO 07010KT 10SM UP FEW008 OVC016 M01/M02 A2960 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "LWOH",
       RawData = "LWOH 041616Z VRB01KT CAVOK 09/M00 Q1022",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KYKN",
       RawData = "KYKN 041616Z AUTO 34025G32KT 1SM -SN BR BKN006 OVC011 03/02 A2951 RMK AO2 PK WND 33032/1612 WSHFT 1602 TSE15RAE08SNB08 CIG 005V010 P0019",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KRKP",
       RawData = "KRKP 041616Z AUTO 35014G25KT 7SM FEW023 SCT038 SCT046 18/12 A2971 RMK AO2 PK WND 33036/1559 WSHFT 1555 RAB1558E14 P0000 T01830117",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KPWT",
       RawData = "KPWT 041616Z AUTO 00000KT 10SM BKN018 BKN030 05/05 A3003 RMK AO2",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KP33",
       RawData = "KP33 041616Z AUTO 00000KT 10SM CLR 08/M05 A3014 RMK AO2",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KOLM",
       RawData = "KOLM 041616Z 00000KT 10SM OVC029 06/05 A3003 RMK AO2 T00610050",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "KANJ",
       RawData = "KANJ 041616Z AUTO 10005KT 4SM UP BR OVC005 01/00 A2974 RMK AO2 RAE12UPB12 P0000 T00110000",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "K40B",
       RawData = "K40B 041616Z AUTO 22007G16KT 160V300 M02/M07 A2992 RMK AO1 SLP166 T10161072 58017 P0003",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "CYTZ",
       RawData = "CYTZ 041616Z AUTO VRB02KT 6SM -RA BR BKN060 BKN074 03/01 A2993 RMK SLP140",
       LastChange = "2025-03-04T16:16:00Z"
    },
    new Metar {
       Station = "PPIZ",
       RawData = "PPIZ 041615Z AUTO 20010KT 10SM SCT009 BKN060 OVC090 M10/M11 A2977 RMK AO2 FZRANO",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LMML",
       RawData = "LMML 041615Z 11007KT 060V130 9999 FEW020 14/10 Q1021 NOSIG",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LIRP",
       RawData = "LIRP 041615Z 28006KT CAVOK 15/03 Q1023 NOSIG",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHSN",
       RawData = "LHSN 041615Z 23002KT CAVOK 13/M00 Q1026 NOSIG RMK BLU",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHSM",
       RawData = "LHSM 041615Z AUTO VRB02KT CAVOK 13/M02 Q1026",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHPR",
       RawData = "LHPR 041615Z AUTO VRB02KT CAVOK 12/01 Q1026 NOSIG",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHPP",
       RawData = "LHPP 041615Z AUTO 15005KT 020V170 CAVOK 11/02 Q1026",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHPA",
       RawData = "LHPA 041615Z 24002KT CAVOK 12/M01 Q1026 NOSIG RMK BLU",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHNY",
       RawData = "LHNY 041615Z AUTO 20003KT 180V240 CAVOK 09/00 Q1026",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHKE",
       RawData = "LHKE 041615Z 27003KT CAVOK 12/00 Q1026 NOSIG RMK BLU",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "LHDC",
       RawData = "LHDC 041615Z AUTO VRB01KT CAVOK 11/M00 Q1026 NOSIG",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KX21",
       RawData = "KX21 041615Z AUTO 10013G20KT 10SM BKN038 BKN047 24/15 A3015 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KVMR",
       RawData = "KVMR 041615Z AUTO 36010G18KT 4SM BR OVC009 05/05 A2948 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KVKS",
       RawData = "KVKS 041615Z AUTO 15019G29KT 2 1/2SM HZ SCT024 BKN075 20/15 A2963 RMK A01 VIS 2V3",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KUWL",
       RawData = "KUWL 041615Z AUTO 20011G22KT 10SM BKN110 13/M02 A2982 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KULS",
       RawData = "KULS 041615Z AUTO 35037G49KT 5SM HZ OVC022 06/02 A2946 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KUCY",
       RawData = "KUCY 041615Z AUTO 16025G32KT 10SM CLR 15/M02 A2971 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KU69",
       RawData = "KU69 041615Z AUTO 28018KT 10SM CLR 06/M05 A2996 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KU52",
       RawData = "KU52 041615Z AUTO 00000KT 10SM CLR 02/01 A3012 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KTHA",
       RawData = "KTHA 041615Z AUTO 16017G27KT 10SM CLR 17/08 A2991 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KTFP",
       RawData = "KTFP 041615Z AUTO 01016G21KT CLR 24/05 A2970 RMK AO1 T02410049",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KT89",
       RawData = "KT89 041615Z AUTO 29022G36KT 9SM CLR 15/M14 A2996 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSVE",
       RawData = "KSVE 041615Z AUTO 00000KT 10SM FEW046 OVC055 03/01 A3019 RMK A01 P000",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSUO",
       RawData = "KSUO 041615Z AUTO 34017G25KT 1/4SM SN FZFG OVC004 M02/M02 A2978 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSRE",
       RawData = "KSRE 041615Z AUTO 22006KT 10SM BKN012 12/09 A2934 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSRB",
       RawData = "KSRB 041615Z AUTO 17014G22KT 10SM FEW038 17/07 A2997 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSPK",
       RawData = "KSPK 041615Z AUTO 25004KT 10SM OVC032 04/03 A3010 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSMS",
       RawData = "KSMS 041615Z AUTO 15009KT 9SM CLR 20/09 A3022 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSEM",
       RawData = "KSEM 041615Z AUTO 14014KT 10SM SCT031 20/12 A2996 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KSBX",
       RawData = "KSBX 041615Z AUTO 14004KT 7SM CLR M06/M06 A3016 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KS39",
       RawData = "KS39 041615Z AUTO 00000KT 10SM FEW050 BKN060 OVC085 02/00 A3006 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KS21",
       RawData = "KS21 041615Z AUTO 21006KT 9SM -SN SCT035 SCT046 00/M02 A3009 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KS12",
       RawData = "KS12 041615Z 16005KT 5SM -RA BR SCT036 07/07 A3008 RMK AO2 UPCOMING TAXIWY CLOSURES. CHECK NOTAMS",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KRZR",
       RawData = "KRZR 041615Z AUTO 18013G22KT 120V210 10SM BKN039 18/08 A3001 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KRVF",
       RawData = "KRVF 041615Z AUTO 00000KT 10SM OVC015 M01/M03 A3010 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KRNC",
       RawData = "KRNC 041615Z AUTO 17009G15KT 120V200 10SM CLR 17/07 A2994 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KRKW",
       RawData = "KRKW 041615Z AUTO 17013G19KT 140V200 10SM CLR 14/01 A3003 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KRDR",
       RawData = "KRDR 041615Z 02016KT 10SM OVC013 M02/M05 A2992 RMK AO2A CIG 012 RWY18 SLP149 $",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KPWD",
       RawData = "KPWD 041615Z AUTO 35015KT 10SM FEW013 OVC024 M04/M06 A3009 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KP52",
       RawData = "KP52 041615Z AUTO 00000KT 10SM CLR 05/M02 A3016 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KP08",
       RawData = "KP08 041615Z AUTO 20007KT 10SM CLR 13/M00 A3017 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KORB",
       RawData = "KORB 041615Z AUTO 05003KT 10SM OVC014 M01/M04 A2973 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KONZ",
       RawData = "KONZ 041615Z AUTO 17008KT 10SM -RA SCT050 BKN070 OVC090 04/M01 A2987 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KOAR",
       RawData = "KOAR 041615Z AUTO 12005KT 10SM BKN070 BKN090 09/06 A3028 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KO86",
       RawData = "KO86 041615Z AUTO 00000KT 9SM FEW023 SCT027 BKN039 06/05 A3020 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KO69",
       RawData = "KO69 041615Z AUTO 00000KT 10SM OVC060 08/08 A3028 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KO54",
       RawData = "KO54 041615Z AUTO 00000KT 3SM BR BKN023 BKN027 05/04 A3021 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KO05",
       RawData = "KO05 041615Z AUTO 00000KT 10SM BKN024 BKN028 OVC050 01/M01 A3019 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KNUQ",
       RawData = "KNUQ 041615Z AUTO 15005KT 10SM OVC065 10/06 A3027 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KMZJ",
       RawData = "KMZJ 041615Z AUTO 14005KT 10SM CLR 12/M00 A3019 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KMVH",
       RawData = "KMVH 041615Z AUTO 31012KT 10SM BKN020 OVC025 M02/M06 A3009 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KMMI",
       RawData = "KMMI 041615Z AUTO 17008G19KT 130V200 10SM CLR 17/06 A3005 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KMHR",
       RawData = "KMHR 041615Z AUTO 13006KT 10SM FEW021 FEW065 FEW080 09/08 A3026 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KMCW",
       RawData = "KMCW 041615Z AUTO 07005KT 10SM SCT007 OVC015 08/06 A2947 RMK AO2 T00830061",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KLMS",
       RawData = "KLMS 041615Z AUTO 16013G23KT 10SM 16/07 A2986 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KLAR",
       RawData = "KLAR 041615Z AUTO 34020G29KT 3SM -SN FEW007 BKN030 OVC038 M02/M06 A2986 RMK AO2 PK WND 34029/1607 P0000 T10221056",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KK70",
       RawData = "KK70 041615Z AUTO 09018G25KT 10SM FEW022 SCT028 BKN034 25/20 A3008 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KJVY",
       RawData = "KJVY 041615Z 19016G22KT 10SM CLR 17/M03 A2985 RMK AO2 RW 14/32 EDGE LIGHTS OTS",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KJVW",
       RawData = "KJVW 041615Z AUTO 14019G31KT 10SM FEW023 SCT036 18/15 A2970 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KJTC",
       RawData = "KJTC 041615Z AUTO 32015G21KT 10SM SCT032 02/M07 A3011 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KJEF",
       RawData = "KJEF 041615Z 14011KT 9SM VCTS -RA OVC055 14/07 A2947 RMK AO2 LTG DSNT SW-N RAB13 P0000 T01440072",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KI40",
       RawData = "KI40 041615Z AUTO 19008KT 10SM OVC110 14/M09 A2999 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KHVC",
       RawData = "KHVC 041615Z AUTO 15019G25KT 9SM CLR 17/M04 A2982 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KHTH",
       RawData = "KHTH 041615Z AUTO 00000KT 10SM 04/M04 A3018 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KHSD",
       RawData = "KHSD 041615Z AUTO 19010G15KT 10SM CLR 13/06 A2931 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KHRF",
       RawData = "KHRF 041615Z AUTO 22004KT 10SM FEW065 02/00 A3009 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KGRR",
       RawData = "KGRR 041615Z 20008KT 10SM SCT012 BKN035 OVC055 06/03 A2976 RMK AO2 T00610033",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KGOO",
       RawData = "KGOO 041615Z AUTO 00000KT 10SM OVC065 05/03 A3022 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KGGP",
       RawData = "KGGP 041615Z AUTO 05/01 RMK AO2 PWINO PNO",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KGCY",
       RawData = "KGCY 041615Z AUTO 19009G20KT 160V240 10SM CLR 15/M07 A3007 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KFYE",
       RawData = "KFYE 041615Z AUTO 14014G25KT 100V190 10SM CLR 16/00 A2969 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KFVE",
       RawData = "KFVE 041615Z AUTO 17006KT 10SM BKN023 BKN090 M07/M12 A2991 RMK AO2 T10671117 $",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KFOT",
       RawData = "KFOT 041615Z AUTO 11017G21KT 5SM FEW031 OVC038 07/07 A3021 RMK AO1 P0001",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KF95",
       RawData = "KF95 041615Z AUTO 16016G24KT 10SM BKN029 BKN037 BKN042 23/17 A3002 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KF45",
       RawData = "KF45 041615Z AUTO 11014G22KT 10SM SCT028 BKN034 OVC055 23/17 A3012 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KEKS",
       RawData = "KEKS 041615Z AUTO 00000KT 10SM FEW015 OVC028 M02/M05 A3011 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KE77",
       RawData = "KE77 041615Z AUTO 01009KT 10SM CLR 11/M04 A3021 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KE01",
       RawData = "KE01 041615Z AUTO 28028G44KT 1/2SM -DZ HZ BKN002 13/M07 A2975 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KDWA",
       RawData = "KDWA 041615Z AUTO 14006KT 10SM OVC065 10/09 A3026 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KDRP",
       RawData = "KDRP 041615Z AUTO 16016G29KT 10SM OVC065 15/09 A2961 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KDLN",
       RawData = "KDLN 041615Z AUTO 00000KT 10SM OVC015 M01/M04 A3006 RMK AO2 T10111039",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KCXW",
       RawData = "KCXW 041615Z AUTO 13019G25KT 1 3/4SM BR 14/14 A2940 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KCXP",
       RawData = "KCXP 041615Z AUTO 18003KT 10SM BKN060 03/M03 A3018 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KCRX",
       RawData = "KCRX 041615Z AUTO 14018G24KT 10SM OVC080 15/05 A2981 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KCEY",
       RawData = "KCEY 041615Z AUTO 15015G30KT 110V170 10SM CLR 16/M02 A2976 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KCCB",
       RawData = "KCCB 041615Z AUTO 09007KT 10SM BKN027 09/05 A3024 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KC83",
       RawData = "KC83 041615Z AUTO 00000KT 10SM BKN075 BKN085 11/07 A3026 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KC08",
       RawData = "KC08 041615Z AUTO 33020G27KT 10SM CLR M00/M09 A2974 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBWP",
       RawData = "KBWP 041615Z AUTO 35028G33KT 10SM OVC013 M00/M00 A2976 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBTN",
       RawData = "KBTN 041615Z AUTO 01019G28KT 10SM OVC012 M02/M03 A2980 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBOW",
       RawData = "KBOW 041615Z AUTO 11019KT 10SM SCT038 25/14 A3012 RMK AO2 PWINO",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBGF",
       RawData = "KBGF 041615Z AUTO 16026G34KT 10SM CLR 16/09 A2994 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBFA",
       RawData = "KBFA 041615Z AUTO VRB03KT 10SM OVC020 05/02 A2969 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KBDN",
       RawData = "KBDN 041615Z AUTO 19010KT 10SM OVC065 04/M01 A3003 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KAVQ",
       RawData = "KAVQ 041615Z AUTO VRB03KT 10SM CLR 12/M01 A3017 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "KAVK",
       RawData = "KAVK 041615Z AUTO 28012G17KT 10SM CLR 13/04 A2930 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K9S9",
       RawData = "K9S9 041615Z AUTO 13005KT 10SM CLR 05/05 A3008 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K8V7",
       RawData = "K8V7 041615Z AUTO 34040G57KT 10SM BKN025 OVC031 05/00 A2957 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K8A3",
       RawData = "K8A3 041615Z AUTO 18013G22KT 10SM CLR 16/04 A2995 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K7S0",
       RawData = "K7S0 041615Z AUTO 00000KT 4SM BR BKN004 BKN033 OVC085 02/02 A3008 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K6E5",
       RawData = "K6E5 041615Z AUTO 36025KT 3/4SM UP BR OVC007 M01/M01 A2966 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K65S",
       RawData = "K65S 041615Z AUTO VRB03KT 10SM SCT009 BKN037 OVC049 03/01 A3008 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K63S",
       RawData = "K63S 041615Z AUTO 00000KT 10SM CLR M02/M05 A3010 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K5T9",
       RawData = "K5T9 041615Z AUTO 31027G36KT 10SM CLR 22/M11 A2976 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K54A",
       RawData = "K54A 041615Z AUTO 12015KT 10SM 26/17 A3006 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K49B",
       RawData = "K49B 041615Z AUTO 31019KT 1 1/2SM UP BR SCT006 BKN012 BKN021 M01/M01 A2997 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K42A",
       RawData = "K42A 041615Z AUTO 13010G21KT 110V170 2 1/2SM VCTS RA BR BKN021 OVC032 13/12 A2948 RMK AO2 LTG DSNT E AND SW AND NW VIS 1V5",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K3W7",
       RawData = "K3W7 041615Z AUTO 06007KT 10SM BKN060 BKN085 03/M00 A3005 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K3S8",
       RawData = "K3S8 041615Z AUTO 00000KT 10SM OVC038 06/05 A3019 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K3L4",
       RawData = "K3L4 041615Z AUTO 14024KT 3SM BR BKN027 BKN034 BKN040 21/21 A2964 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K33N",
       RawData = "K33N 041615Z AUTO 22009G14KT 10SM FEW080 11/01 A3021 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K2G2",
       RawData = "K2G2 041615Z AUTO 20011G17KT 10SM CLR 13/M10 A2999 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K1U7",
       RawData = "K1U7 041615Z AUTO 34004KT 10SM OVC033 M00/M00 A3004 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K1M5",
       RawData = "K1M5 041615Z AUTO 16016G24KT 10SM CLR 17/00 A2988 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K1K8",
       RawData = "K1K8 041615Z AUTO 30004KT 2 1/2SM -RA BR BKN007 BKN043 BKN060 12/12 A2940 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K1D8",
       RawData = "K1D8 041615Z AUTO 36025G33KT 10SM OVC018 01/M03 A2979 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K0R0",
       RawData = "K0R0 041615Z AUTO 15014G27KT 120V180 10SM SCT019 21/15 A2983 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K0D8",
       RawData = "K0D8 041615Z AUTO 35017G27KT 3/4SM BR BKN009 M01/M01 A2984 RMK A01",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "K0A0",
       RawData = "K0A0 041615Z AUTO 32023G29KT 10SM CLR 10/M07 A2995 RMK AO2",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "CYYQ",
       RawData = "CYYQ 041615Z 30009KT 15SM FEW013 SCT250 M19/M22 A3002 RMK SC2CI1 SLP171",
       LastChange = "2025-03-04T16:15:00Z"
    },
    new Metar {
       Station = "SBBE",
       RawData = "SBBE 041614Z 03011KT 5000 2000S -RA FEW007 BKN015 FEW020TCU 25/24 Q1010 RERA",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "PACZ",
       RawData = "PACZ 041614Z AUTO 05010G19KT BKN003 M15/M17 A2965 RMK AO2 SLP059 PWINO FZRANO $",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "KPOE",
       RawData = "KPOE 041614Z AUTO 15019G32KT 7SM -RA OVC014 21/19 A2953 RMK AO2 RAE1555RAB1559 SLP000",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "KFRM",
       RawData = "KFRM 041614Z AUTO 04/03 A2952 RMK AO2",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "K7BM",
       RawData = "K7BM 041614Z AUTO 25016G21KT 230V290 10SM SCT021 SCT033 BKN047 M02/M09 A2979 RMK AO2",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "K20V",
       RawData = "K20V 041614Z AUTO 34006KT 10SM SCT060 SCT075 SCT090 01/M11 A2988 RMK AO2",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "CYQG",
       RawData = "CYQG 041614Z AUTO 17009KT 9SM BKN050 OVC066 04/01 A2986 RMK PRESFR SLP119",
       LastChange = "2025-03-04T16:14:00Z"
    },
    new Metar {
       Station = "PFNO",
       RawData = "PFNO 041613Z AUTO 26004KT 1 1/4SM -SN BR OVC013 M13/M14 A2983 RMK AO2 P0000 FZRANO $",
       LastChange = "2025-03-04T16:13:00Z"
    },
    new Metar {
       Station = "KIOW",
       RawData = "KIOW 041613Z AUTO 10007KT 10SM SCT026 12/06 A2951 RMK AO2 PRESFR T01170056",
       LastChange = "2025-03-04T16:13:00Z"
    },
    new Metar {
       Station = "CYAM",
       RawData = "CYAM 041613Z 08007KT 2 1/2SM -DZRA BR BKN006 OVC034 01/01 A2975 RMK FG1ST6SC2 SLP086",
       LastChange = "2025-03-04T16:13:00Z"
    },
    new Metar {
       Station = "KSLG",
       RawData = "KSLG 041612Z AUTO 27011KT 10SM RA SCT012 SCT038 OVC065 11/11 A2944 RMK AO2 P0004",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KLCH",
       RawData = "KLCH 041612Z 17025G36KT 7SM SCT024 BKN034 OVC042 21/19 A2962 RMK AO2 PK WND 16036/1612 T02110194",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KIAH",
       RawData = "KIAH 041612Z 29007KT 10SM -RA SCT023 OVC033 13/09 A2964 RMK AO2 P0004 T01330094 $",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KHWO",
       RawData = "KHWO 041612Z 09016G23KT 10SM SCT025 BKN031 OVC060 25/19 A3010 RMK AO2 RAB02E04 P0000 T02500194",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KGRI",
       RawData = "KGRI 041612Z 36020G29KT 5SM BR OVC005 07/06 A2939 RMK AO2 PK WND 36031/1559 T00670061",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KGDV",
       RawData = "KGDV 041612Z AUTO 34014KT 9SM -SN BKN013 OVC035 M02/M03 A3008 RMK AO2 P0000 FZRANO TSNO",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KDDC",
       RawData = "KDDC 041612Z AUTO 35026G38KT 4SM HZ OVC015 07/03 A2933 RMK AO2 PK WND 36044/1554 T00720028",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "KC99",
       RawData = "KC99 041612Z AUTO 31021G30KT BKN007 OVC013 M09/M09 A2976 RMK AO2",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "CYKJ",
       RawData = "CYKJ 041612Z AUTO 27005KT 9SM SCT050 M04/M05 A2992 RMK SLP168",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "CYGE",
       RawData = "CYGE 041612Z CCA 00000KT 3SM BR SCT006 BKN015 OVC030 M01/M01 A3008 RMK FG3ST1SC2SC2 VIS E 1 SM SLP221",
       LastChange = "2025-03-04T16:12:00Z"
    },
    new Metar {
       Station = "SCTE",
       RawData = "SCTE 041611Z 34004KT 300V020 9999 -RA SCT006 BKN045 14/13 Q1010 RERA NOSIG",
       LastChange = "2025-03-04T16:11:00Z"
    },
    new Metar {
       Station = "PGUM",
       RawData = "PGUM 041611Z 07010KT 10SM SCT015 SCT060 BKN110 26/24 A2990 RMK AO2 T02610244",
       LastChange = "2025-03-04T16:11:00Z"
    },
    new Metar {
       Station = "KTUL",
       RawData = "KTUL 041611Z 08010G21KT 10SM FEW005 BKN070 OVC110 12/11 A2924 RMK AO2 T01170106",
       LastChange = "2025-03-04T16:11:00Z"
    },
    new Metar {
       Station = "VCBI",
       RawData = "VCBI 041610Z 36002KT 6000 FEW080 26/25 Q1010 NOSIG",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "PFCB",
       RawData = "PFCB 041610Z AUTO 03005KT 10SM CLR 05/04 A2983 RMK AO2 T00500036",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "PAJC",
       RawData = "PAJC 041610Z AUTO 00000KT 8SM -RA BKN013 01/M01 A2961 RMK AO2 RAB06SNE06 P0000 FZRANO",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "PADG",
       RawData = "PADG 041610Z 20005KT 3 1/2SM -SN BR OVC035 M10/M12 A2972",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KXNX",
       RawData = "KXNX 041610Z AUTO 16019G27KT 10SM CLR 18/01 A2993 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KW43",
       RawData = "KW43 041610Z AUTO 35011G21KT 5SM -SN BKN009 OVC014 M02/M04 A3002 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KVES",
       RawData = "KVES 041610Z AUTO 19011G19KT 10SM BKN110 12/M04 A2983 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KTXK",
       RawData = "KTXK 041610Z 33005KT 6SM -RA BR BKN060 OVC075 14/12 A2949 RMK AO2 P0004 T01390117",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KTQV",
       RawData = "KTQV 041610Z AUTO 21008G14KT 130V230 10SM CLR 12/M01 A3024 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KTMT",
       RawData = "KTMT 041610Z AUTO 00000KT 10SM CLR M07/M09 A3019 RMK AO2 T10751090",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KSZY",
       RawData = "KSZY 041610Z AUTO 16017G23KT 10SM FEW075 15/03 A2981 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KSZT",
       RawData = "KSZT 041610Z AUTO 00000KT 10SM SCT006 SCT011 OVC035 03/02 A3010 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KSYI",
       RawData = "KSYI 041610Z AUTO 16014G22KT 10SM CLR 17/08 A2991 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KSNH",
       RawData = "KSNH 041610Z AUTO 16011G19KT 10SM FEW085 SCT120 16/04 A2982 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KSCX",
       RawData = "KSCX 041610Z AUTO 20019G27KT 10SM FEW100 15/01 A3000 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KRQO",
       RawData = "KRQO 041610Z AUTO 23012G20KT 10SM CLR 13/01 A2931 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KRBO",
       RawData = "KRBO 041610Z AUTO 33021G29KT 10SM CLR 25/00 A2972 RMK AO2 T02470003",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KPVW",
       RawData = "KPVW 041610Z AUTO 31028G36KT 7SM -RA OVC019 04/04 A2947 RMK AO2 T00430041",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KPVE",
       RawData = "KPVE 041610Z AUTO 16011G22KT 120V190 10SM CLR 16/M01 A2983 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KOWI",
       RawData = "KOWI 041610Z AUTO 15004KT 1 3/4SM -RA SCT007 BKN015 OVC041 12/12 A2939 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KOTM",
       RawData = "KOTM 041610Z AUTO 13010KT 10SM SCT026 13/07 A2945 RMK AO2 T01280067",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KOSA",
       RawData = "KOSA 041610Z AUTO 13007KT 10SM -RA 12/11 A2949 RMK AO2 T01170112",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KOFF",
       RawData = "KOFF 041610Z 02006KT 10SM OVC028 14/11 A2931 RMK AO2A SLP928 $",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KODO",
       RawData = "KODO 041610Z AUTO 29032G46KT 2SM HZ BKN019 OVC029 12/M10 A2971 RMK AO2 PK WND 28046/1609 T01171100",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KNOW",
       RawData = "KNOW 041610Z AUTO 00000KT 10SM OVC100 07/07 A3000 RMK AO2 T00660065",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KMTC",
       RawData = "KMTC 041610Z 15007KT 10SM VCSH OVC038 03/M01 A2983 RMK AO2A SLP111 $",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KMOR",
       RawData = "KMOR 041610Z AUTO 00000KT 10SM CLR 13/M07 A3007 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KMNV",
       RawData = "KMNV 041610Z AUTO 18013G26KT 160V220 10SM CLR 17/06 A3004 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KMBT",
       RawData = "KMBT 041610Z AUTO 16018G24KT 10SM CLR 18/07 A2991 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KM91",
       RawData = "KM91 041610Z AUTO 17022G31KT 10SM CLR 16/M01 A2986 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KM75",
       RawData = "KM75 041610Z AUTO 33010G15KT 10SM OVC035 M01/M05 A3015 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KM04",
       RawData = "KM04 041610Z AUTO 14021G28KT 10SM CLR 16/M00 A2967 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KM02",
       RawData = "KM02 041610Z AUTO 17015G32KT 140V210 10SM CLR 16/M01 A2986 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KLUG",
       RawData = "KLUG 041610Z AUTO 17018G29KT 10SM CLR 17/08 A2990 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KJZP",
       RawData = "KJZP 041610Z AUTO 10SM OVC021 12/05 A3011 RMK AO2 T01220046",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KJES",
       RawData = "KJES 041610Z AUTO 18009KT 10SM SCT038 SCT048 SCT060 23/13 A3019 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KJAU",
       RawData = "KJAU 041610Z AUTO 18012KT 150V210 5SM HZ FEW110 14/M04 A3008 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KHZD",
       RawData = "KHZD 041610Z AUTO 16016G22KT 10SM FEW095 16/M02 A2977 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KHVE",
       RawData = "KHVE 041610Z AUTO 29017G23KT 10SM CLR 10/M05 A3004 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KHSI",
       RawData = "KHSI 041610Z AUTO 34022G32KT 6SM BR OVC001 07/06 A2936 RMK AO2 PK WND 34032/1610 T00670061",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KGZS",
       RawData = "KGZS 041610Z AUTO 17018G26KT 10SM CLR 17/09 A2990 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KGVT",
       RawData = "KGVT 041610Z AUTO 19008KT 10SM SCT120 11/11 A2950 RMK AO2 TSNO",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KGNG",
       RawData = "KGNG 041610Z AUTO 25010KT 10SM CLR 03/02 A3012 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KGCD",
       RawData = "KGCD 041610Z AUTO 00000KT 10SM SCT120 01/00 A3007 RMK AO2 T00071002",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KFYM",
       RawData = "KFYM 041610Z AUTO 17016G26KT 10SM SCT027 16/10 A2995 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KETN",
       RawData = "KETN 041610Z AUTO 25024G32KT 220V280 10SM CLR 15/M02 A2952 RMK AO2 T01451025",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KEDU",
       RawData = "KEDU 041610Z AUTO 17006KT 10SM FEW065 09/08 A3027 RMK AO1",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KDKX",
       RawData = "KDKX 041610Z AUTO VRB04KT 10SM CLR 12/M03 A3008 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KD73",
       RawData = "KD73 041610Z AUTO 10SM SCT028 BKN037 BKN046 14/07 A3015 RMK AO2 T01370068",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KCQB",
       RawData = "KCQB 041610Z AUTO 17007KT 10SM BKN011 12/09 A2933 RMK AO2 T01190093",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KCNI",
       RawData = "KCNI 041610Z AUTO 11009G16KT 080V140 10SM OVC025 13/05 A3012 RMK AO2 T01280047",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KAZE",
       RawData = "KAZE 041610Z AUTO 15009G18KT 10SM SCT048 SCT055 22/12 A3013 RMK AO2 T02160117",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "KAZC",
       RawData = "KAZC 041610Z AUTO 13003KT 10SM CLR 04/01 A3015 RMK AO2",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "K2M2",
       RawData = "K2M2 041610Z AUTO 16014G29KT 10SM CLR 16/07 A2988 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "K2J5",
       RawData = "K2J5 041610Z AUTO 09012KT 10SM CLR 20/11 A3018 RMK AO2 T02010109",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "K00U",
       RawData = "K00U 041610Z AUTO 02005KT 2 1/2SM BR BKN009 OVC012 M02/M02 A3014 RMK A01",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "CYSN",
       RawData = "CYSN 041610Z 20012KT 15SM OVC074 06/M04 A2993 RMK AC8 SLP141",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "CYPX",
       RawData = "CYPX 041610Z AUTO 29002KT 1 3/4SM HZ SCT001 OVC033 M26/M29 A2979 RMK SLP092",
       LastChange = "2025-03-04T16:10:00Z"
    },
    new Metar {
       Station = "PASK",
       RawData = "PASK 041609Z AUTO 27005KT 9SM -SN BKN013 OVC021 M12/M14 A2984 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "PAPM",
       RawData = "PAPM 041609Z AUTO 03008KT 10SM OVC009 M03/M03 A2962 RMK AO2 CIG 006V014 FZRANO TSNO",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "KRHI",
       RawData = "KRHI 041609Z AUTO 05004KT 2SM BR BKN002 OVC012 03/02 A2958 RMK AO2 T00330022",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "KPSX",
       RawData = "KPSX 041609Z AUTO 31017G36KT 8SM -RA SCT027 16/11 A2970 RMK AO2 PK WND 31036/1601 WSHFT 1555 RAB02 PRESRR P0000 T01610106 $",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "K04V",
       RawData = "K04V 041609Z AUTO 30024G33KT 10SM BKN039 OVC046 02/M08 A2982 RMK AO2",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "CYZE",
       RawData = "CYZE 041609Z AUTO 18007KT 9SM FEW050 02/M00 A2976 RMK SLP089",
       LastChange = "2025-03-04T16:09:00Z"
    },
    new Metar {
       Station = "RJNY",
       RawData = "RJNY 041608Z 04015KT 9999 -SHRA FEW015 BKN035 08/06 Q1017 RMK 1CU015 7CU035 A3006",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "PAUN",
       RawData = "PAUN 041608Z AUTO 18006KT 5SM -SN BR BKN011 OVC021 M06/M07 A2971 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "PASM",
       RawData = "PASM 041608Z AUTO 35005KT 8SM SCT021 BKN110 M14/M16 A2970 RMK AO2 SNE03 P0000 FZRANO",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "PAMO",
       RawData = "PAMO 041608Z AUTO 35007KT 5SM -SN BR SCT002 BKN090 BKN110 M15/M17 A2968 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "MMTO",
       RawData = "MMTO 041608Z 00000KT 7SM SKC 18/06 A3041 RMK HZY",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KVTN",
       RawData = "KVTN 041608Z AUTO 34023G37KT 1 1/4SM -SN BR FEW009 BKN014 OVC022 M01/M02 A2975 RMK AO2 PK WND 34038/1557 P0000 T10111022",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KRMG",
       RawData = "KRMG 041608Z AUTO 13010G21KT 10SM BKN027 BKN034 BKN050 16/07 A3006 RMK AO2 T01610072",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KPVG",
       RawData = "KPVG 041608Z AUTO 21012G16KT 10SM FEW001 15/M02 A3029 RMK AO2",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KMLF",
       RawData = "KMLF 041608Z AUTO 20005KT 1/2SM FZFG VV001 M01/M01 A3013 RMK AO2 T10061011",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KFFC",
       RawData = "KFFC 041608Z AUTO 13010G20KT 10SM SCT025 BKN035 BKN044 16/08 A3010 RMK AO2 T01560083",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KBUR",
       RawData = "KBUR 041608Z 12006KT 10SM SCT018 OVC030 11/07 A3025 RMK AO2 T01110067",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KBPT",
       RawData = "KBPT 041608Z 18020G30KT 7SM -RA BKN009 BKN014 OVC023 21/20 A2958 RMK AO2 PK WND 18030/1555 RAE00B08 P0000 T02110200",
       LastChange = "2025-03-04T16:08:00Z"
    },
    new Metar {
       Station = "KSWO",
       RawData = "KSWO 041607Z 16009G16KT 10SM FEW008 13/10 A2931 RMK AO2 T01280100 $",
       LastChange = "2025-03-04T16:07:00Z"
    },
    new Metar {
       Station = "KMTJ",
       RawData = "KMTJ 041607Z AUTO 10004KT 10SM SCT030 BKN050 OVC060 01/M02 A2998 RMK AO2 T00111017",
       LastChange = "2025-03-04T16:07:00Z"
    },
    new Metar {
       Station = "CYJT",
       RawData = "CYJT 041607Z 28018G24KT 15SM -SHSN DRSN FEW024 SCT044 BKN051 M05/M12 A2995 RMK SC2SC2SC3 CVCTV CLD EMBD SLP145",
       LastChange = "2025-03-04T16:07:00Z"
    },
    new Metar {
       Station = "SCCI",
       RawData = "SCCI 041606Z 21006KT 180V240 2500 RA OVC007 07/06 Q0980 NOSIG",
       LastChange = "2025-03-04T16:06:00Z"
    },
    new Metar {
       Station = "KNGP",
       RawData = "KNGP 041606Z COR 32027G34KT 6SM HZ SCT025 BKN041 BKN250 23/16 A2969 RMK PK WND 32034/1605 WSHFT 1555 FROPA T02330156",
       LastChange = "2025-03-04T16:06:00Z"
    },
    new Metar {
       Station = "EGUL",
       RawData = "EGUL 041606Z 21010KT 9999 CLR 14/M02 A3019 RMK SLP227 T01371019 $",
       LastChange = "2025-03-04T16:06:00Z"
    },
    new Metar {
       Station = "PARS",
       RawData = "PARS 041605Z AUTO 26004KT 4SM -SN BR BKN015 OVC020 M08/M09 A2967 RMK AO2 FZRANO PNO $",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "PAPH",
       RawData = "PAPH 041605Z AUTO 14003KT 1/2SM FG OVC003 00/00 A2964 RMK AO2 FZRANO $",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "PAMK",
       RawData = "PAMK 041605Z AUTO 28004KT 2SM -SN BR BKN026 BKN033 OVC045 M11/M12 A2972 RMK AO2 P0000 FZRANO",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KUSE",
       RawData = "KUSE 041605Z AUTO 21005KT 9SM SCT049 05/03 A2988 RMK AO2",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KTCY",
       RawData = "KTCY 041605Z AUTO 00000KT 10SM OVC080 10/08 A3026 RMK A01",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KS34",
       RawData = "KS34 041605Z AUTO 00000KT 10SM OVC011 03/03 A3010 RMK AO2",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KRTS",
       RawData = "KRTS 041605Z AUTO 00000KT OVC055 01/M02 A3017 RMK AO2",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KMRC",
       RawData = "KMRC 041605Z AUTO 16011G21KT 120V190 10SM CLR 16/06 A2987 RMK A01",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KMEV",
       RawData = "KMEV 041605Z AUTO 00000KT 10SM SCT085 BKN110 02/M03 A3016 RMK AO2",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KIMM",
       RawData = "KIMM 041605Z AUTO 11015KT 10SM SCT034 BKN040 BKN047 25/19 A3007 RMK AO2",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KHLB",
       RawData = "KHLB 041605Z AUTO 18014G22KT 10SM CLR 15/M02 A2984 RMK A01",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KEPH",
       RawData = "KEPH 041605Z AUTO 02006KT 10SM FEW007 04/02 A3004 RMK AO2 T00440017",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "KAND",
       RawData = "KAND 041605Z AUTO 10SM BKN029 BKN055 14/03 A3020 RMK AO2 T01440033",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "K6S0",
       RawData = "K6S0 041605Z AUTO 25005KT 10SM BKN047 M03/M04 A3011 RMK A01",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "K1DN",
       RawData = "K1DN 041605Z AUTO 04010KT 9SM -SN BKN005 OVC009 M02/M04 A2996 RMK AO2 CIG 005V009 BKN V SCT SLP176 $",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "BIEG",
       RawData = "BIEG 041605Z 22015KT 9999 FEW055 02/M06 Q0975",
       LastChange = "2025-03-04T16:05:00Z"
    },
    new Metar {
       Station = "PADK",
       RawData = "PADK 041604Z AUTO VRB04KT 9SM FEW008 SCT024 BKN035 M01/M02 A2914 RMK AO2 UPB1559E01SNE1559 P0000 FZRANO",
       LastChange = "2025-03-04T16:04:00Z"
    },
    new Metar {
       Station = "KLBB",
       RawData = "KLBB 041604Z 28032G52KT 10SM -RA SCT017 BKN031 OVC055 07/M01 A2951 RMK AO2 PK WND 29052/1559 P0000 T00671006",
       LastChange = "2025-03-04T16:04:00Z"
    },
    new Metar {
       Station = "KGZH",
       RawData = "KGZH 041604Z AUTO 16016G25KT 10SM BKN020 18/12 A2998 RMK AO2 T01780122",
       LastChange = "2025-03-04T16:04:00Z"
    },
    new Metar {
       Station = "CYSC",
       RawData = "CYSC 041604Z AUTO 21007G18KT 190V260 9SM FEW250 02/M10 A2998 RMK SLP163",
       LastChange = "2025-03-04T16:04:00Z"
    },
    new Metar {
       Station = "SVVL",
       RawData = "SVVL 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVVA",
       RawData = "SVVA 041603Z AUTO 05006KT NCD 31/16 Q1013",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVSR",
       RawData = "SVSR 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVSA",
       RawData = "SVSA 041603Z AUTO 30001KT NCD 24/19 Q1014",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVPR",
       RawData = "SVPR 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVPA",
       RawData = "SVPA 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVMT",
       RawData = "SVMT 041603Z AUTO 11007KT NCD 31/22 Q1014",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVMI",
       RawData = "SVMI 041603Z AUTO 07011KT NCD 27/21 Q1014",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVMG",
       RawData = "SVMG 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVMC",
       RawData = "SVMC 041603Z AUTO 01009KT NCD 30/21 Q1012",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVLO",
       RawData = "SVLO 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVJM",
       RawData = "SVJM 041603Z AUTO 16003KT NCD 32/16 Q1012",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVGU",
       RawData = "SVGU 041603Z AUTO ///01KT NCD ///// Q1013",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVGD",
       RawData = "SVGD 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVFM",
       RawData = "SVFM 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVCS",
       RawData = "SVCS 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVCB",
       RawData = "SVCB 041603Z AUTO NIL",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVBS",
       RawData = "SVBS 041603Z AUTO 22007KT NCD 31/15 Q1015",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVBM",
       RawData = "SVBM 041603Z AUTO 07003KT NCD 28/15 Q1015",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVBI",
       RawData = "SVBI 041603Z AUTO ///01KT NCD ///// Q////",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "SVBC",
       RawData = "SVBC 041603Z AUTO 33009KT NCD 29/24 Q1014",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "KOMA",
       RawData = "KOMA 041603Z 05006KT 8SM SCT010 BKN042 OVC130 13/11 A2933 RMK AO2 T01330111",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "KGUS",
       RawData = "KGUS 041603Z AUTO 05009KT 10SM OVC060 06/03 A2978 RMK AO2 RAE03 SLP092 $",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "KFTW",
       RawData = "KFTW 041603Z 24015G18KT 10SM CLR 12/08 A2945 RMK AO2 T01220078 $",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "K9MN",
       RawData = "K9MN 041603Z AUTO 00000KT 10SM BKN011 BKN043 07/03 A2953 RMK AO1",
       LastChange = "2025-03-04T16:03:00Z"
    },
    new Metar {
       Station = "PAOM",
       RawData = "PAOM 041602Z AUTO 33005KT 10SM FEW012 OVC019 M09/M12 A2973 RMK AO2 T10941117 TSNO",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "PAHX",
       RawData = "PAHX 041602Z AUTO 13008KT 10SM -RA OVC065 01/01 A2968 RMK AO2 UPE1552RAB1552 SLP050 P0000 T00110011 FZRANO",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "KSJT",
       RawData = "KSJT 041602Z 26029G44KT 7SM BLDU CLR 14/M04 A2966 RMK AO2 PK WND 25044/1555 T01441039",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "KLXT",
       RawData = "KLXT 041602Z AUTO 17006KT 5SM RA BR SCT008 BKN045 OVC055 12/10 A2940 RMK AO2 P0001 T01220100 $",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "KBHK",
       RawData = "KBHK 041602Z AUTO 33014KT 10SM BKN010 BKN018 OVC023 M02/M03 A3004 RMK AO2 CIG 008V015 T10221033",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "KAIA",
       RawData = "KAIA 041602Z AUTO 01028G45KT 10SM SCT015 01/M02 A2978 RMK AO2 PK WND 36045/1554 T00061017",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "CYYH",
       RawData = "CYYH 041602Z 28008KT 15SM FEW008 FEW014 BKN055 M20/M24 A2969 RMK ST1SC1SC6 ST TR SLP059",
       LastChange = "2025-03-04T16:02:00Z"
    },
    new Metar {
       Station = "SBTU",
       RawData = "SBTU 041601Z AUTO 21007KT 180V240 9999 // FEW018/// SCT044/// 29/24 Q1011",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "PAFS",
       RawData = "PAFS 041601Z AUTO 00000KT 10SM SCT100 M01/M06 A2976 RMK AO2 SLP086 T10111056 FZRANO",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "KROW",
       RawData = "KROW 041601Z 1 1/2SM BLDU BKN012 OVC025 14/M06 A2969 RMK AO2 PK WND 29050/1554 SFC VIS 1 3/4 T01441056",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "KNQI",
       RawData = "KNQI 041601Z 34024G32KT 8SM FEW040 SCT250 27/03 A2971 RMK AO2 PK WND 34032/1600 WSHFT 1543 T02720028 $",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "KDMO",
       RawData = "KDMO 041601Z AUTO 10006KT 10SM -RA OVC028 11/10 A2945 RMK AO2 LTG DSNT ALQDS TSE1557 P0000 T01110100",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "KATY",
       RawData = "KATY 041601Z AUTO 36019G26KT 1/4SM SN FZFG BKN005 OVC009 M02/M03 A2970 RMK AO2 PK WND 36026/1559 P0000 T10171033",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "KAPG",
       RawData = "KAPG 041601Z 19010KT 10SM SCT070 BKN200 09/00 A3021",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "CYGW",
       RawData = "CYGW 041601Z AUTO 25007KT 3SM -SN OVC032 M14/M16 A2981 RMK SLP097",
       LastChange = "2025-03-04T16:01:00Z"
    },
    new Metar {
       Station = "ZYHB",
       RawData = "ZYHB 041600Z 04001MPS CAVOK M05/M10 Q1023 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZYCC",
       RawData = "ZYCC 041600Z VRB01MPS CAVOK M02/M13 Q1023 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZWSH",
       RawData = "ZWSH 041600Z 31003MPS 240V340 9999 FEW040 04/M15 Q1023 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZUUU",
       RawData = "ZUUU 041600Z VRB01MPS 7000 -RA FEW026 BKN040 12/10 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZUTF",
       RawData = "ZUTF 041600Z 20001MPS 8000 -RA SCT030 SCT050 12/11 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZUGY",
       RawData = "ZUGY 041600Z 04007MPS 8000 -RA FEW007 BKN013 OVC026 04/02 Q1016 BECMG TL1730 FEW007 BKN015 OVC026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZUCK",
       RawData = "ZUCK 041600Z 02003MPS 360V060 9999 OVC040 10/09 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSQD",
       RawData = "ZSQD 041600Z 34003MPS 320V020 4300 BR SCT008 OVC023 03/03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSOF",
       RawData = "ZSOF 041600Z 31002MPS 4000 BR FEW009 BKN016 OVC040 03/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSNJ",
       RawData = "ZSNJ 041600Z VRB01MPS 9999 OVC023 05/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSNB",
       RawData = "ZSNB 041600Z 32005MPS 7000 BKN016 07/05 Q1021 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSFZ",
       RawData = "ZSFZ 041600Z 05007MPS 8000 -RA BKN006 BKN017 11/10 Q1017 BECMG TL1730 BKN010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZSAM",
       RawData = "ZSAM 041600Z 06006MPS 9999 SCT010 OVC020 16/15 Q1014 BECMG TL1700 TSRA BKN010 FEW020CB BKN020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZPPP",
       RawData = "ZPPP 041600Z 20004MPS 9999 SCT046 14/03 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZMUB",
       RawData = "ZMUB 041600Z VRB02MPS CAVOK M18/M21 Q1026 NOSIG RMK QFE661.4 78",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZLXY",
       RawData = "ZLXY 041600Z 24002MPS 6000 NSC 02/M00 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZLLL",
       RawData = "ZLLL 041600Z 04003MPS CAVOK 02/M07 Q1019 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZJSY",
       RawData = "ZJSY 041600Z 10003MPS 9999 BKN023 26/22 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZJHK",
       RawData = "ZJHK 041600Z 11002MPS CAVOK 23/22 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZHHH",
       RawData = "ZHHH 041600Z 34002MPS 300V020 9999 OVC030 04/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZHEC",
       RawData = "ZHEC 041600Z 32003MPS 9999 OVC033 05/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZHCC",
       RawData = "ZHCC 041600Z 00000MPS CAVOK 02/M02 Q1025 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZGSZ",
       RawData = "ZGSZ 041600Z 36004MPS 9999 SCT010 BKN030 21/19 Q1011 BECMG AT1730 BKN010 OVC030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZGOW",
       RawData = "ZGOW 041600Z 11006MPS 9999 -SHRA SCT007 FEW026TCU BKN050 18/17 Q1012 RESHRA BECMG AT1615 SHRA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZGNN",
       RawData = "ZGNN 041600Z 07005MPS 9999 SCT017 16/11 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZGKL",
       RawData = "ZGKL 041600Z 05003MPS 020V110 9999 SCT026 OVC033 06/03 Q1018 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZGHA",
       RawData = "ZGHA 041600Z 36005MPS 5000 BR BKN015 04/02 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZBSJ",
       RawData = "ZBSJ 041600Z 17002MPS CAVOK M02/M07 Q1023 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ZBHH",
       RawData = "ZBHH 041600Z VRB01MPS 4500 BR SCT033 M01/M02 Q1020 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WSSL",
       RawData = "WSSL 041600Z 11003KT 070V130 9999 FEW016 BKN300 27/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WSAP",
       RawData = "WSAP 041600Z 05003KT 9999 FEW018 BKN300 27/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMSA",
       RawData = "WMSA 041600Z VRB02KT 9000 -RA FEW025 28/26 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKN",
       RawData = "WMKN 041600Z VRB02KT 9999 FEW022 27/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKM",
       RawData = "WMKM 041600Z 00000KT 9999 FEW028 29/26 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKL",
       RawData = "WMKL 041600Z VRB01KT 9999 FEW026 26/23 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKJ",
       RawData = "WMKJ 041600Z VRB02KT 9999 FEW020 26/23 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKI",
       RawData = "WMKI 041600Z VRB02KT 9000 FEW027 28/25 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKE",
       RawData = "WMKE 041600Z AUTO 00000KT //// // ////// 25/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKD",
       RawData = "WMKD 041600Z VRB01KT 9999 FEW025 26/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKC",
       RawData = "WMKC 041600Z 12003KT 090V150 9999 FEW020 26/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKB",
       RawData = "WMKB 041600Z 32005KT 260V010 8000 FEW025 29/24 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMKA",
       RawData = "WMKA 041600Z VRB02KT 9999 FEW030 27/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMBA",
       RawData = "WMBA 041600Z 00000KT 9000 FEW031 27/25 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WMAU",
       RawData = "WMAU 041600Z 24004KT 9000 FEW025 26/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WIDD",
       RawData = "WIDD 041600Z 06005KT 9999 SCT014 28/24 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBKW",
       RawData = "WBKW 041600Z 34003KT 300V020 9999 FEW016 26/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBKT",
       RawData = "WBKT 041600Z VRB03KT 7000 -TSRA FEW013 FEW015CB SCT033 25/25 Q1009 RETSRA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBKS",
       RawData = "WBKS 041600Z 08006KT 030V130 9999 FEW016 FEW017CB 29/26 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBKL",
       RawData = "WBKL 041600Z 00000KT 9999 -RA FEW010 SCT030 25/24 Q1009 RETSRA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBGY",
       RawData = "WBGY 041600Z AUTO 00000KT //// // ////// 25/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBGS",
       RawData = "WBGS 041600Z VRB03KT 9999 FEW005 24/23 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBGR",
       RawData = "WBGR 041600Z 06003KT 020V080 9999 SCT016 25/25 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "WBGB",
       RawData = "WBGB 041600Z VRB02KT 9999 -RA SCT016 25/25 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VTUU",
       RawData = "VTUU 041600Z VRB02KT CAVOK 29/23 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VTUK",
       RawData = "VTUK 041600Z 00000KT CAVOK 29/22 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VTSG",
       RawData = "VTSG 041600Z 02004KT 8000 FEW030 26/24 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VTCT",
       RawData = "VTCT 041600Z 26003KT CAVOK 20/16 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VRMM",
       RawData = "VRMM 041600Z 09007KT 9999 FEW018 BKN280 29/25 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VRMH",
       RawData = "VRMH 041600Z 09005KT 9999 FEW018 SCT270 29/26 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VRMG",
       RawData = "VRMG 041600Z 00000KT 9999 FEW018 27/2 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VOPB",
       RawData = "VOPB 041600Z VRB02KT 5000 BR NSC 25/23 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VOMD",
       RawData = "VOMD 041600Z 08006KT 5000 HZ SCT020 BKN100 27/20 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VOCC",
       RawData = "VOCC 041600Z VRB02KT 4000 BR FEW016 BKN090 30/26 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VOBZ",
       RawData = "VOBZ 041600Z 00000KT 6000 FEW020 27/24 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VGEG",
       RawData = "VGEG 041600Z 28004KT 4000 HZ NSC 26/22 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VEMN",
       RawData = "VEMN 041600Z VRB02KT 3000 -RA SCT020 BKN100 19/15 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VEJH",
       RawData = "VEJH 041600Z 26001KT 3000 HZ FEW100 24/15 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VEIM",
       RawData = "VEIM 041600Z 27004KT 3000 HZ FEW018 18/12 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VEGY",
       RawData = "VEGY 041600Z 27006KT 3000 HZ NSC 22/15 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VABO",
       RawData = "VABO 041600Z 34005KT 4000 FU NSC 26/08 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "VAAU",
       RawData = "VAAU 041600Z 32002KT 4000 HZ FEW100 25/12 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UWOR",
       RawData = "UWOR 041600Z 22005MPS CAVOK M11/M13 Q1019 R25/490145 NOSIG RMK QFE741/0988",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAV",
       RawData = "UTAV 041600Z 15008KT 1600 R13/P2000N BLDU VV014 07/M04 Q1026 R13/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAT",
       RawData = "UTAT 041600Z 12010KT CAVOK 05/M01 Q1022 R08/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAM",
       RawData = "UTAM 041600Z 10010KT 6000 BKN230 09/01 Q1024 R88/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAK",
       RawData = "UTAK 041600Z 32012KT 9999 SCT016 05/02 Q1024 R16R/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAE",
       RawData = "UTAE 041600Z 12010KT CAVOK 06/M05 Q1026 R16/CLRD70 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UTAA",
       RawData = "UTAA 041600Z 27004KT 230V300 9999 FEW100 10/M01 Q1022 R88/70D NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "USDD",
       RawData = "USDD 041600Z VRB01MPS 9999 -SN BKN005 M11/M13 Q1015 NOSIG RMK QBB160 QFE756/1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UOOO",
       RawData = "UOOO 041600Z 16008MPS 5000 -SN BLSN FEW048 M19/M22 Q1019 R01/450332 NOSIG RMK QFE750/1000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UMII",
       RawData = "UMII 041600Z 26009G13MPS 9999 OVC014 04/02 Q1003 TEMPO 2000 RA BKN005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ULPB",
       RawData = "ULPB 041600Z AUTO 28002MPS 230V340 9999 // ///029/// 01/M02 Q0990 RMK QFE739/0985",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UHSS",
       RawData = "UHSS 041600Z 06001MPS 9999 NSC M25/M28 Q1032 R01/810365 NOSIG RMK QFE773/1030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UHPP",
       RawData = "UHPP 041600Z 03002MPS 9999 BKN061 M06/M14 Q1003 R34L/110060 NOSIG RMK QFE748/0998",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UHMM",
       RawData = "UHMM 041600Z 07002MPS 6000 -SHSN BKN024CB M19/M22 Q1009 RMK QFE742 R28/15002MPS",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UHBB",
       RawData = "UHBB 041600Z 07001MPS 9999 FEW033 M16/M18 Q1026 R36/090055 NOSIG RMK QFE751/1002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UERP",
       RawData = "UERP 041600Z 27003MPS CAVOK M32/M35 Q1027 R36/850241 NOSIG RMK QFE726",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UCFL",
       RawData = "UCFL 041600Z 31005MPS 9999 SCT030CB M05/M15 Q1026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UBEE",
       RawData = "UBEE 041600Z 21004KT CAVOK 09/M03 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UBBY",
       RawData = "UBBY 041600Z 09012KT 9999 FEW050 06/M02 Q1026 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UBBQ",
       RawData = "UBBQ 041600Z 09006KT 9999 BKN100 04/01 Q1024 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UBBL",
       RawData = "UBBL 041600Z 16005KT 7000 SCT060 05/02 Q1027 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UASK",
       RawData = "UASK 041600Z 12006MPS 9999 BKN110 M06/M10 Q1034 NOSIG RMK QFE750/1000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "UAKD",
       RawData = "UAKD 041600Z 20003MPS CAVOK M16/M18 Q1030 NOSIG RMK QFE739/0986",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TVSA",
       RawData = "TVSA 041600Z 05007KT 9999 SCT022 29/22 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TUPJ",
       RawData = "TUPJ 041600Z 10007KT 10SM VCSH BKN017 SCT048 29/22 A2999 RMK Q1015 VIS16KM VCSH N S",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TTPP",
       RawData = "TTPP 041600Z 12011KT 9999 SCT022 31/21 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TTCP",
       RawData = "TTCP 041600Z 11010KT 9999 FEW018 30/24 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TRPG",
       RawData = "TRPG 041600Z 10019KT 050V140 9999 FEW022 27/23 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TQPF",
       RawData = "TQPF 041600Z 11013KT 9999 BKN019 28/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TNCM",
       RawData = "TNCM 041600Z 11010KT 080V140 9999 FEW016 28/23 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TNCC",
       RawData = "TNCC 041600Z 08009KT 9999 SCT022 31/24 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TNCA",
       RawData = "TNCA 041600Z 08015KT 9999 FEW025 30/21 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TLPL",
       RawData = "TLPL 041600Z 12018KT 9999 FEW028 30/21 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TLPC",
       RawData = "TLPC 041600Z 13012KT 9999 FEW030 30/20 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TKPN",
       RawData = "TKPN 041600Z 10015KT 9999 SCT022 29/23 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TKPK",
       RawData = "TKPK 041600Z 08011KT 9999 FEW022 29/22 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TGPY",
       RawData = "TGPY 041600Z 13014KT 9999 VCSH FEW019 30/24 Q1013 NOSIG RMK VCSH-S",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TDPD",
       RawData = "TDPD 041600Z 13010KT 9999 FEW022 28/22 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TBPB",
       RawData = "TBPB 041600Z 10014KT 9999 FEW022 30/21 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "TAPA",
       RawData = "TAPA 041600Z 09011KT 060V130 9999 BKN022 28/22 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SYEC",
       RawData = "SYEC 041600Z 06012KT 020V090 9999 VCSH BKN018 SCT040 30/23 Q1012 NOSIG RMK VCSH NW-NNE",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SYCJ",
       RawData = "SYCJ 041600Z 09012KT 060V130 9999 BKN020 31/23 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SVJC",
       RawData = "SVJC 041600Z 09007KT 9999 BKN015 XX/XX QXXXX",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SUMU",
       RawData = "SUMU 041600Z 12010KT 9999 FEW033 SCT200 29/26 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SULS",
       RawData = "SULS 041600Z 19008KT 9999 FEW023 SCT200 32/27 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SUAA",
       RawData = "SUAA 041600Z 11008KT 9999 FEW033 SCT200 30/23 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPYL",
       RawData = "SPYL 041600Z 17006KT CAVOK 31/20 Q1011 RMK BIRD HAZARD RWY 17/35 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPUR",
       RawData = "SPUR 041600Z 14005KT 9999 FEW020 31/21 Q1011 RMK BIRD HAZARD RWY 19/01 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPTU",
       RawData = "SPTU 041600Z /////KT 9999 -RA SCT012 BKN040 23/23 Q1011 RMK BIRD HAZARD RWY 01/19 PP008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPTN",
       RawData = "SPTN 041600Z VRB04KT 9999 SCT030 BKN120 24/15 Q1013 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPST",
       RawData = "SPST 041600Z 14003KT 9999 4000N -RA SCT015 SCT020 OVC080 26/26 Q1011 RMK PP010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPSO",
       RawData = "SPSO 041600Z 26007KT CAVOK 24/18 Q1011 RMK BIRD HAZARD RWY 22/04 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPRU",
       RawData = "SPRU 041600Z 17009KT 9000 BKN130 24/21 Q1012 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPQU",
       RawData = "SPQU 041600Z 24003KT 170V340 9999 SCT020 BKN130 18/12 Q1025 NOSIG RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPPY",
       RawData = "SPPY 041600Z 34008KT 8000 VCSH SCT010 SCT015 BKN050 14/12 Q1027 RMK SH SW PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPNC",
       RawData = "SPNC 041600Z 09010KT 9999 FEW040 BKN120 24/14 Q1021 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPMS",
       RawData = "SPMS 041600Z 32006KT 8000 SCT015 BKN070 25/24 Q1012 RMK BIRD HAZARD RWY09/27 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPME",
       RawData = "SPME 041600Z 33003KT 9999 BKN020 30/24 Q1011 RMK BIRD HAZARD RWY 32/14 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPLO",
       RawData = "SPLO 041600Z 15012KT 9999 OVC035 23/17 Q1012 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPJL",
       RawData = "SPJL 041600Z 13002KT 9999 SCT020 BKN080 12/06 Q1034 RMK BIRD HAZARD RWY 12/30 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPJJ",
       RawData = "SPJJ 041600Z 04004KT 9999 FEW030 BKN070 15/07 Q1031 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPJI",
       RawData = "SPJI 041600Z 00000KT 9999 SCT020 BKN080 27/24 Q1020 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPJE",
       RawData = "SPJE 041600Z 26002KT 9999 SCT025 OVC070 25/22 Q1016 RMK BIRD HAZARD RWY 16/34 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPJC",
       RawData = "SPJC 041600Z 19005KT 160V230 CAVOK 24/19 Q1012 NOSIG RMK BIRD HAZARD RWY 16L/16R PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPHZ",
       RawData = "SPHZ 041600Z 01007KT 9999 FEW050 SCT100 19/11 Q1026 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPHY",
       RawData = "SPHY 041600Z 05007KT 8000 BCFG BKN012 OVC060 10/08 Q1033 RMK BIRD HAZARD RWY03/21 PPTRZ",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPHO",
       RawData = "SPHO 041600Z 06004KT 8000 FEW015 BKN080 14/10 Q1028 RMK BR BIRD HAZARD RWY 02/20 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPHI",
       RawData = "SPHI 041600Z 19007KT CAVOK 28/20 Q1012 RMK BIRD HAZARD RWY 19/01 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPGM",
       RawData = "SPGM 041600Z 02005KT 9999 SCT030 BKN100 26/21 Q1014 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPEO",
       RawData = "SPEO 041600Z 19018KT CAVOK 27/21 Q1011 RMK PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SPCL",
       RawData = "SPCL 041600Z 36003KT 9999 BKN017 BKN080 30/24 Q1012 RMK BIRD HAZARD RWY 02/20 PP000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SMZO",
       RawData = "SMZO 041600Z 06010KT 9999 FEW025CB BKN030 30/27 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SMJP",
       RawData = "SMJP 041600Z 09005KT 9999 SCT008 FEW015CB BKN020 30/23 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLYA",
       RawData = "SLYA 041600Z 04007KT 9999 FEW020 34/22 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLVR",
       RawData = "SLVR 041600Z 34006KT 9000 -RA BKN023 FEW030CB 25/23 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLTR",
       RawData = "SLTR 041600Z 00000KT 8000 VCSH SCT015 BKN080 28/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLTJ",
       RawData = "SLTJ 041600Z 22006KT 9999 SCT030 BKN070 24/17 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLSV",
       RawData = "SLSV 041600Z 36005KT 9999 BKN017 29/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLSA",
       RawData = "SLSA 041600Z 10004KT 9999 SCT017 FEW023CB BKN080 BKN200 29/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLRQ",
       RawData = "SLRQ 041600Z 35003KT 9999 FEW015 SCT017CB BKN070 28/27 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLRI",
       RawData = "SLRI 041600Z 00000KT 9999 SCT015 FEW020CB BKN080 29/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLRB",
       RawData = "SLRB 041600Z 35004KT 9999 BKN020 30/23 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLPO",
       RawData = "SLPO 041600Z 06010KT 9999 -RA FEW007 SCT012 BKN070 08/06 Q1042",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLOR",
       RawData = "SLOR 041600Z 03010KT 9999 SCT017 FEW020CB BKN070 15/09 Q1033",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLLP",
       RawData = "SLLP 041600Z 14006KT 9999 FEW007 SCT015 BKN200 10/07 Q1037",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLET",
       RawData = "SLET 041600Z 03006KT 6000 VCSH FEW015 BKN023 FEW030CB 28/23 Q101",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLCO",
       RawData = "SLCO 041600Z 00000KT 9999 BKN017 BKN200 31/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLCB",
       RawData = "SLCB 041600Z 29004KT 9999 FEW010 SCT020 BKN070 17/14 Q1027",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLCA",
       RawData = "SLCA 041600Z 36004KT 9999 BKN036 FEW040CB 29/19 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SLAL",
       RawData = "SLAL 041600Z 01009KT 9999 FEW005 SCT017 BKN070 14/09 Q1031",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKVV",
       RawData = "SKVV 041600Z 32004KT 290V350 8000 SCT030 BKN080 27/24 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKVP",
       RawData = "SKVP 041600Z 08012KT 9999 NSC 30/18 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKUI",
       RawData = "SKUI 041600Z 35005KT 8000 SCT020 BKN030 27/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKUC",
       RawData = "SKUC 041600Z 09007KT 360V170 9999 FEW025 33/20 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKTM",
       RawData = "SKTM 041600Z AUTO VRB02KT 9999 BKN060/// 27/22 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKSP",
       RawData = "SKSP 041600Z 07007KT 040V140 9999 FEW020 30/24 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKSM",
       RawData = "SKSM 041600Z 29006KT 9999 SCT020 32/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKSJ",
       RawData = "SKSJ 041600Z 00000KT 9999 BKN030 31/25 Q1011 RMK HZ",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKSA",
       RawData = "SKSA 041600Z AUTO VRB02KT 9999 OVC058/// 26/23 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKRH",
       RawData = "SKRH 041600Z 11012KT 080V140 9999 FEW018 32/// Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKRG",
       RawData = "SKRG 041600Z AUTO /////KT 9999 FEW054/// 20/13 Q1025",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKQU",
       RawData = "SKQU 041600Z 00000KT 5000 BCFG BKN006 25/23 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPV",
       RawData = "SKPV 041600Z VRB06KT 9999 NSC 31/26 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPS",
       RawData = "SKPS 041600Z 02005KT 310V070 9999 SCT020 20/16 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPP",
       RawData = "SKPP 041600Z 26008KT 210V300 9999 BKN020 22/17 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPE",
       RawData = "SKPE 041600Z 31006KT 270V330 8000 VCFG BKN015 BKN070 22/20 Q1018 REDZ",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPD",
       RawData = "SKPD 041600Z 13005KT 9999 FEW030 30/26 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKPC",
       RawData = "SKPC 041600Z VRB05KT CAVOK 34/22 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKNV",
       RawData = "SKNV 041600Z VRB03KT 9999 SCT030 30/22 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKMZ",
       RawData = "SKMZ 041600Z 30009KT 270V330 7000 VCFG SCT008 BKN015 19/16 Q1026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKMU",
       RawData = "SKMU 041600Z 21003KT 140V300 9000 SCT025 30/24 Q1010 RMK HZ",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKMR",
       RawData = "SKMR 041600Z 36004KT 300V060 9999 BKN040 32/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKMD",
       RawData = "SKMD 041600Z 21003KT 160V270 9999 SCT050 24/16 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKLT",
       RawData = "SKLT 041600Z VRB03KT 9999 SCT010 32/26 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKLC",
       RawData = "SKLC 041600Z AUTO 35008KT 9999 SCT019/// BKN021/// BKN027/// 29/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKIP",
       RawData = "SKIP 041600Z AUTO VRB03KT 9999NDV // OVC071/// 16/10 Q1030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKGY",
       RawData = "SKGY 041600Z VRB03KT 9000 BKN036 BKN070 18/11 Q1027",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKGP",
       RawData = "SKGP 041600Z VRB02KT 7000 SCT015 BKN060 28/24 Q1012 RMK HZ",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKGO",
       RawData = "SKGO 041600Z VRB02KT 9999 FEW020 SCT050 26/20 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKGI",
       RawData = "SKGI 041600Z /////KT 9000 VCFG BKN046 ///// Q////",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKFL",
       RawData = "SKFL 041600Z VRB02KT 9999 NSC 31/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKEJ",
       RawData = "SKEJ 041600Z AUTO 20006KT 160V250 //// R04///// // ////// 29/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKCZ",
       RawData = "SKCZ 041600Z VRB04KT 9999 BKN033 BKN044 31/22 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKCO",
       RawData = "SKCO 041600Z 16003KT 130V220 9999 SCT025 BKN030 28/23 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKCL",
       RawData = "SKCL 041600Z 13003KT 080V250 CAVOK 25/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKCG",
       RawData = "SKCG 041600Z 05003KT 320V130 CAVOK 32/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKCC",
       RawData = "SKCC 041600Z 03004KT 320V110 8000 SCT025 BKN045 OVC070 27/18 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKBU",
       RawData = "SKBU 041600Z 00000KT 9999 SCT025 29/26 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKBS",
       RawData = "SKBS 041600Z 34007KT 300V010 9999 SCT032 29/27 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKBQ",
       RawData = "SKBQ 041600Z 07004KT 360V140 CAVOK 32/23 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKBO",
       RawData = "SKBO 041600Z 27004KT 190V330 7000 3000SE HZ FEW010 BKN050 17/13 Q1027 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKAS",
       RawData = "SKAS 041600Z VRB02KT 9999 FEW015 30/25 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SKAR",
       RawData = "SKAR 041600Z 34003KT 250V050 9999 BKN012 SCT020 23/20 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SGES",
       RawData = "SGES 041600Z 09006KT CAVOK 35/21 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SGEN",
       RawData = "SGEN 041600Z 07012KT CAVOK 34/20 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SGAS",
       RawData = "SGAS 041600Z 32008KT 260V030 CAVOK 37/20 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SETN",
       RawData = "SETN 041600Z 23003KT 200V290 9999 FEW016 BKN100 30/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SEST",
       RawData = "SEST 041600Z 34005KT 9999 FEW016 BKN080 30/24 Q1010 RMK A2985",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SESM",
       RawData = "SESM 041600Z 06003KT 9999 SCT026 SCT050 OVC100 24/19 Q1017 RMK A3006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SESA",
       RawData = "SESA 041600Z 15004KT 9999 FEW008 SCT200 30/26 Q1011 RMK A2988",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SERO",
       RawData = "SERO 041600Z /////KT 9999 FEW010 BKN100 30/24 Q1011 RMK A2987",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SEQM",
       RawData = "SEQM 041600Z 30004KT 270V340 9999 SCT020 BKN090 17/14 Q1026 NOSIG RMK A3032",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SENL",
       RawData = "SENL 041600Z 02001KT 9999 FEW020 BKN100 29/23 Q1013 RMK A2992",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SEMC",
       RawData = "SEMC 041600Z 04003KT 9999 FEW023 BKN120 24/18 Q1017 RMK A3005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SELT",
       RawData = "SELT 041600Z 20004KT 9999 FEW023 SCT040 BKN100 15/10 Q1031",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SEGU",
       RawData = "SEGU 041600Z 06003KT 9999 -RA SCT009 BKN020 OVC100 25/24 Q1011 NOSIG RMK A2986",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SEGS",
       RawData = "SEGS 041600Z 26004KT 9999 FEW020 BKN100 28/23 Q1013 RMK A2992",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SECU",
       RawData = "SECU 041600Z 07002KT 9999 SCT030 BKN090 17/12 Q1027",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SECO",
       RawData = "SECO 041600Z 15003KT 9999 BKN026 BKN100 29/24 Q1013 RMK A2992",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SECA",
       RawData = "SECA 041600Z 21002KT 9999 SCT040 OVC100 23/19 Q1019 RMK A3011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCVM",
       RawData = "SCVM 041600Z 33011KT CAVOK 21/12 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCVD",
       RawData = "SCVD 041600Z 35010KT 6000 -SHRA OVC022 18/15 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCTN",
       RawData = "SCTN 041600Z 33008KT 290V020 8000 SCT030 BKN040 16/13 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCTB",
       RawData = "SCTB 041600Z VRB04KT CAVOK 26/10 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCSN",
       RawData = "SCSN 041600Z 25008KT CAVOK 19/13 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCSE",
       RawData = "SCSE 041600Z 27012KT CAVOK 20/14 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCRM",
       RawData = "SCRM 041600Z 12017KT 9999 BKN030 02/00 Q0983 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCRG",
       RawData = "SCRG 041600Z 19009KT CAVOK 24/11 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCRD",
       RawData = "SCRD 041600Z 34006KT 290V010 CAVOK 21/13 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCQP",
       RawData = "SCQP 041600Z 32008KT 280V350 9999 FEW036 BKN063 21/13 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCPQ",
       RawData = "SCPQ 041600Z 27016KT 240V300 9999 SCT035 17/10 Q1007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCPD",
       RawData = "SCPD 041600Z 16008KT 120V220 CAVOK 26/11 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCNT",
       RawData = "SCNT 041600Z 16006KT 080V210 9999 FEW030 BKN050 09/04 Q0978",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCJO",
       RawData = "SCJO 041600Z 02013KT 350V050 2000 RA SCT015 OVC025 16/15 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCIR",
       RawData = "SCIR 041600Z 32006KT 9999 FEW030 22/17 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCIP",
       RawData = "SCIP 041600Z 12006KT 080V140 9999 SCT020 BKN086 25/21 Q1021 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCIE",
       RawData = "SCIE 041600Z 26007KT 230V310 CAVOK 22/13 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCIC",
       RawData = "SCIC 041600Z 16008KT 110V210 CAVOK 23/11 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCGZ",
       RawData = "SCGZ 041600Z 07012KT CAVOK 10/03 Q0983",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCGE",
       RawData = "SCGE 041600Z 24008KT 9999 FEW020 24/09 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCFT",
       RawData = "SCFT 041600Z 28014KT 8000 VCSH SCT020 BKN030 13/11 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCFM",
       RawData = "SCFM 041600Z 08020KT 8000 -RA BKN020 OVC030 07/05 Q0979",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCFA",
       RawData = "SCFA 041600Z 19010KT 9999 FEW030 SCT260 20/13 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCEL",
       RawData = "SCEL 041600Z 18007KT 130V220 CAVOK 26/10 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCDA",
       RawData = "SCDA 041600Z 23009KT 9999 BKN038 23/15 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCCH",
       RawData = "SCCH 041600Z 24008KT CAVOK 24/08 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCCF",
       RawData = "SCCF 041600Z 27016KT CAVOK 22/04 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCBA",
       RawData = "SCBA 041600Z 29028KT 8000 -RA FEW010 OVC035 09/05 Q0996",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCAT",
       RawData = "SCAT 041600Z 33009KT 290V010 9999 FEW025 21/14 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SCAR",
       RawData = "SCAR 041600Z 24009KT 9999 BKN045 24/16 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBYS",
       RawData = "SBYS 041600Z 05009KT 010V100 9999 SCT046 31/17 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBVT",
       RawData = "SBVT 041600Z 18007KT 9000 VCSH SCT020 BKN050 28/23 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBVH",
       RawData = "SBVH 041600Z 08009KT 9999 SCT015 OVC075 25/21 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBUY",
       RawData = "SBUY 041600Z 12006KT 9999 FEW020 SCT100 29/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBUR",
       RawData = "SBUR 041600Z 06011KT 9999 BKN045 29/17 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBUL",
       RawData = "SBUL 041600Z 10011KT 050V120 9999 BKN040 29/17 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBUF",
       RawData = "SBUF 041600Z AUTO 12012KT CAVOK 32/19 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBUA",
       RawData = "SBUA 041600Z 13006KT 100V170 9999 SCT012 BKN040 28/26 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBTT",
       RawData = "SBTT 041600Z 28006KT 9999 FEW020 30/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBTF",
       RawData = "SBTF 041600Z 09005KT 9999 SCT010 BKN070 25/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBTE",
       RawData = "SBTE 041600Z 13007KT 9999 SCT015 BKN080 30/25 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBTA",
       RawData = "SBTA 041600Z 07010G20KT 040V130 9999 SCT040 30/18 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSV",
       RawData = "SBSV 041600Z 11010KT 080V140 9999 VCSH SCT022 FEW025TCU 31/22 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBST",
       RawData = "SBST 041600Z 17007KT 110V210 9999 SCT025 30/21 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSR",
       RawData = "SBSR 041600Z VRB08KT 9999 FEW035 33/14 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSP",
       RawData = "SBSP 041600Z 11008KT 020V180 CAVOK 31/13 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSN",
       RawData = "SBSN 041600Z 17008KT 9999 SCT015 OVC100 24/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSM",
       RawData = "SBSM 041600Z 05007KT CAVOK 35/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSL",
       RawData = "SBSL 041600Z 08008KT 5000 -SHRA BR FEW012 BKN015 FEW023TCU 25/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSJ",
       RawData = "SBSJ 041600Z 07009KT 360V130 9999 SCT033 FEW046TCU 30/18 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSG",
       RawData = "SBSG 041600Z 13010KT 090V170 9999 BKN030 31/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBSC",
       RawData = "SBSC 041600Z 15008KT 9999 SCT030 BKN070 31/20 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBRP",
       RawData = "SBRP 041600Z 08009KT 9999 BKN045 32/14 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBRJ",
       RawData = "SBRJ 041600Z 16012KT 9999 SCT030 29/21 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBRF",
       RawData = "SBRF 041600Z 14011KT 110V180 9999 SCT023 30/22 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBRB",
       RawData = "SBRB 041600Z 09004KT 9999 BKN018 28/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPV",
       RawData = "SBPV 041600Z 10002KT 9999 BKN025 29/22 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPS",
       RawData = "SBPS 041600Z VRB03KT 8000 VCSH SCT025 FEW025TCU BKN040 26/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPP",
       RawData = "SBPP 041600Z 06007KT 9999 FEW020 32/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPL",
       RawData = "SBPL 041600Z 16014KT 9999 BKN030 32/17 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPK",
       RawData = "SBPK 041600Z 06008KT CAVOK 32/26 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPJ",
       RawData = "SBPJ 041600Z 33007KT 9999 SCT025 FEW030TCU 29/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPG",
       RawData = "SBPG 041600Z 06011KT 9999 SCT035 27/19 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPB",
       RawData = "SBPB 041600Z 11016KT 9999 SCT020 BKN100 31/25 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBPA",
       RawData = "SBPA 041600Z 33009KT CAVOK 33/20 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBOI",
       RawData = "SBOI 041600Z AUTO 12005KT 080V160 9999 -RA FEW023 SCT044 29/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBNT",
       RawData = "SBNT 041600Z 12015KT 9999 SCT033 31/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBNF",
       RawData = "SBNF 041600Z 08011KT 9999 SCT025 28/24 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMT",
       RawData = "SBMT 041600Z 07008KT 010V130 CAVOK 29/15 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMS",
       RawData = "SBMS 041600Z 17006KT 9999 BKN030 33/23 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMO",
       RawData = "SBMO 041600Z 09014KT 9999 VCSH BKN025 BKN070 29/21 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMN",
       RawData = "SBMN 041600Z 30007KT 9999 VCSH BKN020 FEW025TCU BKN080 27/23 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMK",
       RawData = "SBMK 041600Z 10013KT 9999 SCT040 29/16 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMG",
       RawData = "SBMG 041600Z 05008KT 360V100 CAVOK 33/18 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBME",
       RawData = "SBME 041600Z 14005KT 9999 SCT020 31/23 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBMA",
       RawData = "SBMA 041600Z 35005KT 9999 VCSH FEW015 SCT018 FEW020TCU BKN100 30/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBLS",
       RawData = "SBLS 041600Z 11008KT 040V130 9999 BKN035 28/17 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBLO",
       RawData = "SBLO 041600Z 09009KT 9999 FEW026 34/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBLE",
       RawData = "SBLE 041600Z AUTO 16005KT 110V210 9999 -RA BKN030 26/21 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBLB",
       RawData = "SBLB 041600Z AUTO 09016KT 9999 NCD 28/22 Q1017 W29/S4",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBKP",
       RawData = "SBKP 041600Z VRB02KT 9999 SCT040 31/17 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBKG",
       RawData = "SBKG 041600Z 09012KT 9999 BKN027 29/19 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBJV",
       RawData = "SBJV 041600Z 07009KT 9999 SCT030 31/22 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBJU",
       RawData = "SBJU 041600Z 12008KT 9999 SCT022 30/20 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBJR",
       RawData = "SBJR 041600Z 14012KT 9999 SCT025 34/21 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBJP",
       RawData = "SBJP 041600Z 10011KT 060V130 9999 SCT033 31/22 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBJE",
       RawData = "SBJE 041600Z 08009KT 9999 BKN016 26/26 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBIZ",
       RawData = "SBIZ 041600Z 13004KT 9999 BKN020 FEW023TCU 30/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBIP",
       RawData = "SBIP 041600Z AUTO 26005KT 210V310 9999 FEW020 28/19 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBIL",
       RawData = "SBIL 041600Z 12007KT 9999 SCT027 29/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBIH",
       RawData = "SBIH 041600Z 04002KT 9999 SCT016 30/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBHT",
       RawData = "SBHT 041600Z 02005KT 9999 BKN013 OVC080 25/23 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBGW",
       RawData = "SBGW 041600Z 07007KT 010V120 9999 SCT035 30/16 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBGR",
       RawData = "SBGR 041600Z 09010KT CAVOK 30/15 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBGO",
       RawData = "SBGO 041600Z 09010KT 9999 SCT040 30/18 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBGL",
       RawData = "SBGL 041600Z 04010KT 9999 SCT040 SCT080 34/17 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBFZ",
       RawData = "SBFZ 041600Z VRB02KT 9999 FEW015 SCT020 27/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBFS",
       RawData = "SBFS 041600Z 09010KT 050V120 9999 FEW025 30/22 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBFL",
       RawData = "SBFL 041600Z 36015KT 330V030 9999 FEW025 FEW030TCU 31/22 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBFI",
       RawData = "SBFI 041600Z 03006KT CAVOK 35/19 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBES",
       RawData = "SBES 041600Z 07015KT 9999 FEW025 32/21 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBEG",
       RawData = "SBEG 041600Z 18007KT 9999 VCSH SCT020 FEW025TCU 27/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBDN",
       RawData = "SBDN 041600Z VRB08KT CAVOK 35/19 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCZ",
       RawData = "SBCZ 041600Z 03003KT 9999 SCT020 BKN100 28/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCY",
       RawData = "SBCY 041600Z 25003KT CAVOK 29/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCX",
       RawData = "SBCX 041600Z 06006KT CAVOK 30/18 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCT",
       RawData = "SBCT 041600Z 08009KT 040V130 9999 BKN030 25/18 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCR",
       RawData = "SBCR 041600Z 11012KT 9999 SHRA TS SCT046 FEW050CB 31/22 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCP",
       RawData = "SBCP 041600Z 09014KT 9999 BKN025 31/22 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCO",
       RawData = "SBCO 041600Z 33005KT CAVOK 33/20 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCJ",
       RawData = "SBCJ 041600Z 03005KT 9999 SCT023 BKN080 24/21 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCH",
       RawData = "SBCH 041600Z 02010KT CAVOK 32/15 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCG",
       RawData = "SBCG 041600Z 07011KT 040V110 9999 BKN045 FEW050TCU 32/19 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCF",
       RawData = "SBCF 041600Z 09010KT 030V130 9999 BKN035 27/16 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCC",
       RawData = "SBCC 041600Z 33006KT 290V010 9999 VCSH SCT030 FEW035TCU BKN100 30/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCB",
       RawData = "SBCB 041600Z 10015KT 9999 SCT025 30/22 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBCA",
       RawData = "SBCA 041600Z 03014KT CAVOK 31/17 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBW",
       RawData = "SBBW 041600Z 10006KT 9999 FEW020 BKN090 33/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBV",
       RawData = "SBBV 041600Z 09013KT 9999 BKN040 FEW045TCU SCT090 31/20 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBU",
       RawData = "SBBU 041600Z 05006KT CAVOK 33/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBR",
       RawData = "SBBR 041600Z 10012KT 9999 FEW045 28/16 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBQ",
       RawData = "SBBQ 041600Z 09009KT 9999 BKN025 24/18 Q1024",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBI",
       RawData = "SBBI 041600Z 03011KT 9999 SCT030 27/19 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBH",
       RawData = "SBBH 041600Z 08006KT 9999 SCT035 SCT040 BKN100 27/18 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBBG",
       RawData = "SBBG 041600Z AUTO 08006KT 040V120 9999 FEW002 36/21 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBAX",
       RawData = "SBAX 041600Z AUTO 08009KT 050V120 9999 SCT037 BKN049 26/16 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBAT",
       RawData = "SBAT 041600Z 09003KT 9999 SCT030 33/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBAR",
       RawData = "SBAR 041600Z 13012KT 9999 SCT026 SCT090 30/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBAN",
       RawData = "SBAN 041600Z 10012KT 9999 FEW025 28/15 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SBAF",
       RawData = "SBAF 041600Z 07008KT 9999 FEW025 SCT055 32/17 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAZS",
       RawData = "SAZS 041600Z 30019KT 9999 SCT027 BKN037 16/08 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAZN",
       RawData = "SAZN 041600Z 23008KT CAVOK 27/10 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAWH",
       RawData = "SAWH 041600Z 11004KT 080V140 CAVOK 09/00 Q0982",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAWE",
       RawData = "SAWE 041600Z 10010KT 6000 -RA SCT045 09/06 Q0983",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAWC",
       RawData = "SAWC 041600Z 29008KT 250V330 9999 FEW015 15/00 Q0979",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAVT",
       RawData = "SAVT 041600Z 31024G34KT CAVOK 31/04 Q1000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAVC",
       RawData = "SAVC 041600Z 30022G33KT 260V320 CAVOK 25/05 Q0994",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SASJ",
       RawData = "SASJ 041600Z 07009KT 040V110 9999 FEW030 FEW050TCU 30/20 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SASA",
       RawData = "SASA 041600Z VRB02KT 9999 BKN036 27/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARP",
       RawData = "SARP 041600Z VRB05KT CAVOK 37/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARL",
       RawData = "SARL 041600Z 05005KT CAVOK 38/26 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARI",
       RawData = "SARI 041600Z VRB06KT CAVOK 33/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARF",
       RawData = "SARF 041600Z 07009KT 9999 SCT025 40/19 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARE",
       RawData = "SARE 041600Z 36009KT 290V070 9999 FEW060TCU 40/16 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SARC",
       RawData = "SARC 041600Z 05009KT 360V090 5000 FU SCT025 39/18 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SANT",
       RawData = "SANT 041600Z 04005KT 310V100 9999 FEW040 FEW045TCU 35/21 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAME",
       RawData = "SAME 041600Z 05004KT 9999 SCT040 27/18 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAEZ",
       RawData = "SAEZ 041600Z 18010G20KT 9999 BKN016 BKN060 22/20 Q1015 TEMPO VRB10KT 3000 -TSRA FEW050CB",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SADF",
       RawData = "SADF 041600Z 20010KT 9999 -RA SCT019 BKN042 27/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SACO",
       RawData = "SACO 041600Z 08007KT 050V110 9999 SCT040 29/20 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SABE",
       RawData = "SABE 041600Z 14009KT 120V190 9999 FEW012 SCT017 BKN035 26/23 Q1014 TEMPO 3000 -TSRA FEW050CB",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "SAAR",
       RawData = "SAAR 041600Z 25005KT 210V290 9999 SCT029 31/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RPVM",
       RawData = "RPVM 041600Z 11008KT 9999 FEW020 BKN100 28/24 Q1011 NOSIG RMK A2985",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RPMD",
       RawData = "RPMD 041600Z 33003KT 8000 -RA FEW016 OVC080 25/25 Q1010 RMK A2983",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RPLL",
       RawData = "RPLL 041600Z 13003KT 090V180 9999 FEW025 SCT100 28/23 Q1010 NOSIG RMK A2983",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RPLC",
       RawData = "RPLC 041600Z 32002KT 9999 SCT020 BKN100 26/22 Q1012 NOSIG RMK A2988",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RPLB",
       RawData = "RPLB 041600Z 07005KT 9999 FEW020 27/22 Q1011 NOSIG RMK A2985",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ROYN",
       RawData = "ROYN 041600Z AUTO 09019KT 9999 FEW006 SCT130 21/20 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RORY",
       RawData = "RORY 041600Z AUTO 33011KT 9999 BKN013 OVC170 20/18 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RORT",
       RawData = "RORT 041600Z AUTO 02012KT 4600 RA BR BKN006 BKN017 BKN050 19/19 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RORS",
       RawData = "RORS 041600Z AUTO 33016KT 290V350 9999 -RA FEW004 SCT010 BKN015 21/20 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RORK",
       RawData = "RORK 041600Z AUTO 22003KT 180V260 9999 BKN005 22/21 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ROMY",
       RawData = "ROMY 041600Z AUTO 04006KT 8000 -RA FEW003 BKN010 OVC100 21/21 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ROMD",
       RawData = "ROMD 041600Z AUTO 19005KT 150V220 9999 BKN003 OVC230 21/21 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ROIG",
       RawData = "ROIG 041600Z AUTO 02022KT 0700 R04/1200VP2000D +RA FG FEW003 SCT009 BKN012 //////TCU 20/19 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKTU",
       RawData = "RKTU 041600Z 11001KT 9999 FEW040 BKN070 01/00 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKTN",
       RawData = "RKTN 041600Z 02003KT 9999 BKN030 BKN180 03/01 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKSS",
       RawData = "RKSS 041600Z 36005KT CAVOK 02/M02 Q1022 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKSM",
       RawData = "RKSM 041600Z 05005KT 9999 BKN070 03/M03 A3018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKPK",
       RawData = "RKPK 041600Z 02010KT 9999 BKN030 BKN200 04/00 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKPC",
       RawData = "RKPC 041600Z 09012KT 9999 FEW010 BKN030 OVC080 07/05 Q1017 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKNY",
       RawData = "RKNY 041600Z AUTO 06011KT 010V110 9999 RA ///011/// 02/00 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RKJB",
       RawData = "RKJB 041600Z AUTO 07002KT 9999 NCD 05/03 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJSN",
       RawData = "RJSN 041600Z AUTO 15010KT 9999 -RASN BKN046 BKN050 OVC060 04/00 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJSM",
       RawData = "RJSM 041600Z 14008KT 110V170 9999 FEW015 SCT025 BKN130 02/M05 Q1027",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJSF",
       RawData = "RJSF 041600Z AUTO 34006KT 1500 R01/P2000N BR FEW001 OVC012 M01/M02 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOS",
       RawData = "RJOS 041600Z 32007KT 9999 FEW003 BKN006 BKN015 08/07 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOO",
       RawData = "RJOO 041600Z AUTO 07010KT 040V100 9999 FEW037 BKN038 OVC040 08/06 Q1013 RMK A2994",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOK",
       RawData = "RJOK 041600Z AUTO 34005KT 9999 SCT019 OVC022 13/13 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOH",
       RawData = "RJOH 041600Z VRB02KT 9999 FEW003 SCT005 BKN008 07/07 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOC",
       RawData = "RJOC 041600Z AUTO 15007KT 9999 OVC010 06/05 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJOA",
       RawData = "RJOA 041600Z AUTO 07004KT 6000 OVC002 06/06 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJNK",
       RawData = "RJNK 041600Z VRB01KT 9999 -RA FEW003 OVC030 03/03 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJKI",
       RawData = "RJKI 041600Z AUTO 31010KT 9999 SCT011 OVC018 19/17 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJKB",
       RawData = "RJKB 041600Z AUTO 33010KT 9999 BKN012 BKN017 BKN070 19/17 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJKA",
       RawData = "RJKA 041600Z AUTO 31010KT 270V330 9999 NSC 19/17 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJFR",
       RawData = "RJFR 041600Z AUTO 29006KT 9999 BKN018 OVC060 08/07 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJFM",
       RawData = "RJFM 041600Z AUTO 04007KT 2200 -RA BR OVC004 14/14 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJEC",
       RawData = "RJEC 041600Z AUTO 18002KT 9999 NSC M12/M15 Q1028",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJDC",
       RawData = "RJDC 041600Z AUTO VRB02KT 9999 NSC 08/07 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJDB",
       RawData = "RJDB 041600Z AUTO 02015KT 9999 FEW010 SCT019 BKN026 09/07 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJCK",
       RawData = "RJCK 041600Z AUTO 02005KT 9999 NSC M07/M11 Q1030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJCH",
       RawData = "RJCH 041600Z AUTO 08008KT 040V110 9999 BKN035 M01/M07 Q1028",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RJAH",
       RawData = "RJAH 041600Z 35012KT 4000 -RA BR SCT003 SCT008 BKN012 01/00 Q1022",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RCSS",
       RawData = "RCSS 041600Z 09015KT 9999 FEW008 SCT020 BKN037 18/17 Q1015 NOSIG RMK A2998",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RCNN",
       RawData = "RCNN 041600Z 34005KT 9999 FEW012 BKN050 23/19 Q1012 RMK A2990",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "RCKH",
       RawData = "RCKH 041600Z VRB02KT 9999 FEW012 SCT040 BKN090 24/19 Q1011 NOSIG RMK A2986",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "PLCH",
       RawData = "PLCH 041600Z 05011KT 9999 FEW019 27/23 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "PALU",
       RawData = "PALU 041600Z AUTO 31007G19KT 4SM -SN SCT036 OVC060 M13/M15 A2983 RMK AO2 SLP101",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OYSY",
       RawData = "OYSY 041600Z AUTO 18009KT 140V220 //// ////// /// /// /// 27/06 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OYAA",
       RawData = "OYAA 041600Z 08013KT 7000 FEW020 27/21 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OTHH",
       RawData = "OTHH 041600Z 09007KT 9999 FEW040 20/15 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ORSU",
       RawData = "ORSU 041600Z 30004KT CAVOK 08/M03 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ORNI",
       RawData = "ORNI 041600Z 13011KT 6000 NSC 18/M04 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ORMM",
       RawData = "ORMM 041600Z 18004KT 6000 RA SCT030 BKN035 OVC100 12/09 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ORER",
       RawData = "ORER 041600Z VRB02KT 9000 NSC 12/M06 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "ORBI",
       RawData = "ORBI 041600Z 11007KT 9999 BKN030 19/M03 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OPST",
       RawData = "OPST 041600Z 27004KT 4000 HZ NSC 15/03 Q1017 NOSIG RH44",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OMRK",
       RawData = "OMRK 041600Z 11019KT CAVOK 23/12 Q1017 A3005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OMFJ",
       RawData = "OMFJ 041600Z 02006KT 9999 FEW040 23/14 Q1019 A3009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OMAL",
       RawData = "OMAL 041600Z 10008KT CAVOK 25/06 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OMAD",
       RawData = "OMAD 041600Z 36005KT CAVOK 22/16 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OMAA",
       RawData = "OMAA 041600Z 34007KT 270V050 CAVOK 24/12 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OLBA",
       RawData = "OLBA 041600Z 33005KT 300V360 6000 NSC 18/10 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OKKK",
       RawData = "OKKK 041600Z 04005KT 9999 FEW040 BKN080 15/10 Q1018 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OJAQ",
       RawData = "OJAQ 041600Z 34013KT 8000 NSC 22/03 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OJAM",
       RawData = "OJAM 041600Z 29008KT 5000 HZ NSC 15/M01 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OJAI",
       RawData = "OJAI 041600Z 31010KT 4000 HZ NSC 15/M00 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIZJ",
       RawData = "OIZJ 041600Z 15012KT 6000 NSC 23/13 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIZI",
       RawData = "OIZI 041600Z 25004KT CAVOK 20/M14 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIZH",
       RawData = "OIZH 041600Z 01006KT CAVOK 10/M13 Q1025 A3029 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIZB",
       RawData = "OIZB 041600Z 10006KT CAVOK 11/M13 Q1025",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OITP",
       RawData = "OITP 041600Z 15010KT CAVOK 08/01 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OITM",
       RawData = "OITM 041600Z 02004KT 9999 FEW040 SCT190 07/M05 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OITL",
       RawData = "OITL 041600Z 13004KT 9999 FEW050 SCT190 M02/M05 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OISY",
       RawData = "OISY 041600Z 17012KT 9999 SCT040 OVC080 09/M09 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OISL",
       RawData = "OISL 041600Z 00000KT 9999 SCT040 BKN100 18/M02 Q1019 A3011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OISF",
       RawData = "OISF 041600Z 35008KT 8000 FEW030CB SCT035 OVC100 10/04 Q1024 A3025 RERA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OINZ",
       RawData = "OINZ 041600Z 27004KT 9999 BKN050 10/08 Q1026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OINR",
       RawData = "OINR 041600Z 22002KT CAVOK 08/05 Q1025",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OINN",
       RawData = "OINN 041600Z 34002KT 9999 BKN026 OVC090 08/04 Q1026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OING",
       RawData = "OING 041600Z 25004KT 9999 SCT030 SCT190 09/06 Q1028",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OINE",
       RawData = "OINE 041600Z 17008KT 9999 BKN090 09/01 Q1026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIMN",
       RawData = "OIMN 041600Z 04006KT CAVOK 03/M11 Q1023",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIMB",
       RawData = "OIMB 041600Z 00000KT CAVOK 08/M16 Q1023 A3021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIKQ",
       RawData = "OIKQ 041600Z 09010KT 6000 NSC 23/13 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIKK",
       RawData = "OIKK 041600Z 12006KT CAVOK 13/M15 Q1021 A3017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIIP",
       RawData = "OIIP 041600Z 00000KT 8000 NSC 08/M12 Q1020 A3014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIIK",
       RawData = "OIIK 041600Z 10004KT CAVOK 07/M11 Q1021 A3016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIIE",
       RawData = "OIIE 041600Z 11006KT 9999 FEW100 BKN200 09/M12 Q1022",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIHH",
       RawData = "OIHH 041600Z 19002KT CAVOK 04/M07 Q1020 A3013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIFS",
       RawData = "OIFS 041600Z 25008KT CAVOK 07/M26 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OICS",
       RawData = "OICS 041600Z VRB02KT CAVOK 08/M13 Q1018 A3009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OICK",
       RawData = "OICK 041600Z 20002KT 9999 FEW040CB SCT045 OVC100 11/M14 Q1019 A3011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OICI",
       RawData = "OICI 041600Z 18008KT 9999 FEW045 OVC110 11/M17 Q1020 A3014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIBQ",
       RawData = "OIBQ 041600Z 06008KT 9999 FEW030CB SCT035 OVC080 17/13 Q1017 A3006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIBP",
       RawData = "OIBP 041600Z 00000KT 9999 FEW030CB SCT035 OVC090 19/10 Q1016 A3000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIBL",
       RawData = "OIBL 041600Z 09014KT CAVOK 23/09 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIBK",
       RawData = "OIBK 041600Z 09012KT 9999 FEW030 23/08 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIAM",
       RawData = "OIAM 041600Z 21010KT 7000 FEW003CB BKN040 15/11 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIAH",
       RawData = "OIAH 041600Z 13008G17KT 9999 FEW040 BKN100 16/M02 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIAG",
       RawData = "OIAG 041600Z 19004KT 8000 FEW035CB BKN040 17/10 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OIAA",
       RawData = "OIAA 041600Z 23006KT 8000 -RA FEW035CB SCT040 OVC100 13/09 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEYN",
       RawData = "OEYN 041600Z 24010KT CAVOK 25/14 Q1005 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEWJ",
       RawData = "OEWJ 041600Z 34003KT CAVOK 22/14 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEWD",
       RawData = "OEWD 041600Z 11004KT CAVOK 27/03 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OETR",
       RawData = "OETR 041600Z 11016KT 8000 SCT030 BKN100 16/M06 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OETF",
       RawData = "OETF 041600Z 22015KT 9999 FEW030 20/04 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OETB",
       RawData = "OETB 041600Z 24008KT CAVOK 21/M10 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OESK",
       RawData = "OESK 041600Z 10017KT 8000 FEW040 SCT100 17/06 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OESH",
       RawData = "OESH 041600Z 15008KT CAVOK 31/00 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OERS",
       RawData = "OERS 041600Z 27005KT CAVOK 23/13 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OERR",
       RawData = "OERR 041600Z 11015KT 8000 BKN030 14/05 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OERK",
       RawData = "OERK 041600Z 11008KT 8000 SCT040 OVC080 19/01 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OERF",
       RawData = "OERF 041600Z 11012KT 7000 RA BKN035 11/09 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEPA",
       RawData = "OEPA 041600Z 13012KT 9999 SCT035 13/05 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OENG",
       RawData = "OENG 041600Z 20012KT 9999 BKN030 SCT090 31/01 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEMN",
       RawData = "OEMN 041600Z 19004KT 8000 SCT040 29/18 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEMA",
       RawData = "OEMA 041600Z 23016KT 9999 FEW035 26/05 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEKM",
       RawData = "OEKM 041600Z 18012KT 9999 SCT022 19/M01 Q1021 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEKJ",
       RawData = "OEKJ 041600Z 11007KT 9999 FEW040 BKN080 21/01 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEJN",
       RawData = "OEJN 041600Z 22006KT 9999 FEW035 27/22 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEHL",
       RawData = "OEHL 041600Z 15006KT 9999 BKN040 12/08 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEGT",
       RawData = "OEGT 041600Z 30008KT 9999 SCT040 18/M11 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEGS",
       RawData = "OEGS 041600Z 12011KT 6000 SCT040 16/07 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEGN",
       RawData = "OEGN 041600Z 17006KT 9999 FEW030 SCT100 29/22 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEDR",
       RawData = "OEDR 041600Z 07006KT 9999 SCT040 BKN080 18/15 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEDM",
       RawData = "OEDM 041600Z 15012KT 6000 BKN040 19/00 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEDF",
       RawData = "OEDF 041600Z 08006KT 9999 FEW040 OVC080 17/14 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEBH",
       RawData = "OEBH 041600Z 22010KT 9999 FEW030 27/02 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEBA",
       RawData = "OEBA 041600Z 16012G22KT 6000 SCT030 19/05 Q1015 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEAO",
       RawData = "OEAO 041600Z 24012KT 9999 SCT040 24/M03 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEAH",
       RawData = "OEAH 041600Z 09005KT 9999 FEW040 BKN100 19/12 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OEAB",
       RawData = "OEAB 041600Z 21016KT 9999 BKN020 18/03 Q1021 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "OBBI",
       RawData = "OBBI 041600Z 05008KT CAVOK 19/16 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NVVV",
       RawData = "NVVV 041600Z VRB02KT 9999 FEW020 24/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NSFA",
       RawData = "NSFA 041600Z 09007KT 9999 FEW021 BKN150 25/23 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NGTA",
       RawData = "NGTA 041600Z 10010KT 9999 FEW019 27/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NGFU",
       RawData = "NGFU 041600Z 01009KT 9999 SCT020 28/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NFTV",
       RawData = "NFTV 041600Z 35006KT 9999 -SHRA SCT008 BKN016 OVC110 25/24 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NFTF",
       RawData = "NFTF 041600Z 06004KT 9999 FEW008 FEW015TCU 25/24 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NFNA",
       RawData = "NFNA 041600Z 32003KT 9999 SCT020 24/23 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NFFN",
       RawData = "NFFN 041600Z 13004KT 9999 FEW030 24/24 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCSW",
       RawData = "NCSW 041600Z AUTO NIL",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCRK",
       RawData = "NCRK 041600Z AUTO NIL",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCRG",
       RawData = "NCRG 041600Z 08005KT 9999 BKN018 OVC290 25/24 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCPY",
       RawData = "NCPY 041600Z AUTO 11002KT 9999 FEW023 28/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCPL",
       RawData = "NCPL 041600Z AUTO 10001KT //// ////// 25/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCNS",
       RawData = "NCNS 041600Z AUTO NIL",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCMR",
       RawData = "NCMR 041600Z AUTO 06002KT //// ////// 25/24 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCMK",
       RawData = "NCMK 041600Z AUTO 08001KT //// ////// 25/24 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCMH",
       RawData = "NCMH 041600Z AUTO 19001KT //// ////// 26/24 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCMG",
       RawData = "NCMG 041600Z AUTO 10003KT //// ////// 24/22 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCAT",
       RawData = "NCAT 041600Z AUTO 05002KT //// ////// 25/25 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "NCAI",
       RawData = "NCAI 041600Z AUTO 10010KT 9999 SCT018 BKN290 26/24 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MZBZ",
       RawData = "MZBZ 041600Z 16009KT 9999 SCT025 28/22 A2992 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MYSM",
       RawData = "MYSM 041600Z AUTO 10018KT 9999 BKN028/// 26/19 A3011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MYNN",
       RawData = "MYNN 041600Z 10017KT 9999 VCSH BKN025 BKN048 24/17 A3013 RMK VCSH SW-W",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MYGF",
       RawData = "MYGF 041600Z 10020KT 9999 SCT025 SCT050 24/16 A3014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MYCB",
       RawData = "MYCB 041600Z AUTO /////KT ///V/// 9999 FEW028 25/19 A3010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MWCR",
       RawData = "MWCR 041600Z 09013KT 9999 FEW018 29/21 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MWCB",
       RawData = "MWCB 041600Z 09010KT 9999 SCT018TCU 29/21 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MTPP",
       RawData = "MTPP 041600Z 13006KT 070V210 9000 FEW027TCU SCT080 30/21 Q1014 A2996 RMK:TCU/S/SW",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MSSS",
       RawData = "MSSS 041600Z 14006KT 080V170 9999 SCT033 FEW037TCU 28/20 Q1017 A3004 RMK TCU S SW",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MSLP",
       RawData = "MSLP 041600Z 17003KT 080V240 9999 SCT023 FEW033TCU 30/24 Q1012 A2990 NOSIG RMK TCU N",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MRPV",
       RawData = "MRPV 041600Z 07011KT CAVOK 26/12 A3007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MROC",
       RawData = "MROC 041600Z 11011KT CAVOK 28/12 A3001 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MRLM",
       RawData = "MRLM 041600Z 11005KT 9999 FEW030 29/23 A2995",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MRLB",
       RawData = "MRLB 041600Z 10013KT 9999 FEW045 33/19 A2987",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPTO",
       RawData = "MPTO 041600Z 03007KT 330V100 9999 SCT018 31/20 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPSM",
       RawData = "MPSM 041600Z 17010KT 9999 FEW030 30/20 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPPA",
       RawData = "MPPA 041600Z 01007KT 300V100 9999 FEW020 31/21 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPMG",
       RawData = "MPMG 041600Z VRB04KT 9999 SCT020 31/21 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPDA",
       RawData = "MPDA 041600Z 18004KT CAVOK 31/22 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MPBO",
       RawData = "MPBO 041600Z 07003KT 9999 FEW020 SCT080 ///// Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNRS",
       RawData = "MNRS 041600Z 08004KT 9999 FEW015 29/24 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNPC",
       RawData = "MNPC 041600Z 08004KT 6000 VCRA BKN016TCU 29/27 Q1012 TCURA/N/SE/SW/W/NW",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNMG",
       RawData = "MNMG 041600Z 07010KT 9999 SCT023 31/21 Q1012 A2989 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNJU",
       RawData = "MNJU 041600Z 09006KT 9999 SCT020 32/22 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNJG",
       RawData = "MNJG 041600Z 00000KT 9999 BKN014 23/17 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNCH",
       RawData = "MNCH 041600Z 14004KT CAVOK 32/20 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MNBL",
       RawData = "MNBL 041600Z 18004KT 9999 SCT018 29/26 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MKJS",
       RawData = "MKJS 041600Z 06016KT 9999 FEW022 28/23 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MKJP",
       RawData = "MKJP 041600Z VRB02KT 9999 FEW022 BKN032 30/22 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHTG",
       RawData = "MHTG 041600Z 36005KT 9999 SCT032 25/16 Q1020 A3012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHTE",
       RawData = "MHTE 041600Z 36005KT 9999 FEW023 28/23 Q1012 A2988",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHRO",
       RawData = "MHRO 041600Z 10013KT CAVOK 28/22 Q1014 A2995 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHPR",
       RawData = "MHPR 041600Z 00000KT 9999 FEW048 27/18 Q1017 A3005 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHLM",
       RawData = "MHLM 041600Z VRB05KT 9999 FEW028 29/21 Q1013 A2991 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHLC",
       RawData = "MHLC 041600Z 34005KT 9999 FEW040 28/21 Q1013 A2992 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MHCA",
       RawData = "MHCA 041600Z 00000KT 9999 SCT028 30/21 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGZA",
       RawData = "MGZA 041600Z METAR",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGTU",
       RawData = "MGTU 041600Z",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGSJ",
       RawData = "MGSJ METAR",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGRT",
       RawData = "MGRT 041600Z 24006KT 8000 SKC 31/21 Q1015 A2997 HZ VOLCAN SANTA MARIA Y SATIAGUITO EN ACTIVIDAD",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGQZ",
       RawData = "MGQZ 041600Z 00000KT CAVOK 18/09 QFE 774/2 FEW200",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGPB",
       RawData = "MGPB 041600Z METAR",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGMT",
       RawData = "MGMT 041600Z 00000KT CAVOK 34/26",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGMM",
       RawData = "MGMM 041600Z 09006KT CAVOK 28/22 Q1014 A2994",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGHT",
       RawData = "MGHT 041600Z 09006KT CAVOK 22/10",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGGT",
       RawData = "MGGT 041600Z 16012KT 9999 FEW018 23/14 Q1022 A3018 FEW200",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGES",
       RawData = "MGES 041600Z 00000KT 9999 SCT020 26/16 QFE 909.8",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MGCB",
       RawData = "MGCB 041600Z 21008KT CAVOK 24/16 QFE 871.0",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDST",
       RawData = "MDST 041600Z 10007KT 030V180 9999 FEW022CB FEW023 30/20 Q1015 CB/NE/N",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDSD",
       RawData = "MDSD 041600Z 13006KT 9999 SCT020 30/24 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDPP",
       RawData = "MDPP 041600Z 06015KT 9999 FEW022CB FEW024 SCT300 30/22 Q1015 CB/NE/N",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDPC",
       RawData = "MDPC 041600Z 09010KT 9999 FEW022 28/22 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDLR",
       RawData = "MDLR 041600Z 09008KT 9999 SCT020 28/23 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDJB",
       RawData = "MDJB 041600Z 36005KT 9999SCT020 31/21 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDCY",
       RawData = "MDCY 041600Z 00000KT 9999 BKN017 27/22 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDBH",
       RawData = "MDBH 041600Z 13010KT 9999 FEW024 31/21 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MDAB",
       RawData = "MDAB 041600Z 09006KT 9999 SCT020 29/23 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MBPV",
       RawData = "MBPV 041600Z 08012KT 9999 VCSH BKN012CB 26/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "MBGT",
       RawData = "MBGT 041600Z 08016KT 9999 SCT018TCU BKN050 24/22 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LPOV",
       RawData = "LPOV 041600Z 29007KT 9999 FEW025 20/12 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LPMT",
       RawData = "LPMT 041600Z 04007KT 9999 SCT030 14/12 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LPMR",
       RawData = "LPMR 041600Z 33007KT 9999 SCT025 18/11 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LPLA",
       RawData = "LPLA 041600Z /////KT 9999 FEW014 BKN018 18/14 Q1024",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LPBJ",
       RawData = "LPBJ 041600Z 02006KT 350V060 9999 FEW012 SCT040 16/12 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LOAV",
       RawData = "LOAV 041600Z 06004KT CAVOK 13/00 Q////",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LOAN",
       RawData = "LOAN 041600Z 06005KT CAVOK ///// Q////",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LKLN",
       RawData = "LKLN 041600Z AUTO VRB01KT CAVOK 12/M08 Q1025",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LESU",
       RawData = "LESU 041600Z 22005KT 180V260 9999 FEW070TCU SCT082 14/02 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LBPL",
       RawData = "LBPL 041600Z 27004KT 9999 SKC 12/04 Q1025",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LBPG",
       RawData = "LBPG 041600Z 00000KT 3500 HZ BKN034 13/07 Q1024",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "LBIA",
       RawData = "LBIA 041600Z 00000KT 9999 SKC 11/01 Q1024",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "KMLC",
       RawData = "KMLC 041600Z AUTO 19003KT 10SM FEW007 SCT085 12/10 A2936 RMK AO2 T01170100",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "KMHV",
       RawData = "KMHV 041600Z AUTO 00000KT 10SM CLR 08/M02 A3019 RMK AO2",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "KM54",
       RawData = "KM54 041600Z AUTO 17014G25KT 10SM CLR 17/05 A2989 RMK A01",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "KGSH",
       RawData = "KGSH 041600Z AUTO 19012KT 4SM RA BR OVC070 04/03 A2981 RMK AO2 P0002 T00440033",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKWJ",
       RawData = "HKWJ 041600Z 13007KT 9999 FEW035 BKN360 35/15 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKNK",
       RawData = "HKNK 041600Z 00000KT 9999 FEW025 BKN080 26/07",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKNI",
       RawData = "HKNI 041600Z 13004KT 9999 FEW023 24/09",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKMO",
       RawData = "HKMO 041600Z 08009KT 9999 FEW025 28/22 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKML",
       RawData = "HKML 041600Z 12005KT 9999 SCT020 28/22 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKME",
       RawData = "HKME 041600Z 00000KT 9999 FEW020 24/12",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKLO",
       RawData = "HKLO 041600Z 08003KT CAVOK 36/10 Q1003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKKT",
       RawData = "HKKT 041600Z 00000KT 9999 BKN024 27/02",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKKI",
       RawData = "HKKI 041600Z 22009KT 9999 FEW027CB SCT250 27/21 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKJK",
       RawData = "HKJK 041600Z 10013KT 9999 FEW026 BKN300 26/09 Q1018 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKGA",
       RawData = "HKGA 041600Z 00000KT 9999 FEW031 35/15 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HKEL",
       RawData = "HKEL 041600Z 15007KT 2000 FU FEW022 BKN300 22/02 Q1021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HETR",
       RawData = "HETR 041600Z 30015KT CAVOK 20/13 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HESW",
       RawData = "HESW 041600Z 01014KT 9999 SCT025 19/05 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HEIS",
       RawData = "HEIS 041600Z 36010KT CAVOK 18/07 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HECA",
       RawData = "HECA 041600Z 02011KT 9999 FEW025 SCT070 18/07 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HBBA",
       RawData = "HBBA 041600Z 18006KT 9000 FEW030CB 29/21 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "HAAB",
       RawData = "HAAB 041600Z 14008KT 9999 SCT023 24/04 Q1023 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GVSV",
       RawData = "GVSV 041600Z 05016KT 9999 SCT022 BKN028 23/13 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GVNP",
       RawData = "GVNP 041600Z 04013KT 9999 FEW016 BKN200 25/11 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GVBA",
       RawData = "GVBA 041600Z 04013KT 9999 FEW014 BKN200 23/12 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GVAC",
       RawData = "GVAC 041600Z 05010KT 9999 BKN014 BKN200 22/12 Q1013 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GUCY",
       RawData = "GUCY 041600Z 27010KT 5000 HZ NSC 33/18 Q1004 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GQPP",
       RawData = "GQPP 041600Z 30011KT 9999 FEW008 21/15 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GQNO",
       RawData = "GQNO 041600Z 32017KT CAVOK 23/13 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOTK",
       RawData = "GOTK 041600Z 06002KT CAVOK 37/16 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOSS",
       RawData = "GOSS 041600Z 34008KT 280V040 CAVOK 25/17 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOSP",
       RawData = "GOSP 041600Z 36002KT CAVOK 29/15 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOOY",
       RawData = "GOOY 041600Z 34014KT 300V010 CAVOK 22/15 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOOG",
       RawData = "GOOG 041600Z 32008KT CAVOK 32/14 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOOD",
       RawData = "GOOD 041600Z 36006KT CAVOK 31/12 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOGS",
       RawData = "GOGS 041600Z 32010KT CAVOK 26/16 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GOGG",
       RawData = "GOGG 041600Z 34006KT CAVOK 34/23 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMTT",
       RawData = "GMTT 041600Z 05008KT 5000 FEW026 SCT050 BKN083 18/15 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMTN",
       RawData = "GMTN 041600Z 10015KT 5000 BKN012 SCT020 17/14 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMTA",
       RawData = "GMTA 041600Z 02013KT 8000 SCT020 SCT047 18/14 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMZ",
       RawData = "GMMZ 041600Z 06006KT 5000 SCT030 FEW040TCU 18/02 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMW",
       RawData = "GMMW 041600Z 07008KT 050V110 6000 FEW007 BKN017 17/14 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMML",
       RawData = "GMML 041600Z 28015KT 8000 FEW013 SCT100 22/12 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMI",
       RawData = "GMMI 041600Z 26010KT 230V300 6000 SCT016 19/10 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMH",
       RawData = "GMMH 041600Z 27011KT 8000 FEW010 20/14 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMD",
       RawData = "GMMD 041600Z 22005KT 9999 SCT030 20/07 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMC",
       RawData = "GMMC 041600Z 06006KT 8000 SCT016 SCT026 19/12 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMMB",
       RawData = "GMMB 041600Z 35011KT 310V020 9999 SCT016TCU 19/12 Q1008 BECMG SCT016 FEW020CB",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMFM",
       RawData = "GMFM 041600Z 32007KT 290V350 5000 FEW013 BKN016 16/11 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMFK",
       RawData = "GMFK 041600Z 17005KT 120V220 5000 SCT033 18/08 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMFB",
       RawData = "GMFB 041600Z 20015KT 9999 FEW030TCU 18/10 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMAZ",
       RawData = "GMAZ 041600Z 20010KT CAVOK 23/M02 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMAT",
       RawData = "GMAT 041600Z 31016KT 9999 BKN026 19/09 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GMAG",
       RawData = "GMAG 041600Z 29014KT 8000 SCT013 SCT016 20/07 Q1008 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GLRB",
       RawData = "GLRB 041600Z 19010KT 8000 VCHZ FEW022 34/21 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GGOV",
       RawData = "GGOV 041600Z VRB03KT CAVOK 34/13 Q1007 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GBYD",
       RawData = "GBYD 041600Z 28010KT CAVOK 27/15 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GATB",
       RawData = "GATB 041600Z 24005KT 210V270 8000 NSC 39/04 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GAMB",
       RawData = "GAMB 041600Z 30008KT 8000 NSC 39/07 Q1004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "GAKD",
       RawData = "GAKD 041600Z 30006KT 260V330 CAVOK 36/M03 Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FYRU",
       RawData = "FYRU 041600Z AUTO 10004KT //// // ////// 30/19 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FYLZ",
       RawData = "FYLZ 041600Z AUTO /////KT //// // ////// 23/18 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FWKI",
       RawData = "FWKI 041600Z 09011KT 9999 FEW028CB BKN080 24/17 Q1016 TEMPO TS",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FVRG",
       RawData = "FVRG 041600Z 08003KT 9999 -SHRA FEW030CB SCT040 BKN300 23/18 Q1019 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FTTA",
       RawData = "FTTA 041600Z 22002KT CAVOK 41/02 Q1003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FSIA",
       RawData = "FSIA 041600Z 32011KT 9999 FEW017CB SCT022 28/25 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQXA",
       RawData = "FQXA 041600Z 11007KT 070V140 9999 FEW020 29/21 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQTT",
       RawData = "FQTT 041600Z 13004KT 9999 SCT020 FEW025CB 30/22 Q1010 RMK CB TO S/N",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQQL",
       RawData = "FQQL 041600Z 18007KT 100V190 9999 SCT018 29/25 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQPB",
       RawData = "FQPB 041600Z /////KT 9999 FEW020 29/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQNP",
       RawData = "FQNP 041600Z 14004KT 9999 SCT020 FEW025CB 29/21 Q1012 RMK CB N",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQMA",
       RawData = "FQMA 041600Z 02013KT 9999 FEW020 28/22 Q1012 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQLC",
       RawData = "FQLC 041600Z 23003KT 9999 FEW010 BKN015 FEW020CB 19/18 Q1019 RMK RETSRA CB ISO ALL/D",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQIN",
       RawData = "FQIN 041600Z 17009KT 9999 FEW020 28/23 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQCH",
       RawData = "FQCH 041600Z /////KT 9999 BKN015 FEW020CB 26/22 Q1016 RMK CB TO E/NE",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FQBR",
       RawData = "FQBR 041600Z 14010KT 9999 FEW018 SCT/// 28/22 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FOOL",
       RawData = "FOOL 041600Z 25006KT 220V280 9999 FEW013 30/24 Q1005 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FOOG",
       RawData = "FOOG 041600Z 23006KT 160V260 9999 FEW011 31/24 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FNLU",
       RawData = "FNLU 041600Z 26009KT 9999 FEW017 BKN070 29/24 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FMSD",
       RawData = "FMSD 041600Z 28006KT 9999 VCSH SCT016 BKN033 27/25 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FMNM",
       RawData = "FMNM 041600Z 31007KT 9999 VCTS FEW020CB 28/25 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FMMT",
       RawData = "FMMT 041600Z 07006KT 020V100 9999 SCT017CB 28/26 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FLKK",
       RawData = "FLKK 041600Z 11007KT CAVOK 25/17 Q1017 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FKKD",
       RawData = "FKKD 041600Z 26008KT 9999 TS BKN014 SCT017CB 32/26 Q1005 TEMPO 12008G20KT 4000 TSRA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FIMP",
       RawData = "FIMP 041600Z 05005KT 9999 SCT016 27/24 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FEFF",
       RawData = "FEFF 041600Z 04011KT 9000 -TSRA FEW016 FEW033CB 34/22 Q1005 TEMPO 13025KT 4000 TSRA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FDSK",
       RawData = "FDSK 041600Z 03008KT 9999 FEW040 27/19 Q1014 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FDPP",
       RawData = "FDPP 041600Z AUTO 08006KT //// // ////// 24/19 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FDMY",
       RawData = "FDMY 041600Z AUTO 06001KT //// // ////// ///// Q////",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FBSK",
       RawData = "FBSK 041600Z 05005KT 9999 FEW030 28/19 Q1016 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FBPM",
       RawData = "FBPM 041600Z 12008KT 090V150 9999 FEW030 27/19 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FBKE",
       RawData = "FBKE 041600Z 12008KT 090V160 9999 SCT030 29/18 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAWK",
       RawData = "FAWK 041600Z AUTO /////KT //// // ////// 20/18 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAUP",
       RawData = "FAUP 041600Z 04011KT 9999 SCT050CB 30/18 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAPP",
       RawData = "FAPP 041600Z 07010KT 9999 BKN025 24/19 Q1020 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAPE",
       RawData = "FAPE 041600Z 23013KT CAVOK 22/18 Q1010 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAMM",
       RawData = "FAMM 041600Z 04006KT 9999 FEW040 27/19 Q1019 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FALA",
       RawData = "FALA 041600Z 19009KT 8000 -TSRA FEW045CB 22/18 Q1020 BECMG -SHRA FEW045TCU",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAKN",
       RawData = "FAKN 041600Z 03003KT 9999 FEW030 25/18 Q1017 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAKM",
       RawData = "FAKM 041600Z 11031KT 9999 FEW040 23/17 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAGG",
       RawData = "FAGG 041600Z 23006KT 180V260 9999 FEW015 SCT025 22/19 Q1012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FAEL",
       RawData = "FAEL 041600Z 23007KT CAVOK 23/19 Q1011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FACT",
       RawData = "FACT 041600Z 18018KT 9999 FEW008 BKN016 22/19 Q1011 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "FABL",
       RawData = "FABL 041600Z 12008KT 9999 -TSRA BKN020 SCT030CB 20/15 Q1020 TEMPO 5000 TSRA BKN009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DXNG",
       RawData = "DXNG 041600Z 20004KT 130V290 9999 FEW010 37/12 Q1007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTZ",
       RawData = "DTTZ 041600Z 10014KT 7000 FEW033 21/07 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTX",
       RawData = "DTTX 041600Z 11009KT 080V140 9999 FEW030 17/13 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTR",
       RawData = "DTTR 041600Z AUTO 12006KT 090V150 NCD 24/02 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTN",
       RawData = "DTTN 041600Z 09010KT 9999 SCT020 20/11 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTL",
       RawData = "DTTL 041600Z VRB03KT 9999 FEW020 17/13 Q1020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTK",
       RawData = "DTTK 041600Z VRB04KT 9999 SCT023 20/07 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTG",
       RawData = "DTTG 041600Z 08016KT 6000 SCT030 18/11 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTF",
       RawData = "DTTF 041600Z 09010KT 8000 SCT026 19/08 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTD",
       RawData = "DTTD 041600Z 08009KT 040V130 8000 FEW026 21/03 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTTB",
       RawData = "DTTB 041600Z 06017KT 9999 FEW020 16/14 Q1019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DTKA",
       RawData = "DTKA 041600Z 12011KT 090V160 9999 FEW020 20/10 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DRZR",
       RawData = "DRZR 041600Z 06008KT CAVOK 38/M08 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DRZA",
       RawData = "DRZA 041600Z 09015KT 8000 NSC 35/M08 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DRRN",
       RawData = "DRRN 041600Z 09007KT 050V160 8000 NSC 41/02 Q1004 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNYO",
       RawData = "DNYO 041600Z 00000KT CAVOK 41/09 Q1004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNPO",
       RawData = "DNPO 041600Z 19004KT 9999 FEW360M 32/26 Q1004 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNMN",
       RawData = "DNMN 041600Z 28003KT CAVOK 40/13 Q1003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNMM",
       RawData = "DNMM 041600Z 19018KT 8000 SCT014 FEW020CB 32/25 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNKT",
       RawData = "DNKT 041600Z 05010KT 8000 NSW NSC 38/02 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNKN",
       RawData = "DNKN 041600Z 06009KT 8000 NSC 37/02 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNIM",
       RawData = "DNIM 041600Z 24010KT 9999 BKN390M 33/25 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNIL",
       RawData = "DNIL 041600Z 00000KT 9999 FEW015 38/19 Q1004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNGO",
       RawData = "DNGO 041600Z 06005KT CAVOK 38/05 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNCA",
       RawData = "DNCA 041600Z 31008KT 6000 HZ BKN013 FEW021CB 32/25 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DNAA",
       RawData = "DNAA 041600Z 09006KT 8000 NSC 39/16 Q1004 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DGAA",
       RawData = "DGAA 041600Z 19016KT CAVOK 31/26 Q1006 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DFOO",
       RawData = "DFOO 041600Z VRB05KT 6000 FEW026 39/11 Q1005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DFFD",
       RawData = "DFFD 041600Z 07007KT 360V170 6000 NSC 41/06 Q1004 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DBBB",
       RawData = "DBBB 041600Z 22015KT 9999 FEW013 32/26 Q1005 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUZ",
       RawData = "DAUZ 041600Z 14012KT 7000 FEW040 BKN080 22/02 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUU",
       RawData = "DAUU 041600Z 03011KT 350V070 7000 SCT040 BKN100 22/07 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUT",
       RawData = "DAUT 041600Z 05013KT 9000 NSC 25/08 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUO",
       RawData = "DAUO 041600Z 11006KT 8000 NSC 21/08 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUL",
       RawData = "DAUL 041600Z 10008KT 6000 SCT013 FEW023CB BKN026 10/10 Q1017 RERA",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUK",
       RawData = "DAUK 041600Z 08005KT 8000 SCT040 SCT100 21/09 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUI",
       RawData = "DAUI 041600Z 17016KT 8000 SCT046 SCT120 29/04 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUH",
       RawData = "DAUH 041600Z 08004KT 360V120 5000 SCT040 BKN100 24/04 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUG",
       RawData = "DAUG 041600Z 02012KT 6000 -RA FEW030 SCT033 BKN090 14/11 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUE",
       RawData = "DAUE 041600Z 06008KT 3000 HZ BKN040 22/02 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUB",
       RawData = "DAUB 041600Z 12008KT 6000 SCT040 BKN100 20/08 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAUA",
       RawData = "DAUA 041600Z 19018KT 6000 DRSA SCT046 SCT133 29/07 Q1007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DATM",
       RawData = "DATM 041600Z 24015KT 200V270 7000 NSC 38/// Q1006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOY",
       RawData = "DAOY 041600Z 11027KT 9999 SCT015 SCT023 09/06 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOV",
       RawData = "DAOV 041600Z 14016KT 6000 -RA FEW023CB BKN026 18/09 Q1010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOR",
       RawData = "DAOR 041600Z 21014KT 4000 DRDU FEW030TCU SCT033 22/02 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOL",
       RawData = "DAOL 041600Z 06012KT 7000 -RA SCT026 BKN100 16/14 Q1009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOI",
       RawData = "DAOI 041600Z 05008KT 5000 -RA BKN026 15/11 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOF",
       RawData = "DAOF 041600Z 26012KT 9999 FEW046 23/M00 Q1008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAOB",
       RawData = "DAOB 041600Z 12018KT 9999 BKN026 12/08 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAFH",
       RawData = "DAFH 041600Z 11006KT 8000 FEW010 SCT033 BKN080 12/09 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DABT",
       RawData = "DABT 041600Z 27012KT 9999 SCT026 BKN200 17/05 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DABS",
       RawData = "DABS 041600Z 15009KT 9999 SCT033 SCT200 16/00 Q1018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DABC",
       RawData = "DABC 041600Z VRB02KT CAVOK 19/02 Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DABB",
       RawData = "DABB 041600Z 07010KT 9999 FEW026 18/12 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAY",
       RawData = "DAAY 041600Z 17022KT 7000 FEW026 SCT030 14/09 Q1013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAV",
       RawData = "DAAV 041600Z 33004KT 300V360 8000 FEW023TCU BKN200 18/13 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAS",
       RawData = "DAAS 041600Z 18009KT 8000 SCT030 BKN233 15/03 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAP",
       RawData = "DAAP 041600Z 18008KT 8000 SCT040 SCT080 25/M02 Q1015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAJ",
       RawData = "DAAJ 041600Z 15009KT CAVOK 26/// Q1016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAE",
       RawData = "DAAE 041600Z 06004KT 7000 FEW020 SCT233 19/13 Q1014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "DAAD",
       RawData = "DAAD 041600Z 22010KT 7000 FEW026 SCT100 17/06 Q1017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZZJ",
       RawData = "CZZJ 041600Z AUTO 28003KT M07/M08 RMK AO1 SOG 10 8006 SLP203 T10731084",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZVL",
       RawData = "CZVL 041600Z AUTO 16008KT 9SM CLR M03/M04 A3004 RMK SLP209",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZUM",
       RawData = "CZUM 041600Z AUTO 27008G15KT 220V290 9SM OVC042 M13/M20 A2964 RMK SLP083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZTB",
       RawData = "CZTB 041600Z AUTO 05008KT 01/M04 RMK AO1 SOG 06 1011 SLP084 T00131040",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZST",
       RawData = "CZST 041600Z VRB02KT 15SM SCT240 M04/M04 A3000 RMK CI4 FROIN SLP160",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZSP",
       RawData = "CZSP 041600Z AUTO 24013G19KT M05/M15 RMK AO1 SOG 32 8006 PK WND 23019/1556 SLP194 T10461150 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZSM",
       RawData = "CZSM 041600Z AUTO 00000KT M14/M16 RMK AO1 SOG 49 8009 SLP169 T11441161",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZRP",
       RawData = "CZRP 041600Z AUTO 32019KT M18/M19 RMK AO1 SOG 110 5000 PK WND 32022/1558 SLP040 T11781194",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZMT",
       RawData = "CZMT 041600Z 13006KT 100V170 5SM BR BKN014 BKN020 BKN085 07/06 A2982 RMK SC6SC1AC1 SLP102",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZMJ",
       RawData = "CZMJ 041600Z AUTO 36008KT M06/M09 RMK AO1 SOG 12 2018 SLP256 T10591089",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZMD",
       RawData = "CZMD 041600Z AUTO 01006KT 330V040 9SM -SN SCT012 OVC047 M10/M13 A2996 RMK SLP171",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZKD",
       RawData = "CZKD 041600Z AUTO 31008KT M13/M18 RMK AO1 SOG 51 1004 SLP196 T11301183",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZHY",
       RawData = "CZHY 041600Z AUTO 16002KT M14/M16 RMK AO1 SOG 18 0001 SLP172 T11411158",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZFS",
       RawData = "CZFS 041600Z AUTO 34001KT M16/M18 RMK AO1 SOG 33 3003 SLP186 T11631178",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZFN",
       RawData = "CZFN 041600Z 04005KT 15SM SCT080 SCT220 M18/M21 A3011 RMK AC3CC1 SNW CVR/MUCH LOOSE SLP209",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZFM",
       RawData = "CZFM 041600Z 19002KT 35SM FEW080 M23/M25 A3006 RMK AC1 AC TR SLP186",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZFA",
       RawData = "CZFA 041600Z 13003KT 30SM FEW060 BKN220 M17/M19 A3001 RMK SC1CI5 SLP227",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZEV",
       RawData = "CZEV 041600Z AUTO 10005KT M15/M16 RMK AO1 SOG 48 0000 SLP192 T11471164",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZEM",
       RawData = "CZEM 041600Z 32004KT 15SM BKN080 M11/M16 A2986 RMK AC7 SLP115",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZEL",
       RawData = "CZEL 041600Z AUTO 20009KT 02/M01 RMK AO1 4PAST HR SOG 42 8015 SLP131 P0002 T00171011 50007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZDB",
       RawData = "CZDB 041600Z AUTO 25013G19KT M04/M11 RMK AO1 SOG 19 8007 PK WND 24019/1554 SLP211 T10391108",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZCR",
       RawData = "CZCR 041600Z AUTO 07003KT M11/M16 RMK AO1 SOG 27 8021 SLP161 T11071161",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CZBF",
       RawData = "CZBF 041600Z AUTO 09003KT 020V140 9SM SCT060 BKN110 M07/M15 A3000 RMK SLP167",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZY",
       RawData = "CYZY 041600Z AUTO 00000KT 9SM CLR M07/M08 A2998 RMK ICE SLP194",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZX",
       RawData = "CYZX 041600Z 23012KT 15SM FEW031 BKN130 M02/M11 A3017 RMK SC1AC6 DENSITY ALT -2241FT SLP219",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZW",
       RawData = "CYZW 041600Z VRB02KT 30SM FEW110 M16/M18 A2999 RMK AC2 SLP214",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZV",
       RawData = "CYZV 041600Z 17002KT 20SM R09/5000VP6000FT/D -SN BKN026 OVC041 M10/M16 A2990 RMK SC6SC2 SLP134",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZU",
       RawData = "CYZU 041600Z 13002KT 1/4SM FZFG VV002 M07/M08 A2999 RMK FG8 FROIN SLP201",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZT",
       RawData = "CYZT 041600Z 10015G21KT 20SM SCT064 OVC088 08/05 A2985 RMK SC4AC4 SLP110",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZS",
       RawData = "CYZS 041600Z 36007KT 15SM BKN035 M24/M27 A2970 RMK SC5 SLP070",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZR",
       RawData = "CYZR 041600Z AUTO 18008KT 9SM -RA OVC028 02/01 A2988 RMK SLP126",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZH",
       RawData = "CYZH 041600Z AUTO 12005KT 9SM OVC170 M07/M08 A3001 RMK SLP199",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYZG",
       RawData = "CYZG 041600Z 25009KT 13SM IC BKN020 M22/M25 A2961 RMK SC6 SLP061",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYZ",
       RawData = "CYYZ 041600Z 20004KT 160V230 12SM -RA OVC050 03/01 A2991 RMK SC8 SLP138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYY",
       RawData = "CYYY 041600Z 21009KT 15SM FEW035 BKN160 M04/M10 A2989 RMK SC1AC7 SC TR SLP129",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYW",
       RawData = "CYYW 041600Z AUTO VRB04KT 9SM OVC021 M03/M07 A2981 RMK SLP116",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYU",
       RawData = "CYYU 041600Z 01009KT 15SM SCT008 BKN009 OVC031 M01/M03 A2975 RMK SC3SC4SC1 SLP091",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYT",
       RawData = "CYYT 041600Z 30018G25KT 15SM BKN036 M07/M15 A2984 RMK SC7 SLP117",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYR",
       RawData = "CYYR 041600Z 27007KT 240V300 15SM -SHSN BKN036 M12/M19 A2976 RMK SC7 DENSITY ALT -2989FT SLP081",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYN",
       RawData = "CYYN 041600Z AUTO 34011G17KT 9SM OVC015 M05/M07 A3011 RMK SLP239",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYJ",
       RawData = "CYYJ 041600Z 14005KT 4SM BR SCT005 SCT010 BKN016 BKN025 BKN035 07/06 A3000 RMK SF3SC1SC2SC1SC1 SC TR VIS NE-SE 30 SLP161",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYG",
       RawData = "CYYG 041600Z 24013G19KT 15SM FEW030 BKN160 BKN250 M06/M14 A3009 RMK SC1AC5CI2 SC TR SLP195",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYF",
       RawData = "CYYF 041600Z 00000KT 15SM FEW160 BKN230 M00/M03 A3007 RMK AC1CI5 SLP197",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYE",
       RawData = "CYYE 041600Z VRB02KT 30SM FEW120 M10/M12 A3000 RMK AC1 SLP188",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYD",
       RawData = "CYYD 041600Z 00000KT 25SM FEW050 FEW150 FEW220 M05/M06 A2995 RMK SC1AC1CI1 SC TR AC TR SLP169",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYYC",
       RawData = "CYYC 041600Z 20005KT 40SM FEW030 M05/M07 A3001 RMK SC1 SC TR SLP221",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXZ",
       RawData = "CYXZ 041600Z 00000KT 10SM OVC010 02/M01 A2973 RMK SC8 SLP083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXY",
       RawData = "CYXY 041600Z 00000KT 40SM FEW040 FEW220 M12/M13 A2993 RMK SC1CI1 SC TR CI TR FROIN SLP188",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXX",
       RawData = "CYXX 041600Z 36003KT 30SM FEW010 SCT045 OVC160 07/07 A3001 RMK SF1SC2AC5 SLP167",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXU",
       RawData = "CYXU 041600Z 18006KT 6SM -RA OVC056 03/M02 A2991 RMK SC8 SLP142",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXT",
       RawData = "CYXT 041600Z 02011KT 20SM FEW030 BKN060 02/00 A2993 RMK SC2SC5 SLP146",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXS",
       RawData = "CYXS 041600Z AUTO 01005KT 9SM SCT160 M04/M05 A2993 RMK SLP174",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXR",
       RawData = "CYXR 041600Z AUTO 20008KT 9SM FEW016 00/M02 A2977 RMK PCPN 0.5MM PAST HR SLP097",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXP",
       RawData = "CYXP 041600Z VRB02KT 15SM SKC M28/M31 A2947 RMK SLP984",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXN",
       RawData = "CYXN 041600Z 32011KT 15SM SKC M25/M29 A2993 RMK SLP138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXL",
       RawData = "CYXL 041600Z 02007KT 340V090 15SM OVC015 M03/M07 A2982 RMK SC8 SLP122",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXH",
       RawData = "CYXH 041600Z 21007KT 15SM FEW032 FEW270 M01/M04 A3015 RMK SC2CI1 CI TR SLP242",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXE",
       RawData = "CYXE 041600Z 25005KT 15SM -SN FEW020 BKN036 M05/M07 A3014 RMK CF1SC6 SLP246",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYXC",
       RawData = "CYXC 041600Z 00000KT 15SM FEW007 SCT040 BKN062 M00/M00 A3006 RMK ST1SC2SC4 BR SLP213",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYWL",
       RawData = "CYWL 041600Z 12006KT 15SM BKN120 M02/M05 A2991 RMK AC5 SLP167",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYWK",
       RawData = "CYWK 041600Z 23009KT 15SM FEW040 SCT090 M14/M24 A2964 RMK SC1AC3 SLP091",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYWH",
       RawData = "CYWH 041600Z 11004KT 090V160 10SM SCT004 OVC008 07/06 A3000 RMK SF3SC5 VIS S 15 SLP160",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYWG",
       RawData = "CYWG 041600Z 35015KT 9SM -SHSNGS OVC017 M05/M07 A2999 RMK SC8 CVCTV CLD EMBD SLP172",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYWE",
       RawData = "CYWE 041600Z AUTO 09004KT 9SM -SN OVC024 M16/M18 A2995 RMK SLP189",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVT",
       RawData = "CYVT 041600Z AUTO 24006KT 9SM CLR M03/M07 A3001 RMK SLP194",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVR",
       RawData = "CYVR 041600Z 11007KT 25SM BKN026 BKN039 OVC140 08/07 A3001 RMK SC5SC2AC1 SLP165",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVQ",
       RawData = "CYVQ 041600Z 11006KT 30SM FEW080 SCT100 M16/M19 A3011 RMK AC1AC2 SLP205",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVP",
       RawData = "CYVP 041600Z 29004KT 250V320 15SM -SN FEW025 BKN054 OVC089 M16/M22 A2968 RMK CF1SC6AC1 SLP056",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVO",
       RawData = "CYVO 041600Z 20009G16KT 160V230 10SM BKN075 M01/M04 A2975 RMK AC7 SLP099",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVM",
       RawData = "CYVM 041600Z 00000KT 12SM IC FEW020 BKN037 OVC070 M18/M20 A2944 RMK SC2SC4AC2 VIS LWR WNW-NE 4 SLP970",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYVL",
       RawData = "CYVL 041600Z AUTO VRB03KT 9SM OVC110 M19/M21 A3004 RMK SLP211",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYUY",
       RawData = "CYUY 041600Z 21008KT 15SM FEW015 SCT072 BKN240 00/M03 A2975 RMK CF1AC3CI1 SLP092",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYUX",
       RawData = "CYUX 041600Z 31012KT 10SM BKN018 BKN032 M23/M25 A2958 RMK SC5SC2 SLP021",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYUT",
       RawData = "CYUT 041600Z 33007KT 15SM BKN015 M21/M25 A2972 RMK ST6 SLP070",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYUL",
       RawData = "CYUL 041600Z 21002KT 15SM OVC048 03/M08 A2998 RMK SC8 SLP156",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYUB",
       RawData = "CYUB 041600Z 11012KT 15SM FEW070 M18/M21 A3011 RMK AC2 SLP197",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYTS",
       RawData = "CYTS 041600Z 00000KT 15SM BKN092 02/M04 A2972 RMK AC5 SLP082",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYTR",
       RawData = "CYTR 041600Z 19004KT 150V230 15SM OVC050 03/M04 A2998 RMK SC8 DENSITY ALT -1084FT SLP155",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYTQ",
       RawData = "CYTQ 041600Z 25011KT 15SM FEW010 FEW023 FEW220 M21/M25 A2969 RMK SF1SC1CI1 SF TR SLP062",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYTH",
       RawData = "CYTH 041600Z 32007KT 15SM FEW022 SCT200 M12/M17 A3005 RMK SC2CI1 SLP201",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYTE",
       RawData = "CYTE 041600Z 27005KT 15SM FEW003 BKN038 M20/M24 A2963 RMK SF1SC6 SF TR SLP044",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSP",
       RawData = "CYSP 041600Z CCA 04007KT 15SM FEW016 SCT170 BKN300 00/M02 A2972 RMK SC2AC2CI1 SLP081",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSM",
       RawData = "CYSM 041600Z 00000KT 10SM SCT002 BKN220 M15/M17 A2996 RMK ST4CI2 SLP166",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSK",
       RawData = "CYSK 041600Z 31015KT 7SM -SN DRSN OVC023 M16/M19 A2981 RMK SC8 SLP100",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSJ",
       RawData = "CYSJ 041600Z 25013G20KT 15SM FEW020 OVC130 M03/M12 A3012 RMK SC1AC7 SLP210",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSF",
       RawData = "CYSF 041600Z AUTO VRB02KT 9SM -SN OVC017 M08/M09 A2997 RMK SLP172",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYSB",
       RawData = "CYSB 041600Z 22009KT 2SM -SN OVC004 M00/M02 A2978 RMK SC8 SLP105",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYRT",
       RawData = "CYRT 041600Z 32010KT 15SM IC SCT007 SCT250 M25/M28 A2990 RMK SC3CI1 SLP131",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYRQ",
       RawData = "CYRQ 041600Z AUTO 20008KT 9SM BKN091 BKN190 BKN210 M02/M07 A2997 RMK SLP154",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYRJ",
       RawData = "CYRJ 041600Z CCA 24010G17KT 200V270 12SM VCSH OVC044 M04/M08 A2982 RMK NS8 SLP112",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYRB",
       RawData = "CYRB 041600Z 34014KT 9SM R35/5000V5500FT/N -SN DRSN OVC004 M24/M27 A2952 RMK ST8 SLP010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQZ",
       RawData = "CYQZ 041600Z AUTO 00000KT 9SM CLR M05/M06 A2997 RMK SLP181",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQY",
       RawData = "CYQY 041600Z 27006G16KT 230V310 15SM -SN BKN033 OVC040 M05/M11 A3007 RMK SC6SC2 SLP190",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQX",
       RawData = "CYQX 041600Z 28017G22KT 270V330 20SM SCT035 M07/M17 A2983 RMK SC3 SLP113",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQW",
       RawData = "CYQW 041600Z AUTO 22002KT 9SM CLR M05/M07 A3016 RMK SLP249",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQV",
       RawData = "CYQV 041600Z AUTO 34009KT 9SM BKN029 OVC035 M05/M09 A3007 RMK SLP215",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQU",
       RawData = "CYQU 041600Z 00000KT 25SM FEW064 BKN220 M05/M07 A2995 RMK SC2CI5 SLP181",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQT",
       RawData = "CYQT 041600Z 03008KT 350V070 20SM FEW020 BKN260 01/M04 A2974 RMK SC1CI7 SC TR SLP085",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQR",
       RawData = "CYQR 041600Z CCA 33012KT 15SM -SN OVC020 M07/M09 A3013 RMK SC8 SLP242",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQQ",
       RawData = "CYQQ 041600Z 14017G22KT 20SM FEW010 BKN025 OVC040 08/06 A2997 RMK SF1SC6SC2 DENSITY ALT -705FT SLP150",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQM",
       RawData = "CYQM 041600Z 23015G20KT 15SM FEW030 BKN070 BKN120 BKN200 M04/M12 A3008 RMK SC1AC5AC1CI1 SC TR SLP193",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQL",
       RawData = "CYQL 041600Z 18007KT 60SM FEW100 FEW250 M04/M07 A3009 RMK AC1CI1 AC TR CI TR SLP238",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQK",
       RawData = "CYQK 041600Z 35007KT 20SM -FZDZ OVC015 M03/M06 A2985 RMK ST8 SLP132",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQI",
       RawData = "CYQI 041600Z 22014KT 15SM FEW050 BKN140 M01/M09 A3021 RMK SC1AC7 SC TR SLP235",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQF",
       RawData = "CYQF 041600Z AUTO 15006KT 9SM CLR M06/M06 A3003 RMK SLP222",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYQD",
       RawData = "CYQD 041600Z AUTO 30004KT 9SM CLR M10/M14 A3010 RMK SLP218",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPY",
       RawData = "CYPY 041600Z AUTO 00000KT 9SM CLR M12/M13 A2996 RMK SLP168",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPL",
       RawData = "CYPL 041600Z AUTO 04007KT 7SM -SN OVC018 M07/M10 A2986 RMK SLP137",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPG",
       RawData = "CYPG 041600Z 35017G22KT 15SM -SN OVC028 M05/M08 A3002 RMK SC8 SLP183",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPE",
       RawData = "CYPE 041600Z AUTO 25004KT 9SM BKN140 BKN160 M04/M05 A2995 RMK SLP177",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPD",
       RawData = "CYPD 041600Z AUTO 29012G17KT M06/M15 A3011 RMK CLD MISG WX MISG VIS MISG SLP205",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPC",
       RawData = "CYPC 041600Z 19003KT 15SM SCT024 M23/M26 A3017 RMK SC3 SLP220",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYPA",
       RawData = "CYPA 041600Z 25005KT 15SM FEW020 BKN036 BKN054 M03/M06 A3010 RMK SC1SC4SC2 SLP223",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOY",
       RawData = "CYOY 041600Z 26004KT 190V280 5SM -SN SCT017 OVC029 M04/M07 A2995 RMK SC3SC5 DENSITY ALT -1671FT SLP155",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOW",
       RawData = "CYOW 041600Z 19008KT 2SM R07/5500VP6000FT/D R32/5500VP6000FT/D -SN OVC015 M01/M02 A2996 RMK SN2SC6 SLP155",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOO",
       RawData = "CYOO 041600Z AUTO 19004KT 9SM -RA BKN055 OVC069 04/M03 A2994 RMK SLP145",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOJ",
       RawData = "CYOJ 041600Z 00000KT 15SM FEW110 FEW130 FEW260 M11/M13 A2994 RMK AC1AC1CI1 CI TR SLP169",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOD",
       RawData = "CYOD 041600Z 23006KT 15SM SKC M04/M06 A3010 RMK DENSITY ALT -445FT SLP226",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYOC",
       RawData = "CYOC 041600Z 00000KT 35SM FEW040 M26/M29 A3001 RMK SC1 SC TR SLP200",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYNC",
       RawData = "CYNC 041600Z 35004KT 15SM FEW039 BKN054 OVC075 M10/M18 A2987 RMK SC2SC3AC3 SLP119",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYNA",
       RawData = "CYNA 041600Z AUTO 25008KT 9SM CLR M09/M17 A2990 RMK SLP129",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMX",
       RawData = "CYMX 041600Z VRB02KT 25SM -SN BKN050 BKN120 OVC200 M01/M08 A2997 RMK SC5AS2CS1 SLP156",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMU",
       RawData = "CYMU 041600Z 24006KT 1 1/2SM -SN SCT033 BKN043 OVC053 M15/M17 A2974 RMK SC3SC3SC2 SLP083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMO",
       RawData = "CYMO 041600Z AUTO 35008KT 300V100 9SM OVC030 M05/M13 A2987 RMK SLP117",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMM",
       RawData = "CYMM 041600Z AUTO VRB02KT 9SM SCT180 BKN210 M04/M08 A3001 RMK SLP188",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMJ",
       RawData = "CYMJ 041600Z 35009KT 15SM FEW008 BKN020 OVC050 M06/M08 A3017 RMK SF1SC5SC2 DENSITY ALT -631FT SLP250",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYMA",
       RawData = "CYMA 041600Z 06002KT 20SM SCT160 M19/M21 A3003 RMK AS3 SLP219",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLW",
       RawData = "CYLW 041600Z AUTO 05004KT 330V060 9SM BKN180 M00/M02 A3005 RMK SLP194",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLU",
       RawData = "CYLU 041600Z 24005KT 15SM FEW028 OVC041 M17/M20 A2962 RMK SC2SC6 SLP039",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLT",
       RawData = "CYLT 041600Z 10004KT 050V120 15SM BKN027 BKN034 M27/M30 A2964 RMK SC6SC1 DENSITY ALT -5009FT SLP044",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLL",
       RawData = "CYLL 041600Z 23006KT 15SM SKC M04/M07 A3010 RMK SLP233",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLJ",
       RawData = "CYLJ 041600Z 25008KT 15SM FEW050 M03/M06 A3009 RMK SC1 SLP220",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLH",
       RawData = "CYLH 041600Z AUTO 02005KT 320V060 9SM OVC030 M07/M12 A2990 RMK SLP147",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLD",
       RawData = "CYLD 041600Z VRB02KT 15SM OVC010 01/M02 A2971 RMK SC8 SLP085",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLC",
       RawData = "CYLC 041600Z 29013KT 15SM -SN SCT072 BKN081 M21/M25 A2955 RMK AC4AC3 SLP016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYLA",
       RawData = "CYLA 041600Z 31009KT 15SM BKN051 M20/M25 A2966 RMK SC7 SLP051",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKY",
       RawData = "CYKY 041600Z VRB02KT 14SM BKN018 OVC100 M04/M08 A3015 RMK SC5AC3 SLP247",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKQ",
       RawData = "CYKQ 041600Z 28004KT 270V360 15SM FEW015 FEW060 M07/M11 A2984 RMK SC1SC1 SC TR SLP109",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKP",
       RawData = "CYKP 041600Z AUTO 05008KT 9SM CLR M06/M12 A2988 RMK SLP138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKO",
       RawData = "CYKO 041600Z VRB02KT 2 1/2SM -SN OVC018 M21/M24 A2978 RMK ST8 SLP089",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKL",
       RawData = "CYKL 041600Z AUTO 25013G19KT 9SM SCT055 SCT240 M13/M18 A2955 RMK SLP058",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKG",
       RawData = "CYKG 041600Z 29015KT 8SM -SN DRSN FEW011 BKN027 M19/M23 A2959 RMK ST2SC4 SLP042",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKF",
       RawData = "CYKF 041600Z AUTO 20011KT 9SM -RA SCT043 OVC066 02/M02 A2989 RMK SLP135",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKD",
       RawData = "CYKD 041600Z 13005KT 15SM FEW090 FEW240 M20/M23 A3006 RMK AC1CI1 AC TR SLP182",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYKA",
       RawData = "CYKA 041600Z 09008KT 40SM FEW160 BKN200 M01/M03 A3005 RMK AC1CI6 SLP191",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYJF",
       RawData = "CYJF 041600Z VRB02KT 15SM SKC M17/M19 A3004 RMK SLP192",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYIV",
       RawData = "CYIV 041600Z AUTO 01006KT 340V040 9SM OVC041 M11/M15 A3002 RMK SLP189",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYIO",
       RawData = "CYIO 041600Z 20004KT 40SM FEW022 M29/M32 A2945 RMK SC2 SNW CVR/ MUCH LOOSE SLP986",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYIN",
       RawData = "CYIN 041600Z AUTO 14005G15KT 9SM CLR M02/M04 A2988 RMK SLP160",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYIK",
       RawData = "CYIK 041600Z 27011KT 15SM -SN SCT018 BKN022 BKN024 M18/M22 A2972 RMK SC4SC2SC1 SLP071",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHZ",
       RawData = "CYHZ 041600Z 29011KT 240V310 15SM FEW030 FEW200 BKN250 M02/M13 A3013 RMK SC1CS1CI7 SC TR CS TR SLP216",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHY",
       RawData = "CYHY 041600Z 17003KT 15SM SCT003 BKN150 M15/M17 A2999 RMK SC3AC4 SLP173",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHU",
       RawData = "CYHU 041600Z AUTO 17009KT 9SM SCT066 01/M07 A2999 RMK SLP158",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHM",
       RawData = "CYHM 041600Z 19010KT 15SM OVC053 04/M04 A2992 RMK SC8 SLP141",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHE",
       RawData = "CYHE 041600Z AUTO 09005KT 9SM BKN046 06/05 A3003 RMK SLP172",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHD",
       RawData = "CYHD 041600Z AUTO 05011G16KT 360V080 9SM OVC015 M04/M07 A2981 RMK SLP121",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYHA",
       RawData = "CYHA 041600Z 28007KT 15SM IC FEW014 FEW028 FEW080 M19/M22 A2960 RMK SF1SC1AC1 SF TR SLP030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGX",
       RawData = "CYGX 041600Z 00000KT 7SM -SN OVC019 M16/M20 A3004 RMK SC8 SLP190",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGV",
       RawData = "CYGV 041600Z AUTO 24009KT 9SM FEW130 M09/M17 A2991 RMK SLP134",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGT",
       RawData = "CYGT 041600Z 32015KT 15SM SCT019 M23/M26 A2953 RMK SC3 SLP010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGR",
       RawData = "CYGR 041600Z 27016KT 15SM -SHSN BKN023 M05/M12 A3003 RMK CU6 SLP171",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGP",
       RawData = "CYGP 041600Z 27005KT 240V310 15SM FEW081 BKN110 BKN210 BKN280 M05/M13 A2994 RMK AC1AS5CI1CS1 CI TR SLP142",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGL",
       RawData = "CYGL 041600Z 25005KT 6SM -SN OVC060 M13/M19 A2979 RMK SC8 SLP112",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGK",
       RawData = "CYGK 041600Z 19009KT 12SM BKN052 OVC070 01/M01 A3000 RMK SC7AC1 SLP164",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYGH",
       RawData = "CYGH 041600Z 06003KT 030V090 25SM BKN100 M18/M20 A3009 RMK AC6 AS ASOCTD SLP200",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYFT",
       RawData = "CYFT 041600Z 27015KT 15SM FEW050 SCT061 SCT070 M13/M21 A2963 RMK SC1SC2AS1 AS TR SLP044",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYFS",
       RawData = "CYFS 041600Z CCA 00000KT 1/8SM FZFG SKC M17/M19 A3002 RMK FG7 FROIN SLP186",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYFO",
       RawData = "CYFO 041600Z 18003KT 15SM FEW020 OVC077 M12/M15 A3008 RMK SC1AC7 SLP215",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYFC",
       RawData = "CYFC 041600Z AUTO 23009KT 180V260 9SM OVC140 M04/M14 A3010 RMK SLP198",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYEV",
       RawData = "CYEV 041600Z 07005KT 15SM FEW100 M17/M20 A3006 RMK AC1 SLP192",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYET",
       RawData = "CYET 041600Z AUTO VRB02KT 9SM CLR M07/M08 A2997 RMK SLP202",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYER",
       RawData = "CYER 041600Z AUTO 29007KT 270V340 9SM OVC012 M14/M16 A3002 RMK SLP170",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYEK",
       RawData = "CYEK 041600Z 33009KT 15SM FEW110 M25/M29 A2998 RMK AC1 SLP155",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYEG",
       RawData = "CYEG 041600Z 16006KT 20SM FEW070 M04/M06 A3004 RMK AC1 AC TR SLP213",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYED",
       RawData = "CYED 041600Z 18008KT 15SM FEW250 M03/M05 A3006 RMK CI1 DENSITY ALT 306FT WIND EST CI TR SLP217",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDQ",
       RawData = "CYDQ 041600Z AUTO VRB02KT 9SM CLR M04/M05 A2994 RMK SLP176",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDP",
       RawData = "CYDP 041600Z 29013KT 15SM BKN120 M16/M22 A2962 RMK AC5 SLP034",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDN",
       RawData = "CYDN 041600Z AUTO 01013G20KT 9SM OVC033 M08/M12 A3008 RMK SLP208",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDL",
       RawData = "CYDL 041600Z AUTO 09007KT 9SM CLR M11/M12 A2996 RMK SLP186",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDF",
       RawData = "CYDF 041600Z 24014KT 220V300 15SM SCT028 BKN046 M06/M14 A2991 RMK SC3SC4 SLP133",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDC",
       RawData = "CYDC 041600Z 00000KT 25SM FEW130 FEW150 FEW170 FEW260 SCT280 M03/M04 A3002 RMK AC1AC1AC2CC1CS2 AC TR AC TR CC TR CONTRAILS SLP194",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDB",
       RawData = "CYDB 041600Z 00000KT 15SM FEW015 FEW090 SCT120 M20/M22 A2990 RMK ST1AC1AC2 / FROIN / SLP196",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYDA",
       RawData = "CYDA 041600Z VRB02KT 20SM FEW120 M20/M22 A3005 RMK AC1 SLP219",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCY",
       RawData = "CYCY 041600Z 32016KT 15SM IC DRSN FEW002 FEW012 BKN014 M20/M24 A2942 RMK SF1SF1ST6 SF TR SF TR SLP968",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCX",
       RawData = "CYCX 041600Z 23010G17KT 180V260 15SM FEW090 SCT130 M04/M14 A3010 RMK AC1AC4 DENSITY ALT -2315FT SLP196",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCQ",
       RawData = "CYCQ 041600Z 21004KT 35SM FEW140 FEW180 SCT200 M03/M04 A2996 RMK AC1AC2CI1 AC TR SLP181",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCP",
       RawData = "CYCP 041600Z 00000KT 15SM VCFG FEW002 FEW130 M07/M07 A3005 RMK SF1AC1 SF TR VIS VLY E3 SLP217",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCO",
       RawData = "CYCO 041600Z 26013KT 8SM -SN DRSN FEW011 OVC021 M18/M21 A3008 RMK ST1SC7 SLP193",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCK",
       RawData = "CYCK 041600Z AUTO 18007KT 9SM -RA OVC071 03/M01 A2991 RMK SLP138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCG",
       RawData = "CYCG 041600Z VRB02KT 15SM BKN048 BKN060 M00/M01 A3011 RMK SC6SC1 SLP214",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCD",
       RawData = "CYCD 041600Z 13002KT 15SM -RA OVC009 07/06 A3000 RMK SC8 SLP163",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCB",
       RawData = "CYCB 041600Z 27004KT 10SM IC FEW040 BKN100 M26/M29 A2988 RMK SC1AC4 SLP125",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYCA",
       RawData = "CYCA 041600Z AUTO 22005KT 190V270 9SM M12/M19 A2970 RMK CLD MISG SLP059",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBX",
       RawData = "CYBX 041600Z 24010KT 15SM FEW060 M14/M18 A2982 RMK SC1 SC TR SLP105",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBW",
       RawData = "CYBW 041600Z AUTO 33003KT 9SM CLR M10/M11 A3000 RMK ICE SLP233",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBV",
       RawData = "CYBV 041600Z 03005KT 15SM FEW014 OVC043 M06/M09 A3001 RMK SF1SC8 SF TR OCNL -SN SLP180",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBR",
       RawData = "CYBR 041600Z 04004KT 15SM -SN OVC020 M05/M09 A3002 RMK SC8 SLP195",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBL",
       RawData = "CYBL 041600Z 12009KT 30SM FEW013 SCT050 OVC100 07/05 A2995 RMK SC2SC2AC4 SLP148",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBG",
       RawData = "CYBG 041600Z 09005KT 1/2SM R11/3000FT SN VV005 M07/M09 A2987 RMK SN8 DENSITY ALT -2079FT VIS VRB 1/4-3/4 SLP128",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYBD",
       RawData = "CYBD 041600Z 00000KT 15SM FEW120 BKN150 M01/M01 A2992 RMK AC1AS7 AC TR FROIN SLP137",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAZ",
       RawData = "CYAZ 041600Z 10009KT 15SM -RA FEW019 OVC030 07/05 A2993 RMK SC2SC6 VRY LGT PCPN SLP138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAY",
       RawData = "CYAY 041600Z AUTO 24015G20KT 7SM -SN CLR M13/M18 A2980 RMK SLP098",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAW",
       RawData = "CYAW 041600Z 28009KT 15SM FEW120 BKN250 M02/M13 A3019 RMK AC1CI7 DENSITY ALT -2197FT SLP225",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAS",
       RawData = "CYAS 041600Z 33008KT 15SM FEW045 M21/M25 A2961 RMK SC1 SLP046",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAH",
       RawData = "CYAH 041600Z AUTO VRB02KT 9SM OVC060 M12/M21 A2972 RMK SLP097",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CYAB",
       RawData = "CYAB 041600Z 00000KT 11SM OVC026 M20/M42 A2946 RMK SC8 SLP981",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXZV",
       RawData = "CXZV 041600Z AUTO 16002KT M09/M16 RMK AO1 SOG 75 8015 SLP129 T10851158",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXZC",
       RawData = "CXZC 041600Z AUTO 05004KT M05/M14 RMK AO1 SOG 21 1016 SLP121 T10541139",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXYH",
       RawData = "CXYH 041600Z AUTO 05003KT M09/M11 RMK AO1 SOG 22 3004 SLP173 T10901107",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXWN",
       RawData = "CXWN 041600Z AUTO 35006KT M04/M08 RMK AO1 PK WND 01017/1506 SLP168 T10441079 52016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXVN",
       RawData = "CXVN 041600Z AUTO 19009KT 06/M03 RMK AO1 SLP141 T00601034 58013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXTV",
       RawData = "CXTV 041600Z AUTO 00000KT M23/M26 RMK AO1 SLP193 T12321255 58001",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXTP",
       RawData = "CXTP 041600Z AUTO 30009G15KT M06/M16 RMK AO1 SOG 05 0000 PK WND 31018/1519 SLP111 T10601158",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXTO",
       RawData = "CXTO 041600Z AUTO 03/M01 RMK AO1 6PAST HR SOG 20 8012 SLP137 P0002 T00331007 50006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXTN",
       RawData = "CXTN 041600Z AUTO 32005KT M19/M21 RMK AO1 SOG 98 8003 SLP215 T11931214",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXTD",
       RawData = "CXTD 041600Z AUTO 26010G17KT M04/M16 RMK AO1 SOG 05 8003 PK WND 26017/1559 SLP208 T10441157",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXSH",
       RawData = "CXSH 041600Z AUTO 20007KT M03/M09 RMK AO1 SLP151 T10301086 56019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXSE",
       RawData = "CXSE 041600Z AUTO 28012KT M17/M19 RMK AO1 SOG 15 7002 SLP059 T11711192",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXRH",
       RawData = "CXRH 041600Z AUTO 29007KT M08/M10 RMK AO1 SOG 11 8003 SLP135 T10841095",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXRB",
       RawData = "CXRB 041600Z AUTO 33003KT M24/M26 RMK AO1 SOG 04 6001 SLP009 T12391255",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXPC",
       RawData = "CXPC 041600Z AUTO 01/M02 RMK AO1 3PAST HR SOG 49 8001 SLP117 P0001 T00071015 50003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXOX",
       RawData = "CXOX 041600Z AUTO 23004KT M03/M06 RMK AO1 SOG 43 8008 SLP199 T10251056",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXNP",
       RawData = "CXNP 041600Z AUTO 24017G23KT M03/M11 RMK AO1 SOG 01 8013 PK WND 22023/1511 SLP202 T10291112",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXNM",
       RawData = "CXNM 041600Z AUTO 26021G26KT M09/M13 RMK AO1 SOG 112 PK WND 26026/1551 T10931128 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXMY",
       RawData = "CXMY 041600Z AUTO M02/M15 RMK AO1 T10161149",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXMM",
       RawData = "CXMM 041600Z AUTO 28001KT M04/M08 RMK AO1 SOG 33 8006 SLP192 T10381081",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXMI",
       RawData = "CXMI 041600Z AUTO 34010G15KT M03/M13 RMK AO1 SLP219 T10261129 58006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXMD",
       RawData = "CXMD 041600Z AUTO 35014G21KT M05/M08 RMK AO1 PK WND 02022/1522 SLP175 T10471079 53020",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXLL",
       RawData = "CXLL 041600Z AUTO 00000KT M19/M21 RMK AO1 SLP193 T11881207 53003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXLB",
       RawData = "CXLB 041600Z AUTO 28013KT M02/M10 RMK AO1 PK WND 26018/1543 SLP220 T10171103 58011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXKT",
       RawData = "CXKT 041600Z AUTO 25012G18KT M03/M12 RMK AO1 SOG 09 8008 PK WND 28018/1552 SLP214 T10251116",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXKI",
       RawData = "CXKI 041600Z AUTO 17004KT M00/M04 RMK AO1 SOG 42 2004 SLP083 T10011036",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXKE",
       RawData = "CXKE 041600Z AUTO 21007KT M00/M01 RMK AO1 3PAST HR SOG 35 8009 SLP155 P0001 T10041012 50003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXKA",
       RawData = "CXKA 041600Z AUTO 36007KT M01/M03 RMK AO1 SOG 61 3017 SLP088 T10131030",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXIB",
       RawData = "CXIB 041600Z AUTO 25006G15KT M04/M13 RMK AO1 SOG 25 0000 SLP176 T10401133",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXHM",
       RawData = "CXHM 041600Z AUTO 25003KT 06/M03 RMK AO1 SLP142 T00571027 58014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXHA",
       RawData = "CXHA 041600Z AUTO 17007KT 04/M01 RMK AO1 4PAST HR SOG 01 8013 SLP122 P0002 T00401013 50007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXGH",
       RawData = "CXGH 041600Z AUTO 34009KT M05/M07 RMK AO1 PK WND 33017/1511 SLP170 T10501073 51011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXET",
       RawData = "CXET 041600Z AUTO 18005KT 02/M02 RMK AO1 2PAST HR SOG 32 8010 SLP127 P0001 T00221019 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXEG",
       RawData = "CXEG 041600Z AUTO 15006KT M04/M06 RMK AO1 SOG 05 8008 SLP208 T10381061",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXEC",
       RawData = "CXEC 041600Z AUTO 17004KT M02/M06 RMK AO1 SLP206 T10191060 58009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXEA",
       RawData = "CXEA 041600Z AUTO 02008KT M04/M08 RMK AO1 SOG 59 1008 SLP132 T10431082",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXDW",
       RawData = "CXDW 041600Z AUTO 34015G20KT M05/M08 RMK AO1 SOG 04 3016 PK WND 00024/1507 SLP174 T10481082",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXDK",
       RawData = "CXDK 041600Z AUTO 00000KT M20/M22 RMK AO1 SOG 18 3007 SLP210 T11971217",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXDI",
       RawData = "CXDI 041600Z AUTO 20004KT 05/M05 RMK AO1 SOG 02 6017 SLP144 T00451049 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXDE",
       RawData = "CXDE 041600Z AUTO 36001KT M20/M23 RMK AO1 SOG 36 1005 SLP216 T12031227",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXCK",
       RawData = "CXCK 041600Z AUTO 00000KT M17/M18 RMK AO1 SOG 42 1003 SLP207 T11671184",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXCA",
       RawData = "CXCA 041600Z AUTO 36011KT M01/M05 RMK AO1 SOG 04 1010 PK WND 00017/1535 SLP096 T10071049",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXBO",
       RawData = "CXBO 041600Z AUTO 24007KT M04/M08 RMK AO1 T10361078 50005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXBK",
       RawData = "CXBK 041600Z AUTO 33011KT M06/M08 RMK AO1 SOG 35 1018 SLP236 T10641080",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXBI",
       RawData = "CXBI 041600Z AUTO 16003KT 01/M02 RMK AO1 5PAST HR SOG 64 8002 SLP133 P0002 T00091022 50005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CXAT",
       RawData = "CXAT 041600Z AUTO 00000KT M20/M23 RMK AO1 SOG 06 6006 SLP982 T12021227",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZW",
       RawData = "CWZW 041600Z AUTO 21001KT M15/M17 RMK AO1 SOG 59 3002 SLP210 T11511167",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZV",
       RawData = "CWZV 041600Z AUTO 14023G33KT 06/06 RMK AO1 2PAST HR 6013 PK WND 14033/1554 SLP080 P0001 T00580057 50008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZQ",
       RawData = "CWZQ 041600Z AUTO 22015KT M06/M14 RMK AO1 PK WND 25021/1502 SLP186 T10551143 51008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZO",
       RawData = "CWZO 041600Z AUTO 17011KT RMK AO1",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZN",
       RawData = "CWZN 041600Z AUTO 30021KT M07/M13 RMK AO1 PK WND 31031/1509 SLP124 T10661129 51012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZL",
       RawData = "CWZL 041600Z AUTO 13023KT 07/M02 RMK AO1 PK WND 14029/1546 SLP093 T00731024 57009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZG",
       RawData = "CWZG 041600Z AUTO 23003KT M05/M08 RMK AO1 SLP213 T10541083 58007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWZA",
       RawData = "CWZA 041600Z AUTO 23002KT 07/07 RMK AO1 SLP165 T00710067 58014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWYY",
       RawData = "CWYY 041600Z AUTO 33001KT M00/M02 RMK AO1 SLP192 T10031021 58002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWYL",
       RawData = "CWYL 041600Z AUTO 00000KT M08/M10 RMK AO1 SOG 73 8001 SLP216 T10821095",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWYJ",
       RawData = "CWYJ 041600Z AUTO 14001KT 06/06 RMK AO1 SLP158 T00550057 56009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWXL",
       RawData = "CWXL 041600Z AUTO 19004KT M01/M03 RMK AO1 SLP245 T10051034 54000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWXI",
       RawData = "CWXI 041600Z AUTO 26016KT M10/M16 RMK AO1 SOG 27 8009 PK WND 27019/1558 SLP105 T11031161",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWXC",
       RawData = "CWXC 041600Z AUTO 20006KT M06/M08 RMK AO1 2PAST HR 8006 SLP108 P0001 T10571082 50010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWXA",
       RawData = "CWXA 041600Z AUTO 24006KT M05/M08 RMK AO1 8011 SLP233 T10451076 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWZ",
       RawData = "CWWZ 041600Z AUTO 19009KT 06/M04 RMK AO1 SOG 01 8014 SLP140 T00621038",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWS",
       RawData = "CWWS 041600Z AUTO 36011KT M08/M10 RMK AO1 SOG 77 1013 SLP195 T10781098",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWL",
       RawData = "CWWL 041600Z AUTO 11005KT 07/05 RMK AO1 SLP111 T00720051 58008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWK",
       RawData = "CWWK 041600Z AUTO 06002KT 08/06 RMK AO1 SLP170 T00800061 56012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWF",
       RawData = "CWWF 041600Z AUTO 36015KT M06/M09 RMK AO1 SOG 14 1020 PK WND 35018/1554 SLP224 T10561088",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWE",
       RawData = "CWWE 041600Z AUTO 21010KT 01/M11 RMK AO1 SOG 02 8009 SLP231 T00101113",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWB",
       RawData = "CWWB 041600Z AUTO 24004KT 05/M03 RMK AO1 SLP138 T00511030 58011",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWWA",
       RawData = "CWWA 041600Z AUTO 07002KT 08/04 RMK AO1 SLP165 T00800041 56012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVU",
       RawData = "CWVU 041600Z AUTO 19008G15KT 00/M08 RMK AO1 SOG 01 7008 SLP221 T00001079",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVT",
       RawData = "CWVT 041600Z AUTO 24003KT M03/M08 RMK AO1 SOG 32 8004 SLP207 T10261078",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVQ",
       RawData = "CWVQ 041600Z AUTO 21003KT 02/M08 RMK AO1 SOG 39 8012 SLP155 T00231080",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVP",
       RawData = "CWVP 041600Z AUTO 33003KT M07/M09 RMK AO1 SOG 11 1012 SLP227 T10661091",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVN",
       RawData = "CWVN 041600Z AUTO 34009KT M03/M06 RMK AO1 SLP237 T10301057 51016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVI",
       RawData = "CWVI 041600Z AUTO 18006KT M07/M07 RMK AO1 SOG 03 8007 SLP231 T10671071",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWVF",
       RawData = "CWVF 041600Z AUTO 10008KT 07/06 RMK AO1 T00650063",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWUX",
       RawData = "CWUX 041600Z AUTO 06002KT M07/M10 RMK AO1 SLP132 T10741100 58010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWUS",
       RawData = "CWUS 041600Z AUTO 29004KT 02/M04 RMK AO1 SOG 01 8002 SLP188 T00181038",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWTY",
       RawData = "CWTY 041600Z AUTO 20008KT M03/M08 RMK AO1 T10281083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWTT",
       RawData = "CWTT 041600Z AUTO 23008KT M00/M09 RMK AO1 T10011086",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWTN",
       RawData = "CWTN 041600Z AUTO 26008KT M02/M08 RMK AO1 SOG 59 8018 SLP149 T10191083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWTG",
       RawData = "CWTG 041600Z AUTO 26009KT M06/M08 RMK AO1 7017 SLP126 T10611078 50003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWTA",
       RawData = "CWTA 041600Z AUTO 15003KT 01/M07 RMK AO1 SOG 82 8010 SLP155 T00111068",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSW",
       RawData = "CWSW 041600Z 13004KT 090V170 20SM BKN055 M01/M06 A3005 RMK SC7 SLP217",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWST",
       RawData = "CWST 041600Z AUTO 23019G25KT M03/M07 RMK AO1 SOG 28 8016 PK WND 22027/1514 SLP135 T10321070",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSS",
       RawData = "CWSS 041600Z AUTO 21007KT M02/M13 RMK AO1 SOG 22 8017 SLP206 T10191130",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSR",
       RawData = "CWSR 041600Z AUTO 27009KT M03/M06 RMK AO1 SLP227 T10281058 50003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSP",
       RawData = "CWSP 041600Z AUTO 09001KT 07/06 RMK AO1 SLP163 T00720061 56009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSL",
       RawData = "CWSL 041600Z AUTO 19001KT M02/M03 RMK AO1 SOG 01 8001 SLP191 T10211028",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSK",
       RawData = "CWSK 041600Z AUTO 00000KT 05/05 RMK AO1 SLP167 T00530053 58008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSG",
       RawData = "CWSG 041600Z AUTO 22006KT M04/M08 RMK AO1 SLP130 T10411075 58018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSF",
       RawData = "CWSF 041600Z AUTO 04001KT M05/M14 RMK AO1 SOG 58 8013 SLP134 T10481137",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSD",
       RawData = "CWSD 041600Z AUTO 24017KT M06/M13 RMK AO1 SOG 05 7011 PK WND 24021/1553 SLP193 T10611129",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWSA",
       RawData = "CWSA 041600Z AUTO 28019G26KT 9SM SCT036 M03/M12 A3019 RMK SLP226",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRZ",
       RawData = "CWRZ 041600Z AUTO 23011G16KT M07/M12 RMK AO1 SLP154 T10681117 58010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRY",
       RawData = "CWRY 041600Z AUTO 17001KT M06/M07 RMK AO1 SOG 02 0000 SLP247 T10571072",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRU",
       RawData = "CWRU 041600Z AUTO 12043G52KT 07/ RMK AO1 6031 PK WND 14055/1523 SLP071 T0070 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRT",
       RawData = "CWRT 041600Z AUTO 00000KT M05/M06 RMK AO1 SLP223 T10521064 58005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRO",
       RawData = "CWRO 041600Z AUTO 12016KT 07/06 RMK AO1 4PAST HR 7006 PK WND 13023/1504 SLP111 P0002 T00650059 50004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRN",
       RawData = "CWRN 041600Z AUTO 27011G16KT M04/M14 RMK AO1 PK WND 27018/1533 SLP207 T10411139 50000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRM",
       RawData = "CWRM 041600Z AUTO 12002KT M07/M08 RMK AO1 SOG 03 7010 SLP186 T10711075",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRK",
       RawData = "CWRK 041600Z AUTO 20003KT M00/M02 RMK AO1 2PAST HR SOG 52 6008 SLP137 P0001 T10011015 50010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRJ",
       RawData = "CWRJ 041600Z AUTO 24007KT M09/M11 RMK AO1 SOG 11 0003 SLP248 T10901106",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWRA",
       RawData = "CWRA 041600Z AUTO 25020G25KT M04/M13 RMK AO1 PK WND 26027/1513 SLP134 T10351126 50008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQV",
       RawData = "CWQV 041600Z AUTO 25001KT M06/M08 RMK AO1 T10591082",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQS",
       RawData = "CWQS 041600Z AUTO 15009KT 08/03 RMK AO1 PK WND 13017/1541 SLP082 T00770032 55008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQR",
       RawData = "CWQR 041600Z AUTO 25009KT M07/M14 RMK AO1 T10741138",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQP",
       RawData = "CWQP 041600Z AUTO 18013KT 02/M02 RMK AO1 SOG 11 6009 PK WND 17020/1511 SLP160 T00191016",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQO",
       RawData = "CWQO 041600Z AUTO 22019G25KT M03/M07 RMK AO1 PK WND 22027/1525 T10281068",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQK",
       RawData = "CWQK 041600Z AUTO 36006KT 06/ RMK AO1 SLP160 T0055 55009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWQH",
       RawData = "CWQH 041600Z AUTO 20011KT 01/M10 RMK AO1 SOG 51 7019 SLP170 T00121097",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPZ",
       RawData = "CWPZ 041600Z AUTO 00000KT M08/M09 RMK AO1 SOG 14 6003 SLP174 T10821090",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPR",
       RawData = "CWPR 041600Z AUTO 00000KT M02/M04 RMK AO1 SOG 02 6007 SLP189 T10151039",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPO",
       RawData = "CWPO 041600Z AUTO 01013G18KT M06/M09 RMK AO1 SOG 25 3019 PK WND 35023/1540 SLP189 T10621091",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPK",
       RawData = "CWPK 041600Z AUTO 23005KT M04/M07 RMK AO1 SOG 67 6005 SLP117 T10361068",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPE",
       RawData = "CWPE 041600Z AUTO 23012G18KT M00/M10 RMK AO1 PK WND 24018/1557 SLP209 T10031095 58014",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWPD",
       RawData = "CWPD 041600Z AUTO 19006KT M07/M10 RMK AO1 2PAST HR 6008 SLP130 P0001 T10721099 50007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWOY",
       RawData = "CWOY 041600Z AUTO 29006KT M06/M08 RMK AO1 SOG 21 1006 SLP229 T10591081",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWOE",
       RawData = "CWOE 041600Z AUTO 34003KT M05/M06 RMK AO1 SOG 01 2005 SLP249 T10461061",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWOD",
       RawData = "CWOD 041600Z AUTO 14005KT M04/M07 RMK AO1 SOG 21 6009 SLP111 T10441069 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWOC",
       RawData = "CWOC 041600Z AUTO 26005KT M09/M16 RMK AO1 SOG 20 8017 SLP163 T10881163",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNZ",
       RawData = "CWNZ 041600Z AUTO 02007KT M04/M05 RMK AO1 SOG 55 1020 SLP104 T10411053",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNQ",
       RawData = "CWNQ 041600Z AUTO 24004KT M02/M08 RMK AO1 SLP154 T10201078 56018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNP",
       RawData = "CWNP 041600Z AUTO 00000KT M00/M01 RMK AO1 SOG 03 0004 SLP213 T10021006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNM",
       RawData = "CWNM 041600Z AUTO 25003KT 02/M00 RMK AO1 SLP210 T00201003 50000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNK",
       RawData = "CWNK 041600Z AUTO 35011G17KT M05/M08 RMK AO1 PK WND 00021/1512 SLP181 T10501084 53019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNH",
       RawData = "CWNH 041600Z AUTO 21007G15KT M04/M09 RMK AO1 SOG 46 8011 PK WND 19017/1523 SLP137 T10371088",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNE",
       RawData = "CWNE 041600Z AUTO 22015KT M07/M11 RMK AO1 PK WND 22019/1555 SLP183 T10671114 58009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWND",
       RawData = "CWND 041600Z AUTO 11013KT M19/M21 RMK AO1 SLP173 T11901212 57003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWNC",
       RawData = "CWNC 041600Z AUTO 15002KT 03/M01 RMK AO1 SOG 10 7008 SLP147 T00251007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWMZ",
       RawData = "CWMZ 041600Z AUTO 16009KT 01/M01 RMK AO1 SLP112 T00101011 58003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWMT",
       RawData = "CWMT 041600Z AUTO 06001KT M13/M14 RMK AO1 SOG 38 5004 SLP179 T11261142",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWMQ",
       RawData = "CWMQ 041600Z AUTO 22001KT M03/M06 RMK AO1 SLP245 T10301056 51007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWMM",
       RawData = "CWMM 041600Z AUTO 01002KT 08/07 RMK AO1 SLP170 T00770068 57010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWMJ",
       RawData = "CWMJ 041600Z AUTO 20007KT M01/M05 RMK AO1 SOG 44 8012 SLP131 T10061053",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWME",
       RawData = "CWME 041600Z AUTO 05018G23KT 05/02 RMK AO1 PK WND 04024/1542 SLP120 T00450022 57015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLY",
       RawData = "CWLY 041600Z AUTO 17003KT 100V180 9SM OVC024 02/M01 A3001 RMK SLP172",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLS",
       RawData = "CWLS 041600Z AUTO 20008KT 01/M00 RMK AO1 9PAST HR SOG 31 8012 SLP124 P0004 T00141002 50015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLP",
       RawData = "CWLP 041600Z AUTO 12026G32KT 09/ RMK AO1 PK WND 12035/1542 SLP105 T0088 58018",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLM",
       RawData = "CWLM 041600Z AUTO 13003KT 06/06 RMK AO1 SLP153 T00630060 56009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLE",
       RawData = "CWLE 041600Z AUTO 30003KT M06/M08 RMK AO1 SLP250 T10571076 51010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLC",
       RawData = "CWLC 041600Z AUTO 04004KT 06/04 RMK AO1 T00580040",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWLB",
       RawData = "CWLB 041600Z AUTO 17004KT M04/M07 RMK AO1 SLP215 T10421073 58009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKX",
       RawData = "CWKX 041600Z AUTO 08006KT M11/M12 RMK AO1 SOG 38 1003 SLP202 T11081118",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKO",
       RawData = "CWKO 041600Z AUTO 35012G17KT M06/M08 RMK AO1 SOG 01 2017 PK WND 35017/1550 SLP235 T10571075",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKM",
       RawData = "CWKM 041600Z AUTO 10019KT ////SM ////// ///// A////",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKK",
       RawData = "CWKK 041600Z AUTO 01011KT M02/M05 RMK AO1 SOG 37 3012 SLP110 T10151046",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKH",
       RawData = "CWKH 041600Z AUTO 04/04 RMK AO1 5008 SLP147 T00430043 50004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKG",
       RawData = "CWKG 041600Z AUTO 26005KT M01/M12 RMK AO1 SOG 23 8005 SLP229 T10111115",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWKD",
       RawData = "CWKD 041600Z AUTO M12/M15 RMK AO1 SLP102 T11161148 56012",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJX",
       RawData = "CWJX 041600Z AUTO 21002KT M03/M08 RMK AO1 SOG 32 1004 SLP244 T10251076",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJW",
       RawData = "CWJW 041600Z AUTO 21003KT M05/M08 RMK AO1 SOG 01 8003 SLP209 T10471081",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJV",
       RawData = "CWJV 041600Z AUTO 10007KT M00/M03 RMK AO1 SLP192 T10021026 58004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJU",
       RawData = "CWJU 041600Z AUTO 09007KT 06/06 RMK AO1 PK WND 10018/1502 SLP095 T00630057 55002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJR",
       RawData = "CWJR 041600Z AUTO 09002KT 02/01 RMK AO1 SLP210 T00210011 51003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJO",
       RawData = "CWJO 041600Z AUTO 10002KT M06/M08 RMK AO1 5PAST HR 8010 SLP123 P0002 T10561080 50015",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJI",
       RawData = "CWJI 041600Z AUTO 33009KT M06/M08 RMK AO1 SOG 27 1017 SLP242 T10621079",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJH",
       RawData = "CWJH 041600Z AUTO 23003KT M08/M11 RMK AO1 SOG 77 6011 SLP187 T10801110",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJD",
       RawData = "CWJD 041600Z AUTO 05004KT M08/M11 RMK AO1 SOG 67 2011 SLP205 T10771110",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJC",
       RawData = "CWJC 041600Z AUTO 36007KT M18/M20 RMK AO1 SLP174 T11761199 53006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWJB",
       RawData = "CWJB 041600Z AUTO 32002KT M04/M08 RMK AO1 SOG 33 T10421082 50005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIZ",
       RawData = "CWIZ 041600Z AUTO 18014KT M01/M06 RMK AO1 SOG 38 PK WND 17017/1506 T10051064",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIW",
       RawData = "CWIW 041600Z AUTO 27007KT M06/M08 RMK AO1 SOG 16 1004 SLP236 T10601083",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIT",
       RawData = "CWIT 041600Z AUTO 19006KT 05/M09 RMK AO1 SOG 34 8017 SLP155 T00531090",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIS",
       RawData = "CWIS 041600Z AUTO 25007G18KT M05/M09 RMK AO1 SOG 126 6008 PK WND 24020/1516 SLP121 T10541090",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIP",
       RawData = "CWIP 041600Z AUTO 36002KT M10/M15 RMK AO1 T11011152",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIK",
       RawData = "CWIK 041600Z AUTO 01009G15KT M06/M10 RMK AO1 SOG 24 1018 SLP213 T10621104",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIJ",
       RawData = "CWIJ 041600Z AUTO 26014KT M21/M23 RMK AO1 SOG 55 8009 PK WND 25017/1545 SLP173 T12071229",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWII",
       RawData = "CWII 041600Z AUTO 33015KT M05/M07 RMK AO1 PK WND 33018/1553 SLP168 T10451070 51009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWIG",
       RawData = "CWIG 041600Z AUTO 22014KT RMK AO1 PK WND 23019/1550",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWID",
       RawData = "CWID 041600Z AUTO 19001KT M15/M16 RMK AO1 SLP175 T11531164 50000",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWHV",
       RawData = "CWHV 041600Z AUTO 23003KT M01/M10 RMK AO1 SLP155 T10111095 58019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWHT",
       RawData = "CWHT 041600Z AUTO 00000KT M18/M20 RMK AO1 SOG 37 3005 SLP206 T11781198",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWHQ",
       RawData = "CWHQ 041600Z AUTO 26003KT M04/M08 RMK AO1 T10401077 50007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWHL",
       RawData = "CWHL 041600Z AUTO 07009KT 06/03 RMK AO1 SLP119 T00600028 57009",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGY",
       RawData = "CWGY 041600Z AUTO 17003KT M02/M08 RMK AO1 SOG 15 0000 SLP239 T10241076",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGW",
       RawData = "CWGW 041600Z AUTO 13004KT M01/M06 RMK AO1 SLP216 T10091056 57002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGT",
       RawData = "CWGT 041600Z AUTO 12017KT 08/06 RMK AO1 PK WND 12023/1527 SLP154 T00790061 56008",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGR",
       RawData = "CWGR 041600Z AUTO 26015KT M06/M12 RMK AO1 PK WND 24020/1534 SLP172 T10571120 58001",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGM",
       RawData = "CWGM 041600Z AUTO 25001KT M08/M09 RMK AO1 SOG 08 8006 SLP222 T10791092",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGL",
       RawData = "CWGL 041600Z AUTO 19009KT 01/M02 RMK AO1 SLP117 T00131022 58003",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGH",
       RawData = "CWGH 041600Z AUTO 20011KT 02/M03 RMK AO1 SLP158 T00221031 58013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWGD",
       RawData = "CWGD 041600Z AUTO 17014G20KT 03/M00 RMK AO1 7PAST HR SOG 10 8014 PK WND 15020/1534 SLP116 P0003 T00271002 50031",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWFQ",
       RawData = "CWFQ 041600Z AUTO 18007KT 02/M10 RMK AO1 SOG 32 7014 PK WND 22018/1530 SLP162 T00171095",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWFJ",
       RawData = "CWFJ 041600Z AUTO 16005KT M03/M05 RMK AO1 8007 SLP216 T10321046 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWFF",
       RawData = "CWFF 041600Z AUTO 28006KT M05/M07 RMK AO1 SOG 18 3004 SLP224 T10511073",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEZ",
       RawData = "CWEZ 041600Z AUTO 13010KT 08/05 RMK AO1 SLP162 T00830052 56010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEW",
       RawData = "CWEW 041600Z AUTO 17004KT 01/M07 RMK AO1 SOG 49 8013 SLP158 T00081069",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEU",
       RawData = "CWEU 041600Z 01017G22KT 12SM IC FEW018 FEW100 M24/M27 A2953 RMK SC1AC1 SC TR AC TR SLP017",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWER",
       RawData = "CWER 041600Z AUTO 22016KT RMK AO1 PK WND 22020/1555",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEQ",
       RawData = "CWEQ 041600Z AUTO 34003KT M09/M14 RMK AO1 SOG 40 1012 SLP221 T10881135",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEP",
       RawData = "CWEP 041600Z AUTO M04/M16 RMK AO1 SOG 42 8005 SLP194 T10401158",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEL",
       RawData = "CWEL 041600Z AUTO 13012KT 07/06 RMK AO1 SLP160 T00740059 56007",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEK",
       RawData = "CWEK 041600Z AUTO 06023G28KT 05/02 RMK AO1 PK WND 06028/1513 SLP123 T00530022 56005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEH",
       RawData = "CWEH 041600Z AUTO 02007KT M06/M08 RMK AO1 SOG 08 1010 SLP231 T10561084",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEF",
       RawData = "CWEF 041600Z AUTO 27021KT M06/M11 RMK AO1 PK WND 26026/1522 SLP163 T10581113 51002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEE",
       RawData = "CWEE 041600Z AUTO M03/M05 RMK AO1 SLP090 T10301050 57005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWEB",
       RawData = "CWEB 041600Z AUTO 13013G23KT 07/05 RMK AO1 PK WND 12023/1559 SLP116 T00740053 58019",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDZ",
       RawData = "CWDZ 041600Z AUTO 12007KT M03/M06 RMK AO1 SOG 11 8004 SLP227 T10341056",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDV",
       RawData = "CWDV 041600Z AUTO 04005KT M02/M06 RMK AO1 SOG 52 0013 SLP098 T10241056",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDQ",
       RawData = "CWDQ 041600Z AUTO 18004KT M05/M08 RMK AO1 SOG 49 8016 SLP138 T10491076",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDO",
       RawData = "CWDO 041600Z AUTO 27012G19KT M09/M15 RMK AO1 SOG 16 0006 PK WND 27022/1520 SLP106 T10881151",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDM",
       RawData = "CWDM 041600Z AUTO 24011KT M10/M18 RMK AO1 SOG 40 8011 SLP122 T10951179",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDK",
       RawData = "CWDK 041600Z AUTO 15004KT M06/M07 RMK AO1 SLP223 T10601071 58005",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDJ",
       RawData = "CWDJ 041600Z AUTO 35011KT M07/M10 RMK AO1 SOG 23 1017 SLP238 T10661097",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWDC",
       RawData = "CWDC 041600Z AUTO 08002KT M07/M09 RMK AO1 SOG 75 8003 SLP171 T10741094",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWCT",
       RawData = "CWCT 041600Z AUTO 17005KT M11/M12 RMK AO1 SOG 25 8001 SLP247 T11081124",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWCJ",
       RawData = "CWCJ 041600Z AUTO 08005KT 01/M03 RMK AO1 SOG 51 1011 SLP081 T00101026",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWCI",
       RawData = "CWCI 041600Z AUTO 15010KT 02/M00 RMK AO1 SLP071 T00161004",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWCF",
       RawData = "CWCF 041600Z AUTO 01005KT M06/M09 RMK AO1 SOG 32 1011 SLP180 T10551091",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBZ",
       RawData = "CWBZ 041600Z AUTO 23011G18KT 04/M07 RMK AO1 PK WND 24018/1555 SLP148 T00421071 58013",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBY",
       RawData = "CWBY 041600Z AUTO 25010G15KT M06/M13 RMK AO1 SOG 38 6007 PK WND 23019/1530 SLP133 T10631127",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBV",
       RawData = "CWBV 041600Z AUTO 23016KT M03/M12 RMK AO1 PK WND 23020/1555 SLP206 T10321118 58006",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBU",
       RawData = "CWBU 041600Z AUTO 16005KT M08/M10 RMK AO1 SOG 14 1001 SLP217 T10791102",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBT",
       RawData = "CWBT 041600Z AUTO 25004KT M07/M14 RMK AO1 SLP135 T10721138 56010",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBS",
       RawData = "CWBS 041600Z AUTO 00000KT M02/M08 RMK AO1 T10181076",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBO",
       RawData = "CWBO 041600Z AUTO 17004KT M02/M03 RMK AO1 8001 SLP234 T10231034 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBK",
       RawData = "CWBK 041600Z AUTO 31011KT M04/M12 RMK AO1 SOG 02 8012 SLP202 T10371119",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWBA",
       RawData = "CWBA 041600Z AUTO 15005KT M01/M03 RMK AO1 SOG 49 T10081027 50001",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWAV",
       RawData = "CWAV 041600Z AUTO 26001KT M09/M10 RMK AO1 SOG 04 8009 SLP211 T10881104",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWAR",
       RawData = "CWAR 041600Z AUTO 30017G22KT M06/M12 RMK AO1 PK WND 31022/1556 SLP134 T10561122 58002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWAQ",
       RawData = "CWAQ 041600Z AUTO 34014KT M05/M06 RMK AO1 SOG 03 1017 PK WND 33018/1545 SLP227 T10451058",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CWAF",
       RawData = "CWAF 041600Z AUTO 20027G33KT M03/M05 RMK AO1 PK WND 21033/1551 T10261051",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CTRA",
       RawData = "CTRA 041600Z AUTO 04005KT M03/M06 RMK AO1 SOG 31 3010 SLP118 T10281064",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CTNK",
       RawData = "CTNK 041600Z AUTO 25002KT M01/M03 RMK AO1 SOG 61 6007 SLP129 T10111030 50022",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CTCK",
       RawData = "CTCK 041600Z AUTO 23006KT 01/M04 RMK AO1 SOG 52 8007 PK WND 24020/1529 SLP156 T00091035",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CMGB",
       RawData = "CMGB 041600Z AUTO 21004KT 03/M09 RMK AO1 SOG 46 8016 SLP167 T00291089",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CMFM",
       RawData = "CMFM 041600Z AUTO 23007KT M06/M09 RMK AO1 SOG 106 6012 SLP135 T10571093 50002",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CERM",
       RawData = "CERM 041600Z AUTO 15004KT M07/M13 RMK AO1 SOG 76 8018 SLP165 T10691132",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CBBC",
       RawData = "CBBC 041600Z AUTO 00000KT 9SM 04/04 A2985 RMK CLD MISG SLP112",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "CAHR",
       RawData = "CAHR 041600Z AUTO 23011KT M06/M14 RMK AO1 SOG 132 8006 PK WND 24017/1534 SLP197 T10551135",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIVM",
       RawData = "BIVM 041600Z 24032G44KT 2000 SHSN BKN013 M00/M02 Q0976",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIRK",
       RawData = "BIRK 041600Z 24023KT 1500 SHSN VV006 M01/M04 Q0974",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIIS",
       RawData = "BIIS 041600Z 16005KT 9999 FEW025 FEW045 00/M06 Q0970",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIGR",
       RawData = "BIGR 041600Z 25030G40KT CAVOK 01/M06 Q0970",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIBD",
       RawData = "BIBD 041600Z 19004KT 5000 SHSN FEW016 SCT025 M01/M02 Q0970",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "BIAR",
       RawData = "BIAR 041600Z 19013G24KT 160V250 9999 BKN045 01/M05 Q0974",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "AGGH",
       RawData = "AGGH 041600Z 20002KT 9999 FEW015 SCT100 BKN300 25/24 Q1009 NOSIG",
       LastChange = "2025-03-04T16:00:00Z"
    },
    new Metar {
       Station = "KNZY",
       RawData = "KNZY 041559Z 08004KT 10SM BKN022 BKN033 13/07 A3024 RMK AO2 T01330072",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "KNOZ",
       RawData = "KNOZ 041559Z AUTO 35005KT CLR 14/02 A3018 RMK AO2 SLP170 T01390017 $",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "KNGU",
       RawData = "KNGU 041559Z 21013G19KT 10SM BKN250 16/M03 A3029 RMK AO2 SLP257 T01561028",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "KMWN",
       RawData = "KMWN 041559Z 26040G48KT 60SM FEW005 FEW015 SCT025 SCT040 BKN100 BKN200 M08/M11 RMK SCSL NW ACSL DSNT W-SE BLSN BLO STA NW-NE",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "KCOS",
       RawData = "KCOS 041559Z COR 34034G49KT 10SM FEW025 SCT040 SCT150 03/M04 A2969 RMK AO2 PK WND 34049/1555 T00331044 PNO $",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "K1LW",
       RawData = "K1LW 041559Z 33021G38KT 290V010 7SM -SN BKN012 OVC017 01/M01 A2973 RMK SLP078",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "K1IW",
       RawData = "K1IW 041559Z 01032G43KT 10SM OVC014 02/M01 A2968 RMK SLP057",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "K1FW",
       RawData = "K1FW 041559Z 33026G37KT 10SM OVC014 00/M03 A2974 RMK SLP075",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "K1DW",
       RawData = "K1DW 041559Z 33031G42KT 2 1/4SM -SN BR FEW009 OVC023 M00/M02 A2979 RMK SLP103",
       LastChange = "2025-03-04T15:59:00Z"
    },
    new Metar {
       Station = "PKMR",
       RawData = "PKMR 041558Z 08005KT 15SM FEW015 SCT050 BKN300 28/23 A2984 RMK SLP107 T02760227",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KNFE",
       RawData = "KNFE 041558Z AUTO 19011G16KT 10SM CLR 16/02 A3029 RMK AO2 SLP258 T01610017",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KMRH",
       RawData = "KMRH 041558Z AUTO 13007KT 10SM CLR 18/07 A3032 RMK AO2 SLP269 T01830067",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KMEI",
       RawData = "KMEI 041558Z 16019G26KT 10SM CLR 18/10 A2988 RMK AO2 PK WND 16028/1542 SLP117 T01780100",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KHUA",
       RawData = "KHUA 041558Z 15015G25KT 7SM SCT025 BKN160 BKN250 17/08 A2995 RMK SLPNO RVRNO $",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KBKF",
       RawData = "KBKF 041558Z 01030G36KT 10SM FEW065 SCT100 SCT160 BKN220 04/M02 A2975 RMK AO2A PK WND 01040/40 SLP063 T00441019",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "KBCR",
       RawData = "KBCR 041558Z AUTO 15009G21KT 110V170 10SM BKN038 23/14 A3002 RMK AO2 SLP151 T02280144",
       LastChange = "2025-03-04T15:58:00Z"
    },
    new Metar {
       Station = "PHNG",
       RawData = "PHNG 041557Z COR 06011KT 7SM FEW028 24/18 A3018 RMK AO2 SLP215 FIRST T02390183",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KSUE",
       RawData = "KSUE 041557Z AUTO 14004KT 7SM OVC024 04/04 A2965 RMK AO2 RAE03 SLP044 P0000 T00440039",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KRST",
       RawData = "KRST 041557Z 00000KT 10SM BKN008 BKN028 OVC037 07/04 A2951 RMK AO2 T00720039",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KNYL",
       RawData = "KNYL 041557Z 35004KT 10SM CLR 13/02 A3017 RMK AO2 SLP216 T01330022",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KNJW",
       RawData = "KNJW 041557Z AUTO 14012G20KT 10SM CLR 17/07 A2989 RMK AO2 SLP038 T01670067 $",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KNFL",
       RawData = "KNFL 041557Z 17006KT 10SM FEW070 BKN100 BKN170 03/M03 A3016 RMK AO2 SLP178 T00281028",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KMGE",
       RawData = "KMGE 041557Z 11011KT 10SM BKN023 OVC200 14/07 A3009 RMK AO2A SLP191 T01430069 $",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "KFLG",
       RawData = "KFLG 041557Z 31005KT 10SM CLR 02/M05 A3010 RMK AO2 SLP181 T00171050",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "EQYR",
       RawData = "EQYR 041557Z AUTO 13012KT OVC070 17/12 A2985 RMK AO2 SLP107 T01670117 $",
       LastChange = "2025-03-04T15:57:00Z"
    },
    new Metar {
       Station = "ROTM",
       RawData = "ROTM 041556Z AUTO 34010KT BKN011 BKN019 OVC027 A2998 RMK AO2 CIG 008V014 SLPNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "RJOI",
       RawData = "RJOI 041556Z 31004KT 8000 BR SCT007 BKN020 OVC035 08/06 A2997 RMK AO2 SLP147 T00830061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PMDY",
       RawData = "PMDY 041556Z AUTO 10008KT 10SM FEW018 BKN037 OVC049 20/20 A3025 RMK AO2 SLP244 T02000200",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PHNY",
       RawData = "PHNY 041556Z AUTO 06011KT 10SM CLR 19/17 A3021 RMK AO2 SLP212 T01940167 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFYU",
       RawData = "PFYU 041556Z 00000KT 4SM HZ CLR M23/M26 A2995 RMK AO2 SLP165 T12281256",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFWS",
       RawData = "PFWS 041556Z AUTO 00000KT 10SM OVC065 02/01 A2968 RMK AO2 SLP051 P0292 T00170006 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFTO",
       RawData = "PFTO 041556Z AUTO 00000KT 10SM CLR M07/M09 A2991 RMK AO2 SLP782 T10721094 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFKT",
       RawData = "PFKT 041556Z AUTO 03018G25KT 8SM -SN OVC016 M16/M18 A2983 RMK AO2 PK WND 03027/1509 SLP103 P0000 T11561178 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFKO",
       RawData = "PFKO 041556Z AUTO 00000KT 8SM FEW014 OVC021 M14/M16 A2944 RMK AO2 SLP971 T11441156 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PFCL",
       RawData = "PFCL 041556Z AUTO 10SM FEW044 OVC055 A2965 RMK AO2 RAE42 SLPNO P0000 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAZK",
       RawData = "PAZK 041556Z AUTO 03004KT 10SM CLR M07/M07 A2982 RMK AO2 SLP159 T10671072 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAWS",
       RawData = "PAWS 041556Z AUTO 06008G14KT 10SM CLR 04/M05 A2983 RMK AO2 SLP106 T00441050",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAWG",
       RawData = "PAWG 041556Z 13006KT 10SM FEW060 02/01 A2992 RMK AO2 SLPNO T00220006 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAVD",
       RawData = "PAVD 041556Z VRB05KT 10SM OVC150 M02/M02 A2993 RMK AO2 SLP134 T10171022 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAVA",
       RawData = "PAVA 041556Z AUTO 02005KT 9SM -SN OVC008 M14/M16 A2975 RMK AO2 SLP074 P0000 T11441156 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PATG",
       RawData = "PATG 041556Z AUTO 35006KT 9SM UP BKN021 OVC029 00/ A2963 RMK AO2 UPB03E13B31SNE03B13E31 SLP035 P0000 T0000 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PATE",
       RawData = "PATE 041556Z AUTO 04009KT 9SM -SN OVC012 M17/M19 A2981 RMK AO2 SNB1459 SLP104 P0000 T11671189 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PASX",
       RawData = "PASX 041556Z AUTO 02003KT 10SM CLR 02/M01 A2981 RMK AO2 SLP101 T00171011 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PASH",
       RawData = "PASH 041556Z AUTO 31011KT 9SM -SN OVC025 M18/M19 A2989 RMK AO2 SLP123 P0000 T11781194 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PASD",
       RawData = "PASD 041556Z 31004KT 10SM BKN015 BKN021 01/M01 A2961 RMK AO2 SLP030 T00111011 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PASA",
       RawData = "PASA 041556Z AUTO 36003KT 10SM OVC012 M19/M21 A2991 RMK AO2 SLPNO T11891211 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PARY",
       RawData = "PARY 041556Z AUTO 08011G18KT 10SM OVC070 M03/M08 A2979 RMK AO2 SLP101 T10281083 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PARC",
       RawData = "PARC 041556Z AUTO 02004KT 10SM CLR M16/M17 A2986 RMK AO2 SLP185 T11561172 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAQH",
       RawData = "PAQH 041556Z AUTO 36011KT 6SM -SN BR SCT024 BKN041 BKN100 M09/M11 A2966 RMK AO2 SLP044 P0000 T10941106 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAPO",
       RawData = "PAPO 041556Z AUTO 32016KT 9SM -SN BKN024 OVC070 M18/M19 A2985 RMK AO2 SLP108 P0000 T11781194 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAPG",
       RawData = "PAPG 041556Z 00000KT 10SM OVC060 M02/M02 A2993 RMK AO2 SLP139 T10171017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAPE",
       RawData = "PAPE 041556Z AUTO 35004KT 10SM OVC019 01/00 A2919 RMK AO2 UPE12 SLP881 P0000 T00110000 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PANW",
       RawData = "PANW 041556Z AUTO 10010KT 10SM OVC060 03/00 A2969 RMK AO2 SLP061 T00280000",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PANI",
       RawData = "PANI 041556Z AUTO 19003KT 10SM FEW029 OVC060 M03/M04 A2965 RMK AO2 SNB13E48 SLP043 P0000 T10331044 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PANA",
       RawData = "PANA 041556Z AUTO 35005KT 3SM -SN BR SCT044 BKN050 OVC070 M12/M13 A2969 RMK AO2 SLP052 P0000 T11171133 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAMY",
       RawData = "PAMY 041556Z AUTO 32006KT 9SM -SN OVC009 M13/M15 A2972 RMK AO2 SLP064 P0000 T11331150 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAMM",
       RawData = "PAMM 041556Z AUTO 16003KT 10SM OVC041 07/M01 A2991 RMK AO2 SLP118 T00721006 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAMH",
       RawData = "PAMH 041556Z AUTO 00000KT 10SM CLR M11/M11 A2981 RMK AO2 SLP102 T11061111 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAMD",
       RawData = "PAMD 041556Z AUTO 11019KT 10SM OVC017 05/03 A2979 RMK AO2 SLP088 T00500028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAMB",
       RawData = "PAMB 041556Z AUTO 13005KT 10SM -RA FEW028 OVC038 02/01 A2965 RMK AO2 SLP045 P0001 T00170011 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PALG",
       RawData = "PALG 041556Z AUTO 00000KT 9SM -SN SCT008 OVC038 M06/M07 A2967 RMK AO2 SLP047 P0000 T10561072 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAKP",
       RawData = "PAKP 041556Z AUTO 19009KT 10SM FEW120 M08/M09 A2979 RMK AO2 SLP140 T10781094 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAKH",
       RawData = "PAKH 041556Z AUTO 10004KT 10SM -RA BKN026 OVC032 A2964 RMK AO2 RAB50 SLPNO FZRANO PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAKF",
       RawData = "PAKF 041556Z AUTO 20006KT 10SM OVC026 M01/M04 A2958 RMK AO2 SLP016 T10061044 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAJZ",
       RawData = "PAJZ 041556Z AUTO 13015KT 7SM BKN065 OVC085 03/00 A2974 RMK AO2 SLP070 T00280000",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAIN",
       RawData = "PAIN 041556Z AUTO 00000KT 10SM CLR M04/M07 A2985 RMK AO2 SLP134 T10441072 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAIK",
       RawData = "PAIK 041556Z AUTO 19006KT 1 1/4SM -SN BR OVC017 M11/M12 A2982 RMK AO2 SLP103 P0000 T11111122 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAII",
       RawData = "PAII 041556Z AUTO 13011KT 10SM FEW037 OVC049 04/02 A2967 RMK AO2 SLP046 T00390017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAIG",
       RawData = "PAIG 041556Z AUTO 07010G16KT 10SM OVC070 04/00 A2970 RMK AO2 SLP067 T00440000",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAHL",
       RawData = "PAHL 041556Z AUTO 07006KT 9SM -SN FEW027 BKN034 OVC060 M01/M05 A2980 RMK AO2 UPB11E13B42E45SNB13E42B45 SLP094 P0000 T10061050 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAHC",
       RawData = "PAHC 041556Z AUTO 24003KT 10SM FEW026 OVC033 M02/M03 A2966 RMK AO2 UPE30 SLP047 P0000 T10221028 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAGM",
       RawData = "PAGM 041556Z AUTO 01022G26KT 9SM CLR M17/M19 A2991 RMK AO2 PK WND 01029/1500 SLP134 T11671194 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAGL",
       RawData = "PAGL 041556Z AUTO 34007KT 6SM -SN BR BKN040 BKN055 OVC075 M12/M13 A2974 RMK AO2 SLP068 P0000 T11171133 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAGA",
       RawData = "PAGA 041556Z AUTO 11005KT 10SM OVC070 00/M06 A2978 RMK AO2 SLP087 T00001056 FZRANO TSNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAFE",
       RawData = "PAFE 041556Z AUTO 00000KT 10SM CLR M01/M01 A2994 RMK AO2 SLP148 T10111011 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAEM",
       RawData = "PAEM 041556Z AUTO 00000KT 9SM OVC005 M13/M14 A2973 RMK AO2 SNE18B42E52 SLP066 P0000 T11331144 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PADU",
       RawData = "PADU 041556Z 12015G22KT 6SM -SN BR BKN027 OVC035 01/M03 A2946 RMK AO2 RAB21E40SNB40 SLP976 P0000 T00061033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PADM",
       RawData = "PADM 041556Z AUTO 5SM -SN BR BKN055 OVC070 M10/M12 A2972 RMK AO2 SLP073 P0000 T11001117 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PADL",
       RawData = "PADL 041556Z AUTO 07005KT 10SM -RA BKN036 OVC050 02/02 A2967 RMK AO2 SLP050 P0000 T00220022 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PACX",
       RawData = "PACX 041556Z AUTO 05007KT 10SM CLR M08/M11 A2989 RMK AO2 SLP750 T10831106 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PABV",
       RawData = "PABV 041556Z AUTO 20003KT 10SM CLR M02/M03 A2985 RMK AO2 SLP108 T10171033 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PABL",
       RawData = "PABL 041556Z AUTO 32011KT 2SM -SN BR OVC019 M15/M17 A2983 RMK AO2 SLP103 P0000 T11501172 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PABA",
       RawData = "PABA 041556Z AUTO 08016KT 10SM CLR M19/M21 A2993 RMK AO2 SLP154 T11891211 FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "PAAK",
       RawData = "PAAK 041556Z AUTO 00000KT 10SM BKN030 BKN048 M01/M02 A2924 RMK AO2 SLP901 T10061022 FZRANO TSNO PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "MMUN",
       RawData = "MMUN 041556Z 13013KT 7SM SCT015 29/19 A2996 RMK 8/500 CU Y CI",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KY50",
       RawData = "KY50 041556Z AUTO 11004KT 10SM OVC047 06/04 A2960 RMK AO2 SLP029 T00610039 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KWWD",
       RawData = "KWWD 041556Z AUTO 18014KT 10SM OVC085 08/04 A3026 RMK AO2 SLP250 T00830039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KWVL",
       RawData = "KWVL 041556Z AUTO VRB05KT 10SM FEW070 OVC095 00/M13 A3007 RMK AO2 SLP216 T00001128 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KWMC",
       RawData = "KWMC 041556Z AUTO A3013 RMK AO2 SLPNO PWINO FZRANO TSNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KWJF",
       RawData = "KWJF 041556Z 00000KT 10SM CLR 06/00 A3020 RMK AO2 SLP233 T00610000 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KVPZ",
       RawData = "KVPZ 041556Z AUTO 17009KT 7SM RA FEW040 OVC080 06/04 A2977 RMK AO2 LTG DSNT S SLP085 P0016 T00560039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KVIS",
       RawData = "KVIS 041556Z AUTO 23003KT 10SM FEW045 08/06 A3028 RMK AO2 SLP255 T00830061 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KUDG",
       RawData = "KUDG 041556Z AUTO 12009KT 10SM BKN050 OVC060 16/06 A3024 RMK AO2 SLP242 T01560056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KUCP",
       RawData = "KUCP 041556Z AUTO VRB06KT 10SM OVC110 12/M08 A3000 RMK AO2 SLP179 T01171083",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KTVF",
       RawData = "KTVF 041556Z AUTO 35014KT 10SM BKN012 OVC017 M02/M04 A2987 RMK AO2 SLP131 T10171039 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KTPH",
       RawData = "KTPH 041556Z AUTO 06004KT 10SM CLR 00/M06 A3019 RMK AO2 SLP226 T00001061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSXT",
       RawData = "KSXT 041556Z AUTO 19008G18KT 1/4SM FG BKN005 OVC011 01/01 A3009 RMK AO2 RAB23E49 SLP205 P0001 T00110011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSRC",
       RawData = "KSRC 041556Z AUTO 14015G25KT 10SM -RA OVC021 14/12 A2954 RMK AO2 RAB44 SLP000 P0000 T01390117",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSQI",
       RawData = "KSQI 041556Z AUTO 13012G18KT 10SM OVC031 07/06 A2964 RMK AO2 SLP037 T00720056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSOP",
       RawData = "KSOP 041556Z AUTO 17008KT SCT050 BKN060 15/04 A3026 RMK AO2 SLP251 T01500039 PWINO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSMP",
       RawData = "KSMP 041556Z AUTO 00000KT 10SM BKN120 01/01 A2997 RMK AO2 SLP790 T00060006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSMN",
       RawData = "KSMN 041556Z AUTO 00000KT 10SM OVC065 00/M02 A3009 RMK AO2 SLP210 T00001022 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSLE",
       RawData = "KSLE 041556Z COR 18006KT 2 1/2SM -RA BKN012 BKN046 OVC060 07/06 A3007 RMK AO2 RAB06 SLP182 P0003 T00720061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSKX",
       RawData = "KSKX 041556Z AUTO VRB04KT 10SM CLR M02/M04 A2984 RMK AO2 SLP129 T10171044 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSGU",
       RawData = "KSGU 041556Z AUTO 00000KT 10SM CLR 05/M01 A3014 RMK AO2 SLP212 T00501006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSGJ",
       RawData = "KSGJ 041556Z 14011KT 10SM OVC036 22/16 A3018 RMK AO2 SLP217 T02170156 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSGH",
       RawData = "KSGH 041556Z AUTO 20016G21KT 10SM CLR 11/M03 A2989 RMK AO2 SLP129 T01111033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSFZ",
       RawData = "KSFZ 041556Z AUTO 20009G14KT 160V230 10SM OVC075 05/M07 A3021 RMK AO2 SLP234 T00501067 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSFO",
       RawData = "KSFO 041556Z 16006KT 10SM FEW006 BKN070 BKN095 11/07 A3025 RMK AO2 SLP245 T01060072",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSFM",
       RawData = "KSFM 041556Z AUTO 23007KT 10SM CLR 03/M09 A3013 RMK AO2 SLP210 T00331089",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSDY",
       RawData = "KSDY 041556Z AUTO 34013KT 9SM -SN FEW016 BKN043 OVC060 M02/M04 A3008 RMK AO2 SLP215 P0000 T10171044 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSDF",
       RawData = "KSDF 041556Z 18012G27KT 10SM SCT070 17/M06 A2988 RMK AO2 PK WND 18027/1523 SLP117 T01721061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KSBP",
       RawData = "KSBP 041556Z 32008KT 10SM CLR 10/08 A3026 RMK AO2 SLP249 T01000078",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KRUT",
       RawData = "KRUT 041556Z AUTO 15004KT 10SM OVC070 03/M10 A3008 RMK AO2 SLP189 T00331100 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KRKD",
       RawData = "KRKD 041556Z AUTO 23010G17KT 10SM BKN080 02/M07 A3014 RMK AO2 SLP207 T00221067 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KRDM",
       RawData = "KRDM 041556Z 17008KT 10SM BKN075 OVC090 03/M01 A3004 RMK AO2 SLP184 T00331011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPWG",
       RawData = "KPWG 041556Z AUTO 26013G19KT 10SM CLR A2957 RMK AO2 SLPNO FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPVC",
       RawData = "KPVC 041556Z AUTO 22015G20KT 10SM FEW075 06/M02 A3023 RMK AO2 SLP235 T00611017 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPTV",
       RawData = "KPTV 041556Z AUTO 12006KT 10SM OVC046 09/06 A3027 RMK AO2 SLP251 T00940056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPTN",
       RawData = "KPTN 041556Z AUTO 14015G23KT 10SM FEW023 BKN031 OVC060 23/19 A2975 RMK AO2 PK WND 15026/1546 SLP075 T02280189 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPRX",
       RawData = "KPRX 041556Z AUTO 18006KT SCT007 SCT090 12/12 A2947 RMK AO2 SLP976 P0002 T01220117 PWINO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPQI",
       RawData = "KPQI 041556Z AUTO 15008KT 10SM OVC027 M06/M12 A3000 RMK AO2 SLP199 T10561122",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KPIB",
       RawData = "KPIB 041556Z AUTO 14011KT 10SM BKN021 OVC031 18/11 A2989 RMK AO2 SLP121 T01780111 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KP53",
       RawData = "KP53 041556Z AUTO 19004KT 03/01 A2966 RMK AO1 SLP051 T00280006 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KP28",
       RawData = "KP28 041556Z AUTO 27009KT 13/01 A2927 RMK AO1 SLP906 T01280006 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KOXC",
       RawData = "KOXC 041556Z VRB05G16KT 10SM CLR 04/M03 A3019 RMK AO2 SLP242 T00441033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KOWB",
       RawData = "KOWB 041556Z 17023G27KT 10SM CLR 16/M02 A2980 RMK AO2 PK WND 17029/1525 SLP092 T01611017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KOKK",
       RawData = "KOKK 041556Z AUTO 34004KT 10SM OVC070 09/03 A2981 RMK AO2 RAB11E36 SLP098 P0000 T00940028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KOAJ",
       RawData = "KOAJ 041556Z 19009KT 140V220 10SM SCT050 19/07 A3029 RMK AO2 SLP261 T01890067",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNYG",
       RawData = "KNYG 041556Z 16012KT 7SM BKN100 11/ A3022 RMK AO2 SLP235 T0106 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNUC",
       RawData = "KNUC 041556Z 31004KT 10SM BKN011 BKN250 13/11 A3023 RMK AO2 SLP236 T01280111 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNTU",
       RawData = "KNTU 041556Z 20006KT 10SM BKN250 15/M02 A3028 RMK AO2 SLP256 T01501022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNSE",
       RawData = "KNSE 041556Z 14011G21KT 10SM BKN015 OVC030 19/15 A2997 RMK AO2 SLP135 T01890150 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNOG",
       RawData = "KNOG 041556Z AUTO 32024G32KT 10SM CLR 24/M01 A2973 RMK AO2 PK WND 28041/1457 WSHFT 1451 SLP047 T02391006 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNMM",
       RawData = "KNMM 041556Z 14008G16KT 10SM FEW070 SCT240 16/08 A2990 RMK AO2 SLP135 T01610078 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNLC",
       RawData = "KNLC 041556Z 32003KT 10SM FEW170 SCT240 08/04 A3028 RMK AO2 SLP255 RH/73 T00830039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNJK",
       RawData = "KNJK 041556Z 28006KT 10SM FEW065 15/03 A3018 RMK AO2 SLP234 T01500028 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNID",
       RawData = "KNID 041556Z COR 00000KT 10SM FEW300 07/M03 A3020 RMK AO2 SLP232 T00671033 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNDZ",
       RawData = "KNDZ 041556Z 15012G20KT 10SM OVC016 19/16 A2997 RMK AO2 SLP136 T01890156 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNCA",
       RawData = "KNCA 041556Z 18012G18KT 10SM SCT055 17/06 A3029 RMK AO2 SLP260 T01720061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KNBC",
       RawData = "KNBC 041556Z 16012G18KT 7SM BKN041 BKN250 19/12 A3021 RMK AO2 SLP229 T01940117",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMYR",
       RawData = "KMYR 041556Z 12007KT 10SM CLR 17/11 A3027 RMK AO2 SLP251 T01720106",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMVN",
       RawData = "KMVN 041556Z AUTO 19019G25KT 10SM CLR 16/02 A2974 RMK AO2 PK WND 20028/1527 SLP073 T01610022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMTW",
       RawData = "KMTW 041556Z AUTO 17008KT 10SM OVC050 04/03 A2966 RMK AO2 SLP047 T00440028 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMQY",
       RawData = "KMQY 041556Z 16013G21KT 10SM CLR 17/05 A2994 RMK AO2 SLP145 T01720050",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMOB",
       RawData = "KMOB 041556Z 14018G31KT 7SM BKN023 OVC220 20/14 A2993 RMK AO2 PK WND 14031/1554 SLP133 T02000144",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMML",
       RawData = "KMML 041556Z AUTO 35020G25KT 8SM -RA OVC004 01/ A2959 RMK AO2 UPB15E22RAB22 SLP031 P0000 T0011 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMKT",
       RawData = "KMKT 041556Z AUTO 33008KT 10SM OVC024 06/03 A2956 RMK AO2 SLP014 T00610033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMJX",
       RawData = "KMJX 041556Z AUTO 22013G17KT 10SM OVC075 11/01 A3024 RMK AO2 SLP244 T01060006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMHS",
       RawData = "KMHS 041556Z AUTO 11003KT 10SM FEW027 BKN036 OVC050 04/03 A3016 RMK AO2 SLP238 T00440028 PNO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMEH",
       RawData = "KMEH 041556Z AUTO 00000KT 10SM CLR M02/M03 A3003 RMK AO2 SLP193 T10221033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMDT",
       RawData = "KMDT 041556Z 13006KT 10SM SCT075 BKN250 07/M04 A3017 RMK AO2 SLP218 T00721039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KMBL",
       RawData = "KMBL 041556Z AUTO 11005KT 10SM BKN035 BKN043 OVC055 04/03 A2968 RMK AO2 SLP055 T00440028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLZU",
       RawData = "KLZU 041556Z 08009KT 10SM BKN027 OVC055 11/04 A3014 RMK AO2 SLP220 T01110044",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLWS",
       RawData = "KLWS 041556Z 11003KT 10SM OVC100 06/03 A3009 RMK AO2 SLP193 T00610028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLRD",
       RawData = "KLRD 041556Z 34023G29KT 7SM OVC032 23/M06 A2975 RMK AO2 PK WND 36029/1551 SLP071 T02281061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLGD",
       RawData = "KLGD 041556Z AUTO 00000KT 10SM CLR 01/01 A3009 RMK AO2 SLP209 T00060006 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLEW",
       RawData = "KLEW 041556Z AUTO 00000KT 10SM CLR M01/M11 A3011 RMK AO2 SLP209 T10111106 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLCI",
       RawData = "KLCI 041556Z AUTO 26007KT 10SM CLR 01/M11 A3011 RMK AO2 SLP206 T00061106 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLBT",
       RawData = "KLBT 041556Z AUTO 16009G18KT 10SM SCT048 OVC060 17/07 A3024 RMK AO2 SLP241 T01720072",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLBL",
       RawData = "KLBL 041556Z AUTO 35032G39KT 9SM OVC022 06/02 A2941 RMK AO2 PK WND 35039/1553 RAB07E55 SLP952 P0000 T00610017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KLAS",
       RawData = "KLAS 041556Z 19004KT 10SM SCT250 12/M03 A3015 RMK AO2 SLP206 T01171033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KKLS",
       RawData = "KKLS 041556Z AUTO 14006KT 10SM BKN025 OVC041 08/06 A3006 RMK AO2 SLP182 T00780061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJXN",
       RawData = "KJXN 041556Z 18014G23KT 8SM -RA FEW018 BKN070 OVC085 05/03 A2981 RMK AO2 RAB27 SLP102 P0001 T00500028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJRB",
       RawData = "KJRB 041556Z AUTO 21009KT 10SM OVC080 06/M01 A3024 RMK AO2 SLP240 T00611006 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJMS",
       RawData = "KJMS 041556Z AUTO 36022G26KT 10SM OVC007 M02/M03 A2989 RMK AO2 PK WND 01028/1457 CIG 006V009 SLP142 T10171028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJHW",
       RawData = "KJHW 041556Z AUTO 18006KT 10SM BKN065 OVC095 06/M09 A2999 RMK AO2 SLP172 T00611089",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJAX",
       RawData = "KJAX 041556Z 12017G26KT 10SM FEW014 BKN035 BKN250 24/13 A3014 RMK AO2 PK WND 12026/1555 SLP206 T02390133",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KJAC",
       RawData = "KJAC 041556Z 00000KT 10SM CLR M02/M03 A3002 RMK AO2 SLP199 T10221028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KITH",
       RawData = "KITH 041556Z 16010KT 10SM OVC055 03/M07 A3005 RMK AO2 RAB11E26 SLP187 P0000 T00331072",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KISP",
       RawData = "KISP 041556Z 21017G24KT 10SM FEW020 FEW085 SCT200 BKN250 07/01 A3024 RMK AO2 SLP242 T00720011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KISO",
       RawData = "KISO 041556Z 18010KT 10SM BKN050 17/03 A3030",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KISM",
       RawData = "KISM 041556Z 15014KT 10SM BKN035 OVC043 24/15 A3014 RMK AO2 SLP206 T02440150 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KINW",
       RawData = "KINW 041556Z AUTO 01003KT 10SM CLR 06/M04 A3010 RMK AO2 SLP186 T00561039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KILE",
       RawData = "KILE 041556Z AUTO 27017G25KT 10SM CLR 17/M01 A2960 RMK AO2 PK WND 27027/1530 SLP014 T01671006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHYI",
       RawData = "KHYI 041556Z 29021G28KT 19/00 A2965 RMK AO2 PK WND 29028/1547 SLP036 T01940000 PWINO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHYA",
       RawData = "KHYA 041556Z 24022G29KT 10SM OVC080 06/M03 A3022 RMK AO2 PK WND 23029/1552 SLP236 T00561028",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHWV",
       RawData = "KHWV 041556Z AUTO 21014G23KT 10SM FEW085 07/01 A3026 RMK AO2 SLP247 T00670006 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHPN",
       RawData = "KHPN 041556Z 18009G15KT 10SM SCT100 07/M02 A3019 RMK AO2 SLP231 T00671017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHND",
       RawData = "KHND 041556Z 21005KT 10SM CLR 10/M03 A3016 RMK AO2 SLP228 T01001028 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHNB",
       RawData = "KHNB 041556Z AUTO 17019G25KT 10SM BKN065 15/M02 A2982 RMK AO2 PK WND 18029/1533 SLP097 T01501022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHEZ",
       RawData = "KHEZ 041556Z AUTO 15020G28KT 10SM OVC020 19/15 A2966 RMK AO2 PK WND 14035/1513 SLP041 T01940150",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHEF",
       RawData = "KHEF 041556Z 21006KT 10SM SCT080 11/M04 A3020 RMK AO2 SLP234 T01111039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KHDN",
       RawData = "KHDN 041556Z AUTO 28009KT 10SM UP OVC010 01/M01 A2993 RMK AO2 UPB21 CIG 008V014 SLP142 P0000 T00061006 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGXY",
       RawData = "KGXY 041556Z 35030G35KT 10SM FEW110 05/M04 A2980 RMK AO2 PK WND 35038/1540 SLP101 T00501039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGVQ",
       RawData = "KGVQ 041556Z AUTO 23007G14KT 10SM OVC070 09/M07 A2997 RMK AO2 SLP152 T00891072",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGUC",
       RawData = "KGUC 041556Z AUTO 25018KT 10SM CLR M01/M05 A2986 RMK AO2 SLP129 T10111050 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGTU",
       RawData = "KGTU 041556Z 26019G31KT 10SM CLR 18/01 A2961 RMK AO2 PK WND 26031/1553 SLP023 T01780006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGTR",
       RawData = "KGTR 041556Z 16015KT 10SM CLR 16/06 A2990 RMK AO2 SLP124 T01610056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGRD",
       RawData = "KGRD 041556Z AUTO 12005KT 10SM FEW043 14/06 A3021 RMK AO2 SLP230 T01390061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGPZ",
       RawData = "KGPZ 041556Z AUTO 01013G17KT 10SM CLR 02/M03 A2968 RMK AO2 SLP069 T00171033 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGON",
       RawData = "KGON 041556Z 21009KT 10SM OVC080 05/M01 A3025 RMK AO2 SLP242 T00501006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGNR",
       RawData = "KGNR 041556Z AUTO VRB04KT M03/M11 A2997 RMK AO1 SLP174 T10281106",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGNA",
       RawData = "KGNA 041556Z AUTO 07009G17KT 05/M03 A2969 RMK AO1 SLP065 T00501033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGBD",
       RawData = "KGBD 041556Z AUTO 33017G24KT 10SM CLR 07/M02 A2927 RMK AO2 SLP907 T00721022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGAI",
       RawData = "KGAI 041556Z AUTO 21007KT 10SM BKN080 10/M05 A3019 RMK AO2 SLP242 T01001050 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KGAD",
       RawData = "KGAD 041556Z AUTO 13009KT 10SM OVC026 16/10 A3004 RMK AO2 SLP177 T01560100 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFSD",
       RawData = "KFSD 041556Z 02019G30KT 5SM -RA BR OVC008 03/01 A2952 RMK AO2 PK WND 01030/1553 DZE25RAB48 SLP005 P0000 T00280011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFOD",
       RawData = "KFOD 041556Z AUTO 13005KT 10SM OVC015 10/09 A2944 RMK AO2 SLP982 T01000089",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFNL",
       RawData = "KFNL 041556Z 34025G31KT 10SM CLR 06/M06 A2982 RMK AO2 PK WND 34033/1538 SLP079 T00611056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFKL",
       RawData = "KFKL 041556Z AUTO 21008KT 10SM BKN090 11/M08 A3000 RMK AO2 SLP169 T01061078",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFCI",
       RawData = "KFCI 041556Z AUTO 19012KT 10SM CLR 13/M02 A3026 RMK AO2 SLP258 T01281017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KFAM",
       RawData = "KFAM 041556Z AUTO 17020G31KT 10SM CLR 14/02 A2961 RMK AO2 PK WND 17032/1533 SLP033 T01390022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEWK",
       RawData = "KEWK 041556Z AUTO 18007KT 10SM CLR 12/10 A2927 RMK AO2 SLP906 T01170100",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEUL",
       RawData = "KEUL 041556Z AUTO 07004KT 10SM CLR 04/01 A3012 RMK AO2 SLP209 T00390011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KENV",
       RawData = "KENV 041556Z AUTO 31015KT 10SM OVC070 07/M03 A3014 RMK AO2 SLP211 T00721033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KELZ",
       RawData = "KELZ 041556Z AUTO 22009G16KT 10SM OVC065 06/M12 A3001 RMK AO2 SLP179 T00611117",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEKY",
       RawData = "KEKY 041556Z AUTO 10SM CLR RMK AO2 SLPNO FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEKQ",
       RawData = "KEKQ 041556Z AUTO 17016G25KT 10SM SCT110 14/M03 A3000 RMK AO2 SLP159 T01441033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEKO",
       RawData = "KEKO 041556Z AUTO 22003KT 10SM CLR 02/M01 A3013 RMK AO2 SLP213 T00171006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEHR",
       RawData = "KEHR 041556Z AUTO 17017G26KT 10SM FEW095 17/M01 A2977 RMK AO2 PK WND 17029/1544 SLP081 T01671006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEGE",
       RawData = "KEGE 041556Z 14004KT 9SM -SN FEW040 BKN065 01/M01 A2992 RMK AO2 SLP129 P0001 T00111011",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEEN",
       RawData = "KEEN 041556Z AUTO 30003KT 10SM OVC080 M01/M08 A3014 RMK AO2 SLP216 T10061083 FZRANO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEED",
       RawData = "KEED 041556Z AUTO 10004KT 10SM CLR 13/M02 A3015 RMK AO2 SLP196 T01281022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEAU",
       RawData = "KEAU 041556Z 00000KT 5SM BR BKN006 OVC033 06/04 A2954 RMK AO2 SLP009 T00560044",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KEAR",
       RawData = "KEAR 041556Z AUTO 35030G38KT 10SM OVC008 03/02 A2940 RMK AO2 PK WND 35042/1542 SLP960 T00330022",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDYR",
       RawData = "KDYR 041556Z AUTO 14020G25KT 10SM CLR 14/M01 A2972 RMK AO2 PK WND 15030/1505 PRESFR SLP070 T01441006",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDWU",
       RawData = "KDWU 041556Z AUTO 08003KT CLR 12/M04 A3002 RMK AO2 SLP168 T01171044 PWINO RVRNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDVL",
       RawData = "KDVL 041556Z AUTO 01020G24KT 10SM OVC010 M04/M07 A2998 RMK AO2 SNE42 SLP178 P0000 T10441067 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDUG",
       RawData = "KDUG 041556Z AUTO 28004KT 10SM CLR 06/M06 A3016 RMK AO2 SLP197 T00611056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDIJ",
       RawData = "KDIJ 041556Z AUTO 00000KT 10SM OVC030 M03/M04 A3006 RMK AO2 SLP209 T10331039 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KDAY",
       RawData = "KDAY 041556Z 19017G26KT 10SM SCT050 BKN100 13/M05 A2988 RMK AO2 PK WND 19030/1541 SLP119 T01331050",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KD07",
       RawData = "KD07 041556Z AUTO 35018G26KT M01/M02 A2992 RMK AO1 PK WND 35026/1555 SLP155 P0001 T10061017 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCXY",
       RawData = "KCXY 041556Z 09007KT 10SM SCT100 08/M04 A3017 RMK AO2 SLP219 T00781044",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCWI",
       RawData = "KCWI 041556Z AUTO 14013KT 10SM BKN027 OVC037 08/06 A2959 RMK AO2 SLP024 T00830056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCVN",
       RawData = "KCVN 041556Z AUTO 33029G39KT 10SM SCT045 OVC060 07/02 A2959 RMK AO2 PK WND 33039/1551 RAE10B30E41 SLP013 P0001 T00720017",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCOE",
       RawData = "KCOE 041556Z AUTO 00000KT 10SM FEW022 BKN030 OVC085 01/01 A3009 RMK AO2 SLP221 T00110011 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCOD",
       RawData = "KCOD 041556Z AUTO 35009KT 10SM OVC018 M03/M05 A3009 RMK AO2 SLP218 T10281050 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCIU",
       RawData = "KCIU 041556Z AUTO 13006KT 5SM -RA BR BKN033 OVC055 01/00 A2974 RMK AO2 SLP081 P0001 T00110000 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCHS",
       RawData = "KCHS 041556Z 12017G21KT 10SM FEW045 BKN250 22/09 A3023 RMK AO2 SLP234 T02170094",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCEF",
       RawData = "KCEF 041556Z 21010KT 10SM OVC080 03/M08 A3015 RMK SLP216 T00311083",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KCAE",
       RawData = "KCAE 041556Z 14007KT 10SM BKN060 BKN200 15/07 A3021 RMK AO2 SLP231 T01500067",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBZN",
       RawData = "KBZN 041556Z 19003KT 10SM FEW020 BKN050 OVC060 M02/M04 A3011 RMK AO2 SNB15E38 SLP228 P0000 T10171039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBTP",
       RawData = "KBTP 041556Z AUTO 23010G17KT 10SM CLR 14/M08 A3002 RMK AO2 SLP178 T01391078",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBMI",
       RawData = "KBMI 041556Z 19018KT 7SM VCTS +RA FEW027 BKN065 OVC090 07/07 A2969 RMK AO2 LTG DSNT ALQDS TSB01RAE02B53 SLP055 P0018 T00720067",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBLM",
       RawData = "KBLM 041556Z AUTO 19010G16KT 10SM BKN075 10/00 A3023 RMK AO2 SLP239 T01000000",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBKX",
       RawData = "KBKX 041556Z AUTO 35021G26KT 10SM UP OVC008 00/M02 A2962 RMK AO2 PK WND 36026/1555 UPB17RAB29E38 SLP051 P0000 T00001017 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBJJ",
       RawData = "KBJJ 041556Z AUTO 20011KT 10SM OVC090 09/M06 A2996 RMK AO2 SLP150 T00891056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBIH",
       RawData = "KBIH 041556Z AUTO 30003KT 10SM CLR 04/M04 A3017 RMK AO2 SLP207 T00391039",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBID",
       RawData = "KBID 041556Z AUTO 22013KT 10SM OVC080 04/M02 A3026 RMK AO2 SLP250 T00441017 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KBHB",
       RawData = "KBHB 041556Z AUTO 20011KT 10SM OVC075 00/M07 A3015 RMK AO2 SLP210 T00001067 FZRANO",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KAWO",
       RawData = "KAWO 041556Z AUTO 00000KT 10SM BKN046 07/05 A3004 RMK AO2 SLP179 T00670050",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KAUO",
       RawData = "KAUO 041556Z AUTO 15013G20KT 10SM OVC020 17/12 A3006 RMK AO2 SLP172 T01670117",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KASH",
       RawData = "KASH 041556Z VRB06KT 10SM OVC080 04/M08 A3015 RMK AO2 SLP213 T00391083",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KART",
       RawData = "KART 041556Z AUTO 20010G18KT 10SM -RA OVC050 03/M06 A3001 RMK AO2 RAB52 SLP165 P0000 T00331056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KARG",
       RawData = "KARG 041556Z AUTO 15017KT 10SM OVC070 15/06 A2962 RMK AO2 PK WND 14027/1507 SLP031 T01500061",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KALK",
       RawData = "KALK 041556Z AUTO 30007KT 10SM CLR 06/M06 A3018 RMK AO2 SLP184 T00611056",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KAJO",
       RawData = "KAJO 041556Z AUTO 09003KT 10SM CLR 10/06 A3027 RMK AO2 SLP249 T01000056 PNO $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "KAFJ",
       RawData = "KAFJ 041556Z AUTO 20009KT 10SM FEW120 13/M09 A3005 RMK AO2 SLP179 T01281089 $",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "K8D3",
       RawData = "K8D3 041556Z AUTO 35020G30KT M01/M03 A2977 RMK AO1 PK WND 36034/1500 SLP096 T10061033",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "K2WX",
       RawData = "K2WX 041556Z AUTO 34020KT M01/M05 A2998 RMK AO1 PK WND 34027/1542 SLP176 T10111050",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "K1M4",
       RawData = "K1M4 041556Z AUTO 15015G22KT 10SM CLR 14/07 A2994 RMK AO2 SLP898 T01440072",
       LastChange = "2025-03-04T15:56:00Z"
    },
    new Metar {
       Station = "TXKF",
       RawData = "TXKF 041555Z 03011KT 360V060 9999 VCSH SCT033 BKN045 15/07 Q1027",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "TNCE",
       RawData = "TNCE 041555Z AUTO 09011KT 050V120 //// // ///////// 28/22 Q1015 RE//",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "TNCB",
       RawData = "TNCB 041555Z 10013KT 070V130 9999 BKN018 BKN022 30/23 Q1013",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "RKSO",
       RawData = "RKSO 041555Z 04003KT 9SM OVC070 04/M01 A3020 RMK AO2A SLP231 T00371015 FZRANO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "RKSG",
       RawData = "RKSG 041555Z AUTO 00000KT 10SM OVC065 03/M01 A3015 RMK AO2 SLP213 T00311011 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "RKJK",
       RawData = "RKJK 041555Z 06004KT 8SM SCT065 05/00 A3011 RMK AO2A SLPNO T00450001 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "RJTY",
       RawData = "RJTY 041555Z 34010KT 5SM -RASN OVC023 02/00 A3022 RMK AO2A SNB1455E40RAB45 SLP241 P0004 T00170001 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PWAK",
       RawData = "PWAK 041555Z AUTO 09006KT 10SM SCT021 SCT065 SCT120 26/23 A2998 RMK AO2 RAB1455E00 SLP155 P0000 T02560227",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PHSF",
       RawData = "PHSF 041555Z AUTO 10012G25KT 10SM CLR 10/09 A3043 RMK AO2 SLP205 T01010085 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PHHI",
       RawData = "PHHI 041555Z AUTO 08007KT 10SM BKN033 OVC046 22/17 A3021 RMK AO2 RAB04E09 SLP221 P0000 T02220169 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PATL",
       RawData = "PATL 041555Z AUTO VRB03KT 10SM BKN150 BKN250 00/M04 A2976 RMK AO2 SLP091 T10041039",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PATC",
       RawData = "PATC 041555Z 01023G29KT 1 1/2SM BLSN OVC010 M17/ RMK AO2A SLPNO ALL DATA ESTMD",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PASY",
       RawData = "PASY 041555Z 08017G24KT 10SM FEW029 BKN050 02/M01 A2890 RMK SLP786 ALSTG/SLP ESTMD WND DATA ESTMD T00241009 PNO FZRANO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PALP",
       RawData = "PALP 041555Z 09021KT 8SM FEW003 BKN070 M17/M19 A2990",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PAIM",
       RawData = "PAIM 041555Z AUTO 00000KT 10SM SCT065 BKN190 M05/M08 A2982 RMK AO2 SLP121 T10551084",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PAFR",
       RawData = "PAFR 041555Z AUTO 00000KT 10SM SCT140 M01/M03 A2981 RMK AO2 SLP100 T10091026 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PAFB",
       RawData = "PAFB 041555Z 00000KT 10SM FEW150 M15/M17 A2986 RMK AO2A SLP125 T11471168 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PAEI",
       RawData = "PAEI 041555Z 00000KT 10SM FEW200 M13/M15 A2984 RMK AO2A SLP117 T11261151 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PAED",
       RawData = "PAED 041555Z 00000KT 10SM SCT120 01/M03 A2980 RMK AO2A SLP089 T00061033",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "OTBH",
       RawData = "OTBH 041555Z 11011KT 9999 SCT170 21/14 A2996 Q1014 RMK AO2A SLP147 WND DATA ESTMD T02070141 FZRANO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "OPFA",
       RawData = "OPFA 041555Z 00000KT 4000 FU NSC 15/09 Q1019 NOSIG",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "OKAS",
       RawData = "OKAS 041555Z AUTO 08007KT 9999 OVC100 13/08 A3004 RMK AO2 SLP173 T01330077 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "OEPS",
       RawData = "OEPS 041555Z AUTO VRB05KT 9999 FEW130 BKN150 21/03 A2995 RMK AO2 SLP125 WND DATA ESTMD T02080032",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "NZFX",
       RawData = "NZFX 041555Z 19019KT 4800 -SN BR DRSN FEW010 OVC026 M14/M16 A2917 RMK AO2A VIS GRID N-E 2400 SLP872 LSR11 GRID36019KT SDP/HDP",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIVT",
       RawData = "LIVT 041555Z AUTO /////KT //// 13/M01 Q1024",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIVM",
       RawData = "LIVM 041555Z AUTO 08004KT //// 11/05 Q1024",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIVF",
       RawData = "LIVF 041555Z 06004KT CAVOK 10/M03 Q1022",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIVD",
       RawData = "LIVD 041555Z AUTO VRB03KT //// 07/M04 Q1025",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIVC",
       RawData = "LIVC 041555Z AUTO 06009KT //// M01/M16 Q1024",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRX",
       RawData = "LIRX 041555Z AUTO 21005KT 160V260 //// 12/08 Q1022",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRV",
       RawData = "LIRV 041555Z 34003KT 9999 FEW020 15/00 Q1022 RMK FEW MON LIB NC VIS MIN 9999 BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRS",
       RawData = "LIRS 041555Z 22009KT 9999 FEW020 14/10 Q1022 RMK FEW VIS MIN 9999 WIND THR03 23010KT WIND THR21 24009KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRM",
       RawData = "LIRM 041555Z 23008KT CAVOK 14/M13 Q1022 RMK SKC VIS MIN 9999 WIND THR06 27008KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRL",
       RawData = "LIRL 041555Z 26008KT 9999 SCT025 16/12 Q1022 RMK SCT MON LIB NC VIS MIN 9999 WIND THR12 /////KT WIND THR30 24007KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRK",
       RawData = "LIRK 041555Z AUTO 11007KT 070V130 //// 02/M07 Q1019",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRH",
       RawData = "LIRH 041555Z 16004KT 9999 FEW035 17/M01 Q1022 RMK FEW MON LIB NC VIS MIN 9999 WIND THR16 /////KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRG",
       RawData = "LIRG 041555Z /////KT CAVOK 17/03 Q1021 RMK SKC MON NE LIB NC VIS MIN 9999 BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIRE",
       RawData = "LIRE 041555Z 27009KT CAVOK 14/06 Q1022 RMK SKC VIS MIN 9999 WIND THR13 /////KT WIND THR31 /////KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIQO",
       RawData = "LIQO 041555Z AUTO 12005KT 040V170 //// 13/08 Q1022",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIQC",
       RawData = "LIQC 041555Z AUTO VRB02KT 9999 ///////// 14/04 Q1020 RMK /// QUK QUL VIS MIN 9999",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPS",
       RawData = "LIPS 041555Z 18002KT CAVOK 17/M01 Q1023 RMK SKC VIS MIN 9999 WIND THR26 09001KT WIND THR08 07002KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPL",
       RawData = "LIPL 041555Z 15003KT CAVOK 15/04 Q1023 RMK SKC VIS MIN 9999 WIND THR31 17002KT WIND THR13 27001KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPI",
       RawData = "LIPI 041555Z 20003KT CAVOK 17/M05 Q1023 RMK SKC VIS MIN 9999 WIND THR06 23004KT WIND THR24 23003KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPF",
       RawData = "LIPF 041555Z 00000KT CAVOK 16/M01 Q1024 RMK SKC VIS MIN 9999",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPC",
       RawData = "LIPC 041555Z 07005KT CAVOK ///// Q1025 RMK SKC VIS MIN 9999 WIND THR11 07005KT WIND THR29 09005KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIPA",
       RawData = "LIPA 041555Z 20003KT CAVOK 16/01 Q1023 RMK SKC VIS MIN 9999 WIND THR05 /////KT WIND THR23 /////KT A3024 BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMY",
       RawData = "LIMY 041555Z AUTO 06004KT //// 13/M01 Q1024",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMV",
       RawData = "LIMV 041555Z AUTO VRB09KT //// // ///////// 13/01 Q1023",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMU",
       RawData = "LIMU 041555Z AUTO 06009KT //// 14/05 Q1024",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMS",
       RawData = "LIMS 041555Z 10005KT CAVOK 14/01 Q1023 RMK SKC VIS MIN 9999 WIND THR30 11005KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMN",
       RawData = "LIMN 041555Z 16004KT CAVOK 16/01 Q1024 RMK SKC VIS MIN 9999 BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMK",
       RawData = "LIMK 041555Z AUTO 31003KT //// 13/03 Q1023",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIMH",
       RawData = "LIMH 041555Z AUTO 23002KT //// M04/M26 Q1023",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIED",
       RawData = "LIED 041555Z 13009KT 9999 FEW030 15/08 Q1020 RMK FEW VIS MIN 9999 WIND THR34 13009KT WIND THR16 12010KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LICZ",
       RawData = "LICZ 041555Z /////KT 9999 FEW025 14/05 Q1021 RMK FEW VIS MIN 9999 WIND THR28 09012KT WIND THR10 09011KT A3017 BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LICT",
       RawData = "LICT 041555Z 24004KT 9999 FEW022 17/09 Q1020 RMK FEW VIS MIN 9999 WIND THR13 25004KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LICF",
       RawData = "LICF 041555Z AUTO 28002KT //// 14/05 Q1022",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIBY",
       RawData = "LIBY 041555Z AUTO 03009KT //// 13/06 Q1021",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIBV",
       RawData = "LIBV 041555Z 36008KT 8000 FEW029 10/04 Q1023 RMK FEW VIS MIN 8000 WIND THR32 01008KT WIND THR14 01008KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIBQ",
       RawData = "LIBQ 041555Z 08007KT 9999 SCT003 SCT004 ///// Q//// RMK BKN MON LIB VAL NIL VIS MIN 9999",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIBN",
       RawData = "LIBN 041555Z 36009KT CAVOK 13/03 Q1022 RMK SKC VIS MIN 9999 WIND THR14 01009KT WIND THR32 01009KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "LIBA",
       RawData = "LIBA 041555Z 12003KT 9999 FEW030 14/07 Q1023 RMK FEW VIS MIN 9999 WIND THR11 14004KT WIND THR29/////KT BLU",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KXNO",
       RawData = "KXNO 041555Z AUTO 12007KT 10SM FEW046 FEW060 18/08 A3019 RMK AO2 SLP226 T01780084 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KXMR",
       RawData = "KXMR 041555Z AUTO 12017G24KT 10SM FEW190 24/15 A3012 RMK AO2 SLP203 T02380148 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KXIF",
       RawData = "KXIF 041555Z AUTO 08004KT 9SM SCT080 08/M04 A3013 RMK AO2 SLP215 T00791045 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KWRI",
       RawData = "KWRI 041555Z AUTO 20014KT 10SM OVC070 10/00 A3021 RMK AO2 SLP231 T01040004",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KWRB",
       RawData = "KWRB 041555Z AUTO 14014KT 10SM FEW039 FEW055 19/10 A3012 RMK AO2 SLP202 T01870097 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KWHP",
       RawData = "KWHP 041555Z 04005KT 10SM OVC024 10/03 A3025",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KVPS",
       RawData = "KVPS 041555Z AUTO 13017G23KT 10SM OVC008 19/16 A2997 RMK AO2 SLP156 T01910159 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KVOK",
       RawData = "KVOK 041555Z 11005KT 10SM OVC041 08/05 A2953 RMK AO2A SLP007 T00790052",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KVGN",
       RawData = "KVGN 041555Z AUTO 36009G16KT 8SM CLR 12/08 A3026 RMK AO2 SLP250 T01180081",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KVBG",
       RawData = "KVBG 041555Z 35011KT 9SM FEW007 SCT090 SCT250 11/09 A3027 RMK AO2A SLP254 T01050089",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KVAD",
       RawData = "KVAD 041555Z 13010G20KT 110V170 7SM FEW030 SCT040 22/13 A3013 RMK SLP202 AO2A WND DATA ESTMD ALTSG ESTMD T02240131",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KU16",
       RawData = "KU16 041555Z AUTO 30011KT 10SM CLR 06/M02 A3010 RMK AO2 SLP183 T00591017",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KTTS",
       RawData = "KTTS 041555Z AUTO 13015G24KT 10SM FEW075 SCT095 SCT120 BKN150 BKN190 23/14 A3013 RMK AO2 SLP207 T02290142 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KTQS",
       RawData = "KTQS 041555Z AUTO 36006KT 5SM BR BKN011 10/09 A3027 RMK AO2 BKN V OVC SLP254 T01010085",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KTIK",
       RawData = "KTIK 041555Z AUTO 18009KT 10SM CLR 12/09 A2929 RMK AO2 SLP915 T01180088",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KTCM",
       RawData = "KTCM 041555Z AUTO 00000KT 10SM OVC036 05/05 A3002 RMK AO2 SLP171 T00480045 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KTBN",
       RawData = "KTBN 041555Z AUTO 14023G33KT 8SM VCTS SCT070 BKN090 13/07 A2945 RMK AO2 PK WND 15033/46 SLP971 T01330069",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KT70",
       RawData = "KT70 041555Z AUTO 32025G36KT 10SM CLR 20/M13 A2977 RMK AO2 PK WND 33040/18 SLP070 T02001126 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSVN",
       RawData = "KSVN 041555Z 13009G15KT 10SM FEW055 22/14 A3015 RMK AO2A SLP213 T02190135 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSUU",
       RawData = "KSUU 041555Z AUTO 22010KT 10SM SCT075 BKN100 10/08 A3023 RMK AO2 SLP243 T01010075 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSSC",
       RawData = "KSSC 041555Z 14005KT 10SM FEW045 BKN220 16/07 A3020 RMK AO2A SLP228 T01600067 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSLI",
       RawData = "KSLI 041555Z 07006KT 9SM SCT020 BKN038 BKN180 13/07 A3021 RMK AO2A SLP233 T01300066",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSKF",
       RawData = "KSKF 041555Z AUTO 29021G30KT 10SM CLR 20/M05 A2965 RMK AO2 PK WND 30030/52 SLP035 T02001051 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSKA",
       RawData = "KSKA 041555Z 08003KT 10SM BKN044 OVC085 01/01 A3005 RMK AO2A SLP192 T00130007 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSHM",
       RawData = "KSHM 041555Z AUTO 36029G40KT 10SM CLR 02/M04 A2963 RMK AO2 PK WND 33041/1455 SLP041 T00211036 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSCK",
       RawData = "KSCK 041555Z 19003KT 10SM R29R/0400VP6000FT BKN100 OVC110 09/07 A3026 RMK AO2 SLP248 T00890067",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KSBD",
       RawData = "KSBD 041555Z 00000KT 7SM SCT023 09/03 A3025",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KRYM",
       RawData = "KRYM 041555Z AUTO 02006KT 10SM BKN037 OVC050 02/M01 A2965 RMK AO2 SLPNO T00151007 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KRNO",
       RawData = "KRNO 041555Z 00000KT 10SM BKN070 BKN200 02/M03 A3017 RMK AO2 SLP213 T00171028",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KRND",
       RawData = "KRND 041555Z AUTO 28015G24KT 10SM CLR 20/M04 A2964 RMK AO2 PK WND 29030/28 SLP031 T01981038",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KRIV",
       RawData = "KRIV 041555Z 15004KT 10SM SCT011 BKN250 08/05 A3024 RMK AO2A SLP243 T00750046",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KQTZ",
       RawData = "KQTZ 041555Z 09007KT 9999 BKN120 19/M04 A2998 RMK SLP155",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KQRH",
       RawData = "KQRH 041555Z AUTO 09008G15KT 020V150 9999 FEW020 27/22 A2980 RMK AO2 SLP094 WND DATA ESTMD T02680215",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KQHY",
       RawData = "KQHY 041555Z AUTO 14008G16KT 10SM BKN013 OVC021 19/17 A2999 RMK AO2 BKN V OVC SLP162 T01920166",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KQD3",
       RawData = "KQD3 041555Z 05010KT 9999 FEW020 SCT025 26/22 A2991 RMK AO2A SLP122 WND DATA ESTMD T02660215",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KQBR",
       RawData = "KQBR 041555Z AUTO 25001KT 10SM FEW050 OVC065 06/03 A3010 RMK AO2 SLP186 WND DATA ESTMD T00560028",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KPSM",
       RawData = "KPSM 041555Z 21010KT 10SM BKN080 BKN200 04/M09 A3014 RMK AO2A SLP210 T00401094",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KPOB",
       RawData = "KPOB 041555Z AUTO 12006KT 10SM SCT050 BKN200 15/03 A3024 RMK AO2 SLP243 T01510026 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KPAM",
       RawData = "KPAM 041555Z 15023G28KT 10SM SCT038 23/16 A3000 RMK AO2A PK WND 16031/45 SLP162 T02280159",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KP58",
       RawData = "KP58 041555Z AUTO 20007KT 170V230 04/01 A2978 RMK AO1 SLP092 T00390011",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KOZR",
       RawData = "KOZR 041555Z AUTO 14016G23KT 10SM CLR 21/13 A3001 RMK AO2 SLP164 T02070129",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KNTD",
       RawData = "KNTD 041555Z 04004KT 8SM FEW016 FEW240 12/07 A3025 RMK AO2 SLP245 T01170072 VISNO S $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KNKX",
       RawData = "KNKX 041555Z 08006KT 10SM OVC028 11/06 A3023 RMK AO2 SLP236 T01110061",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KNBG",
       RawData = "KNBG 041555Z 14013G20KT 10SM BKN030 BKN250 19/16 A2983 RMK AO2 SLP101 T01940161 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMXF",
       RawData = "KMXF 041555Z AUTO 12012KT 10SM OVC022 19/11 A2998 RMK AO2 SLP155 T01860112",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMUO",
       RawData = "KMUO 041555Z 31004KT 7SM SCT070 SCT200 04/00 A3009 RMK AO2A DZB06E22 SLP198 T00380000 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMUI",
       RawData = "KMUI 041555Z 14003KT 10SM BKN075 OVC200 05/M04 A3015 RMK AO2A SLP218 T00541042",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMMT",
       RawData = "KMMT 041555Z 14009KT 10SM FEW040 BKN200 17/07 A3019 RMK AO2A SLP226 T01740074 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMIB",
       RawData = "KMIB 041555Z 04008KT 10SM SCT010 BKN014 BKN020 OVC027 M03/M05 A2998 RMK SLP178 P0000 T10281053",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMCF",
       RawData = "KMCF 041555Z 14013KT 10SM CLR 26/15 A3010 RMK AO2A SLPNO ALSTG ESTMD T02570145 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KMAW",
       RawData = "KMAW 041555Z AUTO 14019G26KT 10SM OVC090 15/02 A2967 RMK AO1",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLUF",
       RawData = "KLUF 041555Z AUTO 00000KT 10SM CLR 11/M02 A3015 RMK AO2 SLP208 T01101018 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLTS",
       RawData = "KLTS 041555Z 27019G27KT 10SM CLR 14/M03 A2929 RMK AO2A PK WND 26029/52 SLP909 T01391030 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLSV",
       RawData = "KLSV 041555Z AUTO 00000KT 10SM CLR 10/M03 A3012 RMK AO2 SLP198 T01031031 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLOR",
       RawData = "KLOR 041555Z AUTO 16006KT 10SM FEW025 21/14 A3000 RMK AO2 SLP142 T02070139",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLLJ",
       RawData = "KLLJ 041555Z AUTO 00000KT 10SM CLR 00/M05 A3007 RMK AO2 SLP188 T00001050",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLHW",
       RawData = "KLHW 041555Z 12011G17KT 10SM SCT050 22/13 A3013 RMK AO2A SLP206 T02220127 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLGF",
       RawData = "KLGF 041555Z AUTO 23004KT 10SM CLR 13/01 A3016 RMK AO2 SLP214 T01310008 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLFI",
       RawData = "KLFI 041555Z 24013KT 10SM SCT250 14/M01 A3028 RMK AO2A SLP260 T01381014 VISNO RWY26 CHINO RWY26 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KLCK",
       RawData = "KLCK 041555Z AUTO 17012KT 10SM SCT090 12/M06 A2995 RMK AO2 T01171062",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KJKA",
       RawData = "KJKA 041555Z 15014G19KT 10SM FEW025 23/18 A2993",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KIRK",
       RawData = "KIRK 041555Z AUTO 15010KT 10SM BKN011 BKN070 OVC085 11/09 A2947 RMK AO2 RAB38E47 SLP980 P0001 T01110094",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KINS",
       RawData = "KINS 041555Z AUTO 00000KT 10SM CLR 07/M04 A3016 RMK AO2 SLP200 T00691045 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KIAB",
       RawData = "KIAB 041555Z AUTO 20007KT 10SM FEW190 12/06 A2929 RMK AO2 SLP917 T01150062",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHXD",
       RawData = "KHXD 041555Z 13005G12KT 10SM SCT040 20/14 A3021",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHST",
       RawData = "KHST 041555Z AUTO 08016G24KT 10SM SCT027 25/18 A3007 RMK AO2 SLP186 T02530182",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHRT",
       RawData = "KHRT 041555Z 11014G22KT 10SM BKN009 OVC014 20/16 A2996 RMK AO2A CIG 007V009 BKN V OVC SLP144 T01960164 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHOP",
       RawData = "KHOP 041555Z AUTO 17010G18KT 10SM CLR 17/M05 A2983 RMK AO2 PK WND 16028/29 SLP102 T01711054",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHMN",
       RawData = "KHMN 041555Z COR 34004KT 10SM FEW080 09/M08 A2998 RMK AO2A SLP124 T00911085 $ COR 1606",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHLR",
       RawData = "KHLR 041555Z AUTO 28021G25KT 9SM CLR 17/01 A2957 RMK AO2 PK WND 28028/34 SLP007 T01740005",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHIF",
       RawData = "KHIF 041555Z 21004KT 10SM FEW010 BKN050 04/01 A3009 RMK AO2A SLP184 T00380013",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHFF",
       RawData = "KHFF 041555Z AUTO 17008KT 10SM SCT200 16/05 A3022 RMK AO2 SLP237 T01610048 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KHEY",
       RawData = "KHEY 041555Z AUTO 15014G19KT 9SM CLR 21/14 A2997 RMK AO2 PK WND 16026/20 SLP150 T02050137",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGXF",
       RawData = "KGXF 041555Z AUTO 00000KT 10SM CLR 14/M01 A3016 RMK AO2 SLP209 T01391006 FZRANO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGTB",
       RawData = "KGTB 041555Z 15008KT 10SM OVC049 01/M07 A2996 RMK AO2A SLP153 T00061072",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGSB",
       RawData = "KGSB 041555Z 17008KT 10SM SCT055 BKN250 17/03 A3025 RMK AO2A SLP247 CONTRAILS T01660026 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGRK",
       RawData = "KGRK 041555Z AUTO 28017G25KT 10SM CLR 17/00 A2958 RMK AO2 PK WND 28032/52 SLP009 T01670003",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGRF",
       RawData = "KGRF 041555Z AUTO 00000KT 10SM OVC036 05/04 A3001 RMK AO2 SLP168 T00500043 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGPI",
       RawData = "KGPI 041555Z 00000KT 9SM -SN OVC035 02/M01 A3008 RMK AO2 SLP207 P0000 T00171006",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KGOV",
       RawData = "KGOV 041555Z AUTO 19005KT 9SM OVC018 03/01 A2969 RMK AO2 SLP071 T00310008 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFSI",
       RawData = "KFSI 041555Z COR 22012G18KT 10SM CLR 15/M02 A2929 RMK AO2 SLP913 RVRNO FZRANO $ COR 1601",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFRI",
       RawData = "KFRI 041555Z 27005KT 10SM OVC040 14/09 A2926 RMK AO2A SLP903 T01380090",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFHU",
       RawData = "KFHU 041555Z AUTO 30009KT 10SM CLR 08/M06 A3017 RMK AO2 SLP207 T00771057",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFFO",
       RawData = "KFFO 041555Z AUTO 19013KT 10SM FEW190 13/M06 A2989 RMK AO2 SLP127 T01341057",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFEW",
       RawData = "KFEW 041555Z 36023G34KT 10SM BKN030 M00/M05 A2982 RMK AO2A PK WND 01034/52 SLP106 T10011053 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFCS",
       RawData = "KFCS 041555Z AUTO 35031G42KT 10SM FEW040 05/M06 A2969 RMK AO2 PK WND 34046/33 SLP065 T00521058 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KFAF",
       RawData = "KFAF 041555Z 20006KT 10SM BKN100 13/M00 A3026 RMK AO2A SLP251 T01311005 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KEND",
       RawData = "KEND 041555Z COR 13012KT 10SM FEW150 SCT250 12/08 A2929 RMK AO2A SLP915 T01150078 $ COR 1557",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KEGI",
       RawData = "KEGI 041555Z AUTO 15013G23KT 10SM BKN016 20/15 A2998 RMK AO2 SLP153 T02020150 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KEDW",
       RawData = "KEDW 041555Z 00000KT 70SM FEW200 04/M02 A3017 RMK AO2A SLP220 T00401020",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KEAT",
       RawData = "KEAT 041555Z AUTO 29004KT 10SM BKN060 04/01 A3003 RMK AO2 SLP175 T00390006",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDYS",
       RawData = "KDYS 041555Z 27021G33KT 10SM CLR 14/M05 A2956 RMK AO2A PK WND 26034KT/1538 SLP990 WND DATA ESTMD ALSTG DATA ESTMD T01441054 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDPG",
       RawData = "KDPG 041555Z 20001KT 40SM FEW055 FEW080 07/M02 A3013 RMK SLP189 T00681021",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDOV",
       RawData = "KDOV 041555Z AUTO 19011KT 10SM BKN085 10/00 A3021 RMK AO2 SLP234 T00990002",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDMA",
       RawData = "KDMA 041555Z AUTO 19003KT 10SM CLR 10/M02 A3015 RMK AO2 SLP239 T01021025 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDLH",
       RawData = "KDLH 041555Z 02008KT 7SM -SN BKN050 BKN060 OVC090 02/M01 A2960 RMK AO2 SLP039 P0000 T00171011",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDLF",
       RawData = "KDLF 041555Z AUTO 28024G36KT 10SM FEW012 20/M14 A2974 RMK AO2 PK WND 27040/34 SLP061 T02021137 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KDAA",
       RawData = "KDAA 041555Z AUTO 17008KT 10SM OVC080 11/M03 A3018 RMK AO2 SLP223 T01141035 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCWN",
       RawData = "KCWN 041555Z AUTO 35019G33KT 10SM FEW041 03/M06 A2962 RMK AO2 PK WND 34042/1457 RAB08E19PLB19E31RAB36E49 SLP936 P0000 T00321057 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCVS",
       RawData = "KCVS 041555Z 31032G41KT 10SM BKN070 OVC090 08/02 A2958 RMK AO2A PK WND 31041/46 RAE08 SLP997 P0000 T00780018 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCOF",
       RawData = "KCOF 041555Z AUTO 12018KT 10SM CLR 24/15 A3011 RMK AO2 SLP201 T02390154 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCNW",
       RawData = "KCNW 041555Z 24008KT 7SM CLR 15/08 A2956",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCMA",
       RawData = "KCMA 041555Z 08007KT 10SM CLR 12/08 A3024 RMK AO2 SLP249 T01220078",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCIC",
       RawData = "KCIC 041555Z AUTO 13010KT 10SM CLR 09/07 A3026 RMK AO1",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCBM",
       RawData = "KCBM 041555Z 16014KT 10SM SCT140 BKN250 17/06 A2986 RMK AO2A SLP114 T01740057 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KCAO",
       RawData = "KCAO 041555Z AUTO 34042G64KT 10SM CLR 05/M01 A2948 RMK AO2 PK WND 33064/1547 SLP970 T00501006",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBYS",
       RawData = "KBYS 041555Z AUTO 02006KT 10SM CLR 09/M02 A3012 RMK AO2 SLP196 T00851025 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBLV",
       RawData = "KBLV 041555Z 20023G30KT 10SM SCT110 16/03 A2959 RMK AO2A PK WND 18033/33 SLP022 T01590030",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBKT",
       RawData = "KBKT 041555Z AUTO 22009KT 10SM FEW250 FEW350 13/M02 A3024 RMK AO2 SLP245 T01321023 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBIX",
       RawData = "KBIX 041555Z AUTO 15011G17KT 10SM SCT027 19/15 A2987 RMK AO2 SLP118 T01930154",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBIF",
       RawData = "KBIF 041555Z AUTO 32011G21KT 7SM CLR 10/M06 A2996 RMK AO2 PK WND 32036/03 SLP118 T00981057 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KBAB",
       RawData = "KBAB 041555Z AUTO 13010KT 10SM OVC095 11/07 A3025 RMK AO2 SLP247 T01060071 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KAST",
       RawData = "KAST 041555Z AUTO 13003KT 10SM -RA SCT033 BKN044 OVC055 07/05 A3001 RMK AO2 SLP161 P0005 T00720050",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KADW",
       RawData = "KADW 041555Z AUTO 22014KT 10SM CLR 14/M04 A3017 RMK AO2 SLP225 T01351037 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "KABH",
       RawData = "KABH 041555Z AUTO 35035G42KT 10SM CLR 02/M01 A2966 RMK AO2 PK WND 36048/42 SLP054 T00191015",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K9L2",
       RawData = "K9L2 041555Z AUTO 00000KT 10SM CLR 05/M01 A3018 RMK AO2 SLP223 T00451013",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K4MR",
       RawData = "K4MR 041555Z AUTO 29022G29KT 10SM OVC055 10/M05 A2960 RMK AO2 PK WND 30029/44 SLP980 T00981053 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K2DP",
       RawData = "K2DP 041555Z AUTO 17008KT 10SM CLR 16/04 A3030 RMK AO2 SLP268 T01640038 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1YT",
       RawData = "K1YT 041555Z AUTO 00000KT 10SM BKN140 04/00 A2999 RMK AO2 SLP165 T00370004 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1ON",
       RawData = "K1ON 041555Z AUTO 01010KT 10SM BKN020 OVC031 M03/M05 A3002 RMK AO2 CIG 020V031 BKN V SCT SLP191 T10291055 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1OM",
       RawData = "K1OM 041555Z AUTO 33012KT 10SM OVC005 M03/M04 A3008 RMK AO2 SLP223 T10261040 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1NW",
       RawData = "K1NW 041555Z AUTO 33022G35KT 10SM FEW018 FEW031 02/M02 A2974 RMK AO2 PK WND 01037/30 RAB06E17 SLP068 P0000 T00221020 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1NM",
       RawData = "K1NM 041555Z AUTO 28006KT 10SM BKN032 OVC100 M01/M04 A3005 RMK AO2 SLP212 T10071042 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1MW",
       RawData = "K1MW 041555Z AUTO 35028G35KT 10SM OVC021 02/M02 A2974 RMK AO2 PK WND 34038/01 SLP073 T00241016 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1MN",
       RawData = "K1MN 041555Z AUTO 36007KT 10SM OVC007 M03/M04 A3000 RMK AO2 SNE32 OVC V BKN SLP187 P0000 T10291042 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1MM",
       RawData = "K1MM 041555Z AUTO 32004KT 3SM BR FEW004 BKN019 OVC100 M03/M04 A3008 RMK AO2 SNE36 CIG 019V100 BKN V SCT SLP223 P0001 T10351043 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1KM",
       RawData = "K1KM 041555Z AUTO 01009KT 10SM FEW035 SCT100 M02/M05 M RMK AO2 SLPNO T10181048 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1JW",
       RawData = "K1JW 041555Z AUTO 32032G41KT 10SM OVC014 01/M01 A2970 RMK AO2 PK WND 34042/27 SLP061 T00131011 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1JM",
       RawData = "K1JM 041555Z AUTO 08005KT 9SM -SN OVC013 M03/M04 A3008 RMK AO2 SLP224 P0000 T10311045 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1IM",
       RawData = "K1IM 041555Z AUTO 00000KT 10SM OVC028 M01/M02 A3007 RMK AO2 UPB1458E00PLB00E10UPB20E32 SLP216 P0000 T10151023 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1HW",
       RawData = "K1HW 041555Z AUTO 36027G39KT 10SM OVC014 01/M01 A2969 RMK AO2 PK WND 35042/31 SLP062 T00131014 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1HM",
       RawData = "K1HM 041555Z AUTO 00000KT 10SM -SN OVC009 M03/M05 A3007 RMK AO2 SNE49SNB53 SLP221 P0000 T10331047 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1GW",
       RawData = "K1GW 041555Z AUTO 35025G33KT 10SM OVC012 02/M00 M RMK AO2 PK WND 34039/38 SLPNO T00171004 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1GM",
       RawData = "K1GM 041555Z AUTO 00000KT 1/2SM -SN FZFG VV002 M03/M03 A3002 RMK AO2 FZRAE46SNB46 SLP205 P0001 T10261030 RVRNO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1FM",
       RawData = "K1FM 041555Z AUTO 13004KT 1SM -SN BR OVC003 M04/M04 A3006 RMK AO2 SLP220 P0000 T10371043 RVRNO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1EW",
       RawData = "K1EW 041555Z AUTO 33033G38KT 9SM -SN BKN008 BKN014 M00/M02 A2975 RMK AO2 PK WND 35042/23 SLP082 P0000 T10021018 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1EN",
       RawData = "K1EN 041555Z AUTO 36007KT 9SM -SN OVC006 M02/M03 A2973 RMK AO2 SNE18SNB20 SLP096 P0000 T10161030 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1EM",
       RawData = "K1EM 041555Z AUTO 26007KT 10SM OVC100 M03/M05 A3009 RMK AO2 SLP225 T10351049 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1DM",
       RawData = "K1DM 041555Z AUTO 29012KT 10SM FEW004 OVC100 M03/M04 M RMK AO2 SLPNO T10271044 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1BW",
       RawData = "K1BW 041555Z AUTO 34028G34KT 3/4SM -SN BR BKN007 OVC012 M02/M03 A2983 RMK AO2 PK WND 34035/55 SLP115 P0000 T10161029 RVRNO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1AW",
       RawData = "K1AW 041555Z AUTO 34033G41KT 4SM -SN BR OVC014 M01/M03 A2981 RMK AO2 PK WND 34042/08 SLP106 P0000 T10131035 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "K1AM",
       RawData = "K1AM 041555Z AUTO 00000KT 10SM OVC004 M02/M03 A3009 RMK AO2 SLP227 P0001 T10211028 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "FJDG",
       RawData = "FJDG 041555Z 24006KT 9999 FEW020 SCT050 BKN090 27/23 A2984 RMK SLP102 T02710230",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETOU",
       RawData = "ETOU 041555Z AUTO 00000KT 9999 CLR 12/M04 A3028 RMK AO2 SLP260 T01221040",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETIK",
       RawData = "ETIK 041555Z AUTO 04005KT 9999 CLR 12/M01 A3026 RMK AO2 SLP258 T01241012",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETIC",
       RawData = "ETIC 041555Z AUTO 00000KT 9999 CLR 13/M09 A3024 RMK AO2 SLP254 T01261086 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETEB",
       RawData = "ETEB 041555Z AUTO 01005KT 9999 CLR 12/M03 A3024 RMK AO2 SLP265 T01161030 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETAR",
       RawData = "ETAR 041555Z AUTO 04006KT 9999 CLR 15/M06 A3023 RMK AO2 SLP246 T01461058",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "ETAD",
       RawData = "ETAD 041555Z AUTO 08004KT 9999 CLR 14/M11 A3023 RMK AO2 SLP235 T01391108",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "EGVA",
       RawData = "EGVA 041555Z 25008KT 9999 FEW200 13/M04 A3023 RMK AO2A SLP242 T01261037 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "EGUN",
       RawData = "EGUN 041555Z 21010KT 9999 FEW025 FEW200 13/M01 A3020 RMK AO2A SLP230 T01301010 $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "BGTL",
       RawData = "BGTL 041555Z AUTO 14007KT 9999 CLR M16/M24 A2921 RMK AO2 SLP878 T11601241 TSNO $",
       LastChange = "2025-03-04T15:55:00Z"
    },
    new Metar {
       Station = "PTTP",
       RawData = "PTTP 041554Z 10007KT 12SM BKN018 OVC300 28/24 A2984 RMK SLP103 T02750241",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "PHOG",
       RawData = "PHOG 041554Z 05012G23KT 10SM FEW029 SCT040 SCT060 22/19 A3018 RMK AO2 RAE06B39E52 SLP225 P0000 T02220189",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "PHMK",
       RawData = "PHMK 041554Z 06013G25KT 10SM FEW024 FEW034 BKN045 22/18 A3019 RMK AO2 PK WND 07029/1523 SLP227 T02220178 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "PGSN",
       RawData = "PGSN 041554Z 07014KT 10SM FEW018 SCT030 BKN042 27/23 A2991 RMK AO2 PK WND 07026/1536 SLP148 T02670233 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "PAKN",
       RawData = "PAKN 041554Z AUTO 12007KT 10SM OVC070 04/01 A2963 RMK AO2 SLP035 T00390006 TSNO",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "PAHN",
       RawData = "PAHN 041554Z AUTO 29016KT 10SM CLR M01/M03 A2994 RMK AO2 SLP141 T10111033 TSNO",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "MMPG",
       RawData = "MMPG 041554Z 30025G35KT 6SM SKC 22/04 A2977 RMK HZ",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KWLD",
       RawData = "KWLD 041554Z AUTO 11012G19KT 10SM CLR 11/09 A2931 RMK AO2 SLP920 T01060089",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KWAL",
       RawData = "KWAL 041554Z AUTO 18013KT 10SM CLR 11/03 A3029 RMK AO2 SLP255 T01060033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KVTA",
       RawData = "KVTA 041554Z AUTO A2996 RMK AO2 SLPNO PWINO FZRANO $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KVSF",
       RawData = "KVSF 041554Z AUTO VRB04KT 10SM OVC075 M01/M09 A3012 RMK AO2 SLP210 T10061089",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KVAY",
       RawData = "KVAY 041554Z AUTO 23007G16KT 10SM SCT070 BKN090 10/M01 A3023 RMK AO2 SLP235 T01001006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KUZA",
       RawData = "KUZA 041554Z AUTO 17007KT 10SM BKN045 BKN055 14/05 A3023 RMK AO2 SLP238 T01440050",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KTAD",
       RawData = "KTAD 041554Z AUTO 36022G33KT 10SM BKN080 03/M02 A2969 RMK AO2 PK WND 01034/1509 SLP038 T00281022",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSYR",
       RawData = "KSYR 041554Z 14004KT 10SM OVC060 06/M05 A3003 RMK AO2 SLP170 T00561050",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSUS",
       RawData = "KSUS 041554Z 16016G24KT 10SM CLR 16/04 A2953 RMK AO2 PRESFR SLP999 T01610039",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSLC",
       RawData = "KSLC 041554Z 34006KT 10SM BKN032 BKN041 BKN050 05/02 A3008",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSJN",
       RawData = "KSJN 041554Z AUTO 28015G21KT 10SM CLR 04/M04 A3008 RMK AO2 SLP174 T00391044",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSET",
       RawData = "KSET 041554Z AUTO 16013KT 10SM OVC080 14/06 A2957 RMK AO2 PK WND 16028/1455 SLP010 T01440056",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KSBY",
       RawData = "KSBY 041554Z 20016G24KT 10SM CLR 13/M02 A3026 RMK AO2 SLP249 T01331017",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KRSP",
       RawData = "KRSP 041554Z AUTO 17005KT OVC065 07/M08 A3011 RMK AO2 SLP215 T00671078 PWINO $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KROC",
       RawData = "KROC 041554Z 22010KT 10SM BKN060 OVC100 07/M07 A2999 RMK AO2 SLP165 T00721067 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KROA",
       RawData = "KROA 041554Z VRB04KT 10SM SCT210 07/M07 A3022 RMK AO2 SLP238 T00721067",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KRIC",
       RawData = "KRIC 041554Z 20009KT 10SM OVC250 13/M01 A3026 RMK AO2 SLP253 T01281011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KRDG",
       RawData = "KRDG 041554Z 21009KT 9SM OVC095 07/M03 A3017 RMK AO2 SLP224 T00721028",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPTW",
       RawData = "KPTW 041554Z AUTO VRB05KT 10SM SCT070 OVC100 07/M02 A3020 RMK AO2 SLP228 T00721017",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPSF",
       RawData = "KPSF 041554Z AUTO 17006KT 10SM BKN070 OVC110 02/M08 A3008 RMK AO2 SLP202 T00171083",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPNE",
       RawData = "KPNE 041554Z 22013KT 10SM FEW075 OVC100 09/M01 A3023 RMK AO2 SLP237 T00891011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPMH",
       RawData = "KPMH 041554Z AUTO 16007KT 10SM CLR 12/M09 A3001 RMK AO2",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPHL",
       RawData = "KPHL 041554Z 21010KT 10SM BKN070 BKN095 BKN250 08/M01 A3023 RMK AO2 SLP235 T00831011 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KPHF",
       RawData = "KPHF 041554Z 21012KT 10SM CLR 14/M01 A3028 RMK AO2 SLP255 T01391006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KORH",
       RawData = "KORH 041554Z 24017G27KT 10SM OVC070 03/M09 A3014 RMK AO2 PK WND 23032/1542 SLP219 T00281094",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KOLS",
       RawData = "KOLS 041554Z AUTO 15006KT 10SM CLR 07/M02 A3018 RMK AO2 SLP199 T00721022",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KOFP",
       RawData = "KOFP 041554Z AUTO 22014KT 10SM CLR 13/M02 A3026 RMK AO2 SLP249 T01281022",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KNXP",
       RawData = "KNXP 041554Z AUTO 30005KT 10SM CLR 11/M03 A3024 RMK AO2 SLP222 T01111028",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KNKT",
       RawData = "KNKT 041554Z 19011KT 10SM SCT060 BKN100 18/06 A3032 RMK AO2 SLP263 T01780061",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KNAK",
       RawData = "KNAK 041554Z AUTO 13012KT 10SM CLR 07/02 A3021 RMK AO2 SLP232 T00670022",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KN60",
       RawData = "KN60 041554Z AUTO 01007KT M02/M04 A2999 RMK AO1 SLP180 T10171039",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMVL",
       RawData = "KMVL 041554Z AUTO 20004KT 10SM OVC065 03/M09 A3002 RMK AO2 SNE1455 SLP179 P0000 T00331094 PWINO $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMTP",
       RawData = "KMTP 041554Z AUTO 21008G21KT 07/M01 A3027 RMK AO1 SLP248 T00721006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMTN",
       RawData = "KMTN 041554Z 12009KT 10SM CLR 08/01 A3023",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMRY",
       RawData = "KMRY 041554Z 12005KT 10SM BKN090 10/07 A3027 RMK AO2 SLP262 T01000067",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMKC",
       RawData = "KMKC 041554Z VRB06G16KT 4SM RA BR FEW009 FEW039 OVC060 12/11 A2940 RMK AO2 SLP953 P0015 T01220106",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMIV",
       RawData = "KMIV 041554Z AUTO 19008G16KT 10SM BKN095 09/M01 A3025 RMK AO2 SLP243 T00891006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMGJ",
       RawData = "KMGJ 041554Z AUTO 22013KT 10SM FEW075 SCT095 07/M05 A3013 RMK AO2 SLP207 T00671050",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMFI",
       RawData = "KMFI 041554Z AUTO 12008KT 4SM BR FEW004 07/04 A2956 RMK AO2 SLP018 T00670044",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KMEM",
       RawData = "KMEM 041554Z 14021G38KT 10SM BKN150 OVC180 16/02 A2967 RMK AO2 PK WND 12042/1522 SLP045 T01560017 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KLYH",
       RawData = "KLYH 041554Z 21007KT 10SM CLR 11/M02 A3022 RMK AO2 SLP234 T01111022 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KLWM",
       RawData = "KLWM 041554Z 22011G20KT 10SM OVC080 04/M09 A3017 RMK AO2 SLP219 T00391094",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KLNK",
       RawData = "KLNK 041554Z 04005KT 5SM BR FEW021 BKN029 13/12 A2931 RMK AO2 SLP922 T01330117",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KLEX",
       RawData = "KLEX 041554Z 17015KT 10SM CLR 17/M03 A2994 RMK AO2 PK WND 19027/1519 SLP138 T01671028",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KLAF",
       RawData = "KLAF 041554Z 02008KT 10SM -RA OVC055 08/03 A2978 RMK AO2 RAB19 SLP087 P0002 T00780033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KJST",
       RawData = "KJST 041554Z AUTO 20011G20KT 10SM CLR 10/M11 A3004 RMK AO2 SLP186 T01001106",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KJAN",
       RawData = "KJAN 041554Z 14023G35KT 10SM BKN070 18/12 A2976 RMK AO2 PK WND 14039/1543 SLP074 T01780122 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KIZG",
       RawData = "KIZG 041554Z AUTO 10004KT 10SM CLR M01/M12 A3008 RMK AO2 SLP196 T10061122",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KISW",
       RawData = "KISW 041554Z AUTO 15006KT 10SM SCT040 07/05 A2959 RMK AO2 SLP026 T00670050",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KIPT",
       RawData = "KIPT 041554Z 07003KT 10SM BKN070 OVC085 04/M07 A3013 RMK AO2 SLP208 T00441067",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KINT",
       RawData = "KINT 041554Z 24006KT 10SM CLR 12/01 A3024 RMK AO2 SLP238 T01220006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KINL",
       RawData = "KINL 041554Z AUTO 02012G20KT 10SM OVC021 M01/M06 A2979 RMK AO2 SLP105 T10061056 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KIND",
       RawData = "KIND 041554Z 19021G31KT 10SM FEW065 FEW100 SCT130 BKN250 17/M03 A2977 RMK AO2 PK WND 20031/1554 SLP082 T01671033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KILN",
       RawData = "KILN 041554Z AUTO 20014KT 10SM CLR 11/M03 A2992 RMK AO2 SLP147 T01111033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KHWD",
       RawData = "KHWD 041554Z 15007KT 10SM SCT024 OVC065 12/06 A3026 RMK AO2 SLP256 T01170061",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KGSO",
       RawData = "KGSO 041554Z 19013KT 10SM FEW190 OVC250 13/M01 A3022 RMK AO2 SLP234 T01281006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KGED",
       RawData = "KGED 041554Z AUTO 21015G23KT 10SM OVC080 13/M01 A3024 RMK AO2 SLP242 T01331011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KGCN",
       RawData = "KGCN 041554Z 24006KT 10SM CLR 00/M03 A3012 RMK AO2 SLP199 T00001033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KFZY",
       RawData = "KFZY 041554Z AUTO VRB03KT 8SM BKN055 BKN075 OVC085 03/M04 A3001 RMK AO2 SLP167 T00331039",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KFWA",
       RawData = "KFWA 041554Z 01009KT 10SM -RA BKN060 OVC140 06/02 A2987 RMK AO2 RAE13B33 SLP121 P0000 T00560017",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KFIG",
       RawData = "KFIG 041554Z AUTO 00000KT 10SM CLR 08/M06 A3005 RMK AO2 SLP186 T00831061",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KFFZ",
       RawData = "KFFZ 041554Z 13007KT 10SM CLR 11/M01 A3015 RMK AO2 SLP201 T01111006",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KEWN",
       RawData = "KEWN 041554Z 14008KT 10SM SCT055 17/03 A3031 RMK AO2 SLP264 T01720028 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KEVV",
       RawData = "KEVV 041554Z 16013G26KT 10SM BKN080 17/M01 A2978 RMK AO2 PK WND 17029/1513 SLP084 T01671011 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KEUG",
       RawData = "KEUG 041554Z 13007KT 5SM -RA BR OVC040 08/07 A3009 RMK AO2 SLP192 P0007 T00780067",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KECG",
       RawData = "KECG 041554Z 22008KT 10SM CLR 16/01 A3031 RMK AO2 SLP262 T01560011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KDYL",
       RawData = "KDYL 041554Z AUTO 20010KT 160V240 10SM FEW065 BKN085 07/M01 A3019 RMK AO2 SLP229 T00671011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KDSV",
       RawData = "KDSV 041554Z AUTO 14008KT 10SM CLR 11/M07 A3000 RMK AO2 SLP170 T01061067 $",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KDSM",
       RawData = "KDSM 041554Z 13014KT 10SM FEW019 SCT050 BKN100 OVC250 12/08 A2941 RMK AO2 PRESFR SLP957 T01170083",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KDEC",
       RawData = "KDEC 041554Z 14005KT 10SM OVC042 10/06 A2969 RMK AO2 LTG DSNT W-NE RAE51 TSB23E38 SLP052 P0014 T01000061",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KDDH",
       RawData = "KDDH 041554Z AUTO 00000KT 10SM OVC075 03/M09 A3009 RMK AO2 SLP201 T00281094",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KCRW",
       RawData = "KCRW 041554Z 00000KT 10SM BKN180 13/M05 A3002 RMK AO2 SLP167 T01331050",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KCAR",
       RawData = "KCAR 041554Z AUTO 18007G16KT 150V210 10SM FEW024 OVC080 M06/M12 A2997 RMK AO2 SLP166 T10561117",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBWI",
       RawData = "KBWI 041554Z 22007KT 10SM FEW130 BKN250 11/M03 A3020 RMK AO2 SLP227 T01111033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBUY",
       RawData = "KBUY 041554Z AUTO VRB05KT 10SM CLR 13/M01 A3023 RMK AO2 SLP239 T01281011",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBUF",
       RawData = "KBUF 041554Z 22009KT 10SM FEW060 BKN100 BKN150 OVC230 09/M06 A2996 RMK AO2 SLP152 T00891056",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBTV",
       RawData = "KBTV 041554Z 20013G23KT 10SM BKN070 BKN100 OVC140 02/M09 A3003 RMK AO2 SLP175 T00221089",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBOS",
       RawData = "KBOS 041554Z 21017KT 10SM OVC080 05/M08 A3019 RMK AO2 PK WND 23027/1458 SLP222 T00501083",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KBFL",
       RawData = "KBFL 041554Z 00000KT 10SM CLR 08/04 A3026 RMK AO2 SLP245 T00780039",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAVP",
       RawData = "KAVP 041554Z 00000KT 10SM BKN070 OVC085 06/M07 A3011 RMK AO2 SLP203 T00561072",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAUW",
       RawData = "KAUW 041554Z AUTO 11006KT 4SM BR BKN005 OVC055 04/03 A2956 RMK AO2 SLP023 T00440028",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAPN",
       RawData = "KAPN 041554Z AUTO 20003KT 10SM BKN050 OVC060 02/00 A2977 RMK AO2 RAE40 SLP086 P0000 T00220000",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAPC",
       RawData = "KAPC 041554Z 33005KT 10SM FEW015 OVC065 09/08 A3026 RMK AO2 SLP238 T00940078",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KALO",
       RawData = "KALO 041554Z 12011KT 10SM OVC025 12/07 A2947 RMK AO2 SLP981 T01170067",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAKR",
       RawData = "KAKR 041554Z AUTO 19007KT 10SM OVC100 09/M08 A2996 RMK AO2 SLP150 T00941083",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAKQ",
       RawData = "KAKQ 041554Z AUTO 22010G18KT 10SM CLR 14/M03 A3028 RMK AO2 SLP256 T01441028",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KAKH",
       RawData = "KAKH 041554Z AUTO 18005KT 10SM BKN043 BKN055 12/03 A3023 RMK AO2 SLP239 T01170033",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "KACY",
       RawData = "KACY 041554Z 19010G19KT 10SM OVC075 08/02 A3025 RMK AO2 SLP242 T00830022",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "K1V4",
       RawData = "K1V4 041554Z AUTO 00/M11 A3004 RMK AO1 SLP188 T00001111",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "K12N",
       RawData = "K12N 041554Z AUTO 19007KT 160V220 05/M04 A3016 RMK AO1 SLP225 T00501039",
       LastChange = "2025-03-04T15:54:00Z"
    },
    new Metar {
       Station = "TISX",
       RawData = "TISX 041553Z 11009KT 10SM CLR 29/23 A2999 RMK AO2 SLP154 T02940228 PNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "TIST",
       RawData = "TIST 041553Z 08005KT 10SM SCT025 27/23 A2998 RMK AO2 RAB27E48 SLP154 P0000 T02720233",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PHTO",
       RawData = "PHTO 041553Z 00000KT 10SM FEW026 BKN065 21/20 A3021 RMK AO2 SLP228 T02060200",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PHNL",
       RawData = "PHNL 041553Z 06015G22KT 10SM FEW025 SCT043 BKN050 24/17 A3019 RMK AO2 SLP222 T02440172 VISNO RWY04R $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PHLI",
       RawData = "PHLI 041553Z 06017KT 10SM FEW028 FEW033 SCT042 23/19 A3023 RMK AO2 SLP235 T02330194",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PHKO",
       RawData = "PHKO 041553Z 11006KT 10SM CLR 23/18 A3012 RMK AO2 SLP199 T02280178",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PHJR",
       RawData = "PHJR 041553Z AUTO 06008G16KT 10SM CLR 23/17 A3019 RMK AO2 SLP228 T02330167 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAYA",
       RawData = "PAYA 041553Z AUTO 02003KT 10SM CLR M01/M02 A2987 RMK AO2 SLP115 T10061022 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAWD",
       RawData = "PAWD 041553Z AUTO 01008KT 10SM CLR 02/00 A2978 RMK AO2 SLP085 T00220000 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAVL",
       RawData = "PAVL 041553Z AUTO 00000KT 10SM OVC017 M10/M13 A2979 RMK AO2 SLP089 T11001128 PWINO FZRANO TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PATK",
       RawData = "PATK 041553Z AUTO 04004KT 10SM CLR M01/M06 A2984 RMK AO2 SLP110 T10111056 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PASO",
       RawData = "PASO 041553Z AUTO 00000KT 10SM BKN120 01/00 A2975 RMK AO2 SLP073 T00110000 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PASN",
       RawData = "PASN 041553Z AUTO 06009KT 9SM -SN OVC033 M04/M09 A2957 RMK AO2 SNB00 SLP015 P0000 T10391089 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PASI",
       RawData = "PASI 041553Z 36006KT 10SM FEW027 SCT100 04/01 A2984 RMK AO2 SLP105 T00390011 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PASC",
       RawData = "PASC 041553Z 08016KT 10SM BKN130 M18/M21 A2992 RMK AO2 SLP132 T11831211 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAQT",
       RawData = "PAQT 041553Z AUTO 10017KT 6SM HZ OVC090 M16/M19 A2992 RMK AO2 PK WND 08030/1508 SLP132 T11611189 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAPB",
       RawData = "PAPB 041553Z AUTO A2952 RMK AO2 SLPNO PWINO FZRANO TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAOR",
       RawData = "PAOR 041553Z 00000KT 10SM CLR M19/M22 A2992 RMK AO2 SLP185 T11891222 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PANN",
       RawData = "PANN 041553Z AUTO 08008KT 10SM CLR 00/M07 RMK AO2 SLPNO T00001072 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PANC",
       RawData = "PANC 041553Z 12003KT 10SM SCT120 M01/M03 A2981 RMK AO2 SLP097 T10111033 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAMR",
       RawData = "PAMR 041553Z 00000KT 10SM SCT090 BKN130 00/M03 A2982 RMK AO2 SLP099 T00001028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PALH",
       RawData = "PALH 041553Z AUTO 03007KT 10SM CLR 00/M04 A2982 RMK AO2 SLP099 T00001039 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAKW",
       RawData = "PAKW 041553Z AUTO 04007KT 10SM OVC034 06/02 A2985 RMK AO2 SLP108 T00610022 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAKV",
       RawData = "PAKV 041553Z AUTO 00000KT 10SM UP FEW012 BKN038 OVC055 00/M01 A2976 RMK AO2 UPB07SNE07 SLP082 P0001 T00001006 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAKT",
       RawData = "PAKT 041553Z 14003KT 10SM OVC049 03/02 A2991 RMK AO2 SLP129 HARBOR WIND 10004KT T00330017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAIL",
       RawData = "PAIL 041553Z AUTO 09007KT 10SM OVC060 04/M01 A2975 RMK AO2 SLP076 T00441006 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAHO",
       RawData = "PAHO 041553Z 04006KT 10SM SCT120 04/M01 A2975 RMK AO2 SLP073 T00441011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAGY",
       RawData = "PAGY 041553Z AUTO 05011G17KT 10SM CLR 03/M02 A2995 RMK AO2 SLP141 T00331022 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAGK",
       RawData = "PAGK 041553Z AUTO 00000KT 10SM CLR M10/M11 A2992 RMK AO2 SLP167 T11001111 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAFA",
       RawData = "PAFA 041553Z 04004KT 10SM FEW200 M14/M16 A2986 RMK AO2 SLP124 T11391161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAEN",
       RawData = "PAEN 041553Z 03012KT 10SM OVC100 02/M01 A2981 RMK AO2 SLP096 T00171006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAEG",
       RawData = "PAEG 041553Z AUTO VRB03KT 10SM CLR M11/M14 A2995 RMK AO2 SLP161 T11111139 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PADQ",
       RawData = "PADQ 041553Z 06014KT 5SM -RA BR BKN010 OVC016 04/04 A2967 RMK AO2 SLP049 P0004 T00390039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PACV",
       RawData = "PACV 041553Z 00000KT 10SM SCT170 M03/M03 A2984 RMK AO2 SLP105 I1000 T10281033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PACD",
       RawData = "PACD 041553Z AUTO 00000KT 10SM OVC021 M02/M04 A2959 RMK AO2 SNB04E13 SLP020 P0000 T10221039 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PABR",
       RawData = "PABR 041553Z 09020KT 4SM HZ OVC065 M14/M17 A2987 RMK PK WND 10029/1459",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PABI",
       RawData = "PABI 041553Z 13012G20KT 10SM FEW130 SCT200 M02/M07 A2987 RMK AO2 SLP138 T10221072 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PAAQ",
       RawData = "PAAQ 041553Z AUTO 00000KT 10SM CLR 01/M04 A2981 RMK AO2 SLP097 T00061044 TSNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "MMQT",
       RawData = "MMQT 041553Z 26014KT 10SM SKC 22/M01 A3031",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KZZV",
       RawData = "KZZV 041553Z AUTO 18012KT 10SM CLR 12/M06 A2999 RMK AO2 SLP157 T01221061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KYKM",
       RawData = "KYKM 041553Z 00000KT 10SM CLR 03/M01 A3005 RMK AO2 SLP180 T00281006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KYIP",
       RawData = "KYIP 041553Z 17008KT 10SM OVC041 04/01 A2986 RMK AO2 RAE46 SLP115 P0000 T00440011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KWVI",
       RawData = "KWVI 041553Z AUTO 04003KT 10SM FEW070 08/06 A3028 RMK AO2 SLP253 T00830061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KWST",
       RawData = "KWST 041553Z AUTO 21009KT 10SM OVC080 04/M02 A3026 RMK AO2 SLP246 T00441022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KWRL",
       RawData = "KWRL 041553Z AUTO 31015KT 10SM OVC065 M01/M05 A3004 RMK AO2 SLP199 T10111050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVUO",
       RawData = "KVUO 041553Z AUTO 07004KT 8SM -RA BKN044 BKN050 OVC100 08/06 A3008 RMK AO2 RAB37 SLP184 P0000 T00780056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVRB",
       RawData = "KVRB 041553Z 12017G27KT 10SM BKN037 BKN045 24/15 A3014 RMK AO2 PK WND 13029/1516 SLP206 T02390150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVLD",
       RawData = "KVLD 041553Z 17016G23KT 10SM FEW036 FEW042 24/13 A3012 RMK AO2 SLP205 T02440133",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVIH",
       RawData = "KVIH 041553Z AUTO 16020G31KT 10SM OVC110 13/06 A2950 RMK AO2 PK WND 17036/1529 SLP983 T01330061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVGT",
       RawData = "KVGT 041553Z 30006KT 10SM CLR 13/M03 A3014 RMK AO2 SLP219 T01281033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVEL",
       RawData = "KVEL 041553Z AUTO 00000KT 10SM FEW075 03/M04 A2995 RMK AO2 SLP145 T00331044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KVCB",
       RawData = "KVCB 041553Z AUTO 19003KT 10SM BKN075 OVC100 11/07 A3025 RMK AO2 SLP243 T01060067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUUU",
       RawData = "KUUU 041553Z AUTO 21011G19KT 10SM OVC080 06/M02 A3025 RMK AO2 SLP243 T00561017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUTS",
       RawData = "KUTS 041553Z AUTO 25006KT 10SM OVC050 14/11 A2961 RMK AO2 RAE16 SLP025 P0006 T01390106",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUNV",
       RawData = "KUNV 041553Z 21007KT 10SM SCT080 BKN110 06/M07 A3009",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUNO",
       RawData = "KUNO 041553Z AUTO 14012G32KT 10SM FEW026 OVC050 13/06 A2953 RMK AO2 PK WND 15032/1544 SLP994 T01330061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUIL",
       RawData = "KUIL 041553Z AUTO 10003KT 10SM -RA SCT027 OVC043 07/05 A2996 RMK AO2 RAB49 SLP148 P0000 T00720050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KUAO",
       RawData = "KUAO 041553Z 16003KT 9SM -RA SCT040 OVC049 06/05 A3008 RMK AO2 RAB24 SLP186 P0002 T00610050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTYS",
       RawData = "KTYS 041553Z 05004KT 10SM FEW045 BKN170 BKN250 12/M03 A3006 RMK AO2 SLP180 T01171033 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTYR",
       RawData = "KTYR 041553Z 22005KT 5SM BR FEW005 OVC075 13/12 A2951 RMK AO2 RAE24 SLP989 P0003 T01280117",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTWF",
       RawData = "KTWF 041553Z 26015KT 10SM OVC065 04/M02 A3009 RMK AO2 SLP182 T00391017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTVR",
       RawData = "KTVR 041553Z AUTO 15019G32KT 10SM FEW026 BKN085 19/13 A2965 RMK AO2 PK WND 13032/1530 SLP048 T01890133",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTVL",
       RawData = "KTVL 041553Z AUTO 19003KT 10SM FEW090 01/M08 A3015 RMK AO2 SLP210 T00111078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTVC",
       RawData = "KTVC 041553Z 17006KT 10SM FEW017 OVC027 05/00 A2967 RMK AO2 PRESFR SLP051 T00500000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTUS",
       RawData = "KTUS 041553Z 19006KT 10SM CLR 10/M02 A3018 RMK AO2 SLP205 T01001017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTUP",
       RawData = "KTUP 041553Z 15013G29KT 10SM FEW085 16/04 A2985 RMK AO2 PK WND 14029/1545 PRESFR SLP107 T01610044 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTTN",
       RawData = "KTTN 041553Z 18007KT 10SM OVC070 07/00 A3021 RMK AO2 SLP224 T00720000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTTD",
       RawData = "KTTD 041553Z 11004KT 10SM FEW048 OVC060 07/06 A3007 RMK AO2 SLP182 T00720056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTRL",
       RawData = "KTRL 041553Z AUTO 19009KT 10SM FEW007 SCT110 11/10 A2953 RMK AO2 SLP995 T01110100",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTRI",
       RawData = "KTRI 041553Z 17012KT 10SM BKN044 BKN060 08/01 A3010 RMK AO2 SLP189 T00780006 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTPA",
       RawData = "KTPA 041553Z 12013G21KT 10SM BKN250 24/15 A3010 RMK AO2 SLP191 T02390150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTOR",
       RawData = "KTOR 041553Z AUTO 34026G41KT 10SM SCT025 OVC055 01/M06 A2985 RMK AO2 PK WND 33041/1546 SLP116 T00111056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTOP",
       RawData = "KTOP 041553Z 13018G26KT 4SM -RA BKN055 OVC070 12/08 A2934 RMK AO2 PK WND 13029/1514 RAB33 PRESFR SLP933 P0000 T01220083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTOI",
       RawData = "KTOI 041553Z AUTO 14013G23KT 10SM BKN020 19/12 A3002 RMK AO2 SLP162 T01890122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTMB",
       RawData = "KTMB 041553Z 11017G28KT 10SM SCT028 BKN036 27/19 A3009 RMK AO2 PK WND 08031/1515 SLP189 T02670189 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTLH",
       RawData = "KTLH 041553Z 15015G29KT 10SM OVC032 23/14 A3007 RMK AO2 PK WND 16037/1525 SLP181 T02330144",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTIW",
       RawData = "KTIW 041553Z 00000KT 10SM BKN038 BKN110 07/06 A3003 RMK AO2 SLP171 T00670061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTHV",
       RawData = "KTHV 041553Z AUTO 18005KT 10SM FEW085 FEW110 09/M04 A3016 RMK AO2 SLP219 T00941044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTDZ",
       RawData = "KTDZ 041553Z AUTO 19005KT 10SM OVC060 07/M03 A2989 RMK AO2 RAE06 SLP125 P0000 T00721028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTCS",
       RawData = "KTCS 041553Z AUTO 32013G24KT 10SM CLR 08/M07 A2995 RMK AO2 PK WND 31038/1535 SLP115 T00831067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTCL",
       RawData = "KTCL 041553Z 10SM CLR 17/08 A2994 RMK AO2 SLP136 T01720078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KTCC",
       RawData = "KTCC 041553Z AUTO 35033G44KT 10SM CLR 09/01 A2959 RMK AO2 PK WND 34048/1540 SLP000 T00890006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSTS",
       RawData = "KSTS 041553Z 00000KT 10SM OVC060 08/08 A3026 RMK AO2 RAE1455 SLP240 P0000 T00830083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSTP",
       RawData = "KSTP 041553Z 00000KT 3SM BR BKN022 OVC030 06/04 A2959 RMK AO2 SLP021 T00610039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSPW",
       RawData = "KSPW 041553Z AUTO 36015G26KT 8SM -RA OVC005 04/02 A2948 RMK AO2 PK WND 36026/1546 RAB29 SLP988 P0000 T00390022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSPG",
       RawData = "KSPG 041553Z 14013KT 10SM CLR 24/17 A3007 RMK AO1 PK WND 12031/1522 SLP182 T02390167",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSPB",
       RawData = "KSPB 041553Z AUTO 00000KT 7SM -RA FEW023 BKN039 OVC045 06/05 A3006 RMK AO2 RAB20 SLP179 P0001 T00610050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSNY",
       RawData = "KSNY 041553Z AUTO 36028G41KT 10SM OVC014 01/M04 A2972 RMK AO2 PK WND 35042/1525 SLP069 T00111039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSNS",
       RawData = "KSNS 041553Z 15008KT 10SM SCT022 BKN080 09/06 A3028 RMK AO2 SLP261 T00890061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSNA",
       RawData = "KSNA 041553Z 11008KT 10SM SCT031 SCT042 BKN250 13/06 A3024 RMK AO2 SLP240 T01330061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSMQ",
       RawData = "KSMQ 041553Z AUTO VRB05KT 10SM OVC075 07/M01 A3020 RMK AO2 SLP228 T00671006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSMF",
       RawData = "KSMF 041553Z 16009KT 10SM OVC100 10/07 A3025 RMK AO2 SLP243 T01000067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSLN",
       RawData = "KSLN 041553Z 00000KT 10SM CLR 12/M01 A2927 RMK AO2 SLP906 T01221006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSJC",
       RawData = "KSJC 041553Z 16006KT 10SM FEW026 BKN075 BKN120 09/06 A3026 RMK AO2 SLP247 T00940056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSIY",
       RawData = "KSIY 041553Z AUTO 02005KT 10SM OVC050 04/02 A3015 RMK AO2 SLP228 T00440017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSHN",
       RawData = "KSHN 041553Z AUTO 00000KT 9SM FEW002 FEW024 BKN110 04/04 A3002 RMK AO2 SLP168 T00390039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSFF",
       RawData = "KSFF 041553Z VRB03KT 10SM FEW070 OVC090 04/01 A3009 RMK AO2 SLP196 T00390011 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSFB",
       RawData = "KSFB 041553Z 15017G27KT 10SM BKN060 23/14 A3014 RMK AO2 PK WND 15027/1551 SLP204 T02280139",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSEG",
       RawData = "KSEG 041553Z AUTO 18007KT 10SM OVC075 05/M06 A3016 RMK AO2 SLP217 T00501056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSEA",
       RawData = "KSEA 041553Z 12006KT 10SM FEW010 SCT042 BKN120 BKN200 06/05 A3002 RMK AO2 SLP176 T00610050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSDM",
       RawData = "KSDM 041553Z COR 00000KT 10SM OVC027 14/07 A3024 RMK AO2 SLPNO T01390067 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSDL",
       RawData = "KSDL 041553Z VRB05KT 10SM CLR 12/M01 A3016 RMK AO2 SLP205 T01171011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSBM",
       RawData = "KSBM 041553Z AUTO 17010G21KT 10SM OVC046 06/02 A2965 RMK AO2 SLP044 T00610017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSBA",
       RawData = "KSBA 041553Z 05004KT 10SM CLR 13/09 A3025 RMK AO2 SLP242 T01280089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSAV",
       RawData = "KSAV 041553Z 14013KT 10SM FEW035 SCT060 BKN250 22/13 A3018 RMK AO2 SLP220 T02170128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSAF",
       RawData = "KSAF 041553Z 34010KT 10SM CLR 04/M04 A2984 RMK AO2 SLP087 T00441044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KSAC",
       RawData = "KSAC 041553Z AUTO 15004KT 10SM OVC100 10/07 A3026 RMK AO2 SLP247 T01000067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRWL",
       RawData = "KRWL 041553Z AUTO 33012KT 9SM -SN BKN017 OVC024 M01/M05 A2994 RMK AO2 SLP142 P0000 T10111050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRWI",
       RawData = "KRWI 041553Z AUTO 19009KT 10SM CLR 16/M01 A3028 RMK AO2 SLP255 T01561011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRTN",
       RawData = "KRTN 041553Z AUTO 01029G43KT 10SM CLR 05/M02 A2964 RMK AO2 PK WND 35045/1458 SLP018 T00501022 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRSW",
       RawData = "KRSW 041553Z 11016G26KT 10SM BKN034 24/17 A3008 RMK AO1 PK WND 10026/1551 SLP183 T02440172",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRQE",
       RawData = "KRQE 041553Z AUTO 27006KT 10SM CLR 01/M04 A3002 RMK AO2 SLP154 T00061044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRNT",
       RawData = "KRNT 041553Z 16003KT 10SM SCT047 07/05 A3004 RMK AO2 SLP177 T00670050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRNM",
       RawData = "KRNM 041553Z AUTO 03007KT SCT022 09/05 A3022 RMK AO2 SLP235 T00940050 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRME",
       RawData = "KRME 041553Z 08006KT 10SM BKN034 OVC060 02/M06 A3007 RMK AO2 SLP187 T00171061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRIL",
       RawData = "KRIL 041553Z AUTO 26016KT 10SM FEW047 BKN060 OVC090 02/M01 A2994 RMK AO2 SLP139 T00171006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRDD",
       RawData = "KRDD 041553Z 19006KT 10SM OVC044 10/06 A3022 RMK AO2 SLP232 T01000061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRBG",
       RawData = "KRBG 041553Z AUTO 11003KT 8SM -RA OVC047 08/07 A3011 RMK AO2 RAE13B28 SLP197 P0001 T00830072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRBD",
       RawData = "KRBD 041553Z 23009G17KT 10SM CLR 13/09 A2948 RMK AO2 SLP978 T01280089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRAL",
       RawData = "KRAL 041553Z 00000KT 10SM CLR 14/05 A3025 RMK AO2 SLP235 T01440050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KRAC",
       RawData = "KRAC 041553Z AUTO 17012KT 10SM OVC031 08/05 A2967 RMK AO2 SLP050 T00830050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPWA",
       RawData = "KPWA 041553Z 16016KT 10SM CLR 12/08 A2933 RMK AO2 SLP925 T01220083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPUW",
       RawData = "KPUW 041553Z AUTO 00000KT 10SM OVC085 04/02 A3007 RMK AO2 SLP199 T00390022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPUC",
       RawData = "KPUC 041553Z AUTO 33011G20KT 10SM BKN044 06/M04 A3000 RMK AO2 SLP167 T00611039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPUB",
       RawData = "KPUB 041553Z 35027G41KT 10SM SCT095 09/M04 A2969 RMK AO2 PK WND 33043/1508 SLP034 T00891044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPTK",
       RawData = "KPTK 041553Z COR 18005KT 6SM BR BKN028 OVC036 02/00 A2983 RMK AO2 RAE50 SLP109 P0000 T00170000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPSP",
       RawData = "KPSP 041553Z VRB03KT 10SM CLR 13/02 A3018 RMK AO2 SLP221 T01330017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPSC",
       RawData = "KPSC 041553Z 10004KT 10SM CLR 07/03 A3008 RMK AO2 SLP187 T00670033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPRC",
       RawData = "KPRC 041553Z 00000KT 10SM CLR 05/M04 A3014 RMK AO2 SLP187 T00501044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPQL",
       RawData = "KPQL 041553Z AUTO 15019G26KT 10SM SCT026 BKN033 21/16 A2992 RMK AO2 PK WND 16033/1512 SLP132 T02060156",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPOU",
       RawData = "KPOU 041553Z 15006KT 10SM SCT090 SCT110 07/M05 A3016 RMK AO2 SLP211 T00671050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPOF",
       RawData = "KPOF 041553Z AUTO 15018G26KT 10SM OVC090 13/04 A2964 RMK AO2 PK WND 16026/1553 PRESFR SLP036 T01330039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPNS",
       RawData = "KPNS 041553Z 15015G24KT 10SM BKN019 OVC031 21/14 A2995 RMK AO2 SLP145 T02060144",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPNC",
       RawData = "KPNC 041553Z AUTO 15011KT 10SM CLR 11/08 A2931 RMK AO2 SLP920 T01060083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPMP",
       RawData = "KPMP 041553Z 10017G23KT 10SM FEW027 BKN045 OVC065 24/18 A3010 RMK AO2 PK WND 10029/1500 SLP195 T02440178",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPMD",
       RawData = "KPMD 041553Z 00000KT 10SM CLR 08/00 A3019 RMK AO2 SLP223 T00780000 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPKD",
       RawData = "KPKD 041553Z AUTO 36013G21KT 10SM OVC080 M01/M04 A2970 RMK AO2 SLP074 T10061044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPKB",
       RawData = "KPKB 041553Z 17009KT 10SM CLR 13/M10 A3002 RMK AO2 SLP169 T01331100 PNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPIL",
       RawData = "KPIL 041553Z AUTO 20016G29KT 7SM CLR 28/22 A2963 RMK AO2 PK WND 19038/1533 RAE46 SLP034 P0000 T02780222",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPIH",
       RawData = "KPIH 041553Z 24008KT 10SM -SN FEW003 BKN050 BKN090 02/00 A3009 RMK AO2 SLP201 P0000 T00220000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPIE",
       RawData = "KPIE 041553Z 14017G26KT 10SM CLR 26/16 A3009 RMK AO2 PK WND 12026/1504 SLP188 T02560156",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPHD",
       RawData = "KPHD 041553Z AUTO 18006KT 10SM FEW110 12/M07 A2999 RMK AO2 SLP161 T01171072 PWINO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPGD",
       RawData = "KPGD 041553Z 13014G25KT 10SM BKN034 25/17 A3010 RMK AO2 SLP191 T02500167 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPGA",
       RawData = "KPGA 041553Z AUTO 12004KT 10SM CLR 06/M02 A3007 RMK AO2 SLP173 T00561022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPEO",
       RawData = "KPEO 041553Z AUTO 19008KT 10SM OVC070 05/M07 A3002 RMK AO2 SLP175 T00501067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPDX",
       RawData = "KPDX 041553Z 08004KT 5SM -RA BR FEW030 BKN047 OVC080 08/06 A3007 RMK AO2 RAB35 SLP181 P0001 T00780056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPDT",
       RawData = "KPDT 041553Z 11005KT 10SM CLR 05/01 A3006 RMK AO2 SLP180 T00500006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPDK",
       RawData = "KPDK 041553Z VRB03KT 10SM BKN025 BKN035 OVC055 14/07 A3012 RMK AO2 SLP199 T01390067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPBI",
       RawData = "KPBI 041553Z 08020G28KT 10SM SCT027 BKN050 BKN065 24/16 A3013 RMK AO2 PK WND 08030/1508 SLP202 T02390161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPBG",
       RawData = "KPBG 041553Z AUTO 15010KT 10SM BKN090 BKN110 01/M08 A3002 RMK AO2 SLP168 T00061083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPAH",
       RawData = "KPAH 041553Z 17017G29KT 10SM CLR 17/M01 A2973 RMK AO2 PK WND 15030/1518 SLP065 T01721011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KPAE",
       RawData = "KPAE 041553Z 16005KT 10SM CLR 08/04 A3003 RMK AO2 SLP170 T00780044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KP68",
       RawData = "KP68 041553Z AUTO 21003KT 01/M01 A3014 RMK AO1 SLP202 T00111011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOXB",
       RawData = "KOXB 041553Z AUTO 21011G20KT 10SM CLR 10/04 A3029 RMK AO2 SLP255 T01000039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOWD",
       RawData = "KOWD 041553Z 21011G23KT 10SM OVC080 06/M08 A3020 RMK AO2 SLP227 T00611078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOVE",
       RawData = "KOVE 041553Z AUTO 15014KT 10SM OVC090 11/06 A3026 RMK AO2 SLP249 T01060061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOSU",
       RawData = "KOSU 041553Z 19012G22KT 10SM CLR 13/M06 A2994 RMK AO2 SLP140 T01281056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOSH",
       RawData = "KOSH 041553Z 00000KT 10SM OVC048 07/04 A2962 RMK AO2 SLP037 T00670039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KORL",
       RawData = "KORL 041553Z 11016G22KT 10SM SCT043 OVC055 24/14 A3014 RMK AO2 PK WND 11027/1543 SLP208 T02390139",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOQT",
       RawData = "KOQT 041553Z AUTO VRB03KT 10SM CLR 13/M06 A3008 RMK AO2 SLP190 T01331061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KONT",
       RawData = "KONT 041553Z 10005KT 10SM FEW030 FEW250 10/04 A3025 RMK AO2 SLP245 T01000044 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KONO",
       RawData = "KONO 041553Z AUTO 08003KT 10SM CLR 04/00 A3013 RMK AO2 SLP213 T00390000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOMK",
       RawData = "KOMK 041553Z AUTO 00000KT 10SM OVC080 02/M03 A3006 RMK AO2 SLP192 T00171028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOLF",
       RawData = "KOLF 041553Z AUTO 33011KT 10SM OVC055 M01/M04 A3012 RMK AO2 SNB19E32 SLP223 P0000 T10111044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOJC",
       RawData = "KOJC 041553Z 15006KT 4SM RA BR BKN005 BKN025 OVC047 11/11 A2939 RMK AO2 PRESFR SLP949 P0018 T01110106",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOGB",
       RawData = "KOGB 041553Z AUTO 13009KT 10SM SCT041 BKN060 18/09 A3021 RMK AO2 SLP228 T01830094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KOAK",
       RawData = "KOAK 041553Z 14008KT 10SM SCT017 BKN060 BKN110 11/07 A3026 RMK AO2 SLP246 T01060072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNUW",
       RawData = "KNUW 041553Z 13012G18KT 10SM FEW012 BKN034 BKN150 BKN200 08/04 A3001 RMK AO2 SLP166 T00830044 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNUI",
       RawData = "KNUI 041553Z AUTO 21011KT 10SM CLR 13/03 A3024 RMK AO2 SLP241 T01280028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNSI",
       RawData = "KNSI 041553Z 32018G24KT 10SM FEW007 FEW250 11/09 A3022 RMK AO2 SLPNO T01110094 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNRS",
       RawData = "KNRS 041553Z 12006KT 10SM SCT022 BKN032 12/07 A3025 RMK AO2 SLP243 T01170067 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNQX",
       RawData = "KNQX 041553Z 13015KT 10SM SCT035 27/17 A3006 RMK AO2 SLP176 T02670172 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNIP",
       RawData = "KNIP 041553Z 14014G21KT 10SM SCT036 BKN250 23/14 A3015 RMK AO2 SLP206 T02280139",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KNEN",
       RawData = "KNEN 041553Z AUTO 11008G18KT 10SM SCT037 BKN048 22/14 A3015 RMK AO2 SLP274 T02170139 TSNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMYV",
       RawData = "KMYV 041553Z AUTO 14008KT 10SM OVC100 10/06 A3027 RMK AO2 SLP252 T01000061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMYF",
       RawData = "KMYF 041553Z COR 09006KT 10SM BKN029 11/05 A3024 RMK AO2 SLP239 T01110050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMWL",
       RawData = "KMWL 041553Z AUTO 25019G30KT 10SM CLR 16/02 A2946 RMK AO2 PK WND 25030/1544 SLP967 T01560022 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMVY",
       RawData = "KMVY 041553Z 22016G26KT 10SM OVC080 07/M02 A3027 RMK AO2 PK WND 22026/1538 SLP250 T00671022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMTO",
       RawData = "KMTO 041553Z AUTO 17018G36KT OVC095 13/00 A2969 RMK AO2 PK WND 19036/1544 SLP053 T01330000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMTH",
       RawData = "KMTH 041553Z AUTO 11009KT 10SM CLR 26/17 A3006 RMK AO2 SLP178 T02560167",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMSS",
       RawData = "KMSS 041553Z AUTO 23009G17KT 10SM OVC045 03/M06 A2999 RMK AO2 PK WND 22028/1525 SLP162 T00281061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMSO",
       RawData = "KMSO 041553Z 11008KT 10SM SCT085 02/M01 A3009 RMK AO2 SLP213 T00171011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMSL",
       RawData = "KMSL 041553Z AUTO 15015G25KT 10SM CLR 17/07 A2991 RMK AO2 PRESFR SLP125 T01670072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMRB",
       RawData = "KMRB 041553Z 00000KT 10SM OVC080 09/M07 A3014 RMK AO2 SLP210 T00891067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMPO",
       RawData = "KMPO 041553Z AUTO 23008G17KT 10SM BKN055 07/M08 A3009 RMK AO2 SLP206 T00671083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMOD",
       RawData = "KMOD 041553Z 00000KT 10SM BKN100 09/06 A3027 RMK AO2 SLP248 T00890061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMNN",
       RawData = "KMNN 041553Z AUTO 20015G23KT 9SM FEW100 11/M04 A2991 RMK AO2 SLP134 T01111044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMMV",
       RawData = "KMMV 041553Z AUTO 00000KT 6SM -RA BR FEW016 BKN036 OVC050 05/04 A3007 RMK AO2 RAB1454 SLP182 P0002 T00500044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMMK",
       RawData = "KMMK 041553Z AUTO 18010G18KT 10SM BKN080 06/M03 A3021 RMK AO2 SLP231 T00561028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMLU",
       RawData = "KMLU 041553Z 15016G28KT 10SM OVC019 19/14 A2958 RMK AO2 PK WND 15032/1529 SLP015 T01890144",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMLT",
       RawData = "KMLT 041553Z AUTO VRB04G17KT 10SM OVC065 M03/M12 A3007 RMK AO2 SLP193 T10331122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMLS",
       RawData = "KMLS 041553Z AUTO 33009KT 10SM BKN015 OVC024 M01/M03 A3010 RMK AO2 SLP216 T10111028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMLB",
       RawData = "KMLB 041553Z 12015G25KT 10SM SCT045 BKN055 23/15 A3012 RMK AO2 PK WND 11027/1508 SLP198 T02330150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMKO",
       RawData = "KMKO 041553Z AUTO 06019G24KT 9SM -RA SCT065 OVC085 12/11 A2933 RMK AO2 PRESFR SLP928 P0007 T01170111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMKL",
       RawData = "KMKL 041553Z 16015G39KT 10SM FEW095 15/M02 A2979 RMK AO1 PK WND 15039/1546 SLP086 T01501022 PNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMIW",
       RawData = "KMIW 041553Z AUTO 15009KT 10SM CLR 12/09 A2944 RMK AO2 SLP970 T01170089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMIE",
       RawData = "KMIE 041553Z 20016G30KT 10SM CLR 16/M03 A2979 RMK AO2 PK WND 19030/1549 SLP086 T01561033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMIA",
       RawData = "KMIA 041553Z 10017G26KT 10SM SCT027 BKN033 BKN045 BKN250 26/18 A3010 RMK AO2 PK WND 11029/1514 SLP192 T02560178 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMHT",
       RawData = "KMHT 041553Z 19007KT 10SM OVC080 03/M09 A3013 RMK AO2 SLP222 T00331089 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMGY",
       RawData = "KMGY 041553Z AUTO 20016KT 10SM CLR 13/M04 A2989 RMK AO2 SLP124 T01331044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMGW",
       RawData = "KMGW 041553Z VRB05KT 10SM CLR 16/M10 A3005 RMK AO2 SLP180 T01561100",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMGM",
       RawData = "KMGM 041553Z 11010KT 10SM OVC022 18/11 A3001 RMK AO2 SLP160 T01780111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMFR",
       RawData = "KMFR 041553Z 05003KT 10SM OVC050 07/03 A3015 RMK AO2 SLP212 T00670033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMFE",
       RawData = "KMFE 041553Z 31007KT 6SM HZ CLR 27/20 A2969 RMK AO2 SLP052 T02670200",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMDW",
       RawData = "KMDW 041553Z 19013G22KT 10SM FEW029 OVC035 08/04 A2972 RMK AO2 PK WND 17029/1543 SLP069 T00830039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMCO",
       RawData = "KMCO 041553Z 10016G23KT 10SM SCT043 BKN055 BKN250 24/14 A3013 RMK AO2 SLP203 T02390144",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMCN",
       RawData = "KMCN 041553Z 12007KT 10SM FEW038 SCT046 BKN060 17/10 A3013 RMK AO2 SLP201 T01720100",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMCI",
       RawData = "KMCI 041553Z 16012KT 3SM RA BR SCT011 SCT021 OVC060 12/11 A2939 RMK AO2 SLP949 P0008 T01170111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMCE",
       RawData = "KMCE 041553Z AUTO 00000KT 10SM OVC100 08/06 A3027 RMK AO2 SLP250 T00830056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMCB",
       RawData = "KMCB 041553Z AUTO 13013G26KT 10SM OVC015 18/14 A2977 RMK AO2 PK WND 13029/1531 SLP076 T01780139",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMBS",
       RawData = "KMBS 041553Z 19011KT 10SM BKN022 OVC047 04/02 A2978 RMK AO2 RAE1454 SLP091 P0000 T00440017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMAI",
       RawData = "KMAI 041553Z AUTO 15013G24KT 10SM SCT027 22/15 A3003 RMK AO2 PK WND 17030/1501 RAB04E11 SLP166 P0000 T02170150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KMAE",
       RawData = "KMAE 041553Z AUTO 06003KT 10SM CLR 07/05 A3027 RMK AO2 SLP251 T00720050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLXV",
       RawData = "KLXV 041553Z AUTO 35011G19KT 5SM -SN FEW023 BKN030 OVC045 M04/M09 A2983 RMK AO2 SNB29 SLP068 P0000 T10391094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLWV",
       RawData = "KLWV 041553Z AUTO 17021G27KT 10SM BKN055 15/01 A2976 RMK AO2 PK WND 17029/1531 SLP078 T01500011 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLWD",
       RawData = "KLWD 041553Z AUTO 11007KT 8SM -RA OVC080 11/11 A2939 RMK AO2 SLP953 P0003 T01110106",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLVS",
       RawData = "KLVS 041553Z AUTO 35020G32KT 10SM CLR 07/M11 A2966 RMK AO2 PK WND 35035/1517 SLP010 T00671111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLVM",
       RawData = "KLVM 041553Z AUTO 26003KT 9SM OVC043 M02/M04 A3009 RMK AO2 SNE53 SLP223 P0000 T10221039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLVK",
       RawData = "KLVK 041553Z 00000KT 10SM BKN070 OVC085 10/06 A3025 RMK AO2 SLP242 T01000056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLUK",
       RawData = "KLUK 041553Z 19010KT 10SM FEW100 14/M03 A2993 RMK AO2 SLP135 T01441033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLSE",
       RawData = "KLSE 041553Z 12004KT 10SM OVC019 09/04 A2953 RMK AO2 RAB40E53 SLP003 P0000 T00940039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLPR",
       RawData = "KLPR 041553Z AUTO 19011KT 10SM FEW110 10/M06 A2992 RMK AO2 SLP135 T01001056 PWINO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLOZ",
       RawData = "KLOZ 041553Z AUTO 18015G27KT 10SM CLR 15/M07 A3000 RMK AO2 PK WND 18027/1518 SLP157 T01501072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLOU",
       RawData = "KLOU 041553Z 18018G27KT 10SM BKN070 16/M04 A2988 RMK AO2 PK WND 19031/1535 SLP117 T01611044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLOL",
       RawData = "KLOL 041553Z AUTO 00000KT 10SM OVC110 M02/M05 A3016 RMK AO2 SLP226 T10221050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLNS",
       RawData = "KLNS 041553Z 17007KT 10SM BKN090 07/M02 A3018 RMK AO2 SLP223 T00671017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLMT",
       RawData = "KLMT 041553Z 00000KT 2SM -SN BR OVC026 01/00 A3012 RMK AO2 RAB40E47SNB47 SLP204 P0000 T00060000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLLQ",
       RawData = "KLLQ 041553Z AUTO 15013G25KT 10SM OVC018 17/12 A2956 RMK AO2 PK WND 15029/1514 SLP008 T01720122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLKV",
       RawData = "KLKV 041553Z AUTO 16008KT 10SM OVC017 02/00 A3013 RMK AO2 SLP231 T00170000 FZRANO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLHX",
       RawData = "KLHX 041553Z AUTO 35029G48KT 8SM OVC035 06/M02 A2970 RMK AO2 PK WND 34051/1541 SLP039 T00561017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLHQ",
       RawData = "KLHQ 041553Z AUTO 18013G19KT 10SM CLR 13/M07 A2997 RMK AO2 SLP150 T01281067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLGB",
       RawData = "KLGB 041553Z 08005KT 10SM BKN037 12/07 A3023 RMK AO2 SLP237 T01220067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLFK",
       RawData = "KLFK 041553Z AUTO 28012G22KT 10SM FEW038 OVC044 13/13 A2958 RMK AO2 PK WND 29051/1519 WSHFT 1508 LTG DSNT NE-S RAB07E46 TSB12E27 SLP013 P0053 T01330128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLEE",
       RawData = "KLEE 041553Z 13010KT 10SM FEW037 23/15 A3014 RMK AO2 SLP205 T02330150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLEB",
       RawData = "KLEB 041553Z 23004KT 10SM OVC075 01/M09 A3010 RMK AO2 SLP204 T00061094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLAX",
       RawData = "KLAX 041553Z 09009KT 8SM SCT020 BKN032 12/08 A3025 RMK AO2 SLP242 T01220078 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLAW",
       RawData = "KLAW 041553Z 25012G25KT 10SM CLR 14/01 A2932 RMK AO2 PK WND 23027/1528 SLP923 T01440006 PNO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLAN",
       RawData = "KLAN 041553Z 18008KT 10SM OVC018 06/02 A2980 RMK AO2 SLP098 T00560022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KLAA",
       RawData = "KLAA 041553Z AUTO 35032G49KT 10SM OVC032 06/00 A2958 RMK AO2 PK WND 34055/1533 SLP003 T00560000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KJKL",
       RawData = "KJKL 041553Z AUTO 19009G14KT 10SM CLR 14/M08 A3001 RMK AO2 SLP160 T01441078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KJER",
       RawData = "KJER 041553Z AUTO 26010KT 10SM CLR 03/M01 A3009 RMK AO2 SLP202 T00281006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KJBR",
       RawData = "KJBR 041553Z AUTO 16024G32KT 10SM BKN085 16/04 A2964 RMK AO2 PK WND 14038/1500 SLP037 T01560044 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KIWI",
       RawData = "KIWI 041553Z AUTO 20003KT 10SM SCT080 02/M09 A3014 RMK AO2 SLP209 T00221094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KITR",
       RawData = "KITR 041553Z AUTO 35034G57KT 10SM FEW018 FEW025 OVC080 03/00 A2957 RMK AO2 PK WND 34060/1536 SLP000 T00280000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KIPL",
       RawData = "KIPL 041553Z AUTO 24004KT 10SM CLR 13/04 A3016 RMK AO2 SLP214 T01330044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KILM",
       RawData = "KILM 041553Z 14010G21KT 10SM FEW060 18/07 A3030 RMK AO2 SLP258 T01780067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KIDA",
       RawData = "KIDA 041553Z 21013KT 9SM OVC004 01/M01 A3008 RMK AO2 SLP199 T00111006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KICT",
       RawData = "KICT 041553Z 18010KT 10SM OVC130 11/06 A2929 RMK AO2 SLP915 T01110061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KIAG",
       RawData = "KIAG 041553Z 20011KT 10SM FEW060 BKN090 OVC110 07/M04 A2995 RMK AO2 SLP151 T00721044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHZY",
       RawData = "KHZY 041553Z AUTO 17007KT 10SM OVC090 07/M06 A2995 RMK AO2 SLP148 T00721061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHVR",
       RawData = "KHVR 041553Z AUTO 28004KT 10SM CLR M06/M07 A3018 RMK AO2 SLP252 T10561067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHVN",
       RawData = "KHVN 041553Z 18012KT 8SM SCT085 BKN250 07/00 A3023 RMK AO2 SLP236 T00670000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHUL",
       RawData = "KHUL 041553Z AUTO 21011G16KT 10SM FEW049 BKN075 M04/M13 A3003 RMK AO2 SLP181 T10441128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHUF",
       RawData = "KHUF 041553Z 18015G24KT 10SM BKN055 OVC070 14/00 A2976 RMK AO2 PK WND 17031/1458 SLP077 T01440000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHSV",
       RawData = "KHSV 041553Z 16018G26KT 10SM SCT025 BKN160 BKN250 16/08 A2996 RMK AO2 PK WND 17026/1549 SLP142 T01610083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHRI",
       RawData = "KHRI 041553Z AUTO 00000KT 10SM CLR 06/02 A3008 RMK AO2 SLP186 T00610017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHQM",
       RawData = "KHQM 041553Z AUTO 11010KT 9SM -RA SCT024 OVC039 06/05 A3000 RMK AO2 RAB42 SLP163 P0000 T00610050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHLN",
       RawData = "KHLN 041553Z 33003KT 10SM FEW047 BKN060 01/M03 A3010 RMK AO2 SLP237 T00111033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHLG",
       RawData = "KHLG 041553Z 20011G19KT 10SM CLR 13/M10 A3001 RMK AO2 SLP168 T01281100",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHLC",
       RawData = "KHLC 041553Z AUTO 34030G41KT 10SM OVC015 05/02 A2939 RMK AO2 PK WND 34046/1511 SLP953 T00500022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHKY",
       RawData = "KHKY 041553Z 20006KT 10SM SCT041 12/M01 A3021 RMK AO2 SLP220 T01221006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHKS",
       RawData = "KHKS 041553Z 15016G27KT 10SM FEW036 SCT075 17/12 A2975 RMK AO2 PK WND 17028/1543 SLP067 T01720117",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHKA",
       RawData = "KHKA 041553Z AUTO 15022G36KT 10SM CLR 15/02 A2965 RMK AO2 PK WND 16043/1515 SLP040 T01500017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHJO",
       RawData = "KHJO 041553Z AUTO 00000KT 10SM CLR 07/04 A3029 RMK AO2 SLP258 T00670044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHIB",
       RawData = "KHIB 041553Z AUTO 01012G17KT 10SM SCT110 01/M03 A2967 RMK AO2 SLP066 T00111028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHHR",
       RawData = "KHHR 041553Z 11007KT 10SM BKN035 13/07 A3025 RMK AO2 SLP243 T01280067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHGR",
       RawData = "KHGR 041553Z 17007KT 10SM BKN085 09/M08 A3014 RMK AO2 SLP220 T00941078 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHFD",
       RawData = "KHFD 041553Z 19011G18KT 10SM OVC085 05/M03 A3020 RMK AO2 SLP226 T00501033 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHBR",
       RawData = "KHBR 041553Z AUTO 25016G24KT 10SM CLR 12/01 A2930 RMK AO2 PK WND 23028/1503 SLP912 T01220006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KHAO",
       RawData = "KHAO 041553Z AUTO 17007KT 140V200 10SM SCT095 14/M04 A2991 RMK AO2 SLP129 T01391039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGWO",
       RawData = "KGWO 041553Z AUTO 15020G35KT 10SM -RA SCT090 18/08 A2968 RMK AO2 PK WND 14042/1459 SLP049 P0000 T01830078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGUP",
       RawData = "KGUP 041553Z AUTO 23009KT 10SM CLR 00/M05 A3004 RMK AO2 SLP185 T00001050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGTF",
       RawData = "KGTF 041553Z 10007KT 4SM -SN BR OVC006 M03/M03 A3012 RMK AO2 SNB48 SLP249 P0000 T10281028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGSP",
       RawData = "KGSP 041553Z 10004KT 10SM FEW036 FEW055 12/01 A3021 RMK AO2 SLP231 T01220011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGRB",
       RawData = "KGRB 041553Z 13004KT 10SM CLR 08/04 A2963 RMK AO2 SLP038 T00780039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGPT",
       RawData = "KGPT 041553Z AUTO 13014KT 10SM OVC028 19/16 A2989 RMK AO2 SLP121 T01890156",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGOK",
       RawData = "KGOK 041553Z AUTO 17009G18KT 10SM CLR 12/08 A2933 RMK AO2 SLP928 T01170078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGNV",
       RawData = "KGNV 041553Z 14014G23KT 10SM FEW035 24/14 A3014 RMK AO2 SLP206 T02440144 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGMU",
       RawData = "KGMU 041553Z 00000KT 10SM BKN035 BKN045 OVC055 12/02 A3022 RMK AO2 SLP234 T01220022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGLH",
       RawData = "KGLH 041553Z 15023G36KT 10SM OVC085 17/12 A2960 RMK AO2 PK WND 16037/1531 PRESFR SLP031 T01720117",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGKY",
       RawData = "KGKY 041553Z 22008G18KT 10SM CLR 15/07 A2948 RMK AO2 SLP977 T01500072 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGKJ",
       RawData = "KGKJ 041553Z AUTO 18004KT 10SM FEW080 BKN100 OVC110 08/M08 A2998 RMK AO2 SLP161 T00781083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGJT",
       RawData = "KGJT 041553Z 27005KT 10SM OVC100 02/M01 A2998 RMK AO2 SLP152 T00171006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGIF",
       RawData = "KGIF 041553Z AUTO 10010G22KT 10SM BKN038 24/15 A3013 RMK AO2 SLP200 T02440150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGGW",
       RawData = "KGGW 041553Z AUTO 34010KT 9SM SCT041 OVC049 M01/M04 A3012 RMK AO2 SNB40E50 SLP228 P0000 T10111044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGGG",
       RawData = "KGGG 041553Z 30003KT 10SM R13/6000VP6000FT RA BKN060 OVC075 13/11 A2953 RMK AO2 SLP997 P0010 T01280111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGFL",
       RawData = "KGFL 041553Z AUTO 19007KT 10SM OVC075 M01/M09 A3011 RMK AO2 SLP206 T10061089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGFK",
       RawData = "KGFK 041553Z 35017G26KT 10SM OVC013 M02/M06 A2992 RMK AO2 PK WND 36026/1551 SLP144 T10171056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGEZ",
       RawData = "KGEZ 041553Z AUTO 18022G33KT 10SM CLR 16/M02 A2980 RMK AO2 PK WND 18034/1512 SLP091 T01561017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGEY",
       RawData = "KGEY 041553Z AUTO 34021G29KT 10SM FEW095 02/M06 A3002 RMK AO2 PK WND 35032/1536 SLP186 T00171056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGEG",
       RawData = "KGEG 041553Z 00000KT 10SM FEW027 FEW070 BKN085 02/00 A3006 RMK AO2 SLP194 T00170000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KGAG",
       RawData = "KGAG 041553Z AUTO 36015G23KT 10SM FEW032 12/03 A2930 RMK AO2 SLP907 T01170028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFXE",
       RawData = "KFXE 041553Z 09019G29KT 10SM FEW033 BKN049 BKN075 26/18 A3010 RMK AO2 PK WND 09029/1548 SLP194 T02560178",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFUL",
       RawData = "KFUL 041553Z A3024 RMK AO2 SLPNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFTY",
       RawData = "KFTY 041553Z 10009G16KT 10SM BKN026 BKN038 OVC060 14/07 A3011 RMK AO2 RAB45E50 SLP194 P0000 T01390067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFSM",
       RawData = "KFSM 041553Z 26008KT 4SM RA BR FEW011 OVC070 13/12 A2947 RMK AO2 PK WND 26030/1509 TSE03 SLP975 P0027 T01280122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFRG",
       RawData = "KFRG 041553Z 21015G24KT 10SM FEW019 07/01 A3024 RMK AO2 PK WND 19027/1542 SLP241 T00670011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFPR",
       RawData = "KFPR 041553Z 11019G29KT 10SM SCT030 OVC035 24/16 A3013 RMK AO2 PK WND 11029/1548 SLP202 T02390156",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFOK",
       RawData = "KFOK 041553Z 21013G25KT 180V240 10SM BKN085 07/01 A3027 RMK AO2 SLP250 T00720006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFNT",
       RawData = "KFNT 041553Z 19006KT 7SM -RA OVC021 04/02 A2984 RMK AO2 RAB43 SLP110 P0000 T00390017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFNB",
       RawData = "KFNB 041553Z AUTO 32006KT 10SM BKN043 OVC050 14/09 A2930 RMK AO2 PRESRR SLP919 T01390094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFMY",
       RawData = "KFMY 041553Z 14013G25KT 10SM BKN035 25/16 A3007 RMK AO2 PK WND 13028/1533 SLP183 T02500156 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFMN",
       RawData = "KFMN 041553Z 28024G30KT 10SM CLR 03/M04 A2995 RMK AO2 PK WND 28034/1506 SLP151 T00331044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFLO",
       RawData = "KFLO 041553Z 16014G21KT 10SM CLR 19/08 A3024 RMK AO2 SLP237 T01940078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFLD",
       RawData = "KFLD 041553Z AUTO 17010KT 10SM OVC050 09/06 A2961 RMK AO2 SLP032 T00890056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFHR",
       RawData = "KFHR 041553Z AUTO 14006KT 10SM OVC018 08/04 A3001 RMK AO2 SLP162 T00830044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFFT",
       RawData = "KFFT 041553Z AUTO 18014G22KT 10SM CLR 16/M04 A2992 RMK AO2 SLP134 T01611044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFDY",
       RawData = "KFDY 041553Z AUTO 20010KT 10SM FEW070 OVC085 12/M03 A2987 RMK AO2 SLP113 T01171028 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFDR",
       RawData = "KFDR 041553Z AUTO 26027G35KT 10SM CLR 14/M01 A2930 RMK AO2 PK WND 26035/1549 SLP909 T01441006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFAY",
       RawData = "KFAY 041553Z 15011KT 10SM CLR 16/04 A3025 RMK AO2 SLP239 T01610044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFAT",
       RawData = "KFAT 041553Z 00000KT 10SM FEW015 FEW140 BKN200 08/04 A3028 RMK AO2 SLP252 T00780044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KFAR",
       RawData = "KFAR 041553Z 36018G30KT 10SM OVC013 M02/M04 A2984 RMK AO2 PK WND 35030/1544 SLP117 T10171044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEYW",
       RawData = "KEYW 041553Z 12014KT 10SM FEW025 26/18 A3006 RMK AO2 SLP183 T02560183",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEYE",
       RawData = "KEYE 041553Z AUTO 19013G25KT 10SM SCT120 17/M03 A2978 RMK AO2 SLP083 T01671033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEWB",
       RawData = "KEWB 041553Z 24014G24KT 10SM OVC080 06/M03 A3024 RMK AO2 PK WND 23028/1521 SLP240 T00611028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KESF",
       RawData = "KESF 041553Z AUTO 19013G23KT 10SM BKN022 OVC028 21/16 A2958 RMK AO2 PRESFR SLP015 T02060161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEQY",
       RawData = "KEQY 041553Z AUTO VRB04KT BKN055 14/05 A3023 RMK AO2 SLP248 T01440050 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KENW",
       RawData = "KENW 041553Z 20018KT 10SM OVC033 11/05 A2966 RMK AO2 PK WND 19027/1535 SLP046 T01110050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEMP",
       RawData = "KEMP 041553Z AUTO 11013KT 3SM -RA BR BKN055 BKN070 OVC090 11/09 A2931 RMK AO2 PRESFR SLP923 P0015 T01060089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KELY",
       RawData = "KELY 041553Z AUTO 16006KT 10SM CLR 08/M03 A3015 RMK AO2 SLP180 T00781028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KELN",
       RawData = "KELN 041553Z AUTO 02003KT 10SM CLR 03/01 A3002 RMK AO2 SLP177 T00280006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KELM",
       RawData = "KELM 041553Z 00000KT 10SM -RA OVC075 04/M06 A3005 RMK AO2 RAB03E13B41 SLP185 P0000 T00441056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KEET",
       RawData = "KEET 041553Z AUTO 15008KT 100V170 10SM CLR 18/09 A2998 RMK AO2 SLP150 T01780094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KECP",
       RawData = "KECP 041553Z 14015G21KT 10SM OVC038 22/16 A3001 RMK AO1 SLP172 T02220161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDXR",
       RawData = "KDXR 041553Z VRB06KT 10SM CLR 07/M04 A3019 RMK AO2 SLP227 T00721039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDWH",
       RawData = "KDWH 041553Z 29005G14KT 7SM -RA FEW025 OVC034 12/09 A2964 RMK AO2 PK WND 30043/1515 SLP036 P0027 T01220094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDVT",
       RawData = "KDVT 041553Z 16008KT 10SM CLR 11/M01 A3015 RMK AO2 SLP202 T01111006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDUJ",
       RawData = "KDUJ 041553Z AUTO 18004KT 10SM CLR 11/M08 A3001 RMK AO2 SLP172 T01061083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDTW",
       RawData = "KDTW 041553Z 16008KT 8SM -RA OVC045 04/01 A2987 RMK AO2 SLP120 P0000 T00390006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDTO",
       RawData = "KDTO 041553Z 24014G22KT 10SM CLR 16/05 A2945 RMK AO2 SLP968 T01560050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDRT",
       RawData = "KDRT 041553Z AUTO 28026G43KT 10SM CLR 21/M12 A2980 RMK AO2 PK WND 29044/1540 SLP081 T02111122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDRO",
       RawData = "KDRO 041553Z AUTO 00000KT 10SM CLR M02/M06 A2988 RMK AO2 SLP146 T10171056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDRA",
       RawData = "KDRA 041553Z AUTO 01003KT 10SM CLR 07/M03 A3015 RMK AO2 SLP196 T00671033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDNL",
       RawData = "KDNL 041553Z AUTO 15009KT 10SM BKN050 BKN060 16/08 A3019 RMK AO2 SLP222 T01610078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDMN",
       RawData = "KDMN 041553Z AUTO 30015KT 10SM CLR 09/M04 A3003 RMK AO2 PK WND 28031/1458 SLP143 T00891044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDMH",
       RawData = "KDMH 041553Z AUTO 11/M02 A3021 RMK AO1 SLP229 T01111022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDLS",
       RawData = "KDLS 041553Z AUTO 00000KT 10SM FEW120 05/03 A3008 RMK AO2 SLP188 T00500028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDKK",
       RawData = "KDKK 041553Z AUTO 19011G21KT 10SM BKN100 11/M07 A2998 RMK AO2 SLP155 T01061067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDHN",
       RawData = "KDHN 041553Z 14014G24KT 10SM FEW023 20/13 A3005 RMK AO2 PK WND 13028/1457 SLP172 T02000128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDGW",
       RawData = "KDGW 041553Z AUTO 34016G27KT 6SM -SN OVC019 M03/M07 A2997 RMK AO2 PK WND 32029/1522 SNB39 SLP169 P0000 T10281067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDFW",
       RawData = "KDFW 041553Z 23013KT 10SM FEW120 15/08 A2945 RMK AO2 SLP967 T01500078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDFI",
       RawData = "KDFI 041553Z AUTO 28003KT 8SM -RA BKN055 BKN070 OVC085 07/00 A2989 RMK AO2 RAB25 SLP126 P0001 T00670000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDET",
       RawData = "KDET 041553Z 17007KT 10SM OVC041 04/00 A2987 RMK AO2 RAE39 SLP121 P0002 T00440000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDEQ",
       RawData = "KDEQ 041553Z AUTO 06005KT 10SM RA OVC080 13/11 A2943 RMK AO2 PRESFR SLP964 P0013 T01280111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDEN",
       RawData = "KDEN 041553Z 35024G36KT 10SM FEW040 SCT085 BKN160 BKN220 04/M03 A2978 RMK AO2 PK WND 34036/1548 SLP073 T00441033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDCU",
       RawData = "KDCU 041553Z AUTO 15016G25KT 10SM CLR 17/08 A2996 RMK AO2 PRESFR SLP142 T01670078 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDBQ",
       RawData = "KDBQ 041553Z 15012KT 10SM SCT023 BKN029 OVC035 08/04 A2956 RMK AO2 SLP014 T00780044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDAN",
       RawData = "KDAN 041553Z AUTO 23005KT 10SM CLR 12/M01 A3023 RMK AO2 SLP235 T01171006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDAL",
       RawData = "KDAL 041553Z 21008KT 10SM FEW060 FEW095 FEW120 13/09 A2948 RMK AO2 SLP980 T01330089 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KDAB",
       RawData = "KDAB 041553Z 12011G26KT 070V160 10SM SCT046 BKN200 23/13 A3016 RMK AO2 PK WND 17026/1551 SLP211 T02280133",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCYS",
       RawData = "KCYS 041553Z 35026G48KT 10SM SCT016 M01/M06 A2981 RMK AO2 PK WND 33048/1546 SLP105 T10111056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCXO",
       RawData = "KCXO 041553Z 29008KT 10SM BKN039 OVC046 13/11 A2962 RMK AO2 PK WND 29045/1503 WSHFT 1453 RAE1456B04E47 SLP028 P0010 T01280111",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCUB",
       RawData = "KCUB 041553Z AUTO VRB05KT 10SM CLR 17/07 A3022 RMK AO2 SLP232 T01670072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCSV",
       RawData = "KCSV 041553Z AUTO 17009G29KT 130V200 10SM CLR 13/06 A3001 RMK AO2 PK WND 17030/1532 SLP157 T01280056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCSM",
       RawData = "KCSM 041553Z 24012KT 10SM CLR 11/M01 A2929 RMK AO2 SLP908 T01061011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCRS",
       RawData = "KCRS 041553Z AUTO 26010KT 10SM BKN110 13/11 A2954 RMK AO2 RAE27 SLP999 P0001 T01280106",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCRQ",
       RawData = "KCRQ 041553Z 09008KT 10SM CLR 12/05 A3023 RMK AO2 SLP235 T01220050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCRG",
       RawData = "KCRG 041553Z 15017G27KT 10SM FEW036 23/14 A3016 RMK AO2 PK WND 14028/1454 SLP211 T02330144",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCRE",
       RawData = "KCRE 041553Z 13008KT 10SM CLR 17/09 A3026 RMK AO1 SLP249 T01720094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCQC",
       RawData = "KCQC 041553Z AUTO 30033G46KT 10SM CLR 01/M06 A2977 RMK AO2 PK WND 31046/1550 SLP082 T00111056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCPS",
       RawData = "KCPS 041553Z 16016G27KT 10SM SCT120 16/03 A2958 RMK AO2 PK WND 16027/1548 SLP015 T01560033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCPR",
       RawData = "KCPR 041553Z 01015G27KT 4SM BR OVC038 M04/M06 A3000 RMK AO2 PK WND 01030/1537 SNB1457E49 SLP182 P0000 T10441061",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCOT",
       RawData = "KCOT 041553Z AUTO 32021G31KT 8SM CLR A2974 RMK AO2 PK WND 30035/1533 SLPNO $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCNY",
       RawData = "KCNY 041553Z AUTO 00000KT 10SM CLR 03/01 A2998 RMK AO2 SLP160 T00280006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCNO",
       RawData = "KCNO 041553Z 00000KT 10SM FEW040 10/05 A3027 RMK AO2 SLP249 T01000050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCLM",
       RawData = "KCLM 041553Z AUTO 00000KT 10SM SCT017 OVC100 07/04 A2999 RMK AO2 SLP158 T00670044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCLL",
       RawData = "KCLL 041553Z 22006KT 10SM OVC070 15/11 A2962 RMK AO2 RAB18E31 SLP025 P0006 T01500106",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCKB",
       RawData = "KCKB 041553Z 17007KT 10SM CLR 16/M07 A3005 RMK AO2 SLP171 T01561072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCHO",
       RawData = "KCHO 041553Z 19011KT 10SM CLR 09/M07 A3018 RMK AO2 SLP222 T00891067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCHA",
       RawData = "KCHA 041553Z 16011G19KT 10SM BKN030 BKN042 BKN100 BKN200 16/07 A3005 RMK AO2 SLP176 T01610072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCGI",
       RawData = "KCGI 041553Z 16018G28KT 10SM OVC100 15/03 A2969 RMK AO2 PK WND 18032/1525 SLP052 T01500033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCEZ",
       RawData = "KCEZ 041553Z AUTO VRB03KT 10SM CLR 02/M03 A2998 RMK AO2 SLP149 T00221033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCEW",
       RawData = "KCEW 041553Z AUTO 10SM BKN019 BKN028 20/15 A3001 RMK AO2 SLP160 T02000150",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCDW",
       RawData = "KCDW 041553Z 21005KT 10SM BKN075 OVC095 06/M01 A3021 RMK AO2 SLP237 T00561011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCDS",
       RawData = "KCDS 041553Z AUTO 27021G29KT 10SM BKN028 OVC037 09/03 A2935 RMK AO2 PK WND 29038/1458 RAB13E47 SLP926 P0000 T00890033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCDC",
       RawData = "KCDC 041553Z AUTO 04003KT 10SM CLR 02/M01 A3012 RMK AO2 SLP201 T00171006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KCCR",
       RawData = "KCCR 041553Z 18008KT 10SM OVC070 11/08 A3026 RMK AO2 SLP231 T01110078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBYI",
       RawData = "KBYI 041553Z AUTO 26013G21KT 10SM CLR 04/00 A3008 RMK AO2 SLP190 T00390000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBYG",
       RawData = "KBYG 041553Z AUTO 35023G33KT 6SM -SN BR BKN007 BKN100 M03/M04 A3000 RMK AO2 PK WND 35033/1547 SNB1456 CIG 005V010 SLP185 P0000 T10331044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBWG",
       RawData = "KBWG 041553Z AUTO 17019G29KT 10SM CLR 17/M03 A2989 RMK AO2 PK WND 18029/1550 PRESFR SLP120 T01721028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBVY",
       RawData = "KBVY 041553Z 23015G23KT 10SM OVC080 06/M09 A3017 RMK AO2 SLP213 T00561089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBVO",
       RawData = "KBVO 041553Z AUTO 05011G25KT 10SM BKN110 11/09 A2928 RMK AO2 PK WND 05029/1534 RAE34 SLP909 P0002 T01110089",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBTR",
       RawData = "KBTR 041553Z 13019G29KT 10SM BKN020 OVC027 21/16 A2972 RMK AO2 PK WND 13029/1541 SLP063 T02060161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBTM",
       RawData = "KBTM 041553Z AUTO 00000KT 10SM OVC070 M03/M05 A3007 RMK AO2 SLP213 T10281050",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBTL",
       RawData = "KBTL 041553Z 22014KT 9SM -RA BKN009 BKN065 OVC080 06/04 A2978 RMK AO2 PK WND 20029/1527 RAB04 SLP089 P0003 T00610044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBRO",
       RawData = "KBRO 041553Z 18018G35KT 6SM HZ CLR 27/21 A2963 RMK AO2 PK WND 17035/1550 SLP032 T02720211",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBRD",
       RawData = "KBRD 041553Z AUTO 36009KT 10SM OVC075 01/M02 A2966 RMK AO2 SLP055 T00111022",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBPI",
       RawData = "KBPI 041553Z AUTO 34015G23KT 10SM CLR 01/M07 A2997 RMK AO2 SLP144 T00061067",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBOI",
       RawData = "KBOI 041553Z 12005KT 10SM CLR 03/M01 A3011 RMK AO2 SLP204 T00331006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBNO",
       RawData = "KBNO 041553Z AUTO 26003KT 10SM FEW120 M03/M03 A3010 RMK AO2 SLP218 T10281033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBNA",
       RawData = "KBNA 041553Z 18020G27KT 10SM FEW130 SCT180 SCT250 18/02 A2991 RMK AO2 PK WND 15027/1544 PRESFR SLP127 T01780017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBMQ",
       RawData = "KBMQ 041553Z AUTO 27018G28KT 10SM CLR 16/00 A2965 RMK AO2 PK WND 27032/1527 SLP026 T01610000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBMG",
       RawData = "KBMG 041553Z 18010G18KT 10SM FEW100 15/M02 A2980 RMK AO2 SLP088 T01501017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBLI",
       RawData = "KBLI 041553Z AUTO 00000KT 10SM FEW039 OVC050 07/06 A3001 RMK AO2 SLP172 T00670056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBKV",
       RawData = "KBKV 041553Z 10SM CLR 25/14 A3010 RMK AO2 PK WND 13028/1505 SLP192 T02500144 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBKL",
       RawData = "KBKL 041553Z 17010G19KT 10SM OVC090 11/M08 A2993 RMK AO2 SLP137 T01061083",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBKE",
       RawData = "KBKE 041553Z AUTO 00000KT 10SM CLR M01/M02 A3008 RMK AO2 SLP204 T10061017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBIV",
       RawData = "KBIV 041553Z AUTO 18005KT 10SM OVC035 07/04 A2975 RMK AO2 SLP078 T00720039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBHM",
       RawData = "KBHM 041553Z 15008G20KT 110V180 10SM FEW020 BKN150 BKN250 17/09 A3001 RMK AO2 SLP159 T01670094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBGR",
       RawData = "KBGR 041553Z 20008KT 10SM BKN070 OVC120 M02/M12 A3011 RMK AO2 SLP200 T10221117",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBGM",
       RawData = "KBGM 041553Z 20008KT 10SM UP OVC055 A3005 RMK AO2 UPB39RAB49E50 SLPNO P0000 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBFM",
       RawData = "KBFM 041553Z 16014G23KT 10SM OVC028 19/13 A2995 RMK AO2 SLP140 T01940128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBFI",
       RawData = "KBFI 041553Z 13003KT 10SM BKN047 07/06 A3004 RMK AO2 SLP170 T00670056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBFF",
       RawData = "KBFF 041553Z AUTO 34025G40KT 10SM BKN021 BKN036 BKN110 03/M03 A2982 RMK AO2 PK WND 34041/1540 UPE00 SLP099 P0000 T00331033",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBFD",
       RawData = "KBFD 041553Z AUTO 21007G16KT 10SM SCT065 BKN080 BKN100 09/M09 A3000 RMK AO2 SLP170 T00891094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBEH",
       RawData = "KBEH 041553Z AUTO 18011G18KT 10SM SCT038 BKN055 BKN110 10/06 A2975 RMK AO2 SLP076 T01000056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBDE",
       RawData = "KBDE 041553Z AUTO 34011KT 10SM OVC017 00/M04 A2983 RMK AO2 SLP116 T00001044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBCT",
       RawData = "KBCT 041553Z 11016G27KT 090V140 10SM SCT030 24/18 A3011",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBCE",
       RawData = "KBCE 041553Z AUTO 31014KT 10SM CLR M01/M04 A3007 RMK AO2 SLP163 T10061044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KBAF",
       RawData = "KBAF 041553Z COR 20009KT 10SM OVC080 M03/M07 A3018",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAWM",
       RawData = "KAWM 041553Z AUTO 15020G32KT 10SM -RA CLR 15/04 A2965 RMK AO2 PK WND 13042/1502 RAB14 SLP039 P0000 T01500044",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAUS",
       RawData = "KAUS 041553Z 28010G22KT 10SM FEW080 FEW120 19/00 A2962 RMK AO2 SLP024 T01940000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAUG",
       RawData = "KAUG 041553Z AUTO VRB03KT 10SM CLR M01/M12 A3011 RMK AO2 SLP201 T10061122",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KASE",
       RawData = "KASE 041553Z 01008KT 6SM BR BKN012 M02/M04 A2988 RMK AO2 SNE12 SLP110 P0000 T10221039",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KASD",
       RawData = "KASD 041553Z AUTO 14010G19KT 10SM SCT032 BKN070 21/16 A2984 RMK AO2 SLP104 T02060161",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KARB",
       RawData = "KARB 041553Z 18009KT 9SM -RA BKN035 OVC055 04/01 A2985 RMK AO2 RAB21UPB35E37 SLP113 P0000 T00390006",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KARA",
       RawData = "KARA 041553Z 15024G37KT 10SM BKN060 BKN080 23/18 A2969 RMK AO2 PK WND 14037/1552 SLP054 T02280178",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAPF",
       RawData = "KAPF 041553Z 11010G20KT 10SM SCT033 BKN043 BKN049 26/17 A3007 RMK AO2 PK WND 12027/1513 SLP180 T02560167",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAPA",
       RawData = "KAPA 041553Z 36018G23KT 10SM FEW040 SCT080 SCT140 SCT220 04/M04 A2977 RMK AO2 PK WND 01035/1626 SLP092",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAOO",
       RawData = "KAOO 041553Z AUTO 25007KT 10SM CLR 10/M07 A3008 RMK AO2 SLP196 T01001072",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAOH",
       RawData = "KAOH 041553Z AUTO 19011G22KT 10SM SCT070 BKN090 12/M03 A2985 RMK AO2 SLP112 T01171028",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KANB",
       RawData = "KANB 041553Z AUTO 12006G16KT 10SM OVC023 16/09 A3004 RMK AO2 SLP175 T01610094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAMW",
       RawData = "KAMW 041553Z AUTO 14013KT 10SM CLR 12/09 A2942 RMK AO2 SLP958 T01220094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAMG",
       RawData = "KAMG 041553Z AUTO 13010G18KT 10SM FEW050 SCT060 21/12 A3015 RMK AO2 SLP207 T02060117 PWINO",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KALW",
       RawData = "KALW 041553Z 10005KT 10SM CLR 07/02 A3006 RMK AO2 SLP185 T00670017",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAGS",
       RawData = "KAGS 041553Z AUTO 17006KT FEW060 17/08 A3018 RMK AO2 SLP220 T01720078",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAGC",
       RawData = "KAGC 041553Z 20010KT 10SM CLR 12/M09 A3002 RMK AO2 SLP176 T01221094",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAFW",
       RawData = "KAFW 041553Z 24012G21KT 10SM FEW100 16/06 A2945 RMK AO2 SLP966 T01560056",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAEX",
       RawData = "KAEX 041553Z 15022G33KT 10SM OVC021 20/17 A2957 RMK AO2 PK WND 15033/1552 SLP015 T02000167",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KADG",
       RawData = "KADG 041553Z AUTO 19009KT 8SM -RA BKN045 OVC075 04/00 A2987 RMK AO2 SLP123 P0000 T00440000",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KACK",
       RawData = "KACK 041553Z 21015G20KT 10SM CLR 06/M01 A3029 RMK AO2 SLP256 T00611006 $",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KABY",
       RawData = "KABY 041553Z 17020G28KT 10SM FEW028 BKN043 BKN055 22/13 A3009 RMK AO2 PK WND 17028/1553 SLP190 T02170128",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "KAAF",
       RawData = "KAAF 041553Z AUTO 15013G24KT 10SM BKN046 22/17 A3005 RMK AO2 SLP176 T02170167",
       LastChange = "2025-03-04T15:53:00Z"
    },
    new Metar {
       Station = "PATA",
       RawData = "PATA 041552Z 06005KT 10SM CLR M07/M12 A2987 RMK AO2 SLP122 T10721122 $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "MMIO",
       RawData = "MMIO 041552Z 19008KT 10SM BKN200 24/08 A2999 RMK 8/002",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KTRM",
       RawData = "KTRM 041552Z AUTO 31010KT 10SM CLR 15/03 A3017 RMK AO2 SLP216 T01500033 TSNO $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KTOL",
       RawData = "KTOL 041552Z 20006KT 10SM -RA OVC055 07/M01 A2988 RMK AO2 SLP122 P0000 T00721011 $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KTAN",
       RawData = "KTAN 041552Z AUTO 20013G23KT 10SM OVC080 05/M06 A3023 RMK AO2 SLP237 T00501056",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KSUX",
       RawData = "KSUX 041552Z A2941 RMK AO2 SLPNO PNO",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KSPS",
       RawData = "KSPS 041552Z 24025G32KT 10SM CLR 16/M01 A2935 RMK AO2 PK WND 25038/1535 SLP930 T01561006",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KREO",
       RawData = "KREO 041552Z AUTO 00000KT 03/M01 A3008 RMK AO1 SLP198 T00281011",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KPYM",
       RawData = "KPYM 041552Z AUTO 23020G29KT 10SM OVC080 07/M07 A3021 RMK AO2 PK WND 23031/1539 SLP235 T00721067",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KPWK",
       RawData = "KPWK 041552Z 20016G26KT 10SM OVC032 09/05 A2970 RMK AO2 PK WND 19030/1536 SLP060 T00890050",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KP69",
       RawData = "KP69 041552Z AUTO 00000KT 03/02 A3014 RMK AO1 SLP223 T00280022",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KORE",
       RawData = "KORE 041552Z AUTO 17007KT 10SM OVC075 02/M08 A3015 RMK AO2 SLP219 T00171083",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KOKC",
       RawData = "KOKC 041552Z 18012G19KT 10SM FEW150 12/07 A2933 RMK AO2 SLP925 T01170072",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KOKB",
       RawData = "KOKB 041552Z AUTO 06005KT 9SM OVC038 11/M01 A3024 RMK AO2 RAB06E18 SLP238 P0000 T01111011",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KNRB",
       RawData = "KNRB 041552Z 15015G22KT 10SM SCT025 BKN250 25/14 A3016 RMK AO2 SLP212 T02500144",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KNHK",
       RawData = "KNHK 041552Z 21012G21KT 10SM CLR 14/M01 A3024 RMK AO2 SLP239 T01441006",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KNFW",
       RawData = "KNFW 041552Z 24013G20KT 10SM CLR 16/04 A2947 RMK AO2 SLP966 T01560044 $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMWH",
       RawData = "KMWH 041552Z 00000KT 10SM SCT090 03/02 A3005 RMK AO2 SLP183 T00280022",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMLI",
       RawData = "KMLI 041552Z 15007KT 10SM OVC033 12/07 A2956 RMK AO2 SLP011 T01220072",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMKE",
       RawData = "KMKE 041552Z 19010KT 10SM OVC034 09/06 A2964 RMK AO2 SLP042 T00890056",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMHK",
       RawData = "KMHK 041552Z AUTO 26006KT 10SM OVC038 15/09 A2926 RMK AO2 SLP904 T01500089",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMFD",
       RawData = "KMFD 041552Z 20015G29KT 10SM CLR 12/M04 A2992 RMK AO2 PK WND 18029/1547 SLP138 T01221044 $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMEB",
       RawData = "KMEB 041552Z AUTO 15011KT 10SM BKN044 BKN060 16/06 A3025 RMK AO2 SLP242 T01610061",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMDH",
       RawData = "KMDH 041552Z 16017G28KT 10SM BKN110 16/02 A2969 RMK AO2 PK WND 17033/1507 PRESFR SLP051 T01560022",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KMBG",
       RawData = "KMBG 041552Z AUTO 35016G25KT 10SM OVC014 01/M03 A2988 RMK AO2 SNE29 SLP130 P0000 T00111033",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KLWC",
       RawData = "KLWC 041552Z AUTO 14008KT 4SM RA BR OVC065 12/11 A2938 RMK AO1 SLP948 P0010 T01170106",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KIJD",
       RawData = "KIJD 041552Z AUTO 19007KT 10SM OVC080 04/M04 A3021 RMK AO2 SLP234 T00391044",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KIAD",
       RawData = "KIAD 041552Z 19009KT 10SM BKN080 BKN250 09/M05 A3019 RMK AO2 SLP224 T00891050",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KHUT",
       RawData = "KHUT 041552Z 19008KT 10SM CLR 10/04 A2925 RMK AO2 SLP893 T01000039",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KHIE",
       RawData = "KHIE 041552Z AUTO 31004KT 10SM CLR 01/M10 A3002 RMK AO2 SLP186 T00061100",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KGLS",
       RawData = "KGLS 041552Z 18016KT 3SM BR FEW021 BKN026 OVC035 21/21 A2962 RMK AO2 RAB15E43 SLP029 P0006 T02060206",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KFIT",
       RawData = "KFIT 041552Z AUTO 10SM OVC075 04/M09 A3015 RMK AO2 SLP215 T00441089",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KDPA",
       RawData = "KDPA 041552Z 17016G25KT 10SM OVC033 08/05 A2968 RMK AO2 SLP054 T00780050",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KDCA",
       RawData = "KDCA 041552Z 17011KT 10SM SCT085 BKN250 12/M02 A3020 RMK AO2 SLP227 T01171017",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCVG",
       RawData = "KCVG 041552Z 18013KT 10SM FEW070 BKN090 BKN250 14/M03 A2989 RMK AO2 SLP121 T01441028",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCQX",
       RawData = "KCQX 041552Z AUTO 22009G19KT 10SM CLR 07/M03 A3026 RMK AO2 SLP250 T00671028 PWINO",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCLT",
       RawData = "KCLT 041552Z 17007KT 10SM SCT050 BKN190 BKN250 13/03 A3023 RMK AO2 SLP252 T01330033",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCKV",
       RawData = "KCKV 041552Z AUTO 17017G28KT 10SM CLR 17/M04 A2985 RMK AO2 PK WND 18028/1550 SLP107 T01721044",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCID",
       RawData = "KCID 041552Z 13011KT 10SM OVC022 10/07 A2950 RMK AO2 SLP991 T01000072",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KCFV",
       RawData = "KCFV 041552Z AUTO 36006KT 5SM RA BR OVC060 11/10 A2940 RMK AO2 SLP952 P0014 T01110100",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KBML",
       RawData = "KBML 041552Z AUTO 00000KT 10SM CLR 02/M12 A3000 RMK AO2 SLP182 T00171117",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KBLU",
       RawData = "KBLU 041552Z AUTO 00000KT 10SM OVC050 01/M02 A3020 RMK AO2 SLP235 T00111017",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KBLF",
       RawData = "KBLF 041552Z AUTO 16010G22KT 10SM CLR 09/M09 A3009 RMK AO2 SLP188 T00941094",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KBDR",
       RawData = "KBDR 041552Z 22005KT 10SM FEW085 06/M01 A3023 RMK AO2 SLP237 T00561006",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KBAN",
       RawData = "KBAN 041552Z AUTO 10SM FEW070 SCT085 04/M14 A3011 RMK AO2 SLP184 T00441144 PWINO $",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KATL",
       RawData = "KATL 041552Z 12009KT 10SM BKN023 BKN035 OVC055 14/07 A3011 RMK AO2 SLP197 MDT CU OHD-ALQDS BINOVC T01390067",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KARR",
       RawData = "KARR 041552Z 15014KT 8SM OVC033 07/05 A2969 RMK AO2 SLP057 T00720050",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KAQW",
       RawData = "KAQW 041552Z AUTO 09005KT 10SM OVC075 01/M10 A3012 RMK AO2 SLP210 T00111100",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KALS",
       RawData = "KALS 041552Z AUTO 32016G27KT 10SM CLR 03/M08 A2976 RMK AO2 PK WND 33030/1537 SLP070 T00281083",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KAFN",
       RawData = "KAFN 041552Z AUTO 19012G19KT 10SM OVC070 01/M09 A3011 RMK AO2 SLP217 T00111094",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KABQ",
       RawData = "KABQ 041552Z 01014G21KT 10SM SCT045 SCT210 06/M05 A2992 RMK AO2 SLP120 MTN TOPS OBSC NE AND SE T00611050",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "KABI",
       RawData = "KABI 041552Z 26017G41KT 220V280 10SM CLR 14/M04 A2952 RMK AO2 PK WND 24041/1546 SLP978 T01441039",
       LastChange = "2025-03-04T15:52:00Z"
    },
    new Metar {
       Station = "PTYA",
       RawData = "PTYA 041551Z 08008KT 12SM SCT016 BKN300 28/24 A2983 RMK SLP101 T02770244",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "PHBK",
       RawData = "PHBK 041551Z AUTO 10004KT 10SM CLR 16/13 A3019 RMK AO2 SLP224 T01610128 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "MUGM",
       RawData = "MUGM 041551Z 12007KT 10SM FEW030 FEW110 29/20 A3001 RMK AO2 SLP161 T02940200 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KYNG",
       RawData = "KYNG 041551Z 21007KT 10SM BKN095 BKN120 OVC220 10/M08 A2999 RMK AO2 SLP161 T01001078",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KVNY",
       RawData = "KVNY 041551Z VRB03KT 10SM BKN019 OVC026 12/05 A3023 RMK AO2 SLP234 T01170050",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KVCT",
       RawData = "KVCT 041551Z 33005KT 10SM SCT036 OVC065 17/10 A2970 RMK AO2 PK WND 31034/1459 WSHFT 1452 RAB03E24 SLP056 P0003 T01670100",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KUGN",
       RawData = "KUGN 041551Z 20016G27KT 10SM OVC034 10/04 A2967 RMK AO2 PK WND 19027/1546 SLP050 T01000039",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KTPL",
       RawData = "KTPL 041551Z AUTO 27016G21KT 10SM CLR 17/06 A2959 RMK AO2 SLP013 T01720061",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KTEB",
       RawData = "KTEB 041551Z 19012KT 10SM SCT080 OVC100 06/M02 A3021 RMK AO2 SLP231 T00611017",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSTL",
       RawData = "KSTL 041551Z 17019G34KT 10SM FEW045 SCT100 BKN250 17/02 A2957 RMK AO2 PK WND 15034/1532 RAE1458 SLP008 P0000 T01670022",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSNT",
       RawData = "KSNT 041551Z AUTO 00000KT M07/M12 A3007 RMK AO1 SLP181 T10671117",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSMX",
       RawData = "KSMX 041551Z 00000KT 10SM CLR 08/06 A3027 RMK AO2 SLP255 T00830061",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSMO",
       RawData = "KSMO 041551Z VRB04KT 10SM OVC016 12/07 A3025 RMK AO2 SLP243 T01220072",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSDB",
       RawData = "KSDB 041551Z AUTO VRB03KT 10SM CLR 04/M02 A3019 RMK AO2 SLP219 T00391022 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSAT",
       RawData = "KSAT 041551Z 29022G34KT 10SM CLR 19/M02 A2967 RMK AO2 PK WND 29034/1536 SLP034 T01891017",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSAN",
       RawData = "KSAN 041551Z 07005KT 10SM SCT024 BKN032 13/07 A3025 RMK AO2 SLP244 T01330067",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KSAD",
       RawData = "KSAD 041551Z AUTO 31016KT 10SM CLR 10/M04 A3010 RMK AO2 PK WND 31026/1517 SLP176 T01001039",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KRDU",
       RawData = "KRDU 041551Z 19010KT 10SM FEW210 BKN250 16/M01 A3026 RMK AO2 SLP246 T01611006",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KQOA",
       RawData = "KQOA 041551Z 26005KT 9999 FEW070 27/18 A3002 RMK A02A SLP127 WND DATA/ALSTG ESTMD T02710182 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KPWM",
       RawData = "KPWM 041551Z 21007KT 10SM BKN080 OVC130 01/M10 A3014 RMK AO2 SLP207 T00111100 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KPVD",
       RawData = "KPVD 041551Z 24011KT 10SM OVC080 06/M07 A3024 RMK AO2 PK WND 25026/1533 SLP240 T00561067",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KPIT",
       RawData = "KPIT 041551Z 21012KT 10SM FEW140 OVC220 13/M11 A3002 RMK AO2 SLP177 T01281106",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KPHX",
       RawData = "KPHX 041551Z 10004KT 10SM CLR 12/M02 A3014 RMK AO2 SLP201 T01221017",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KP59",
       RawData = "KP59 041551Z AUTO 01003KT 02/M01 A2968 RMK AO1 SLP059 T00221011",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KOXR",
       RawData = "KOXR 041551Z 04006KT 10SM CLR 11/05 A3024 RMK AO2 SLP240 T01060050 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KORF",
       RawData = "KORF 041551Z 22013KT 10SM CLR 16/M05 A3027 RMK AO2 SLP250 T01561050",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KORD",
       RawData = "KORD 041551Z 18017G25KT 10SM OVC034 08/05 A2969 RMK AO2 PK WND 19026/1538 SLP055 T00830050",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KOCF",
       RawData = "KOCF 041551Z 13014G17KT 10SM BKN034 23/14 A3013 RMK AO2 SLP202 T02330144",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KNYC",
       RawData = "KNYC 041551Z AUTO VRB03KT 10SM FEW070 OVC085 07/M02 A3024 RMK AO2 SLP231 T00721022",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KNJM",
       RawData = "KNJM 041551Z AUTO 10008KT 9SM CLR 16/05 A3033 RMK AO2 SLP273 T01560050 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KNFG",
       RawData = "KNFG 041551Z 05007KT 10SM SCT025 BKN030 14/07 A3025 RMK AO2 SLP242 T01440067 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KNBT",
       RawData = "KNBT 041551Z AUTO 07004KT 10SM SCT060 15/07 A3033 RMK AO2 SLP274 T01500067 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KMYL",
       RawData = "KMYL 041551Z AUTO 00000KT 10SM CLR M04/M06 A3007 RMK AO2 SLP206 T10391056",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KMPV",
       RawData = "KMPV 041551Z AUTO 21008KT 10SM CLR 02/M11 A3006 RMK AO2 SLP198 T00221106",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KLPC",
       RawData = "KLPC 041551Z AUTO 09004KT 10SM CLR 07/07 A3028 RMK AO2 SLP255 T00720072 PNO $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KLGU",
       RawData = "KLGU 041551Z AUTO 00000KT 4SM BR BKN002 OVC023 01/01 A3008 RMK AO2 SLP192 T00110011",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KLGA",
       RawData = "KLGA 041551Z 17010KT 10SM FEW040 BKN090 OVC250 07/M02 A3022 RMK AO2 SLP232 T00721022",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KJFK",
       RawData = "KJFK 041551Z 19016KT 10SM FEW032 BKN090 BKN250 07/02 A3025 RMK AO2 SLP243 T00720022",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KILG",
       RawData = "KILG 041551Z 15005KT 10SM OVC075 09/00 A3023 RMK AO2 SLP238 T00940000",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KIGM",
       RawData = "KIGM 041551Z AUTO 08006KT 10SM CLR 09/M03 A3013 RMK AO2 SLP173 T00941033",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KHTS",
       RawData = "KHTS 041551Z 22004KT 10SM CLR 14/M06 A3002 RMK AO2 SLP164 T01441061",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KHSE",
       RawData = "KHSE 041551Z AUTO 18003KT 10SM CLR 16/06 A3032 RMK AO2 SLP268 T01560056 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KHDO",
       RawData = "KHDO 041551Z AUTO 30021G42KT FEW060 19/M05 A2971 RMK AO2 PK WND 30042/1548 SLP047 T01941050 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KFWS",
       RawData = "KFWS 041551Z 22011G18KT 10SM CLR 15/07 A2950",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KEWR",
       RawData = "KEWR 041551Z 18009KT 10SM BKN080 BKN120 BKN250 08/M01 A3022 RMK AO2 SLP232 T00781011 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KERI",
       RawData = "KERI 041551Z 18014G23KT 10SM SCT100 OVC110 11/M09 A2995 RMK AO2 SLP147 T01111089",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KELP",
       RawData = "KELP 041551Z 28018G26KT 10SM FEW250 09/M06 A2996 RMK AO2 PK WND 27045/1455 SLP116 BLDU ALQDS MTNS OBSCD SW T00941056",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KEKN",
       RawData = "KEKN 041551Z AUTO 00000KT 10SM CLR 09/M03 A3008 RMK AO2 RAB07E16B41E50 SLP202 P0000 T00891033 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KDAW",
       RawData = "KDAW 041551Z AUTO VRB06KT 10SM SCT080 03/M08 A3012 RMK AO2 SLP202 T00331083 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCSG",
       RawData = "KCSG 041551Z 14011G18KT 10SM BKN028 OVC050 18/11 A3006 RMK AO2 SLP178 T01830111",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCRP",
       RawData = "KCRP 041551Z 34028G36KT 7SM SQ FEW018 SCT030 SCT050 BKN250 23/01 A2970 RMK AO2 PK WND 31046/1540 WSHFT 1531 SLP056 FROPA VIS SE 2 1/2 BLDU SE T02330011 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCON",
       RawData = "KCON 041551Z AUTO 15005KT 10SM FEW075 02/M09 A3013 RMK AO2 SLP209 T00171089",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCMH",
       RawData = "KCMH 041551Z 18012KT 10SM FEW060 SCT100 BKN200 12/M06 A2995 RMK AO2 SLP144 T01221056",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCLE",
       RawData = "KCLE 041551Z 18013KT 10SM BKN085 BKN150 BKN250 09/M08 A2992 RMK AO2 SLP150 T00941078",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCDJ",
       RawData = "KCDJ 041551Z AUTO 14010G18KT 13/10 A2942 RMK AO1 SLP958 T01280100",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KCAK",
       RawData = "KCAK 041551Z 22010G20KT 10SM BKN100 OVC150 10/M08 A2998 RMK AO2 SLP158 T01001083",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KBKW",
       RawData = "KBKW 041551Z AUTO 14010G19KT 10SM CLR 09/M08 A3009 RMK AO2 SLP195 T00891083",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KBED",
       RawData = "KBED 041551Z 22013G20KT 10SM OVC080 04/M09 A3018 RMK AO2 SLP235 T00441094",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KBDL",
       RawData = "KBDL 041551Z 18011G17KT 10SM BKN080 OVC250 05/M05 A3019 RMK AO2 SLP223 BINOVC T00501050",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KBAZ",
       RawData = "KBAZ 041551Z 28015G27KT 10SM CLR 20/01 A2965 RMK AO2 PK WND 31031/1453 SLP032 T02000006",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KAVX",
       RawData = "KAVX 041551Z AUTO 12007KT 10SM FEW004 09/08 A3021 RMK AO2 SLP233 T00890078 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KATT",
       RawData = "KATT 041551Z AUTO A2963 RMK AO2 SLPNO PWINO FZRANO TSNO",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KALB",
       RawData = "KALB 041551Z 17008G17KT 10SM FEW060 OVC080 02/M09 A3012 RMK AO2 SLP204 T00171094",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KAHN",
       RawData = "KAHN 041551Z 07006KT 10SM 11/05 A3018 RMK AO2 SLP220 T01110050 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KACT",
       RawData = "KACT 041551Z A2955 RMK AO2 SLPNO $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "KABE",
       RawData = "KABE 041551Z 21008KT 10SM CLR 06/M03 A3018 RMK AO2 SLP224 T00561033",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "K6R6",
       RawData = "K6R6 041551Z AUTO 27026G41KT 15/M06 A2981 RMK AO1 PK WND 28047/1523 SLP070 T01501061 $",
       LastChange = "2025-03-04T15:51:00Z"
    },
    new Metar {
       Station = "TJBQ",
       RawData = "TJBQ 041550Z 08015KT 10SM SCT031 28/21 A3002",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "SFAL",
       RawData = "SFAL 041550Z 33027KT 9999 FEW040 SCT082 15/08 Q0995",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "PTRO",
       RawData = "PTRO 041550Z 05007KT 13SM BKN015CB BKN110 OVC290 27/25 A2977 RMK CB ALQDS",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OOSH",
       RawData = "OOSH 041550Z AUTO 06001KT //// ////// 23/12 Q1018 RMK QFE1014 RH051? PR000.0",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OOSA",
       RawData = "OOSA 041550Z 12005KT 100V160 9999 SCT025 26/22 Q1015 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OOMS",
       RawData = "OOMS 041550Z 08009KT CAVOK 24/15 Q1017 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OOKB",
       RawData = "OOKB 041550Z AUTO 18008KT 150V220 CAVOK 25/09 Q1017 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OODQ",
       RawData = "OODQ 041550Z AUTO 08017KT 9999 BKN024 24/20 Q1016 NOSIG RMK RH76? 0",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "OOAD",
       RawData = "OOAD 041550Z AUTO 14010KT 9999 // ///////// 27/01 Q1017 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "NSTU",
       RawData = "NSTU 041550Z VRB02KT 10SM SCT020 BKN040 24/23 A2982 RMK SLP100 T02370229",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUVR",
       RawData = "MUVR 041550Z 13009KT 080V170 9000 FEW030 27/16 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUSC",
       RawData = "MUSC 041550Z 11010KT 080V140 9000 SCT020 27/18 Q1018",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUHG",
       RawData = "MUHG 041550Z 09013KT 9000 FEW030 SCT033 BKN075 28/19 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUHA",
       RawData = "MUHA 041550Z 14009KT 100V180 CAVOK 27/17 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUCU",
       RawData = "MUCU 041550Z 17005KT 150V210 9000 FEW020 28/20 Q1016",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUCM",
       RawData = "MUCM 041550Z 06014KT 9000 SCT020 28/20 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUCL",
       RawData = "MUCL 041550Z 10013KT 060V140 9000 FEW020 27/20 Q1016",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUCF",
       RawData = "MUCF 041550Z 08004KT 9999 FEW025 29/18 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MUCC",
       RawData = "MUCC 041550Z 12012KT 080V140 9000 SCT020 28/20 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MSSM",
       RawData = "MSSM 041550Z 00000KT 9999 FEW033 31/22 Q//// A////",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MSSA",
       RawData = "MSSA 041550Z 14002KT CAVOK 27/20 Q1019 A3009",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MSLU",
       RawData = "MSLU 041550Z 04004KT CAVOK 30/21 Q1012 A2989",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MSAC",
       RawData = "MSAC 041550Z 18006KT 9999 FEW037 34/25 Q1011 A2986",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MMPQ",
       RawData = "MMPQ 041550Z 00000KT 8SM SKC 26/21 A2974 RMK HZY",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "MMCL",
       RawData = "MMCL 041550Z 29003KT 10SM SCT250 18/06 A3002 RMK 8/004 HZY",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTFO",
       RawData = "LTFO 041550Z 12004KT 9999 BKN025 06/03 Q1027",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTFH",
       RawData = "LTFH 041550Z 22002KT 9999 FEW015 SCT030 BKN090 06/03 Q1027 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTFG",
       RawData = "LTFG 041550Z 06006KT 010V090 9999 FEW030 18/01 Q1013",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTFD",
       RawData = "LTFD 041550Z 06018KT 9999 FEW035 09/M01 Q1021",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTDA",
       RawData = "LTDA 041550Z 05012KT 9999 SCT040 BKN120 19/M03 Q1013 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCW",
       RawData = "LTCW 041550Z 13004KT 3700 BR FEW010 SCT040 BKN120 M02/M05 Q1021",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCV",
       RawData = "LTCV 041550Z 19002KT CAVOK 12/M04 Q1018",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCT",
       RawData = "LTCT 041550Z VRB01KT 9999 FEW040 05/M04 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCR",
       RawData = "LTCR 041550Z 08006KT 9999 FEW040 SCT100 11/M02 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCN",
       RawData = "LTCN 041550Z 08010KT 9999 FEW100 SCT180 15/M04 Q1016",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCI",
       RawData = "LTCI 041550Z 16003KT 9999 FEW040 SCT180 01/M03 Q1021 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCF",
       RawData = "LTCF 041550Z VRB02KT CAVOK M03/M06 Q1021 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCD",
       RawData = "LTCD 041550Z 11001KT CAVOK 02/M01 Q1021 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCB",
       RawData = "LTCB 041550Z 17006KT 9999 FEW015 BKN033 06/02 Q1027 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTCA",
       RawData = "LTCA 041550Z 12003KT 090V170 CAVOK 07/M01 Q1019 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTBY",
       RawData = "LTBY 041550Z 35010KT CAVOK 06/M04 Q1019",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTBQ",
       RawData = "LTBQ 041550Z 04007KT 9999 SCT035 06/00 Q1025 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTBH",
       RawData = "LTBH 041550Z 04017KT 9999 SCT035 08/M01 Q1023",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTBF",
       RawData = "LTBF 041550Z 36016KT 9999 FEW035 08/00 Q1021 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTBD",
       RawData = "LTBD 041550Z 05003KT 360V090 9999 FEW040 16/02 Q1014",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAY",
       RawData = "LTAY 041550Z 05013KT 9999 FEW035 SCT070 09/M02 Q1015 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAW",
       RawData = "LTAW 041550Z 03005KT 9999 FEW040 05/M00 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAR",
       RawData = "LTAR 041550Z 13007KT 9999 SCT020 M01/M03 Q1020",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAP",
       RawData = "LTAP 041550Z 03014KT 9999 FEW040 03/M02 Q1022 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAN",
       RawData = "LTAN 041550Z 01008KT 9999 FEW030 05/M01 Q1018 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LTAE",
       RawData = "LTAE 041550Z 06009KT CAVOK 06/M13 Q1020 NOSIG RMK RWY21 07007KT 030V110",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LSZL",
       RawData = "LSZL 041550Z 27003KT 240V300 CAVOK 14/02 Q1024 RMK BLU",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LOXZ",
       RawData = "LOXZ 041550Z 21004KT 9999 FEW210 SCT250 13/M04 Q1024 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LLIB",
       RawData = "LLIB 041550Z AUTO 31005KT CAVOK 18/01 Q1008",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LLHA",
       RawData = "LLHA 041550Z 31004KT CAVOK 18/12 Q1008",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LLER",
       RawData = "LLER 041550Z 01015KT CAVOK 22/03 Q1007",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIRU",
       RawData = "LIRU 041550Z 27007KT CAVOK 16/10 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIRI",
       RawData = "LIRI 041550Z 25007KT CAVOK 15/07 Q1021",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIQN",
       RawData = "LIQN 041550Z 32007KT CAVOK 15/02 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIPK",
       RawData = "LIPK 041550Z VRB01KT CAVOK 15/03 Q1024",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIPB",
       RawData = "LIPB 041550Z 19004KT 150V220 CAVOK 17/M01 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIMP",
       RawData = "LIMP 041550Z 07005KT CAVOK 15/M01 Q1024",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIMG",
       RawData = "LIMG 041550Z 08008KT CAVOK 16/03 Q1023",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIMA",
       RawData = "LIMA 041550Z 24003KT 190V280 CAVOK 15/M00 Q1024",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LICG",
       RawData = "LICG 041550Z 01002KT 9999 SCT020 14/12 Q1021 RERA",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIBG",
       RawData = "LIBG 041550Z 02010KT CAVOK 13/M01 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIBF",
       RawData = "LIBF 041550Z 34012KT 9999 FEW040 13/07 Q1023",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LIBC",
       RawData = "LIBC 041550Z 03010KT CAVOK 12/05 Q1022",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LGZA",
       RawData = "LGZA 041550Z 02010KT 9999 FEW020 14/02 Q1020",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LGKF",
       RawData = "LGKF 041550Z /////KT 9999 FEW025 14/05 Q1020",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "LGHI",
       RawData = "LGHI 041550Z 01015KT CAVOK 13/03 Q1017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KWDG",
       RawData = "KWDG 041550Z 15011KT 10SM FG BKN150 11/08 A2934",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KVQQ",
       RawData = "KVQQ 041550Z 14010G18KT 10SM SCT036 25/14 A3014",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KTRK",
       RawData = "KTRK 041550Z 00000KT 10SM OVC550 M02/M03 A3017",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KSUA",
       RawData = "KSUA 041550Z 10020G25KT 10SM SCT029 24/17 A3013",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KPHT",
       RawData = "KPHT 041550Z AUTO 15020G32KT 10SM BKN095 16/M02 A2981 RMK A01",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KOQU",
       RawData = "KOQU 041550Z 23015G23KT 10SM OVC080 06/M04 A3025 RMK AO2",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KOMN",
       RawData = "KOMN 041550Z 13013G20KT 10SM SCT045 23/16 A3016",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KOLV",
       RawData = "KOLV 041550Z 14025G32KT 10SM CLR 16/M01 A2967",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KNQA",
       RawData = "KNQA 041550Z 16014G29KT 10SM CLR 17/00 A2965",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KLWB",
       RawData = "KLWB 041550Z 00000KT 10SM CLR 07/M06 A3014",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KLAL",
       RawData = "KLAL 041550Z 11012G22KT 10SM BKN035 24/17 A3012",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KJWN",
       RawData = "KJWN 041550Z 15015G20KT 10SM CLR 16/M01 A2989",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KJQF",
       RawData = "KJQF 041550Z 16005KT 10SM SCT045 13/03 A3026",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KHSA",
       RawData = "KHSA 041550Z 15012G20KT 10SM BKN025 19/15 A2986",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KHQZ",
       RawData = "KHQZ 041550Z 19007G20KT 10SM SCT015 11/10 A2951",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KHOB",
       RawData = "KHOB 041550Z 27028G34KT 10SM CLR 10/M08 A2969",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KGYI",
       RawData = "KGYI 041550Z 21013G19KT 10SM CLR 13/09 A2944",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KFMH",
       RawData = "KFMH 041550Z 23018G27KT 10SM CLR 06/M03 A3026",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KFIN",
       RawData = "KFIN 041550Z 14017G24KT 10SM SCT034 23/13 A3016",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KESN",
       RawData = "KESN 041550Z 20012KT 10SM CLR 12/M01 A3023",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KDAG",
       RawData = "KDAG 041550Z AUTO 29010KT 10SM CLR 08/M01 A3018 RMK AO2 SLP214 T00831006",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KCWA",
       RawData = "KCWA 041550Z 11005KT 6SM BR SCT004 05/04 A2957",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KALN",
       RawData = "KALN 041550Z 17019G25KT 10SM OVC090 13/03 A2960",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KADS",
       RawData = "KADS 041550Z 21008G14KT 10SM SKC 14/09 A2948",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KADM",
       RawData = "KADM 041550Z COR 21005G12KT 10SM CLR 13/10 A2938",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "ETNG",
       RawData = "ETNG 041550Z 03003KT CAVOK 13/00 Q1025 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGYE",
       RawData = "EGYE 041550Z 23011KT CAVOK 11/M00 Q1022 RMK BLU",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGXC",
       RawData = "EGXC 041550Z 23011KT CAVOK 12/00 Q1022 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGTK",
       RawData = "EGTK 041550Z 23007KT CAVOK 12/M02 Q1023",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGQS",
       RawData = "EGQS 041550Z 24030G40KT 9999 FEW027 BKN300 11/05 Q1006 NOSIG RMK BLU BLU",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGQL",
       RawData = "EGQL 041550Z 25020KT 9999 OVC023 09/04 Q1012 RMK WHT",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EGEO",
       RawData = "EGEO 041550Z 21012KT 6000 -DZ OVC012 09/07 Q1013",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "EEEI",
       RawData = "EEEI 041550Z 28012KT CAVOK 03/M03 Q1002 NOSIG",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "BGJN",
       RawData = "BGJN 041550Z 12012KT 9999 -SN BKN025 M14/M19 Q0994",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "BGBW",
       RawData = "BGBW 041550Z 04009KT 9999 FEW110 M11/M21 Q0991 RMK 1AC",
       LastChange = "2025-03-04T15:50:00Z"
    },
    new Metar {
       Station = "KRYY",
       RawData = "KRYY 041549Z 12010G18KT 10SM BKN028 14/06 A3012 RMK AO2 SLP196 T01440061 $",
       LastChange = "2025-03-04T15:49:00Z"
    },
    new Metar {
       Station = "KGEU",
       RawData = "KGEU 041549Z 00000KT 10SM CLR 11/M01 A3014",
       LastChange = "2025-03-04T15:49:00Z"
    },
    new Metar {
       Station = "KBKB",
       RawData = "KBKB 041549Z AUTO VRB06KT 7SM -RA OVC019 21/18 A2954 RMK AO2 RAB34 SLP030 P0001 T02060178",
       LastChange = "2025-03-04T15:49:00Z"
    },
    new Metar {
       Station = "MMTM",
       RawData = "MMTM 041548Z 19008KT 2SM HZ BKN008 BKN200 23/22 A2970 RMK 8/108",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "MMEP",
       RawData = "MMEP 041548Z 27002KT 10SM SKC 21/07 A3007 RMK CI S",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "KTZR",
       RawData = "KTZR 041548Z 19011G14KT 10SM CLR 11/M03 A2995",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "KTOA",
       RawData = "KTOA 041548Z 06004KT 8SM SCT015 BKN020 13/09 A3024",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "KJDN",
       RawData = "KJDN 041548Z AUTO 31009KT M01/M03 A3012 RMK AO1 SLP230 T10111028",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "KASG",
       RawData = "KASG 041548Z 21014G21KT 1 1/2SM BR SCT004 BKN008 13/13 A2942",
       LastChange = "2025-03-04T15:48:00Z"
    },
    new Metar {
       Station = "MMSP",
       RawData = "MMSP 041547Z 23014KT 10SM BKN210 23/M06 A3016 RMK 8/008 AC",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "MMLO",
       RawData = "MMLO 041547Z 21004KT 10SM SCT250 21/M02 A3028 RMK 8/008 AC",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "MMCT",
       RawData = "MMCT 041547Z 13012KT 7SM BKN020 27/22 A2993 RMK 8/100 HZY MDT CU CI",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KTIX",
       RawData = "KTIX 041547Z 12015G25KT 7SM SCT035 25/14 A3016",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KSUN",
       RawData = "KSUN 041547Z 33008KT 10SM CLR 00/M08 A3008",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KSQL",
       RawData = "KSQL 041547Z 14005KT 10SM BKN023 OVC060 11/07 A3027",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KSEE",
       RawData = "KSEE 041547Z 00000KT 10SM BKN030 10/04 A3025",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KSAW",
       RawData = "KSAW 041547Z 00000KT 1 1/2SM -RA BR SCT002 OVC042 01/01 A2963",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KRHV",
       RawData = "KRHV 041547Z 00000KT 10SM BKN060 09/06 A3027",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KPOC",
       RawData = "KPOC 041547Z VRB04KT 10SM OVC030 09/04 A3025",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KPAO",
       RawData = "KPAO 041547Z 13007KT 10SM BKN060 09/07 A3027",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KLBE",
       RawData = "KLBE 041547Z 21013G19KT 10SM BKN150 13/M08 A3006",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KIWA",
       RawData = "KIWA 041547Z 11008KT 10SM CLR 10/M02 A3018",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KIFP",
       RawData = "KIFP 041547Z 00000KT 10SM CLR 10/M03 A3013",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KHUM",
       RawData = "KHUM 041547Z 14020G29KT 7SM BKN065 23/18 A2980",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KGYR",
       RawData = "KGYR 041547Z 12006KT 10SM SKC 12/M01 A3017",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KGYH",
       RawData = "KGYH 041547Z 11006KT 10SM BKN036 OVC049 12/03 A3021",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KEVB",
       RawData = "KEVB 041547Z 15017G25KT 10SM SCT045 24/15 A3016",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KCHD",
       RawData = "KCHD 041547Z 00000KT 10SM CLR 11/M01 A3016",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KCFO",
       RawData = "KCFO 041547Z 35019G26KT 10SM CLR 04/M01 A2979",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KAQV",
       RawData = "KAQV 041547Z AUTO 19011G22KT 9SM -RA OVC017 21/18 A2953 RMK AO2 PK WND 14028/1532 RAB05E14B39 SLP996 P0000 T02060178",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "KAEG",
       RawData = "KAEG 041547Z 30015G26KT 10SM CLR 05/M07 A2992",
       LastChange = "2025-03-04T15:47:00Z"
    },
    new Metar {
       Station = "MMTJ",
       RawData = "MMTJ 041546Z 11006KT 10SM BKN029 11/06 A3026 RMK 8/500 HZY",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "MMMX",
       RawData = "MMMX 041546Z 14002KT 8SM SKC 22/04 A3032 NOSIG RMK HZY",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "MMCM",
       RawData = "MMCM 041546Z 10010KT 7SM SCT020 29/21 A2994 RMK 8/500",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "MMCB",
       RawData = "MMCB 041546Z 04002KT 5SM SKC 26/10 A3013 RMK HZY VSBY E 3SM",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "KSCH",
       RawData = "KSCH 041546Z 18010KT 10SM BKN075 OVC080 A3012",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "KNRA",
       RawData = "KNRA 041546Z AUTO 14006KT 10SM CLR 08/04 A3001 RMK AO2 SLP105 T00780039 $",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "KCWF",
       RawData = "KCWF 041546Z 16020KT 7SM -RA OVC020 21/19 A2963 RMK RAB25",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "EQYS",
       RawData = "EQYS 041546Z AUTO 10SM CLR 16/07 A3018 RMK AO2 TSB1451E1453 SLP220 T01560067 PNO $",
       LastChange = "2025-03-04T15:46:00Z"
    },
    new Metar {
       Station = "TJIG",
       RawData = "TJIG 041545Z 08005KT 10SM SCT025 SCT035 BKN060 26/22 A3001",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "PAKU",
       RawData = "PAKU 041545Z 09018KT 10SM R06/P6000FT BKN070 BKN120 M17/ A2991",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "MMPB",
       RawData = "MMPB 041545Z 00000KT 7SM SKC 19/09 A3033 RMK HZY MSGTX MMMX",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "MMMD",
       RawData = "MMMD 041545Z 17015KT 7SM FEW015 29/20 A2989 RMK 8/100",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KUES",
       RawData = "KUES 041545Z 18010G16KT 10SM BKN033 OVC038 08/04 A2965",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KSWF",
       RawData = "KSWF 041545Z 20003KT 10SM SCT100 06/M06 A3016",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KRYN",
       RawData = "KRYN 041545Z CALMKT 10SM CLR 11/M04 A3016",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KOUN",
       RawData = "KOUN 041545Z 15011KT 10SM CLR 12/08 A2933",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KMWC",
       RawData = "KMWC 041545Z 19011KT 10SM OVC040 08/06 A2966",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KMWA",
       RawData = "KMWA 041545Z 18018G34KT 10SM SCT070 BKN100 16/01 A2971",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KMMU",
       RawData = "KMMU 041545Z 22005KT 10SM OVC095 05/M01 A3022",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KJVL",
       RawData = "KJVL 041545Z 17017G20KT 10SM OVC034 08/05 A2963",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KGYY",
       RawData = "KGYY 041545Z 18009KT 10SM -RA BKN033 OVC047 07/07 A2975 RMK LTG DSNT S",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KEMT",
       RawData = "KEMT 041545Z 08004KT 10SM BKN030 11/05 A3026",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KCGF",
       RawData = "KCGF 041545Z 20009G16KT 10SM OVC080 08/M07 A2994",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KBJC",
       RawData = "KBJC 041545Z 36014G24KT 10SM BKN090 06/M04 A2978",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KBAK",
       RawData = "KBAK 041545Z 19015G22KT 10SM SCT120 13/M04 A2982",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KATW",
       RawData = "KATW 041545Z 14007KT 10SM BKN050 08/04 A2962",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "KANE",
       RawData = "KANE 041545Z 35005KT 5SM DZ BKN015 05/05 A2958",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "K46U",
       RawData = "K46U 041545Z AUTO 29005KT 10SM FEW075 SCT090 M00/M02 A3005 RMK A01",
       LastChange = "2025-03-04T15:45:00Z"
    },
    new Metar {
       Station = "MMVR",
       RawData = "MMVR 041544Z 17009KT 3SM BR HZ FEW012 27/23 A2978 RMK 8/100",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMVA",
       RawData = "MMVA 041544Z 10008KT 8SM SKC 28/22 A2982",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMTG",
       RawData = "MMTG 041544Z 11003KT 6SM SKC 29/17 A2999 RMK HZY",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMPR",
       RawData = "MMPR 041544Z 03003KT 15SM FEW250 24/17 A2997 RMK 8/001",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMMV",
       RawData = "MMMV 041544Z 28017KT 12SM FEW200 26/M23 A2983 RMK 8/002",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMLT",
       RawData = "MMLT 041544Z 32009KT 4SM SCT200 18/09 A3014 RMK 8/001 HZY",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMCZ",
       RawData = "MMCZ 041544Z 16006KT 8SM FEW015 SCT250 28/18 A2996 RMK 8/508",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMCV",
       RawData = "MMCV 041544Z 00000KT 7SM SCT050 BKN100 24/18 A2968 RMK 8/530 HZY",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMCP",
       RawData = "MMCP 041544Z 14010G20KT 7SM FEW300 29/19 A2987 RMK 8/004",
       LastChange = "2025-03-04T15:44:00Z"
    },
    new Metar {
       Station = "MMZH",
       RawData = "MMZH 041543Z 23004KT 7SM SKC 28/18 A2992 RMK HZY",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMSD",
       RawData = "MMSD 041543Z 32014KT 10SM FEW140 SCT250 20/04 A3007 RMK 8/028",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMNL",
       RawData = "MMNL 041543Z 35015G25KT 3SM BLDU SCT200 23/00 A2975 RMK 8/002",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMMZ",
       RawData = "MMMZ 041543Z 00000KT 15SM BKN240 19/09 A2998 RMK 8/008 ISOL AC",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMMT",
       RawData = "MMMT 041543Z 36010KT 7SM FEW120 28/24 A2982 RMK 8/030",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMML",
       RawData = "MMML 041543Z 02005KT 10SM SKC 11/00 A3018",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMDO",
       RawData = "MMDO 041543Z 22013KT 9SM SCT150 BKN210 18/M16 A3017 RMK 8/012",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMBT",
       RawData = "MMBT 041543Z 20010KT 10SM SKC 29/22 A2991",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMAS",
       RawData = "MMAS 041543Z 18010KT 10SM FEW250 21/M01 A3026 RMK 8/005",
       LastChange = "2025-03-04T15:43:00Z"
    },
    new Metar {
       Station = "MMMA",
       RawData = "MMMA 041542Z 18016KT 4SM SCT080 BKN200 27/22 A2964 RMK 8/038 HZ VRB COND",
       LastChange = "2025-03-04T15:42:00Z"
    },
    new Metar {
       Station = "MMCU",
       RawData = "MMCU 041542Z 31004KT 10SM SKC 12/M19 A3012",
       LastChange = "2025-03-04T15:42:00Z"
    },
    new Metar {
       Station = "MMCE",
       RawData = "MMCE 041542Z 15012KT 7SM SKC 27/20 A2987",
       LastChange = "2025-03-04T15:42:00Z"
    },
    new Metar {
       Station = "MMTP",
       RawData = "MMTP 041541Z 00000KT 8SM SKC 30/24 A2992 RMK HZ",
       LastChange = "2025-03-04T15:41:00Z"
    },
    new Metar {
       Station = "MMTL",
       RawData = "MMTL 041541Z 11014KT 7SM SCT020 28/22 A2998 RMK 8/100 MDT CU",
       LastChange = "2025-03-04T15:41:00Z"
    },
    new Metar {
       Station = "MMPE",
       RawData = "MMPE 041541Z 13005KT 10SM SKC 14/06 A3018 RMK HZY",
       LastChange = "2025-03-04T15:41:00Z"
    },
    new Metar {
       Station = "MMLP",
       RawData = "MMLP 041541Z 36013KT 10SM FEW200 20/09 A3014 RMK 8/008 HZY",
       LastChange = "2025-03-04T15:41:00Z"
    },
    new Metar {
       Station = "MMZO",
       RawData = "MMZO 041540Z 00000KT 10SM SCT180 24/22 A2988 RMK 8/006",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMZC",
       RawData = "MMZC 041540Z E22030KT 8SM SCT100 SCT200 18/M02 A3021 RMK 8/076 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMTC",
       RawData = "MMTC 041540Z 01009KT 6SM BKN220 20/M17 A3003 RMK 8/002 ISOL AS HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMSL",
       RawData = "MMSL 041540Z 08007KT 10SM FEW250 19/12 A3006 RMK 8/008 ISOL AC",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMRX",
       RawData = "MMRX 041540Z 36005KT 4SM FEW100 BKN200 27/20 A2968 RMK 8/038 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMPN",
       RawData = "MMPN 041540Z 00000KT 10SM SKC 22/11 A3019 RMK HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMPA",
       RawData = "MMPA 041540Z 27004KT 3SM BR HZ BKN012 25/24 A2976 RMK 8/100 VRB CONS",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMOX",
       RawData = "MMOX 041540Z 20002KT 7SM SKC 22/10 A3021 RMK HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMMY",
       RawData = "MMMY 041540Z 34012G30KT 5SM SCT050 BKN100 28/08 A2969 RMK 8/570 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMMM",
       RawData = "MMMM 041540Z 00000KT 8SM SKC 20/08 A3027 RMK CI",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMLM",
       RawData = "MMLM 041540Z 31016KT 10SM BKN220 18/05 A3007 RMK 8/004 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMIA",
       RawData = "MMIA 041540Z 00000KT 6SM SKC 29/12 A3001",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMHO",
       RawData = "MMHO 041540Z 00000KT 10SM SCT200 17/M02 A3017 RMK 8/008 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMGM",
       RawData = "MMGM 041540Z 02008KT 10SM BKN200 17/03 A3010 RMK 8/001",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMGL",
       RawData = "MMGL 041540Z 00000KT 10SM SKC 24/M03 A3020",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMGA",
       RawData = "MMGA 041540Z E24005KT 10SM SCT200 ///// A3032 RMK 8/001",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMCS",
       RawData = "MMCS 041540Z 26019G31KT 6SM BLDU SKC 08/M06 A3000",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMCN",
       RawData = "MMCN 041540Z 33008KT 10SM BKN200 16/M03 A3011 RMK 8/008 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMAN",
       RawData = "MMAN 041540Z 34018KT 8SM BKN100 30/M05 A2971 RMK 8/020 HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "MMAA",
       RawData = "MMAA 041540Z 23004KT 8SM SKC 28/22 A2989 RMK HZY",
       LastChange = "2025-03-04T15:40:00Z"
    },
    new Metar {
       Station = "KFRR",
       RawData = "KFRR 041535Z AUTO 20006KT 160V240 10SM OVC070 15/M05 A3012 RMK AO1",
       LastChange = "2025-03-04T15:35:00Z"
    },
    new Metar {
       Station = "KF70",
       RawData = "KF70 041535Z AUTO 00000KT 10SM OVC022 06/03 A3025 RMK AO2",
       LastChange = "2025-03-04T15:35:00Z"
    },
    new Metar {
       Station = "RJOF",
       RawData = "RJOF 041534Z 34003KT 9999 FEW002 SCT005 BKN015 08/07 Q1014 RMK 1ST002 4ST005 7CU015 A2995",
       LastChange = "2025-03-04T15:34:00Z"
    },
    new Metar {
       Station = "RJTE",
       RawData = "RJTE 041531Z 02014KT 350V050 3000 -RA BR BKN007 03/02 Q1021 RMK 7ST007 A3017",
       LastChange = "2025-03-04T15:31:00Z"
    },
    new Metar {
       Station = "VOVZ",
       RawData = "VOVZ 041530Z 23004KT 4000 BR FEW018 28/27 Q1012 NOSIG",
       LastChange = "2025-03-04T15:30:00Z"
    },
    new Metar {
       Station = "VAUD",
       RawData = "VAUD 041530Z 03003KT 5000 HZ NSC 17/M06 Q1018 NOSIG",
       LastChange = "2025-03-04T15:30:00Z"
    },
    new Metar {
       Station = "DXXX",
       RawData = "DXXX 041530Z 21017KT 9999 FEW014 31/25 Q1006 NOSIG",
       LastChange = "2025-03-04T15:30:00Z"
    },
    new Metar {
       Station = "KLHM",
       RawData = "KLHM 041529Z AUTO 12007KT 10SM SCT100 09/07 A3024 RMK AO1",
       LastChange = "2025-03-04T15:29:00Z"
    },

            };
        }
    }
}
