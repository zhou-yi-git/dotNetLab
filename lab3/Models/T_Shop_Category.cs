//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Shop_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Shop_Category()
        {
            this.T_Shop_Product = new HashSet<T_Shop_Product>();
        }
    
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string PicUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Shop_Product> T_Shop_Product { get; set; }
    }
}
