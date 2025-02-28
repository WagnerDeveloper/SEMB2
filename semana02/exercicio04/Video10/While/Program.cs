//Pinger

using System.Net.NetworkInformation;

Ping p1 = new Ping();

PingReply PR = p1.Send("172.217.29.238");

while(PR.Status.ToString() == "Success"){
    Console.WriteLine(PR.Status.ToString() + "!");
    PR = p1.Send("172.217.29.238");
    Console.WriteLine("Waiting 10 seconds for next request");
    Thread.Sleep(10000);
}