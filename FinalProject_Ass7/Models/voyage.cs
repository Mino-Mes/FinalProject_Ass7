using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Ass7.Models
{
    public class voyage
    {
        public voyage(int turckNum, int driverNum, int coNum, int tripNum, string dateD, string dateR, string stateCode, double milesDriven, int fuelReceiptNumber, double gallonPurchased, double taxesPaid, string stationName, string stationLocation)
        {
            this.turckNum = turckNum;
            this.driverNum = driverNum;
            this.coNum = coNum;
            this.tripNum = tripNum;
            this.dateD = dateD;
            this.dateR = dateR;
            this.stateCode = stateCode;
            this.milesDriven = milesDriven;
            this.fuelReceiptNumber = fuelReceiptNumber;
            this.gallonPurchased = gallonPurchased;
            this.taxesPaid = taxesPaid;
            this.stationName = stationName;
            this.stationLocation = stationLocation;
        }

        public int turckNum { get; set; }
        public int driverNum { get; set; }
        public int coNum { get; set; }
        public int tripNum { get; set; }
        public String dateD { get; set; }
        public String dateR { get; set; }
        public String stateCode { get; set; }
        public double milesDriven { get; set; }
        public int fuelReceiptNumber { get; set; }
        public double gallonPurchased { get; set; }
        public double taxesPaid { get; set; }
        public String stationName { get; set; }
        public String stationLocation { get; set; }

    }
}