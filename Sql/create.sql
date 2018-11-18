#IH31 スグクル社 車両販売管理システム データベース
#作成開始
DROP DATABASE IF EXISTS sugukuru;
CREATE DATABASE sugukuru CHARACTER SET utf8;
use sugukuru;

#M自社テーブル
CREATE TABLE m_our_company (
    id INT(8) NOT NULL AUTO_INCREMENT,  #ID
    phonetic VARCHAR(512),  #フリガナ
    name VARCHAR(256) NOT NULL, #社名
    zip_code CHAR(7),   #郵便番号
    address VARCHAR(128),   #住所
    phone CHAR(12), #電話番号
    fax CHAR(12),#FAX番号
    PRIMARY KEY(id), 
    INDEX(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#M社員テーブル
CREATE TABLE m_employees (
    id CHAR(8) NOT NULL, #社員ID
    phonetic VARCHAR(512),   #フリガナ
    name VARCHAR(256) NOT NULL,   #社員名
    password VARCHAR(128),   #パスワード
    gender BOOLEAN, #性別
    birthday DATE,   #生年月日
    PRIMARY KEY(id), 
    INDEX(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T顧客テーブル
CREATE TABLE t_customers (
    id INT(8) NOT NULL AUTO_INCREMENT,    #顧客ID
    phonetic VARCHAR(512),    #フリガナ
    name VARCHAR(256) NOT NULL,    #顧客名
    zip_code CHAR(7),    #郵便番号
    address VARCHAR(128),    #住所
    phone CHAR(12),  #電話番号
    fax CHAR(12),    #FAX番号
    credit_limit DECIMAL(13, 0) NOT NULL DEFAULT 20000000,  #与信限度額
    carry_over DECIMAL(13, 0) DEFAULT 0,    #繰り越し分
    PRIMARY KEY(id), 
    INDEX(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T買注文テーブル（受注）
CREATE TABLE t_orders (
    no INT NOT NULL AUTO_INCREMENT, #連番
    customer INT NOT NULL,  #顧客ID - r顧客
    rep CHAR(8),    #営業担当者 - r社員
    car_name VARCHAR(512),  #車両名
    car_year VARCHAR(4),    #年式
    car_color VARCHAR(128), #色
    car_mileage DOUBLE, #走行距離
    budget DECIMAL(13, 0),  #予算
    budget_category BOOLEAN DEFAULT FALSE,  #予算の振れ幅（以下か付近か）
    transmission INT DEFAULT 1, #変更機構の種別
    note TEXT,  #備考
    received_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,    #受注日
    cleared BOOLEAN NOT NULL DEFAULT FALSE, #受注消込
    contracted DECIMAL(13, 0) DEFAULT NULL, #落札価格
    expenses DECIMAL(13, 0) DEFAULT NULL,   #オークション諸経費
    commision DECIMAL(13, 0) DEFAULT NULL,  #買手数料
    PRIMARY KEY(no), 
    INDEX(no), 
    FOREIGN KEY (customer) REFERENCES t_customers(id),
    FOREIGN KEY (rep) REFERENCES m_employees(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T納品テーブル
CREATE TABLE t_deliverables (
    no INT NOT NULL AUTO_INCREMENT, #連番
    customer INT NOT NULL,  #顧客ID
    printed_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, #発行日
    PRIMARY KEY(no), 
    INDEX(no),
    FOREIGN KEY (customer) REFERENCES t_customers(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T納品-受注テーブル
CREATE TABLE t_ordered_delivered (
    id INT NOT NULL AUTO_INCREMENT, #ID
    order_no INT NOT NULL, #受注no
    deliverable_no INT NOT NULL, #納品no
    PRIMARY KEY(id), 
    INDEX(id),
    FOREIGN KEY (order_no) REFERENCES t_orders(no), 
    FOREIGN KEY (deliverable_no) REFERENCES t_deliverables(no)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T請求テーブル
CREATE TABLE t_bills (
    no INT NOT NULL AUTO_INCREMENT, #no
    printed_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, #発行日
    cleared BOOLEAN NOT NULL DEFAULT FALSE, #請求消込
    PRIMARY KEY(no), 
    INDEX(no)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T請求-納品テーブル
CREATE TABLE t_billed_delivered (
    no INT NOT NULL AUTO_INCREMENT, #no
    deliverable_no INT NOT NULL,    #納品No
    bill_no INT NOT NULL,   #請求No
    PRIMARY KEY(no), 
    INDEX(no),
    FOREIGN KEY (deliverable_no) REFERENCES t_deliverables(no),
    FOREIGN KEY (bill_no) REFERENCES t_bills(no)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#終了
