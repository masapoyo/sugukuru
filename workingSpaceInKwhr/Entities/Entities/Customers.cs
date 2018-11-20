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
        private string _phonetic; //フリガナ
        private string _name; //顧客名
        private string _zipCode; //郵便番号
        private string _address; //住所
        private string _phone; //電話番号
        private string _fax; //FAX電話番号
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
        public void setId(string id)
        {
            this._id = int.Parse(id);
        }
        //フリガナ
        public void setPhonetic(string phonetic)
        {
            this._phonetic = phonetic;
        }
        //顧客名
        public void setName(string name)
        {
            this._name = name;
        }
        //郵便番号
        public void setZipCode(string zipCode)
        {
            this._zipCode = zipCode;
        }
        //住所
        public void setAddress(string address)
        {
            this._address = address;
        }
        //電話番号
        public void setPhone(string phone)
        {
            this._phone = phone;
        }
        //FAX番号
        public void setFax(string fax)
        {
            this._fax = fax;
        }
        //与信限度額
        public void setCreditLimit(int creditLimit)
        {
            this._creditLimit = creditLimit;
        }
        public void setCreditLimit(string creditLimit)
        {
            this._creditLimit = int.Parse(creditLimit);
        }
        //繰り越し分
        public void setCarryOver(int carryOver)
        {
            this._carryOver = carryOver;
        }
        public void setCarryOver(string carryOver)
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
        public string getPhonetic()
        {
            return this._phonetic;
        }
        //顧客名
        public string getName()
        {
            return this._name;
        }
        //郵便番号
        public string getZipCode()
        {
            return this._zipCode;
        }
        //住所
        public string getAddress()
        {
            return this._address;
        }
        //電話番号
        public string getPhone()
        {
            return this._phone;
        }
        //FAX番号
        public string getFax()
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
