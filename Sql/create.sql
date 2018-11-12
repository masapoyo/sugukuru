#IH31 スグクル
DROP DATABASE IF EXISTS sugukuru;
CREATE DATABASE sugukuru CHARACTER SET utf8;
use sugukuru;

#M自社テーブル
CREATE TABLE m_our_company (
    #
    #
    #
    #
    #
    #
    #
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#M顧客テーブル
CREATE TABLE m_customers (
    id INT(8) NOT NULL AUTO_INCREMENT    #顧客ID
    phonetic VARCHAR(512)    #フリガナ
    name VARCHAR(256) NOT NULL    #顧客名
    address VARCHAR(128)    #住所
    zip_code CHAR(7)    #郵便番号
    phone CHAR(12)  #電話番号
    fax CHAR(12)    #FAX番号
    PRIMARY KEY(id), 
    INDEX(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#M社員テーブル
CREATE TABLE m_customers (
    id CHAR(8) NOT NULL #社員ID
    phonetic VARCHAR(512)   #フリガナ
    name VARCHAR(256) NOT NULL   #社員名
    password VARCHAR(128)#パスワード
    gender BOOL #性別
    birthday DATE   #生年月日
    PRIMARY KEY(id), 
    INDEX(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T与信テーブル
CREATE TABLE t_credits (
    no INT NOT NULL AUTO_INCREMENT  #No
    id CHAR NOT NULL #顧客ID
    credit_limit DECIMAL(13, 0) NOT NULL DEFAULT 20000000  #与信限度額
    PRIMARY KEY(id), 
    INDEX(id), 
    FOREIGN KEY (id) REFERENCES m_customers(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#T買注文テーブル
    #連番(ID)
    #顧客ID - r顧客
    #営業担当者 - r社員
    #車両名
    #年式
    #色
    #走行距離
    #予算
    #予算の振れ幅（以下か付近か）
    #変更機構の種別
    #備考
    #受注日
#T納品テーブル
