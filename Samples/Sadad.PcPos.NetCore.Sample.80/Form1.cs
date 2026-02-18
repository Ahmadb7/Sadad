using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Sadad.PcPos.NetCore.Sample._80
{
    public partial class Form1 : Form
    {
        private readonly JsonSerializerOptions options = new()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All),
            WriteIndented = true
        };
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Sadad.PcPos.NetCore.SadadPcPosClient client = new Sadad.PcPos.NetCore.SadadPcPosClient(null);
            client.IP = textBox1.Text;
            client.Port = 8888;
            client.ResponseTimeOut = new int[] { 30000, 30000, 30000 };
            client.RetryTimeOut = new int[] { 30000, 30000, 30000 };

            client.Amount = numericUpDown1.Value.ToString();
            var posResult = await client.SaleTransactionAsync();

            textBox2.Text = System.Text.Json.JsonSerializer.Serialize(posResult, options);
        }

        private async void BtnGovSale_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var client = new Sadad.PcPos.NetCore.SadadPcPosClient(null);
            //client.IP = textBox1.Text;
            //client.Port = 8888;
            client.ComPortName = "COM3";
            client.ConnectionType = Enums.PcPosConnectionType.Serial;
            client.ResponseTimeOut = new int[] { 30000, 30000, 30000 };
            client.RetryTimeOut = new int[] { 30000, 30000, 30000 };

            var multiSaleId = new Models.SaleIdProvider();
            decimal sum = 0;
            var tempIds =
                "1,367036974285120158877436912066,100000;" +
                "7,301053274146500002000000000000,200000;";
            foreach (var row in tempIds.Split(';'))
            {
                var items = row.Split(',');
                try
                {

                    var idx = 0;
                    var converted = int.TryParse(items[0], out idx);
                    var iban = converted ? string.Empty : items[0];
                    var saleId = items[1];
                    var amount = decimal.Parse(items[2]);
                    sum += amount;

                    var data = new Models.SaleIdData(idx, iban, saleId, amount, converted ? Enums.RowType.Private : Enums.RowType.PlainIban);

                    multiSaleId.SaleIds.Add(data);
                }
                catch (Exception)
                {

                }
            }
            client.Amount = sum.ToString();

            client.SetMultiSaleId(multiSaleId);
            var posResult = await client.GovernmentIdentifiedInquiryTransactionAsync();
            textBox2.Text = System.Text.Json.JsonSerializer.Serialize(posResult, options);
        }
    }
}
