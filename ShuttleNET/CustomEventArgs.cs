using System;

namespace ShuttleNET
{
    /// <summary>
    /// Provides data for the ShuttleNET.Contour.ShuttleMove event
    /// </summary>
    public class ShuttleEventArgs : EventArgs
    {
        public ShuttleEventArgs(int zone, ShuttleDirection direction, DeviceType device, DeviceNo deviceNo)
        {
            Zone = zone;
            Direction = direction;
            Device = device;
            DeviceNumber = deviceNo;
        }

        /// <summary>
        /// The zone number the shuttle knob was rotated to
        /// </summary>
        public int Zone
        {
            get;
            private set;
        }

        /// <summary>
        /// The direction the shuttle knob was rotated
        /// </summary>
        public ShuttleDirection Direction
        {
            get;
            private set;
        }
        /// <summary>
        /// The ShuttleNet.DeviceType of the device the event occured from
        /// </summary>
        public DeviceType Device
        {
            get;
            private set;
        }
        /// <summary>
        /// The ShuttleNet.DeviceNo of the device the event occured from
        /// </summary>
        public DeviceNo DeviceNumber
        {
            get;
            private set;
        }
    }
    /// <summary>
    /// Provides data for the ShuttleNET.Contour.JogMove event
    /// </summary>
    public class JogEventArgs : EventArgs
    {
        public JogEventArgs(JogDirection direction, DeviceType device, DeviceNo deviceNo)
        {
            Direction = direction;
            Device = device;
            DeviceNumber = deviceNo;
        }

        /// <summary>
        /// The direction that the jog dial was rotated
        /// </summary>
        public JogDirection Direction
        {
            get;
            private set;
        }

        /// <summary>
        /// The ShuttleNet.DeviceType of the device the event occured from
        /// </summary>
        public DeviceType Device
        {
            get;
            private set;
        }
        /// <summary>
        /// The ShuttleNet.DeviceNo of the device the event occured from
        /// </summary>
        public DeviceNo DeviceNumber
        {
            get;
            private set;
        }
    }
    /// <summary>
    /// Provides data for the ShuttleNET.Contour.ButtonClick event
    /// </summary>
    public class ButtonClickEventArgs : EventArgs
    {
        public ButtonClickEventArgs(int Button, DeviceType device, DeviceNo deviceNo)
        {
            ButtonNumber = Button;
            Device = device;
            DeviceNumber = deviceNo;
        }

        /// <summary>
        /// The number of the button that was clicked
        /// </summary>
        public int ButtonNumber
        {
            get;
            private set;
        }
        /// <summary>
        /// The ShuttleNet.DeviceType of the device the event occured from
        /// </summary>
        public DeviceType Device
        {
            get;
            private set;
        }
        /// <summary>
        /// The ShuttleNet.DeviceNo of the device the event occured from
        /// </summary>
        public DeviceNo DeviceNumber
        {
            get;
            private set;
        }
    }
}

