using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /*自社情報のエンティティクラス*/
    class OurCompany
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _id; //主キー
        private string _phonetic; //フリガナ
        private string _name; //社名
        private string _zipCode; //郵便番号
        private string _address; //住所
        private string _phone; //電話番号
        private string _fax; //FAX電話番号
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public OurCompany()
        {
            this._id = 0;
            this._phonetic = "";
            this._name = "";
            this._zipCode = "";
            this._address = "";
            this._phone = "";
            this._fax = "";
        }
        /*-------------------------------------------------*/

        /*セッター*/
        /*-------------------------------------------------*/
        //主キー
        public void setId(int id)
        {
            this._id = id;
        }
        //主キー
        public void setId(string id)
        {
            this._id = int.Parse(id);
        }
        //フリガナ
        public void setPhonetic(string phonetic)
        {
            this._phonetic = phonetic;
        }
        //社名
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
            return this._phone;
        }
        //社名
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
        public string getFac()
        {
            return this._fax;
        }
        /*-------------------------------------------------*/
    }
}
