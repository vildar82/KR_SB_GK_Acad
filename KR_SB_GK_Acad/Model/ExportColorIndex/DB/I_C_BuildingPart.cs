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
    
    public partial class I_C_BuildingPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public I_C_BuildingPart()
        {
            this.I_S_ItemGroup = new HashSet<I_S_ItemGroup>();
        }
    
        public decimal BuildingPartId { get; set; }
        public string BuildingPart { get; set; }
        public string BuildingPartText { get; set; }
        public string BuildingPartCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<I_S_ItemGroup> I_S_ItemGroup { get; set; }
    }
}
