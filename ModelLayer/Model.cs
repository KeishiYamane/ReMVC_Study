using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ReMVC_Study
{
    public partial class Model : Form
    {
        private int _port = 13000;
        private IPAddress _iPAddress;
        private TcpListener _server;

        public Model()
        {
            InitializeComponent();

            // 初期設定
            _port = 13000;
            _iPAddress = IPAddress.Parse("127.0.0.1");
            _server = new TcpListener(_iPAddress, _port);
        }

        private void StartListenerBtn_Click(object sender, EventArgs e)
        {
            StartServer();
            ListenForClients();
        }

        private void StartServer()
        {
            try
            {
                _server.Start();
                AppendTextToLog("Server started.\r\nWaiting for a connection... \r\n");
            }
            catch (SocketException ex)
            {
                AppendTextToLog($"SocketException: {ex.Message}\r\n");
            }
        }

        // クライアントからの接続を永続的にリスニングするために、無限ループ内で _server.AcceptTcpClient() を呼び出し
        private void ListenForClients()
        {
            // “クライアントの接続を待つ作業”をメインスレッドとは別のスレッドで非同期に実行するためのタスク
            // UIのフリーズを回避するためのタスク化
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        TcpClient client = _server.AcceptTcpClient();
                        Task.Run(() => HandleClient(client));// クライアントごとに個別のタスク（スレッド）を割り当てて並列に処理するためのタスク。複数のクライアントを同時に効率的に扱うことが可能。例えば、あるクライアントがデータの読み書きで時間がかかる処理をしていても、他のクライアントの処理には影響を与えない
                    }
                }
                catch (Exception ex)
                {
                    AppendTextToLog($"Exception: {ex.Message}\r\n");
                }
            });
        }


        private void HandleClient(TcpClient client)
        {
            try
            {
                AppendTextToLog("Client connected. \r\n");
                using (client)
                {
                    NetworkStream stream = client.GetStream();
                    ReadDataFromStream(stream);
                }
            }
            catch (Exception ex)
            {
                AppendTextToLog($"Client handling exception: {ex.Message}\r\n");
            }
        }

        private void ReadDataFromStream(NetworkStream stream)
        {
            byte[] bytes = new byte[256];
            int bytesRead;

            while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                string dataReceived = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                AppendTextToLog($"Received: {dataReceived}\r\n");
            }
        }

        private void AppendTextToLog(string message)
        {
            // これだけで良い
            // Invoke(() => LogTxtBox_Model.AppendText(message));

            // メインスレッド(UIスレッド)かどうかチェックしたい場合は下記のように書く
            // InvokeRequiredプロパティを確認し、現在のスレッドがUIスレッドであるかどうかをチェック
            if (LogTxtBox_Model.InvokeRequired)
            {
                // UIスレッドでない場合は、Invokeを使ってUIスレッド上で以下の匿名メソッドを実行
                LogTxtBox_Model.Invoke((MethodInvoker)(() =>
                {
                    LogTxtBox_Model.AppendText(message);
                }));
            }
            else
            {
                // 既にUIスレッドの場合は直接呼び出し
                LogTxtBox_Model.AppendText(message);
            }
        }
    }
}
