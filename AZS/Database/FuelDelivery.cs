//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AZS.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class FuelDelivery
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int FuelID { get; set; }
        public decimal Volume { get; set; }
    
        public virtual Fuel Fuel { get; set; }
    }
}