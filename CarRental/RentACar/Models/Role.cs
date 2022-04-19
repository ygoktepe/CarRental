﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Models
{
    public class Role
    {
        //ilk kaydı istediğin gibi verebiliyorsun, müşterinin idsini kendisinin girmesini sağlar.
        //4 dilin dördünün de tek class içerisinde yapılmasına Fluent API denir.
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte RoleID { get; set; }

        [Required(ErrorMessage = "{0} Gerekli"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} ,{2}-{1} Karakter olmalı."), Display(Name = "Rol Adı")]
        public string RoleName { get; set; }
    }
}