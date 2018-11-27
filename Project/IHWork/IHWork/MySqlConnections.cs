﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;   // デバッグ用
using Entities;

namespace IHWork
{
    class MySqlConnections
    {
        Employees emp = new Employees();
        String ConStr;
        DataSet dset;
        MySql.Data.MySqlClient.MySqlConnection con;

        public MySqlConnections()
        {
            this.ConStr = ConfigurationManager.AppSettings["DbConKey"];
            con = new MySqlConnection(this.ConStr);
        }

        public Employees CheckLogin(String id, String pass)
        {
            this.dset = new DataSet("m_employees");
            String sql = "select " +
                "   id, " +
                "   phonetic, " +
                "   name, " +
                "   password, " +
                "   gender, " +
                "   birthday " +
                " from " +
                "   m_employees" +
                " where " +
                "   id = @id " +
                " and" +
                "   password = @pass ";

            try
            {
                //SQL接続
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, this.con);
                //インジェクション対策
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Parameters.Add(new MySqlParameter("pass", pass));
                // データアダプター作成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(cmd);
                // データ抽出＆取得
                mAdp.Fill(dset, "m_employees");


                emp.setId(dset.Tables["m_employees"].Rows[0]["id"].ToString());
                emp.setPhonetic(dset.Tables["m_employees"].Rows[0]["phonetic"].ToString());
                emp.setName(dset.Tables["m_employees"].Rows[0]["name"].ToString());
                emp.setPassword(dset.Tables["m_employees"].Rows[0]["password"].ToString());
                emp.setGender(System.Convert.ToBoolean(dset.Tables["m_employees"].Rows[0]["gender"].ToString()));
                emp.setBirthday(dset.Tables["m_employees"].Rows[0]["birthday"].ToString());

            }
            catch (Exception ex)
            {
                Debug.WriteLine(Convert.ToString(ex));
                return null;
            }
            finally
            {
                this.con.Close();
            }

            return emp;
        }

        public OurCompany getCompany()
        {
            OurCompany oc = new OurCompany();
            this.dset = new DataSet("m_our_company");
            String sql = "select " +
                "   *" +
                " from " +
                "   m_our_company" +
                " where" +
                "   id = 1";
            try
            {
                //SQL接続
                con.Open();
                // データアダプター作成
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, this.con);
                // データ抽出＆取得
                mAdp.Fill(dset, "m_our_company");

                oc.setZipCode(dset.Tables["m_our_company"].Rows[0]["zip_code"].ToString());
                oc.setPhonetic(dset.Tables["m_our_company"].Rows[0]["phonetic"].ToString());
                oc.setName(dset.Tables["m_our_company"].Rows[0]["name"].ToString());
                oc.setAddress(dset.Tables["m_our_company"].Rows[0]["address"].ToString());
                oc.setPhone(dset.Tables["m_our_company"].Rows[0]["phone"].ToString());
                oc.setFax(dset.Tables["m_our_company"].Rows[0]["fax"].ToString());

            }
            catch (Exception ex)
            {
                Debug.WriteLine(Convert.ToString(ex));
                return null;
            }
            finally
            {
                this.con.Close();
            }

            return oc;
        }

    }
}