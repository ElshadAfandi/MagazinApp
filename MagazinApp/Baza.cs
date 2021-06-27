using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace MagazinApp
{
    class Baza
    {
        StreamReader sr;
        string connectionString;        
        public SqlConnection baglanti()
        {
            using (sr=new StreamReader(@"C:\Sqlway.txt"))
           // using (sr = new StreamReader(@"C:\Sqlway3.txt"))
            {
                string setir=sr.ReadLine();
                while (setir!=null)
                {
                    connectionString = setir;
                    setir = sr.ReadLine();                  
                }                 
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        //logintable cedvelinden UserName cagirir Form-larin text hissesin yazmaq ucun
        public SqlDataAdapter Username(string txtLogin)
        {
            string command = "select userName from logintable where login='" + txtLogin + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command, baglanti());
            return sda;
        }
        //logintable cedvelinden login-i cagirir Admin(ve ya diger formlardan) form-dan diger formlara kecmek ucun not visible label-
        //lara yazmaq ucun
        public SqlDataAdapter login(string txtlogin)
        {
            string commandlogin = "select login from logintable where login='"+txtlogin+"'";
            SqlDataAdapter sdalogin = new SqlDataAdapter(commandlogin,baglanti());
            return sdalogin;
        }

        //Edilen deyisikliyi informasiya kimi editinformation-a yazmaq 
        public void EditInformation(string username, string editplace)
        {
            string edtinfo = "Insert into EditInformation values('" + username + "',getdate(),'" + editplace + "')";
            SqlCommand comedt = new SqlCommand(edtinfo,baglanti());
            comedt.ExecuteNonQuery();
        }
        //

        //logintable role
        public SqlDataAdapter loginrole(string cardNumber)
        {
            string command = "select role from logintable where CardIdentity='"+cardNumber+"'";
            SqlDataAdapter sda = new SqlDataAdapter(command,baglanti());
            return sda;
        }
        //
        public SqlDataAdapter Role(string login)
        {
            string command = "select role from logintable where login='"+login+"'";
            SqlDataAdapter sda = new SqlDataAdapter(command,baglanti());
            return sda;
        }
    }
}
