using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using GlobalDentalClasses.Controller;
using System.IO;

namespace GlobalDentalServer
{
    class Program
    {
        public static void Main()
        {
            var portNumber = 5678;
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            var encoder = new UTF8Encoding();
            var clientsFile = "registeredClients.json";
            var DOPsFile = "DOPs.json";
            List<string> validClients = null;
            Dictionary<string, List<DentalOutreachProgram>> DOPCollections = null;

            try
            {
                var fileContents = System.IO.File.ReadAllText(clientsFile);
                validClients = JsonConvert.DeserializeObject<List<string>>(fileContents);
            }
            catch (Exception)
            {
                validClients = new List<string>();
                File.WriteAllText(clientsFile, JsonConvert.SerializeObject(validClients));
            }

            try
            {
                var fileContents = System.IO.File.ReadAllText(DOPsFile);
                DOPCollections = JsonConvert.DeserializeObject<Dictionary<string, List<DentalOutreachProgram>>>(fileContents);
            }
            catch (Exception)
            {
                DOPCollections = new Dictionary<string, List<DentalOutreachProgram>>();
                File.WriteAllText(DOPsFile, JsonConvert.SerializeObject(DOPCollections));
            }

            var validSessions = new Dictionary<string, string>();

            while (true)
            {
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                TcpListener clientListener = new TcpListener(serverIP, portNumber);

                /* Start Listeneting at the specified port */
                clientListener.Start();

                Console.WriteLine("The server is running at port " + portNumber + "...");
                Console.WriteLine("The local End point is  :" +
                                    clientListener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection.....");

                Socket clientSocket = clientListener.AcceptSocket();
                Console.WriteLine("Connection accepted from " + clientSocket.RemoteEndPoint);

                byte[] receiveBuffer = new byte[1024 * 100];
                int k = clientSocket.Receive(receiveBuffer);
                byte[] truncatedReceiveBuffer = new byte[k];

                Array.Copy(receiveBuffer, truncatedReceiveBuffer, k);
                Console.WriteLine("Recieved...");
                var gottenString = encoder.GetString(truncatedReceiveBuffer);
                var messageType = gottenString.Substring(0, 4);
                if (messageType == "SYNC")
                {
                    var token = gottenString.Substring(5, 10);
                    if (validSessions.ContainsKey(token))
                    {
                        var ClientID = validSessions[token];
                        var DOPsString = gottenString.Substring(16);
                        var DeserializedDOPs = JsonConvert.DeserializeObject<List<DentalOutreachProgram>>(DOPsString);
                        DOPCollections[ClientID] = DeserializedDOPs;
                        File.WriteAllText(DOPsFile, JsonConvert.SerializeObject(DOPCollections));
                    }
                }
                else if(messageType == "LOGN")
                {
                    var clientID = gottenString.Substring(5);
                    if (validClients.Contains(clientID))
                    {
                        var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 10);
                        validSessions[token] = clientID;
                        if (DOPCollections.ContainsKey(clientID))
                        {
                            var DOPs = DOPCollections[clientID];
                            var DOPsJSON = JsonConvert.SerializeObject(DOPs);
                            clientSocket.Send(encoder.GetBytes(token + ":" + DOPsJSON));
                        }
                        else
                        {
                            clientSocket.Send(encoder.GetBytes(token));
                        }
                    }
                    else
                    {
                        clientSocket.Send(encoder.GetBytes(""));
                    }
                }
                else if (messageType == "REGS")
                {
                    var newClientID = gottenString.Substring(5);
                    if (validClients.Contains(newClientID))
                    {
                        clientSocket.Send(encoder.GetBytes("The Client ID " + newClientID + " is already in use"));
                    }
                    else
                    {
                        validClients.Add(newClientID);
                        File.WriteAllText(clientsFile, JsonConvert.SerializeObject(validClients));
                        var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 10);
                        validSessions[token] = newClientID;
                        clientSocket.Send(encoder.GetBytes("GOOD:" + token));
                    }
                }

                /* clean up */
                clientSocket.Close();
                clientListener.Stop();
            }
        }
    }
}
