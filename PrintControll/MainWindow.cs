using System;
using System.Windows.Forms;
using System.Management;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Collections;
using System.Drawing.Printing;
using System.Threading;

namespace PrintControll
{


    public partial class MainWindow : Form
    {
        // TODO Clear all unneeded code
        // PrintQueueMonitor pqm = null;
        public DataOverview data = new DataOverview();
        LoginForm lgForm = new LoginForm();

        //Background background = new Background();


        public MainWindow()
        {
            InitializeComponent();
            lbCurrentUser.Text = "Aktueller Benutzer: " + LoginForm.LabelUsername;


        }
        /// <summary>
        /// Convert method for bools
        /// recognize the "Running"-strings from the Service State
        /// </summary>
        /// <param name="stringToBool"></param>
        /// <returns>bool:</returns>
        private static bool convertStringToBool(string stringToBool)
        {
            bool convertedString = false;

            stringToBool = stringToBool.ToLower();

            if (stringToBool.Equals("running"))
            {
                convertedString = true;
            }
            else if (stringToBool.Equals("stopped"))
            {
                convertedString = false;
            }
            else if (stringToBool.Equals("true"))
            {
                convertedString = true;
            }
            else if (stringToBool.Equals("false"))
            {
                convertedString = false;
            }

            return convertedString;

        }
        /// <summary>
        /// Button : Open DataView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            new DataOverview().Show(this);
        }

        /// <summary>
        /// activate the Printers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActivePrinter_Click(object sender, EventArgs e)
        {
            PrintIt(true);

            lbPrintServiceRunningState.Text = "Drucker freigeschaltet";
            
            recordprintJobs(true);
        }
        
     


        /// <summary>
        /// recordprintjobs. capture printjobs. 
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>

        private bool recordprintJobs(bool fini)
        {
            bool finished = false;
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerAsync();



          
            return finished;

        }

        


        /// <summary>
        /// ordinary method to stop the spooler service. at the time this method is
        /// not in use! Repalced by the PrintIt(bool)-method!
        /// </summary>
        public static void StopService()
        {
            try
            {
                ServiceController scController = new ServiceController();
                scController.ServiceName = "Spooler";
                scController.MachineName = SystemInformation.ComputerName;
                scController.Stop();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Handle the Start and Stop Service behavoir. 
        /// Start- and Stopmethods are deprecated! 
        /// Use this method instead!
        /// 
        /// </summary>
        /// <param name="startStop">true - start</param>
        /// <param name="startStop">false - stop</param>
        public static void PrintIt(bool startStop)
        {
            try
            {
                ServiceController scController = new ServiceController();
                scController.ServiceName = "Spooler";
                scController.MachineName = SystemInformation.ComputerName;

                convertStringToBool(scController.ToString());

                if (startStop)
                {
                    scController.Start();
                }
                else
                {
                    scController.Stop();
                }

                // Only for debug reasons
                // string sStatus = scController.Status.ToString();
                // MessageBox.Show(sStatus);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// ordinary method to start the spooler service. at the time this method is
        /// not in use! Repalced by the PrintIt()-method!
        /// Use this instead!
        /// </summary>
        private static void StartPrintService()
        {
            try
            {
                ServiceController scController = new ServiceController();
                scController.ServiceName = "Spooler";
                scController.MachineName = SystemInformation.ComputerName;
                scController.Start();
                // Only for debug reasons
                // string sStatus = scController.Status.ToString();
                // MessageBox.Show(sStatus);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }


        // Handle MainWindowClosing Event
        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            PrintIt(false);
            //Application.Exit();
        }

        /// <summary>
        /// btn- deactivate the printer and cancel the worker-thread  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeactivate_Click(object sender, EventArgs e)
        {

            try
            {
                backgroundWorker1.CancelAsync();
                PrintIt(false);
            }
            catch (Exception xs)
            {

                Console.WriteLine(xs.Message);
            }
        }

        private void höhereRechteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginForm.LabelUsername.Equals("admin"))
            {
                groupBox1.Visible = true;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "Dem Benutzer sind keine höheren Rechte erteilt worden!\n Bitte wende Dich an den Systemadministrator!", "Zugriff verweigert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string _Document= "";
        //string _host = null;
        //string _owner = null;
        int _PagesPrint = 0;
        int _Pages = 0;
        /// <summary>
        /// Retrive actually information about the print jobs which are listed at the local spooler
        /// service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //reset the vars 
            _Document = null;
            _PagesPrint = 0;
            _Pages = 0;
               


            backgroundWorker1.WorkerSupportsCancellation = true;
            Thread.Sleep(1);

            while (!backgroundWorker1.CancellationPending)
            {
               

                string searchQuery = "SELECT * FROM Win32_PrintJob";
                ManagementObjectSearcher searchPrintJobs = new ManagementObjectSearcher(searchQuery);

                ManagementObjectCollection prntJobCollection = searchPrintJobs.Get();

                foreach (ManagementObject prntJob in prntJobCollection)

                {
                    try
                    {
                        string document = prntJob.Properties["Document"].Value.ToString();

                        // string color = prntJob.Properties["Color"].Value.ToString();

                        string host = prntJob.Properties["HostPrintQueue"].Value.ToString();

                        string owner = prntJob.Properties["Owner"].Value.ToString();

                        //int id = int.Parse(prntJob.Properties["JobId"].Value.ToString());

                        int pages = int.Parse(prntJob.Properties["TotalPages"].Value.ToString());

                        int pagesPrint = int.Parse(prntJob.Properties["PagesPrinted"].Value.ToString());

                        
                        //Vars for the notification icon.
                        _Document = document;
                        _Pages = pages;
                        _PagesPrint = pagesPrint;
                       

                        //delete numbers
                        // {0]} id
                        //{3} Color
                        Console.WriteLine("Document '{0}', pages {1}, sent by {2}\\{3} - pagesPrint: {4}", document, pages, host, owner, pagesPrint);
           
                    }
                  
                    catch (ManagementException fs)
                    {
                        Console.WriteLine(fs.StackTrace);
                      
                        lgForm.notifyIcon1.ShowBalloonTip(50, "Holla,eine Exeption", fs.StackTrace, ToolTipIcon.Error);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);

                    }


                }

            }

            
            //Show a notifyIcon , which shows the actually print queue ( only the latest print job)
            lgForm.notifyIcon1.ShowBalloonTip(50, "Info zum Druckauftrag", "Dokumentname: " + _Document + "\nSeite(n):" + _Pages + "\n", ToolTipIcon.Info);
            data.addTest(LoginForm.LabelUsername, _Pages, DateTime.Now, _Document);
            data.saveAccessOBject();

        }

        private void cancelActionBtn_Click(object sender, EventArgs e)
        {
            
            backgroundWorker1.CancelAsync();
            lgForm.notifyIcon1.ShowBalloonTip(50, "CancelActionBtn was clicked", "Cancel ", ToolTipIcon.Info);
        }
    }
}

