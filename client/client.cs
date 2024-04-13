using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client
{
    public partial class client : Form
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private StreamReader _reader;
        private StreamWriter _writer;

        public client()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                _client = new TcpClient("127.0.0.1", 2010);
                _stream = _client.GetStream();
                _reader = new StreamReader(_stream);
                _writer = new StreamWriter(_stream);

                // Start receiving data from the server in a new thread
                Thread receiveThread = new Thread(ReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server: " + ex.Message);
            }
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    string message = _reader.ReadLine();
                    if (!string.IsNullOrEmpty(message))
                    {
                        DisplayMessage(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu từ server: " + ex.Message);
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => DisplayMessage(message)));
                return;
            }
            txt_Nhan.AppendText(message + Environment.NewLine);
        }

        private void SendMessage(string message)
        {
            try
            {
                _writer.WriteLine(message);
                _writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message);
            }
        }

        private void SendFile(string filePath)
        {
            try
            {
                byte[] fileData = File.ReadAllBytes(filePath);
                _stream.Write(fileData, 0, fileData.Length);
                _stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi file: " + ex.Message);
            }
        }

        private void btn_GuiTinNhan_Click_1(object sender, EventArgs e)
        {
            string message = txt_Gui.Text;
            if (!string.IsNullOrEmpty(message))
            {
                SendMessage(message);
                txt_Gui.Clear();
            }
        }

        private void btn_GuiFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                SendFile(filePath);
            }
        }
        private void SendSystemInfo()
        {
            try
            {
                // Get CPU information
                string cpuInfo = $"CPU: {Environment.ProcessorCount} core(s)";
                SendMessage(cpuInfo);

                // Get RAM information
                PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                float totalMemory = ramCounter.NextValue();
                string ramInfo = $"RAM: {totalMemory} MB";
                SendMessage(ramInfo);

                // Get disk information
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives)
                {
                    if (drive.IsReady)
                    {
                        string diskInfo = $"{drive.Name}: Total space: {drive.TotalSize / (1024 * 1024 * 1024)} GB";
                        SendMessage(diskInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi thông tin hệ thống: " + ex.Message);
            }
        }

        private void btnGuiCauHinh_Click(object sender, EventArgs e)
        {
            // Gửi thông tin cấu hình đến máy chủ
            SendSystemInfo();
        }
        private void ListenForServerMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = _client.GetStream().Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        // Xử lý dữ liệu nhận được từ server
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (message == "disconnect_request")
                        {
                            // Thực hiện đóng kết nối
                            DisconnectFromServer();
                            break;
                        }
                        else
                        {
                            // Xử lý các tin nhắn khác từ server
                            // Ví dụ: hiển thị trên giao diện người dùng
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi nhận dữ liệu từ server
            }
        }

        private void DisconnectFromServer()
        {   
            try
            {
                // Đóng kết nối với server
                _client.Close();
                // Đóng ứng dụng
                Environment.Exit(0); // 0 là mã thoát mặc định, bạn có thể thay đổi nếu cần
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần thiết
                MessageBox.Show("Lỗi khi đóng kết nối hoặc ứng dụng: " + ex.Message);
            }
        }





    }
}
