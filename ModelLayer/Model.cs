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

            // �����ݒ�
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

        // �N���C�A���g����̐ڑ����i���I�Ƀ��X�j���O���邽�߂ɁA�������[�v���� _server.AcceptTcpClient() ���Ăяo��
        private void ListenForClients()
        {
            // �g�N���C�A���g�̐ڑ���҂�Ɓh�����C���X���b�h�Ƃ͕ʂ̃X���b�h�Ŕ񓯊��Ɏ��s���邽�߂̃^�X�N
            // UI�̃t���[�Y��������邽�߂̃^�X�N��
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        TcpClient client = _server.AcceptTcpClient();
                        Task.Run(() => HandleClient(client));// �N���C�A���g���ƂɌʂ̃^�X�N�i�X���b�h�j�����蓖�Ăĕ���ɏ������邽�߂̃^�X�N�B�����̃N���C�A���g�𓯎��Ɍ����I�Ɉ������Ƃ��\�B�Ⴆ�΁A����N���C�A���g���f�[�^�̓ǂݏ����Ŏ��Ԃ������鏈�������Ă��Ă��A���̃N���C�A���g�̏����ɂ͉e����^���Ȃ�
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
            // ���ꂾ���ŗǂ�
            // Invoke(() => LogTxtBox_Model.AppendText(message));

            // ���C���X���b�h(UI�X���b�h)���ǂ����`�F�b�N�������ꍇ�͉��L�̂悤�ɏ���
            // InvokeRequired�v���p�e�B���m�F���A���݂̃X���b�h��UI�X���b�h�ł��邩�ǂ������`�F�b�N
            if (LogTxtBox_Model.InvokeRequired)
            {
                // UI�X���b�h�łȂ��ꍇ�́AInvoke���g����UI�X���b�h��ňȉ��̓������\�b�h�����s
                LogTxtBox_Model.Invoke((MethodInvoker)(() =>
                {
                    LogTxtBox_Model.AppendText(message);
                }));
            }
            else
            {
                // ����UI�X���b�h�̏ꍇ�͒��ڌĂяo��
                LogTxtBox_Model.AppendText(message);
            }
        }
    }
}
