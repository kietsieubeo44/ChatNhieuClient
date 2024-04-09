<h2>1) Nếu lập trình như hướng dẫn trên thì khi ta tắt client có lỗi xảy ra không? Nếu lỗi xảy ra
thì lý do tại sao bị lỗi. Hãy đề xuất cách khắc phục và sửa lại code</h2>

<h5>Khi tắt client, có thể xảy ra lỗi vì server vẫn đang cố gắng gửi dữ liệu tới client đã tắt. Để khắc phục điều này, ta cần kiểm tra trạng thái kết nối của client trước khi gửi dữ liệu tới nó. Dưới đây là một cách sửa code ngắn gọn:
</h5>
private void SendToAllClients(string message)
{
    foreach (TcpClient client in _clients.ToList())
    {
        if (client.Connected)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            client.GetStream().Write(data, 0, data.Length);
        }
        else
        {
            _clients.Remove(client);
        }
    }
}


