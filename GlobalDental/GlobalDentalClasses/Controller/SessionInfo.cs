using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace GlobalDentalClasses.Controller
{
    public class SessionInfo
    {
        public SessionInfo()
        {
            loggedIn = false;
            sessionToken = null;
        }

        public string sessionToken { get; set; }
        public bool loggedIn { get; set; }

        public void LogOut()
        {
            loggedIn = false;
            sessionToken = null;
        }

        public List<DentalOutreachProgram> LogIn(string ClientID)
        {
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                var messageLength = 1024 * 100;
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] helloMessage = encoder.GetBytes("LOGN:" + ClientID);

                stm.Write(helloMessage, 0, helloMessage.Length);

                byte[] payloadBytes = new byte[messageLength];
                int k = stm.Read(payloadBytes, 0, messageLength);
                tcpclnt.Close();

                byte[] truncatedReceiveBuffer = new byte[k];
                Array.Copy(payloadBytes, truncatedReceiveBuffer, k);

                var payload = encoder.GetString(truncatedReceiveBuffer);
                sessionToken = payload.Substring(0, 10);
                loggedIn = true;
                if (payload.Length > 10)
                {
                    var a = payload.Substring(11);
                    var b = JsonConvert.DeserializeObject<string>(a);
                    var c = JsonConvert.DeserializeObject<List<DentalOutreachProgram>>(b);
                    return c;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return null;
            }
        }

        public string Register(string clientID)
        {
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                var messageLength = 1024 * 100;
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] helloMessage = encoder.GetBytes("REGS:" + clientID);

                stm.Write(helloMessage, 0, helloMessage.Length);

                byte[] ReceivedBytes = new byte[messageLength];
                int k = stm.Read(ReceivedBytes, 0, messageLength);
                tcpclnt.Close();

                byte[] truncatedReceiveBuffer = new byte[k];
                Array.Copy(ReceivedBytes, truncatedReceiveBuffer, k);

                var receivedString = encoder.GetString(truncatedReceiveBuffer);
                if (receivedString.Substring(0, 4) != "GOOD")
                {
                    return receivedString;
                }
                else
                {
                    sessionToken = receivedString.Substring(5);
                    loggedIn = true;
                    return "";
                }
            }

            catch (Exception e)
            {
                return e.StackTrace;
            }
        }

        public bool Sync(DOPs Programs)
        {
            if (!loggedIn)
            {
                return false;
            }
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] syncPayload = encoder.GetBytes("SYNC:" + sessionToken + ":" + Programs.getSerializedJSON());

                stm.Write(syncPayload, 0, syncPayload.Length);

                tcpclnt.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return false;
            }
        }
    }
}
