using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    public string ipaddress = "10.60.135.79";
    public int port = 138;

    private Socket clientSocket;
    public UIInput textInput;

    private byte[] data = new byte[1024];//��������
    private Thread t;

    public UILabel chatLabel;

    private string message = "";//��Ϣ����
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }

    // Update is called once per frame
    void Update()
    {
        if (message != null && message != "")
        {
            chatLabel.text += "\n" + message;
            message = "";//�����Ϣ
        }
    }

    void ConnectToServer()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //���������˽�������
        clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipaddress),port));
        //����һ���µ��߳�����������Ϣ
        t = new Thread(ReceiveMessage);
        t.Start();
    }
    /// <summary>
    /// ����̷߳�������ѭ��������Ϣ
    /// </summary>
    void ReceiveMessage()
    {
        while (true)
        {
            if (clientSocket.Connected == false)
                break;
            int length = clientSocket.Receive(data);
            message = Encoding.UTF8.GetString(data,0,length);
        }
    }
    void SendMessage(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        clientSocket.Send(data);
    }

    public void OnSendButtonClick()
    {
        string value = textInput.value; 
        SendMessage(value);
        textInput.value = "";
    }
}
