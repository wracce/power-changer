
using Microsoft.Toolkit.Uwp.Notifications;
using PowerManagerAPI;
using System;
using System.Runtime.InteropServices;

namespace PowerChanger
{

    internal class Program
    {

        [DllImport("C:\\Program Files\\MI\\Xiaomi Support Assistant\\1.1.1.579\\DriverManagementPopup.dll", EntryPoint = "CreatePopup")]
        public static extern string CreatePopup(int skin);

        [DllImport("C:\\Program Files\\MI\\Xiaomi Support Assistant\\1.1.1.579\\DriverManagementPopup.dll", EntryPoint = "DestoryPopup")]
        public static extern string DestoryPopup(string skin);

        public static void Main()
        {


            //var activePlanGuid = PowerManager.GetActivePlan();
            //var planGuids = PowerManager.ListPlans();

            //planGuids.Add(planGuids[0]);

            //bool isFindedActiveGuid = false;
            //foreach (var guid in planGuids)
            //{
            //    if (guid == activePlanGuid) { 
            //        isFindedActiveGuid = true;
            //        continue;
            //    }
            //    if (isFindedActiveGuid)
            //    {
            //        activePlanGuid = guid;
            //        break;
            //    }
            //}

            //PowerManager.SetActivePlan(activePlanGuid);

            //new ToastContentBuilder()
            //    .AddArgument("conversationId", 9813)
            //    .AddText(PowerManager.GetPlanName(activePlanGuid))
            //    .Show(toast => {
            //        toast.Priority = Windows.UI.Notifications.ToastNotificationPriority.High;
            //            //toast.ExpirationTime = DateTime.Now.AddSeconds(0);
            //    });

            for (int i = 0; i < 100000000; i++)
            {
                Console.WriteLine(DestoryPopup(CreatePopup(i)));
            }

        }
    }
}
