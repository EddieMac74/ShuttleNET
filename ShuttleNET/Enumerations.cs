using System;

namespace ShuttleNET
{
    /// <summary>
    /// Enumerated value describing the Shuttle device model type
    /// </summary>
    public enum DeviceType : ushort
    {
        /// <summary>
        /// The device type (model) is a Contour Shuttle Express
        /// </summary>
        SHUTTLEXPRESS = 1,
        /// <summary>
        /// The device type (model) is a Contour Shuttle Pro
        /// </summary>
        SHUTTLEPRO = 2,
        /// <summary>
        /// The device type (model) is a Contour Shuttle Pro V2
        /// </summary>
        SHUTTLEPRO2 = 3
    }

    /// <summary>
    /// Enumerated value describing the device priority assignment
    /// </summary>
    public enum DeviceNo : ushort
    {
        /// <summary>
        /// Shuttle device is in the primary position
        /// </summary>
        SHUTTLEPRIMARY = 1,
        /// <summary>
        /// Shuttle device is in the secondary position
        /// </summary>
        SHUTTLESECONDARY = 2
    }

    /// <summary>
    /// Enumerated value encoding the error type or status returned from the Contour shuttle driver
    /// </summary>
    public enum ErrorCode : uint
    {
        /// <summary>
        /// Shuttle engine responds that function call was successful
        /// </summary>
        SHUTTLESDK_OK = 0,
        /// <summary>
        /// Shuttle engine reponds that function call did not complete due to an error with a passed parameter 
        /// </summary>
        SHUTTLESDK_ERRPARAM = 1,
        /// <summary>
        /// Shuttle engine responds that Shuttle Drivers are not installed on the local machine
        /// </summary>
        SHUTTLESDK_ERRDRVNOTFOUND = 2,
        /// <summary>
        /// Shuttle engine responds that the device trying to be registered was previously registered.
        /// </summary>
        SHUTTLESDK_ERRALREADYREGISTERED = 3,
        /// <summary>
        /// Shuttle engine responds that the device registration was not found 
        /// </summary>
        SHUTTLESDK_ERRREGNOTFOUND = 4,
        /// <summary>
        /// Shuttle engine responds that an unknown error occured during the function call
        /// </summary>
        SHUTTLESDK_ERRUNKNOWN = 5
    }

