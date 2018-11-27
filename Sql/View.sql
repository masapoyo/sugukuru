/*顧客名、請求金額、うち繰越金額、請求書発行日*/

#入金照会画面で表示する請求一覧用のVIEW
CREATE VIEW v_bills AS (
    SELECT 
        t_bills.no AS no, #請求No
        t_customers.id AS customer_id, #顧客ID
        t_customers.phonetic AS phonetic, #フリガナ
        t_customers.name AS customer, #顧客名
        t_orders.no AS order_id, #受注ID
        (
            t_orders.contracted + 
            t_orders.expenses + 
            t_orders.commision +
            t_customers.carry_over
        ) AS price, #請求金額
        t_customers.carry_over AS carry_over, #うち繰越金額
        t_bills.printed_at AS printed_at, #発行日
        t_bills.cleared AS cleared #消込フラグ
    FROM t_orders
        INNER JOIN t_customers ON t_orders.customer = t_customers.id
        INNER JOIN t_deliverables ON t_customers.id = t_deliverables.customer
        INNER JOIN t_billed_delivered ON t_deliverables.no = t_billed_delivered.deliverable_no
        INNER JOIN t_bills ON t_billed_delivered.bill_no = t_bills.no
    ORDER BY no
);

/*請求金額＝
落札価格（contracted）＋諸経費（expenses）＋買手数料（commision）*/


#受注、顧客、担当
#受注詳細で取得するVIEW
CREATE VIEW v_orders AS (
    SELECT 
        t_orders.no AS no, 
        t_orders.car_name AS car_name, 
        t_orders.car_year AS car_year, 
        t_orders.car_model AS car_model,
        t_orders.car_color AS car_color, 
        t_orders.car_mileage AS car_mileage, 
        t_orders.budget AS budget, 
        t_orders.budget_category AS budget_category, 
        t_orders.transmission AS transmission, 
        t_orders.note AS note, 
        t_orders.received_at AS received_at, 
        t_orders.cleared AS cleared, 
        t_orders.contracted AS contracted, 
        t_orders.expenses AS expenses, 
        t_orders.commision AS commision, 
        t_orders.customer AS customer_id, 
        t_customers.phonetic AS customer_phonetic, 
        t_customers.name AS customer_name, 
        t_customers.zip_code AS customer_zip_code, 
        t_customers.address AS customer_address,
        t_customers.phone AS customer_phone,
        t_customers.fax AS customer_fax, 
        t_customers.credit_limit AS customer_credit_limit, 
        t_customers.carry_over AS customer_carry_over, 
        t_orders.rep AS rep_id, 
        m_employees.phonetic AS rep_phonetic, 
        m_employees.name AS rep_name, 
        m_employees.gender AS rep_gender, 
        m_employees.birthday AS rep_birthday 
    FROM t_orders 
        LEFT JOIN t_customers ON t_orders.customer = t_customers.id 
        LEFT JOIN m_employees ON t_orders.rep = m_employees.id 
    ORDER BY no ASC
);
