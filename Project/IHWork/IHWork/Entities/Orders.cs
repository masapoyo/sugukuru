using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /*買注文情報のエンティティクラス*/
    class Orders
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _no; //主キー
        private Customers _customer; //顧客ID
        private Employees _rep; //営業担当者(社員ID)
        private string _carName; //車両名
        private string _carYear; //年式
        private string _carColor; //色
        private double _carMileage; //走行距離
        private int _budget; //予算
        private Boolean _budgetCategory; //予算の振れ幅（true:付近、false:以下)
        private int _transmission; //変更機構の種別
        private string _note; //備考
        private string _receivedAt; //受注日
        private Boolean _cleared; //受注消込
        private int _contracted; //落札価格
        private int _expenses; //オークション諸経費
        private int _commision; //買手数料
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public Orders()
        {
            this._no = 0;
            this._customer = new Customers();
            this._rep = new Employees();
            this._carName = "";
            this._carYear = "";
            this._carColor = "";
            this._carMileage = 0;
            this._budget = 0;
            this._budgetCategory = false;
            this._transmission = 1;
            this._note = "";
            this._receivedAt = "";
            this._cleared = false;
            this._contracted = 0;
            this._expenses = 0;
            this._commision = 0;
        }
        /*-------------------------------------------------*/

        /*セッター*/
        /*-------------------------------------------------*/
        //主キー
        public void setNo(int no)
        {
            this._no = no;
        }
        public void setNo(string no)
        {
            this._no = int.Parse(no);
        }
        //顧客ID
        public void setCustomer(int customer)
        {
            this._customer.setId(customer);
        }
        public void setCustomer(string customer)
        {
            this._customer.setId(customer);
        }
        //営業担当者（社員ID）
        public void setRep(string rep)
        {
            this._rep.setId(rep);
        }
        //車両名
        public void setCarName(string carName)
        {
            this._carName = carName;
        }
        //年式
        public void setCarYear(string carYear)
        {
            this._carYear = carYear;
        }
        //色
        public void setCarColor(string carColor)
        {
            this._carColor = carColor;
        }
        //走行距離
        public void setCarMileage(double carMileage)
        {
            this._carMileage = carMileage;
        }
        //予算
        public void setBudget(int budget)
        {
            this._budget = budget;
        }
        //予算の振れ幅
        public void setBudgetCategory(Boolean budgetCategory)
        {
            this._budgetCategory = budgetCategory;
        }
        //変更機構の種別
        public void setTransmission(int transmission)
        {
            this._transmission = transmission;
        }
        //備考
        public void setNote(string note)
        {
            this._note = note;
        }
        //受注日
        public void setReceivedAt(string receivedAt)
        {
            this._receivedAt = receivedAt;
        }
        //受注消込
        public void setCleared(Boolean cleared)
        {
            this._cleared = cleared;
        }
        //落札価格
        public void setContracted(int contracted)
        {
            this._contracted = contracted;
        }
        //オークション諸経費
        public void setExpenses(int expenses)
        {
            this._expenses = expenses;
        }
        //買手数料
        public void setCommision(int commision)
        {
            this._commision = commision;
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //主キー
        public int getNo()
        {
            return this._no;
        }
        //顧客ID
        public int getCustomer()
        {
            return this._customer.getId();
        }
        //営業担当者（社員ID）
        public string getRep()
        {
            return this._rep.getId();
        }
        //車両名
        public string getCarName()
        {
            return this._carName;
        }
        //年式
        public string getCarYear()
        {
            return this._carYear;
        }
        //色
        public string getCarColor()
        {
            return this._carColor;
        }
        //走行距離
        public double getCarMileage()
        {
            return this._carMileage;
        }
        //予算
        public int getBudget()
        {
            return this._budget;
        }
        //予算の振れ幅
        public Boolean isAround()
        {
            return this._budgetCategory;
        }
        //変更機構の種別
        public int getTransmission()
        {
            return this._transmission;
        }
        //備考
        public string getNote()
        {
            return this._note;
        }
        //受注日
        public string getReceivedAt()
        {
            return this._receivedAt;
        }
        //受注消込
        public Boolean isCleared()
        {
            return this._cleared;
        }
        //落札価格
        public int getContracted()
        {
            return this._contracted;
        }
        //オークション諸経費
        public int getExpenses()
        {
            return this._expenses;
        }
        //買手数料
        public int getCommision()
        {
            return this._commision;
        }
        /*-------------------------------------------------*/
    }
}