    /// <summary>
    /// Enumerated value encoding the event type returned to the call back from the Contour shuttle driver
    /// </summary>
    public enum EventCode : UInt32
    {
        SHUTTLEEVENTJOGLEFT = 0,
        SHUTTLEEVENTJOGRIGHT = 1,
        SHUTTLEEVENTSHUTTLEL8 = 4,
        SHUTTLEEVENTSHUTTLEL7 = 5,
        SHUTTLEEVENTSHUTTLEL6 = 6,
        SHUTTLEEVENTSHUTTLEL5 = 7,
        SHUTTLEEVENTSHUTTLEL4 = 8,
        SHUTTLEEVENTSHUTTLEL3 = 9,
        SHUTTLEEVENTSHUTTLEL2 = 10,
        SHUTTLEEVENTSHUTTLEL1 = 11,
        SHUTTLEEVENTSHUTTLEC0 = 12,
        SHUTTLEEVENTSHUTTLER1 = 13,
        SHUTTLEEVENTSHUTTLER2 = 14,
        SHUTTLEEVENTSHUTTLER3 = 15,
        SHUTTLEEVENTSHUTTLER4 = 16,
        SHUTTLEEVENTSHUTTLER5 = 17,
        SHUTTLEEVENTSHUTTLER6 = 18,
        SHUTTLEEVENTSHUTTLER7 = 19,
        SHUTTLEEVENTSHUTTLER8 = 20,
        SHUTTLEEVENTSHUTTLETRANL8L7 = 24,
        SHUTTLEEVENTSHUTTLETRANL7L6 = 25,
        SHUTTLEEVENTSHUTTLETRANL6L5 = 26,
        SHUTTLEEVENTSHUTTLETRANL5L4 = 27,
        SHUTTLEEVENTSHUTTLETRANL4L3 = 28,
        SHUTTLEEVENTSHUTTLETRANL3L2 = 29,
        SHUTTLEEVENTSHUTTLETRANL2L1 = 30,
        SHUTTLEEVENTSHUTTLETRANL1C0 = 31,
        SHUTTLEEVENTSHUTTLETRANC0R1 = 32,
        SHUTTLEEVENTSHUTTLETRANR1R2 = 33,
        SHUTTLEEVENTSHUTTLETRANR2R3 = 34,
        SHUTTLEEVENTSHUTTLETRANR3R4 = 35,
        SHUTTLEEVENTSHUTTLETRANR4R5 = 36,
        SHUTTLEEVENTSHUTTLETRANR5R6 = 37,
        SHUTTLEEVENTSHUTTLETRANR6R7 = 38,
        SHUTTLEEVENTSHUTTLETRANR7R8 = 39,
        SHUTTLEEVENTSHUTTLETRANR8R7 = 42,
        SHUTTLEEVENTSHUTTLETRANR7R6 = 43,
        SHUTTLEEVENTSHUTTLETRANR6R5 = 44,
        SHUTTLEEVENTSHUTTLETRANR5R4 = 45,
        SHUTTLEEVENTSHUTTLETRANR4R3 = 46,
        SHUTTLEEVENTSHUTTLETRANR3R2 = 47,
        SHUTTLEEVENTSHUTTLETRANR2R1 = 48,
        SHUTTLEEVENTSHUTTLETRANR1C0 = 49,
        SHUTTLEEVENTSHUTTLETRANC0L1 = 50,
        SHUTTLEEVENTSHUTTLETRANL1L2 = 51,
        SHUTTLEEVENTSHUTTLETRANL2L3 = 52,
        SHUTTLEEVENTSHUTTLETRANL3L4 = 53,
        SHUTTLEEVENTSHUTTLETRANL4L5 = 54,
        SHUTTLEEVENTSHUTTLETRANL5L6 = 55,
        SHUTTLEEVENTSHUTTLETRANL6L7 = 56,
        SHUTTLEEVENTSHUTTLETRANR7L8 = 57,
        SHUTTLEEVENTBUTTON0 = 60,
        SHUTTLEEVENTBUTTON1 = 61,
        SHUTTLEEVENTBUTTON2 = 62,
        SHUTTLEEVENTBUTTON3 = 63,
        SHUTTLEEVENTBUTTON4 = 64,
        SHUTTLEEVENTBUTTON5 = 65,
        SHUTTLEEVENTBUTTON6 = 66,
        SHUTTLEEVENTBUTTON7 = 67,
        SHUTTLEEVENTBUTTON8 = 68,
        SHUTTLEEVENTBUTTON9 = 69,
        SHUTTLEEVENTBUTTON10 = 70,
        SHUTTLEEVENTBUTTON11 = 71,
        SHUTTLEEVENTBUTTON12 = 72,
        SHUTTLEEVENTBUTTON13 = 73,
        SHUTTLEEVENTBUTTON14 = 74,
        SHUTTLEEVENTBUTTON15 = 75
    }

    /// <summary>
    /// Enumerated value which specifies the direction the jog dial was moved.
    /// </summary>
    public enum JogDirection
    {
        /// <summary>
        /// Jog dial is moving left
        /// </summary>
        Left = 0,
        /// <summary>
        /// Jog dial is moving right
        /// </summary>
        Right = 1
    }

    /// <summary>
    /// Enumerated value indication the direction the shuttle knob was moved
    /// </summary>
    public enum ShuttleDirection
    {
        /// <summary>
        /// Shuttle knob is centered
        /// </summary>
        Center = 0,
        /// <summary>
        /// Shuttle knob has moved left
        /// </summary>
        Left = 1,
        /// <summary>
        /// Shuttle knob has moved right
        /// </summary>
        Right = 2
    }
}
