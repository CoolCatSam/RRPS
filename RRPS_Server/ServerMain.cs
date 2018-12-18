using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using RRSP_Shared_Classes;

namespace RRPS_Server
{
    class ServerMain
    {


        public static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    TcpListener myList = new TcpListener(IPAddress.Any, 8001);
                    myList.Start();
                    Console.WriteLine("The server is running at port 8001...");
                    Console.WriteLine("The local End point is  :" +
                    myList.LocalEndpoint);
                    Console.WriteLine("Waiting for a connection.....");
                    Socket s = myList.AcceptSocket();
                    Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
                    //byte[] b = new byte[8192];
                    //int k = s.Receive(b);
                    Console.WriteLine("Recieved...");

                    Message message = MessageSerialization.Serialize(new RPS_Data_Packet(RPS_Types.RPS_Type.SCISSORS));

                    //Console.WriteLine(Command);
                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(message.Data);
                    s.Send(asen.GetBytes("The string was recieved by the server."));
                    Console.WriteLine("\nSent Acknowledgement");
                    s.Close();
                    myList.Stop();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }


    }
}

