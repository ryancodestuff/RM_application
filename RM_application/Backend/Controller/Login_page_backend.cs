using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using RM_application.Backend;
using RM_application.Front_End.View;

namespace RM_application.Backend.Controller
{
    class Login_page_backend
    {

        public static void findUser( String email, String password)
        {
            Login_page instance = new Login_page();
          
            Client_page allClients = new Client_page();
           



            Connection con = Connection.getDBConnection();
            DataSet result = con.getDataSet("SELECT Count(*) FROM RM_tbl WHERE email='" + email + "'AND password = '" + password + "'");

            if (result.Tables[0].Rows[0][0].Equals(1))
            {

                instance.Hide();
                MessageBox.Show("Login page is working");
                //for testing purposes
                // DataSet user = con.getDataSet("SELECT * FROM rm_data WHERE email'" + email + "'");

                //get the first name and last name of the user where entered email text is equal to email
               
                allClients.Show();

                /*
                 * Until the homepage is made/functioning, it will directly load to the 
                 * 'All Clients page' -GJ
                 */
            }
            else
            {
                MessageBox.Show("email or password is incorrect");
            }
            

        }
    }
}
