/*自社情報*/
INSERT INTO m_our_company (
    phonetic,
    name,
    zip_code,
    address,
    phone,
    fax
) VALUES(
    "ｽｸﾞｸﾙｼｬﾊﾝｶﾌﾞｼｷｶﾞｲｼｬ",
    "スグクル社販株式会社",
    "530-0001",
    "大阪府大阪市北区梅田３丁目３−１",
    "06-6347-0001",
    "06-6345-3456"
);

/*社員情報*/
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0001",
    "ﾖｼﾀﾞﾕｳｷ",
    "吉田有希",
    "aaaaaaaa",
    0,
    "1997-12-09"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0002",
    "ｶﾜﾊﾗﾁｱｷ",
    "川原千秋",
    "aaaaaaaa",
    1,
    "1997-06-30"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0003",
    "ｲｼﾀﾞﾏｻﾋﾛ",
    "石田将晃",
    "aaaaaaaa",
    0,
    "1997-09-04"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0004",
    "ｶﾄｳｶｽﾞｷ",
    "加藤和樹",
    "aaaaaaaa",
    0,
    "1997-10-07"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0005",
    "ｺﾀﾆﾖｼｶｽﾞ",
    "小谷嘉一",
    "aaaaaaaa",
    0,
    "1997-03-25"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0006",
    "ﾐﾔﾊﾗﾁﾋﾛ",
    "宮原千尋",
    "aaaaaaaa",
    1,
    "1997-06-30"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0007",
    "ﾅｶﾑﾗｾｲｼﾞﾛｳ",
    "中村誠治郎",
    "aaaaaaaa",
    0,
    "1997-04-05"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0008",
    "ﾓﾁﾂﾞｷﾚﾅ",
    "望月怜奈",
    "aaaaaaaa",
    1,
    "1997-10-14"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0009",
    "ﾄｳﾄﾞｳｻｸﾔ",
    "東堂朔夜",
    "aaaaaaaa",
    0,
    "1997-011-05"
);
INSERT INTO m_employees (
    id,
    phonetic,
    name,
    password,
    gender,
    birthday
) VALUES (
    "aaaa0010",
    "ﾀﾁﾊﾞﾅﾀﾂﾏﾙ",
    "橘龍丸",
    "aaaaaaaa",
    0,
    "1997-04-21"
);

/*顧客情報*/
INSERT INTO t_customers (
    phonetic,
    name,
    zip_code,
    address,
    phone,
    fax
) VALUES (
    "ｶﾌﾞｼｷｶﾞｲｼｬｱｼｽﾄ",
    "株式会社アシスト",
    "152-0003",
    "東京都目黒区碑文谷6-7-1",
    "03-6712-2013",
    "03-6712-2015"
);
INSERT INTO t_customers (
    phonetic,
    name,
    zip_code,
    address,
    phone,
    fax
) VALUES (
    "ｶﾌﾞｼｷｶﾞｲｼｬﾌﾟﾛﾀﾞｸｼｮﾝｵｷﾞ",
    "株式会社プロダクション尾木",
    "104-0061",
    "東京都中央区銀座四丁目3-6",
    "03-6263-0541",
    "03-6263-0551"
);
INSERT INTO t_customers (
    phonetic,
    name,
    zip_code,
    address,
    phone,
    fax
) VALUES (
    "ｶﾌﾞｼｷｶﾞｲｼｬﾘｼｪ",
    "株式会社リシェ",
    "153-0043",
    "東京都目黒区東山1丁目8番11号 タウンハウス中目黒203",
    "03-6303-3853",
    "03-6745-1743"
);