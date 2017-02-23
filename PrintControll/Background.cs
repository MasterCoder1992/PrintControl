using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrintControll
{
    class Background
    {


        LoginForm lgForm = new LoginForm();

        /// <summary>
        /// Get every PrintJobs on the printer-query
        /// 
        /// </summary>

        public void GetPrintJobs()
        {
            Monitor.Enter(this);
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

     
                
                    //delete numbers
                    // {0]} id
                    //{3} Color
                    Console.WriteLine("Document '{0}', pages {1}, sent by {2}\\{3} - pagesPrint: {4}", document, pages, host, owner,pagesPrint);
                    
                    

                    //Show a notifyIcon , which shows the actually print queue
                    lgForm.notifyIcon1.ShowBalloonTip(100, "Info zum Druckauftrag", "Dokumentname: "+document+"\nSeite(n):"+pages+"\n", System.Windows.Forms.ToolTipIcon.Info);
                  //  MainWindow.data.addTest(LoginForm.LabelUsername, pages, DateTime.Now, document);


                         
                   

                   

                }catch (Exception ex) {
                    Console.WriteLine("Exception getting print jobs: " + ex);
                    

                }

            }
            Monitor.Exit(this);
           
           
        }



     



    }
}
