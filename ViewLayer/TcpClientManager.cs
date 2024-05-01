using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    // TcpClientインスタンスの作成およびインスタンスの取得を管理
    internal class TcpClientManager
    {
        private static TcpClient? _client;
        private static readonly object _lock = new object();
        private static string _ipAddress = "127.0.0.1";
        private static int _port = 13000;

        // 1.自分のインスタンスを保持(★privateかつstatic)
        private static TcpClientManager? _instance;

        // 2.コンストラクタをprivate
        private TcpClientManager(){}

        // 3.インスタンス取得のためのプロパティ
        public static TcpClient Instance
        {
            get
            {
                lock (_lock)
                {
                    // 古い接続に関連する潜在的な問題（タイムアウト、途切れがちな接続など）を回避
                    if (_client == null || _client.Connected)
                    {
                        _client?.Close();
                        _client = new TcpClient(_ipAddress, _port);
                    }
                }
                return _client; 
            }
        }
    }
}
