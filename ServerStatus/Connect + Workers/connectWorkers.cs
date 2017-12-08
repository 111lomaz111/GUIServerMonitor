using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.Threading;

namespace ServerStatus.Connect___Workers
{
    class ConnectWorkers
    {
        public ConnectWorkers(string _cpuUsageCommand, string _ramUsageCommand, string _ramMaxValueCheckCommand, string _diskUsageCommand, string _ip, string _login, string _password)
        {
            SetCommands(_cpuUsageCommand, _ramUsageCommand,  _ramMaxValueCheckCommand,  _diskUsageCommand);
            SetCredentials(_ip, _login, _password);
            ConnnectToServer();
            Workers();
        }

        private int i, cpuValueUsage, ramValueUsage, ramMaxValue;
        private string cpuUsageCommand, ramUsageCommand, ramMaxValueCheckCommand, diskUsageCommand, login, password, ip;
        private SshClient client;
        private Thread threadCPU, threadRAM;

        #region getters

        public int GetramMaxValue()
        {
            return ramMaxValue;
        }

        public int GetramValueUsage()
        {
            return ramValueUsage;
        }

        public int GetcpuValueUsage()
        {
            return cpuValueUsage;
        }

        #endregion

        #region setters

        private void SetCommands(string _cpuUsageCommand, string _ramUsageCommand, string _ramMaxValueCheckCommand, string _diskUsageCommand)
        {
            cpuUsageCommand = _cpuUsageCommand;
            ramUsageCommand = _ramUsageCommand;
            ramMaxValueCheckCommand = _ramMaxValueCheckCommand;
            diskUsageCommand = _diskUsageCommand;
        }

        private void SetCredentials(string _ip, string _login, string _password)
        {
            ip = _ip;
            login = _login;
            password = _password;
        }

        #endregion

        private void ConnnectToServer()
        {
            client = new SshClient(ip, login, password);
            try
            {
                client.Connect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot connect to server. Error: " + e);
            }
            GetRamValueLimit();
        }

        private void GetRamValueLimit()
        {
            var ramValueLimitCmd = client.RunCommand(ramMaxValueCheckCommand);

            var ramValueLimit = ramValueLimitCmd.Execute();
            ramMaxValue = Convert.ToInt16(ramValueLimit);
        }

        private void Workers()
        {

            threadCPU = new Thread(
                    new ThreadStart(() =>
                    {
                        for (; ; )
                        {
                            i++;
                            var cmdCPU = client.RunCommand(cpuUsageCommand);
                            var resultCPU = cmdCPU.Execute();
                            cpuValueUsage = Convert.ToInt16(resultCPU);
                        }
                    }));

            threadRAM = new Thread(
                new ThreadStart(() =>
                {
                    for (; ; )
                    {
                        var cmdRAM = client.RunCommand(ramUsageCommand);
                        var resultRAM = cmdRAM.Execute();
                        ramValueUsage = Convert.ToInt16(resultRAM);
                        Thread.Sleep(1000);
                    }
                }));
            threadCPU.Start();
            threadRAM.Start();
        }
    }
}
