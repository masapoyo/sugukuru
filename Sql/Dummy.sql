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
    "ｶ)ｱｼｽﾄ",
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
    "ｶ)ﾌﾟﾛﾀﾞｸｼｮﾝｵｷﾞ",
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
    "ｶ)ﾘｼｪ",
    "株式会社リシェ",
    "153-0043",
    "東京都目黒区東山1丁目8番11号 タウンハウス中目黒203",
    "03-6303-3853",
    "03-6745-1743"
);

/*受注*/
INSERT INTO t_orders (
    customer,
    rep,
    car_name,
    car_year,
    car_color,
    car_model,
    car_mileage,
    budget,
    budget_category,
    transmission,
    note,
    cleared,
    contracted,
    expenses,
    commision
) VALUES (
    1,
    "aaaa0007",
    "DBA-JF3",
    "2017",
    "青",
    "",
    5,
    5000000,
    true,
    3,
    "テスト受注データ",
    false,
    5000000,
    400000,
    400000
);
INSERT INTO t_orders (
    customer,
    rep,
    car_name,
    car_year,
    car_color,
    car_model,
    car_mileage,
    budget,
    budget_category,
    transmission,
    note,
    cleared,
    contracted,
    expenses,
    commision
) VALUES (
    2,
    "aaaa0005",
    "NBOX",
    "2015",
    "黒",
    "DBA-JF4",
    4.6,
    6000000,
    false,
    2,
    "テスト受注データ2",
    false,
    6000000,
    300000,
    200000
);
INSERT INTO t_orders (
    customer,
    rep,
    car_name,
    car_year,
    car_color,
    car_model,
    car_mileage,
    budget,
    budget_category,
    transmission,
    note,
    cleared,
    contracted,
    expenses,
    commision
) VALUES (
    3,
    "aaaa0002",
    "ワゴンR",
    "2013",
    "黒",
    "DAA-MH55S",
    3.2,
    5500000,
    false,
    0,
    "テスト受注データ3",
    false,
    5500000,
    500000,
    400000
);

/*納品*/
INSERT INTO t_deliverables (
    customer
) VALUES (
    1
);
INSERT INTO t_deliverables (
    customer
) VALUES (
    2
);

/*納品・受注*/
INSERT INTO t_ordered_delivered (
    order_no,
    deliverable_no
) VALUES (
    1,
    1
);
INSERT INTO t_ordered_delivered (
    order_no,
    deliverable_no
) VALUES (
    2,
    2
);

/*請求*/
INSERT INTO t_bills (
    cleared
) VALUES (
    false
);
INSERT INTO t_bills (
    cleared
) VALUES (
    false
);

/*請求・納品*/
INSERT INTO t_billed_delivered (
    deliverable_no,
    bill_no
) VALUES (
    1,
    1
);
INSERT INTO t_billed_delivered (
    deliverable_no,
    bill_no
) VALUES (
    2,
    2
);