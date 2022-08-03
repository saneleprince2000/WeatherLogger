using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Timers;
using System.Threading;
using Timer = System.Timers.Timer;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;


namespace WeatherLogger
{
    public partial class LoggerApplication : Form
    {
        
        MySqlConnection con=new MySqlConnection("server=localhost; userid=root; password=; database=wldb.mdf");
        /*bool on = true;
       bool toggleLight = true;
       Timer t = new Timer();*/

        DataTable table = new DataTable("tbl");
        void SetTimer(int a)
        {
            /*_timer = new Timer(1000000);
            _timer.Elapsed += TimerOnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;*/

            /*int mydelay = 2000;
            Thread.Sleep(mydelay);*/
            //yield return new WaitForSecods(0f);
            int add = 0;
            int time;
            int i;
            time = a * 100000000;
            for (i = 0; i < time; i++)
            {
                add *= i;
                add++;
                add++;
            }

        }
        //Logger thread function

        private static void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {

            //throw new NotImplementedException("{e.SignalTime}");
        }

        public LoggerApplication()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = "3991";
                dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                dataGridView1.Rows[0].Cells[2].Value = "20.9";
                dataGridView1.Rows[0].Cells[3].Value = "50.9";
                dataGridView1.Rows[0].Cells[4].Value = "1029.5";
                
            
                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = "3990";
                dataGridView1.Rows[1].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                dataGridView1.Rows[1].Cells[2].Value = "20.9";
                dataGridView1.Rows[1].Cells[3].Value = "60.1";
                dataGridView1.Rows[1].Cells[4].Value = "1029.7";
                



            this.dataGridView1.DataBindings.Clear();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "3989";
            dataGridView1.Rows[2].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            dataGridView1.Rows[2].Cells[2].Value = "20.7";
            dataGridView1.Rows[2].Cells[3].Value = "60";
            dataGridView1.Rows[2].Cells[4].Value = "1029.7";
          
            
            dataGridView1.Rows.Add();
           dataGridView1.Rows[3].Cells[0].Value = "3988";
           dataGridView1.Rows[3].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[3].Cells[2].Value = "20.7";
           dataGridView1.Rows[3].Cells[3].Value = "60.4";
           dataGridView1.Rows[3].Cells[4].Value = "1029.9";

          dataGridView1.Rows.Add();
           dataGridView1.Rows[4].Cells[0].Value = "3987";
           dataGridView1.Rows[4].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[4].Cells[2].Value = "20.6";
           dataGridView1.Rows[4].Cells[3].Value = "60.1";
           dataGridView1.Rows[4].Cells[4].Value = "1030.1";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[5].Cells[0].Value = "3986";
           dataGridView1.Rows[5].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[5].Cells[2].Value = "20.7";
           dataGridView1.Rows[5].Cells[3].Value = "60";
           dataGridView1.Rows[5].Cells[4].Value = "1030.2";



           dataGridView1.Rows.Add();
           dataGridView1.Rows[6].Cells[0].Value = "3985";
           dataGridView1.Rows[6].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[6].Cells[2].Value = "20.9";
           dataGridView1.Rows[6].Cells[3].Value = "50.9";
           dataGridView1.Rows[6].Cells[4].Value = "1029.5";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[7].Cells[0].Value = "3984";
           dataGridView1.Rows[7].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[7].Cells[2].Value = "20.4";
           dataGridView1.Rows[7].Cells[3].Value = "60.1";
           dataGridView1.Rows[7].Cells[4].Value = "1030.3";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[8].Cells[0].Value = "3983";
           dataGridView1.Rows[8].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[8].Cells[2].Value = "20.1";
           dataGridView1.Rows[8].Cells[3].Value = "60.6";
           dataGridView1.Rows[8].Cells[4].Value = "1030.5";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[9].Cells[0].Value = "3982";
           dataGridView1.Rows[9].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[9].Cells[2].Value = "20";
           dataGridView1.Rows[9].Cells[3].Value = "60.6";
           dataGridView1.Rows[9].Cells[4].Value = "1030.7";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[10].Cells[0].Value = "3981";
           dataGridView1.Rows[10].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[10].Cells[2].Value = "19.9";
           dataGridView1.Rows[10].Cells[3].Value = "60.7";
           dataGridView1.Rows[10].Cells[4].Value = "1030.7";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[11].Cells[0].Value = "3980";
           dataGridView1.Rows[11].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[11].Cells[2].Value = "19.9";
           dataGridView1.Rows[11].Cells[3].Value = "60.6";
           dataGridView1.Rows[11].Cells[4].Value = "1030.7";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[12].Cells[0].Value = "3979";
           dataGridView1.Rows[12].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[12].Cells[2].Value = "19.8";
           dataGridView1.Rows[12].Cells[3].Value = "60.6";
           dataGridView1.Rows[12].Cells[4].Value = "1030.8";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[13].Cells[0].Value = "3978";
           dataGridView1.Rows[13].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[13].Cells[2].Value = "19.6";
           dataGridView1.Rows[13].Cells[3].Value = "60.7";
           dataGridView1.Rows[13].Cells[4].Value = "1030.9";


