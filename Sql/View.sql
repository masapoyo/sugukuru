/*顧客名、請求金額、うち繰越金額、請求書発行日*/

#入金照会画面で表示する請求一覧用のVIEW
CREATE VIEW v_bills AS (
    SELECT 
        t_bills.no AS no, #請求No
        t_customers.id AS customer_id, #顧客ID
        t_customers.name AS customer, #顧客名
        t_orders.no AS order_id, #受注ID
        (
            t_orders.contracted + 
            t_orders.expenses + 
            t_orders.commision +
            t_customers.carry_over
        ) AS price, #請求金額
        t_customers.carry_over AS carry_over, #うち繰越金額
        t_bills.printed_at AS printed_at #発行日
    FROM t_orders
        INNER JOIN t_customers ON t_orders.customer = t_customers.id
        INNER JOIN t_deliverables ON t_customers.id = t_deliverables.customer
        INNER JOIN t_billed_delivered ON t_deliverables.no = t_billed_delivered.deliverable_no
        INNER JOIN t_bills ON t_billed_delivered.bill_no = t_bills.no
    ORDER BY no
);

/*請求金額＝
落札価格（contracted）＋諸経費（expenses）＋買手数料（commision）*/
