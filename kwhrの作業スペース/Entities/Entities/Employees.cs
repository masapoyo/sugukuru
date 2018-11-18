using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /*社員情報のエンティティクラス*/
    class Employees
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private String _id; //社員ID
        private String _phonetic; //フリガナ
        private String _name; //社員名
        private String _passwrod; //パスワード
        private String _gender; //性別
        private String _birthday; //生年月日
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public Employees()
        {
            this._id = "";
            this._phonetic = "";
            this._name = "";
            this._passwrod = "";
            this._gender = "";
            this._birthday = "";
        }
        /*-------------------------------------------------*/

        /*セッター*/
        /*-------------------------------------------------*/
        //社員ID
        public void setId(String id)
        {
            this._id = id;
        }
        //フリガナ
        public void setPhonetic(String phonetic)
        {
            this._phonetic = phonetic;
        }
        //社員名
        public void setName(String name)
        {
            this._name = name;
        }
        //パスワード
        public void setPassword(String password)
        {
            this._passwrod = password;
        }
        //性別
        public void setGender(Boolean gender) {
            if(!gender) {
                this._gender = "男";
            }
            else {
                this._gender = "女";
            }
        }
        //生年月日
        public void setBirthday(String birthday)
        {
            this._birthday = birthday;
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //社員ID
        public String getId()
        {
            return this._id;
        }
        //フリガナ
        public String getPhonetic()
        {
            return this._phonetic;
        }
        //社員名
        public String getName()
        {
            return this._name;
        }
        //パスワード
        public String getPassword()
        {
            return this._passwrod;
        }
        //性別
        public String getGender()
        {
            return this._gender;
        }
        //生年月日
        public String getBirthday()
        {
            return this._birthday;
        }
        /*-------------------------------------------------*/
    }
}
