using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace PrintControll
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
            // putAllInside();
            READSERV();
        }
        




        private void READSERV()
        {
            string query = "*[System/Provider/@Name=\"Microsoft-Windows-PrintService/Operational\"]";

            //  string query = "*[System/EventID=903]";
            EventLogQuery eventsQuery = new EventLogQuery("Application", PathType.LogName, query);

            try
            {
                EventLogReader logReader = new EventLogReader(eventsQuery);

                for (EventRecord eventdetail = logReader.ReadEvent(); eventdetail != null; eventdetail = logReader.ReadEvent())
                {
                    Console.WriteLine(eventdetail);
                }
            }
            catch (EventLogNotFoundException e)
            {
                Console.WriteLine("Error while reading the event logs \n"+e.StackTrace);
                return;
            }

            //EventLog log = new EventLog("Application", ".");

            //foreach (EventLogEntry eintrag in log.Entries)
            //{
            //    listBox1.Items.Add(eintrag.InstanceId + "," + eintrag.Message);
            ////    Console.WriteLine(eintrag.InstanceId +", "+eintrag.Message);



            //}



            //     for (Int32 i = 0; i < log.Entries.Count - 1; i++)
            //   {
            ////      listBox1.Items.Add(log.Entries[i].Message.ToString());
            //     Console.WriteLine(log.Entries[i].InstanceId);
            // }
        }
  




        private void putAllInside()
        {

            try
            {
                foreach (string Name in PrinterSettings.InstalledPrinters)
                {
                    listBox1.Items.Add(Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Tipp: Dienst \"Druckerwarteschlange\" läuft nicht ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default["StandardPrinter"] = listBox1.SelectedItem;
         //   Properties.Settings.Default.Save();
         //   Console.WriteLine("Properties changed! NEW VALUE: " + listBox1.SelectedItem);
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {

        }
    }
}
