﻿using NAudio.CoreAudioApi;
using Newtonsoft.Json;
using SoundSwitch.Common.Framework.Audio.Icon;

namespace SoundSwitch.Common.Framework.Audio.Device
{
    public class DeviceFullInfo : DeviceInfo
    {
        public string IconPath { get; }
        public DeviceState State { get; }

        public System.Drawing.Icon LargeIcon => AudioDeviceIconExtractor.ExtractIconFromPath(IconPath, Type, true);
        public System.Drawing.Icon SmallIcon => AudioDeviceIconExtractor.ExtractIconFromPath(IconPath, Type, false);

        [JsonConstructor]
        public DeviceFullInfo(string name, string id, DataFlow type, string iconPath, DeviceState state, bool isUsb) : base(name, id, type, isUsb)
        {
            IconPath = iconPath;
            State = state;
        }

        public DeviceFullInfo(MMDevice device) : base(device)
        {
            IconPath = device.IconPath;
            State = device.State;
        }
    }
}