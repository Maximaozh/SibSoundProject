using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibsound.Secures
{

    public class Verify
    {
        public Verify()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Logger\\Logger.exe";
            SetLoggerExecutable(path);
        }

        private Process LoggerExecutable { get; set; }
        public string Retrieve_serial(string strSource)
        {
            string strStart = "\\";
            int Start, End;
            Start = strSource.LastIndexOf(strStart) + strStart.Length;
            End = strSource.IndexOf("&0", Start);
            string serial = strSource.Substring(Start, End - Start);
            return serial;
        }

        public byte[] VerifyKey()
        {
            string usb = GetFlashDriveWithKey();

            if (usb == null)
            {
                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Статус активации%Ошибка. Базовая версия%";
                LoggerExecutable.Start();
                return new byte[] { 0, 0, 0, 0 };
            }

            var encryptedData = File.ReadAllBytes(usb + "KEY.MAXIMAOZH");
            var data = "";

            string DeviceIDstr = "";
            string Serial = "";

            string query = "SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            List<string> usbDevdata = new List<string>();

            bool decrypted = false;

            foreach (ManagementObject diskDrive in searcher.Get().Cast<ManagementObject>())
            {
                DeviceIDstr = (string)diskDrive["PNPDeviceID"];
                Serial = Retrieve_serial(DeviceIDstr);
                data = MyAes.Decrypt(Serial, encryptedData);
                if (data.Contains("&ORG") && data.Contains("&FUN") && data.Contains("&EXP"))
                {
                    decrypted = true;
                    break;
                }
            }
            if (!decrypted)
            {
                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Статус активации%Ошибка. Базовая версия%";
                LoggerExecutable.Start();
                return new byte[] { 0, 0, 0, 0 };
            }

            byte cut = 0, paste = 0, copy = 0, delete = 0, plugins = 0;

            if (!data.Contains("&ORG") || !data.Contains("&FUN"))
            {
                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Статус активации%Ошибка. Базовая версия%";
                LoggerExecutable.Start();
                return new byte[] { 0, 0, 0, 0 };
            }

            int startIndexOfExp = data.IndexOf("&EXP_") + 5;
            var date = data.Substring(startIndexOfExp, data.Length - startIndexOfExp - 1);

            if (DateTime.Parse(date) < DateTime.Now)
            {
                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Статус активации%Ошибка. Базовая версия%";
                LoggerExecutable.Start();
                return new byte[] { 0, 0, 0, 0 };
            }

            if (data.Contains("&FUN_COPY"))
                copy = 1;
            if (data.Contains("&FUN_CUT"))
                cut = 1;
            if (data.Contains("&FUN_PASTE"))
                paste = 1;
            if (data.Contains("&FUN_DELETE"))
                delete = 1;

            string functions = $"Копировать({copy}) Вырезать({cut}) Вставить({paste}) Удалить({delete})";

            MessageBox.Show($"Лицензия действительна до {date} не включительно. {functions}", "Внимание");

            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Статус активации%Успешно. " + functions;
            LoggerExecutable.Start();
            return new byte[] { copy, cut, paste, delete};
        }

        static private string GetFlashDriveWithKey()
        {
            List<string> FlashDrives = new List<string>();

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if ((d.DriveType) == DriveType.Removable)
                    FlashDrives.Add(d.Name);
            }

            foreach (string usb in FlashDrives)
            {
                if (File.Exists(usb + "KEY.MAXIMAOZH"))
                    return usb;
            }

            return null;
        }

        private void SetLoggerExecutable(string pathToLoggerExecutable)
        {
            LoggerExecutable = new Process();
            LoggerExecutable.StartInfo.FileName = pathToLoggerExecutable;
            LoggerExecutable.StartInfo.CreateNoWindow = true;
            LoggerExecutable.StartInfo.UseShellExecute = false;
        }
    }
}
