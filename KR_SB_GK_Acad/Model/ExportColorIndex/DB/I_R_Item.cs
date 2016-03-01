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
    
    public partial class I_R_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public I_R_Item()
        {
            this.I_nn_Item_Series = new HashSet<I_nn_Item_Series>();
            this.I_nn_Item_Tier = new HashSet<I_nn_Item_Tier>();
        }
    
        public decimal ItemId { get; set; }
        public string HandMark { get; set; }
        public Nullable<decimal> ItemGroupId { get; set; }
        public Nullable<short> Lenght { get; set; }
        public Nullable<short> Height { get; set; }
        public Nullable<short> Thickness { get; set; }
        public Nullable<short> Formwork { get; set; }
        public Nullable<short> FormworkMirror { get; set; }
        public string Electrics { get; set; }
        public Nullable<decimal> BalconyDoorId { get; set; }
        public Nullable<decimal> BalconyCutId { get; set; }
        public string Colour { get; set; }
        public string Additional { get; set; }
        public string MosColour { get; set; }
        public string NCS { get; set; }
        public string RAL { get; set; }
        public Nullable<float> Weight { get; set; }
        public Nullable<float> Volume { get; set; }
        public Nullable<int> ArcHeight { get; set; }
        public Nullable<int> ArcWidth { get; set; }
        public string Article1C { get; set; }
        public Nullable<int> Code1C { get; set; }
        public string DocumentLink { get; set; }
        public string ItemCreateDate { get; set; }
        public string ItemModifyDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<I_nn_Item_Series> I_nn_Item_Series { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<I_nn_Item_Tier> I_nn_Item_Tier { get; set; }
        public virtual I_S_BalconyCut I_S_BalconyCut { get; set; }
        public virtual I_S_ItemGroup I_S_ItemGroup { get; set; }
    }
}
