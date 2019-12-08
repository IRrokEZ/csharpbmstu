//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bmstu.IU6.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Settings
    {
        public System.Guid ID { get; set; }
        public System.TimeSpan CycleDuration { get; set; }
        public long ReaderTimerInterval { get; set; }
        public string ModbusIP { get; set; }
        public int ModbusPort { get; set; }
        public byte ModbusDeviceID { get; set; }
        public string UserName { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public long UdpSenderInterval { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> FinishTime { get; set; }
        public int MediaPlayerTimeout { get; set; }
        public int UdpCacheTimeout { get; set; }
        public long DeviceMask { get; set; }
        public int SupportCount { get; set; }
        public int ModbusTimeout { get; set; }
        public int ModbusThreshold { get; set; }
        public int ConveyorTimeout { get; set; }
        public System.TimeSpan ConveyorTime { get; set; }
        public System.TimeSpan LunchStart { get; set; }
        public System.TimeSpan LunchFinish { get; set; }
    }
}