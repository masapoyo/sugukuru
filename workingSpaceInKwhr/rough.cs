/*フィールド*/
/*-------------------------------------------------*/
private int _no; //主キー
private Customers _customer; //顧客ID
private string _printedAt; //発行日
/*-------------------------------------------------*/

/*コンストラクタ*/
/*-------------------------------------------------*/
public Deliverables() {
    this._no = 0;
    this._customer = new Customers();
    this._printedAt = "";
}
/*-------------------------------------------------*/

/*セッター*/
/*-------------------------------------------------*/
//主キー
public void setNo(int no) {
    this._no = no;
}
public void setNo(string no) {
    this._no = int.Parse(no);
}
//顧客ID
public void setCustomer(int customer) {
    this._customer.setId(customer);
}
public void setCustomer(string customer) {
    this._customer.setId(customer);
}
//発行日
public void setPrintedAt(string printedAt) {
    this._printedAt = printedAt;
}
/*-------------------------------------------------*/

/*ゲッター*/
/*-------------------------------------------------*/
//主キー
public int getNo() {
    return this._no;
}
//顧客ID
public int getCustomer() {
    return this._customer.getId();
}
//発行日
public string getPrintedAt() {
    return this._printedAt;
}
/*-------------------------------------------------*/