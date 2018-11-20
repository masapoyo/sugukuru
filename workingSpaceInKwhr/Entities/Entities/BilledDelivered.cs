using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class BilledDelivered
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _no; //主キー
        private Deliverables _deliverableNo; //納品No
        private Bills _billNo; //請求No
        /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public BilledDelivered()
        {
            this._no = 0;
            this._deliverableNo = new Deliverables();
            this._billNo = new Bills();
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
        //納品No
        public void setDeliveravleNo(int deliverableNo)
        {
            this._deliverableNo.setNo(deliverableNo);
        }
        public void setDeliveravleNo(string deliverableNo)
        {
            this._deliverableNo.setNo(deliverableNo);
        }
        //請求No
        public void setBillNo(int billNo)
        {
            this._billNo.setNo(billNo);
        }
        public void setBillNo(string billNo)
        {
            this._billNo.setNo(billNo);
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //主キー
        public int getNo()
        {
            return this._no;
        }
        //納品No
        public int getDeliverableNo()
        {
            return this._deliverableNo.getNo();
        }
        //請求No
        public int getBillNo()
        {
            return this._billNo.getNo();
        }
        /*-------------------------------------------------*/
    }
}
