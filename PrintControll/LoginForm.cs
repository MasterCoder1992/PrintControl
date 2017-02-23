using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ServiceProcess;
using System.Management;
using System.IO;

namespace PrintControll
{
    public partial class LoginForm : Form
    {

        NotifyIcon notifyicon1 = null;

        UserList dsUsers = new UserList();
        // TODO Before release, fix the path to a global path or add a posibillity to set a custom location (unsave!)-- prefer a global location (e.g. AppData-Directory)
        string XMLlocation = @"C:\Users\Clemens\Documents\Visual Studio 2015\Projects\PrintControll\PrintControll\PrintControll\bin\Debug\XMLUSERS.xml";
        string Username;
        string Password;
        bool LoginSuccess = false;
        private static string labelUsername;

        //getter for the Username
        public static string LabelUsername
        {get{ return labelUsername; } }

        public LoginForm()
        {
            InitializeComponent();

            //DataTable dTable = dsUsers.Tables["LoginUsers"];
            //DataRow drRows = dTable.NewRow();
            //DataRow drRows1 = dTable.NewRow();
            //DataRow drRow2 = dTable.NewRow();

            //drRows["Username"] = "Administrator";
            //drRows["Password"] = "Welcome2016";
            //drRows1["Username"] = "Clemens";
            //drRows1["Password"] = "Clemens";
            //drRow2["Username"] = "Gurgle";
            //drRow2["Password"] = "Heiße7";

            //dTable.Rows.Add(drRows);
            //dTable.Rows.Add(drRows1);
            //dTable.Rows.Add(drRow2);
            //dTable.WriteXml(XMLlocation);

        }

        /// <summary>
        /// Read Login File
        /// </summary>
        /// <returns></returns>
        private bool readXML()
        {
            try
            {
                dsUsers.ReadXml(XMLlocation);
                return true;
            }
            catch (IOException ioex)
            {
                
                MessageBox.Show(this, "Execption ausgelöst: " + ioex.Message + " ", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ConstraintException x)
            {
                Console.WriteLine("Exception: " + x.Message);
                return false;

            }

        }


        // Handle Click-Event "freischalten"
        private void button1_Click(object sender, EventArgs e)
        {

            readXML();
                
            if (!(textBox1.Text.Equals("")) & !(textBox2.Text.Equals("")))
            {

                for (int i = 0; i < dsUsers.Tables["LoginUsers"].Rows.Count; i++)
                {
                    Username = dsUsers.Tables["LoginUsers"].Rows[i]["Username"].ToString();
                    Password = dsUsers.Tables["LoginUsers"].Rows[i]["Password"].ToString();

                    if (textBox1.Text == Username && textBox2.Text == Password)
                    {
                        labelUsername = textBox1.Text;
                        LoginSuccess = true;

                    }
                }

                if (LoginSuccess)
                {
                    //MessageBox.Show("Des ist der Rucksack Sepp!");
                    this.Hide();
                    new MainWindow().Show(this);
                 
                }
                else
                {

                    MessageBox.Show("Login-Daten sind falsch!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
         }
            else
            {

                MessageBox.Show("Bitte Username und/oder Passwort eingeben!");
            }

        }



        /// <summary>
        ///   Check Spooler State 
        /// true = Service is not running
        /// </summary>

        private bool CheckSpoolerState()
        {
            try
            {
                ServiceController scController = new ServiceController();
                scController.ServiceName = "Spooler";
                scController.MachineName = SystemInformation.ComputerName;
            
                string statusmsg = scController.Status.ToString();

                if (statusmsg.Equals("running"))
                {
                    Console.WriteLine(statusmsg);
                    return false;

                }
                else
                {
                    return true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
               
                
            }

           
            return false;
         
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>

        private void Dispose_Click(object Sender, EventArgs e)
        {
            notifyicon1.Visible = false;
            notifyicon1.Icon = null;
            notifyicon1.Dispose();
            Application.Exit();
        }


        /// <summary>
        /// Handle disabled Printer Spooler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender , EventArgs e)
        {
            // for debugging-reasons only. At the target-system, the spooler service
            //have to disabled by the group policity   
            CheckSpoolerState();
            if (!CheckSpoolerState())
            {
                MainWindow.PrintIt(false);

            }

        }


       
    }
}
