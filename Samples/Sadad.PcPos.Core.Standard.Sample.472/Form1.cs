using System;
using System.Windows.Forms;

namespace Sadad.PcPos.Core.Standard.Sample._472
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            Sadad.PcPos.Standard.SadadPcPosClient client = new Sadad.PcPos.Standard.SadadPcPosClient();
            client.IP = textBox1.Text;
            client.Port = 8888;
            client.ResponseTimeOut = new int[] { 30000, 30000, 30000 };
            client.RetryTimeOut = new int[] { 30000, 30000, 30000 };

            client.Amount = numericUpDown1.Value.ToString();
            var posResult = await client.SaleTransactionAsync();

            textBox2.Text = System.Text.Json.JsonSerializer.Serialize(posResult);
        }
    }
}
