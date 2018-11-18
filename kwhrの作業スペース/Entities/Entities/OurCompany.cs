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
        private String _phonetic; //フリガナ
        private String _name; //社名
        private String _zipCode; //郵便番号
        private String _address; //住所
        private String _phone; //電話番号
        private String _fax; //FAX電話番号
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
        public void setId(String id)
        {
            this._id = int.Parse(id);
        }
        //フリガナ
        public void setPhonetic(String phonetic)
        {
            this._phonetic = phonetic;
        }
        //社名
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
            return this._phone;
        }
        //社名
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
        public String getFac()
        {
            return this._fax;
        }
        /*-------------------------------------------------*/
    }
}
