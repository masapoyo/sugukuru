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
        private string _id; //社員ID
        private string _phonetic; //フリガナ
        private string _name; //社員名
        private string _passwrod; //パスワード
        private string _gender; //性別
        private string _birthday; //生年月日
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
        public void setId(string id)
        {
            this._id = id;
        }
        //フリガナ
        public void setPhonetic(string phonetic)
        {
            this._phonetic = phonetic;
        }
        //社員名
        public void setName(string name)
        {
            this._name = name;
        }
        //パスワード
        public void setPassword(string password)
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
        public void setBirthday(string birthday)
        {
            this._birthday = birthday;
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //社員ID
        public string getId()
        {
            return this._id;
        }
        //フリガナ
        public string getPhonetic()
        {
            return this._phonetic;
        }
        //社員名
        public string getName()
        {
            return this._name;
        }
        //パスワード
        public string getPassword()
        {
            return this._passwrod;
        }
        //性別
        public string getGender()
        {
            return this._gender;
        }
        //生年月日
        public string getBirthday()
        {
            return this._birthday;
        }
        /*-------------------------------------------------*/
    }
}
