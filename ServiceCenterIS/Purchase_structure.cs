//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCenterIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase_structure
    {
        public int Id_spares { get; set; }
        public int Id_record { get; set; }
        public int Amount { get; set; }
    
        public virtual Registration_for_the_provision_of_services Registration_for_the_provision_of_services { get; set; }
        public virtual Shares Shares { get; set; }
    }
}