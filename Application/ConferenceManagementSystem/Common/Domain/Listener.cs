﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Listener: Participant
    {
        private string cNP;
        public string CNP { get => cNP; set => cNP = value; }
    }
}
