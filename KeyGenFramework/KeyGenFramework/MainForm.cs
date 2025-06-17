using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Reflection;

namespace KeyGenFramework
{
        
    public partial class MainForm : Form
    {
        private Process LoggerExecutable { get; set; }

        public void SetLoggerExecutable(string pathToLoggerExecutable)
        {
            LoggerExecutable = new Process();
            LoggerExecutable.StartInfo.FileName = pathToLoggerExecutable;
        }

        public bool ProtocolData(string contnent)
        {
            LoggerExecutable.StartInfo.Arguments = contnent;
            LoggerExecutable.Start();
            return true;
        }

        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        public MainForm()
        {
            InitializeComponent();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Logger\\Logger.exe";
            SetLoggerExecutable(path);
        }
        public static string Retrieve_serial(string strSource)
        {
            string strStart = "\\";
            int Start, End;
            Start = strSource.LastIndexOf(strStart) + strStart.Length;
            End = strSource.IndexOf("&0", Start);
            string serial = strSource.Substring(Start, End - Start);
            return serial;
        }

        public static string[] GetUsbData()
        {
            string query = "SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            List<string> usbDevdata = new List<string>();

            foreach (ManagementObject diskDrive in searcher.Get().Cast<ManagementObject>())
            {
                string DeviceIDstr = (string)diskDrive["PNPDeviceID"];

                string Serial = Retrieve_serial(DeviceIDstr);

                string usbData = Serial;

                if (usbDevdata.IndexOf(usbData) < 0)
                    usbDevdata.Insert(0,usbData);
            }

            return usbDevdata.ToArray();
        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_DEVICECHANGE) 
            {
                switch ((int)msg.WParam)
                {
                    case DBT_DEVICEARRIVAL:
                        LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%СТАТУС УСТРОЙСТВА %ПОДКЛЮЧЕНО";
                        LoggerExecutable.Start();
                        EventsViewerRichTextBox.AppendText(DateTime.Now.ToString() + " Устройство подключено \n");
                        break;

                    case DBT_DEVICEREMOVECOMPLETE:
                        LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%СТАТУС УСТРОЙСТВА%ОТКЛЮЧЕНО";
                        LoggerExecutable.Start();
                        EventsViewerRichTextBox.AppendText(DateTime.Now.ToString() + " Устройство отключено \n");
                        break;

                    default:
                        break;
                }
            }
            base.WndProc(ref msg);

        }
        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            var output = GetUsbData();

            if (output.Length < 0)
                return;

            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Генерация ключа%" + output[0];
            LoggerExecutable.Start();

            this.EventsViewerRichTextBox.AppendText("Генерация ключа для"+"\n");
            this.EventsViewerRichTextBox.AppendText(output[DrivesComboBox.SelectedIndex] + "\n");

            GenerateKeyData(output);
        }

        private void GetDrivesButton_Click(object sender, EventArgs e)
        {
            DrivesComboBox.Items.Clear();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if ((d.DriveType) == DriveType.Removable)
                    DrivesComboBox.Items.Add(d.Name);
            }
        }

        private void GenerateKeyData(string[] serials)
        {
            string hashData = "";


            string organization = "&ORG_" + this.OrganizationNameRichTextBox.Text;
            hashData += organization;

            var funcSplit = this.FunctionsAvaiableRichTextBox.Text.Split('!');
            foreach(var func in funcSplit)
            {
                string newFunc = "&FUN_" + func;
                hashData += newFunc;
            }

            string expDate = "&EXP_" + this.ExpirationDateTimePicker.Value.ToShortDateString() + "!";
            hashData += expDate;

            string UsbName = this.DrivesComboBox.Text;
            string key = serials[DrivesComboBox.SelectedIndex];

            var data = MyAes.Crypt(key, hashData);
            File.WriteAllBytes(UsbName + "KEY.MAXIMAOZH", data);


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Новый ключ%" + hashData;
            LoggerExecutable.Start();
        }

    }
}
