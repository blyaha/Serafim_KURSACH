//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serafim_KURSACH
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKS
    {
        public int id { get; set; }
        public System.DateTime adddate { get; set; }
        public Nullable<System.DateTime> deletedate { get; set; }
        public string avtor { get; set; }
        public string nazvanie { get; set; }
        public int god { get; set; }
        public bool IsDeleted { get; set; }
        public int price { get; set; }
    }
}
