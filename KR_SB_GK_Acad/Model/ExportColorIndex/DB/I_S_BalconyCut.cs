//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KR_SB_GK_Acad.Model.ExportColorIndex.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class I_S_BalconyCut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public I_S_BalconyCut()
        {
            this.I_R_Item = new HashSet<I_R_Item>();
        }
    
        public decimal BalconyCutId { get; set; }
        public string BalconyCut { get; set; }
        public Nullable<int> BalconyCutSize { get; set; }
        public Nullable<decimal> SideId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<I_R_Item> I_R_Item { get; set; }
        public virtual I_S_Side I_S_Side { get; set; }
    }
}
