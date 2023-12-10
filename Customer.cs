﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AirTicketBookingWindowForm
{
    public class Customer
    {
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public DateTime Birthday { get; set; }
        public string PassPortNbr { get; set; }
        public string Nationality {  get; set; }
        public Image Avatar { get; set; }

        public Customer()
        {
            CustomerID = GenerateCustomerID();
        }

        private string GenerateCustomerID()
        {
            return $"{Nationality}{PassPortNbr}";
        }

        public Customer(string CustomerName, DateTime Birthday, Image Avatar, string PassPortNbr, string Nationality)
        {
            this.CustomerName = CustomerName;
            this.Birthday = Birthday;
            this.Avatar = Avatar;
            this.PassPortNbr = PassPortNbr;
            this.Nationality = Nationality;
            CustomerID = GenerateCustomerID();
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CustomerID { get; set; }

        public User()
        {
            UserName = "N/A";
        }

        public User(string UserName, string Password, string CustomerID)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.CustomerID = CustomerID;
        }
    }

    public class FlightInfo
    {
        public string FlightID { get; }
        public DateTime TimeDepart { get; set; }
        public DateTime TimeArrival { get; set; }
        public string FlightType { get; set; }
        public int NumCredit { get; set; }

        public FlightInfo()
        {
            FlightID = GenerateFlightID();
        }

        public string GenerateFlightID ()
        {
            string formattedTimeDepart = TimeDepart.ToString("yyyyMMddHHmm");
            return $"{FlightType}{formattedTimeDepart}";
        }

        public FlightInfo(DateTime TimeDepart, DateTime TimeArrival, string FlightType, int NumCredit)
        {
            this.TimeDepart = TimeDepart;
            this.TimeArrival = TimeArrival;
            this.FlightType = FlightType;
            this.NumCredit = NumCredit;
            FlightID = GenerateFlightID();
        }
    }

    public class FlightRegistration
    {
        public string CustomerID { get; set; }
        public List<FlightInfo> FlightEnrollList;

        public FlightRegistration()
        {
            CustomerID = "N/A";
            FlightEnrollList = new List<FlightInfo>();
        }

        public FlightRegistration(string CustomerID)
        {
            this.CustomerID = CustomerID;
            FlightEnrollList = new List<FlightInfo>();
        }

        public int CalculateSumCredit()
        {
            return FlightEnrollList.Sum(x => x.NumCredit);
        }
    }
}
