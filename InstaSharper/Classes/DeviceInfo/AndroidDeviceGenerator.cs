﻿using System;
using InstaSharper.API;

namespace InstaSharper.Classes.DeviceInfo
{
    public class AndroidDeviceGenerator
    {
        private static readonly string[] DEVICES =
        {
            "24/7.0; 380dpi; 1080x1920; OnePlus; ONEPLUS A3010; OnePlus3T; qcom",
            "23/6.0.1; 640dpi; 1440x2392; LGE/lge; RS988; h1; h1",
            "24/7.0; 640dpi; 1440x2560; HUAWEI; LON-L29; HWLON; hi3660",
            "23/6.0.1; 640dpi; 1440x2560; ZTE; ZTE A2017U; ailsa_ii; qcom",
            "23/6.0.1; 640dpi; 1440x2560; samsung; SM-G935F; hero2lte; samsungexynos8890",
            "23/6.0.1; 640dpi; 1440x2560; samsung; SM-G930F; herolte; samsungexynos8890"
        };

        /// <summary>
        ///     Build <see cref="AndroidDevice"/> from user agent string
        /// </summary>
        /// <param name="userAgent">Example: "24/7.0; 380dpi; 1080x1920; OnePlus; ONEPLUS A3010; OnePlus3T; qcom"</param>
        /// <returns></returns>
        public static AndroidDevice BuildDeviceFromString(string userAgent)
        {
            var device = new AndroidDevice();
            try
            {
                var components = userAgent.Split(';');
                if (components.Length != 7) throw new ArgumentException("User agent string provided is not valid");
                for (var i = 0; i < components.Length; i++) components[i] = components[i].Trim();
                device.UserAgent = GetCompleteUserAgent(userAgent);
                device.AndroidVersion = AndroidVersion.FromString(components[0].Split('/')[1]);
                device.Dpi = int.Parse(components[1].Remove(components[1].Length - 3));
                var resolutionValues = components[2].Split('x');
                device.ScreenResolution.Width = int.Parse(resolutionValues[0]);
                device.ScreenResolution.Height = int.Parse(resolutionValues[1]);
                device.HardwareManufacturer = components[3].Split('/')[0];
                device.HardwareModel = components[4];
                device.DeviceName = components[5];
                device.Cpu = components[6];
                device.DeviceId = ApiRequestMessage.GenerateDeviceIdFromGuid(device.Uuid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Failed to generate AndroidDevice. Check user agent string format?");
                return null;
            }
            
            return device;
        }

        private static string GetCompleteUserAgent(string deviceString)
        {
            // Example complete user agent:
            // Instagram 85.0.0.21.100 Android (24/7.0; 380dpi; 1080x1920; OnePlus; ONEPLUS A3010; OnePlus3T; qcom; en_US; 146536611)
            string format = "Instagram {0} Android ({1}; {2}; {3})";
            return string.Format(format, ApiVersion.CurrentApiVersion.AppVersion, deviceString,
                InstaApiConstants.USER_AGENT_LOCALE, ApiVersion.CurrentApiVersion.AppVersionCode);
        }

        public static AndroidDevice GetRandomAndroidDevice()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var randomDeviceIndex = random.Next(0, DEVICES.Length);
            return BuildDeviceFromString(DEVICES[randomDeviceIndex]);
        }
    }
}