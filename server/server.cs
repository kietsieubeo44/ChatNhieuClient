using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class server : Form
    {
        private TcpListener _server;
        private List<TcpClient> _clients = new List<TcpClient>();

        public server()
        {
            InitializeComponent();
            StartServer();
        }

        private void StartServer()
        {
            try
            {
                _server = new TcpListener(IPAddress.Any, 2010);
                _server.Start();

                // Hiển thị thông báo khi máy chủ đã khởi động thành công
                AppendMessage("Server đã khởi động.");

                // Bắt đầu lắng nghe kết nối từ client
                Thread listenThread = new Thread(ListenForClients);
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi động server: " + ex.Message);
            }
        }

        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = _server.AcceptTcpClient();
                    _clients.Add(client);

                    // Bắt đầu lắng nghe tin nhắn từ client mới
                    Thread receiveThread = new Thread(() => ReceiveData(client));
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReceiveData(TcpClient client)
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        // Xử lý dữ liệu nhận được từ client
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        // Hiển thị tin nhắn trên giao diện máy chủ
                        AppendMessage(message);

                        // Gửi tin nhắn tới tất cả client kết nối
                        SendToAllClients(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                _clients.Remove(client);
                client.Close();
            }
        }

        private void SendToAllClients(string message)
        {
            foreach (TcpClient client in _clients)
            {
                if (client.Connected)
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    client.GetStream().Write(data, 0, data.Length);
                }
            }
        }

        private void SendFileToClient(TcpClient client, string filePath)
        {
            if (client.Connected)
            {
                try
                {
                    // Đọc dữ liệu từ file
                    byte[] fileData = File.ReadAllBytes(filePath);

                    // Gửi kích thước file trước tiên
                    byte[] fileSize = BitConverter.GetBytes(fileData.Length);
                    client.GetStream().Write(fileSize, 0, fileSize.Length);

                    // Gửi dữ liệu file
                    client.GetStream().Write(fileData, 0, fileData.Length);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error sending file: " + ex.Message);
                }
            }
        }

        private void AppendMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AppendMessage(message)));
                return;
            }
            txt_TinNhan.AppendText(message + Environment.NewLine);
        }

        private void btn_GuiTinNhan_Click(object sender, EventArgs e)
        {
            string message = txt_NhapTinNhan.Text;
            SendToAllClients(message);
            txt_NhapTinNhan.Clear();
        }

        private void btn_GuiFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                // Gửi file cho từng client kết nối
                foreach (TcpClient client in _clients)
                {
                    SendFileToClient(client, filePath);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Các sự kiện và phương thức khác cần được triển khai

    }
}
