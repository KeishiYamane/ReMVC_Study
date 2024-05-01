using System.Net.Sockets;
using System.Text;
using ViewLayer;

namespace View
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            TcpClient client = TcpClientManager.Instance;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            TcpClient client = TcpClientManager.Instance;
            var message = "Test Message!";
            Byte[] data = Encoding.ASCII.GetBytes(message);
            NetworkStream Stream = client.GetStream();
            Stream.Write(data, 0, data.Length);

            LogTxtBox_View.AppendText($"Send: {message} \r\n");
        }
    }
}
