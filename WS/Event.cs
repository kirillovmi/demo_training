//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventTypeId { get; set; }
        public byte MarathonId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<short> MaxParticipants { get; set; }
    }
}
