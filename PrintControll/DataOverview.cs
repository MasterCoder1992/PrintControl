using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace PrintControll
{
    public partial class DataOverview : Form
    {

        public bool clear = false;
        private List<Access> ddd = new List<Access>();
      
        
        public DataOverview()
        {
            InitializeComponent();
            initializeListView();

            //test data
          //  ddd.Add(new Access(LoginForm.LabelUsername, 55, DateTime.Now,"Rock im Schlachthof"));
           // ddd.Add(new Access("Jula", 555, DateTime.Today,"Weihnachtsmarkt"));
           // ddd.Add(new Access("Holla", 23, DateTime.Now,"Jugendwochenende"));
            //ddd.Add(new Access("Holla", 77, DateTime.Now,"Warum?"));
            //ddd.Add(new Access(LoginForm.LabelUsername, 12, DateTime.Now, "Faschingsfeier"));

            displayList();
       
        }


        private void initializeListView()
        {
            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Ascending;

    
            listView1.Columns.Add("Username", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Seiten", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Letzer Druck", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Grund/Aktion", 325, HorizontalAlignment.Left);  
        }
        /// <summary>
        /// DisplayList: Init Listview
        /// If data avialible then will be shown  
        /// </summary>
        /// 
        private void displayList()
        {
            //for (int i = 0; i < ddd.Count; i++)
            //{                
            //    ListViewItem lvi = new ListViewItem(ddd.ElementAt(i).GetUsername());
            //    lvi.SubItems.Add(ddd.ElementAt(i).GetpageCount().ToString());
            //    lvi.SubItems.Add(ddd.ElementAt(i).GetAccesstime().ToString());
            //    lvi.SubItems.Add(ddd.ElementAt(i).GetReason().ToString());
            //    listView1.Items.Add(lvi);
            //}

            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var lizards2 = (List<Access>)bin.Deserialize(stream);
                    ListViewItem lvi = new ListViewItem();

                    for (int i = 0; i < lizards2.Count; i++)
                    {


                        //foreach (Access lizard in lizards2)
                        //{
                        lvi.SubItems.Add(lizards2.ElementAt(i).username);
                        lvi.SubItems.Add(lizards2.ElementAt(i).pagecount.ToString());
                        lvi.SubItems.Add(lizards2.ElementAt(i).accesstime.ToString());
                        lvi.SubItems.Add(lizards2.ElementAt(i).reason);



                        //for (int i = 0; i < ddd.Count; i++)
                        //{
                        //    ListViewItem lvi = new ListViewItem(ddd.ElementAt(i).username);
                        //    lvi.SubItems.Add(ddd.ElementAt(i).pagecount.ToString());
                        //    lvi.SubItems.Add(ddd.ElementAt(i).accesstime.ToString());
                        //    lvi.SubItems.Add(ddd.ElementAt(i).reason);
                        //    listView1.Items.Add(lvi);
                        //}


                        //Console.WriteLine("{0}, {1}, {2}, {3}",
                        //    lizards2.username,
                        //    lizard.accesstime,
                        //    lizard.pagecount,
                        //    lizard.reason);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message); 

            }

        
    }

    /// <summary>
    /// reset button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Visible = true;
            label1.Text = DateTime.Now.ToLocalTime().ToString();
            Properties.Settings.Default["lastReset"] = label1.Text;
            Properties.Settings.Default.Save();
            
        }

        /// <summary> 
        /// Save the access-entries into a list, at the moment TEST
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pagecount"></param>
        /// <param name="accesstime"></param>
        /// <param name="reason"></param>
        public void addTest(string username,int pagecount,DateTime accesstime,string reason)
        {
            
            ddd.Add(new Access(username, pagecount, accesstime,reason));
            //After adding you must save the Entries!!Bitch!
           

          
        }

    
       /// <summary>
       /// First try of serialize 
       /// </summary>
        public void saveAccessOBject()
        {

            try
            {

                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, ddd);
                }
            }
            catch (IOException)
            {

            }

                       
           
            

        }


        private void convertToXML<T>(T o ,string filename)
        {
            string filePath = Environment.CurrentDirectory + filename;

            XmlDocument docXML = new XmlDocument();
            XPathNavigator nav = docXML.CreateNavigator();
            using (XmlWriter writer = nav.AppendChild())
            {
                try {
                    XmlSerializer ser = new XmlSerializer(typeof(T), new XmlRootAttribute("Eintrag"));
                    
                    ser.Serialize(writer, o);

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            File.WriteAllText(filePath, docXML.InnerXml);



        }

        private void standarddruckerAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Einstellungen().Show(this);
        }

        private void datenImcsvFormatExportierenEXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convertToXML<List<Access>>(ddd, "eintrag.xml");
        }

        private void DataOverview_Load(object sender, EventArgs e)
        {
            
            if (!Properties.Settings.Default.lastReset.Equals(""))
            {
                label1.Visible = true;
                label1.Text = Properties.Settings.Default.lastReset.ToString();
            }
        }
    }
}
