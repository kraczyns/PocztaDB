using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObslugaPrzesylekPocztowychIKurierskich
{
    public partial class Form1 : Form
    {
        private List<Message> messages;
         
        public Form1()
        {
            InitializeComponent();
            messages = new List<Message>();
        }

        private void addMsgButton_Click(object sender, EventArgs e)
        {
            MessageDesign msgForm = new MessageDesign();
            msgForm.Show();
        }
    }
}
