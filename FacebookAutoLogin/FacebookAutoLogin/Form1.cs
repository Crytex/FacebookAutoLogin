using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
             
        {
            string username;
            string password;
            username = ("put in username");
            password = ("put in password");




        
     


          Process.Start("https://www.facebook.com");   // OPENS YOUR DEFAULT BROWSER AND NAVIGATES TO FACEBOOK
            System.Threading.Thread.Sleep(5000);      // SLEEPS FOR 5000 MS
            SendKeys.Send(username);                 // SENDS THE USERNAME STRING
            SendKeys.Send ("{TAB}");                // HITS TAB
            System.Threading.Thread.Sleep(5000);   // SLEEPS FOR 5000 MS
            SendKeys.Send(password);              // SENDS THE PASSWORD STRING
            SendKeys.Send("{ENTER}");            // HITS ENTER
            Application.Exit();                 // EXITS THE APPLICATION

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

          


    }
}
