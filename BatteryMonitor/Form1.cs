﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //testing commit to github directly
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PowSrc.Text=GetPowerSource();
            BatStat.Text = GetBatteryStatus().ToString();
        }

        public String GetPowerSource()
        {
            string strPowerLineStatus = "Default";
            // Getting the current system power status.
            switch (SystemInformation.PowerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    strPowerLineStatus = "Battery";
                    break;
                case PowerLineStatus.Online:
                    strPowerLineStatus = "AC Power";
                    break;
                case PowerLineStatus.Unknown:
                    strPowerLineStatus = "Unknown";
                    break;
            }
            return strPowerLineStatus;
        }
        public float GetBatteryStatus()
        {
            float batterylife;
            batterylife = SystemInformation.PowerStatus.BatteryLifePercent;
            batterylife *= 100.0f;
            return batterylife;
        }
    }
}
