using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace RM_application.Backend.Controller
{
    class Login_page_backend
    {

        public static void findUser( String email, String password)
        {
            Connection con = Connection.getDBConnection();
            DataSet result = con.getDataSet("SELECT Count(*) FROM rm_tbl WHERE email='" + email + "'AND password = '" + password + "'");


            if (result.Tables[0].Rows[0][0].Equals(1))
            {

                MessageBox.Show("Login page is working");

            }
            else
            {
                MessageBox.Show("email or password is incorrect");
            }

        }
    }
}
