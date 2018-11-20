using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Bills
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _no; //主キー
        private string _printedAt; //発行日
        private Boolean _cleared; //請求消込
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public Bills()
        {
            this._no = 0;
            this._printedAt = "";
            this._cleared = false;
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
        //発行日
        public void setPrintedAt(string printedAt)
        {
            this._printedAt = printedAt;
        }
        //請求消込
        public void setCleared(Boolean cleared)
        {
            this._cleared = cleared;
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //主キー
        public int getNo()
        {
            return this._no;
        }
        //受注No
        public string getPrintedAt()
        {
            return this._printedAt;
        }
        //納品No
        public Boolean isCleared()
        {
            return this._cleared;
        }
        /*-------------------------------------------------*/
    }
}
