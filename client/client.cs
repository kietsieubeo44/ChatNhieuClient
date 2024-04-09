using System;
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

                // Bắt đầu lắng nghe dữ liệu từ server trong một luồng mới
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

        private void btn_GuiTinNhan_Click(object sender, EventArgs e)
        {
        
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

        private void btn_GuiFile_Click(object sender, EventArgs e)
        {

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
    }
}
