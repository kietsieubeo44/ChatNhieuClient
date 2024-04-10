
Trong mẫu README.md này, phần "Code Explanation" giải thích về phương thức `SendToAllClients` trong đoạn mã. Mã được bao bọc bởi một khối mã, và cú pháp markdown được sử dụng để định dạng mã.

```csharp
private void SendToAllClients(string message)
{
    foreach (TcpClient client in _clients.ToList())
    {
        if (client.Connected)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                client.GetStream().Write(data, 0, data.Length);
            }
            catch (IOException)
            {
                // Error occurred while sending data to client, remove client from list
                _clients.Remove(client);
            }
        }
        else
        {
            // Client has disconnected, remove client from list
            _clients.Remove(client);
        }
    }
}

