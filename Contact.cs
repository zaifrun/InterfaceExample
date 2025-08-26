﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Contact
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public Contact(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
