﻿using System.Collections.Generic;

namespace coinium.Net.RPC.Responses
{
    public class ValidateAddress
    {
        public bool IsValid { get; set; }
        public string Address { get; set; }
        public bool IsMine { get; set; }
        public bool IsScript { get; set; }
        public string Script { get; set; }
        public List<string> Addresses { get; set; }
        public int SigsRequired { get; set; }
        public string Account { get; set; }
    }
}
