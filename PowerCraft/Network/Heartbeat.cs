using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.IO;
using System.Net.Cache;
using PowerCraft.Tools;
// Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org>
namespace PowerCraft.Network
{
    public enum HeartbeatLocation
    {
        ClassiCube,
        MinecraftNet
    }
    public class Heartbeat
    {
        
        public static string GenerateSalt()
        {
            RandomNumberGenerator prng = RandomNumberGenerator.Create();
            StringBuilder sb = new StringBuilder();
            byte[] oneChar = new byte[1];
            while (sb.Length < 32)
            {
                prng.GetBytes(oneChar);
                if (oneChar[0] >= 48 && oneChar[0] <= 57 ||
                    oneChar[0] >= 65 && oneChar[0] <= 90 ||
                    oneChar[0] >= 97 && oneChar[0] <= 122)
                {
                    sb.Append((char)oneChar[0]);
                }
            }
            return sb.ToString();
        }
        static readonly TimeSpan Timeout = TimeSpan.FromSeconds( 10 );
        static readonly TimeSpan Delay = TimeSpan.FromSeconds( 25 );
        const string UrlFileName = "externalurl.txt";

        public static readonly string Salt = GenerateSalt();
        static Uri uri;


        public static void Start() {
            Thread heartbeatThread = new Thread( Beat ) { IsBackground = true };
            heartbeatThread.Start();
        }

        static bool IsShown = false;
        static void Beat() {
            while( true ) {
                try {
                    string requestUri =
                        String.Format( "{0}?public={1}&max={2}&users={3}&port={4}&version=7&salt={5}&name={6}",
                                       Config.heartbeatURL(),
                                       Config.GetPrivacy(),
                                       Config.GetMaxPlayers(),
                                       Server.GetPlayerList().ToString(),
                                       Config.GetPort(),
                                       Uri.EscapeDataString( Salt ),
                                       Uri.EscapeDataString( Config.GetServerName() ) );
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create( requestUri );
                    request.Method = "GET";
                    request.Timeout = (int)Timeout.TotalMilliseconds;
                    request.CachePolicy = new HttpRequestCachePolicy( HttpRequestCacheLevel.BypassCache );
                    request.UserAgent = Updater.VersionString(); ;
                    request.ServicePoint.BindIPEndPointDelegate = BindIPEndPointCallback;

                    using( HttpWebResponse response = (HttpWebResponse)request.GetResponse() ) {
                        var rs = response.GetResponseStream();
                        if( rs == null ) continue;
                        using( StreamReader responseReader = new StreamReader( rs ) ) {
                            string responseText = responseReader.ReadToEnd().Trim();
                            Uri newUri;
                            if( Uri.TryCreate( responseText, UriKind.Absolute, out newUri ) ) {
                                if( newUri != uri ) {
                                    File.WriteAllText( UrlFileName, newUri.ToString() );
                                    uri = newUri;
                                    Writer[] writerArray = new Writer[] {
                                        new Writer( String.Format("Heartbeat: {0}", newUri )),
                                        new Writer( String.Format("Heartbeat URL also saved to {0} file.", UrlFileName ))
                                    };
                                    foreach (Writer w in writerArray)
                                    {
                                        w.WriteToConsole(LogType.Normal);
                                    }
                                }
                            } else {
                                new Writer( String.Format("Heartbeat: Minecraft.net replied with: {0}", responseText) )
                                    .WriteToConsole(LogType.Warning);
                            }
                        }
                    }
                    Thread.Sleep( Delay );

                } catch( Exception ex ) {
                    if (!IsShown)
                    {
                        new Writer(String.Format("Heartbeat: {0}: {1}", ex.GetType().Name, ex.Message))
                            .WriteToConsole(LogType.Serious);
                        IsShown = true;
                    }
                }
            }
        }


        static IPEndPoint BindIPEndPointCallback( ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount ) {
            return new IPEndPoint( IPAddress.Any, 0 );
        }
    }
}
