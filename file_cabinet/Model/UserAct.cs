//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace file_cabinet.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAct
    {
        public int action_id { get; set; }
        public int id_user { get; set; }
        public int id_doc { get; set; }
        public string action { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Users Users { get; set; }
    }
}