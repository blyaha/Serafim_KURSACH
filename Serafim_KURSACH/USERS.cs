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
    
    public partial class USERS
    {
        public int id { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public int role { get; set; }
    
        public virtual ROLES ROLES { get; set; }
    }
}
