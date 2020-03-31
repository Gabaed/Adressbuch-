using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Praktiku
{



    public class Datenbankverbindung
    {
        string connectionstring = "Server='localhost'; Database='Adressbuchprogramm'; Uid='root'; pwd='gaba89li'";
        MySqlConnection connection;
        public Datenbankverbindung()
        {
            connection = new MySqlConnection(connectionstring);
        }

        public void FirmaInDatenbankHinzufuegen(string Vorname, int Nachname, string Strasse, string Hausnummer, string Postleitzahl, string Ort, string EMailadresse, string Telefonnummer, string Handynummer, string Anmerkungen)
        {
            MySqlParameter mySqlParameter = new MySqlParameter("Vorname", Vorname);
            MySqlParameter mySqlParameter1 = new MySqlParameter("Nachname", Nachname);
            MySqlParameter mySqlParameter2 = new MySqlParameter("Strasse", Strasse);
            MySqlParameter mySqlParameter3 = new MySqlParameter("Hausnummer", Hausnummer);
            MySqlParameter mySqlParameter4 = new MySqlParameter("Postleitzahl", Postleitzahl);
            MySqlParameter mySqlParameter5 = new MySqlParameter("Ort", Ort);
            MySqlParameter mySqlParameter6 = new MySqlParameter("EMailadresse", EMailadresse);
            MySqlParameter mySqlParameter7 = new MySqlParameter("Telefonnummer", Telefonnummer);
            MySqlParameter mySqlParameter8 = new MySqlParameter("Handynummer", Handynummer);
            MySqlParameter mySqlParameter9 = new MySqlParameter("Anmerkungen", Anmerkungen);
            MySqlCommand query = new MySqlCommand("insert into firma (Vorname,Nachname,Strasse,Hausnummer,Postleitzahl,Ort,EMailadresse,Telefonnummer,Handynummer,Anmerkungen ) values(@Vorname,@Nachname,,@Strasse,@Hausnummer, @Postleitzahl,@Ort,@EMailadresse,@Handynummer,@Anmerkungen)", connection);
            query.Parameters.Add(mySqlParameter);
            query.Parameters.Add(mySqlParameter1);
            query.Parameters.Add(mySqlParameter2);
            query.Parameters.Add(mySqlParameter3);
            query.Parameters.Add(mySqlParameter4);
            query.Parameters.Add(mySqlParameter5);
            query.Parameters.Add(mySqlParameter6);
            query.Parameters.Add(mySqlParameter7);
            query.Parameters.Add(mySqlParameter8);

            try
            {
                connection.Open();
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}