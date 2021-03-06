﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using NBitcoin;

namespace StratisMinter
{
    public class Program
    {
        public static void Main(string[] args)
		{
			var conf = new Config
	        {
		        FolderLocation = AppContext.BaseDirectory,
				MaximumNodeConnection = 20,
				MaxBlocksInMemory = 30000,
				ConnectedNodesToStake = 1,
		        TrustedNodes = new List<IPEndPoint> {new IPEndPoint(IPAddress.Parse("127.0.0.1"), Network.Main.DefaultPort) } 
				//TrustedNodes = new List<IPEndPoint> { new IPEndPoint(IPAddress.Parse("185.64.104.55"), Network.Main.DefaultPort) }
			};
			
			//conf.FirstLoadPrivateKey = Key.Parse("your staking prv key here", Network.Main);

			Staker.Build(conf).Run();
        }
    }
}
