using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class OrderdDelivered
    {
        /*フィールド*/
        /*-------------------------------------------------*/
        private int _id; //主キー
        private Orders _orderNo; //受注No
        private Deliverables _deliverableNo; //納品No
                                             /*-------------------------------------------------*/

        /*コンストラクタ*/
        /*-------------------------------------------------*/
        public OrderdDelivered()
        {
            this._id = 0;
            this._orderNo = new Orders();
            this._deliverableNo = new Deliverables();
        }
        /*-------------------------------------------------*/

        /*セッター*/
        /*-------------------------------------------------*/
        //主キー
        public void setNo(int id)
        {
            this._id = id;
        }
        public void setNo(string id)
        {
            this._id = int.Parse(id);
        }
        //受注No
        public void setOrderNo(int orderNo)
        {
            this._orderNo.setNo(orderNo);
        }
        public void setOrderNo(string orderNo)
        {
            this._orderNo.setNo(orderNo);
        }
        //納品No
        public void setDeliverableNo(int deliverableNo)
        {
            this._deliverableNo.setNo(deliverableNo);
        }
        public void setDeliverableNo(string deliverableNo)
        {
            this._deliverableNo.setNo(deliverableNo);
        }
        /*-------------------------------------------------*/

        /*ゲッター*/
        /*-------------------------------------------------*/
        //主キー
        public int getId()
        {
            return this._id;
        }
        //受注No
        public int getOrderNo()
        {
            return this._orderNo.getNo();
        }
        //納品No
        public int getDeliverableNo()
        {
            return this._deliverableNo.getNo();
        }
        /*-------------------------------------------------*/
    }
}
