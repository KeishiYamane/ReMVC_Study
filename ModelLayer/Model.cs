using System.Net;
using System.Net.Sockets;

namespace ReMVC_Study
{
    public partial class Model : Form
    {
        private int _port = 13000;
        private IPAddress _iPAddress = IPAddress.Parse("127.0.0.1");
        private TcpListener _server;

        public Model()
        {
            InitializeComponent();

            // 初期設定
            _port = 13000;
            _iPAddress = IPAddress.Parse("127.0.0.1");
            _server  = new TcpListener(_iPAddress, _port);
        }

        private void StartListenerBtn_Click(object sender, EventArgs e)
        {
            // サーバー起動
            try
            {
                _server.Start();
            }
            catch (SocketException ex)
            {
                LogTxtBox_Model.AppendText($"SocketException:{ex}\r\n") ;
            }

            Task.Run(() => 
            {
                try
                {
                    // UI更新
                    Invoke(() => 
                    {
                        LogTxtBox_Model.AppendText("Waiting for a connection... \r\n");
                    });

                    // クライアントの接続処理(AcceptTcpClientのおかげでボタン連打でフリーズするのを回避している)
                    // クライアントの接続をブロッキング（処理を停止して待つ）モードで受け入れ
                    using (TcpClient client = _server.AcceptTcpClient())
                    {

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            
            });

        }
    }
}