          for (int j = 0; j < 7; j++)
            {
                string message = "LOW TEMPERETURE DETECTED";
                string title = "WARNING";
                MessageBox.Show(message, title);
                button3.BackColor = Color.Yellow;
                Console.Beep();
                
            }
            button3.BackColor = SystemColors.ButtonFace;

            dataGridView1.Rows.Add();
           dataGridView1.Rows[14].Cells[0].Value = "3977";
           dataGridView1.Rows[14].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[14].Cells[2].Value = "19.7";
           dataGridView1.Rows[14].Cells[3].Value = "61";
           dataGridView1.Rows[14].Cells[4].Value = "1030.8";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[15].Cells[0].Value = "3976";
           dataGridView1.Rows[15].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[15].Cells[2].Value = "19.7";
           dataGridView1.Rows[15].Cells[3].Value = "61";
           dataGridView1.Rows[15].Cells[4].Value = "1030.8";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[16].Cells[0].Value = "3975";
           dataGridView1.Rows[16].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[16].Cells[2].Value = "19.7";
           dataGridView1.Rows[16].Cells[3].Value = "60.8";
           dataGridView1.Rows[16].Cells[4].Value = "1030.7";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[17].Cells[0].Value = "3974";
           dataGridView1.Rows[17].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[17].Cells[2].Value = "19.8";
           dataGridView1.Rows[17].Cells[3].Value = "61.2";
           dataGridView1.Rows[17].Cells[4].Value = "1030.7";



           dataGridView1.Rows.Add();
           dataGridView1.Rows[18].Cells[0].Value = "3973";
           dataGridView1.Rows[18].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[18].Cells[2].Value = "20.6";
           dataGridView1.Rows[18].Cells[3].Value = "61";
           dataGridView1.Rows[18].Cells[4].Value = "1030.6";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[19].Cells[0].Value = "3972";
           dataGridView1.Rows[19].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[19].Cells[2].Value = "21.1";
           dataGridView1.Rows[19].Cells[3].Value = "61.2";
           dataGridView1.Rows[19].Cells[4].Value = "1030.6";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[20].Cells[0].Value = "3971";
           dataGridView1.Rows[20].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[20].Cells[2].Value = "21.7";
           dataGridView1.Rows[20].Cells[3].Value = "61.6";
           dataGridView1.Rows[20].Cells[4].Value = "1030.7";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[21].Cells[0].Value = "3970";
           dataGridView1.Rows[21].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[21].Cells[2].Value = "22";
           dataGridView1.Rows[21].Cells[3].Value = "60.2";
           dataGridView1.Rows[21].Cells[4].Value = "1030.5";

           dataGridView1.Rows.Add();
           dataGridView1.Rows[22].Cells[0].Value = "3969";
           dataGridView1.Rows[22].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[22].Cells[2].Value = "22.5";
           string m = (string)dataGridView1.Rows[22].Cells[2].Value;
           dataGridView1.Rows[22].Cells[3].Value = "60.3";
           dataGridView1.Rows[22].Cells[4].Value = "1030.5";

            for (int j = 0; j < 7; j++)
            {
                string message = "HIGH TEMPERETURE DETECTED";
                string title = "WARNING";
                MessageBox.Show(message, title);
                button3.BackColor = Color.Red;
                Console.Beep();

            }
            button3.BackColor = SystemColors.ButtonFace;

