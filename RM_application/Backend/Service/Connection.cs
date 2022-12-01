using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RM_application.Backend
{
    class Connection
    {
        private static Connection conInstance;
        private static string conString;
        private static SqlConnection conToDB;

        private Connection()
        {
            conString = Properties.Settings.Default.ConnectionString;

        }

        public static string ConString { get => conString; set => conString = value; }
        internal static Connection ConInstance { get => conInstance; set => conInstance = value; }
        public SqlConnection ConToDB { get => conToDB; set => conToDB = value; }

        public static Connection getDBConnection()
        {
            if (conInstance == null)
                conInstance = new Connection();
            return conInstance;
        }

        public DataSet getDataSet(string query)

        {

            //This is required to retrieve data from the database - GJ

            DataSet dataSet = new DataSet();

            using (conToDB = new SqlConnection(conString))
            {
                conToDB.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, conToDB);
                adapter.Fill(dataSet);
                conToDB.Close();
            }
            return dataSet;

        }


        public static void saveOrUpdateData(string query)
        {
            /*
            *  To save or update data in our database we need a similar function to getDataSet
            *  that does not return a dataset. This method will accept queries from various service
            *  classes. - GJ
            */
            using (conToDB = new SqlConnection(conString))
            {

                conToDB.Open();

                SqlCommand cmd = new SqlCommand(query, conToDB);
                cmd.ExecuteNonQuery();
                conToDB.Close();


            }
        }
    }
}
