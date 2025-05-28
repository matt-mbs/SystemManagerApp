using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;

namespace SystemToolsLib
{
    public static class SystemTools
    {
        public static string GetDriveSerialNumber(string drive = "C")
        {
            ManagementObject disk = new ManagementObject($@"win32_logicaldisk.deviceid=""{drive}:""");
            disk.Get();
            return disk["VolumeSerialNumber"]?.ToString();
        }

        public static int GetDiskCount()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            return searcher.Get().Count;
        }

        public static string GetSystemInventory()
        {
            string cpu = "", ram = "", nic = "", patches = "";

            var cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (var item in cpuSearcher.Get())
                cpu += item["Name"] + "\n";

            var ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (var item in ramSearcher.Get())
                ram += $"{Math.Round(Convert.ToDouble(item["Capacity"]) / (1024 * 1024 * 1024), 2)} GB\n";

            var nicSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetEnabled=true");
            foreach (var item in nicSearcher.Get())
                nic += item["Name"] + "\n";

            var patchSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_QuickFixEngineering");
            foreach (var item in patchSearcher.Get())
                patches += item["HotFixID"] + "\n";

            return $"CPU:\n{cpu}\nRAM:\n{ram}\nNICs:\n{nic}\nParches:\n{patches}";
        }

        public static List<string> GetMACAddresses()
        {
            return NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .ToList();
        }

        public static void CreateRegistryKey(string path, string name, string value)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(path);
            key.SetValue(name, value);
            key.Close();
        }

        public static string ReadRegistryKey(string path, string name)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
            return key?.GetValue(name)?.ToString();
        }

        public static void DeleteRegistryKey(string path, string name)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            key?.DeleteValue(name, false);
            key?.Close();
        }

        public static void ModifyRegistryKey(string path, string name, string newValue)
        {
            CreateRegistryKey(path, name, newValue);
        }

        public static List<string> GetRunningProcesses()
        {
            return Process.GetProcesses().Select(p => $"{p.ProcessName} - ID: {p.Id}").ToList();
        }

        public static void KillProcessById(int id)
        {
            Process.GetProcessById(id).Kill();
        }
    }
}