using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /*顧客情報のエンティティクラス*/
    class Customers
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _id; //主キー
        private String _phonetic; //フリガナ
        private String _name; //顧客名
        private String _zipCode; //郵便番号
        private String _address; //住所
        private String _phone; //電話番号
        private String _fax; //FAX電話番号
        private int _creditLimit; //与信限度額
        private int _carryOver; //繰り越し分
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public Customers()
        {
            this._id = 0;
            this._phonetic = "";
            this._name = "";
            this._zipCode = "";
            this._address = "";
            this._phone = "";
            this._fax = "";
            this._creditLimit = 20000000;
            this._carryOver = 0;
        }
        /*-------------------------------------------------*/

        /*セッター*/
        /*-------------------------------------------------*/
        //主キー
        public void setId(int id)
        {
            this._id = id;
        }
        public void setId(String id)
        {
            this._id = int.Parse(id);
        }
        //フリガナ
        public void setPhonetic(String phonetic)
        {
            this._phonetic = phonetic;
        }
        //顧客名
        public void setName(String name)
        {
            this._name = name;
        }
        //郵便番号
        public void setZipCode(String zipCode)
        {
            this._zipCode = zipCode;
        }
        //住所
        public void setAddress(String address)
        {
            this._address = address;
        }
        //電話番号
        public void setPhone(String phone)
        {
            this._phone = phone;
        }
        //FAX番号
        public void setFax(String fax)
        {
            this._fax = fax;
        }
        //与信限度額
        public void setCreditLimit(int creditLimit)
        {
            this._creditLimit = creditLimit;
        }
        public void setCreditLimit(String creditLimit)
        {
            this._creditLimit = int.Parse(creditLimit);
        }
        //繰り越し分
        public void setCarryOver(int carryOver)
        {
            this._carryOver = carryOver;
        }
        public void setCarryOver(String carryOver)
        {
            this._carryOver = int.Parse(carryOver);
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //主キー
        public int getId()
        {
            return this._id;
        }
        //フリガナ
        public String getPhonetic()
        {
            return this._phonetic;
        }
        //顧客名
        public String getName()
        {
            return this._name;
        }
        //郵便番号
        public String getZipCode()
        {
            return this._zipCode;
        }
        //住所
        public String getAddress()
        {
            return this._address;
        }
        //電話番号
        public String getPhone()
        {
            return this._phone;
        }
        //FAX番号
        public String getFax()
        {
            return this._fax;
        }
        //与信限度額
        public int getCreditLimit()
        {
            return this._creditLimit;
        }
        //繰り越し分
        public int getCarryOver()
        {
            return this._carryOver;
        }
        /*-------------------------------------------------*/
    }
}