            dataGridView1.Rows.Add();
           dataGridView1.Rows[23].Cells[0].Value = "3968";
           dataGridView1.Rows[23].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
           dataGridView1.Rows[23].Cells[2].Value = "22";
           dataGridView1.Rows[23].Cells[3].Value = "60.3";
           dataGridView1.Rows[23].Cells[4].Value = "1030.5";



            //database connection

            /*DataSet ds = new DataSet();

             ds.ReadXml(@"C:\Users\Student\source\repos\WeatherLogger\WeatherLogger\DataSet.xml");
             dataGridView1.DataSource = ds.Tables[0];*/

            /*  try
              {
                  MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root; password=");
                  MySqlDataAdapter ad = new MySqlDataAdapter("SELECT *FROM wldb", con);
                  //ad.Fill(ds, "wldb");
                  con.Open();


                  con.Close();


              } catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
            /*

            
            
            string insertQuery = "INSERT INTO *dbo.table(ID,Temperature,Humidity,Pressure) VALUES('" +3990+ "')";
            //con.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, con);
            try
            {
                con.Open();
                string message = "Data successfully uploaded";
                MessageBox.Show(message);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


















            /*string[] lines = File.ReadAllLines(@"C:\Users\Student\Documents\data.xlsx");
            string[] values;

            for(int i=0; i< lines.Length; i++) {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for(int j=0; j<values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }

             /*List<String> ID_s = new List<String>();
             List<String> Time_s = new List<String>();
             List<String> Temperature_s  = new List<String>();
             List<String> Humidity_s = new List<String>();
             List<String> Pressure_s = new List<String>();
             WebClient web = new WebClient();
             String html = web.DownloadString("https://www.ecobliss.co.za/");
             MatchCollection m1 = Regex.Matches(html, @"<strong>\s*(.+?)\s*</strong>", RegexOptions.Singleline);

             foreach(Match m in m1)
             {

                     String ID = m.Groups[1].Value;
                     ID_s.Add(ID);



             }
             dataGridView1.DataSource = ID_s;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            while (i == 0)
                if (textBox1.Text == "3991")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3991";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.9";
                    dataGridView1.Rows[0].Cells[3].Value = "50.9";
                    dataGridView1.Rows[0].Cells[4].Value = "1029.5";
                    break;
                }

                else if (textBox1.Text == "3990")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3990";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.9";
                    dataGridView1.Rows[0].Cells[3].Value = "60.1";
                    dataGridView1.Rows[0].Cells[4].Value = "1029.7";
                    break;
                }

                else if (textBox1.Text == "3989")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3989";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.7";
                    dataGridView1.Rows[0].Cells[3].Value = "60";
                    dataGridView1.Rows[0].Cells[4].Value = "1029.7";
                    break;
                }

                else if (textBox1.Text == "3988")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3988";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.7";
                    dataGridView1.Rows[0].Cells[3].Value = "60.4";
                    dataGridView1.Rows[0].Cells[4].Value = "1029.9";
                    break;
                }

                else if (textBox1.Text == "3987")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3987";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.6";
                    dataGridView1.Rows[0].Cells[3].Value = "60.1";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.1";
                    break;
                }
                else if (textBox1.Text == "3986")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3986";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.7";
                    dataGridView1.Rows[0].Cells[3].Value = "60";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.2";
                    break;
                }

                else if (textBox1.Text == "3985")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3985";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.9";
                    dataGridView1.Rows[0].Cells[3].Value = "50.9";
                    dataGridView1.Rows[0].Cells[4].Value = "1029.5";
                    break;
                }

                else if (textBox1.Text == "3984")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3984";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.4";
                    dataGridView1.Rows[0].Cells[3].Value = "60.1";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.3";
                    break;
                }
                else if (textBox1.Text == "3983")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3983";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.1";
                    dataGridView1.Rows[0].Cells[3].Value = "60.6";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.5";
                    break;
                }
                else if (textBox1.Text == "3982")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3982";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20";
                    dataGridView1.Rows[0].Cells[3].Value = "60.6";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;
                }

                else if (textBox1.Text == "3981")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3981";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.9";
                    dataGridView1.Rows[0].Cells[3].Value = "60.7";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;
                }
                else if (textBox1.Text == "3980")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3980";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.9";
                    dataGridView1.Rows[0].Cells[3].Value = "60.6";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;
                }
                else if (textBox1.Text == "3979")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3979";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.8";
                    dataGridView1.Rows[0].Cells[3].Value = "60.6";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.8";
                    break;
                }

                else if (textBox1.Text == "3978")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3978";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.6";
                    dataGridView1.Rows[0].Cells[3].Value = "60.7";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.9";
                    break;
                }
                else if (textBox1.Text == "3977")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3977";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.7";
                    dataGridView1.Rows[0].Cells[3].Value = "61";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.8";
                    break;
                }

                else if (textBox1.Text == "3976")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3976";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.7";
                    dataGridView1.Rows[0].Cells[3].Value = "61";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.8";
                    break;
                }
                else if (textBox1.Text == "3975")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3975";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.7";
                    dataGridView1.Rows[0].Cells[3].Value = "60.8";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;
                }
                else if (textBox1.Text == "3974")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3974";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "19.8";
                    dataGridView1.Rows[0].Cells[3].Value = "61.2";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;

                }
                else if (textBox1.Text == "3973")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3973";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "20.6";
                    dataGridView1.Rows[0].Cells[3].Value = "61";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.6";
                    break;
                }

                else if (textBox1.Text == "3972")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3972";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "21.1";
                    dataGridView1.Rows[0].Cells[3].Value = "61.2";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.6";
                    break;
                }
                else if (textBox1.Text == "3971")
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3971";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "21.7";
                    dataGridView1.Rows[0].Cells[3].Value = "61.6";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.7";
                    break;
                }
                else if (textBox1.Text == "3970")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3970";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "22";
                    dataGridView1.Rows[0].Cells[3].Value = "60.2";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.5";
                    break;
                }
                else if (textBox1.Text == "3969")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3969";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "22.5";
                    dataGridView1.Rows[0].Cells[3].Value = "60.3";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.5";
                    break;
                }
                else if (textBox1.Text == "3968")
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "3968";
                    dataGridView1.Rows[0].Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    dataGridView1.Rows[0].Cells[2].Value = "22";
                    dataGridView1.Rows[0].Cells[3].Value = "60.3";
                    dataGridView1.Rows[0].Cells[4].Value = "1030.5";
                    break;
                }
                else
                {
                    string message = "INCORRECT ID RECEIVED";
                    string title = "ID";
                    MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Abort)
                    {
                        this.Close();
                    }
                    if(result == DialogResult.Retry) {
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        
                    }

                }
        }
        
         private void textBox1_Enter(object sender, EventArgs e)
         {
             if(textBox1.Text=="Enter ID")
             {
                 textBox1.Text = "";
                 textBox1.ForeColor = Color.Black;
             }
         }

         private void textBox1_Leave(object sender, EventArgs e)
         {
             if (textBox1.Text == "")
             {
                 textBox1.Text = "Enter ID";
                 textBox1.ForeColor = Color.Silver;
             }

         }
         /*DataTable table1 = new DataTable();
         DataTable table2 = new DataTable();*/
            private void LoggerApplication_Load(object sender, EventArgs e)
        {
           /* t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);*/
            /*table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Time", typeof(String));
            table.Columns.Add("Temperature", typeof(String));
            table.Columns.Add("Humidity", typeof(String));
            table.Columns.Add("Pressure", typeof(String));
            dataGridView1.DataSource = table;*/

           // dataGridView1.Columns.DefaultCellStyle.Format = "dd/MM/yyyy";

            timer1.Start();
            
        }
        private void t_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           

            //var hucre = dataGridView1.CurrentCell;
                //var hucre_loc = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            //toolTip1.Show("//Info&" + e.ColumnIndex.ToString() + "&" + e.RowIndex.ToString(), dataGridView1, hucre_loc.X, hucre_loc.Y);

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void datagridview1_rowenter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_BackColorChanged(object sender, EventArgs e)

        {
            
          


            }

        }
    }

