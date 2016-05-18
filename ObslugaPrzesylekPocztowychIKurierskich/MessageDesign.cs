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
    public partial class MessageDesign : Form
    {
        public MessageDesign()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Message newMessage = new Message(new Person(senderName.Text, senderSurname.Text, address.Text), 
                new Person(recipientName.Text, recipientSurname.Text, recipientAddress.Text), 
                (double)cost.Text, size, status, dateSend.Text, dateReceive.Text, priority.Checked, paymentLater.Checked, msng);
        }
    }
}
