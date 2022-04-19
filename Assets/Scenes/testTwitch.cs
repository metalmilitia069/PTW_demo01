using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.IO;

public class testTwitch : MonoBehaviour
{
    TcpClient Twitch;
    StreamReader Reader;
    StreamWriter Writer;

    const string URL = "irc.chat.twitch.tv";
    const int PORT = 6667;

    string User = "MannyCalavera1919";//"DomoArigatoMissRoboto";
    //get OAuth from https://twtchapps.com/tmi
    string OAuth = "oauth:9thanuevmkli4kwdd1itigcw12s0h1";
    string Channel = "mannycalavera1919";

    private void ConnectToTwitch()
    {
        Twitch = new TcpClient(URL, PORT);
        Reader = new StreamReader(Twitch.GetStream());
        Writer = new StreamWriter(Twitch.GetStream());

        Writer.WriteLine("PASS " + OAuth);
        Writer.WriteLine("NICK " + User.ToLower());
        Writer.WriteLine("JOIN #" + Channel.ToLower());
        Writer.Flush();
    }

    private void Awake()
    {
        ConnectToTwitch();
    }

    // Update is called once per frame
    void Update()
    {
        if (Twitch.Available > 0)
        {
            string message = Reader.ReadLine();

            print(message);
            
        }
    }
}
