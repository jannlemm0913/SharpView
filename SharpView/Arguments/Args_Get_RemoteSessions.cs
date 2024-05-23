using SharpView.Enums;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpView.Arguments
{
    public class Args_Get_RemoteSessions
    {
        // Arguments from Get-DomainComputer
        public string OperatingSystem { get; set; }
        public string ServicePack { get; set; }
        public bool Unconstrained { get; set; }
        public bool TrustedToAuth { get; set; }
        public bool Ping { get; set; }
        public string Domain { get; set; }
        public string SPN { get; set; }

        // Custom Arguments
        public string[] UserName { get; set; }
        public string[] SessionName { get; set; }
        public string[] SessionState { get; set; }
        public int[] SessionID { get; set; }


        public NetworkCredential Credential { get; set; }
    }
}