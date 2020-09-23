using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace RestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //http://dry-cliffs-19849.herokuapp.com/users/4.json

            RestClient rClient = new RestClient();
            rClient.endPoint = textRestValueUrl.Text;
            debugOutput($"Rest Client Created");


            string strRespons = rClient.makeRequest();

            debugOutput(strRespons);





        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                TextResponse.Text = TextResponse.Text + strDebugText + Environment.NewLine;
                TextResponse.SelectionStart = TextResponse.TextLength;
                TextResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
