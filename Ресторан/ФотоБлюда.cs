//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ресторан
{
    using System;
    using System.Collections.Generic;
    
    public partial class ФотоБлюда
    {
        public int ИД_фото { get; set; }
        public int ИД_блюда { get; set; }
        public string Фото_ссылка { get; set; }
    
        public virtual Блюдо Блюдо { get; set; }
    }
}
