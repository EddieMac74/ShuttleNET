using System;
using System.Runtime.InteropServices;

namespace ShuttleNET
{
    /// <summary>
    /// .NET class wrapper for the Contour Shuttle SDK
    /// </summary>
    public sealed class Contour
    {
        [DllImport("ShuttleSDK.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_Shuttle_Register_Callback_Global@12")]
        private static extern uint _Shuttle_RegisterCallback_Global_Msg(MulticastDelegate shuttleproc, ushort type, ushort devno);

        [DllImport("ShuttleSDK.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_Shuttle_Register_Callback@12")]
        private static extern uint _Shuttle_RegisterCallback_Msg(MulticastDelegate shuttleproc, ushort type, ushort devno);

        [DllImport("ShuttleSDK.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_Shuttle_Unregister_Callback@8")]
        private static extern int _Shuttle_UnregisterCallback_Msg(ushort type, ushort devno);

        private delegate void ShuttleCallback(uint @event, byte status, ushort type, ushort devno);

        private static ShuttleCallback callback;

        /// <summary>
        /// Initializes a new instance of the ShuttleNET.Contour class
        /// </summary>
        public Contour()
        {
            //callback = new ShuttleCallback(Shuttle_Callback);
        }

        /// <summary>
        /// Occurs when a button is clicked on the Contour Shuttle device
        /// </summary>
        public  event Button_Click ButtonClick;
        /// <summary>
        /// Occurs when the jog knob on the Contour Shuttle device is rotated
        /// </summary>
        public  event Jog_Move JogMove;   
        /// <summary>
        /// Occurs when the shuttle dial is rotated on the Contour Shuttle device
        /// </summary>
        public  event Shuttle_Move ShuttleMove;

        private void Shuttle_Callback(uint @event, byte status, ushort type, ushort devno)
        {
            EventCode eventCode = (EventCode)@event;
            
            if (status == 1)
            {
                switch (eventCode)
                {
                    case EventCode.SHUTTLEEVENTBUTTON0:
                        ButtonClick(this, new ButtonClickEventArgs(0, (DeviceType) type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON1:
                        ButtonClick(this, new ButtonClickEventArgs(1, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON2:
                        ButtonClick(this, new ButtonClickEventArgs(2, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON3:
                        ButtonClick(this, new ButtonClickEventArgs(3, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON4:
                        ButtonClick(this, new ButtonClickEventArgs(4, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON5:
                        ButtonClick(this, new ButtonClickEventArgs(5, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON6:
                        ButtonClick(this, new ButtonClickEventArgs(6, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON7:
                        ButtonClick(this, new ButtonClickEventArgs(7, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON8:
                        ButtonClick(this, new ButtonClickEventArgs(8, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON9:
                        ButtonClick(this, new ButtonClickEventArgs(9, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON10:
                        ButtonClick(this, new ButtonClickEventArgs(10, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON11:
                        ButtonClick(this, new ButtonClickEventArgs(11, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON12:
                        ButtonClick(this, new ButtonClickEventArgs(12, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON13:
                        ButtonClick(this, new ButtonClickEventArgs(13, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON14:
                        ButtonClick(this, new ButtonClickEventArgs(14, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTBUTTON15:
                        ButtonClick(this, new ButtonClickEventArgs(15, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTJOGLEFT:
                        JogMove(this, new JogEventArgs(JogDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTJOGRIGHT:
                        JogMove(this, new JogEventArgs(JogDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL8:
                        ShuttleMove(this, new ShuttleEventArgs(8, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL7:
                        ShuttleMove(this, new ShuttleEventArgs(7, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL6:
                        ShuttleMove(this, new ShuttleEventArgs(6, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL5:
                        ShuttleMove(this, new ShuttleEventArgs(5, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL4:
                        ShuttleMove(this, new ShuttleEventArgs(4, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL3:
                        ShuttleMove(this, new ShuttleEventArgs(3, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL2:
                        ShuttleMove(this, new ShuttleEventArgs(2, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEL1:
                        ShuttleMove(this, new ShuttleEventArgs(1, ShuttleDirection.Left, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLEC0:
                        ShuttleMove(this, new ShuttleEventArgs(0, ShuttleDirection.Center, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER1:
                        ShuttleMove(this, new ShuttleEventArgs(1, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER2:
                        ShuttleMove(this, new ShuttleEventArgs(2, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER3:
                        ShuttleMove(this, new ShuttleEventArgs(3, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER4:
                        ShuttleMove(this, new ShuttleEventArgs(4, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER5:
                        ShuttleMove(this, new ShuttleEventArgs(5, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER6:
                        ShuttleMove(this, new ShuttleEventArgs(6, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER7:
                        ShuttleMove(this, new ShuttleEventArgs(7, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                    case EventCode.SHUTTLEEVENTSHUTTLER8:
                        ShuttleMove(this, new ShuttleEventArgs(8, ShuttleDirection.Right, (DeviceType)type, (DeviceNo)devno));
                        return;
                }
            }
        }

        /// <summary>
        /// Registers the device to recieve event notifications from the Shuttle driver
        /// </summary>
        /// <param name="Device">ShuttleNET.DeviceType enumeration describing the device to be registered</param>
        /// <param name="DeviceNumber">ShuttleNET.DeviceType enumeration describing the device position (number) to be registered</param>
        /// <returns>An integer value of type ShuttleNet.ErrorCode which denotes the result of the function call</returns>
        public int RegisterCallBack(DeviceType Device, DeviceNo DeviceNumber)
        {
            callback = new ShuttleCallback(Shuttle_Callback);
            int result = (int)_Shuttle_RegisterCallback_Msg(callback, (ushort)Device, (ushort)DeviceNumber);
            return result;
        }
       
        /// <summary>
        /// Registers the device to recieve event notifications from the Shuttle driver
        /// </summary>
        /// <param name="Device">ShuttleNET.DeviceType enumeration describing the device to be registered globally</param>
        /// <param name="DeviceNumber">ShuttleNET.DeviceType enumeration describing the device position (number) to be registered globally</param>
        /// <returns>An integer value of type ShuttleNet.ErrorCode which denotes the result of the function call</returns>
        public int RegisterCallBackGlobal(DeviceType Device, DeviceNo DeviceNumber)
        {    
             callback = new ShuttleCallback(Shuttle_Callback);
            int result = (int)_Shuttle_RegisterCallback_Global_Msg(callback, (ushort)Device, (ushort)DeviceNumber);
            return result;
        }
       
        /// <summary>
        /// Unegisters the device from receiving event notifications from the Shuttle driver
        /// </summary>
        /// <param name="Device">ShuttleNET.DeviceType enumeration describing the device to be unregistered</param>
        /// <param name="DeviceNumber">ShuttleNET.DeviceType enumeration describing the device position (number) to be unregistered</param>
        /// <returns>An integer value of type ShuttleNet.ErrorCode which denotes the result of the function call</returns>
        public int UnregisterCallBack(DeviceType Device, DeviceNo DeviceNumber)
        {
            int result = (int)_Shuttle_UnregisterCallback_Msg((ushort)Device, (ushort)DeviceNumber);
            return result;
        }
    }
}

   

